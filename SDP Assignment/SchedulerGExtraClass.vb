Imports System.Data.OleDb

Public Class frmSchedulerGExtraClass

    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim inc As Integer
    Dim tables As DataTableCollection

    Private Sub frmSchedulerGExtraClass_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        txtClassPurpose.Clear()
        cbClassroomAssigned.SelectedIndex = -1
        cbDay.SelectedIndex = -1
        cbTime.SelectedIndex = -1
        txtBookedby.Clear()
        txtClassPurpose.Select()
    End Sub

    Private Sub SchedulerGExtraClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        sql = "SELECT * FROM Timetable ORDER BY [DayID], [Time1]"
        da = New OleDb.OleDbDataAdapter(sql, connection)
        da.Fill(ds, "Timetable")
        inc = -1

        tables = ds.Tables()

        ClassroomDropDown()

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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerTimetableMenu.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        txtClassPurpose.Clear()
        cbClassroomAssigned.SelectedIndex = -1
        cbDay.SelectedIndex = -1
        cbTime.SelectedIndex = -1
        txtBookedby.Clear()
        txtClassPurpose.Select()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)

        '********* VALIDATION FOR CLASSROOM, DAY and TIME ****************
        Dim dr As OleDbDataReader

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Timetable] WHERE ([Day1] = '" & cbDay.Text & "' AND [Time1] = '" & cbTime.Text & "' AND [Classroom_Name] = '" & cbClassroomAssigned.Text & "')", connection)
        dr = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim SimilarClassroom As Boolean = False

        'if found
        While dr.Read
            SimilarClassroom = True
        End While

        Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT * FROM [Timetable] WHERE ExtraClassName_Purpose = '" & txtClassPurpose.Text & "'", connection)
        dr = cmd2.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim SimilarClassNamePurpose As Boolean = False

        'if found
        While dr.Read
            SimilarClassNamePurpose = True
        End While

        If SimilarClassroom = True Then   'classroom duplication
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Classroom has been occupied at this day and time!", vbExclamation & vbOKOnly, "Error")

        ElseIf SimilarClassNamePurpose = True Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Similar Class Name or Purpose has already been used!", vbExclamation & vbOKOnly, "Error")

        ElseIf SimilarClassroom = True And SimilarClassNamePurpose = True Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Similar Extra Class has already been booked!", vbExclamation & vbOKOnly, "Error")

        Else
            cmd = New OleDbCommand("SELECT * FROM [Timetable]", connection)
            dr = cmd.ExecuteReader
            cmd2 = New OleDbCommand("SELECT * FROM [Timetable]", connection)
            dr = cmd2.ExecuteReader
            da = New OleDb.OleDbDataAdapter(sql, connection)
            da.Fill(ds, "Timetable")
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            GenerateExtraClass()
        End If
    End Sub

    Private Sub GenerateExtraClass()
        If txtClassPurpose.Text = "" Or cbClassroomAssigned.SelectedIndex = -1 Or cbDay.SelectedIndex = -1 Or cbTime.SelectedIndex = -1 Or txtBookedby.Text = "" Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Please make sure that all of the fields are filled in.", vbExclamation & vbOKOnly, "Empty Field(s)")

        Else
            MsgBox("The Extra Class has been successfully generated!", vbOKOnly, "Successful")
            If inc <> 0 Then
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                Dim dsNewRow As DataRow
                dsNewRow = ds.Tables("Timetable").NewRow
                dsNewRow.Item("ExtraClassName_Purpose") = txtClassPurpose.Text
                dsNewRow.Item("Classroom_Name") = cbClassroomAssigned.Text
                dsNewRow.Item("Day1") = cbDay.Text
                dsNewRow.Item("BookedBy") = txtBookedby.Text
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

                txtClassPurpose.Clear()
                cbClassroomAssigned.SelectedIndex = -1
                cbDay.SelectedIndex = -1
                cbTime.SelectedIndex = -1
                txtBookedby.Clear()
            End If
        End If

    End Sub
End Class