Imports System.Data.SqlClient

Public Class ATicket_Step2

    Public Sub New(showid As Integer)
        InitializeComponent()
        Me.ShowId = showid
    End Sub

    Dim koltuksay As Integer = Salons.secilenKoltuklar.Count
    Dim ShowId As Integer
    Dim price As Decimal
    Dim Ccon As New CGeneral
    Dim cShow As New CShows
    Dim client As New CClient
    Dim cMovie As New Movies
    Dim indirimliSayisi As Integer = 0
    Dim biletutar() As Decimal


    Private Sub ATicket_Step2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetirElemanlar()
        GetirShowBilgi()
        HesapBiletTutar()
    End Sub

    Private Sub HesapBiletTutar() ' Toplam tutar
        Dim indirimliFiyat As Decimal = (indirimliSayisi * price) * 0.4
        Dim fiyat As Decimal = (price * koltuksay) - indirimliFiyat

        TextBox4.Text = fiyat
        TextBox5.Text = koltuksay
        TextBox6.Text = fiyat + koltuksay
    End Sub

    Private Sub GetirShowBilgi()
        cShow.BulShowInformation(ShowId)
        Label7.Text = cMovie.BulMovieInformation(cShow.MovieId)
        Label15.Text = cShow.SalonId
        Label16.Text = cShow.ShowDate
        Label17.Text = cShow.ShowTime
        price = cShow.Price
    End Sub

    Private Sub GetirElemanlar() 'label ve combobox

        Dim labelYukseklik As Integer = 40
        Dim baslangicY As Integer = 50

        For i As Integer = 0 To koltuksay - 1
            Dim koltukLabel As New Label()
            koltukLabel.Text = Salons.secilenKoltuklar(i)
            koltukLabel.Font = New Font("Verdana", 11)
            koltukLabel.AutoSize = True
            koltukLabel.Location = New Point(10, baslangicY + (i * labelYukseklik))
            GroupBox3.Controls.Add(koltukLabel)

            Dim koltukComboBox As New ComboBox()
            koltukComboBox.Items.AddRange(New String() {"Tam", "İndirimli"})
            koltukComboBox.DropDownStyle = ComboBoxStyle.DropDownList
            koltukComboBox.Font = New Font("Verdana", 11)
            koltukComboBox.SelectedIndex = 0
            koltukComboBox.Name = Salons.secilenKoltuklar(i) 'seçilen koltukları tutan liste
            koltukComboBox.Size = New Size(160, 33)
            koltukComboBox.Location = New Point(80, baslangicY + (i * labelYukseklik) - 3)
            AddHandler koltukComboBox.SelectedIndexChanged, AddressOf ComboBox_SelectedIndexChanged 'combobox index değişince
            GroupBox3.Controls.Add(koltukComboBox)
        Next
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

        Dim comboBox As ComboBox = DirectCast(sender, ComboBox)
        If comboBox.SelectedItem IsNot Nothing AndAlso comboBox.SelectedItem.ToString() = "İndirimli" Then
            indirimliSayisi += 1
        Else
            indirimliSayisi -= 1
        End If

        HesapBiletTutar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If client.BulClientInformation(TextBox3.Text) Then
            OlusturBilet()
            SatBilet()
            Me.Close()
        Else
            client.EkleClient(TextBox1.Text, TextBox2.Text, TextBox3.Text, MaskedTextBox1.Text)
            client.BulClientInformation(TextBox3.Text)
            OlusturBilet()
            SatBilet()
            Me.Close()
        End If


    End Sub

    Public transactionId As Integer

    Private Sub OlusturBilet()
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And MaskedTextBox1.Text <> "" Then
            Try
                Using connection As New SqlConnection(Ccon.connection)
                    connection.Open()
                    Dim updateCommand As New SqlCommand("INSERT INTO Transactions (show_id, ticketdate, totalprice, client_id) VALUES (@showId, @ticketdate, @totalprice, @clientId); SELECT SCOPE_IDENTITY();", connection)
                    updateCommand.Parameters.AddWithValue("@showId", ShowId)
                    updateCommand.Parameters.AddWithValue("@ticketdate", DateTime.Now)
                    updateCommand.Parameters.AddWithValue("@totalprice", Decimal.Parse(TextBox6.Text))
                    updateCommand.Parameters.AddWithValue("@clientId", client.Id)

                    transactionId = Convert.ToInt32(updateCommand.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("Hata: " & ex.Message)
            End Try
        End If
    End Sub


    Private Sub SatBilet()
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And MaskedTextBox1.Text <> "" Then
            Try
                Using connection As New SqlConnection(Ccon.connection)
                    connection.Open()
                    For Each control As Control In GroupBox3.Controls 'controller içinden groupbox3 controllerine erişme
                        If TypeOf control Is ComboBox Then 'groupbox3 içindeki control combobox ise
                            Dim comboBox As ComboBox = DirectCast(control, ComboBox) ' bulunan controlu combobox türüne çevir
                            Dim koltuk As String = comboBox.Name 'ismi listedeki koltuk numarasına göre verilmişti
                            Dim tariff As String = If(comboBox.SelectedItem IsNot Nothing, comboBox.SelectedItem.ToString(), "")
                            Dim fiyat As Decimal = price
                            If tariff = "İndirimli" Then
                                fiyat *= 0.4
                            End If
                            Dim command As New SqlCommand("INSERT INTO Tickets (transaction_id, seat, price, tariff) VALUES (@transactionId, @seat, @price, @tariff)", connection)
                            command.Parameters.AddWithValue("@transactionId", transactionId)
                            command.Parameters.AddWithValue("@seat", koltuk)
                            command.Parameters.AddWithValue("@price", fiyat)
                            command.Parameters.AddWithValue("@tariff", tariff)
                            command.ExecuteNonQuery()
                        End If
                    Next
                    ' Shows tablosundaki emptyseat güncellemesi
                    Dim updateCommand As New SqlCommand("UPDATE Shows SET emptyseat = emptyseat - @soldSeats WHERE id = @show_id", connection)
                    updateCommand.Parameters.AddWithValue("@soldSeats", koltuksay)
                    updateCommand.Parameters.AddWithValue("@show_id", ShowId)
                    updateCommand.ExecuteNonQuery()
                    MessageBox.Show("Biletler başarıyla kaydedildi.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Hata: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ATicket_Step2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Salons.secilenKoltuklar.Clear()
    End Sub
End Class