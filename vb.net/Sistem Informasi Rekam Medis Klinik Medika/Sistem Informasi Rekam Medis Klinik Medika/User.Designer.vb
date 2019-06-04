<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ofdphoto = New System.Windows.Forms.OpenFileDialog()
        Me.lbledit = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(283, 638)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 32)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "BATAL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(283, 606)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 32)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "SIMPAN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(183, 141)
        Me.TextBox3.MaxLength = 8
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(171, 29)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Tag = ""
        Me.ToolTip1.SetToolTip(Me.TextBox3, "Minimal 6 Karakter")
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(183, 106)
        Me.TextBox2.MaxLength = 8
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(171, 29)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Tag = ""
        Me.ToolTip1.SetToolTip(Me.TextBox2, "Minimal 6 Karakter")
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(183, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 29)
        Me.TextBox1.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(127, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(221, 21)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "PENDAFTARAN PENGGUNA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 423)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 21)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Hak Akses"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 383)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 21)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Telepon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 21)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 21)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 21)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 21)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Nama Lengkap"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 21)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Ulang Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 21)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Username"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(183, 178)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(219, 29)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(183, 251)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(219, 29)
        Me.TextBox5.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(183, 286)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(219, 29)
        Me.DateTimePicker1.TabIndex = 7
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(183, 327)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(219, 47)
        Me.TextBox6.TabIndex = 8
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(182, 380)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(219, 29)
        Me.TextBox7.TabIndex = 9
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Bag. Pendaftaran", "Bag. Rekam Medis", "Bag. Apotik dan Kasir", "Bag. Surat Kesehatan"})
        Me.ComboBox2.Location = New System.Drawing.Point(182, 415)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(220, 29)
        Me.ComboBox2.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(357, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 13)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "_"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Laki - laki", "Perempuan"})
        Me.ComboBox1.Location = New System.Drawing.Point(183, 214)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(218, 29)
        Me.ComboBox1.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 217)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 21)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Jenis Kelamin"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.SandyBrown
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBrowse.Location = New System.Drawing.Point(185, 451)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(92, 30)
        Me.btnBrowse.TabIndex = 11
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnBrowse, "Cari Foto")
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'picPhoto
        '
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPhoto.Location = New System.Drawing.Point(283, 451)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(119, 153)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 63
        Me.picPhoto.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 451)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 21)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Foto"
        '
        'ofdphoto
        '
        Me.ofdphoto.FileName = "Pilih Foto"
        '
        'lbledit
        '
        Me.lbledit.AutoSize = True
        Me.lbledit.Location = New System.Drawing.Point(18, 21)
        Me.lbledit.Name = "lbledit"
        Me.lbledit.Size = New System.Drawing.Size(19, 21)
        Me.lbledit.TabIndex = 65
        Me.lbledit.Text = "0"
        Me.lbledit.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(363, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Lihat"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(249, 607)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(35, 32)
        Me.Panel1.TabIndex = 67
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(249, 638)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(35, 32)
        Me.Panel2.TabIndex = 68
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(76, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(52, 50)
        Me.Panel3.TabIndex = 68
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(185, 451)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(29, 30)
        Me.Panel4.TabIndex = 68
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Location = New System.Drawing.Point(-32, 480)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(237, 235)
        Me.Panel5.TabIndex = 69
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(419, 674)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbledit)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.picPhoto)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel5)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(435, 713)
        Me.MinimumSize = New System.Drawing.Size(435, 713)
        Me.Name = "User"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PENDAFTARAN PENGGUNA"
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ofdphoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbledit As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
