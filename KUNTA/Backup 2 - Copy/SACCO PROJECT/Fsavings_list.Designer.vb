<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fsavings_list
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
        Me.btnAdd_savings = New System.Windows.Forms.Button()
        Me.btnRemove_Savings = New System.Windows.Forms.Button()
        Me.btnRefresh_Savings = New System.Windows.Forms.Button()
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
        Me.Label12.Location = New System.Drawing.Point(55, 41)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 17)
        Me.Label12.TabIndex = 211
        Me.Label12.Text = "SACCO Savings List"
        '
        'Dgv
        '
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Location = New System.Drawing.Point(91, 105)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(810, 465)
        Me.Dgv.TabIndex = 229
        '
        'btnAdd_savings
        '
        Me.btnAdd_savings.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd_savings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd_savings.ForeColor = System.Drawing.Color.White
        Me.btnAdd_savings.Location = New System.Drawing.Point(679, 56)
        Me.btnAdd_savings.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd_savings.Name = "btnAdd_savings"
        Me.btnAdd_savings.Size = New System.Drawing.Size(107, 30)
        Me.btnAdd_savings.TabIndex = 228
        Me.btnAdd_savings.Text = "Add Savings"
        Me.btnAdd_savings.UseVisualStyleBackColor = False
        '
        'btnRemove_Savings
        '
        Me.btnRemove_Savings.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove_Savings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove_Savings.ForeColor = System.Drawing.Color.White
        Me.btnRemove_Savings.Location = New System.Drawing.Point(811, 59)
        Me.btnRemove_Savings.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemove_Savings.Name = "btnRemove_Savings"
        Me.btnRemove_Savings.Size = New System.Drawing.Size(73, 27)
        Me.btnRemove_Savings.TabIndex = 226
        Me.btnRemove_Savings.Text = "remove"
        Me.btnRemove_Savings.UseVisualStyleBackColor = False
        '
        'btnRefresh_Savings
        '
        Me.btnRefresh_Savings.FlatAppearance.BorderSize = 0
        Me.btnRefresh_Savings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh_Savings.ForeColor = System.Drawing.Color.LightGray
        Me.btnRefresh_Savings.Location = New System.Drawing.Point(932, 277)
        Me.btnRefresh_Savings.Name = "btnRefresh_Savings"
        Me.btnRefresh_Savings.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh_Savings.TabIndex = 231
        Me.btnRefresh_Savings.Text = "refresh"
        Me.btnRefresh_Savings.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(311, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 16)
        Me.Label2.TabIndex = 336
        Me.Label2.Text = "Search for Record :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(459, 29)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(154, 20)
        Me.txtSearch.TabIndex = 335
        '
        'Fsavings_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 626)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnRefresh_Savings)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.btnAdd_savings)
        Me.Controls.Add(Me.btnRemove_Savings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fsavings_list"
        Me.Text = "Fsavinf"
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Dgv As System.Windows.Forms.DataGridView
    Private WithEvents btnAdd_savings As System.Windows.Forms.Button
    Private WithEvents btnRemove_Savings As System.Windows.Forms.Button
    Friend WithEvents btnRefresh_Savings As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
End Class
