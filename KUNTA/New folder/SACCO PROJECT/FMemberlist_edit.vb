Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FMemberlist_edit
    Public ourconn As New MySqlConnection("Server=localhost;Uid=root;Database=sacco_db;Port=3306")
    Public MyDa As New MySqlDataAdapter
    Public DtaSet As New DataSet
    Public adaptor As New MySqlDataAdapter
    Public dset As New DataSet
    Public DtaSet2 As New DataSet
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave_Changes.Click
        Try
            Dim cmd = New MySqlCommand("UPDATE Member_details SET Name=@OurName,Title=@OurTitle,Marital_Status=@OurMarital_Status,Email=@OurEmail,Nationality=@OurNationality,password=@Ourpassword,Place_Of_Birth=@OurPlace_Of_Birth,DOB=@OurDOB,Gender=@OurGender,TelNo=@OurTelNo,Residence=@OurResidence,Town=@OurTown,Next_Of_Kin=@OurNext_Of_Kin,NOK_Relationship=@OurNOK_Relationship,NOK_TelNo=@OurNOK_TelNo,Name_of_Employer=@OurName_of_Employer,Employer_Tel=@OurEmployer_Tel,Employer_Town=@OurEmployer_Town,Occupation=@OurOccupation,AC_No=@OurAC_No,Schemes=@OurSchemes,Employer_Location=@OurEmployer_Location,Position_Held=@OurPosition_Held,Terms_of_Service=@OurTerms_of_Service,Bank_name=@OurBank_name,Bank_Branch=@OurBank_Branch,Monthly_Contribution=@OurMonthly_Contribution,Payment_Method=@OurPayment_Method,Position_in_SACCO=@OurPosition_in_SACCO where MemberID='" & txtMemberID.Text.Trim & "'", ourconn)
            ourconn.Open()
            'Dim mysc As New MySqlCommand(str, ourconn)
            With cmd
                .Parameters.AddWithValue("OurName", txtName.Text.Trim)
                .Parameters.AddWithValue("OurTitle", cboTitle.Text.Trim)
                .Parameters.AddWithValue("OurMarital_Status", txtstatus.Text.Trim)
                .Parameters.AddWithValue("OurEmail", txtEmail.Text.Trim)
                .Parameters.AddWithValue("OurNationality", txtNationality.Text.Trim)

                .Parameters.AddWithValue("OurPlace_Of_Birth", txtBirth_place.Text.Trim)
                .Parameters.AddWithValue("OurDOB", dtpdbirth.Text.Trim)
                .Parameters.AddWithValue("OurGender", cboGender.Text.Trim)
                .Parameters.AddWithValue("OurTelNo", txtMyTel.Text.Trim)
                .Parameters.AddWithValue("OurResidence", txtResidence.Text.Trim)
                .Parameters.AddWithValue("OurTown", txtTown.Text.Trim)
                .Parameters.AddWithValue("OurNext_Of_Kin", txtNOK.Text.Trim)
                .Parameters.AddWithValue("OurNOK_Relationship", txtNOK_Relation.Text.Trim)
                .Parameters.AddWithValue("OurNOK_TelNo", txtTel_NOK.Text.Trim)

                .Parameters.AddWithValue("OurName_of_Employer", txtEmployeer.Text.Trim)
                .Parameters.AddWithValue("OurEmployer_Tel", txtEmp_Num.Text.Trim)
                .Parameters.AddWithValue("OurEmployer_Town", txtEmp_Town.Text.Trim)
                .Parameters.AddWithValue("OurOccupation", txtEmp_Position.Text.Trim)
                .Parameters.AddWithValue("OurSchemes", cboSchemes.Text.Trim)
                .Parameters.AddWithValue("OurEmployer_Location", txtEmp_Location.Text.Trim)


                .Parameters.AddWithValue("OurTerms_of_Service", cboService.Text.Trim)
                .Parameters.AddWithValue("OurBank_name", txtBank_Name.Text.Trim)
                .Parameters.AddWithValue("OurBank_Branch", txtBank_Branch.Text.Trim)
                .Parameters.AddWithValue("OurMonthly_Contribution", txtContribution.Text.Trim)
                .Parameters.AddWithValue("OurPayment_Method", txtPay_method.Text.Trim)
                .Parameters.AddWithValue("OurPosition_in_SACCO", cboSACC0_Position.Text.Trim)
                .Parameters.AddWithValue("Ourpassword", txtPassword.Text.Trim)

            End With
            cmd.ExecuteNonQuery()
            MsgBox("MEMBER ACCOUNT HAS BEEN SUCCESSFULLY UPDATED", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "")
            ourconn.Close()
            btnRefresh.PerformClick()

        Catch ex As Exception
            MsgBox(ex.Message, 0 + 48, "Error Occured")
        End Try
        btnClear.PerformClick()

        Me.btnRefresh.PerformClick()
    End Sub

    Private Sub FMemberlist_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With ourconn
                With MyDa
                    .SelectCommand = New MySqlCommand
                    .SelectCommand.CommandText = "SELECT * FROM Member_details"
                    .SelectCommand.Connection = ourconn
                    Dim Ole As New MySqlCommandBuilder(MyDa)
                    DtaSet.Clear()
                    .Fill(DtaSet, "Member_details")
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
            .DataMember = "Member_details"
            .Columns(0).DataPropertyName = "MemberID"
            .Columns(1).DataPropertyName = "Title"
            .Columns(2).DataPropertyName = "Name"
            .Columns(3).DataPropertyName = "Marital_Status"
            .Columns(4).DataPropertyName = "Email"
            .Columns(5).DataPropertyName = "password"

            .Columns(0).HeaderText = "Member ID"
            .Columns(1).HeaderText = "Title"
            .Columns(2).HeaderText = "Name"
            .Columns(3).HeaderText = "Marital_Status"
            .Columns(4).HeaderText = "Email"
            .Columns(5).HeaderText = "Password"
            .Columns(0).Width = 90
            .Columns(1).Width = 50
            .Columns(2).Width = 120
            .Columns(4).Width = 150
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
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
        txtMyTel.Clear()
        txtTel_NOK.Clear()
        txtTown.Clear()

    End Sub

    Private Sub Dvg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If DtaSet.Tables("Member_details").Rows.Count = 0 Then
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
        Dim titleStrBind As String

        CurrencyMngr = CType(BindingContext.Item(DtaSet, "Member_details"), CurrencyManager)
        DtaView = CType(CurrencyMngr.Current, DataRowView)
        MemberIDStrBind = CType(DtaView.Item("MemberID").ToString, String)

        NameStrBind = CType(DtaView.Item("Name").ToString, String)
        titleStrBind = CType(DtaView.Item("Title").ToString, String)

        txtMemberID.Text = MemberIDStrBind

        txtName.Text = NameStrBind
        cboTitle.Text = titleStrBind

        btnSave_Changes.Enabled = True
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        With MyDa
            ourconn.Close()
            ourconn.Open()
            .SelectCommand = New MySqlCommand
            .SelectCommand.CommandText = "SELECT * FROM Member_details"
            .SelectCommand.Connection = ourconn
            DtaSet.Clear()
            MyDa.Fill(DtaSet, "Member_details")

            ourconn.Close()
        End With
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim cmd As New MySqlCommand(" SELECT * FROM Member_details  WHERE MemberID like '" & txtSearch.Text & "%' or Name like '" & txtSearch.Text & "%' ", ourconn)
        adaptor.SelectCommand = cmd
        dset.Clear()

        adaptor.Fill(dset, "Member_details")
        Dgv.DataSource = dset.Tables("Member_details")


        Dgv.Columns(0).DataPropertyName = "MemberID"
        Dgv.Columns(1).DataPropertyName = "Title"
        Dgv.Columns(2).DataPropertyName = "Name"
        Dgv.Columns(3).DataPropertyName = "Marital_Status"
        Dgv.Columns(4).DataPropertyName = "Email"
        Dgv.Columns(5).DataPropertyName = "password"

        Dgv.Columns(0).HeaderText = "Member ID"
        Dgv.Columns(1).HeaderText = "Title"
        Dgv.Columns(2).HeaderText = "Name"
        Dgv.Columns(3).HeaderText = "Marital_Status"
        Dgv.Columns(4).HeaderText = "Email"
        Dgv.Columns(5).HeaderText = "Password"
        Dgv.Columns(0).Width = 90
        Dgv.Columns(1).Width = 50
        Dgv.Columns(2).Width = 120
        Dgv.Columns(4).Width = 150

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

    Private Sub GroupBox9_Enter(sender As Object, e As EventArgs) Handles GroupBox9.Enter

    End Sub
End Class