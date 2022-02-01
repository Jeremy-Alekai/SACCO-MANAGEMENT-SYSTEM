<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chairman_Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chairman_Dashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnMy_Loans = New System.Windows.Forms.Button()
        Me.btnSACCO_SAVINGS = New System.Windows.Forms.Button()
        Me.btnView_Members = New System.Windows.Forms.Button()
        Me.btnPersonal_savings = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MemberID_Dash = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(540, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Chairman Dashboard"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(138, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1151, 598)
        Me.Panel1.TabIndex = 59
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btnLogout)
        Me.Panel3.Controls.Add(Me.btnMy_Loans)
        Me.Panel3.Controls.Add(Me.btnSACCO_SAVINGS)
        Me.Panel3.Controls.Add(Me.btnView_Members)
        Me.Panel3.Controls.Add(Me.btnPersonal_savings)
        Me.Panel3.Location = New System.Drawing.Point(0, 133)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(141, 610)
        Me.Panel3.TabIndex = 60
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(24, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 59
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "SACCO LOANS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(18, 484)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(99, 23)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnMy_Loans
        '
        Me.btnMy_Loans.Location = New System.Drawing.Point(21, 296)
        Me.btnMy_Loans.Name = "btnMy_Loans"
        Me.btnMy_Loans.Size = New System.Drawing.Size(99, 23)
        Me.btnMy_Loans.TabIndex = 1
        Me.btnMy_Loans.Text = "My Loans"
        Me.btnMy_Loans.UseVisualStyleBackColor = True
        '
        'btnSACCO_SAVINGS
        '
        Me.btnSACCO_SAVINGS.Location = New System.Drawing.Point(21, 249)
        Me.btnSACCO_SAVINGS.Name = "btnSACCO_SAVINGS"
        Me.btnSACCO_SAVINGS.Size = New System.Drawing.Size(99, 23)
        Me.btnSACCO_SAVINGS.TabIndex = 1
        Me.btnSACCO_SAVINGS.Text = "SACCO Savings"
        Me.btnSACCO_SAVINGS.UseVisualStyleBackColor = True
        '
        'btnView_Members
        '
        Me.btnView_Members.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnView_Members.Location = New System.Drawing.Point(21, 158)
        Me.btnView_Members.Name = "btnView_Members"
        Me.btnView_Members.Size = New System.Drawing.Size(99, 23)
        Me.btnView_Members.TabIndex = 1
        Me.btnView_Members.Text = "View Members"
        Me.btnView_Members.UseVisualStyleBackColor = False
        '
        'btnPersonal_savings
        '
        Me.btnPersonal_savings.Location = New System.Drawing.Point(21, 204)
        Me.btnPersonal_savings.Name = "btnPersonal_savings"
        Me.btnPersonal_savings.Size = New System.Drawing.Size(99, 23)
        Me.btnPersonal_savings.TabIndex = 1
        Me.btnPersonal_savings.Text = "Personal Savings"
        Me.btnPersonal_savings.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MemberID_Dash)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1301, 70)
        Me.Panel2.TabIndex = 61
        '
        'MemberID_Dash
        '
        Me.MemberID_Dash.AutoSize = True
        Me.MemberID_Dash.ForeColor = System.Drawing.Color.White
        Me.MemberID_Dash.Location = New System.Drawing.Point(115, 36)
        Me.MemberID_Dash.Name = "MemberID_Dash"
        Me.MemberID_Dash.Size = New System.Drawing.Size(56, 13)
        Me.MemberID_Dash.TabIndex = 10
        Me.MemberID_Dash.Text = "MemberID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(512, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "UBEN SACCO GROUP"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 70)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1301, 66)
        Me.Panel4.TabIndex = 62
        '
        'Chairman_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 743)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Chairman_Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnMy_Loans As System.Windows.Forms.Button
    Friend WithEvents btnSACCO_SAVINGS As System.Windows.Forms.Button
    Friend WithEvents btnView_Members As System.Windows.Forms.Button
    Friend WithEvents btnPersonal_savings As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents MemberID_Dash As System.Windows.Forms.Label

End Class
