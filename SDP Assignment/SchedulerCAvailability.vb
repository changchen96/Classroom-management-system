Imports System.Data.OleDb

Public Class frmSchedulerClassroomAvailability
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim MaxRows As String
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource

    Private Sub frmSchedulerClassroomAvailability_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblName.Text = frmLoginPage.DisplayName
        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        sql = "SELECT * FROM Classroom ORDER BY [ClassroomName]"
        da = New OleDb.OleDbDataAdapter(sql, connection)
        da.Fill(ds, "Classroom")
        MaxRows = ds.Tables("Classroom").Rows.Count

        tables = ds.Tables
        ClassroomNameDropDown()
    End Sub

    Private Sub ClassroomNameDropDown()
        Dim view As New DataView(tables(0))
        'With ... End With is used to reduce repetition of Name. eg: dont have to type cbIntakeCode x4
        With cbClassroomName   'without the With ... End With,
            .DataSource = ds.Tables("Classroom")
            .DisplayMember = "ClassroomName"
            .ValueMember = "ClassroomName"
            .SelectedIndex = -1
            .DropDownHeight = 106
        End With
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

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)

        tables.Clear()  'avoid duplication in the DATA GRID VIEW when the 'Submit' button is clicked x2

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Timetable] WHERE ([Classroom_Name] = '" & cbClassroomName.Text & "' AND [Day1] = '" & cbDay.Text & "')", connection)
        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if classroom is unavailable, and false if classroom is available
        Dim ClassroomUnavailable As Boolean = False

        'if found
        While dr.Read
            ClassroomUnavailable = True
        End While

        If ClassroomUnavailable = True Then
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            'this functions to display the table on the DATA GRID VIEW
            sql = "SELECT Classroom_Name, Day1, Time1, ClassroomStatus FROM [Timetable] WHERE ([Classroom_Name] = '" & cbClassroomName.Text & "' AND [Day1] = '" & cbDay.Text & "')"
            da = New OleDb.OleDbDataAdapter(sql, connection)
            da.Fill(ds, "Timetable")
            'display the table on the DATA GRID VIEW when the 'Search' button is clicked
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DGVAvailability.DataSource = view
            'modifications
            DGVAvailability.Columns(0).HeaderText = "Classroom Name"
            DGVAvailability.Columns(1).HeaderText = "Day"
            DGVAvailability.Columns(2).HeaderText = "Time"
            DGVAvailability.Columns(3).HeaderText = "Classroom Status"
            DGVAvailability.Columns(0).Width = 80
            DGVAvailability.Columns(1).Width = 80
            DGVAvailability.Columns(2).Width = 120
            DGVAvailability.Columns(3).Width = 120

        ElseIf cbClassroomName.SelectedIndex = -1 Or cbDay.SelectedIndex = -1 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Please make sure the classroom name and day are selected!", vbExclamation & vbOKOnly, "Invalid Input")
            cbClassroomName.SelectedIndex = -1
            cbDay.SelectedIndex = -1
            cbClassroomName.Select()
            DGVAvailability.DataSource = Nothing

        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Classroom is available at this day!", vbExclamation & vbOKOnly, "Classroom Available")
            cbClassroomName.Select()
            DGVAvailability.DataSource = Nothing
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmLecturerMM.Show()
    End Sub

    Private Sub frmSchedulerCAvailability_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        cbClassroomName.SelectedIndex = -1
        cbDay.SelectedIndex = -1
        cbClassroomName.Select()
    End Sub

    Private Sub btnIntake_Click(sender As Object, e As EventArgs) Handles btnIntake.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerIntakeMenu.Show()
    End Sub

    Private Sub btnTimetable_Click(sender As Object, e As EventArgs) Handles btnTimetable.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerTimetableMenu.Show()
    End Sub

    Private Sub btnResponse_Click(sender As Object, e As EventArgs) Handles btnResponse.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerResponseMenu.Show()
    End Sub

End Class