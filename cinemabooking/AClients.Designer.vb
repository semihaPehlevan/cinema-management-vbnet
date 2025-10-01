<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AClients
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtAtel = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAemail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAlname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAname = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lv_Clients = New System.Windows.Forms.ListView()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(691, 73)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(788, 648)
        Me.TabControl1.TabIndex = 59
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtTel)
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Controls.Add(Me.btnUpdate)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtMail)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtLName)
        Me.TabPage1.Controls.Add(Me.label3)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(780, 610)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Müşteri Detayları"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtTel.Location = New System.Drawing.Point(261, 289)
        Me.txtTel.Mask = "9990000000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(440, 29)
        Me.txtTel.TabIndex = 26
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Goldenrod
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(261, 397)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(194, 40)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "Sil"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(507, 397)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(194, 40)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "Güncelle"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(50, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 22)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Telefon Numarası:"
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtMail.Location = New System.Drawing.Point(261, 205)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(440, 29)
        Me.txtMail.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(50, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(50, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Soyad:"
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtLName.Location = New System.Drawing.Point(261, 127)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(440, 29)
        Me.txtLName.TabIndex = 10
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.label3.Location = New System.Drawing.Point(50, 54)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(44, 22)
        Me.label3.TabIndex = 9
        Me.label3.Text = "Ad:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtName.Location = New System.Drawing.Point(261, 54)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(440, 29)
        Me.txtName.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtAtel)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtAemail)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtAlname)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtAname)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(780, 610)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Müşteri Ekle"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtAtel
        '
        Me.txtAtel.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtAtel.Location = New System.Drawing.Point(273, 272)
        Me.txtAtel.Mask = "9990000000"
        Me.txtAtel.Name = "txtAtel"
        Me.txtAtel.Size = New System.Drawing.Size(440, 29)
        Me.txtAtel.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(50, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 22)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Telefon Numarası:"
        '
        'txtAemail
        '
        Me.txtAemail.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtAemail.Location = New System.Drawing.Point(273, 199)
        Me.txtAemail.Name = "txtAemail"
        Me.txtAemail.Size = New System.Drawing.Size(440, 29)
        Me.txtAemail.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(50, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 22)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(50, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 22)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Soyad:"
        '
        'txtAlname
        '
        Me.txtAlname.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtAlname.Location = New System.Drawing.Point(273, 129)
        Me.txtAlname.Name = "txtAlname"
        Me.txtAlname.Size = New System.Drawing.Size(440, 29)
        Me.txtAlname.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(50, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 22)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Ad:"
        '
        'txtAname
        '
        Me.txtAname.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtAname.Location = New System.Drawing.Point(273, 48)
        Me.txtAname.Name = "txtAname"
        Me.txtAname.Size = New System.Drawing.Size(440, 29)
        Me.txtAname.TabIndex = 44
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(519, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 40)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Ekle"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lv_Clients
        '
        Me.lv_Clients.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lv_Clients.HideSelection = False
        Me.lv_Clients.Location = New System.Drawing.Point(0, 107)
        Me.lv_Clients.Name = "lv_Clients"
        Me.lv_Clients.Size = New System.Drawing.Size(685, 614)
        Me.lv_Clients.TabIndex = 58
        Me.lv_Clients.UseCompatibleStateImageBehavior = False
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label10.Location = New System.Drawing.Point(27, 30)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(176, 25)
        Me.label10.TabIndex = 57
        Me.label10.Text = "Müşteri Arama"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(230, 23)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(363, 32)
        Me.txtSearch.TabIndex = 56
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(230, 61)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(89, 20)
        Me.RadioButton1.TabIndex = 60
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Ad-Soyad"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(341, 61)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(62, 20)
        Me.RadioButton2.TabIndex = 61
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Email"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'AClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1477, 859)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lv_Clients)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "AClients"
        Me.Text = "Müşteriler"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Private WithEvents Label6 As Label
    Private WithEvents btnDelete As Button
    Private WithEvents btnUpdate As Button
    Private WithEvents txtMail As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents Label1 As Label
    Private WithEvents txtLName As TextBox
    Private WithEvents label3 As Label
    Private WithEvents txtName As TextBox
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents Button1 As Button
    Friend WithEvents lv_Clients As ListView
    Private WithEvents label10 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtTel As MaskedTextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents txtAtel As MaskedTextBox
    Private WithEvents Label2 As Label
    Private WithEvents txtAemail As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents Label7 As Label
    Private WithEvents txtAlname As TextBox
    Private WithEvents Label8 As Label
    Private WithEvents txtAname As TextBox
End Class
