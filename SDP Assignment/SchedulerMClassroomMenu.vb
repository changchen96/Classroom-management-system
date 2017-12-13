Imports System.Data.OleDb

Public Class frmSchedulerMClassroomMenu
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim MaxRows As Integer
    Dim tables As DataTableCollection

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerClassroomMenu.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim dr As OleDbDataReader

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Classroom WHERE ClassroomName = '" & txtClassroomName.Text & "' AND ClassroomSize = '" & cbClassroomSize.Text & "' AND ClassroomType = '" & cbClassroomType.Text & "'", connection)
        dr = cmd.ExecuteReader
        Dim SimilarClassroomDetails As Boolean = False
        'if found
        While dr.Read
            SimilarClassroomDetails = True
        End While

        Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT * FROM Classroom WHERE ClassroomName = '" & cbClassroomName.Text & "' AND ClassroomName = '" & txtClassroomName.Text & "' AND ClassroomSize <> '" & cbClassroomSize.Text & "' OR ClassroomType <> '" & cbClassroomType.Text & "'", connection)
        dr = cmd2.ExecuteReader
        Dim NewClassroomDetails As Boolean = False
        'if found
        While dr.Read
            NewClassroomDetails = True
        End While

        Dim cmd3 As OleDbCommand = New OleDbCommand("SELECT * FROM Classroom WHERE ClassroomName = '" & txtClassroomName.Text & "' AND ClassroomID <> '" & txtClassroomID.Text & "'", connection)
        dr = cmd3.ExecuteReader
        Dim SimilarClassroomName As Boolean = False
        'if found
        While dr.Read
            SimilarClassroomName = True
        End While

        If SimilarClassroomDetails = True Then   'classroom duplication
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Similar classroom details has been found in the database!", vbExclamation & vbOKOnly, "Error")

        ElseIf NewClassroomDetails = True Then
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            UpdateClassroom()

        ElseIf SimilarClassroomName = True Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Similar classroom name has been found in the database!", vbExclamation & vbOKOnly, "Error")

        Else
            cmd = New OleDbCommand("SELECT * FROM Classroom", connection)
            dr = cmd.ExecuteReader
            cmd2 = New OleDbCommand("SELECT * FROM Classroom", connection)
            dr = cmd2.ExecuteReader
            cmd3 = New OleDbCommand("SELECT * FROM Classroom", connection)
            dr = cmd3.ExecuteReader
            da = New OleDb.OleDbDataAdapter(sql, connection)
            da.Fill(ds, "Classroom")
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            UpdateClassroom()
        End If
    End Sub

    Private Sub UpdateClassroom()
        If txtClassroomName.Text = "" Or cbClassroomType.SelectedIndex = -1 Or cbClassroomSize.SelectedIndex = -1 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Please make sure that all of the fields are filled in.", vbExclamation & vbOKOnly, "Empty Field(s)")

        ElseIf cbClassroomType.Text = "Basic Classroom" And cbClassroomSize.Text = "60" Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Basic Classrooms can only hold the size of 30, 40 and 50 students.", vbExclamation & vbOKOnly, "Invalid Classroom Size")

        ElseIf cbClassroomType.Text = "Basic Classroom" And cbClassroomSize.Text = "100" Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Basic Classrooms can only hold the size of 30, 40 and 50 students.", vbExclamation & vbOKOnly, "Invalid Classroom Size")

        ElseIf cbClassroomType.Text = "Laboratory" And cbClassroomSize.Text <> "60" Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Laboratories can only hold the size of 60 students.", vbExclamation & vbOKOnly, "Invalid Classroom Size")

        ElseIf cbClassroomType.Text = "Auditorium" And cbClassroomSize.Text <> "100" Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Auditoriums can only hold the size of 100 students.", vbExclamation & vbOKOnly, "Invalid Classroom Size")

        Else
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            MsgBox("The Classroom Details have been successfully updated!", vbOKOnly, "Successful Update")
            Dim SqlUpdate As String
            SqlUpdate = "UPDATE Classroom SET [ClassroomName] = '" & txtClassroomName.Text & "', [ClassroomType] = '" & cbClassroomType.Text & "', [ClassroomSize] = '" & cbClassroomSize.Text & "', [ClassroomID] = '" & txtClassroomName.Text & "' WHERE [ClassroomName] = '" & cbClassroomName.Text & "'"
            Dim cmd As OleDbCommand = New OleDbCommand(SqlUpdate, connection)
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Catch ex As Exception
            End Try
            Me.Close()
            frmSchedulerClassroomMenu.Show()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If txtClassroomName.Text = "" Or cbClassroomType.SelectedIndex = -1 Or cbClassroomSize.SelectedIndex = -1 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Empty field(s) cannot be deleted!", vbExclamation & vbOKOnly, "Empty Field(s)")

        Else
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                MsgBox("The Classroom Details have been successfully removed!", vbOKOnly, "Successful Deletion")
                Dim SqlDelete As String
                SqlDelete = "DELETE * FROM Classroom WHERE ClassroomName = '" & cbClassroomName.Text & "'"
                Dim cmd As OleDbCommand = New OleDbCommand(SqlDelete, connection)
                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Catch ex As Exception
                End Try
                cbClassroomName.SelectedIndex = -1
                txtClassroomName.Clear()
                cbClassroomType.SelectedIndex = -1
                cbClassroomSize.SelectedIndex = -1
                Me.Close()
                frmSchedulerClassroomMenu.Show()

                If ds.Tables("Classroom").Rows.Count = 0 Then   'if there is no more records in the database
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    MsgBox("There are no more records to be modified or deleted!", vbExclamation & vbOKOnly, "Empty Record")
                    Me.Close()
                    frmSchedulerClassroomMenu.Show()
                End If
            End If
        End If
    End Sub

    Private Sub frmSchedulerMClassroomMenu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        cbClassroomName.SelectedIndex = -1
        txtClassroomID.Clear()
        txtClassroomName.Clear()
        cbClassroomType.SelectedIndex = -1
        cbClassroomSize.SelectedIndex = -1
        cbClassroomName.Select()
    End Sub

    Private Sub frmSchedulerMClassroomMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'With ... End With is used to reduce repetition of Name. eg: dont have to type cbClassroomName x4
        With cbClassroomName    'without the With ... End With,
            .DataSource = ds.Tables("Classroom")
            .DisplayMember = "ClassroomName"
            .ValueMember = "ClassroomName"
            .SelectedIndex = -1
            .DropDownHeight = 106
        End With
    End Sub

    Private Sub cbClassroomName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClassroomName.SelectedIndexChanged

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Classroom] WHERE ([ClassroomName] = '" & cbClassroomName.Text & "')", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim SimilarClassroomName As Boolean = False

        'if found
        While dr.Read
            SimilarClassroomName = True
            txtClassroomID.Text = dr("ClassroomID").ToString()
            txtClassroomName.Text = dr("ClassroomName").ToString()
            cbClassroomType.Text = dr("ClassroomType").ToString()
            cbClassroomSize.Text = dr("ClassroomSize").ToString()
        End While
    End Sub
End Class