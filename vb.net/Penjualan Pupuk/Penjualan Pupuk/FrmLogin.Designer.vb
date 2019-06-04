<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmlogin
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
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.cmdbatal = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(103, 95)
        Me.txtid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(175, 25)
        Me.txtid.TabIndex = 0
        Me.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(103, 157)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(175, 25)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'cmdlogin
        '
        Me.cmdlogin.Location = New System.Drawing.Point(114, 189)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(75, 32)
        Me.cmdlogin.TabIndex = 4
        Me.cmdlogin.Text = "Login"
        Me.cmdlogin.UseVisualStyleBackColor = True
        '
        'cmdbatal
        '
        Me.cmdbatal.Location = New System.Drawing.Point(195, 189)
        Me.cmdbatal.Name = "cmdbatal"
        Me.cmdbatal.Size = New System.Drawing.Size(75, 32)
        Me.cmdbatal.TabIndex = 5
        Me.cmdbatal.Text = "Batal"
        Me.cmdbatal.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(128, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "LOGIN ADMIN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 72)
        Me.Panel1.TabIndex = 7
        '
        'Frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(388, 241)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdbatal)
        Me.Controls.Add(Me.cmdlogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents cmdbatal As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
