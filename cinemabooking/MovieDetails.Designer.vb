<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovieDetails))
        Me.lblFilmAdi = New System.Windows.Forms.Label()
        Me.lblYonetmen = New System.Windows.Forms.Label()
        Me.lblSure = New System.Windows.Forms.Label()
        Me.lblTur = New System.Windows.Forms.Label()
        Me.lblYayinTarihi = New System.Windows.Forms.Label()
        Me.pbBanner = New System.Windows.Forms.PictureBox()
        Me.txbAciklama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFilmAdi
        '
        Me.lblFilmAdi.AutoSize = True
        Me.lblFilmAdi.Font = New System.Drawing.Font("Arial Black", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblFilmAdi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblFilmAdi.Location = New System.Drawing.Point(40, 18)
        Me.lblFilmAdi.Name = "lblFilmAdi"
        Me.lblFilmAdi.Size = New System.Drawing.Size(174, 52)
        Me.lblFilmAdi.TabIndex = 0
        Me.lblFilmAdi.Text = "Film Ad"
        '
        'lblYonetmen
        '
        Me.lblYonetmen.AutoSize = True
        Me.lblYonetmen.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYonetmen.Location = New System.Drawing.Point(652, 299)
        Me.lblYonetmen.Name = "lblYonetmen"
        Me.lblYonetmen.Size = New System.Drawing.Size(15, 24)
        Me.lblYonetmen.TabIndex = 1
        Me.lblYonetmen.Text = "-"
        '
        'lblSure
        '
        Me.lblSure.AutoSize = True
        Me.lblSure.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSure.Location = New System.Drawing.Point(652, 175)
        Me.lblSure.Name = "lblSure"
        Me.lblSure.Size = New System.Drawing.Size(15, 24)
        Me.lblSure.TabIndex = 2
        Me.lblSure.Text = "-"
        '
        'lblTur
        '
        Me.lblTur.AutoSize = True
        Me.lblTur.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTur.Location = New System.Drawing.Point(652, 237)
        Me.lblTur.Name = "lblTur"
        Me.lblTur.Size = New System.Drawing.Size(15, 24)
        Me.lblTur.TabIndex = 3
        Me.lblTur.Text = "-"
        '
        'lblYayinTarihi
        '
        Me.lblYayinTarihi.AutoSize = True
        Me.lblYayinTarihi.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinTarihi.Location = New System.Drawing.Point(652, 113)
        Me.lblYayinTarihi.Name = "lblYayinTarihi"
        Me.lblYayinTarihi.Size = New System.Drawing.Size(15, 24)
        Me.lblYayinTarihi.TabIndex = 4
        Me.lblYayinTarihi.Text = "-"
        '
        'pbBanner
        '
        Me.pbBanner.Location = New System.Drawing.Point(105, 146)
        Me.pbBanner.Name = "pbBanner"
        Me.pbBanner.Size = New System.Drawing.Size(217, 345)
        Me.pbBanner.TabIndex = 5
        Me.pbBanner.TabStop = False
        '
        'txbAciklama
        '
        Me.txbAciklama.Enabled = False
        Me.txbAciklama.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txbAciklama.Location = New System.Drawing.Point(459, 392)
        Me.txbAciklama.Multiline = True
        Me.txbAciklama.Name = "txbAciklama"
        Me.txbAciklama.Size = New System.Drawing.Size(701, 133)
        Me.txbAciklama.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(455, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Vizyon Tarihi:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(455, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Süre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(455, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tür:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(455, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Yönetmen:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(455, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Film Konusu:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblFilmAdi)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1186, 89)
        Me.Panel1.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(409, 412)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(40, 559)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 52)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Seanslar"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(49, 630)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(861, 174)
        Me.FlowLayoutPanel1.TabIndex = 16
        '
        'MovieDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1181, 835)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbBanner)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbAciklama)
        Me.Controls.Add(Me.lblYayinTarihi)
        Me.Controls.Add(Me.lblTur)
        Me.Controls.Add(Me.lblSure)
        Me.Controls.Add(Me.lblYonetmen)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MovieDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MovieDetails"
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFilmAdi As Label
    Friend WithEvents lblYonetmen As Label
    Friend WithEvents lblSure As Label
    Friend WithEvents lblTur As Label
    Friend WithEvents lblYayinTarihi As Label
    Friend WithEvents pbBanner As PictureBox
    Friend WithEvents txbAciklama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
