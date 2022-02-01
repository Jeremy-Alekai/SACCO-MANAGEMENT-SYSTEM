<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Treasurer_Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Treasurer_Dashboard))
        Me.Label25 = New System.Windows.Forms.Label()
        Me.panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSACCO_LOANS = New System.Windows.Forms.Button()
        Me.btnSACCO_Savings = New System.Windows.Forms.Button()
        Me.btnMy_Loans = New System.Windows.Forms.Button()
        Me.btnMy_savings = New System.Windows.Forms.Button()
        Me.btnViewMembers = New System.Windows.Forms.Button()
        Me.btnLog_Out = New System.Windows.Forms.Button()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.label19 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbMemberCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbMemberID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panel8.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label25.Location = New System.Drawing.Point(479, 36)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(149, 18)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Treasurer Dashboard"
        '
        'panel8
        '
        Me.panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.panel8.Controls.Add(Me.PictureBox1)
        Me.panel8.Controls.Add(Me.btnSACCO_LOANS)
        Me.panel8.Controls.Add(Me.btnSACCO_Savings)
        Me.panel8.Controls.Add(Me.btnMy_Loans)
        Me.panel8.Controls.Add(Me.btnMy_savings)
        Me.panel8.Controls.Add(Me.btnViewMembers)
        Me.panel8.Controls.Add(Me.btnLog_Out)
        Me.panel8.Controls.Add(Me.label17)
        Me.panel8.Controls.Add(Me.label18)
        Me.panel8.Controls.Add(Me.label19)
        Me.panel8.Location = New System.Drawing.Point(0, 132)
        Me.panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.panel8.Name = "panel8"
        Me.panel8.Size = New System.Drawing.Size(129, 659)
        Me.panel8.TabIndex = 88
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'btnSACCO_LOANS
        '
        Me.btnSACCO_LOANS.Location = New System.Drawing.Point(8, 340)
        Me.btnSACCO_LOANS.Name = "btnSACCO_LOANS"
        Me.btnSACCO_LOANS.Size = New System.Drawing.Size(106, 23)
        Me.btnSACCO_LOANS.TabIndex = 21
        Me.btnSACCO_LOANS.Text = "SACCO Loans"
        Me.btnSACCO_LOANS.UseVisualStyleBackColor = True
        '
        'btnSACCO_Savings
        '
        Me.btnSACCO_Savings.Location = New System.Drawing.Point(11, 252)
        Me.btnSACCO_Savings.Name = "btnSACCO_Savings"
        Me.btnSACCO_Savings.Size = New System.Drawing.Size(103, 23)
        Me.btnSACCO_Savings.TabIndex = 20
        Me.btnSACCO_Savings.Text = "SACCO Savings"
        Me.btnSACCO_Savings.UseVisualStyleBackColor = True
        '
        'btnMy_Loans
        '
        Me.btnMy_Loans.Location = New System.Drawing.Point(8, 295)
        Me.btnMy_Loans.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMy_Loans.Name = "btnMy_Loans"
        Me.btnMy_Loans.Size = New System.Drawing.Size(106, 23)
        Me.btnMy_Loans.TabIndex = 4
        Me.btnMy_Loans.Text = "My Loans"
        Me.btnMy_Loans.UseVisualStyleBackColor = True
        '
        'btnMy_savings
        '
        Me.btnMy_savings.Location = New System.Drawing.Point(8, 214)
        Me.btnMy_savings.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMy_savings.Name = "btnMy_savings"
        Me.btnMy_savings.Size = New System.Drawing.Size(106, 23)
        Me.btnMy_savings.TabIndex = 4
        Me.btnMy_savings.Text = "Personal Savings"
        Me.btnMy_savings.UseVisualStyleBackColor = True
        '
        'btnViewMembers
        '
        Me.btnViewMembers.Location = New System.Drawing.Point(8, 174)
        Me.btnViewMembers.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewMembers.Name = "btnViewMembers"
        Me.btnViewMembers.Size = New System.Drawing.Size(106, 23)
        Me.btnViewMembers.TabIndex = 2
        Me.btnViewMembers.Text = "View Members"
        Me.btnViewMembers.UseVisualStyleBackColor = True
        '
        'btnLog_Out
        '
        Me.btnLog_Out.Location = New System.Drawing.Point(11, 491)
        Me.btnLog_Out.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLog_Out.Name = "btnLog_Out"
        Me.btnLog_Out.Size = New System.Drawing.Size(106, 23)
        Me.btnLog_Out.TabIndex = 6
        Me.btnLog_Out.Text = "LOGOUT"
        Me.btnLog_Out.UseVisualStyleBackColor = True
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.ForeColor = System.Drawing.Color.White
        Me.label17.Location = New System.Drawing.Point(25, 194)
        Me.label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(0, 13)
        Me.label17.TabIndex = 7
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.ForeColor = System.Drawing.Color.White
        Me.label18.Location = New System.Drawing.Point(18, 201)
        Me.label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(0, 13)
        Me.label18.TabIndex = 9
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label19.ForeColor = System.Drawing.Color.White
        Me.label19.Location = New System.Drawing.Point(25, 214)
        Me.label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(0, 13)
        Me.label19.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(134, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 550)
        Me.Panel1.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(477, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "JUZZA SACCO"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.lbMemberCount)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 70)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1386, 66)
        Me.Panel4.TabIndex = 101
        '
        'lbMemberCount
        '
        Me.lbMemberCount.AutoSize = True
        Me.lbMemberCount.Location = New System.Drawing.Point(293, 31)
        Me.lbMemberCount.Name = "lbMemberCount"
        Me.lbMemberCount.Size = New System.Drawing.Size(39, 13)
        Me.lbMemberCount.TabIndex = 0
        Me.lbMemberCount.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Members :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbMemberID)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1386, 70)
        Me.Panel2.TabIndex = 100
        '
        'lbMemberID
        '
        Me.lbMemberID.AutoSize = True
        Me.lbMemberID.ForeColor = System.Drawing.Color.White
        Me.lbMemberID.Location = New System.Drawing.Point(64, 41)
        Me.lbMemberID.Name = "lbMemberID"
        Me.lbMemberID.Size = New System.Drawing.Size(56, 13)
        Me.lbMemberID.TabIndex = 0
        Me.lbMemberID.Text = "MemberID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(540, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Treasurer Dashboard"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(512, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "UBEN SACCO GROUP"
        '
        'Treasurer_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panel8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Treasurer_Dashboard"
        Me.Text = "Ftreasurer_Dash"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel8.ResumeLayout(False)
        Me.panel8.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnMy_Loans As System.Windows.Forms.Button
    Friend WithEvents btnMy_savings As System.Windows.Forms.Button
    Friend WithEvents btnViewMembers As System.Windows.Forms.Button
    Friend WithEvents btnLog_Out As System.Windows.Forms.Button
    Friend WithEvents label17 As System.Windows.Forms.Label
    Friend WithEvents label18 As System.Windows.Forms.Label
    Friend WithEvents label19 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSACCO_Savings As System.Windows.Forms.Button
    Friend WithEvents btnSACCO_LOANS As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbMemberCount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbMemberID As System.Windows.Forms.Label
End Class
