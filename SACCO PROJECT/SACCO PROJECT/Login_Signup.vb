Public Class Login_Signup

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        If txtMember_ID.Text = "Treasurer" And txtPassword.Text = "123" Then
            Treasurer_Dashboard.Show()
            Treasurer_Dashboard.btnHome.PerformClick()
        ElseIf txtMember_ID.Text = "Chairperson" And txtPassword.Text = "123" Then
            Chairman_Dashboard.Show()
            Chairman_Dashboard.btnHome.PerformClick()

        ElseIf txtMember_ID.Text = "Secretary" And txtPassword.Text = "123" Then
            Secretary_Dashboard.Show()
            Secretary_Dashboard.btnMy_savings.PerformClick()
        Else
            MsgBox("Incorrect MemberID or Password. Please try again or consult the Admin", MsgBoxStyle.Information)
            Me.Show()
            txtMember_ID.Clear()
            txtPassword.Clear()
            txtMember_ID.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class