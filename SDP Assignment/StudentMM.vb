Public Class frmStudentMM

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmLoginPage.Show()
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnVT.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Hide()
        frmStudentVT.Show()
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Hide()
        frmStudentRequest.Show()
    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Hide()
        frmStudentFeedback.Show()
    End Sub

    Private Sub frmStudentMM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display student name in this specific MENU
        Me.lblName.Text = frmLoginPage.DisplayName

    End Sub

    Private Sub frmStudentMM_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        btnVT.Select()
    End Sub
End Class