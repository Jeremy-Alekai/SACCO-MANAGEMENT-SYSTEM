<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fadd_savings
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNames = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMember_ID = New System.Windows.Forms.TextBox()
        Me.btnCancel_Loan = New System.Windows.Forms.Button()
        Me.btnSubmit_loan = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtResidence = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 249
        Me.Label3.Text = "Tel :"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(110, 108)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(173, 20)
        Me.txtTel.TabIndex = 3
        Me.txtTel.Text = "0708488261"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 249
        Me.Label2.Text = "Full Names"
        '
        'txtNames
        '
        Me.txtNames.Location = New System.Drawing.Point(110, 71)
        Me.txtNames.Name = "txtNames"
        Me.txtNames.Size = New System.Drawing.Size(238, 20)
        Me.txtNames.TabIndex = 1
        Me.txtNames.Text = "Jeremy alekai"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 249
        Me.Label1.Text = "Member ID"
        '
        'txtMember_ID
        '
        Me.txtMember_ID.Location = New System.Drawing.Point(110, 31)
        Me.txtMember_ID.Name = "txtMember_ID"
        Me.txtMember_ID.Size = New System.Drawing.Size(100, 20)
        Me.txtMember_ID.TabIndex = 0
        Me.txtMember_ID.Text = "02172"
        '
        'btnCancel_Loan
        '
        Me.btnCancel_Loan.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel_Loan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel_Loan.ForeColor = System.Drawing.Color.White
        Me.btnCancel_Loan.Location = New System.Drawing.Point(399, 213)
        Me.btnCancel_Loan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel_Loan.Name = "btnCancel_Loan"
        Me.btnCancel_Loan.Size = New System.Drawing.Size(85, 28)
        Me.btnCancel_Loan.TabIndex = 247
        Me.btnCancel_Loan.Text = "Cancel"
        Me.btnCancel_Loan.UseVisualStyleBackColor = False
        '
        'btnSubmit_loan
        '
        Me.btnSubmit_loan.BackColor = System.Drawing.Color.YellowGreen
        Me.btnSubmit_loan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit_loan.ForeColor = System.Drawing.Color.White
        Me.btnSubmit_loan.Location = New System.Drawing.Point(154, 213)
        Me.btnSubmit_loan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit_loan.Name = "btnSubmit_loan"
        Me.btnSubmit_loan.Size = New System.Drawing.Size(95, 28)
        Me.btnSubmit_loan.TabIndex = 246
        Me.btnSubmit_loan.Text = "Submit"
        Me.btnSubmit_loan.UseVisualStyleBackColor = False
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(110, 144)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(173, 20)
        Me.txtAmount.TabIndex = 4
        Me.txtAmount.Text = "20000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 249
        Me.Label4.Text = "Amount :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(376, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 249
        Me.Label5.Text = "Date :"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(431, 145)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 5
        '
        'txtResidence
        '
        Me.txtResidence.Location = New System.Drawing.Point(470, 72)
        Me.txtResidence.Name = "txtResidence"
        Me.txtResidence.Size = New System.Drawing.Size(161, 20)
        Me.txtResidence.TabIndex = 2
        Me.txtResidence.Text = "Mulago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(373, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 249
        Me.Label6.Text = "Residence :"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Chocolate
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(305, 213)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 27)
        Me.btnClear.TabIndex = 251
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Fadd_savings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 268)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtResidence)
        Me.Controls.Add(Me.txtNames)
        Me.Controls.Add(Me.txtMember_ID)
        Me.Controls.Add(Me.btnSubmit_loan)
        Me.Controls.Add(Me.btnCancel_Loan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fadd_savings"
        Me.Text = "Fadd_savings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNames As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMember_ID As System.Windows.Forms.TextBox
    Private WithEvents btnCancel_Loan As System.Windows.Forms.Button
    Private WithEvents btnSubmit_loan As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtResidence As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
