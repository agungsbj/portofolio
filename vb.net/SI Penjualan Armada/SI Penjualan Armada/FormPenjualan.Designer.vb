<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.labelno = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.labelstokbaru = New System.Windows.Forms.Label()
        Me.labelstok = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.labelno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaksi Penjualan"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(454, 27)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(164, 25)
        Me.DateTimePicker1.TabIndex = 9
        '
        'labelno
        '
        Me.labelno.BackColor = System.Drawing.SystemColors.ButtonHighlight
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
        Me.Label2.Location = New System.Drawing.Point(361, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tgl. Transaksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Transaksi :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.labelstokbaru)
        Me.GroupBox2.Controls.Add(Me.labelstok)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(637, 122)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Barang"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(530, 63)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 17)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "qty"
        Me.Label19.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(487, 63)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 17)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "kode"
        Me.Label18.Visible = False
        '
        'labelstokbaru
        '
        Me.labelstokbaru.AutoSize = True
        Me.labelstokbaru.Location = New System.Drawing.Point(530, 91)
        Me.labelstokbaru.Name = "labelstokbaru"
        Me.labelstokbaru.Size = New System.Drawing.Size(62, 17)
        Me.labelstokbaru.TabIndex = 23
        Me.labelstokbaru.Text = "stokbaru"
        Me.labelstokbaru.Visible = False
        '
        'labelstok
        '
        Me.labelstok.AutoSize = True
        Me.labelstok.Location = New System.Drawing.Point(487, 91)
        Me.labelstok.Name = "labelstok"
        Me.labelstok.Size = New System.Drawing.Size(34, 17)
        Me.labelstok.TabIndex = 22
        Me.labelstok.Text = "stok"
        Me.labelstok.Visible = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Location = New System.Drawing.Point(336, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 17)
        Me.Label15.TabIndex = 219
        Me.Label15.Text = "Label15"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(129, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(105, 18)
        Me.TextBox1.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(279, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 17)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Jumlah :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(93, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 17)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Qty :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(478, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 17)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Harga :"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Location = New System.Drawing.Point(530, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Label9"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(11, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 24)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Kode Barang :"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Location = New System.Drawing.Point(129, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Label7"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(239, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 17)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Nama Barang :"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Location = New System.Drawing.Point(336, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Label8"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 217)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(486, 129)
        Me.DataGridView1.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("LANGDON", 26.0!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(12, 366)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(286, 57)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Label16"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 349)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 17)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Total :"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(502, 284)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 28)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Simpan Transaksi"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(502, 251)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(145, 28)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Hapus Barang"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(502, 318)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(145, 28)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Batalkan Pesanan"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(502, 217)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(145, 28)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "Tambah Barang"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(380, 375)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 18)
        Me.TextBox2.TabIndex = 221
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 375)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 220
        Me.Label3.Text = "Dibayar :"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(380, 399)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(116, 18)
        Me.TextBox3.TabIndex = 223
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(311, 399)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 222
        Me.Label4.Text = "Kembali :"
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 432)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Penjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelno As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents labelstokbaru As System.Windows.Forms.Label
    Friend WithEvents labelstok As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
