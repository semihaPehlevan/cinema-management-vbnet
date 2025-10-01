Public Class Settings
    Dim Ccon As New CGeneral
    Dim staff As New CStaff
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        staff.BulStaffInformation(CGeneral.staffId)
        TextBox1.Text = CGeneral.staffId
        TextBox2.Text = staff.Username
        TextBox3.Text = staff.Pass

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        staff.GuncelleStaffInformation(CGeneral.staffId, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        staff.EkleStaff(TextBox5.Text, TextBox4.Text)
    End Sub
End Class