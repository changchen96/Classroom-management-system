Imports System.Data.OleDb

Public Class frmSchedulerMExtraClass

    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim inc As Integer
    Dim tables As DataTableCollection

    Private Sub frmSchedulerMExtraClass_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        cbClassPurpose.SelectedIndex = -1
        cbClassroomAssigned.SelectedIndex = -1
        cbDay.SelectedIndex = -1
        txtDayID.Clear()
        cbTime.SelectedIndex = -1
        txtBookedby.Clear()
        cbClassPurpose.Select()
    End Sub

    Private Sub frmSchedulerMExtraClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        tables = ds.Tables()
        ClassroomDropDown()
        UserIdentificationDropDown()

        inc = -1

    End Sub

    Private Sub UserIdentificationDropDown()
        da = New OleDb.OleDbDataAdapter("SELECT ExtraClassName_Purpose FROM Timetable WHERE ExtraClassName_Purpose Is NOT NULL ORDER BY [ExtraClassName_Purpose]", connection)
        da.Fill(ds, "Timetable")
        Dim view As New DataView(tables(0))
        'With ... End With is used to reduce repetition of Name. eg: dont have to type cbClassPurpose x4
        With cbClassPurpose
            .DataSource = ds.Tables("Timetable")
            .DisplayMember = "ExtraClassName_Purpose"
            .ValueMember = "ExtraClassName_Purpose"
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerTimetableMenu.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        '********* VALIDATION FOR CLASSROOM, LECTURER, INTAKE, DAY and TIME ****************
        Dim dr As OleDbDataReader

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Timetable WHERE Day1 = '" & cbDay.Text & "' AND Time1 = '" & cbTime.Text & "' AND Classroom_Name = '" & cbClassroomAssigned.Text & "'", connection)
        dr = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim SimilarClassroom As Boolean = False

        'if found
        While dr.Read
            SimilarClassroom = True
        End While

        If SimilarClassroom = True Then   'classroom duplication
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Classroom has been occupied at this day and time!", vbExclamation & vbOKOnly, "Error")

        Else
            cmd = New OleDbCommand("SELECT * FROM [Timetable]", connection)
            dr = cmd.ExecuteReader
            'da = New OleDb.OleDbDataAdapter(sql, connection)
            'da.Fill(ds, "Timetable")
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            ModifyExtraClass()
        End If
    End Sub

    Private Sub ModifyExtraClass()
        If cbClassPurpose.SelectedIndex = -1 Or cbClassroomAssigned.SelectedIndex = -1 Or cbDay.SelectedIndex = -1 Or cbTime.SelectedIndex = -1 Or txtBookedby.Text = "" Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Please make sure that all of the fields are filled in.", vbExclamation & vbOKOnly, "Empty Field(s)")

        Else
            MsgBox("The Extra Class has been successfully modified!", vbOKOnly, "Successful")
            Dim SqlUpdate As String
            SqlUpdate = "UPDATE Timetable SET [DayID] = '" & txtDayID.Text & "', [Day1] = '" & cbDay.Text & "', [Time1] = '" & cbTime.Text & "', [Classroom_Name] = '" & cbClassroomAssigned.Text & "' WHERE [ExtraClassName_Purpose] = '" & cbClassPurpose.Text & "'"
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
        If cbClassPurpose.SelectedIndex = -1 Or cbClassroomAssigned.SelectedIndex = -1 Or cbDay.SelectedIndex = -1 Or cbTime.SelectedIndex = -1 Or txtBookedby.Text = "" Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Empty field(s) cannot be deleted!", vbExclamation & vbOKOnly, "Empty Field(s)")
        Else
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                MsgBox("The timetable details have been successfully removed!", vbOKOnly, "Successful Deletion")
                Dim SqlDelete As String
                SqlDelete = "DELETE * FROM Timetable WHERE ExtraClassName_Purpose = '" & cbClassPurpose.Text & "' "
                Dim cmd As OleDbCommand = New OleDbCommand(SqlDelete, connection)
                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Catch ex As Exception
                End Try
                cbClassPurpose.SelectedIndex = -1
                cbDay.SelectedIndex = -1
                cbTime.SelectedIndex = -1
                cbClassroomAssigned.SelectedIndex = -1
                txtBookedby.Clear()

                If ds.Tables("Timetable").Rows.Count = 0 Then   'if there is no more records in the database
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    MsgBox("There are no more records to be modified or deleted!", vbExclamation & vbOKOnly, "Empty Record")
                    Me.Close()
                    frmSchedulerTimetableMenu.Show()
                End If
            End If
        End If
    End Sub

    Private Sub cbClassPurpose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClassPurpose.SelectedIndexChanged

        cbDay.SelectedIndex = -1
        cbTime.SelectedIndex = -1
        cbClassroomAssigned.SelectedIndex = -1
        txtBookedby.Clear()

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Timetable WHERE ExtraClassName_Purpose = '" & cbClassPurpose.Text & "'", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim SimilarClassPurpose As Boolean = False

        'if found
        While dr.Read
            SimilarClassPurpose = True

            cbDay.Text = dr("Day1").ToString()
            cbTime.Text = dr("Time1").ToString()
            cbClassroomAssigned.Text = dr("Classroom_Name").ToString()
            txtBookedby.Text = dr("Bookedby").ToString()
        End While
    End Sub
End Class