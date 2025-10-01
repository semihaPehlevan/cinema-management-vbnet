Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography

Public Class CClient
    Dim _id As Integer
    Dim _name As String
    Dim _lastname As String
    Dim _email As String
    Dim _phone As String
    Dim _pass As String

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
    Public Property Lastname As String
        Get
            Return _lastname
        End Get
        Set(value As String)
            _lastname = value
        End Set
    End Property
    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
    Public Property Phone As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property
    Public Property Pass As String
        Get
            Return _pass
        End Get
        Set(value As String)
            _pass = value
        End Set
    End Property




    Dim Ccon As New CGeneral

    Public Function BulClientInformation(ByVal mail As String) As Integer     'email alsın kayıtlı var mı varsa id geri dönsün

        Dim clientid As String = 0

        Try
            Using connection As New SqlConnection(Ccon.connection)
                connection.Open()

                Dim command As New SqlCommand("SELECT * FROM Clients WHERE email = @mail", connection)
                command.Parameters.AddWithValue("@mail", mail)

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        clientid = reader.GetInt32(reader.GetOrdinal("id"))
                        Id = reader.GetInt32(reader.GetOrdinal("id"))
                        Name = reader.GetString(reader.GetOrdinal("name"))
                        Lastname = reader.GetString(reader.GetOrdinal("lastname"))
                        Email = reader.GetString(reader.GetOrdinal("email"))
                        Phone = reader.GetString(reader.GetOrdinal("phone"))
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try

        Return clientid
    End Function

    Public Sub EkleClient(name As String, lastname As String, email As String, phone As String)
        Try
            Using connection As New SqlConnection(Ccon.connection)
                connection.Open()

                Dim command As New SqlCommand("INSERT INTO Clients (name, lastname, email, phone) VALUES (@name, @lastname, @email, @phone)", connection)
                command.Parameters.AddWithValue("@name", name)
                command.Parameters.AddWithValue("@lastname", lastname)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@phone", phone)

                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub

End Class
