<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AMovies
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lvMovies = New System.Windows.Forms.ListView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.button3 = New System.Windows.Forms.Button()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtype = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtduration = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdirector = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.label10)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 112)
        Me.Panel1.TabIndex = 0
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.label10.Location = New System.Drawing.Point(44, 48)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(140, 25)
        Me.label10.TabIndex = 51
        Me.label10.Text = "Film Arama"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(220, 41)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(312, 32)
        Me.txtSearch.TabIndex = 1
        '
        'lvMovies
        '
        Me.lvMovies.HideSelection = False
        Me.lvMovies.Location = New System.Drawing.Point(0, 115)
        Me.lvMovies.Name = "lvMovies"
        Me.lvMovies.Size = New System.Drawing.Size(746, 614)
        Me.lvMovies.TabIndex = 1
        Me.lvMovies.UseCompatibleStateImageBehavior = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(748, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(731, 728)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.txtId)
        Me.TabPage1.Controls.Add(Me.button3)
        Me.TabPage1.Controls.Add(Me.txtdescription)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtdate)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtype)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtduration)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtdirector)
        Me.TabPage1.Controls.Add(Me.label3)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(723, 690)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detaylar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Goldenrod
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(139, 575)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(241, 40)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Sil"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(28, 648)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(50, 32)
        Me.txtId.TabIndex = 22
        Me.txtId.Visible = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button3.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.button3.Location = New System.Drawing.Point(431, 575)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(241, 40)
        Me.button3.TabIndex = 23
        Me.button3.Text = "Güncelle"
        Me.button3.UseVisualStyleBackColor = False
        '
        'txtdescription
        '
        Me.txtdescription.Font = New System.Drawing.Font("Verdana", 10.2!)
        Me.txtdescription.Location = New System.Drawing.Point(139, 374)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(533, 167)
        Me.txtdescription.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(24, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 22)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Açıklama:"
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtdate.Location = New System.Drawing.Point(408, 291)
        Me.txtdate.Mask = "0000"
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(264, 29)
        Me.txtdate.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(28, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 292)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(254, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 22)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Yayın Tarihi:"
        '
        'txtype
        '
        Me.txtype.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtype.Location = New System.Drawing.Point(408, 219)
        Me.txtype.Name = "txtype"
        Me.txtype.Size = New System.Drawing.Size(264, 29)
        Me.txtype.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(254, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Film Türü:"
        '
        'txtduration
        '
        Me.txtduration.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtduration.Location = New System.Drawing.Point(408, 148)
        Me.txtduration.Mask = "0s 00dk"
        Me.txtduration.Name = "txtduration"
        Me.txtduration.Size = New System.Drawing.Size(264, 29)
        Me.txtduration.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(254, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Süre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(254, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Yönetmen:"
        '
        'txtdirector
        '
        Me.txtdirector.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtdirector.Location = New System.Drawing.Point(408, 84)
        Me.txtdirector.Name = "txtdirector"
        Me.txtdirector.Size = New System.Drawing.Size(264, 29)
        Me.txtdirector.TabIndex = 10
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.label3.Location = New System.Drawing.Point(254, 35)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(99, 22)
        Me.label3.TabIndex = 9
        Me.label3.Text = "Film Adı:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtName.Location = New System.Drawing.Point(408, 28)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(264, 29)
        Me.txtName.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.MaskedTextBox1)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.MaskedTextBox2)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.TextBox5)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.TextBox6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(723, 690)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Film Ekle"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(435, 580)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(241, 40)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Ekle"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Verdana", 10.2!)
        Me.TextBox3.Location = New System.Drawing.Point(143, 378)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(533, 167)
        Me.TextBox3.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(28, 378)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 22)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Açıklama:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.MaskedTextBox1.Location = New System.Drawing.Point(412, 291)
        Me.MaskedTextBox1.Mask = "0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(264, 29)
        Me.MaskedTextBox1.TabIndex = 32
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(32, 32)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 291)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(258, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 22)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Yayın Tarihi:"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.TextBox4.Location = New System.Drawing.Point(412, 223)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(264, 29)
        Me.TextBox4.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(258, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 22)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Film Türü:"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.MaskedTextBox2.Location = New System.Drawing.Point(412, 152)
        Me.MaskedTextBox2.Mask = "0s 00dk"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(264, 29)
        Me.MaskedTextBox2.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(258, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 22)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Süre:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(258, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 22)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Yönetmen:"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.TextBox5.Location = New System.Drawing.Point(412, 88)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(264, 29)
        Me.TextBox5.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(258, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 22)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Film Adı:"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.TextBox6.Location = New System.Drawing.Point(412, 29)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(264, 29)
        Me.TextBox6.TabIndex = 23
        '
        'AMovies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1477, 859)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lvMovies)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AMovies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AMovies"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lvMovies As ListView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents label10 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label1 As Label
    Private WithEvents txtdirector As TextBox
    Private WithEvents label3 As Label
    Private WithEvents txtName As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtdate As MaskedTextBox
    Private WithEvents Label5 As Label
    Private WithEvents txtype As TextBox
    Private WithEvents Label4 As Label
    Friend WithEvents txtduration As MaskedTextBox
    Private WithEvents txtdescription As TextBox
    Private WithEvents Label7 As Label
    Friend WithEvents txtId As TextBox
    Private WithEvents button3 As Button
    Private WithEvents Button1 As Button
    Private WithEvents Button2 As Button
    Private WithEvents TextBox3 As TextBox
    Private WithEvents Label6 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents Label8 As Label
    Private WithEvents TextBox4 As TextBox
    Private WithEvents Label9 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Private WithEvents Label11 As Label
    Private WithEvents Label12 As Label
    Private WithEvents TextBox5 As TextBox
    Private WithEvents Label13 As Label
    Private WithEvents TextBox6 As TextBox
End Class
