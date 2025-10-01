<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ATickets
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
        Me.lv_Ticket = New System.Windows.Forms.ListView()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lv_tickets = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lv_Ticket
        '
        Me.lv_Ticket.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lv_Ticket.HideSelection = False
        Me.lv_Ticket.Location = New System.Drawing.Point(3, 66)
        Me.lv_Ticket.Name = "lv_Ticket"
        Me.lv_Ticket.Size = New System.Drawing.Size(846, 618)
        Me.lv_Ticket.TabIndex = 59
        Me.lv_Ticket.UseCompatibleStateImageBehavior = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.Location = New System.Drawing.Point(39, 96)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(99, 22)
        Me.label3.TabIndex = 10
        Me.label3.Text = "Film Adı:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Salon Adı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Gösterim Tarih/Saat:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 22)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Bilet Kesim Tarihi:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Adı Soyadı:"
        '
        'lv_tickets
        '
        Me.lv_tickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lv_tickets.HideSelection = False
        Me.lv_tickets.Location = New System.Drawing.Point(160, 435)
        Me.lv_tickets.Name = "lv_tickets"
        Me.lv_tickets.Size = New System.Drawing.Size(428, 162)
        Me.lv_tickets.TabIndex = 61
        Me.lv_tickets.UseCompatibleStateImageBehavior = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 435)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 22)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Biletler:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(318, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 22)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(318, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 22)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(318, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 22)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(318, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 22)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(318, 291)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 22)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 362)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 22)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Toplam Tutar:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(318, 362)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 22)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "-"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(855, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(620, 652)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lv_tickets)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Font = New System.Drawing.Font("Verdana", 10.2!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(612, 614)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Satış Bilgileri"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ATickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1477, 859)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lv_Ticket)
        Me.Name = "ATickets"
        Me.Text = "Biletler"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lv_Ticket As ListView
    Private WithEvents Label5 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label1 As Label
    Private WithEvents label3 As Label
    Private WithEvents Label8 As Label
    Private WithEvents Label12 As Label
    Private WithEvents Label11 As Label
    Private WithEvents Label10 As Label
    Private WithEvents Label9 As Label
    Private WithEvents Label7 As Label
    Private WithEvents Label4 As Label
    Friend WithEvents lv_tickets As ListView
    Private WithEvents Label13 As Label
    Private WithEvents Label6 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
End Class
