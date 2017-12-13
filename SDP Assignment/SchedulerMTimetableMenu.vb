Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class frmSchedulerMTimetableMenu
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim inc As Integer
    Dim tables As DataTableCollection
    Dim TimetableID As String = Nothing
    Private NameValid As Boolean

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerTimetableMenu.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        '********* VALIDATION FOR CLASSROOM, LECTURER, INTAKE, DAY and TIME ****************
        Dim dr As OleDbDataReader

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Timetable WHERE TimetableID <> " & CInt(TimetableID) & " AND Day1 = '" & cbDay.Text & "' AND Time1 = '" & cbTime.Text & "' AND Classroom_Name = '" & cbClassroomAssigned.Text & "'", connection)
        dr = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim SimilarClassroom As Boolean = False

        'if found
        While dr.Read
                SimilarClassroom = True
        End While

        Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT * FROM Timetable WHERE TimetableID <> " & CInt(TimetableID) & " AND Day1 = '" & cbDay.Text & "' AND Time1 = '" & cbTime.Text & "' AND Lecturer_Assigned = '" & cbLecturerAssigned.Text & "'", connection)
        dr = cmd2.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim SimilarLecturer As Boolean = False

        'if found
        While dr.Read
            SimilarLecturer = True
        End While

        Dim cmd3 As OleDbCommand = New OleDbCommand("SELECT * FROM Timetable WHERE TimetableID <> " & CInt(TimetableID) & " AND Day1 = '" & cbDay.Text & "' AND Time1 = '" & cbTime.Text & "' AND Intake_Code = '" & cbIntakeCode.Text & "'", connection)
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
            ModifyTimetable()
        End If

    End Sub

    Private Sub ModifyTimetable()
        If cbIntakeCode.SelectedIndex = -1 Or cbTimetableID.SelectedIndex = -1 Or txtModuleName.Text = "" Or cbClassroomAssigned.SelectedIndex = -1 Or cbLecturerAssigned.SelectedIndex = -1 Or cbDay.SelectedIndex = -1 Or cbTime.SelectedIndex = -1 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Please make sure that all of the fields are filled in.", vbExclamation & vbOKOnly, "Empty Field(s)")

        Else
            MsgBox("The Timetable has been successfully modified!", vbOKOnly, "Successful")
            Dim SqlUpdate As String
            SqlUpdate = "UPDATE Timetable SET [DayID] = '" & txtDayID.Text & "', [Day1] = '" & cbDay.Text & "', [Time1] = '" & cbTime.Text & "', [Module_Name] = '" & txtModuleName.Text & "', [Classroom_Name] = '" & cbClassroomAssigned.Text & "', [Lecturer_Assigned] = '" & cbLecturerAssigned.Text & "' WHERE [Intake_Code] = '" & cbIntakeCode.Text & "' AND [TimetableID] = " & CInt(TimetableID) & ""
            Dim cmd As OleDbCommand = New OleDbCommand(SqlUpdate, connection)
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Catch ex As Exception
            End Try
            Me.Close()
            frmSchedulerTimetableMenu.Show()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If cbIntakeCode.SelectedIndex = -1 Or cbTimetableID.SelectedIndex = -1 Or txtModuleName.Text = "" Or cbClassroomAssigned.SelectedIndex = -1 Or cbLecturerAssigned.SelectedIndex = -1 Or cbDay.SelectedIndex = -1 Or cbTime.SelectedIndex = -1 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Empty field(s) cannot be deleted!", vbExclamation & vbOKOnly, "Empty Field(s)")
        Else
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                MsgBox("The timetable details have been successfully removed!", vbOKOnly, "Successful Deletion")
                Dim SqlDelete As String
                SqlDelete = "DELETE * FROM Timetable WHERE Intake_Code = '" & cbIntakeCode.Text & "' AND TimetableID = " & CInt(TimetableID) & ""
                Dim cmd As OleDbCommand = New OleDbCommand(SqlDelete, connection)
                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Catch ex As Exception
                End Try
                cbIntakeCode.SelectedIndex = -1
                cbTimetableID.SelectedIndex = -1
                cbDay.SelectedIndex = -1
                cbTime.SelectedIndex = -1
                txtModuleName.Clear()
                cbClassroomAssigned.SelectedIndex = -1
                cbLecturerAssigned.SelectedIndex = -1

                If ds.Tables("Timetable").Rows.Count = 0 Then   'if there is no more records in the database
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    MsgBox("There are no more records to be modified or deleted!", vbExclamation & vbOKOnly, "Empty Record")
                    Me.Close()
                    frmSchedulerTimetableMenu.Show()
                End If
            End If
        End If
    End Sub

    Private Sub frmSchedulerMTimetableMenu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        cbIntakeCode.SelectedIndex = -1
        cbTimetableID.SelectedIndex = -1
        txtModuleName.Clear()
        cbClassroomAssigned.SelectedIndex = -1
        cbLecturerAssigned.SelectedIndex = -1
        txtDayID.Clear()
        cbDay.SelectedIndex = -1
        cbTime.SelectedIndex = -1
        cbIntakeCode.Select()
    End Sub

    Private Sub frmSchedulerMTimetableMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        tables = ds.Tables
        IntakeCodeDropDown()
        LecturerDropDown()
        ClassroomDropDown()

        sql = "SELECT * FROM Timetable ORDER BY [Intake_Code],[TimetableID],[DayID],[Time1]"
        da = New OleDb.OleDbDataAdapter(sql, connection)
        da.Fill(ds, "Timetable")

        cbTimetableID.Enabled = False

    End Sub

    Private Sub IntakeCodeDropDown()
        da = New OleDb.OleDbDataAdapter("SELECT IntakeCode FROM IntakeDetails ORDER BY [IntakeCourse], [IntakeCode]", connection)
        da.Fill(ds, "IntakeDetails")
        Dim view As New DataView(tables(0))
        'With ... End With is used to reduce repetition of Name. eg: dont have to type cbIntakeCode x4
        With cbIntakeCode
            .DataSource = ds.Tables("IntakeDetails")
            .DisplayMember = "IntakeCode"
            .ValueMember = "IntakeCode"
            .DropDownHeight = 106
        End With
    End Sub

    Private Sub ClassroomDropDown()

        da = New OleDb.OleDbDataAdapter("SELECT ClassroomName FROM Classroom ORDER BY [ClassroomName]", connection)
        da.Fill(ds, "Classroom")
        Dim view As New DataView(tables(0))
        'With ... End With is used to reduce repetition of Name. eg: dont have to type cbClassroomAssigned x4
        With cbClassroomAssigned
            .DataSource = ds.Tables("Classroom")
            .DisplayMember = "ClassroomName"
            .ValueMember = "ClassroomName"
            .DropDownHeight = 106
        End With
    End Sub

    Private Sub LecturerDropDown()

        da = New OleDb.OleDbDataAdapter("SELECT LecturerName FROM Lecturer ORDER BY [LecturerName]", connection)
        da.Fill(ds, "Lecturer")
        Dim view As New DataView(tables(0))
        'With ... End With is used to reduce repetition of Name. eg: dont have to type cbLecturerAssigned x4
        With cbLecturerAssigned
            .DataSource = ds.Tables("Lecturer")
            .DisplayMember = "LecturerName"
            .ValueMember = "LecturerName"
            .DropDownHeight = 106
        End With
    End Sub

    Private Sub cbIntakeCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIntakeCode.SelectedIndexChanged
        cbTimetableID.Items.Clear()
        cbTimetableID.SelectedIndex = -1
        cbDay.SelectedIndex = -1
        cbTime.SelectedIndex = -1
        txtModuleName.Clear()
        cbClassroomAssigned.SelectedIndex = -1
        cbLecturerAssigned.SelectedIndex = -1

        If cbIntakeCode.SelectedIndex <> -1 Then    'avoid users from selecting timetableID if the intakecode is not selected
            cbTimetableID.Enabled = True
        End If

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Timetable WHERE Intake_Code = '" & cbIntakeCode.Text & "'", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim SimilarIntakeCode As Boolean = False

        'if found
        While dr.Read
            Dim TEMP As Integer = dr("TimetableID").ToString()
            SimilarIntakeCode = True
            cbTimetableID.Items.Add("T" + TEMP.ToString("0000"))
        End While
    End Sub

    Private Sub cbTimetableID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTimetableID.SelectedIndexChanged

        If cbTimetableID.SelectedIndex <> -1 Then
            Dim Temp_String() As String = cbTimetableID.Text.Split("T")
            TimetableID = Temp_String(1)

            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Timetable WHERE TimetableID = " & CInt(TimetableID) & "", connection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            Dim SimilarTimetableID As Boolean = False

            'if found
            While dr.Read
                SimilarTimetableID = True
                cbDay.Text = dr("Day1").ToString()
                cbTime.Text = dr("Time1").ToString()
                txtModuleName.Text = dr("Module_Name").ToString()
                cbClassroomAssigned.Text = dr("Classroom_Name").ToString()
                cbLecturerAssigned.Text = dr("Lecturer_Assigned").ToString()
            End While
        End If
    End Sub

    Private Sub cbDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDay.SelectedIndexChanged
        If cbDay.Text = "Monday" Then
            txtDayID.Text = "1"
        ElseIf cbDay.Text = "Tuesday" Then
            txtDayID.Text = "2"
        ElseIf cbDay.Text = "Wednesday" Then
            txtDayID.Text = "3"
        ElseIf cbDay.Text = "Thursday" Then
            txtDayID.Text = "4"
        ElseIf cbDay.Text = "Friday" Then
            txtDayID.Text = "5"
        End If
    End Sub

    Private Sub txtModuleName_Leave(sender As Object, e As EventArgs) Handles txtModuleName.Leave
        If Not Regex.Match(txtModuleName.Text, "^[a-z\s]*$", RegexOptions.IgnoreCase).Success Then 'Only Letters

            My.Computer.Audio.Play(My.Resources.Button_Error, AudioPlayMode.Background)
            MessageBox.Show("Please Enter Alphabetic Characters Only!", "Module Name Error") 'Inform User

            txtModuleName.Focus() 'Return Focus
            txtModuleName.Clear() 'Clear TextBox

            NameValid = False 'Boolean = False
        Else

            NameValid = True 'Everything Fine

        End If
    End Sub

End Class