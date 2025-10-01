Imports System.Data.SqlClient

Public Class Register
    Dim con As New SqlConnection("Data Source=DESKTOP-UPQILDP;Initial Catalog=Cinema;Integrated Security=True")
    Dim Ccon As CGeneral


    'Giriş ve çıkışları kontrol ederken 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton2.Checked Then
            Dim cmd As New SqlCommand("select * from Clients where email = '" & TextBox1.Text & "' and pass = '" & TextBox2.Text & "'", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)

            If ds.Tables(0).Rows.Count <> 0 Then
                CGeneral.StaffOrClient = 1
                Me.Hide()
                Dim dh As New CMainPage()
                dh.ShowDialog()
            Else
                MessageBox.Show("Hatalı Email adresi veya Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
        If RadioButton1.Checked Then
            Dim cmd As New SqlCommand("select id from Admin where username = '" & TextBox1.Text & "' and pass = '" & TextBox2.Text & "'", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)

            If ds.Tables(0).Rows.Count <> 0 Then
                CGeneral.StaffOrClient = 0
                CGeneral.staffId = Convert.ToInt32(ds.Tables(0).Rows(0)("id"))
                Me.Hide()
                Dim dh As New AMainPage()
                dh.ShowDialog()
            Else
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub
End Class