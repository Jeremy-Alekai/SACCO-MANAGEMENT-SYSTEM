Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Floans
    Public ourconn As New MySqlConnection("Server=localhost;Uid=root;Database=sacco_db;Port=3306")
    Public MyDa As New MySqlDataAdapter
    Public DtaSet As New DataSet
    Public adaptor As New MySqlDataAdapter
    Public dset As New DataSet
    Public DtaSet2 As New DataSet
    Private Sub Floans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb.Text = Member_Dashboard.MemberID_Dash.Text
        Try
            With ourconn
                With MyDa
                    .SelectCommand = New MySqlCommand
                    .SelectCommand.CommandText = "SELECT * FROM Loans WHERE MEMBERID = '" + lb.Text + "'"
                    .SelectCommand.Connection = ourconn
                    Dim Ole As New MySqlCommandBuilder(MyDa)
                    DtaSet.Clear()
                    .Fill(DtaSet, "Loans")
                    Call DataConnection(Me.DgvPLoans)
                End With
            End With
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...Here...........")

        Finally
            ourconn.Close()
        End Try
        ''//////////////
        'Try
        'With ourconn
        'With MyDa
        '.SelectCommand = New MySqlCommand
        '.SelectCommand.CommandText = "SELECT * FROM Loans"
        '.SelectCommand.Connection = ourconn
        'Dim Ole As New MySqlCommandBuilder(MyDa)
        'DtaSet.Clear()
        '.Fill(DtaSet, "Loans")
        'Call DataConnection(Me.Dgv)
        'End With
        'End With
        'Catch ex As Exception
        'MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...Here...........")
        'Finally
        'ourconn.Close()
        'End Try
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

    Private Sub btnExport_Loan_Click(sender As Object, e As EventArgs) Handles btnExport_Loan.Click
        DgvPLoans.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True
            rowsTotal = DgvPLoans.RowCount - 1
            colsTotal = DgvPLoans.Columns.Count - 1

            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DgvPLoans.Columns(iC).HeaderText
                Next

                For I = 0 To rowsTotal 'REMOVED THE - 1 to print the lasr row for the total
                    For j = 0 To colsTotal 'REMOVED THE - 1 to print the lasr column for the telephone
                        .Cells(I + 2, j + 1).value = DgvPLoans.Rows(I).Cells(j).Value
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
End Class