Public Class Secretary_Dash

    Private Sub btnViewMembers_Click(sender As Object, e As EventArgs) Handles btnViewMembers.Click
        Panel1.Controls.Clear()
        Foffical_Documents.TopLevel = False
        Panel1.Controls.Add(Foffical_Documents)
        Foffical_Documents.Show()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Controls.Clear()
        FprofileSettings.TopLevel = False
        Panel1.Controls.Add(FprofileSettings)
        FprofileSettings.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Controls.Clear()
        Fmeetings.TopLevel = False
        Panel1.Controls.Add(Fmeetings)
        Fmeetings.Show()
    End Sub

    Private Sub btn_AdminDash_Click(sender As Object, e As EventArgs) Handles btn_AdminDash.Click
        Dim x As New Form()
        Panel1.Controls.Clear()
        Foffical_Documents.TopLevel = False
        Foffical_Documents.WindowState = FormWindowState.Maximized
        Foffical_Documents.Visible = True
        Panel1.Controls.Add(Foffical_Documents)
        Foffical_Documents.Show()
    End Sub
End Class