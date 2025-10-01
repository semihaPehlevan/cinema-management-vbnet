Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView

Public Class Movies

    Private _id As Integer
    Private _name As String
    Private _director As String
    Private _duration As String
    Private _type As String
    Private _publishdate As String
    Private _banner As String
    Private _description As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Director As String
        Get
            Return _director
        End Get
        Set(value As String)
            _director = value
        End Set
    End Property

    Public Property Duration As String
        Get
            Return _duration
        End Get
        Set(value As String)
            _duration = value
        End Set
    End Property

    Public Property Type As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property

    Public Property PubDate As String
        Get
            Return _publishdate
        End Get
        Set(value As String)
            _publishdate = value
        End Set
    End Property

    Public Property Banner As String
        Get
            Return _banner
        End Get
        Set(value As String)
            _banner = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Dim Ccon As New CGeneral

    Public Function BulMovieInformation(ByVal movieId As Integer) As String
        Dim movieName As String = ""

        Try
            Using connection As New SqlConnection(Ccon.connection)
                connection.Open()

                Dim command As New SqlCommand("SELECT * FROM Movies WHERE id = @movieid", connection)
                command.Parameters.AddWithValue("@movieid", movieId)

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Id = reader.GetInt32(reader.GetOrdinal("id"))
                        movieName = reader.GetString(reader.GetOrdinal("name"))
                        Director = reader.GetString(reader.GetOrdinal("director"))
                        Duration = reader.GetString(reader.GetOrdinal("duration"))
                        Type = reader.GetString(reader.GetOrdinal("type"))
                        PubDate = reader.GetString(reader.GetOrdinal("publishdate"))
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try

        Return movieName
    End Function


End Class
