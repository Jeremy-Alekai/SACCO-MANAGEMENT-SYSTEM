Public Class Treasurer_Dashboard

    Private Sub button7_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub button7_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim y As New Form()
        Panel1.Controls.Clear()
        Treasurer_Home.TopLevel = False
        Treasurer_Home.WindowState = FormWindowState.Maximized
        Treasurer_Home.Visible = True
        Panel1.Controls.Add(Treasurer_Home)
        Treasurer_Home.Show()
    End Sub

    Private Sub btnViewMembers_Click(sender As Object, e As EventArgs) Handles btnViewMembers.Click
        Dim y As New Form()
        panel1.Controls.Clear()
        Fmember_list.TopLevel = False
        Fmember_list.WindowState = FormWindowState.Maximized
        Fmember_list.Visible = True
        panel1.Controls.Add(Fmember_list)
        Fmember_list.Show()
    End Sub

    Private Sub btnMy_savings_Click(sender As Object, e As EventArgs) Handles btnMy_savings.Click
        Dim y As New Form()
        Panel1.Controls.Clear()
        Fsavings.TopLevel = False
        Fsavings.WindowState = FormWindowState.Maximized
        Fsavings.Visible = True
        Panel1.Controls.Add(Fsavings)
        Fsavings.Show()
    End Sub

    Private Sub btnSACCO_Click(sender As Object, e As EventArgs) Handles btnSACCO_Savings.Click
        Dim y As New Form()
        Panel1.Controls.Clear()
        Fsavings_list.TopLevel = False
        Fsavings_list.WindowState = FormWindowState.Maximized
        Fsavings_list.Visible = True
        Panel1.Controls.Add(Fsavings_list)
        Fsavings_list.Show()
    End Sub

    

    Private Sub btnLoans_Click(sender As Object, e As EventArgs) Handles btnMy_Loans.Click
        Dim y As New Form()
        Panel1.Controls.Clear()
        Floans.TopLevel = False
        Floans.WindowState = FormWindowState.Maximized
        Floans.Visible = True
        Panel1.Controls.Add(Floans)
        Floans.Show()
    End Sub

    Private Sub btnSACCO_LOANS_Click(sender As Object, e As EventArgs) Handles btnSACCO_LOANS.Click
        Dim y As New Form()
        Panel1.Controls.Clear()
        Floans_list.TopLevel = False

        Floans_list.Visible = True
        Panel1.Controls.Add(Floans_list)
        Floans_list.Show()
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

    Private Sub btnProfile_settings_Click(sender As Object, e As EventArgs) Handles btnProfile_settings.Click
        Dim y As New Form()
        Panel1.Controls.Clear()
        Fprofile_Settings.TopLevel = False
        Fprofile_Settings.WindowState = FormWindowState.Maximized
        Fprofile_Settings.Visible = True
        Panel1.Controls.Add(Fprofile_Settings)
        Fprofile_Settings.Show()
    End Sub

    Private Sub btnLog_Out_Click(sender As Object, e As EventArgs) Handles btnLog_Out.Click
        Me.Close()
    End Sub
End Class