<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fsavings_view
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.btnRefresh_Savingsview = New System.Windows.Forms.Button()
        Me.btnExport_SACCOLoan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(58, 21)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 17)
        Me.Label12.TabIndex = 231
        Me.Label12.Text = "SACCO Savings List"
        '
        'Dgv
        '
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Location = New System.Drawing.Point(74, 77)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(810, 475)
        Me.Dgv.TabIndex = 248
        '
        'btnRefresh_Savingsview
        '
        Me.btnRefresh_Savingsview.BackColor = System.Drawing.Color.LimeGreen
        Me.btnRefresh_Savingsview.FlatAppearance.BorderSize = 0
        Me.btnRefresh_Savingsview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh_Savingsview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh_Savingsview.ForeColor = System.Drawing.Color.White
        Me.btnRefresh_Savingsview.Location = New System.Drawing.Point(745, 21)
        Me.btnRefresh_Savingsview.Name = "btnRefresh_Savingsview"
        Me.btnRefresh_Savingsview.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh_Savingsview.TabIndex = 250
        Me.btnRefresh_Savingsview.Text = "Refresh List"
        Me.btnRefresh_Savingsview.UseVisualStyleBackColor = False
        '
        'btnExport_SACCOLoan
        '
        Me.btnExport_SACCOLoan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExport_SACCOLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport_SACCOLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport_SACCOLoan.ForeColor = System.Drawing.Color.White
        Me.btnExport_SACCOLoan.Location = New System.Drawing.Point(745, 599)
        Me.btnExport_SACCOLoan.Name = "btnExport_SACCOLoan"
        Me.btnExport_SACCOLoan.Size = New System.Drawing.Size(169, 32)
        Me.btnExport_SACCOLoan.TabIndex = 254
        Me.btnExport_SACCOLoan.Text = "Export Savings Report"
        Me.btnExport_SACCOLoan.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 16)
        Me.Label2.TabIndex = 336
        Me.Label2.Text = "Search for Record :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(474, 21)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(154, 20)
        Me.txtSearch.TabIndex = 335
        '
        'Fsavings_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 656)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnExport_SACCOLoan)
        Me.Controls.Add(Me.btnRefresh_Savingsview)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fsavings_view"
        Me.Text = "Fsavings_view"
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh_Savingsview As System.Windows.Forms.Button
    Friend WithEvents btnExport_SACCOLoan As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
End Class
