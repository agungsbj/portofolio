<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogAktivitas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogAktivitas))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nolog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pengguna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nolog, Me.tgl, Me.jam, Me.pengguna, Me.aksi})
        Me.DataGridView1.Location = New System.Drawing.Point(4, 13)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(843, 390)
        Me.DataGridView1.TabIndex = 0
        '
        'nolog
        '
        Me.nolog.HeaderText = "No Log"
        Me.nolog.Name = "nolog"
        Me.nolog.ReadOnly = True
        Me.nolog.Width = 200
        '
        'tgl
        '
        Me.tgl.HeaderText = "Tanggal"
        Me.tgl.Name = "tgl"
        Me.tgl.ReadOnly = True
        '
        'jam
        '
        Me.jam.HeaderText = "Jam"
        Me.jam.Name = "jam"
        Me.jam.ReadOnly = True
        '
        'pengguna
        '
        Me.pengguna.HeaderText = "Pengguna"
        Me.pengguna.Name = "pengguna"
        Me.pengguna.ReadOnly = True
        '
        'aksi
        '
        Me.aksi.HeaderText = "Aksi"
        Me.aksi.Name = "aksi"
        Me.aksi.ReadOnly = True
        Me.aksi.Width = 300
        '
        'LogAktivitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(850, 409)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(709, 448)
        Me.Name = "LogAktivitas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log Aktivitas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents nolog As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pengguna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aksi As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
