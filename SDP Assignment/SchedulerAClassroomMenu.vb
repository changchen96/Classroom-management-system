Imports System.Text.RegularExpressions
Imports System.Data.OleDb

Public Class frmSchedulerAClassroomMenu
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim inc As Integer
    Dim MaxRows As Integer

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerClassroomMenu.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        txtClassroomName.Clear()
        cbClassroomType.SelectedIndex = -1
        txtClassroomName.Select()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Classroom] WHERE ([ClassroomName] = '" & txtClassroomName.Text & "')", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim SimilarClassroomName As Boolean = False

        'if found
        While dr.Read
            SimilarClassroomName = True
        End While

        If SimilarClassroomName = True Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Similar Classroom Name has already been used!", vbExclamation & vbOKOnly, "Error")
        Else
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            NewClassroomName()
        End If

    End Sub

    Private Sub NewClassroomName()
        If txtClassroomName.Text = "eg: L1-01-BC" Or cbClassroomSize.SelectedIndex = -1 Or cbClassroomType.SelectedIndex = -1 Then
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
            MsgBox("The Classroom Details have been successfully added!", vbOKOnly, "Successful")
            If inc <> 0 Then
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                Dim dsNewRow As DataRow
                dsNewRow = ds.Tables("Classroom").NewRow
                dsNewRow.Item("ClassroomName") = txtClassroomName.Text
                dsNewRow.Item("ClassroomType") = cbClassroomType.Text
                dsNewRow.Item("ClassroomSize") = cbClassroomSize.Text
                dsNewRow.Item("ClassroomID") = txtClassroomName.Text

                ds.Tables("Classroom").Rows.Add(dsNewRow)
                da.Update(ds, "Classroom")

                txtClassroomName.Clear()
                cbClassroomType.SelectedIndex = -1
                cbClassroomSize.SelectedIndex = -1
                txtClassroomName.Text = "eg: L1-01-BC"
                txtClassroomName.Select()
            End If
        End If
    End Sub

    Private Sub frmSchedulerAClassroomMenu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        cbClassroomType.SelectedIndex = -1
        cbClassroomType.SelectedIndex = -1
        txtClassroomName.Select()
    End Sub

    Private Sub frmSchedulerAClassroomMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        sql = "SELECT * FROM Classroom"
        da = New OleDb.OleDbDataAdapter(sql, connection)
        da.Fill(ds, "Classroom")
        MaxRows = ds.Tables("Classroom").Rows.Count
        inc = -1
    End Sub
End Class