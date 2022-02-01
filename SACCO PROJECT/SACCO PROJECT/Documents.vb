Imports MySql.Data.MySqlClient
Public Class Documents
    Public ourconn As New MySqlConnection("Server=localhost;Uid=root;Database=sacco_db;Port=3306")
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public Dt As New DataTable
    Dim sql As String

    Private Sub Documents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            OpenFileDialog1.Filter = "PDF | *.pdf"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                txtDoc_name.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Try
        'ProgressBar1.Value += 1
        'If ProgressBar1.Value = 100 Then
        '    Timer1.Stop()
        '   ourconn.Open()
        '  sql = "INSERT INTO pdf-reader(PDFNAME) VALUES ('" & System.IO.Path.GetFileName(txtDoc_name.Text) & "')"
        ' cmd = New MySqlCommand
        'With cmd
        '    .Connection = ourconn
        '   .CommandText = sql
        '  .ExecuteNonQuery()

        'End With
        'If txtDoc_name.Text <> Then
        '    System.IO.File.Copy(txtDoc_name.Text, Application.StartupPath && "\PDFFILE\" &System.IO.Path.GetFileName(txtDoc_name.Text))
        'End If
        'End If
        '        Catch ex As Exception

        'End Try
    End Sub
End Class