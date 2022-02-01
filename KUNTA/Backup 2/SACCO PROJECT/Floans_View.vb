Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Floans_View
    Public ourconn As New MySqlConnection("Server=localhost;Uid=root;Database=sacco_db;Port=3306")
    Public MyDa As New MySqlDataAdapter
    Public DtaSet As New DataSet
    Public adaptor As New MySqlDataAdapter
    Public dset As New DataSet
    Public DtaSet2 As New DataSet
    Private Sub Floans_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            .Columns(7).DataPropertyName = "Monthly_NetIncome"
            .Columns(8).DataPropertyName = "My_Tel"
            .Columns(9).DataPropertyName = "email"
            .Columns(10).DataPropertyName = "Emp_name"
            .Columns(11).DataPropertyName = "Employer_tel"
            .Columns(12).DataPropertyName = "Emp_address"
            .Columns(13).DataPropertyName = "Terms_of_service"
            .Columns(14).DataPropertyName = "expiry_date"
            .Columns(15).DataPropertyName = "Position_in_sacco"

            .Columns(0).HeaderText = "Loan_Number"
            .Columns(1).HeaderText = "Member ID"
            .Columns(2).HeaderText = "Name"
            .Columns(3).HeaderText = "Employment_Postion"
            .Columns(4).HeaderText = "Payroll_num"
            .Columns(5).HeaderText = "Loan_Amount"
            .Columns(6).HeaderText = "Loan_interest"
            .Columns(7).HeaderText = "Monthly_NetIncome"
            .Columns(8).HeaderText = "My_Tel"
            .Columns(9).HeaderText = "email"
            .Columns(10).HeaderText = "Emp_name"
            .Columns(11).HeaderText = "Employer_tel"
            .Columns(12).HeaderText = "Emp_address"
            .Columns(13).HeaderText = "Terms_of_service"
            .Columns(14).HeaderText = "expiry_date"
            .Columns(15).HeaderText = "Position_in_sacco"
            '.Columns(0).Width = 90
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

    Private Sub btnExport_SACCOLoan_Click(sender As Object, e As EventArgs) Handles btnExport_SACCOLoan.Click
        Dgv.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True
            rowsTotal = Dgv.RowCount - 1
            colsTotal = Dgv.Columns.Count - 1

            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = Dgv.Columns(iC).HeaderText
                Next

                For I = 0 To rowsTotal 'REMOVED THE - 1 to print the lasr row for the total
                    For j = 0 To colsTotal 'REMOVED THE - 1 to print the lasr column for the telephone
                        .Cells(I + 2, j + 1).value = Dgv.Rows(I).Cells(j).Value
                    Next j
                Next I

                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 10
                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With

        Catch ex As Exception
            MsgBox("Export Excel Error " & ex.Message)
        Finally
            'RELEASE ALLOACTED RESOURCES  
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing

        End Try
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
        Dgv.Columns(7).DataPropertyName = "Monthly_NetIncome"
        Dgv.Columns(8).DataPropertyName = "My_Tel"
        Dgv.Columns(9).DataPropertyName = "email"
        Dgv.Columns(10).DataPropertyName = "Emp_name"
        Dgv.Columns(11).DataPropertyName = "Employer_tel"
        Dgv.Columns(12).DataPropertyName = "Emp_address"
        Dgv.Columns(13).DataPropertyName = "Terms_of_service"
        Dgv.Columns(14).DataPropertyName = "expiry_date"
        Dgv.Columns(15).DataPropertyName = "Position_in_sacco"

        Dgv.Columns(0).HeaderText = "Loan_Number"
        Dgv.Columns(1).HeaderText = "Member ID"
        Dgv.Columns(2).HeaderText = "Name"
        Dgv.Columns(3).HeaderText = "Employment_Postion"
        Dgv.Columns(4).HeaderText = "Payroll_num"
        Dgv.Columns(5).HeaderText = "Loan_Amount"
        Dgv.Columns(6).HeaderText = "Loan_interest"
        Dgv.Columns(7).HeaderText = "Monthly_NetIncome"
        Dgv.Columns(8).HeaderText = "My_Tel"
        Dgv.Columns(9).HeaderText = "email"
        Dgv.Columns(10).HeaderText = "Emp_name"
        Dgv.Columns(11).HeaderText = "Employer_tel"
        Dgv.Columns(12).HeaderText = "Emp_address"
        Dgv.Columns(13).HeaderText = "Terms_of_service"
        Dgv.Columns(14).HeaderText = "expiry_date"
        Dgv.Columns(15).HeaderText = "Position_in_sacco"
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
End Class