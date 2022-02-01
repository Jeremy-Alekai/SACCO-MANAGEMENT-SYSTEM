Imports MySql.Data.MySqlClient
Public Class Login_Signup
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Me.Hide()
        If txtMember_ID.Text = "Treasurer" And txtPassword.Text = "123" Then
            Treasurer_Dashboard.Show()
            Treasurer_Dashboard.btnViewMembers.PerformClick()
        

        ElseIf txtMember_ID.Text = "Member" And txtPassword.Text = "123" Then
            Member_Dashboard.Show()
            Member_Dashboard.btnMy_savings.PerformClick()
        Else
            MsgBox("Incorrect MemberID or Password. Please try again or consult the Admin", MsgBoxStyle.Information)
            Me.Show()
            txtMember_ID.Clear()
            txtPassword.Clear()
            txtMember_ID.Focus()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    

    
    Private Sub btnConnection_Click(sender As Object, e As EventArgs) Handles btnConnection.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=localhost;Uid=root;Database=sacco_db;Port=3306"

        Try
            MysqlConn.Open()
            MessageBox.Show("DB Connected")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub
End Class