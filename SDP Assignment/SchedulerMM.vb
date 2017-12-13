Public Class frmSchedulerMM

    Private Sub btnIntake_Click(sender As Object, e As EventArgs) Handles btnIntake.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Hide()
        frmSchedulerIntakeMenu.Show()
    End Sub

    Private Sub btnClassroom_Click(sender As Object, e As EventArgs) Handles btnClassroom.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Hide()
        frmSchedulerClassroomMenu.Show()
    End Sub

    Private Sub btnTimetable_Click(sender As Object, e As EventArgs) Handles btnTimetable.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Hide()
        frmSchedulerTimetableMenu.Show()
    End Sub

    Private Sub btnResponse_Click(sender As Object, e As EventArgs) Handles btnResponse.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Hide()
        frmSchedulerResponseMenu.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmLoginPage.Show()
        End If
    End Sub

    Private Sub frmSchedulerMM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'display scheduler name in the MAIN MENU
        Me.lblName.Text = frmLoginPage.DisplayName

    End Sub

    Private Sub frmSchedulerMM_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        btnIntake.Select()
    End Sub
End Class