Public Class frmLecturerMM

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmLoginPage.Show()
        End If
    End Sub

    Private Sub btnVT_Click(sender As Object, e As EventArgs) Handles btnVT.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Hide()
        frmLecturerVT.Show()
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Hide()
        frmLecturerRequest.Show()
    End Sub

    Private Sub btnCAvailability_Click(sender As Object, e As EventArgs) Handles btnCAvailability.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Hide()
        frmLecturerCAvailability.Show()
    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Hide()
        frmLecturerFeedback.Show()
    End Sub

    Private Sub frmLecturerMM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display lecturer name in the MAIN MENU
        lblName.Text = frmLoginPage.DisplayName


    End Sub

    Private Sub frmLecturerMM_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        btnVT.Select()
    End Sub
End Class