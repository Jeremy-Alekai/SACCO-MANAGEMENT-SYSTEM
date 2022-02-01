<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fsavings
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
        Me.btnExport_Savings = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DgvPSavings = New System.Windows.Forms.DataGridView()
        Me.btnRefresh_Savings = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lb = New System.Windows.Forms.Label()
        CType(Me.DgvPSavings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExport_Savings
        '
        Me.btnExport_Savings.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExport_Savings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport_Savings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport_Savings.ForeColor = System.Drawing.Color.White
        Me.btnExport_Savings.Location = New System.Drawing.Point(817, 551)
        Me.btnExport_Savings.Name = "btnExport_Savings"
        Me.btnExport_Savings.Size = New System.Drawing.Size(169, 32)
        Me.btnExport_Savings.TabIndex = 211
        Me.btnExport_Savings.Text = "Export Savings Report"
        Me.btnExport_Savings.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(161, 46)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(232, 17)
        Me.Label12.TabIndex = 191
        Me.Label12.Text = "PERSONAL SAVINGS REPORT"
        '
        'DgvPSavings
        '
        Me.DgvPSavings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPSavings.Location = New System.Drawing.Point(162, 87)
        Me.DgvPSavings.Name = "DgvPSavings"
        Me.DgvPSavings.Size = New System.Drawing.Size(844, 449)
        Me.DgvPSavings.TabIndex = 212
        '
        'btnRefresh_Savings
        '
        Me.btnRefresh_Savings.BackColor = System.Drawing.Color.LimeGreen
        Me.btnRefresh_Savings.FlatAppearance.BorderSize = 0
        Me.btnRefresh_Savings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh_Savings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh_Savings.ForeColor = System.Drawing.Color.White
        Me.btnRefresh_Savings.Location = New System.Drawing.Point(895, 40)
        Me.btnRefresh_Savings.Name = "btnRefresh_Savings"
        Me.btnRefresh_Savings.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh_Savings.TabIndex = 251
        Me.btnRefresh_Savings.Text = "Refresh List"
        Me.btnRefresh_Savings.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(491, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 16)
        Me.Label2.TabIndex = 334
        Me.Label2.Text = "Search for Record :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(639, 39)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(154, 20)
        Me.txtSearch.TabIndex = 333
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.ForeColor = System.Drawing.Color.DimGray
        Me.lb.Location = New System.Drawing.Point(24, 22)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(39, 13)
        Me.lb.TabIndex = 335
        Me.lb.Text = "Label1"
        '
        'Fsavings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 665)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnRefresh_Savings)
        Me.Controls.Add(Me.DgvPSavings)
        Me.Controls.Add(Me.btnExport_Savings)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fsavings"
        Me.Text = "Fsavings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvPSavings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExport_Savings As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DgvPSavings As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh_Savings As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lb As System.Windows.Forms.Label
End Class
