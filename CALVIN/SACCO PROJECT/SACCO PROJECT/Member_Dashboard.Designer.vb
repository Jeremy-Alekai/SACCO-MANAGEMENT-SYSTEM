<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Member_Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Member_Dashboard))
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel8 = New System.Windows.Forms.Panel()
        Me.btnMy_Loans = New System.Windows.Forms.Button()
        Me.btnMy_savings = New System.Windows.Forms.Button()
        Me.btnLog_Out = New System.Windows.Forms.Button()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.label19 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panel7.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.panel7.Controls.Add(Me.Label25)
        Me.panel7.Controls.Add(Me.Label26)
        Me.panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel7.Location = New System.Drawing.Point(129, 0)
        Me.panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(1054, 44)
        Me.panel7.TabIndex = 95
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(501, 25)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(140, 18)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Member Dashboard"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(463, 1)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(278, 24)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "TWEZIMBE YOUTH SACCO "
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(21, 77)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(87, 64)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 19
        Me.pictureBox1.TabStop = False
        '
        'panel8
        '
        Me.panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.panel8.Controls.Add(Me.pictureBox1)
        Me.panel8.Controls.Add(Me.btnMy_Loans)
        Me.panel8.Controls.Add(Me.btnMy_savings)
        Me.panel8.Controls.Add(Me.btnLog_Out)
        Me.panel8.Controls.Add(Me.label17)
        Me.panel8.Controls.Add(Me.label18)
        Me.panel8.Controls.Add(Me.label19)
        Me.panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel8.Location = New System.Drawing.Point(0, 0)
        Me.panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.panel8.Name = "panel8"
        Me.panel8.Size = New System.Drawing.Size(129, 704)
        Me.panel8.TabIndex = 96
        '
        'btnMy_Loans
        '
        Me.btnMy_Loans.Location = New System.Drawing.Point(8, 204)
        Me.btnMy_Loans.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMy_Loans.Name = "btnMy_Loans"
        Me.btnMy_Loans.Size = New System.Drawing.Size(106, 23)
        Me.btnMy_Loans.TabIndex = 4
        Me.btnMy_Loans.Text = "My Loans"
        Me.btnMy_Loans.UseVisualStyleBackColor = True
        '
        'btnMy_savings
        '
        Me.btnMy_savings.Location = New System.Drawing.Point(8, 169)
        Me.btnMy_savings.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMy_savings.Name = "btnMy_savings"
        Me.btnMy_savings.Size = New System.Drawing.Size(106, 23)
        Me.btnMy_savings.TabIndex = 4
        Me.btnMy_savings.Text = "Personal Savings"
        Me.btnMy_savings.UseVisualStyleBackColor = True
        '
        'btnLog_Out
        '
        Me.btnLog_Out.Location = New System.Drawing.Point(11, 519)
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
        Me.Panel1.Location = New System.Drawing.Point(134, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1037, 643)
        Me.Panel1.TabIndex = 97
        '
        'Member_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 704)
        Me.Controls.Add(Me.panel7)
        Me.Controls.Add(Me.panel8)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Member_Dashboard"
        Me.Text = "Member_Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel7.ResumeLayout(False)
        Me.panel7.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel8.ResumeLayout(False)
        Me.panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnMy_Loans As System.Windows.Forms.Button
    Friend WithEvents btnMy_savings As System.Windows.Forms.Button
    Friend WithEvents btnLog_Out As System.Windows.Forms.Button
    Friend WithEvents label17 As System.Windows.Forms.Label
    Friend WithEvents label18 As System.Windows.Forms.Label
    Friend WithEvents label19 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
