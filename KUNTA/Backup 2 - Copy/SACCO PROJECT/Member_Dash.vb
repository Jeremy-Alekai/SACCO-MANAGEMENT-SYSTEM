Public Class Member_Dash

    Private Sub btn_AdminDash_Click(sender As Object, e As EventArgs) Handles btn_AdminDash.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Controls.Clear()
        Psavings.TopLevel = False
        Panel1.Controls.Add(Psavings)
        Psavings.Show()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel1.Controls.Clear()
        My_Loans.TopLevel = False
        Panel1.Controls.Add(My_Loans)
        My_Loans.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Controls.Clear()
        FprofileSettings.TopLevel = False
        Panel1.Controls.Add(FprofileSettings)
        FprofileSettings.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Controls.Clear()
        Fmessages.TopLevel = False
        Panel1.Controls.Add(Fmessages)
        Fmessages.Show()
    End Sub
End Class