Public Class Admin_View

    Private Sub Admin_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_AdminDash_Click(sender As Object, e As EventArgs) Handles btn_AdminDash.Click
        Panel1.Controls.Clear()
        Admin_Dash1.TopLevel = False
        Panel1.Controls.Add(Admin_Dash1)
        Admin_Dash1.Show()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click

        Me.Close()

    End Sub

    Private Sub btnViewMembers_Click(sender As Object, e As EventArgs) Handles btnViewMembers.Click
        Panel1.Controls.Clear()
        Fmembers1.TopLevel = False
        Panel1.Controls.Add(Fmembers1)
        Fmembers1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Controls.Clear()
        FprofileSettings.TopLevel = False
        Panel1.Controls.Add(FprofileSettings)
        FprofileSettings.Show()
    End Sub
End Class
