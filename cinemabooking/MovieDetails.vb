Imports System.Data.SqlClient

Public Class MovieDetails
    Dim connectionString As String = "Data Source=DESKTOP-UPQILDP;Initial Catalog=Cinema;Integrated Security=True" ' Veritabanı bağlantı dizesi
    Dim connection As New SqlConnection(connectionString)
    Private filmId As Integer
    Public Sub New(ByVal filmId As Integer)
        InitializeComponent()
        Me.filmId = filmId
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim command As New SqlCommand("SELECT * FROM movies WHERE id = @MovieId", connection)
                command.Parameters.AddWithValue("@MovieId", filmId)
                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    lblFilmAdi.Text = reader("name").ToString()
                    lblYonetmen.Text = reader("director").ToString()
                    lblSure.Text = reader("duration").ToString()
                    lblTur.Text = reader("type").ToString()
                    lblYayinTarihi.Text = reader("publishdate")
                    txbAciklama.Text = reader("description")

                    pbBanner.ImageLocation = reader("banner").ToString()
                    pbBanner.SizeMode = PictureBoxSizeMode.StretchImage
                End If

                reader.Close()


            End Using

        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub


    Private Sub MovieDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim command As New SqlCommand("SELECT Shows.id, Shows.movie_id, Shows.salon_id, Shows.date, Shows.time, Shows.price, Shows.emptyseat FROM Shows INNER JOIN Movies ON Shows.movie_id = Movies.id WHERE Shows.movie_id = @movieid", connection)
                command.Parameters.AddWithValue("movieid", filmId)
                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim filmId As Integer = reader("id")
                    Dim filmgun As String = reader("date")
                    Dim filmsaat As String = reader("time")

                    Dim button As New Button
                    button.Text = filmgun + " " + filmsaat
                    button.FlatStyle = FlatStyle.Popup
                    button.Size = New Size(100, 100)
                    FlowLayoutPanel1.Controls.Add(button)
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub
End Class