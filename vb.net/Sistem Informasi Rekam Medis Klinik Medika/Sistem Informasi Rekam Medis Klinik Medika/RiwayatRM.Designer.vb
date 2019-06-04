<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RiwayatRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RiwayatRM))
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView3
        '
        Me.DataGridView3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToResizeColumns = False
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView3.Location = New System.Drawing.Point(13, 12)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.ShowCellToolTips = False
        Me.DataGridView3.ShowEditingIcon = False
        Me.DataGridView3.Size = New System.Drawing.Size(741, 245)
        Me.DataGridView3.TabIndex = 57
        '
        'RiwayatRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(766, 268)
        Me.Controls.Add(Me.DataGridView3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(782, 307)
        Me.MinimumSize = New System.Drawing.Size(782, 307)
        Me.Name = "RiwayatRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RiwayatRM"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
End Class
