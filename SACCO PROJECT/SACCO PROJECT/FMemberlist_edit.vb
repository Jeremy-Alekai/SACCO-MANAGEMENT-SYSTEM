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
            Dim str As String = "INSERT INTO Member_details(Name,Title,Marital_Status,Email,Nationality,password,Place_Of_Birth,DOB,Gender,TelNo,Residence,Town,Next_Of_Kin,NOK_Relationship,NOK_TelNo,Name_of_Employer,Employer_Tel,Employer_Town,Occupation,AC_No,Schemes,Employer_Location,Position_Held,Terms_of_Service,Bank_name,Bank_Branch,Monthly_Contribution,Payment_Method,Position_in_SACCO) VALUES('" & txtName.Text & "','" & cboTitle.Text & "','" & cboMarital_Status.Text & "','" & txtEmail.Text & "','" & txtNationality.Text & "','" & txtBirth_place.Text & "','" & dtpdbirth.Text & "','" & cboGender.Text & "','" & txtMy_Tel.Text & "','" & txtPassword.Text & "','" & txtResidence.Text & "','" & txtmy_Town.Text & "','" & txtNOK.Text & "','" & txtNOK_Relation.Text & "','" & txtNOK_Tel.Text & "','" & txtEmployeer.Text & "','" & txtEmp_Num.Text & "','" & txtEmp_Town.Text & "','" & txtOccupation.Text & "','" & txtAC_No.Text & "','" & cboSchemes.Text & "','" & txtEmp_Location.Text & "','" & txtEmp_Position.Text & "','" & cboService.Text & "','" & txtBank_Name.Text & "','" & txtBank_Branch.Text & "','" & txtContribution.Text & "','" & txtPay_method.Text & "','" & cboSACC0_Position.Text & "')"
            ourconn.Open()
            Dim mysc As New MySqlCommand(str, ourconn)
            mysc.ExecuteNonQuery()
            MsgBox("Member Details updated successfully", MsgBoxStyle.Information)
            ourconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            ourconn.Close()
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
        txtBirth_place.Clear()
        txtBank_Name.Clear()
        txtContribution.Clear()
        txtEmail.Clear()
        txtEmp_Location.Clear()
        txtEmp_Position.Clear()
        txtEmp_Town.Clear()

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

            ourconn.Open()
            .SelectCommand = New MySqlCommand
            .SelectCommand.CommandText = "SELECT * FROM Member_details"
            .SelectCommand.Connection = ourconn
            DtaSet.Clear()
            MyDa.Fill(DtaSet, "Member_details")

            ourconn.Close()
        End With
    End Sub
End Class