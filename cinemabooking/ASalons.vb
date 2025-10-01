Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ASalons
    Private selectedImagePath As String
    Private con As New SqlConnection("Data Source=DESKTOP-UPQILDP;Initial Catalog=Cinema;Integrated Security=True")
    Private defaultQuery As String = "SELECT * from Salons"
    Private Sub ASalons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BaslatListView()
        YukleVeri()
    End Sub

    Private Sub BaslatListView()
        lvSalons.View = View.Details
        lvSalons.FullRowSelect = True

        lvSalons.Columns.Add("Salon Numarası")
        lvSalons.Columns.Add("Salon Adı")
        lvSalons.Columns.Add("Salon Kapasitesi")


        For Each column As ColumnHeader In lvSalons.Columns
            column.Width = -2
        Next

        AddHandler lvSalons.SelectedIndexChanged, AddressOf lvSalons_SelectedIndexChanged
    End Sub

    Private Sub lvSalons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvSalons.SelectedIndexChanged
        If lvSalons.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvSalons.SelectedItems(0)
            txtId.Text = selectedItem.SubItems(0).Text
            txtName.Text = selectedItem.SubItems(1).Text
            txtCapacity.Text = selectedItem.SubItems(2).Text
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

        lvSalons.Items.Clear()

        For Each row As DataRow In dataTable.Rows
            Dim item As New ListViewItem(row("id").ToString())
            item.SubItems.Add(row("name").ToString())
            item.SubItems.Add(row("capacity").ToString())
            lvSalons.Items.Add(item)
        Next
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim id As String = txtId.Text
        Dim name As String = txtName.Text
        Dim capacity As String = txtCapacity.Text

        Dim query As String = $"UPDATE Salons SET name='{name}', capacity='{capacity}'  WHERE id='{id}'"
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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        Dim query As String = defaultQuery

        If Not String.IsNullOrEmpty(searchText) Then
            query += $" Where Salons.name LIKE '%{searchText}%'"
        End If

        DoldurListView(query)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim id As String = txtId.Text
        Dim query As String = $"DELETE FROM Salons WHERE id='{id}'"

        CalistirQuery(query, "Salon başarıyla silindi.")
        YukleVeri()
    End Sub


End Class