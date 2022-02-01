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
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnSACCO_Policy = New System.Windows.Forms.Button()
        Me.btnMessages = New System.Windows.Forms.Button()
        Me.btnMy_Loans = New System.Windows.Forms.Button()
        Me.btnSACCO_SAVINGS = New System.Windows.Forms.Button()
        Me.btnView_Members = New System.Windows.Forms.Button()
        Me.btnPersonal_savings = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.panel7.Controls.Add(Me.Label1)
        Me.panel7.Controls.Add(Me.Label2)
        Me.panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel7.Location = New System.Drawing.Point(0, 0)
        Me.panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(1301, 44)
        Me.panel7.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(560, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Chairman Dashboard"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(522, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "TWEZIMBE SACCO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(293, 14)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 18)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Administrator's Dashboard"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(593, 14)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "NAME"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(138, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1151, 678)
        Me.Panel1.TabIndex = 59
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btnLogout)
        Me.Panel3.Controls.Add(Me.btnSettings)
        Me.Panel3.Controls.Add(Me.btnSACCO_Policy)
        Me.Panel3.Controls.Add(Me.btnMessages)
        Me.Panel3.Controls.Add(Me.btnMy_Loans)
        Me.Panel3.Controls.Add(Me.btnSACCO_SAVINGS)
        Me.Panel3.Controls.Add(Me.btnView_Members)
        Me.Panel3.Controls.Add(Me.btnPersonal_savings)
        Me.Panel3.Controls.Add(Me.btnHome)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 44)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(141, 699)
        Me.Panel3.TabIndex = 60
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "SACCO LOANS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(12, 515)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(99, 23)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(3, 358)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(138, 42)
        Me.btnSettings.TabIndex = 1
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnSACCO_Policy
        '
        Me.btnSACCO_Policy.Location = New System.Drawing.Point(12, 302)
        Me.btnSACCO_Policy.Name = "btnSACCO_Policy"
        Me.btnSACCO_Policy.Size = New System.Drawing.Size(99, 23)
        Me.btnSACCO_Policy.TabIndex = 1
        Me.btnSACCO_Policy.Text = "SACCO POLICY"
        Me.btnSACCO_Policy.UseVisualStyleBackColor = True
        '
        'btnMessages
        '
        Me.btnMessages.Location = New System.Drawing.Point(12, 273)
        Me.btnMessages.Name = "btnMessages"
        Me.btnMessages.Size = New System.Drawing.Size(99, 23)
        Me.btnMessages.TabIndex = 1
        Me.btnMessages.Text = "Messages"
        Me.btnMessages.UseVisualStyleBackColor = True
        '
        'btnMy_Loans
        '
        Me.btnMy_Loans.Location = New System.Drawing.Point(15, 207)
        Me.btnMy_Loans.Name = "btnMy_Loans"
        Me.btnMy_Loans.Size = New System.Drawing.Size(99, 23)
        Me.btnMy_Loans.TabIndex = 1
        Me.btnMy_Loans.Text = "My Loans"
        Me.btnMy_Loans.UseVisualStyleBackColor = True
        '
        'btnSACCO_SAVINGS
        '
        Me.btnSACCO_SAVINGS.Location = New System.Drawing.Point(15, 160)
        Me.btnSACCO_SAVINGS.Name = "btnSACCO_SAVINGS"
        Me.btnSACCO_SAVINGS.Size = New System.Drawing.Size(99, 23)
        Me.btnSACCO_SAVINGS.TabIndex = 1
        Me.btnSACCO_SAVINGS.Text = "SACCO Savings"
        Me.btnSACCO_SAVINGS.UseVisualStyleBackColor = True
        '
        'btnView_Members
        '
        Me.btnView_Members.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnView_Members.Location = New System.Drawing.Point(15, 69)
        Me.btnView_Members.Name = "btnView_Members"
        Me.btnView_Members.Size = New System.Drawing.Size(99, 23)
        Me.btnView_Members.TabIndex = 1
        Me.btnView_Members.Text = "View Members"
        Me.btnView_Members.UseVisualStyleBackColor = False
        '
        'btnPersonal_savings
        '
        Me.btnPersonal_savings.Location = New System.Drawing.Point(15, 115)
        Me.btnPersonal_savings.Name = "btnPersonal_savings"
        Me.btnPersonal_savings.Size = New System.Drawing.Size(99, 23)
        Me.btnPersonal_savings.TabIndex = 1
        Me.btnPersonal_savings.Text = "Personal Savings"
        Me.btnPersonal_savings.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnHome.Location = New System.Drawing.Point(12, 28)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(99, 23)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'Chairman_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 743)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panel7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Chairman_Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel7.ResumeLayout(False)
        Me.panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnSACCO_Policy As System.Windows.Forms.Button
    Friend WithEvents btnMessages As System.Windows.Forms.Button
    Friend WithEvents btnMy_Loans As System.Windows.Forms.Button
    Friend WithEvents btnSACCO_SAVINGS As System.Windows.Forms.Button
    Friend WithEvents btnView_Members As System.Windows.Forms.Button
    Friend WithEvents btnPersonal_savings As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button

End Class
