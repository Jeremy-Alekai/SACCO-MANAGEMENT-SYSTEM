Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Fmember_list
    Public ourconn As New MySqlConnection("Server=localhost;Uid=root;Database=sacco_db;Port=3306")
    Public MyDa As New MySqlDataAdapter
    Public DtaSet As New DataSet
    Public adaptor As New MySqlDataAdapter
    Public dset As New DataSet
    Public DtaSet2 As New DataSet
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles btnAdd_Member.Click
        Fadd_Member.Show()
    End Sub

    Private Sub Fmember_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

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

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
       
        FMemberlist_edit.Show()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If DtaSet.Tables("Member_details").Rows.Count = 0 Then
            MsgBox("No record's to delete...", MsgBoxStyle.Information, "No record's")
            Exit Sub
        End If
        If Me.Dgv.CurrentRow.Selected = 0 Then
            MsgBox("Please select or highlighted record to delete...", MsgBoxStyle.Information, "Select...")
            Exit Sub
        End If

        If MsgBox("Do you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Confirmation...") = MsgBoxResult.Yes Then
            MsgBox(Me.Dgv.SelectedRows(0).Cells(1).Value & " " & Me.Dgv.SelectedRows(0).Cells(2).Value & "  Successfully deleted...", MsgBoxStyle.Information, "Deleted...")
            Me.BindingContext(DtaSet, "Member_details").EndCurrentEdit()
            Me.BindingContext(DtaSet, "Member_details").RemoveAt(Me.BindingContext(DtaSet, "Member_details").Position)
            MyDa.Update(DtaSet, "Member_details")

        Else
            MsgBox("Deletion canceled...", MsgBoxStyle.Information, "Canceled..")
        End If
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