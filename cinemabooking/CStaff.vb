Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView

Public Class CStaff
    Dim _id As Integer
    Dim _username As String
    Dim _pass As String
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
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

    Public Sub BulStaffInformation(ByVal id As Integer)
        Try
            Using connection As New SqlConnection(Ccon.connection)
                connection.Open()

                Dim sDate As DateTime = DateTime.Today
                Dim command As New SqlCommand("SELECT * FROM Admin WHERE id = @id", connection)
                command.Parameters.AddWithValue("@id", id)



                Dim reader As SqlDataReader = command.ExecuteReader()
                Dim seanslar As New List(Of String)

                While reader.Read()
                    id = reader.GetInt32(reader.GetOrdinal("id"))
                    Username = reader.GetString(reader.GetOrdinal("username"))
                    Pass = reader.GetString(reader.GetOrdinal("pass"))

                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub

    Public Sub GuncelleStaffInformation(ByVal id As Integer, ByVal username As String, ByVal pass As String)
        Try
            Using connection As New SqlConnection(Ccon.connection)
                connection.Open()

                Dim command As New SqlCommand("UPDATE Admin SET username = @username, pass = @pass WHERE id = @id", connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@pass", pass)
                command.Parameters.AddWithValue("@id", id)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Personel bilgileri güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Personel bilgileri güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub EkleStaff(ByVal username As String, ByVal pass As String)
        Try
            Using connection As New SqlConnection(Ccon.connection)
                connection.Open()

                Dim command As New SqlCommand("INSERT INTO Admin (username, pass) VALUES (@username, @pass)", connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@pass", pass)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Yeni personel başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Yeni personel eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
