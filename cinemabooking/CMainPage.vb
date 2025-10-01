Imports System.Data.SqlClient

Public Class CMainPage
    Dim Ccon As New CGeneral
    Dim con As New SqlConnection(Ccon.connection)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        YukleMovies()
    End Sub



    Private Sub YukleMovies() 'O gün gösterimi olan filmler
        Try
            Using connection As New SqlConnection(Ccon.connection)
                connection.Open()

                Dim s_date As DateTime = DateTime.Today
                Dim command As New SqlCommand("SELECT DISTINCT Movies.id, Movies.name, Movies.banner FROM Movies INNER JOIN Shows ON Movies.id = Shows.movie_id WHERE Shows.date = @s_date", connection)
                command.Parameters.AddWithValue("@s_date", s_date)

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim filmId As Integer = reader("id")
                    Dim filmAdi As String = reader("name")
                    Dim filmBanner As String = reader("banner")

                    Dim pictureBox As New PictureBox
                    pictureBox.ImageLocation = filmBanner
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                    pictureBox.BorderStyle = BorderStyle.FixedSingle
                    pictureBox.Size = New Size(200, 300)

                    Dim panel As New Panel
                    panel.Size = New Size(300, 300)
                    panel.Controls.Add(pictureBox)

                    If CGeneral.StaffOrClient = 0 Then
                        ' Personel ise
                        Dim seansPanel As New Panel
                        seansPanel.Size = New Size(50, 300)
                        seansPanel.Location = New Point(pictureBox.Right + 1, pictureBox.Top)
                        YukleShowTimes(filmId, seansPanel)
                        panel.Controls.Add(seansPanel)
                    Else
                        ' Müşteri ise
                        AddHandler pictureBox.Click, Sub(sender, e) FilmDetaylariniGoster(filmId)
                    End If

                    FlowLayoutPanel1.Controls.Add(panel)
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub
    Private Sub FilmDetaylariniGoster(ByVal filmId As Integer) 'Müşteri ise
        Dim filmDetayForm As New MovieDetails(filmId)
        filmDetayForm.ShowDialog()
    End Sub
    Private Sub YukleShowTimes(ByVal filmId As Integer, ByVal seansPanel As Panel)
        Try
            Using connection As New SqlConnection(Ccon.connection)
                connection.Open()

                Dim s_date As DateTime = DateTime.Today
                Dim command As New SqlCommand("SELECT date,time FROM Shows WHERE movie_id = @filmId AND date = @s_date", connection)
                command.Parameters.AddWithValue("@filmId", filmId)
                command.Parameters.AddWithValue("@s_date", s_date)

                Dim reader As SqlDataReader = command.ExecuteReader()
                Dim seanslar As New List(Of String)

                While reader.Read()

                    seanslar.Add(reader("time").ToString())

                End While

                Dim yPos As Integer = 0
                For Each seans In seanslar
                    Dim seansButton As New Button
                    seansButton.Text = seans
                    seansButton.Size = New Size(50, 30)
                    seansButton.FlatStyle = FlatStyle.Popup
                    seansButton.Location = New Point(0, yPos)
                    yPos += seansButton.Height + 5
                    AddHandler seansButton.Click, Sub(sender, e) SeansSecildi(filmId, seans)
                    seansPanel.Controls.Add(seansButton)
                Next

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub



    Private Sub SeansSecildi(ByVal filmId As Integer, ByVal showTime As String) '

        Dim cShow As New CShows
        Dim showId As Integer = cShow.BulShowId(filmId, showTime)
        If showId <> -1 Then
            If (CGeneral.StaffOrClient = 0) Then
                Dim ticketsell As New ATicket_Step1(showId) 'Film Id, ShowId
                ticketsell.ShowDialog()
            Else
                Dim filmDetayForm As New MovieDetails(showId)
                filmDetayForm.ShowDialog()
            End If
        End If
    End Sub





End Class
