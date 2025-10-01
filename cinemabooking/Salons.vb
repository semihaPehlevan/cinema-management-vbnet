Imports System.Data.SqlClient

Public Class Salons

    Public Sub New(showid As Integer, salonid As Integer)
        InitializeComponent()
        Me.ShowId = showid
        Me.SalonId = salonid
    End Sub
    Private ShowId, SalonId As Integer
    Public Shared secilenKoltuklar As New List(Of String)() 'seçilen koltukları tutar
    Dim Ccon As New CGeneral




    Private Sub Salons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SalonId = 1 Then
            Panel1.Visible = True
        ElseIf SalonId = 3 Then
            Panel1.Visible = True
            Panel2.Visible = True
        End If

        Dim satilanKoltuklar As List(Of String) = GetirSatilanKoltuklar(ShowId)
        BoyaKoltuk(satilanKoltuklar)


    End Sub


    Private Function GetirSatilanKoltuklar(showId As Integer) As List(Of String)
        Dim satilanKoltuklar As New List(Of String)

        Using connection As New SqlConnection(Ccon.connection)
            connection.Open()

            Dim command As New SqlCommand("SELECT seat FROM Transactions,Tickets WHERE Transactions.Id = Tickets.transaction_id and show_id = @showid", connection)
            command.Parameters.AddWithValue("@showid", showId)

            Using reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim koltukNo As String = Convert.ToString(reader("seat"))
                    satilanKoltuklar.Add(koltukNo) ' Satılan koltuk numarası listeye eklenir.
                End While
            End Using
        End Using

        Return satilanKoltuklar
    End Function



    Private Sub BoyaKoltuk(satilanKoltuklar As List(Of String))
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso satilanKoltuklar.Contains(ctrl.Tag.ToString()) Then
                Dim btn As Button = DirectCast(ctrl, Button)
                btn.BackColor = Color.IndianRed
                btn.Enabled = False
            End If
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SecKoltuk(Button1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SecKoltuk(Button3)
    End Sub


    Private Sub SecKoltuk(btn As Button) 'Bu olay ile listedeki item sayısı değişecek
        If btn.BackColor = Color.DarkSeaGreen Then
            btn.BackColor = Color.Gold
            secilenKoltuklar.Add(btn.Tag.ToString)
        ElseIf btn.BackColor = Color.Gold Then
            btn.BackColor = Color.DarkSeaGreen
            secilenKoltuklar.Remove(btn.Tag.ToString)
        End If

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SecKoltuk(Button4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SecKoltuk(Button5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SecKoltuk(Button6)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SecKoltuk(Button7)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SecKoltuk(Button2)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SecKoltuk(Button8)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        SecKoltuk(Button9)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        SecKoltuk(Button10)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        SecKoltuk(Button11)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        SecKoltuk(Button12)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        SecKoltuk(Button13)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        SecKoltuk(Button14)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        SecKoltuk(Button15)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        SecKoltuk(Button16)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        SecKoltuk(Button17)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        SecKoltuk(Button18)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        SecKoltuk(Button19)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        SecKoltuk(Button20)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        SecKoltuk(Button21)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        SecKoltuk(Button22)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        SecKoltuk(Button23)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        SecKoltuk(Button24)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        SecKoltuk(Button25)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        SecKoltuk(Button26)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        SecKoltuk(Button27)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        SecKoltuk(Button28)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        SecKoltuk(Button29)
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        SecKoltuk(Button30)
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        SecKoltuk(Button31)
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        SecKoltuk(Button32)
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        SecKoltuk(Button33)
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        SecKoltuk(Button34)
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        SecKoltuk(Button35)
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        SecKoltuk(Button36)
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        SecKoltuk(Button37)
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        SecKoltuk(Button38)
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        SecKoltuk(Button39)
    End Sub



End Class