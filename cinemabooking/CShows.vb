Imports System.Data.SqlClient

Public Class CShows
    Dim _id As Integer
    Dim _movieid As Integer
    Dim _salonid As Integer
    Dim _date As DateTime
    Dim _time As String
    Dim _price As Decimal
    Dim _emptyseat As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property MovieId As Integer
        Get
            Return _movieid
        End Get
        Set(value As Integer)
            _movieid = value
        End Set
    End Property
    Public Property SalonId As Integer
        Get
            Return _salonid
        End Get
        Set(value As Integer)
            _salonid = value
        End Set
    End Property
    Public Property ShowDate As DateTime
        Get
            Return _date
        End Get
        Set(value As DateTime)
            _date = value
        End Set
    End Property
    Public Property ShowTime As String
        Get
            Return _time
        End Get
        Set(value As String)
            _time = value
        End Set
    End Property
    Public Property Price As Decimal
        Get
            Return _price
        End Get
        Set(value As Decimal)
            _price = value
        End Set
    End Property
    Public Property EmptySeat As String
        Get
            Return _emptyseat
        End Get
        Set(value As String)
            _emptyseat = value
        End Set
    End Property

    Dim Ccon As New CGeneral
    Public Sub BulShowInformation(ByVal showId As Integer)
        Try
            Using connection As New SqlConnection(Ccon.connection)
                connection.Open()

                Dim sDate As DateTime = DateTime.Today
                Dim command As New SqlCommand("SELECT * FROM Shows WHERE id = @showid", connection)
                command.Parameters.AddWithValue("@showid", showId)



                Dim reader As SqlDataReader = command.ExecuteReader()
                Dim seanslar As New List(Of String)

                While reader.Read()
                    Id = reader.GetInt32(reader.GetOrdinal("id"))
                    MovieId = reader.GetInt32(reader.GetOrdinal("movie_id"))
                    SalonId = reader.GetInt32(reader.GetOrdinal("salon_id"))
                    ShowDate = reader.GetDateTime(reader.GetOrdinal("date"))
                    ShowTime = reader.GetString(reader.GetOrdinal("time"))
                    Price = reader.GetDecimal(reader.GetOrdinal("price"))
                    EmptySeat = reader.GetString(reader.GetOrdinal("emptyseat"))
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub

    Public Function BulShowId(ByVal filmId As Integer, ByVal sTime As String) As Integer
        Try
            Using connection As New SqlConnection(Ccon.connection)
                connection.Open()

                Dim sDate As DateTime = DateTime.Today
                Dim command As New SqlCommand("SELECT * FROM Shows WHERE movie_id = @filmId AND date = @s_date AND time = @s_time", connection)
                command.Parameters.AddWithValue("@filmId", filmId)
                command.Parameters.AddWithValue("@s_date", sDate)
                command.Parameters.AddWithValue("@s_time", sTime)

                Dim reader As SqlDataReader = command.ExecuteReader()
                Dim Id As Integer = -1

                If reader.Read() Then
                    Id = reader.GetInt32(reader.GetOrdinal("id"))
                End If
                reader.Close()

                Return Id
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
            Return -1
        End Try
    End Function

End Class
