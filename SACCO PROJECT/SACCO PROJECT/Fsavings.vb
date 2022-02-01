Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Fsavings
    Public ourconn As New MySqlConnection("Server=localhost;Uid=root;Database=sacco_db;Port=3306")
    Public MyDa As New MySqlDataAdapter
    Public DtaSet As New DataSet
    Public adaptor As New MySqlDataAdapter
    Public dset As New DataSet
    Public DtaSet2 As New DataSet
    Private Sub Fsavings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    

    Private Sub btnRefresh_Savingsview_Click(sender As Object, e As EventArgs) Handles btnRefresh_Savings.Click
        With MyDa

            ourconn.Open()
            .SelectCommand = New MySqlCommand
            .SelectCommand.CommandText = "SELECT MemberID,Name,Tel,Amount,Deposit_Date FROM personal_savings"
            .SelectCommand.Connection = ourconn
            DtaSet.Clear()
            MyDa.Fill(DtaSet, "personal_savings")

            ourconn.Close()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExport_Savings.Click
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
End Class