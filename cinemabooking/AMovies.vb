Imports System.Data.SqlClient
Imports System.Net.Sockets
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AMovies
    Private selectedImagePath As String
    Private con As New SqlConnection("Data Source=DESKTOP-UPQILDP;Initial Catalog=Cinema;Integrated Security=True")
    Private defaultQuery As String = "SELECT * from Movies"

    Private Sub AMovies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BaslatListView()
        YukleVeri()
    End Sub

    Private Sub BaslatListView()
        lvMovies.View = View.Details
        lvMovies.FullRowSelect = True

        lvMovies.Columns.Add("Id")
        lvMovies.Columns.Add("Film Adı")
        lvMovies.Columns.Add("Yönetmen")
        lvMovies.Columns.Add("Süre")
        lvMovies.Columns.Add("Kategori")
        lvMovies.Columns.Add("Yayın Tarihi")
        lvMovies.Columns.Add("Afiş")
        lvMovies.Columns.Add("Açıklama")

        For Each column As ColumnHeader In lvMovies.Columns
            column.Width = -2
        Next

        AddHandler lvMovies.SelectedIndexChanged, AddressOf lvMovies_SelectedIndexChanged
    End Sub

    Private Sub lvMovies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvMovies.SelectedIndexChanged
        If lvMovies.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvMovies.SelectedItems(0)
            txtId.Text = selectedItem.SubItems(0).Text
            txtName.Text = selectedItem.SubItems(1).Text
            txtdirector.Text = selectedItem.SubItems(2).Text
            txtduration.Text = selectedItem.SubItems(3).Text
            txtype.Text = selectedItem.SubItems(4).Text
            txtdate.Text = selectedItem.SubItems(5).Text
            selectedImagePath = selectedItem.SubItems(6).Text
            PictureBox1.ImageLocation = selectedItem.SubItems(6).Text
            txtdescription.Text = selectedItem.SubItems(7).Text
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Title = "Resim Seç"
            openFileDialog.Filter = "Resim Dosyaları (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                selectedImagePath = openFileDialog.FileName
                PictureBox1.Image = Image.FromFile(selectedImagePath)
            End If
        End Using
    End Sub

    Private Sub YukleVeri()
        DoldurListView(defaultQuery)
    End Sub

    Private Sub DoldurListView(ByVal query As String)
        Dim command As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        lvMovies.Items.Clear()

        For Each row As DataRow In dataTable.Rows
            Dim item As New ListViewItem(row("id").ToString())
            item.SubItems.Add(row("name").ToString())
            item.SubItems.Add(row("director").ToString())
            item.SubItems.Add(row("duration").ToString())
            item.SubItems.Add(row("type").ToString())
            item.SubItems.Add(row("publishdate").ToString())
            item.SubItems.Add(row("banner").ToString())
            item.SubItems.Add(row("description").ToString())

            lvMovies.Items.Add(item)
        Next
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        selectedImagePath = selectedImagePath.Replace("""", "")
        Dim id As String = txtId.Text
        Dim name As String = txtName.Text
        Dim director As String = txtdirector.Text
        Dim mtime As String = txtduration.Text
        Dim type As String = txtype.Text
        Dim pdate As String = txtdate.Text
        Dim image As String = selectedImagePath
        Dim description As String = txtdescription.Text


        Dim query As String = $"UPDATE Movies SET name='{name}', director='{director}', duration='{mtime}', type='{type}', publishdate='{pdate}', banner='{image}', description='{description}' WHERE id='{id}'"

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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Title = "Resim Seç"
            openFileDialog.Filter = "Resim Dosyaları (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                selectedImagePath = openFileDialog.FileName
                PictureBox2.Image = Image.FromFile(selectedImagePath)
            End If
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        selectedImagePath = selectedImagePath.Replace("""", "")
        Dim id As String = txtId.Text
        Dim name As String = TextBox6.Text
        Dim director As String = TextBox5.Text
        Dim mtime As String = MaskedTextBox2.Text
        Dim type As String = TextBox4.Text
        Dim pdate As String = MaskedTextBox1.Text
        Dim image As String = selectedImagePath
        Dim description As String = TextBox3.Text

        Dim query As String = $"INSERT INTO Movies (name, director, duration, type, publishdate, banner, description) VALUES ( '{name}', '{director}', '{mtime}', '{type}', '{pdate}', '{image}', '{description}')"

        CalistirQuery(query, "Yeni film başarıyla eklendi.")
        YukleVeri()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim id As String = txtId.Text
        Dim query As String = $"DELETE FROM Movies WHERE id='{id}'"

        CalistirQuery(query, "Oda başarıyla silindi.")
        YukleVeri()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        Dim query As String = defaultQuery

        If Not String.IsNullOrEmpty(searchText) Then
            query += $" Where Movies.name LIKE '%{searchText}%'"
        End If

        DoldurListView(query)

    End Sub
End Class