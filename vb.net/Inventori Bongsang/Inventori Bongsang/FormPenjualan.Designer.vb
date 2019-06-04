<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProduksi))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.labelno = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.labelstok = New System.Windows.Forms.Label()
        Me.labelstokbaru = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.labelno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Produksi Bongsang"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(422, 27)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(209, 25)
        Me.DateTimePicker1.TabIndex = 9
        '
        'labelno
        '
        Me.labelno.BackColor = System.Drawing.Color.Transparent
        Me.labelno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labelno.Location = New System.Drawing.Point(116, 33)
        Me.labelno.Name = "labelno"
        Me.labelno.Size = New System.Drawing.Size(170, 17)
        Me.labelno.TabIndex = 7
        Me.labelno.Text = "labelno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(331, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tgl. Produksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Produksi"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(486, 129)
        Me.DataGridView1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(504, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 28)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Simpan Produksi"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(504, 192)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(145, 28)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Hapus Bahan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(504, 259)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(145, 28)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Batalkan Produksi"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(504, 158)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(145, 28)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "Tambah Bahan"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(332, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(124, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Label7"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(32, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Kode Bahan"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 24)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(482, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 17)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Qty :"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(518, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(55, 18)
        Me.TextBox1.TabIndex = 20
        '
        'labelstok
        '
        Me.labelstok.AutoSize = True
        Me.labelstok.Location = New System.Drawing.Point(506, 90)
        Me.labelstok.Name = "labelstok"
        Me.labelstok.Size = New System.Drawing.Size(34, 17)
        Me.labelstok.TabIndex = 22
        Me.labelstok.Text = "stok"
        Me.labelstok.Visible = False
        '
        'labelstokbaru
        '
        Me.labelstokbaru.AutoSize = True
        Me.labelstokbaru.Location = New System.Drawing.Point(571, 90)
        Me.labelstokbaru.Name = "labelstokbaru"
        Me.labelstokbaru.Size = New System.Drawing.Size(62, 17)
        Me.labelstokbaru.TabIndex = 23
        Me.labelstokbaru.Text = "stokbaru"
        Me.labelstokbaru.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(502, 62)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 17)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "kode"
        Me.Label18.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(571, 62)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 17)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "qty"
        Me.Label19.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.labelstokbaru)
        Me.GroupBox2.Controls.Add(Me.labelstok)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(637, 63)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Bahan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(235, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 17)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Nama Bahan"
        '
        'FormProduksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(659, 296)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(675, 335)
        Me.MinimumSize = New System.Drawing.Size(675, 335)
        Me.Name = "FormProduksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produksi Bongsang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelno As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents labelstok As System.Windows.Forms.Label
    Friend WithEvents labelstokbaru As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
