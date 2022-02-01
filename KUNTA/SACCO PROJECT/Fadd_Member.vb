Imports MySql.Data.MySqlClient

Public Class Fadd_Member
    Public ourconn As New MySqlConnection("Server=localhost;Uid=root;Database=sacco_db;Port=3306")
    Public MyDa As New MySqlDataAdapter
    Public DtaSet As New DataSet
    Public adaptor As New MySqlDataAdapter
    Public dset As New DataSet
    Public DtaSet2 As New DataSet
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim str As String = "INSERT INTO Member_details(Name,Title,Marital_Status,Email,Nationality,password,Place_Of_Birth,DOB,Gender,TelNo,Residence,Town,Next_Of_Kin,NOK_Relationship,NOK_TelNo,Name_of_Employer,Employer_Tel,Employer_Town,Occupation,AC_No,Schemes,Employer_Location,Position_Held,Terms_of_Service,Bank_name,Bank_Branch,Monthly_Contribution,Payment_Method,Position_in_SACCO) VALUES('" & txtName.Text & "','" & cboTitle.Text & "','" & cboMarital_Status.Text & "','" & txtEmail.Text & "','" & txtNationality.Text & "','" & txtBirth_place.Text & "','" & dtpdbirth.Text & "','" & cboGender.Text & "','" & txtTel.Text & "','" & txtPassword.Text & "','" & txtResidence.Text & "','" & txtTown.Text & "','" & txtNOK.Text & "','" & txtNOK_Relation.Text & "','" & txtTel_NOK.Text & "','" & txtEmployeer.Text & "','" & txtEmp_Num.Text & "','" & txtEmp_Town.Text & "','" & txtOccupation.Text & "','" & txtAC_No.Text & "','" & cboSchemes.Text & "','" & txtEmp_Location.Text & "','" & txtEmp_Position.Text & "','" & cboService.Text & "','" & txtBank_Name.Text & "','" & txtBank_Branch.Text & "','" & txtContribution.Text & "','" & cboPay_method.Text & "','" & cboSACC0_Position.Text & "')"
            ourconn.Open()
            Dim mysc As New MySqlCommand(str, ourconn)
            mysc.ExecuteNonQuery()
            MsgBox("Students Account created successfully", MsgBoxStyle.Information)
            ourconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            ourconn.Close()
        End Try
        btnClear.PerformClick()

        Fmember_list.btnRefresh.PerformClick()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click, Label18.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtAC_No.Clear()
        txtBank_Branch.Clear()
        txtBank_Name.Clear()
        txtBirth_place.Clear()
        txtContribution.Clear()
        txtEmail.Clear()
        txtEmp_Location.Clear()
        txtEmp_Num.Clear()
        txtEmp_Position.Clear()
        txtEmp_Town.Clear()
        txtEmployeer.Clear()
        txtName.Clear()
        txtNationality.Clear()
        txtNOK.Clear()
        txtNOK_Relation.Clear()
        txtOccupation.Clear()
        txtPassword.Clear()
        txtResidence.Clear()
        txtTel.Clear()
        txtTel_NOK.Clear()
        txtTown.Clear()



    End Sub
End Class