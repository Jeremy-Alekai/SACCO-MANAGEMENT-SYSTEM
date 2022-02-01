Public Class Chairman_Dashboard

    Private Sub Admin_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_AdminDash_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs)

        Me.Hide()
        Treasurer_Dashboard.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim y As New Form()
        Panel1.Controls.Clear()
        Chairman_Home.TopLevel = False
        Chairman_Home.WindowState = FormWindowState.Maximized
        Chairman_Home.Visible = True
        Panel1.Controls.Add(Chairman_Home)
        Chairman_Home.Show()
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

    Private Sub btnMessages_Click(sender As Object, e As EventArgs) Handles btnMessages.Click
        Dim y As New Form()
        Panel1.Controls.Clear()
        Fmeeting_minutes.TopLevel = False
        Fmeeting_minutes.WindowState = FormWindowState.Maximized
        Fmeeting_minutes.Visible = True
        Panel1.Controls.Add(Fmeeting_minutes)
        Fmeeting_minutes.Show()
    End Sub

    Private Sub btnSACCO_Policy_Click(sender As Object, e As EventArgs) Handles btnSACCO_Policy.Click

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim y As New Form()
        Panel1.Controls.Clear()
        Fprofile_Settings.TopLevel = False
        Fprofile_Settings.WindowState = FormWindowState.Maximized
        Fprofile_Settings.Visible = True
        Panel1.Controls.Add(Fprofile_Settings)
        Fprofile_Settings.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub


End Class
