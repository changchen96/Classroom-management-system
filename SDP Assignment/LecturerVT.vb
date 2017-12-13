Imports System.Data.OleDb
Public Class frmLecturerVT
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource

    Private Sub frmLecturerVT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblName.Text = frmLoginPage.DisplayName
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        tables = ds.Tables

        LecturerTimetable()
        IntakeTimetable()
    End Sub

    Private Sub LecturerTimetable()

        da = New OleDb.OleDbDataAdapter("SELECT LecturerName FROM Lecturer ORDER BY [LecturerName]", connection)
        da.Fill(ds, "Lecturer")
        Dim view As New DataView(tables(0))
        'With ... End With is used to reduce repetition of Name. eg: dont have to type cbLecturerName x4
        With cbLecturerName   'without the With ... End With,
            .DataSource = ds.Tables("Lecturer")
            .DisplayMember = "LecturerName"
            .ValueMember = "LecturerName"
            .SelectedIndex = -1
            .DropDownHeight = 106
        End With
    End Sub

    Private Sub IntakeTimetable()

        da = New OleDb.OleDbDataAdapter("SELECT IntakeCode FROM IntakeDetails ORDER BY [IntakeCourse],[IntakeCode]", connection)
        da.Fill(ds, "IntakeDetails")
        Dim view As New DataView(tables(0))
        'With ... End With is used to reduce repetition of Name. eg: dont have to type cbLecturerName x4
        With cbIntakeCode   'without the With ... End With,
            .DataSource = ds.Tables("IntakeDetails")
            .DisplayMember = "IntakeCode"
            .ValueMember = "IntakeCode"
            .SelectedIndex = -1
            .DropDownHeight = 106
        End With
    End Sub

    Private Sub btnSearch1_Click_1(sender As Object, e As EventArgs) Handles btnSearch1.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)

        cbLecturerName.SelectedIndex = -1

        tables.Clear()  'avoid duplication in the DATA GRID VIEW when the 'Search' button is clicked x2

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Timetable WHERE ([Intake_Code] = '" & cbIntakeCode.Text & "')", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim IntakeCodeFound As Boolean = False

        'if found
        While dr.Read
            IntakeCodeFound = True
        End While

        If IntakeCodeFound = True Then
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            'this functions to display the table on the DATA GRID VIEW
            sql = "SELECT Day1, Time1, Classroom_Name, Module_Name, Lecturer_Assigned FROM Timetable WHERE ([Intake_Code] = '" & cbIntakeCode.Text & "') ORDER BY [DayID],[Time1]"
            da = New OleDbDataAdapter(sql, connection)
            da.Fill(ds, "Timetable")
            'display the table on the DATA GRID VIEW when the 'Search' button is clicked
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DGVLecturerVT.DataSource = view      'DGV stands for Data Grid View
            'modification
            DGVLecturerVT.Columns(0).HeaderText = "Day"
            DGVLecturerVT.Columns(1).HeaderText = "Time"
            DGVLecturerVT.Columns(2).HeaderText = "Classroom Name"
            DGVLecturerVT.Columns(3).HeaderText = "Module Name"
            DGVLecturerVT.Columns(4).HeaderText = "Lecturer Assigned"
            DGVLecturerVT.Columns(0).Width = 70
            DGVLecturerVT.Columns(1).Width = 70
            DGVLecturerVT.Columns(2).Width = 70
            DGVLecturerVT.Columns(3).Width = 220
            DGVLecturerVT.Columns(4).Width = 100

        ElseIf cbIntakeCode.SelectedIndex = -1 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("No intake code is selected!", vbExclamation & vbOKOnly, "Invalid Input")
            cbIntakeCode.SelectedIndex = -1
            cbLecturerName.SelectedIndex = -1
            cbLecturerName.Select()
            DGVLecturerVT.DataSource = Nothing

        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Timetable not found for this intake code!", vbExclamation & vbOKOnly, "Invalid Input")
            cbIntakeCode.SelectedIndex = -1
            cbLecturerName.SelectedIndex = -1
            cbLecturerName.Select()
            DGVLecturerVT.DataSource = Nothing
        End If

    End Sub

    Private Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)

        cbIntakeCode.SelectedIndex = -1

        tables.Clear()  'avoid duplication in the DATA GRID VIEW when the 'Search' button is clicked x2

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Timetable WHERE ([Lecturer_Assigned] = '" & cbLecturerName.Text & "')", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim LecturerNameFound As Boolean = False

        'if found
        While dr.Read
            LecturerNameFound = True
        End While

        If LecturerNameFound = True Then
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            'this functions to display the table on the DATA GRID VIEW
            sql = "SELECT Day1, Time1, Classroom_Name, Module_Name, Intake_Code, Lecturer_Assigned FROM Timetable WHERE ([Lecturer_Assigned] = '" & cbLecturerName.Text & "') ORDER BY [DayID],[Time1]"
            da = New OleDbDataAdapter(sql, connection)
            da.Fill(ds, "Timetable")
            'display the table on the DATA GRID VIEW when the 'Search' button is clicked
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DGVLecturerVT.DataSource = view      'DGV stands for Data Grid View
            'modification
            DGVLecturerVT.Columns(0).HeaderText = "Day"
            DGVLecturerVT.Columns(1).HeaderText = "Time"
            DGVLecturerVT.Columns(2).HeaderText = "Classroom Name"
            DGVLecturerVT.Columns(3).HeaderText = "Module Name"
            DGVLecturerVT.Columns(4).HeaderText = "Intake Code"
            DGVLecturerVT.Columns(5).HeaderText = "Lecturer Name"
            DGVLecturerVT.Columns(0).Width = 70
            DGVLecturerVT.Columns(1).Width = 70
            DGVLecturerVT.Columns(2).Width = 70
            DGVLecturerVT.Columns(3).Width = 220
            DGVLecturerVT.Columns(4).Width = 100
            DGVLecturerVT.Columns(5).Width = 150

        ElseIf cbLecturerName.SelectedIndex = -1 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("No lecturer is selected!", vbExclamation & vbOKOnly, "Invalid Input")
            cbIntakeCode.SelectedIndex = -1
            cbLecturerName.SelectedIndex = -1
            cbLecturerName.Select()
            DGVLecturerVT.DataSource = Nothing

        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Timetable not found for this lecturer!", vbExclamation & vbOKOnly, "Invalid Input")
            cbIntakeCode.SelectedIndex = -1
            cbLecturerName.SelectedIndex = -1
            cbLecturerName.Select()
            DGVLecturerVT.DataSource = Nothing
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmLecturerMM.Show() 'when users click on logout button, they will be redirected back to the MAIN MENU first before actually logging out
            frmLecturerMM.Close()    '(continue) this prevents error when displaying "DisplayName" label (lblName.Text)
            frmLoginPage.Show()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmLecturerMM.Show()
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmLecturerRequest.Show()
    End Sub

    Private Sub btnCAvailability_Click(sender As Object, e As EventArgs) Handles btnCAvailability.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmLecturerCAvailability.Show()
    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmLecturerFeedback.Show()
    End Sub

    Private Sub frmLecturerVT_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        cbIntakeCode.SelectedIndex = -1
        cbLecturerName.SelectedIndex = -1
        cbIntakeCode.Select()
    End Sub
    
End Class