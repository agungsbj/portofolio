<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNilai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNilai))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblstatus = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblmutu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nilaia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nilaib = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nilaic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nilaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nilaie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalnilai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mutu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblstatus)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.lblmutu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(300, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Siswa"
        '
        'lblstatus
        '
        Me.lblstatus.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblstatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblstatus.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblstatus.ForeColor = System.Drawing.Color.Red
        Me.lblstatus.Location = New System.Drawing.Point(102, 221)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.ReadOnly = True
        Me.lblstatus.Size = New System.Drawing.Size(190, 25)
        Me.lblstatus.TabIndex = 20
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox2.Location = New System.Drawing.Point(79, 62)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(214, 29)
        Me.TextBox2.TabIndex = 2
        '
        'lblmutu
        '
        Me.lblmutu.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblmutu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblmutu.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblmutu.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblmutu.Location = New System.Drawing.Point(102, 188)
        Me.lblmutu.Name = "lblmutu"
        Me.lblmutu.ReadOnly = True
        Me.lblmutu.Size = New System.Drawing.Size(190, 25)
        Me.lblmutu.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(16, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 25)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Status  :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(79, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 29)
        Me.TextBox1.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label10.Location = New System.Drawing.Point(16, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 25)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Mutu   :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(311, 78)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(300, 256)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Nilai"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(93, 173)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(190, 29)
        Me.TextBox7.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nilai 5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 21)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Total Nilai"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox8.Location = New System.Drawing.Point(93, 211)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(190, 29)
        Me.TextBox8.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(93, 98)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(190, 29)
        Me.TextBox5.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nilai 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nilai 4"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(93, 136)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(190, 29)
        Me.TextBox6.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(93, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(190, 29)
        Me.TextBox3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nilai 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nilai 2"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(93, 62)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(190, 29)
        Me.TextBox4.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Location = New System.Drawing.Point(613, 88)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(125, 246)
        Me.Panel1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(5, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 37)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "EDIT"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Red
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(5, 9)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(114, 37)
        Me.Button8.TabIndex = 23
        Me.Button8.Text = "SIMPAN"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nis, Me.nama, Me.nilaia, Me.nilaib, Me.nilaic, Me.nilaid, Me.nilaie, Me.totalnilai, Me.mutu, Me.status})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 342)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(725, 163)
        Me.DataGridView1.TabIndex = 3
        '
        'nis
        '
        Me.nis.HeaderText = "NIS"
        Me.nis.Name = "nis"
        Me.nis.ReadOnly = True
        '
        'nama
        '
        Me.nama.HeaderText = "Nama"
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        Me.nama.Width = 120
        '
        'nilaia
        '
        Me.nilaia.HeaderText = "N 1"
        Me.nilaia.Name = "nilaia"
        Me.nilaia.ReadOnly = True
        Me.nilaia.Width = 50
        '
        'nilaib
        '
        Me.nilaib.HeaderText = "N 2"
        Me.nilaib.Name = "nilaib"
        Me.nilaib.ReadOnly = True
        Me.nilaib.Width = 50
        '
        'nilaic
        '
        Me.nilaic.HeaderText = "N 3"
        Me.nilaic.Name = "nilaic"
        Me.nilaic.ReadOnly = True
        Me.nilaic.Width = 50
        '
        'nilaid
        '
        Me.nilaid.HeaderText = "N 4"
        Me.nilaid.Name = "nilaid"
        Me.nilaid.ReadOnly = True
        Me.nilaid.Width = 50
        '
        'nilaie
        '
        Me.nilaie.HeaderText = "N 5"
        Me.nilaie.Name = "nilaie"
        Me.nilaie.ReadOnly = True
        Me.nilaie.Width = 50
        '
        'totalnilai
        '
        Me.totalnilai.HeaderText = "TOTAL"
        Me.totalnilai.Name = "totalnilai"
        Me.totalnilai.ReadOnly = True
        Me.totalnilai.Width = 70
        '
        'mutu
        '
        Me.mutu.HeaderText = "MUTU"
        Me.mutu.Name = "mutu"
        Me.mutu.ReadOnly = True
        Me.mutu.Width = 70
        '
        'status
        '
        Me.status.HeaderText = "STATUS"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 70
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(15, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(685, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(53, 53)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(69, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(214, 37)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Input Nilai Siswa"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(5, 92)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 37)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "BATAL"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FormNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(755, 517)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormNilai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Nilai Siswa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblmutu As System.Windows.Forms.TextBox
    Friend WithEvents lblstatus As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nilaia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nilaib As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nilaic As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nilaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nilaie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalnilai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mutu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
