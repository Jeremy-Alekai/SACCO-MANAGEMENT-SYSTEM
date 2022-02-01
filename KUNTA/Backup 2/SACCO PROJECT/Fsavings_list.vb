Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Fsavings_list
    Public ourconn As New MySqlConnection("Server=localhost;Uid=root;Database=sacco_db;Port=3306")
    Public MyDa As New MySqlDataAdapter
    Public DtaSet As New DataSet
    Public adaptor As New MySqlDataAdapter
    Public dset As New DataSet
    Public DtaSet2 As New DataSet
    Private Sub Fsavings_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            With ourconn
                With MyDa
                    .SelectCommand = New MySqlCommand
                    .SelectCommand.CommandText = "SELECT MemberID,Name,Tel,Amount,Deposit_Date FROM personal_savings"
                    .SelectCommand.Connection = ourconn
                    Dim Ole As New MySqlCommandBuilder(MyDa)
                    DtaSet.Clear()
                    .Fill(DtaSet, "personal_savings")
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
            .DataMember = "personal_savings"
            .Columns(0).DataPropertyName = "MemberID"
            .Columns(1).DataPropertyName = "Name"
            .Columns(2).DataPropertyName = "Tel"
            .Columns(3).DataPropertyName = "Amount"
            .Columns(4).DataPropertyName = "Deposit_Date"

            .Columns(0).HeaderText = "Member ID"
            .Columns(1).HeaderText = "Name"
            .Columns(2).HeaderText = "Tel"
            .Columns(3).HeaderText = "Amount"
            .Columns(4).HeaderText = "Date"
            .Columns(2).Width = 120
            .Columns(4).Width = 200
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

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles btnAdd_savings.Click
        Fadd_savings.Show()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles btnRemove_Savings.Click
        If DtaSet.Tables("personal_savings").Rows.Count = 0 Then
            MsgBox("No record's to delete...", MsgBoxStyle.Information, "No record's")
            Exit Sub
        End If
        If Me.Dgv.CurrentRow.Selected = 0 Then
            MsgBox("Please select or highlighted record to delete...", MsgBoxStyle.Information, "Select...")
            Exit Sub
        End If

        If MsgBox("Do you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Confirmation...") = MsgBoxResult.Yes Then
            MsgBox(Me.Dgv.SelectedRows(0).Cells(1).Value & " " & Me.Dgv.SelectedRows(0).Cells(2).Value & "  Successfully deleted...", MsgBoxStyle.Information, "Deleted...")
            Me.BindingContext(DtaSet, "personal_savings").EndCurrentEdit()
            Me.BindingContext(DtaSet, "personal_savings").RemoveAt(Me.BindingContext(DtaSet, "personal_savings").Position)
            MyDa.Update(DtaSet, "personal_savings")

        Else
            MsgBox("Deletion canceled...", MsgBoxStyle.Information, "Canceled..")
        End If
    End Sub

    

    Private Sub btnRefresh_Savings_Click_1(sender As Object, e As EventArgs) Handles btnRefresh_Savings.Click
        With MyDa

            ourconn.Open()
            .SelectCommand = New MySqlCommand
            .SelectCommand.CommandText = "SELECT * FROM personal_savings"
            .SelectCommand.Connection = ourconn
            DtaSet.Clear()
            MyDa.Fill(DtaSet, "personal_savings")

            ourconn.Close()

        End With
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim cmd As New MySqlCommand(" SELECT * FROM personal_savings  WHERE MemberID like '" & txtSearch.Text & "%' or Name like '" & txtSearch.Text & "%' ", ourconn)
        adaptor.SelectCommand = cmd
        dset.Clear()

        adaptor.Fill(dset, "personal_savings")
        Dgv.DataSource = dset.Tables("personal_savings")


        Dgv.Columns(0).DataPropertyName = "MemberID"
        Dgv.Columns(1).DataPropertyName = "Name"
        Dgv.Columns(2).DataPropertyName = "Tel"
        Dgv.Columns(3).DataPropertyName = "Amount"
        Dgv.Columns(4).DataPropertyName = "Deposit_Date"

        Dgv.Columns(0).HeaderText = "Member ID"
        Dgv.Columns(1).HeaderText = "Name"
        Dgv.Columns(2).HeaderText = "Tel"
        Dgv.Columns(3).HeaderText = "Amount"
        Dgv.Columns(4).HeaderText = "Date"
        Dgv.Columns(2).Width = 120
        Dgv.Columns(4).Width = 200

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
End Class