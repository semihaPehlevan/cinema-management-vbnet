Imports System.Data.SqlClient
Imports WeifenLuo.WinFormsUI.Docking

Public Class ATicket_Step1

    Public Sub New(showid As Integer)
        InitializeComponent()
        Me.ShowId = showid
        GetirShowInformation()
    End Sub
    Public ShowId, SalonId As Integer
    Dim cShow As New CShows


    Private Sub GetirShowInformation()
        cShow.BulShowInformation(ShowId) 'Gösterim ile ilgili bilgiler tutulur.
        SalonId = cShow.SalonId
    End Sub


    Private Sub GetirSalonForm() 'CMainPage getir
        Dim salonsForm As New Salons(ShowId, SalonId)
        salonsForm.TopLevel = False
        salonsForm.FormBorderStyle = FormBorderStyle.None
        salonsForm.Dock = DockStyle.Fill
        DockPanel1.Controls.Add(salonsForm)
        salonsForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Tbuy2 As New ATicket_Step2(ShowId)
        Me.Close()
        Tbuy2.Show()

    End Sub

    Private Sub ATicketSell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetirSalonForm()
    End Sub
End Class