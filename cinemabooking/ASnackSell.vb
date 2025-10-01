Imports System.Data.SqlClient
Imports WeifenLuo.WinFormsUI.Docking

Public Class ASnackSell

    Dim Ccon As New CGeneral
    Dim FaturaId As Integer

    Private Sub BaslatListView() 'Listview sütunlarını tanımlama
        ListView1.Columns.Clear()
        ListView1.View = View.Details
        ListView1.FullRowSelect = True

        ListView1.Columns.Add("Id")
        ListView1.Columns.Add("Atıştırmalık Adı")
        ListView1.Columns.Add("Adet")
        ListView1.Columns.Add("Toplam Fiyat")

        For Each column As ColumnHeader In ListView1.Columns
            column.Width = -2
        Next

        AddHandler ListView1.SelectedIndexChanged, AddressOf ListView1_SelectedIndexChanged
        AddHandler ListView1.MouseDoubleClick, AddressOf ListView1_MouseDoubleClick
    End Sub

    Private Sub YukleSnacks() ' Atıştırmalıkları buton olarak görüntüleme
        Try
            Using connection As New SqlConnection(Ccon.connection)
                connection.Open()

                Dim command As New SqlCommand("Select Id, Name, Price, Quantity from Snacks Where Quantity != '0'", connection)

                Dim reader As SqlDataReader = command.ExecuteReader()

                Dim sutunsay As Integer = 3
                Dim sutun As Integer = 0
                Dim satir As Integer = 0
                Dim buttongenislikh As Integer = 170
                Dim buttonuzunluk As Integer = 86
                Dim bosluk As Integer = 20

                While reader.Read()
                    Dim snackId As Integer = reader("Id")
                    Dim snackName As String = reader("Name")
                    Dim snackPrice As Decimal = reader("Price")
                    Dim snackQuantity As String = reader("Quantity")

                    Dim button As New Button

                    button.Text = snackName & vbCrLf & "Fiyat: " & snackPrice.ToString & vbCrLf & "Adet: " & snackQuantity
                    button.Size = New Size(buttongenislikh, buttonuzunluk)
                    button.Location = New Point((buttongenislikh + bosluk) * sutun, (buttonuzunluk + bosluk) * satir)
                    button.FlatStyle = FlatStyle.Flat
                    button.Font = New Font("Verdana", 11)
                    button.Tag = New With {.Id = snackId, .Name = snackName, .Price = snackPrice}



                    DockPanel1.Controls.Add(button)
                    AddHandler button.Click, AddressOf SnackButton_Click

                    sutun += 1
                    If sutun >= sutunsay Then
                        sutun = 0
                        satir += 1
                    End If
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub

    Private Sub SnackButton_Click(sender As Object, e As EventArgs) 'Butonlar tıkladığında ürün ekleme
        Dim button As Button = CType(sender, Button)
        Dim snackBilgi = CType(button.Tag, Object)
        Dim snackName As String = snackBilgi.Name
        Dim snackId As Integer = snackBilgi.Id
        Dim snackPrice As Decimal = snackBilgi.Price

        Dim snackVarMi As Boolean = False

        For Each item As ListViewItem In ListView1.Items
            If item.Text = snackId Then

                Dim varolanadet As Integer = Integer.Parse(item.SubItems(2).Text)
                Dim varolantutar As Decimal = Decimal.Parse(item.SubItems(3).Text)

                item.SubItems(2).Text = (varolanadet + 1).ToString()
                item.SubItems(3).Text = (varolantutar + snackPrice).ToString("F2")
                snackVarMi = True
                Exit For
            End If
        Next

        If Not snackVarMi Then
            Dim yeniItem As New ListViewItem(snackId)
            yeniItem.SubItems.Add(snackName)
            yeniItem.SubItems.Add("1")
            yeniItem.SubItems.Add(snackPrice.ToString("F2"))
            ListView1.Items.Add(yeniItem)
        End If

        Label2.Text = HesaplaTotalPrice()

    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) 'Adet azaltma
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim varolanadet As Integer = Integer.Parse(selectedItem.SubItems(2).Text)
            Dim varolantutar As Decimal = Decimal.Parse(selectedItem.SubItems(3).Text)
            Dim snackPrice As Decimal

            For Each item As ListViewItem In ListView1.Items
                If item.Text = selectedItem.Text Then
                    snackPrice = varolantutar / varolanadet 'birim fiyat bulma
                    Exit For
                End If
            Next

            If varolanadet > 1 Then
                selectedItem.SubItems(2).Text = (varolanadet - 1).ToString()
                selectedItem.SubItems(3).Text = (varolantutar - snackPrice).ToString("F2")
            Else
                ListView1.Items.Remove(selectedItem)
            End If
        End If
        Label2.Text = HesaplaTotalPrice()
    End Sub

    Public Function HesaplaTotalPrice() As String 'Toplam tutar hesaplama
        Dim totalPrice As Decimal = 0

        For Each item As ListViewItem In ListView1.Items
            Dim tutar As Decimal = item.SubItems(3).Text
            Dim snackTutar As Decimal = Decimal.Parse(tutar)
            totalPrice += snackTutar
        Next

        Return totalPrice.ToString()
    End Function

    Public Sub EklePayments(price As Decimal) 'Payments tablosunda fatura kaydı açar.
        Try
            Using connection As New SqlConnection(Ccon.connection)
                connection.Open()

                Dim command As New SqlCommand("INSERT INTO Payments (Total, Date) VALUES (@total, @date);  SELECT SCOPE_IDENTITY();", connection)
                command.Parameters.AddWithValue("@total", price)
                command.Parameters.AddWithValue("@date", Date.Now)

                FaturaId = Convert.ToInt32(command.ExecuteScalar()) 'Eklenen faturanın id değeri

            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub

    Public Sub EklePaymentsDetailsVeGuncelleSnacks() 'PaymentsDetails tablosuna satın alınan ürünleri ekleme
        Try
            Using connection As New SqlConnection(Ccon.connection)
                connection.Open()

                For Each item As ListViewItem In ListView1.Items
                    Dim command As New SqlCommand("INSERT INTO PaymentsDetails (Sellid, Snackid, Price, Quantity) VALUES (@sellid, @snackid, @price, @quantity);", connection)
                    command.Parameters.AddWithValue("@sellid", FaturaId)
                    command.Parameters.AddWithValue("@snackid", Convert.ToInt32(item.SubItems(0).Text))
                    command.Parameters.AddWithValue("@price", Convert.ToDecimal(item.SubItems(3).Text))
                    command.Parameters.AddWithValue("@quantity", item.SubItems(2).Text)

                    command.ExecuteNonQuery()

                    Dim command2 As New SqlCommand("UPDATE Snacks SET Quantity -= @sellquan  WHERE Id = @id", connection)
                    command2.Parameters.AddWithValue("id", Convert.ToInt32(item.SubItems(0).Text))
                    command2.Parameters.AddWithValue("sellquan", Convert.ToInt32(item.SubItems(2).Text))

                    command2.ExecuteNonQuery()

                Next


            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Satış işlemi

        EklePayments(Convert.ToDecimal(Label2.Text))
        EklePaymentsDetailsVeGuncelleSnacks()
        MessageBox.Show("Satıldı")
        YukleSnacks()
        SnackSell_Load(Nothing, EventArgs.Empty)
        ListView1.Items.Clear()
    End Sub

    Private Sub SnackSell_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Sayfa yüklenince
        BaslatListView()
        YukleSnacks()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged



    End Sub

    Private Sub DockPanel1_ActiveContentChanged(sender As Object, e As EventArgs)

    End Sub
End Class
