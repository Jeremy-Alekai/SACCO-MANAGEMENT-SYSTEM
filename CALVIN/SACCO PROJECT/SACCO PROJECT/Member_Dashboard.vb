Public Class Member_Dashboard

   
   
    Private Sub btnMy_savings_Click(sender As Object, e As EventArgs) Handles btnMy_savings.Click
        Dim y As New Form()
        Panel1.Controls.Clear()
        Fsavings.TopLevel = False
        Fsavings.WindowState = FormWindowState.Maximized
        Fsavings.Visible = True
        Panel1.Controls.Add(Fsavings)
        Fsavings.Show()
    End Sub

    Private Sub btnMy_Loans_Click(sender As Object, e As EventArgs) Handles btnMy_Loans.Click
        Dim y As New Form()
        Panel1.Controls.Clear()
        Floans.TopLevel = False
        Floans.WindowState = FormWindowState.Maximized
        Floans.Visible = True
        Panel1.Controls.Add(Floans)
        Floans.Show()
    End Sub

    Private Sub btnLog_Out_Click(sender As Object, e As EventArgs) Handles btnLog_Out.Click
        Me.Hide()
        Login_Signup.Show()
    End Sub
End Class