Imports MySql.Data.MySqlClient
Public Class Fadd_savings
    Public ourconn As New MySqlConnection("Server=localhost;Uid=root;Database=sacco_db;Port=3306;pooling =false; convert zero datetime= True")
    Public MyDa As New MySqlDataAdapter
    Public DtaSet As New DataSet
    Public adaptor As New MySqlDataAdapter
    Public dset As New DataSet
    Public DtaSet2 As New DataSet
    Private Sub btnLoanedit_Click(sender As Object, e As EventArgs) Handles btnSubmit_loan.Click
        ' (MemberID,Name,Tel,Amount,Deposit_Date,Residence) VALUES ('" & txtMember_ID.Text & "','" & txtNames.Text & "','" & txtTel.Text & "','" & txtAmount.Text & "','" & dtpDate.Text & "','" & txtResidence.Text & "')"
        Try
            Dim mydate = Now
            'Log Transactions of Savings
            'transaction_details
            Dim ourstr As String = "INSERT INTO personal_savings (MemberID,Name,Tel,Amount,Deposit_Date,Residence) VALUES ('" & txtMember_ID.Text & "','" & txtNames.Text & "','" & txtTel.Text & "','" & txtAmount.Text & "','" & dtpDate.Text & "','" & txtResidence.Text & "')"

            ourconn.Open()
            Dim mysccom As New MySqlCommand(ourstr, ourconn)
            mysccom.ExecuteNonQuery()


            'Get Current Savings Balance For target account Number
            'Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM personal_savings WHERE MemberID = " & txtMember_ID.Text & "", ourconn)
            'Dim sda As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            'Dim mybal As DataTable = New DataTable()
            'sda.Fill(mybal)
            'Dim currentbalance As Double
            'currentbalance = mybal.Rows(0).Item(4)

            'Update Savings Balance
            'Dim newbalance As Double = CInt(txtAmount.Text) + currentbalance
            'MsgBox(newbalance)
            'Dim savestr As String = "UPDATE personal_savings SET Amount = " & newbalance & " WHERE MemberID = " & txtMember_ID.Text & ""
            'Dim mysavbal As New MySqlCommand(savestr, ourconn)
            'mysavbal.ExecuteNonQuery()
            'MsgBox("Savings Added successfully", MsgBoxStyle.Information)
            ourconn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            ourconn.Close()
        End Try

        btnClear.PerformClick()

        Fsavings_list.btnRefresh_Savings.PerformClick()

    End Sub

    Private Sub btnCancel_Loan_Click(sender As Object, e As EventArgs) Handles btnCancel_Loan.Click
        Me.Close()
    End Sub


    Private Sub Fadd_savings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMember_ID.Clear()
    End Sub
End Class