<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formuser
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbjk = New System.Windows.Forms.ComboBox()
        Me.txtalmt = New System.Windows.Forms.TextBox()
        Me.cmdbatal = New System.Windows.Forms.Button()
        Me.cmddaftar = New System.Windows.Forms.Button()
        Me.txtpswd = New System.Windows.Forms.TextBox()
        Me.txtnm = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id_karyawan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_karyawan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.cbjk)
        Me.GroupBox1.Controls.Add(Me.txtalmt)
        Me.GroupBox1.Controls.Add(Me.cmdbatal)
        Me.GroupBox1.Controls.Add(Me.cmddaftar)
        Me.GroupBox1.Controls.Add(Me.txtpswd)
        Me.GroupBox1.Controls.Add(Me.txtnm)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 196)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(316, 94)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(363, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 25)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(363, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 25)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Hapus Data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbjk
        '
        Me.cbjk.BackColor = System.Drawing.Color.White
        Me.cbjk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbjk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbjk.FormattingEnabled = True
        Me.cbjk.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cbjk.Location = New System.Drawing.Point(187, 119)
        Me.cbjk.Name = "cbjk"
        Me.cbjk.Size = New System.Drawing.Size(143, 25)
        Me.cbjk.TabIndex = 3
        '
        'txtalmt
        '
        Me.txtalmt.Location = New System.Drawing.Point(187, 148)
        Me.txtalmt.Name = "txtalmt"
        Me.txtalmt.Size = New System.Drawing.Size(143, 25)
        Me.txtalmt.TabIndex = 4
        '
        'cmdbatal
        '
        Me.cmdbatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdbatal.Location = New System.Drawing.Point(363, 58)
        Me.cmdbatal.Name = "cmdbatal"
        Me.cmdbatal.Size = New System.Drawing.Size(75, 24)
        Me.cmdbatal.TabIndex = 5
        Me.cmdbatal.Text = "Batal"
        Me.cmdbatal.UseVisualStyleBackColor = True
        '
        'cmddaftar
        '
        Me.cmddaftar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmddaftar.Location = New System.Drawing.Point(363, 25)
        Me.cmddaftar.Name = "cmddaftar"
        Me.cmddaftar.Size = New System.Drawing.Size(75, 27)
        Me.cmddaftar.TabIndex = 4
        Me.cmddaftar.Text = "Daftar"
        Me.cmddaftar.UseVisualStyleBackColor = True
        '
        'txtpswd
        '
        Me.txtpswd.Location = New System.Drawing.Point(187, 88)
        Me.txtpswd.Name = "txtpswd"
        Me.txtpswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpswd.Size = New System.Drawing.Size(123, 25)
        Me.txtpswd.TabIndex = 2
        '
        'txtnm
        '
        Me.txtnm.Location = New System.Drawing.Point(187, 57)
        Me.txtnm.Name = "txtnm"
        Me.txtnm.Size = New System.Drawing.Size(143, 25)
        Me.txtnm.TabIndex = 1
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtid.Location = New System.Drawing.Point(187, 25)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(143, 25)
        Me.txtid.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama Karyawan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID Karyawan"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_karyawan, Me.nama_karyawan, Me.password, Me.jk, Me.alamat})
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 256)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(451, 197)
        Me.DataGridView1.TabIndex = 24
        '
        'id_karyawan
        '
        Me.id_karyawan.HeaderText = "ID KARYAWAN"
        Me.id_karyawan.Name = "id_karyawan"
        '
        'nama_karyawan
        '
        Me.nama_karyawan.HeaderText = "NAMA KARYAWAN"
        Me.nama_karyawan.Name = "nama_karyawan"
        '
        'password
        '
        Me.password.HeaderText = "PASSWORD"
        Me.password.Name = "password"
        '
        'jk
        '
        Me.jk.HeaderText = "JENIS KELAMIN"
        Me.jk.Name = "jk"
        '
        'alamat
        '
        Me.alamat.HeaderText = "ALAMAT"
        Me.alamat.Name = "alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(32, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 37)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Daftar User"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(375, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 32)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Buat Baru"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'formuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(474, 460)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "formuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cbjk As System.Windows.Forms.ComboBox
    Friend WithEvents txtalmt As System.Windows.Forms.TextBox
    Friend WithEvents cmdbatal As System.Windows.Forms.Button
    Friend WithEvents cmddaftar As System.Windows.Forms.Button
    Friend WithEvents txtpswd As System.Windows.Forms.TextBox
    Friend WithEvents txtnm As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents id_karyawan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_karyawan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
