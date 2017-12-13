Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class frmSchedulerGTimetableMenu
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim inc As Integer
    Dim tables As DataTableCollection
    Private NameValid As Boolean

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerTimetableMenu.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)

        '********* VALIDATION FOR CLASSROOM, LECTURER, INTAKE, DAY and TIME ****************
        Dim dr As OleDbDataReader

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT *" & _
                                                   "FROM [Timetable]" & _
                                                   "WHERE ([Day1] ='" & cbDay.Text & "' AND [Time1] = '" & cbTime.Text & "' " & _
                                                   "AND [Classroom_Name] = '" & cbClassroomAssigned.Text & "')", connection)
        dr = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim SimilarClassroom As Boolean = False

        'if found
        While dr.Read
            SimilarClassroom = True
        End While

        Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT *" & _
                                                    "FROM [Timetable]" & _
                                                    "WHERE ([Day1] = '" & cbDay.Text & "' AND [Time1] = '" & cbTime.Text & "'" & _
                                                    "AND [Lecturer_Assigned] = '" & cbLecturerAssigned.Text & "')", connection)
        dr = cmd2.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim SimilarLecturer As Boolean = False
        
        'if found
        While dr.Read
            SimilarLecturer = True
        End While

        Dim cmd3 As OleDbCommand = New OleDbCommand("SELECT * " & _
                                                    "FROM [Timetable]" & _
                                                    "WHERE ([Day1] = '" & cbDay.Text & "' AND [Time1] = '" & cbTime.Text & "'" & _
                                                    "AND [Intake_Code] = '" & cbIntakeCode.Text & "')", connection)
        dr = cmd3.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim SimilarIntake As Boolean = False

        'if found
        While dr.Read
            SimilarIntake = True
        End While

        If SimilarClassroom = True And SimilarLecturer = False And SimilarIntake = False Then   'classroom duplication
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Classroom has been occupied at this day and time!", vbExclamation & vbOKOnly, "Error")

        ElseIf SimilarClassroom = False And SimilarLecturer = True And SimilarIntake = False Then   'lecturer duplication
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Lecturer is not available at this day and time!", vbExclamation & vbOKOnly, "Error")

        ElseIf SimilarClassroom = False And SimilarLecturer = False And SimilarIntake = True Then   'intake duplication in the same day and time
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("The intake is unavailable during this day and time!", vbExclamation & vbOKOnly, "Error")

        ElseIf SimilarClassroom = True And SimilarLecturer = True And SimilarIntake = False Then    'lecturer and classroom duplication
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Both lecturer and classroom are not available at this day and time!", vbExclamation & vbOKOnly, "Error")

        ElseIf SimilarClassroom = True And SimilarLecturer = False And SimilarIntake = True Then    'intake and classroom duplication
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Both intake and classroom are not available at this day and time!", vbExclamation & vbOKOnly, "Error")

        ElseIf SimilarClassroom = False And SimilarLecturer = True And SimilarIntake = True Then    'lecturer and intake duplication
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Both lecturer and intake are not available at this day and time!", vbExclamation & vbOKOnly, "Error")

        ElseIf SimilarClassroom = True And SimilarLecturer = True And SimilarIntake = True Then    'classroom, lecturer and intake duplication
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Classroom, lecturer and intake are not available at this day and time!", vbExclamation & vbOKOnly, "Error")

        Else
            cmd = New OleDbCommand("SELECT * FROM [Timetable]", connection)
            dr = cmd.ExecuteReader
            cmd2 = New OleDbCommand("SELECT * FROM [Timetable]", connection)
            dr = cmd2.ExecuteReader
            cmd3 = New OleDbCommand("SELECT * FROM [Timetable]", connection)
            dr = cmd3.ExecuteReader
            da = New OleDb.OleDbDataAdapter(sql, connection)
            da.Fill(ds, "Timetable")
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            GenerateTimetable()
        End If
    End Sub

    Private Sub GenerateTimetable()
        If cbIntakeCode.SelectedIndex = -1 Or txtModuleName.Text = "" Or cbClassroomAssigned.SelectedIndex = -1 Or cbLecturerAssigned.SelectedIndex = -1 Or cbDay.SelectedIndex = -1 Or cbTime.SelectedIndex = -1 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Please make sure that all of the fields are filled in.", vbExclamation & vbOKOnly, "Empty Field(s)")

        Else
            MsgBox("The Timetable has been successfully generated!", vbOKOnly, "Successful")
            If inc <> 0 Then
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                Dim dsNewRow As DataRow
                dsNewRow = ds.Tables("Timetable").NewRow
                dsNewRow.Item("Intake_Code") = cbIntakeCode.Text
                dsNewRow.Item("Module_Name") = txtModuleName.Text
                dsNewRow.Item("Classroom_Name") = cbClassroomAssigned.Text
                dsNewRow.Item("Lecturer_Assigned") = cbLecturerAssigned.Text
                dsNewRow.Item("Day1") = cbDay.Text
                If cbDay.Text = "Monday" Then
                    dsNewRow.Item("DayID") = "1"
                ElseIf cbDay.Text = "Tuesday" Then
                    dsNewRow.Item("DayID") = "2"
                ElseIf cbDay.Text = "Wednesday" Then
                    dsNewRow.Item("DayID") = "3"
                ElseIf cbDay.Text = "Thursday" Then
                    dsNewRow.Item("DayID") = "4"
                ElseIf cbDay.Text = "Friday" Then
                    dsNewRow.Item("DayID") = "5"
                End If
                dsNewRow.Item("Time1") = cbTime.Text
                dsNewRow.Item("ClassroomStatus") = "Unavailable"
                ds.Tables("Timetable").Rows.Add(dsNewRow)

                da.Update(ds, "Timetable")

                cbIntakeCode.SelectedIndex = -1
                txtModuleName.Clear()
                cbClassroomAssigned.SelectedIndex = -1
                cbLecturerAssigned.SelectedIndex = -1
                cbDay.SelectedIndex = -1
                cbTime.SelectedIndex = -1
            End If
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        cbIntakeCode.SelectedIndex = -1
        txtModuleName.Clear()
        cbClassroomAssigned.SelectedIndex = -1
        cbLecturerAssigned.SelectedIndex = -1
        cbDay.SelectedIndex = -1
        cbTime.SelectedIndex = -1
        cbIntakeCode.Select()
    End Sub

    Private Sub frmSchedulerGTimetableMenu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        cbIntakeCode.SelectedIndex = -1
        txtModuleName.Clear()
        cbClassroomAssigned.SelectedIndex = -1
        cbLecturerAssigned.SelectedIndex = -1
        cbDay.SelectedIndex = -1
        cbTime.SelectedIndex = -1
        cbIntakeCode.Select()
    End Sub

    Private Sub frmSchedulerGTimetableMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        sql = "SELECT * FROM Timetable ORDER BY [Intake_Code], [DayID], [Time1]"
        da = New OleDb.OleDbDataAdapter(sql, connection)
        da.Fill(ds, "Timetable")
        inc = -1

        tables = ds.Tables()

        IntakeCodeDropDown()
        ClassroomDropDown()
        LecturerDropDown()
    End Sub

    Private Sub IntakeCodeDropDown()

        da = New OleDb.OleDbDataAdapter("SELECT IntakeCode FROM IntakeDetails ORDER BY [IntakeCourse],[IntakeCode]", connection)
        da.Fill(ds, "IntakeDetails")
        Dim view As New DataView(tables(0))
        'With ... End With is used to reduce repetition of Name. eg: dont have to type cbIntakeCode x4
        With cbIntakeCode    'without the With ... End With,
            .DataSource = ds.Tables("IntakeDetails")
            .DisplayMember = "IntakeCode"
            .ValueMember = "IntakeCode"
            .SelectedIndex = -1
            .DropDownHeight = 106
        End With
    End Sub

    Private Sub ClassroomDropDown()

        da = New OleDb.OleDbDataAdapter("SELECT ClassroomName FROM Classroom ORDER BY [ClassroomName]", connection)
        da.Fill(ds, "Classroom")
        Dim view As New DataView(tables(0))
        'With ... End With is used to reduce repetition of Name. eg: dont have to type cbClassroomAssigned x4
        With cbClassroomAssigned    'without the With ... End With,
            .DataSource = ds.Tables("Classroom")
            .DisplayMember = "ClassroomName"
            .ValueMember = "ClassroomName"
            .SelectedIndex = -1
            .DropDownHeight = 106
        End With
    End Sub

    Private Sub LecturerDropDown()

        da = New OleDb.OleDbDataAdapter("SELECT LecturerName FROM Lecturer ORDER BY [LecturerName]", connection)
        da.Fill(ds, "Lecturer")
        Dim view As New DataView(tables(0))
        'With ... End With is used to reduce repetition of Name. eg: dont have to type cbLecturerAssigned x4
        With cbLecturerAssigned    'without the With ... End With,
            .DataSource = ds.Tables("Lecturer")
            .DisplayMember = "LecturerName"
            .ValueMember = "LecturerName"
            .SelectedIndex = -1
            .DropDownHeight = 106
        End With
    End Sub

End Class