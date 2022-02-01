Imports MySql.Data.MySqlClient
Public Class Fadd_savings
    Public ourconn As New MySqlConnection("Server=localhost;Uid=root;Database=sacco_db;Port=3306")
    Public MyDa As New MySqlDataAdapter
    Public DtaSet As New DataSet
    Public adaptor As New MySqlDataAdapter
    Public dset As New DataSet
    Public DtaSet2 As New DataSet
    Private Sub btnLoanedit_Click(sender As Object, e As EventArgs) Handles btnSubmit_loan.Click
        Try
            Dim str As String = "INSERT INTO personal_savings(MemberID,Name,Residence,Tel,Amount,Deposit_Date) VALUES('" & txtMember_ID.Text & "','" & txtNames.Text & "','" & txtResidence.Text & "','" & txtTel.Text & "','" & txtAmount.Text & "','" & dtpDate.Text & "')"
            ourconn.Open()
            Dim mysc As New MySqlCommand(str, ourconn)
            mysc.ExecuteNonQuery()
            MsgBox("Savings added successfully", MsgBoxStyle.Information)
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