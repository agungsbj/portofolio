<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupplier
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idsup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.cmdbatal = New System.Windows.Forms.Button()
        Me.cmddaftar = New System.Windows.Forms.Button()
        Me.txtalmt = New System.Windows.Forms.TextBox()
        Me.txtnm = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idsup, Me.nama, Me.jk, Me.telp})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 228)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(451, 166)
        Me.DataGridView1.TabIndex = 24
        '
        'idsup
        '
        Me.idsup.HeaderText = "ID Supplier"
        Me.idsup.Name = "idsup"
        '
        'nama
        '
        Me.nama.HeaderText = "Nama Supplier"
        Me.nama.Name = "nama"
        '
        'jk
        '
        Me.jk.HeaderText = "Alamat"
        Me.jk.Name = "jk"
        '
        'telp
        '
        Me.telp.HeaderText = "No. Telp"
        Me.telp.Name = "telp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Helvetica Neue", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 32)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Input Supplier"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.cmdbatal)
        Me.GroupBox1.Controls.Add(Me.cmddaftar)
        Me.GroupBox1.Controls.Add(Me.txtalmt)
        Me.GroupBox1.Controls.Add(Me.txtnm)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Helvetica Neue", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 178)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(355, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Hapus"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(355, 77)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(151, 137)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(179, 23)
        Me.txtno.TabIndex = 4
        '
        'cmdbatal
        '
        Me.cmdbatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdbatal.Location = New System.Drawing.Point(355, 51)
        Me.cmdbatal.Name = "cmdbatal"
        Me.cmdbatal.Size = New System.Drawing.Size(75, 23)
        Me.cmdbatal.TabIndex = 6
        Me.cmdbatal.Text = "Batal"
        Me.cmdbatal.UseVisualStyleBackColor = True
        '
        'cmddaftar
        '
        Me.cmddaftar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmddaftar.Location = New System.Drawing.Point(355, 25)
        Me.cmddaftar.Name = "cmddaftar"
        Me.cmddaftar.Size = New System.Drawing.Size(75, 23)
        Me.cmddaftar.TabIndex = 5
        Me.cmddaftar.Text = "Simpan"
        Me.cmddaftar.UseVisualStyleBackColor = True
        '
        'txtalmt
        '
        Me.txtalmt.Location = New System.Drawing.Point(151, 88)
        Me.txtalmt.Multiline = True
        Me.txtalmt.Name = "txtalmt"
        Me.txtalmt.Size = New System.Drawing.Size(179, 43)
        Me.txtalmt.TabIndex = 3
        '
        'txtnm
        '
        Me.txtnm.Location = New System.Drawing.Point(151, 57)
        Me.txtnm.Name = "txtnm"
        Me.txtnm.Size = New System.Drawing.Size(179, 23)
        Me.txtnm.TabIndex = 2
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtid.Location = New System.Drawing.Point(151, 25)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(179, 23)
        Me.txtid.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Helvetica Neue", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "No. Telp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica Neue", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica Neue", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica Neue", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID Supplier"
        '
        'FormSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(481, 406)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Supplier"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents cmdbatal As System.Windows.Forms.Button
    Friend WithEvents cmddaftar As System.Windows.Forms.Button
    Friend WithEvents txtalmt As System.Windows.Forms.TextBox
    Friend WithEvents txtnm As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents idsup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telp As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
