Public Class Chairman_Dashboard

    Private Sub Admin_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_AdminDash_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs)

        Me.Hide()
        Treasurer_Dashboard.Show()
    End Sub

    Private Sub btnView_Members_Click(sender As Object, e As EventArgs) Handles btnView_Members.Click
        Dim y As New Form()
        Panel1.Controls.Clear()
        Fmember_list.TopLevel = False
        Fmember_list.WindowState = FormWindowState.Maximized
        Fmember_list.Visible = True
        Panel1.Controls.Add(Fmember_list)
        Fmember_list.Show()

    End Sub



    Private Sub btnPersonal_savings_Click(sender As Object, e As EventArgs) Handles btnPersonal_savings.Click
        Dim y As New Form()
        Panel1.Controls.Clear()
        Fsavings.TopLevel = False
        Fsavings.WindowState = FormWindowState.Maximized
        Fsavings.Visible = True
        Panel1.Controls.Add(Fsavings)
        Fsavings.Show()
    End Sub



    Private Sub btnSACCO_SAVINGS_Click(sender As Object, e As EventArgs) Handles btnSACCO_SAVINGS.Click
        Dim y As New Form()
        Panel1.Controls.Clear()
        Fsavings_view.TopLevel = False
        Fsavings_view.WindowState = FormWindowState.Maximized
        Fsavings_view.Visible = True
        Panel1.Controls.Add(Fsavings_view)
        Fsavings_view.Show()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y As New Form()
        Panel1.Controls.Clear()
        Floans_View.TopLevel = False
        Floans_View.WindowState = FormWindowState.Maximized
        Floans_View.Visible = True
        Panel1.Controls.Add(Floans_View)
        Floans_View.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Login_Signup.Show()
    End Sub


End Class
