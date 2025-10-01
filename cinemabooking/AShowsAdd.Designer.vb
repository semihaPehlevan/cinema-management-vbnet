<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AShowsAdd
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
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lvShows = New System.Windows.Forms.ListView()
        Me.rb_movie = New System.Windows.Forms.RadioButton()
        Me.rb_salon = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.txtFullSeat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbSalon = New System.Windows.Forms.ComboBox()
        Me.cbMovie = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtEmptySeat = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtpAdate = New System.Windows.Forms.DateTimePicker()
        Me.cbAsalon = New System.Windows.Forms.ComboBox()
        Me.cbAmovie = New System.Windows.Forms.ComboBox()
        Me.txtAemptyseat = New System.Windows.Forms.TextBox()
        Me.txtAprice = New System.Windows.Forms.TextBox()
        Me.txtAtime = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.label10.Location = New System.Drawing.Point(41, 43)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(158, 25)
        Me.label10.TabIndex = 53
        Me.label10.Text = "Seans Arama"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(225, 36)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(339, 32)
        Me.txtSearch.TabIndex = 52
        '
        'lvShows
        '
        Me.lvShows.HideSelection = False
        Me.lvShows.Location = New System.Drawing.Point(1, 118)
        Me.lvShows.Name = "lvShows"
        Me.lvShows.Size = New System.Drawing.Size(737, 636)
        Me.lvShows.TabIndex = 54
        Me.lvShows.UseCompatibleStateImageBehavior = False
        '
        'rb_movie
        '
        Me.rb_movie.AutoSize = True
        Me.rb_movie.Location = New System.Drawing.Point(227, 74)
        Me.rb_movie.Name = "rb_movie"
        Me.rb_movie.Size = New System.Drawing.Size(76, 20)
        Me.rb_movie.TabIndex = 55
        Me.rb_movie.TabStop = True
        Me.rb_movie.Text = "Film Adı"
        Me.rb_movie.UseVisualStyleBackColor = True
        '
        'rb_salon
        '
        Me.rb_salon.AutoSize = True
        Me.rb_salon.Location = New System.Drawing.Point(340, 74)
        Me.rb_salon.Name = "rb_salon"
        Me.rb_salon.Size = New System.Drawing.Size(86, 20)
        Me.rb_salon.TabIndex = 56
        Me.rb_salon.TabStop = True
        Me.rb_salon.Text = "Salon Adı"
        Me.rb_salon.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Tümü", "Aktif", "Eski"})
        Me.ComboBox1.Location = New System.Drawing.Point(583, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 57
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.Location = New System.Drawing.Point(744, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(732, 750)
        Me.TabControl1.TabIndex = 58
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtDate)
        Me.TabPage1.Controls.Add(Me.txtFullSeat)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cbSalon)
        Me.TabPage1.Controls.Add(Me.cbMovie)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtId)
        Me.TabPage1.Controls.Add(Me.txtEmptySeat)
        Me.TabPage1.Controls.Add(Me.txtPrice)
        Me.TabPage1.Controls.Add(Me.txtTime)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.btnDel)
        Me.TabPage1.Controls.Add(Me.btnUpdate)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(724, 712)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Seans Detayları"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtDate.Location = New System.Drawing.Point(261, 261)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(377, 29)
        Me.txtDate.TabIndex = 35
        '
        'txtFullSeat
        '
        Me.txtFullSeat.AllowDrop = True
        Me.txtFullSeat.Enabled = False
        Me.txtFullSeat.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtFullSeat.Location = New System.Drawing.Point(261, 542)
        Me.txtFullSeat.Name = "txtFullSeat"
        Me.txtFullSeat.Size = New System.Drawing.Size(380, 29)
        Me.txtFullSeat.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(106, 549)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 22)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Dolu Koltuk:"
        '
        'cbSalon
        '
        Me.cbSalon.AllowDrop = True
        Me.cbSalon.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.cbSalon.FormattingEnabled = True
        Me.cbSalon.Location = New System.Drawing.Point(261, 196)
        Me.cbSalon.Name = "cbSalon"
        Me.cbSalon.Size = New System.Drawing.Size(377, 30)
        Me.cbSalon.TabIndex = 32
        '
        'cbMovie
        '
        Me.cbMovie.AllowDrop = True
        Me.cbMovie.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.cbMovie.FormattingEnabled = True
        Me.cbMovie.Location = New System.Drawing.Point(261, 131)
        Me.cbMovie.Name = "cbMovie"
        Me.cbMovie.Size = New System.Drawing.Size(377, 30)
        Me.cbMovie.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(105, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 22)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Seans Id:"
        '
        'txtId
        '
        Me.txtId.AllowDrop = True
        Me.txtId.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtId.Location = New System.Drawing.Point(261, 69)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(377, 29)
        Me.txtId.TabIndex = 29
        '
        'txtEmptySeat
        '
        Me.txtEmptySeat.AllowDrop = True
        Me.txtEmptySeat.Enabled = False
        Me.txtEmptySeat.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtEmptySeat.Location = New System.Drawing.Point(261, 466)
        Me.txtEmptySeat.Name = "txtEmptySeat"
        Me.txtEmptySeat.Size = New System.Drawing.Size(377, 29)
        Me.txtEmptySeat.TabIndex = 28
        '
        'txtPrice
        '
        Me.txtPrice.AllowDrop = True
        Me.txtPrice.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtPrice.Location = New System.Drawing.Point(261, 396)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(377, 29)
        Me.txtPrice.TabIndex = 27
        '
        'txtTime
        '
        Me.txtTime.AllowDrop = True
        Me.txtTime.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtTime.Location = New System.Drawing.Point(261, 333)
        Me.txtTime.Mask = "00:00"
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(377, 29)
        Me.txtTime.TabIndex = 26
        Me.txtTime.ValidatingType = GetType(Date)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(105, 473)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 22)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Boş Koltuk:"
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.Goldenrod
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDel.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnDel.Location = New System.Drawing.Point(110, 623)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(244, 40)
        Me.btnDel.TabIndex = 24
        Me.btnDel.Text = "Sil"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.Location = New System.Drawing.Point(379, 623)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(259, 40)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "Güncelle"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(106, 402)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 22)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Fiyat:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(105, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Saat:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(106, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tarih:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(105, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Salon Adı:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.label3.Location = New System.Drawing.Point(105, 142)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(99, 22)
        Me.label3.TabIndex = 9
        Me.label3.Text = "Film Adı:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtpAdate)
        Me.TabPage2.Controls.Add(Me.cbAsalon)
        Me.TabPage2.Controls.Add(Me.cbAmovie)
        Me.TabPage2.Controls.Add(Me.txtAemptyseat)
        Me.TabPage2.Controls.Add(Me.txtAprice)
        Me.TabPage2.Controls.Add(Me.txtAtime)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.btnAdd)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(724, 712)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Seans Oluştur"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dtpAdate
        '
        Me.dtpAdate.Checked = False
        Me.dtpAdate.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.dtpAdate.Location = New System.Drawing.Point(263, 208)
        Me.dtpAdate.Name = "dtpAdate"
        Me.dtpAdate.Size = New System.Drawing.Size(377, 29)
        Me.dtpAdate.TabIndex = 51
        '
        'cbAsalon
        '
        Me.cbAsalon.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.cbAsalon.FormattingEnabled = True
        Me.cbAsalon.Location = New System.Drawing.Point(263, 137)
        Me.cbAsalon.Name = "cbAsalon"
        Me.cbAsalon.Size = New System.Drawing.Size(377, 30)
        Me.cbAsalon.TabIndex = 50
        '
        'cbAmovie
        '
        Me.cbAmovie.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.cbAmovie.FormattingEnabled = True
        Me.cbAmovie.Location = New System.Drawing.Point(263, 63)
        Me.cbAmovie.Name = "cbAmovie"
        Me.cbAmovie.Size = New System.Drawing.Size(377, 30)
        Me.cbAmovie.TabIndex = 49
        '
        'txtAemptyseat
        '
        Me.txtAemptyseat.Enabled = False
        Me.txtAemptyseat.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtAemptyseat.Location = New System.Drawing.Point(263, 451)
        Me.txtAemptyseat.Name = "txtAemptyseat"
        Me.txtAemptyseat.Size = New System.Drawing.Size(377, 29)
        Me.txtAemptyseat.TabIndex = 46
        '
        'txtAprice
        '
        Me.txtAprice.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtAprice.Location = New System.Drawing.Point(263, 369)
        Me.txtAprice.Name = "txtAprice"
        Me.txtAprice.Size = New System.Drawing.Size(377, 29)
        Me.txtAprice.TabIndex = 45
        '
        'txtAtime
        '
        Me.txtAtime.Font = New System.Drawing.Font("Verdana", 10.8!)
        Me.txtAtime.Location = New System.Drawing.Point(263, 288)
        Me.txtAtime.Mask = "00:00"
        Me.txtAtime.Name = "txtAtime"
        Me.txtAtime.Size = New System.Drawing.Size(377, 29)
        Me.txtAtime.TabIndex = 44
        Me.txtAtime.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(105, 458)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 22)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Boş Koltuk:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(105, 376)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 22)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Fiyat:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(105, 295)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 22)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Saat:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(105, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 22)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Tarih:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(105, 145)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 22)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Salon Adı:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(105, 71)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 22)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Film Adı:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.Location = New System.Drawing.Point(407, 533)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(233, 40)
        Me.btnAdd.TabIndex = 36
        Me.btnAdd.Text = "Ekle"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'AShowsAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1477, 859)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.rb_salon)
        Me.Controls.Add(Me.rb_movie)
        Me.Controls.Add(Me.lvShows)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "AShowsAdd"
        Me.Text = "Film Gösterimi Ekle"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label10 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lvShows As ListView
    Friend WithEvents rb_movie As RadioButton
    Friend WithEvents rb_salon As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Private WithEvents btnDel As Button
    Private WithEvents btnUpdate As Button
    Private WithEvents Label5 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label1 As Label
    Private WithEvents label3 As Label
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents btnAdd As Button
    Private WithEvents Label14 As Label
    Private WithEvents Label7 As Label
    Private WithEvents txtId As TextBox
    Private WithEvents txtEmptySeat As TextBox
    Private WithEvents txtPrice As TextBox
    Friend WithEvents txtTime As MaskedTextBox
    Friend WithEvents cbSalon As ComboBox
    Friend WithEvents cbMovie As ComboBox
    Friend WithEvents dtpAdate As DateTimePicker
    Friend WithEvents cbAsalon As ComboBox
    Friend WithEvents cbAmovie As ComboBox
    Private WithEvents txtAemptyseat As TextBox
    Private WithEvents txtAprice As TextBox
    Friend WithEvents txtAtime As MaskedTextBox
    Private WithEvents Label8 As Label
    Private WithEvents Label9 As Label
    Private WithEvents Label11 As Label
    Private WithEvents Label12 As Label
    Private WithEvents Label13 As Label
    Private WithEvents Label15 As Label
    Private WithEvents txtFullSeat As TextBox
    Private WithEvents Label6 As Label
    Friend WithEvents txtDate As DateTimePicker
End Class
