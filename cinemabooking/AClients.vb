Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AClients
    Private con As New SqlConnection("Data Source=DESKTOP-UPQILDP;Initial Catalog=Cinema;Integrated Security=True")
    Private defaultQuery As String = "SELECT * from Clients"
    Dim clientId As String
    Private Sub AClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BaslatListView()
        YukleVeri()
    End Sub
    Private Sub lvSalons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_Clients.SelectedIndexChanged
        If lv_Clients.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lv_Clients.SelectedItems(0)
            clientId = selectedItem.SubItems(0).Text
            txtName.Text = selectedItem.SubItems(1).Text
            txtLName.Text = selectedItem.SubItems(2).Text
            txtMail.Text = selectedItem.SubItems(3).Text
            txtTel.Text = selectedItem.SubItems(4).Text
        End If
    End Sub

    Private Sub BaslatListView()
        lv_Clients.View = View.Details
        lv_Clients.FullRowSelect = True

        lv_Clients.Columns.Add("Id")
        lv_Clients.Columns.Add("Ad")
        lv_Clients.Columns.Add("Soyad")
        lv_Clients.Columns.Add("Email")
        lv_Clients.Columns.Add("Telefon Numarası")
        lv_Clients.Columns.Add("Şifre")


        For Each column As ColumnHeader In lv_Clients.Columns
            column.Width = 90
        Next

        AddHandler lv_Clients.SelectedIndexChanged, AddressOf lvSalons_SelectedIndexChanged
    End Sub

    Private Sub YukleVeri()
        DoldurListView(defaultQuery)
    End Sub

    Private Sub DoldurListView(ByVal query As String)
        Dim command As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        lv_Clients.Items.Clear()

        For Each row As DataRow In dataTable.Rows
            Dim item As New ListViewItem(row("id").ToString())
            item.SubItems.Add(row("name").ToString())
            item.SubItems.Add(row("lastname").ToString())
            item.SubItems.Add(row("email").ToString())
            item.SubItems.Add(row("phone").ToString())
            item.SubItems.Add(row("pass").ToString())

            lv_Clients.Items.Add(item)
        Next
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim name As String = txtName.Text
        Dim lname As String = txtLName.Text
        Dim email As String = txtMail.Text
        Dim phone As String = txtTel.Text

        Dim query As String = $"UPDATE Clients SET name='{name}', lastname='{lname}', email='{email}', phone='{phone}'   WHERE id='{clientId}'"

        CalistirQuery(query, "Bilgiler başarıyla güncellendi.")
        YukleVeri()
    End Sub

    Private Sub CalistirQuery(ByVal query As String, ByVal successMessage As String)
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim id As String = clientId
        Dim query As String = $"DELETE FROM Clients WHERE id='{id}'"

        CalistirQuery(query, "Müşteri başarıyla silindi.")
        YukleVeri()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = txtAname.Text
        Dim lname As String = txtAlname.Text
        Dim email As String = txtAemail.Text
        Dim tel As String = txtAtel.Text

        Dim query As String = $"INSERT INTO Clients (name, lastname, email, phone) VALUES ( '{name}', '{lname}', '{email}', '{tel}')"

        CalistirQuery(query, "Yeni kullanıcı başarıyla eklendi.")
        YukleVeri()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
            AraClients(txtSearch.Text)
        Else
            YukleClientsVeri()
        End If

    End Sub

    Private Sub AraClients(ByVal searchText As String)
        Dim query As String = "SELECT id, name, lastname, email, phone, pass FROM Clients WHERE name LIKE '%' + @name + '%'"
        query += " OR CONCAT(name, ' ', lastname) LIKE '%' + @name + '%'"
        Dim command As New SqlCommand(query, con)
        command.Parameters.AddWithValue("@name", searchText)

        If RadioButton2.Checked Then
            query = "SELECT id, name, lastname, email, phone, pass FROM Clients WHERE email LIKE '%' + @email + '%'"
            command = New SqlCommand(query, con)
            command.Parameters.AddWithValue("@email", searchText)
        End If

        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        lv_Clients.Items.Clear()

        For Each row As DataRow In dataTable.Rows
            Dim item As New ListViewItem(row("id").ToString())
            item.SubItems.Add(row("name").ToString())
            item.SubItems.Add(row("lastname").ToString())
            item.SubItems.Add(row("email").ToString())
            item.SubItems.Add(row("phone").ToString())
            item.SubItems.Add(row("pass").ToString())
            lv_Clients.Items.Add(item)
        Next
    End Sub
    Private Sub YukleClientsVeri()

        Dim adapter As New SqlDataAdapter(defaultQuery, con)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        lv_Clients.Items.Clear()

        For Each row As DataRow In dataTable.Rows
            Dim item As New ListViewItem(row("id").ToString())
            item.SubItems.Add(row("name").ToString())
            item.SubItems.Add(row("lastname").ToString())
            item.SubItems.Add(row("email").ToString())
            item.SubItems.Add(row("phone").ToString())
            item.SubItems.Add(row("pass").ToString())
            lv_Clients.Items.Add(item)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class