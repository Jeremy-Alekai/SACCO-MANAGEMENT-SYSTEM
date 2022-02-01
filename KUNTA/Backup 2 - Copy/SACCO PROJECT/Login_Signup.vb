Imports MySql.Data.MySqlClient
Public Class Login_Signup
    Dim MysqlConn As MySqlConnection

    Dim COMMAND As MySqlCommand

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            Dim con As MySqlConnection = New MySqlConnection("Server=localhost;Uid=root;Database=sacco_db;Port=3306")

            con.Open()

            Dim cmd As MySqlCommand = New MySqlCommand("select * from member_details where MemberID='" + txtMember_ID.Text + "' and password= '" + txtPassword.Text + "'", con)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)
            Dim Position_in_SACCO As String

            Position_in_SACCO = dt.Rows(0).Item(29)

            If (dt.Rows.Count > 0 And Position_in_SACCO = "Treasurer") Then
                Treasurer_Dashboard.Show()
                Treasurer_Dashboard.btnViewMembers.PerformClick()
                Me.Hide()
            ElseIf (dt.Rows.Count > 0 And Position_in_SACCO = "Chairperson") Then
                Chairman_Dashboard.Show()
                Chairman_Dashboard.btnView_Members.PerformClick()
                Me.Hide()
            ElseIf (dt.Rows.Count > 0 And Position_in_SACCO = "Member") Then
                Member_Dashboard.Show()

                Member_Dashboard.btnMy_savings.PerformClick()

                Me.Hide()

            Else
                MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()

            txtMember_ID.Clear()
            txtPassword.Clear()

        Catch ex As Exception
            If MessageBox.Show("Invalid MemberID or Password", "Alert", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Retry Then
                txtMember_ID.Clear()
                txtPassword.Clear()
            End If

        End Try

        ''

        'If txtMember_ID.Text = "Treasurer" And txtPassword.Text = "123" Then
        'Treasurer_Dashboard.Show()

        'ElseIf txtMember_ID.Text = "Chairperson" And txtPassword.Text = "123" Then
        'Chairman_Dashboard.Show()


        'ElseIf txtMember_ID.Text = "Secretary" And txtPassword.Text = "123" Then
        'Member_Dashboard.Show()
        
        'Else
        'MsgBox("Incorrect MemberID or Password. Please try again or consult the Admin", MsgBoxStyle.Information)
        'Me.Show()
        'txtMember_ID.Clear()
        'txtPassword.Clear()
        'txtMember_ID.Focus()
        'End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Login_Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class