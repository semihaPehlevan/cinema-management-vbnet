Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Runtime.InteropServices

Public Class AShowsAdd
    Private con As New SqlConnection("Data Source=DESKTOP-UPQILDP;Initial Catalog=Cinema;Integrated Security=True")
    Private defaultQuery As String = "SELECT Shows.id, Movies.name as mname, Salons.name as sname, date, time, price, emptyseat from Shows, Movies, Salons Where Shows.movie_id=Movies.id and Shows.salon_id=Salons.id"
    Private MovieId As String
    Private AMovieId As String
    Private SalonId As String
    Private ASalonId As String

    Private Sub AShowsAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvShows.Items.Clear()
        BaslatListView()
        YukleVeri()
        BaslatComboBox("Movies", cbMovie, cbAmovie)
        BaslatComboBox("Salons", cbSalon, cbAsalon)

    End Sub
    Public Class ComboBoxIdNameItem
        Public Property Id As String
        Public Property Name As String

        Public Sub New(ByVal id As String, ByVal name As String)
            Me.Id = id
            Me.Name = name
        End Sub

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Private Sub BaslatComboBox(tablename As String, c1 As ComboBox, c2 As ComboBox)
        c1.Items.Clear()
        c2.Items.Clear()

        con.Open()
        Dim query As String = $"SELECT id, name FROM {tablename}"
        Using cmd As New SqlCommand(query, con)
            Using adapter As New SqlDataAdapter(cmd)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                c1.Items.Clear()
                c2.Items.Clear()
                For Each row As DataRow In dataTable.Rows
                    Dim id As String = row("id").ToString()
                    Dim name As String = row("name").ToString()
                    Dim item As New ComboBoxIdNameItem(id, name)

                    c1.Items.Add(item)
                    c2.Items.Add(item)
                Next
            End Using
        End Using
        con.Close()
    End Sub
    Private Sub BaslatListView()
        lvShows.Clear()
        lvShows.View = View.Details
        lvShows.FullRowSelect = True
        lvShows.Columns.Add("Seans Id")
        lvShows.Columns.Add("Film Adı")
        lvShows.Columns.Add("Salon Adı")
        lvShows.Columns.Add("Tarih")
        lvShows.Columns.Add("Saat")
        lvShows.Columns.Add("Fiyat")
        lvShows.Columns.Add("Boş Koltuk")

        For Each column As ColumnHeader In lvShows.Columns
            column.Width = -2
        Next

        AddHandler lvShows.SelectedIndexChanged, AddressOf lvShows_SelectedIndexChanged
    End Sub
    Private Function BiletSatilmdiMi(ByVal showsId As String) As Boolean
        Dim ticketsExist As Boolean = False
        Dim query As String = "SELECT COUNT(*) FROM Transactions WHERE show_id = @showsId"

        Try
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@showsId", showsId)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                If count > 0 Then
                    ticketsExist = True
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        Finally
            con.Close()
        End Try

        Return ticketsExist
    End Function
    Private Function SatilanBiletSayisi(ByVal showsId As String) As Integer
        Dim soldTicketCount As Integer = 0
        Dim query As String = "SELECT COUNT(seat) from Tickets, Transactions where Transactions.Id=Tickets.transaction_id and Transactions.show_id = @showsId"

        Try
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@showsId", showsId)
                soldTicketCount = Convert.ToInt32(command.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        Finally
            con.Close()
        End Try

        Return soldTicketCount
    End Function
    Private Sub lvShows_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvShows.SelectedIndexChanged
        If lvShows.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvShows.SelectedItems(0)
            txtId.Text = selectedItem.SubItems(0).Text
            cbMovie.Text = selectedItem.SubItems(1).Text
            cbSalon.Text = selectedItem.SubItems(2).Text
            txtDate.Text = selectedItem.SubItems(3).Text
            txtTime.Text = selectedItem.SubItems(4).Text
            txtPrice.Text = selectedItem.SubItems(5).Text
            txtEmptySeat.Text = selectedItem.SubItems(6).Text

            Dim showsId As String = selectedItem.SubItems(0).Text
            txtFullSeat.Text = SatilanBiletSayisi(showsId)
            Dim ticketsExist As Boolean = BiletSatilmdiMi(showsId)

            If ticketsExist = True Then
                txtId.Enabled = False
                cbMovie.Enabled = False
                cbSalon.Enabled = False
                txtDate.Enabled = False
                txtTime.Enabled = False
                txtPrice.Enabled = False

            Else
                txtId.Enabled = True
                cbMovie.Enabled = True
                cbSalon.Enabled = True
                txtDate.Enabled = True
                txtTime.Enabled = True
                txtPrice.Enabled = True


            End If


        End If
    End Sub

    Private Sub YukleVeri()
        DoldurListView(defaultQuery)
    End Sub

    Private Sub DoldurListView(ByVal query As String)
        Dim command As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)
        lvShows.Items.Clear()
        For Each row As DataRow In dataTable.Rows
            Dim item As New ListViewItem(row("id").ToString())
            item.SubItems.Add(row("mname").ToString())
            item.SubItems.Add(row("sname").ToString())
            Dim sdate As DateTime = Convert.ToDateTime(row("date"))
            item.SubItems.Add(sdate.ToString("dd/MM/yyyy"))
            item.SubItems.Add(row("time").ToString())
            item.SubItems.Add(row("price").ToString())
            item.SubItems.Add(row("emptyseat").ToString())
            lvShows.Items.Add(item)
        Next
    End Sub

    Private Sub ExecuteQuery(ByVal query As String, ByVal successMessage As String)
        Try
            con.Open()
            Using command As New SqlCommand(query, con)
                Dim rowsUpdated As Integer = command.ExecuteNonQuery()
                MessageBox.Show(successMessage)
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Function SeansVarMi(ByVal salonId As String, ByVal sdate As Date, ByVal stime As String) As Boolean
        Dim seansVar As Boolean = False
        Dim query As String = "SELECT COUNT(*) FROM Shows WHERE salon_id = @salonId AND date = @sdate AND time = @stime"

        Try
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@salonId", salonId)
                command.Parameters.AddWithValue("@sdate", sdate)
                command.Parameters.AddWithValue("@stime", stime)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                If count > 0 Then
                    seansVar = True
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        Finally
            con.Close()
        End Try

        Return seansVar
    End Function
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ssdate As DateTime = dtpAdate.Value
        Dim sdate As String = ssdate.ToString("yyyy-MM-dd")
        Dim stime As String = txtAtime.Text
        Dim sprice As String = txtAprice.Text
        Dim sseat As String = txtAemptyseat.Text
        If SeansVarMi(ASalonId, sdate, stime) Then
            MessageBox.Show("Aynı gün, aynı saat ve aynı salonda başka bir gösterim bulunmaktadır. Lütfen farklı bir tarih veya saat seçin.")
        Else

            Dim query As String = $"INSERT INTO Shows (movie_id, salon_id, date, time, price, emptyseat) VALUES ('{AMovieId}', '{ASalonId}', '{sdate}', '{stime}', '{sprice}', '{sseat}')"
            ExecuteQuery(query, "Yeni seans başarıyla eklendi.")
            AShowsAdd_Load(Nothing, EventArgs.Empty)

        End If

    End Sub

    Private Sub cbAmovie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAmovie.SelectedIndexChanged
        If cbAmovie.SelectedItem IsNot Nothing Then
            AMovieId = DirectCast(cbAmovie.SelectedItem, ComboBoxIdNameItem)?.Id
        End If

    End Sub

    Private Sub cbAsalon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAsalon.SelectedIndexChanged
        If cbAsalon.SelectedItem IsNot Nothing Then
            ASalonId = DirectCast(cbAsalon.SelectedItem, ComboBoxIdNameItem)?.Id
        End If

        CapacityGetir(txtAemptyseat)
    End Sub

    Private Sub CapacityGetir(tb As TextBox)
        Dim query As String = "SELECT capacity FROM Salons WHERE id = @id"

        Try
            con.Open()
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@id", ASalonId)
                Dim capacity As Object = command.ExecuteScalar()
                tb.Text = capacity.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub cbMovie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMovie.SelectedIndexChanged
        If cbMovie.SelectedItem IsNot Nothing Then
            MovieId = DirectCast(cbMovie.SelectedItem, ComboBoxIdNameItem)?.Id
        End If
    End Sub

    Private Sub cbSalon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSalon.SelectedIndexChanged
        If cbSalon.SelectedItem IsNot Nothing Then
            SalonId = DirectCast(cbSalon.SelectedItem, ComboBoxIdNameItem)?.Id
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        If txtId.Enabled = True Then
            Dim ssdate As DateTime = txtDate.Value
            Dim sdate As String = ssdate.ToString("yyyy-MM-dd")
            Dim showsId As String = txtId.Text
            Dim stime As String = txtTime.Text
            Dim sprice As Decimal = Decimal.Parse(txtPrice.Text)
            Dim sseat As String = txtEmptySeat.Text

            Dim query As String = $"UPDATE Shows SET movie_id = '{MovieId}', salon_id = '{SalonId}', date = '{sdate}', time = '{stime}', price = '{sprice}', emptyseat = '{sseat}' WHERE id = '{showsId}'"

            ExecuteQuery(query, "Seans başarıyla güncellendi.")
            AShowsAdd_Load(Nothing, EventArgs.Empty)
        Else
            MessageBox.Show("Bu seansa ait bilet satıldığından bilgiler güncellenemez.")
        End If



    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If txtId.Enabled = True Then
            Dim result As DialogResult = MessageBox.Show("Bu seansı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim showsId As String = txtId.Text
                Dim query As String = "DELETE FROM Shows WHERE id = @id"

                Try
                    con.Open()
                    Using command As New SqlCommand(query, con)
                        command.Parameters.AddWithValue("@id", showsId)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Seans başarıyla silindi.")
                        Else
                            MessageBox.Show("Seans silinirken bir hata oluştu.")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Hata: " & ex.Message)
                Finally
                    con.Close()
                    AShowsAdd_Load(Nothing, EventArgs.Empty)
                End Try
            End If
        Else
            MessageBox.Show("Bu seansa ait bilet satıldığından bilgiler silinemez.")
        End If
    End Sub

    Private Sub FiltreShows()
        Dim filtreQuery As String = defaultQuery

        Select Case ComboBox1.SelectedIndex
            Case 1 ' Aktif
                filtreQuery &= " AND CONVERT(datetime, CONCAT(Shows.date, ' ', Shows.time)) >= CONVERT(datetime, CONVERT(varchar, GETDATE(), 23) + ' ' + '00:00')"
            Case 2 ' Eski
                filtreQuery &= " AND CONVERT(datetime, CONCAT(Shows.date, ' ', Shows.time)) < CONVERT(datetime, CONVERT(varchar, GETDATE(), 23) + ' ' + '00:00')"
            Case Else
                ' Varsayılan durum
        End Select

        If rb_movie.Checked Then
            If Not String.IsNullOrEmpty(txtSearch.Text) Then
                filtreQuery &= $" AND (Movies.name LIKE '%{txtSearch.Text}%')"
                End If
        ElseIf rb_salon.Checked Then
            If Not String.IsNullOrEmpty(txtSearch.Text) Then
                filtreQuery &= $" AND (Salons.name LIKE '%{txtSearch.Text}%')"
            End If
        End If

        DoldurListView(filtreQuery)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FiltreShows()
        If txtSearch.Text = "" Then
            YukleVeri()
        End If

    End Sub

    Private Sub rb_salon_CheckedChanged(sender As Object, e As EventArgs) Handles rb_salon.CheckedChanged
        FiltreShows()
    End Sub

    Private Sub rb_movie_CheckedChanged(sender As Object, e As EventArgs) Handles rb_movie.CheckedChanged
        FiltreShows()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        FiltreShows()
    End Sub
End Class