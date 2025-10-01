Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ASnacks

    Private defaultQuery As String = "SELECT * from Snacks"
    Dim Ccon As New CGeneral
    Dim snackId As Integer
    Dim con As New SqlConnection(Ccon.connection)

    Private Sub ASnacks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BaslatListView()
        YukleVeri()
    End Sub

    Private Sub BaslatListView()
        lvSnacks.View = View.Details
        lvSnacks.FullRowSelect = True

        lvSnacks.Columns.Add("Id")
        lvSnacks.Columns.Add("Ad")
        lvSnacks.Columns.Add("Fiyat")
        lvSnacks.Columns.Add("Adet")
        lvSnacks.Columns.Add("Açıklama")



        For Each column As ColumnHeader In lvSnacks.Columns
            column.Width = 90
        Next

        AddHandler lvSnacks.SelectedIndexChanged, AddressOf lvSnacks_SelectedIndexChanged
    End Sub

    Private Sub lvSnacks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvSnacks.SelectedIndexChanged
        If lvSnacks.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvSnacks.SelectedItems(0)
            snackId = selectedItem.SubItems(0).Text
            txtName.Text = selectedItem.SubItems(1).Text
            txtprice.Text = selectedItem.SubItems(2).Text
            txtquan.Text = selectedItem.SubItems(3).Text
            txtdes.Text = selectedItem.SubItems(4).Text
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

        lvSnacks.Items.Clear()

        For Each row As DataRow In dataTable.Rows
            Dim item As New ListViewItem(row("Id").ToString())
            item.SubItems.Add(row("Name").ToString())
            item.SubItems.Add(row("Price").ToString())
            item.SubItems.Add(row("Quantity").ToString())
            item.SubItems.Add(row("Description").ToString())

            ' Stok miktarını kontrol edip kırmızıya boyama
            Dim quantity As Integer = Convert.ToInt32(row("Quantity"))
            If quantity <= 15 Then
                For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                    subItem.BackColor = Color.IndianRed
                Next
            End If

            lvSnacks.Items.Add(item)
        Next
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim id As String = snackId
        Dim query As String = $"DELETE FROM Snacks WHERE Id='{id}'"

        CalistirQuery(query, "Atıştırmalık başarıyla silindi.")
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim name As String = txtName.Text
        Dim price As String = txtprice.Text
        Dim quan As String = txtquan.Text
        Dim des As String = txtdes.Text

        Dim query As String = $"UPDATE Snacks SET Name='{name}', Price='{price}', Quantity='{quan}', Description='{des}'  WHERE Id='{snackId}'"

        CalistirQuery(query, "Bilgiler başarıyla güncellendi.")
        YukleVeri()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = TextBox5.Text
        Dim price As String = TextBox3.Text
        Dim quan As String = TextBox4.Text
        Dim des As String = TextBox2.Text

        Dim query As String = $"INSERT INTO Snacks (Name, Price, Quantity, Description) VALUES ( '{name}', '{price}', '{quan}', '{des}')"

        CalistirQuery(query, "Yeni atıştırmalık başarıyla eklendi.")
        YukleVeri()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MessageBox.Show("İndirim yapmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            con.Open()

            Dim indirimoran As Decimal = Convert.ToDecimal(TextBox1.Text) / 100.0

            Dim query As String = "UPDATE Snacks SET Price = Price * (1 - @indirimoran)"
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@indirimoran", indirimoran)
                Dim rowsUpdated As Integer = command.ExecuteNonQuery()
            End Using

            con.Close()

            YukleVeri()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("Zam yapmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            con.Open()

            Dim zamoran As Decimal = Convert.ToDecimal(TextBox1.Text) / 100.0

            Dim query As String = "UPDATE Snacks SET Price = Price * (1 + @zamoran)"
            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@zamoran", zamoran)
                Dim rowsUpdated As Integer = command.ExecuteNonQuery()
            End Using

            con.Close()

            YukleVeri()
        End If
    End Sub
End Class