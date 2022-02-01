Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Floans_list
    Public ourconn As New MySqlConnection("Server=localhost;Uid=root;Database=sacco_db;Port=3306")
    Public MyDa As New MySqlDataAdapter
    Public DtaSet As New DataSet
    Public adaptor As New MySqlDataAdapter
    Public dset As New DataSet
    Public DtaSet2 As New DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd_loan.Click
        Try
            Dim str As String = "INSERT INTO Loans(MemberID,Name,Employment_Postion,Payroll_num,Loan_interest,Monthly_NetIncome,Loan_Amount,My_Tel,email,Emp_name,Employer_tel,Emp_address,Terms_of_service,expiry_date,Position_in_sacco) VALUES('" & txtMemberID.Text & "','" & txtName.Text & "','" & txtEmp_position.Text & "','" & txtPayroll_num.Text & "','" & txtIoan_Interest.Text & "','" & txtLoanAmount.Text & "','" & txtExpenditure.Text & "','" & txtMy_Tel.Text & "','" & txtEmail.Text & "','" & txtEmp_nam.Text & "','" & txtEmp_num.Text & "','" & txtEmp_Address.Text & "','" & cboTerms_of_service.Text & "','" & txtExpiry.Text & "','" & cboSACCO_Position.Text & "')"
            ourconn.Open()
            Dim mysc As New MySqlCommand(str, ourconn)
            mysc.ExecuteNonQuery()
            MsgBox("Loan Added successfully", MsgBoxStyle.Information)
            ourconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            ourconn.Close()
        End Try
        btnClear.PerformClick()

        btnRefresh.PerformClick()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If DtaSet.Tables("Loans").Rows.Count = 0 Then
            MsgBox("No record's to edit...", MsgBoxStyle.Information, "No record...")
            Exit Sub
        End If

        If Me.Dgv.CurrentRow.Selected = 0 Then
            MsgBox("Please highlighted or double click the record to edit...", MsgBoxStyle.Information, "Select...")
            Exit Sub
        End If

        DtaSet2 = New DataSet()

        Dim CurrencyMngr As CurrencyManager
        Dim DtaView As DataRowView


        Dim MemberIDStrBind As String
        Dim NameStrBind As String
        Dim MyTel_StrBind As String
        Dim EmploymentPostion_StrBind As String
        Dim Payroll_num_StrBind As String
        Dim LoanInterest_StrBind As String
        Dim LoanNum_StrBind As String
        Dim MonthlyExp_StrBind As String
        Dim email_StrBind As String
        Dim EmpName_StrBind As String
        Dim EmployerTel_StrBind As String
        Dim EmpAddress_StrBind As String
        Dim TermsOfservice_StrBind As String
        Dim expiry_date_StrBind As String
        Dim PositionSacco_StrBind As String
        Dim MonthlyNetIncome_StrBind As String

        CurrencyMngr = CType(BindingContext.Item(DtaSet, "Loans"), CurrencyManager)
        DtaView = CType(CurrencyMngr.Current, DataRowView)

        LoanNum_StrBind = CType(DtaView.Item("Loan_No").ToString, String)
        MemberIDStrBind = CType(DtaView.Item("MemberID").ToString, String)
        NameStrBind = CType(DtaView.Item("Name").ToString, String)
        MyTel_StrBind = CType(DtaView.Item("My_Tel").ToString, String)
        EmploymentPostion_StrBind = CType(DtaView.Item("Employment_Postion").ToString, String)
        Payroll_num_StrBind = CType(DtaView.Item("Payroll_num").ToString, String)
        LoanInterest_StrBind = CType(DtaView.Item("Loan_interest").ToString, String)
        MonthlyExp_StrBind = CType(DtaView.Item("Loan_Amount").ToString, String)
        email_StrBind = CType(DtaView.Item("email").ToString, String)

        EmpName_StrBind = CType(DtaView.Item("Emp_name").ToString, String)
        EmployerTel_StrBind = CType(DtaView.Item("Employer_tel").ToString, String)
        EmpAddress_StrBind = CType(DtaView.Item("Emp_address").ToString, String)
        TermsOfservice_StrBind = CType(DtaView.Item("Terms_of_service").ToString, String)
        expiry_date_StrBind = CType(DtaView.Item("expiry_date").ToString, String)
        PositionSacco_StrBind = CType(DtaView.Item("Position_in_sacco").ToString, String)
        MonthlyNetIncome_StrBind = CType(DtaView.Item("Monthly_NetIncome").ToString, String)

        LoanID.Text = LoanNum_StrBind
        txtMemberID.Text = MemberIDStrBind
        txtName.Text = NameStrBind
        txtMy_Tel.Text = MyTel_StrBind
        txtEmp_position.Text = EmploymentPostion_StrBind
        txtPayroll_num.Text = Payroll_num_StrBind
        txtIoan_Interest.Text = LoanInterest_StrBind
        txtExpenditure.Text = MonthlyExp_StrBind
        txtEmail.Text = email_StrBind

        txtEmp_nam.Text = EmpName_StrBind
        txtEmp_num.Text = EmployerTel_StrBind
        txtEmp_Address.Text = EmpAddress_StrBind
        cboTerms_of_service.Text = TermsOfservice_StrBind
        txtExpiry.Text = expiry_date_StrBind
        cboSACCO_Position.Text = PositionSacco_StrBind
        txtLoanAmount.Text = MonthlyNetIncome_StrBind

        btnAdd_loan.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtMemberID.Clear()
        txtName.Clear()
        txtMy_Tel.Clear()
        txtEmp_position.Clear()
        txtPayroll_num.Clear()

        txtExpenditure.Clear()
        txtEmail.Clear()

        txtEmp_nam.Clear()
        txtEmp_num.Clear()
        txtEmp_Address.Clear()
        'cboTerms_of_service.Clear()
        txtExpiry.Clear()
        'cboSACCO_Position.Clear()
        txtLoanAmount.Clear()
        txtMemberID.Focus()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Fadd_Loan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With ourconn
                With MyDa
                    .SelectCommand = New MySqlCommand
                    .SelectCommand.CommandText = "SELECT * FROM Loans"
                    .SelectCommand.Connection = ourconn
                    Dim Ole As New MySqlCommandBuilder(MyDa)
                    DtaSet.Clear()
                    .Fill(DtaSet, "Loans")
                    Call DataConnection(Me.Dgv)
                End With
            End With

        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...Here...........")
        Finally
            ourconn.Close()
        End Try
    End Sub
    Public Sub DataConnection(ByVal DgV As DataGridView)

        With DgV
            .DataSource = DtaSet
            .DataMember = "Loans"
            .Columns(0).DataPropertyName = "Loan_No"
            .Columns(1).DataPropertyName = "MemberID"
            .Columns(2).DataPropertyName = "Name"
            .Columns(3).DataPropertyName = "Employment_Postion"
            .Columns(4).DataPropertyName = "Payroll_num"

            .Columns(5).DataPropertyName = "Loan_Amount"
            .Columns(6).DataPropertyName = "Loan_interest"
            .Columns(7).DataPropertyName = "Monthly_exp"
            .Columns(8).DataPropertyName = "My_Tel"
            .Columns(9).DataPropertyName = "email"
            .Columns(10).DataPropertyName = "Emp_name"
            .Columns(11).DataPropertyName = "Employer_tel"
            '.Columns(12).DataPropertyName = "Emp_address"
            .Columns(12).DataPropertyName = "Terms_of_service"
            .Columns(13).DataPropertyName = "expiry_date"
            .Columns(14).DataPropertyName = "Position_in_sacco"

            .Columns(0).HeaderText = "Loan_Number"
            .Columns(1).HeaderText = "Member ID"
            .Columns(2).HeaderText = "Name"
            .Columns(3).HeaderText = "Employment_Postion"
            .Columns(4).HeaderText = "Payroll_num"
            .Columns(5).HeaderText = "Loan_Amount"
            .Columns(6).HeaderText = "Loan_interest"
            .Columns(7).HeaderText = "Monthly_exp"
            .Columns(8).HeaderText = "My_Tel"
            .Columns(9).HeaderText = "email"
            .Columns(10).HeaderText = "Emp_name"
            .Columns(11).HeaderText = "Employer_tel"
            '.Columns(12).HeaderText = "Emp_address"
            .Columns(12).HeaderText = "Terms_of_service"
            .Columns(13).HeaderText = "expiry_date"
            .Columns(14).HeaderText = "Position_in_sacco"
            '.Columns(0).Width = 90
            '.Columns(1).Width = 50
            '.Columns(2).Width = 50
            '.Columns(4).Width = 150
            .ReadOnly = True
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ShowRowErrors = False
            .ShowCellErrors = False
            .AllowUserToAddRows = False ' Disabled or hide (*) Symbol...
            .AllowUserToResizeColumns = False 'Disable HearderText Resize Column...
            .AllowUserToResizeRows = False 'Disabled  row resize...
            .RowHeadersVisible = False 'To hide Left indicator...
            .DefaultCellStyle.SelectionBackColor = Color.SteelBlue  'Selection backcolor....
            .DefaultCellStyle.ForeColor = Color.Black  'Selection backcolor....
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGoldenrodYellow 'Alternating Backcolor

        End With
    End Sub


    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click, Label6.Click

    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles txtLoanAmount.TextChanged

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        With MyDa

            ourconn.Open()
            .SelectCommand = New MySqlCommand
            .SelectCommand.CommandText = "SELECT * FROM Loans"
            .SelectCommand.Connection = ourconn
            DtaSet.Clear()
            MyDa.Fill(DtaSet, "Loans")

            ourconn.Close()
        End With
    End Sub

    Private Sub btnLoan_Remove_Click(sender As Object, e As EventArgs) Handles btnLoan_Remove.Click
        If DtaSet.Tables("Loans").Rows.Count = 0 Then
            MsgBox("No record's to delete...", MsgBoxStyle.Information, "No record's")
            Exit Sub
        End If
        If Me.Dgv.CurrentRow.Selected = 0 Then
            MsgBox("Please select or highlighted record to delete...", MsgBoxStyle.Information, "Select...")
            Exit Sub
        End If

        If MsgBox("Do you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Confirmation...") = MsgBoxResult.Yes Then
            MsgBox(Me.Dgv.SelectedRows(0).Cells(1).Value & " " & Me.Dgv.SelectedRows(0).Cells(2).Value & "  Successfully deleted...", MsgBoxStyle.Information, "Deleted...")
            Me.BindingContext(DtaSet, "Loans").EndCurrentEdit()
            Me.BindingContext(DtaSet, "Loans").RemoveAt(Me.BindingContext(DtaSet, "Loans").Position)
            MyDa.Update(DtaSet, "Loans")

        Else
            MsgBox("Deletion canceled...", MsgBoxStyle.Information, "Canceled..")
        End If

    End Sub

    Private Sub btnSave_Changes_Click(sender As Object, e As EventArgs) Handles btnSave_Changes.Click
        Try
            ourconn.Close()
            ourconn.Open()
            Dim cmd = New MySqlCommand("UPDATE Loans SET MemberID=@OurMemberID,Name=@OurName where Loan_No='" & LoanID.Text.Trim & "'", ourconn)
            ',,Employment_Postion,Payroll_num,Loan_interest,Monthly_NetIncome,Monthly_exp,My_Tel,email,Emp_name,Employer_tel,Emp_address,Terms_of_service,expiry_date,Position_in_sacco) VALUES('" & .Text & "','" & .Text & "','" & txtEmp_position.Text & "','" & txtPayroll_num.Text & "','" & txtIoan_Interest.Text & "','" & txtNet_Income.Text & "','" & txtExpenditure.Text & "','" & txtMy_Tel.Text & "','" & txtEmail.Text & "','" & txtEmp_nam.Text & "','" & txtEmp_num.Text & "','" & txtEmp_Address.Text & "','" & cboTerms_of_service.Text & "','" & txtExpiry.Text & "','" & cboSACCO_Position.Text & "')"
            With cmd
                .Parameters.AddWithValue("OurMemberID", txtMemberID.Text.Trim)
                .Parameters.AddWithValue("OurName", txtName.Text.Trim)
            End With

            'Try
            cmd.ExecuteNonQuery()
            MsgBox("NEW DETAILS HAVE BEEN SUCCESSFULLY UPDATED", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "")
            ourconn.Close()


        Catch ex As Exception
            MsgBox(ex.Message, 0 + 48, "Error Occured")
        End Try
        btnClear.PerformClick()
        btnRefresh.PerformClick()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim cmd As New MySqlCommand(" SELECT * FROM Loans  WHERE Name like '" & txtSearch.Text & "%' or MemberID like '" & txtSearch.Text & "%' ", ourconn)
        adaptor.SelectCommand = cmd
        dset.Clear()

        adaptor.Fill(dset, "Loans")
        Dgv.DataSource = dset.Tables("Loans")


        Dgv.Columns(0).DataPropertyName = "Loan_No"
        Dgv.Columns(1).DataPropertyName = "MemberID"
        Dgv.Columns(2).DataPropertyName = "Name"
        Dgv.Columns(3).DataPropertyName = "Employment_Postion"
        Dgv.Columns(4).DataPropertyName = "Payroll_num"

        Dgv.Columns(5).DataPropertyName = "Loan_Amount"
        Dgv.Columns(6).DataPropertyName = "Loan_interest"
        Dgv.Columns(7).DataPropertyName = "Monthly_exp"
        Dgv.Columns(8).DataPropertyName = "My_Tel"
        Dgv.Columns(9).DataPropertyName = "email"
        Dgv.Columns(10).DataPropertyName = "Emp_name"
        Dgv.Columns(11).DataPropertyName = "Employer_tel"
        'Dgv.Columns(12).DataPropertyName = "Emp_address"
        Dgv.Columns(12).DataPropertyName = "Terms_of_service"
        Dgv.Columns(13).DataPropertyName = "expiry_date"
        Dgv.Columns(14).DataPropertyName = "Position_in_sacco"

        Dgv.Columns(0).HeaderText = "Loan_Number"
        Dgv.Columns(1).HeaderText = "Member ID"
        Dgv.Columns(2).HeaderText = "Name"
        Dgv.Columns(3).HeaderText = "Employment_Postion"
        Dgv.Columns(4).HeaderText = "Payroll_num"
        Dgv.Columns(5).HeaderText = "Loan_Amount"
        Dgv.Columns(6).HeaderText = "Loan_interest"
        Dgv.Columns(7).HeaderText = "Monthly_exp"
        Dgv.Columns(8).HeaderText = "My_Tel"
        Dgv.Columns(9).HeaderText = "email"
        Dgv.Columns(10).HeaderText = "Emp_name"
        Dgv.Columns(11).HeaderText = "Employer_tel"
        'Dgv.Columns(12).HeaderText = "Emp_address"
        Dgv.Columns(12).HeaderText = "Terms_of_service"
        Dgv.Columns(13).HeaderText = "expiry_date"
        Dgv.Columns(14).HeaderText = "Position_in_sacco"
        'Dgv.Columns(0).Width = 90
        'Dgv.Columns(1).Width = 50
        'Dgv.Columns(2).Width = 50
        'Dgv.Columns(4).Width = 150

        Dgv.ReadOnly = True
        Dgv.MultiSelect = False
        Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dgv.ShowRowErrors = False
        Dgv.ShowCellErrors = False
        Dgv.AllowUserToAddRows = False ' Disabled or hide (*) Symbol...
        Dgv.AllowUserToResizeColumns = False 'Disable HearderText Resize Column...
        Dgv.AllowUserToResizeRows = False 'Disabled  row resize...
        Dgv.RowHeadersVisible = False 'To hide Left indicator...
        Dgv.DefaultCellStyle.SelectionBackColor = Color.SteelBlue  'Selection backcolor....
        Dgv.DefaultCellStyle.ForeColor = Color.Black  'Selection backcolor....
        Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGoldenrodYellow 'Alternating Backcolor
    End Sub

    Private Sub txtTOT_TextChanged(sender As Object, e As EventArgs) Handles txtNet_Income.TextChanged
        txtNet_Income.Text = CInt(txtIoan_Interest.Text / 100) * CInt(txtLoanAmount.Text)
    End Sub
End Class