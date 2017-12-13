Public Class frmSchedulerResponseMenu
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim inc As Integer
    Dim MaxRows As Integer
    Dim tables As DataTableCollection

    Private Sub btnResponseFC_Click(sender As Object, e As EventArgs) Handles btnResponseFC.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerResponseFCMenu.Show()
    End Sub

    Private Sub btnResponseRC_Click(sender As Object, e As EventArgs) Handles btnResponseRC.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerResponseRCMenu.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmSchedulerMM.Show() 'when users click on logout button, they will be redirected back to the MAIN MENU first before actually logging out
            frmSchedulerMM.Close()    '(continue) this prevents error when displaying "DisplayName" label (lblName.Text)
            frmLoginPage.Show()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerMM.Show()
    End Sub

    Private Sub btnIntake_Click(sender As Object, e As EventArgs) Handles btnIntake.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerIntakeMenu.Show()
    End Sub

    Private Sub btnClassroom_Click(sender As Object, e As EventArgs) Handles btnClassroom.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerClassroomMenu.Show()
    End Sub

    Private Sub btnTimetable_Click(sender As Object, e As EventArgs) Handles btnTimetable.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerTimetableMenu.Show()
    End Sub

    Private Sub frmSchedulerResponseMenu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        btnResponseFC.Select()
    End Sub

    Private Sub frmSchedulerResponseMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblName.Text = frmLoginPage.DisplayName

        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        sql = "SELECT * FROM Feedback"
        da = New OleDb.OleDbDataAdapter(sql, connection)
        da.Fill(ds, "Feedback")
        MaxRows = ds.Tables("Feedback").Rows.Count

        sql = "SELECT * FROM FacilityRequest"
        da = New OleDb.OleDbDataAdapter(sql, connection)
        da.Fill(ds, "FacilityRequest")
        MaxRows = ds.Tables("FacilityRequest").Rows.Count

        tables = ds.Tables

        If ds.Tables("Feedback").Rows.Count = 0 And ds.Tables("FacilityRequest").Rows.Count = 0 Then
            btnResponseFC.Enabled = False
            btnResponseRC.Enabled = False
        ElseIf ds.Tables("Feedback").Rows.Count = 0 Then
            btnResponseFC.Enabled = False
        ElseIf ds.Tables("FacilityRequest").Rows.Count = 0 Then
            btnResponseRC.Enabled = False
        End If

    End Sub
End Class