<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ASalons
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
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lvSalons = New System.Windows.Forms.ListView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.label10.Location = New System.Drawing.Point(50, 45)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(154, 25)
        Me.label10.TabIndex = 53
        Me.label10.Text = "Salon Arama"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(227, 38)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(313, 32)
        Me.txtSearch.TabIndex = 52
        '
        'lvSalons
        '
        Me.lvSalons.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lvSalons.HideSelection = False
        Me.lvSalons.Location = New System.Drawing.Point(2, 105)
        Me.lvSalons.Name = "lvSalons"
        Me.lvSalons.Size = New System.Drawing.Size(683, 581)
        Me.lvSalons.TabIndex = 54
        Me.lvSalons.UseCompatibleStateImageBehavior = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.Location = New System.Drawing.Point(691, 71)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(788, 619)
        Me.TabControl1.TabIndex = 55
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Controls.Add(Me.btnUpdate)
        Me.TabPage1.Controls.Add(Me.txtCapacity)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.label3)
        Me.TabPage1.Controls.Add(Me.txtId)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(780, 581)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Salon Detayları"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Goldenrod
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(275, 308)
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
        Me.btnUpdate.Location = New System.Drawing.Point(521, 308)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(194, 40)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "Güncelle"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtCapacity
        '
        Me.txtCapacity.Enabled = False
        Me.txtCapacity.Font = New System.Drawing.Font("Verdana", 10.2!)
        Me.txtCapacity.Location = New System.Drawing.Point(275, 222)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(440, 28)
        Me.txtCapacity.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(47, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Salon Kapasitesi:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(47, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Salon Adı:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Verdana", 10.2!)
        Me.txtName.Location = New System.Drawing.Point(275, 146)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(440, 28)
        Me.txtName.TabIndex = 10
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold)
        Me.label3.Location = New System.Drawing.Point(47, 71)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(176, 22)
        Me.label3.TabIndex = 9
        Me.label3.Text = "Salon Numarası:"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Verdana", 10.2!)
        Me.txtId.Location = New System.Drawing.Point(275, 65)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(440, 28)
        Me.txtId.TabIndex = 8
        '
        'ASalons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1477, 859)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lvSalons)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "ASalons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salonlar"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label10 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lvSalons As ListView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Private WithEvents btnDelete As Button
    Private WithEvents btnUpdate As Button
    Private WithEvents txtCapacity As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents Label1 As Label
    Private WithEvents txtName As TextBox
    Private WithEvents label3 As Label
    Private WithEvents txtId As TextBox
End Class
