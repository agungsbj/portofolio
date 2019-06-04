<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LihatPemasok
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.counter = New System.Windows.Forms.TextBox()
        Me.alamat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.id_pemasok = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nama_pemasok = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.telepon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 17)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Cari"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(49, 15)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 25)
        Me.TextBox1.TabIndex = 75
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Cari pemasok berdasarkan ID dan Nama")
        '
        'counter
        '
        Me.counter.Location = New System.Drawing.Point(349, 15)
        Me.counter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.counter.Name = "counter"
        Me.counter.Size = New System.Drawing.Size(34, 25)
        Me.counter.TabIndex = 74
        Me.counter.Visible = False
        '
        'alamat
        '
        Me.alamat.Text = "Alamat"
        Me.alamat.Width = 180
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_pemasok, Me.nama_pemasok, Me.alamat, Me.telepon})
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(8, 46)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(554, 205)
        Me.ListView1.TabIndex = 73
        Me.ToolTip1.SetToolTip(Me.ListView1, "Double Click untuk memilih pemasok")
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'id_pemasok
        '
        Me.id_pemasok.Text = "ID Pemasok"
        Me.id_pemasok.Width = 120
        '
        'nama_pemasok
        '
        Me.nama_pemasok.Text = "Nama Pemasok"
        Me.nama_pemasok.Width = 150
        '
        'telepon
        '
        Me.telepon.Text = "Telepon"
        Me.telepon.Width = 100
        '
        'LihatPemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 260)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.counter)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LihatPemasok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LihatPemasok"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents counter As System.Windows.Forms.TextBox
    Friend WithEvents alamat As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents id_pemasok As System.Windows.Forms.ColumnHeader
    Friend WithEvents nama_pemasok As System.Windows.Forms.ColumnHeader
    Friend WithEvents telepon As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
