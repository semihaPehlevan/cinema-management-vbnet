Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class AMainPage
    Private Sub AMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub FormBring(ByVal frm As Form)
        For Each c As Control In Panel1.Controls
            c.Dispose()
        Next
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        Panel1.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Tbuy As New CMainPage
        FormBring(Tbuy)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim movies As New AMovies()
        FormBring(movies)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim salons As New ASalons()
        FormBring(salons)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim showsAdd As New AShowsAdd()
        FormBring(showsAdd)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim clients As New AClients()
        FormBring(clients)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim tickets As New ATickets()
        FormBring(tickets)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim reports As New AReports()
        FormBring(reports)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim snacksell As New ASnackSell()
        FormBring(snacksell)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim snacks As New ASnacks
        FormBring(snacks)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim settings As New Settings
        FormBring(settings)
    End Sub
End Class