Public Class Treasurer_Dash

    Private Sub button7_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub button7_Click_1(sender As Object, e As EventArgs) Handles button7.Click
        Me.Close()
    End Sub

    Private Sub btnViewMembers_Click(sender As Object, e As EventArgs) Handles btnViewMembers.Click
        panel1.Controls.Clear()
        Fmembers1.TopLevel = False
        Panel1.Controls.Add(Fmembers1)
        Fmembers1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        panel1.Controls.Clear()
        FprofileSettings.TopLevel = False
        panel1.Controls.Add(FprofileSettings)
        FprofileSettings.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        panel1.Controls.Clear()
        Fsavings_List.TopLevel = False
        panel1.Controls.Add(Fsavings_List)
        Fsavings_List.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel1.Controls.Clear()
        Floans.TopLevel = False
        Panel1.Controls.Add(Floans)
        Floans.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel1.Controls.Clear()
        FInvestments.TopLevel = False
        Panel1.Controls.Add(FInvestments)
        FInvestments.Show()
    End Sub
End Class