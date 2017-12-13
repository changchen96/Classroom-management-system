Imports System.Data.OleDb
Public Class frmLoginPage
    Public StudentID As String
    Public LecturerID As String
    Public SchedulerID As String
    Public DisplayName As String
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Select()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dr As OleDbDataReader

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Credentials] WHERE ([Username] = '" & txtUsername.Text & "' AND [Password] = '" & txtPassword.Text & "') AND (Role = 'Student')", connection)
        dr = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim StudentFound As Boolean = False
        'if found
        While dr.Read
            StudentFound = True
            DisplayName = dr("DisplayName").ToString
            StudentID = dr("Username").ToString
        End While

        Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT * FROM [Credentials] WHERE ([Username] = '" & txtUsername.Text & "' AND [Password] = '" & txtPassword.Text & "') AND (Role = 'Lecturer')", connection)
        dr = cmd2.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim LecturerFound As Boolean = False
        'if found
        While dr.Read
            LecturerFound = True
            DisplayName = dr("DisplayName").ToString
            LecturerID = dr("Username").ToString
        End While

        Dim cmd3 As OleDbCommand = New OleDbCommand("SELECT * FROM [Credentials] WHERE ([Username] = '" & txtUsername.Text & "' AND [Password] = '" & txtPassword.Text & "') AND (Role = 'Scheduler')", connection)
        dr = cmd3.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim SchedulerFound As Boolean = False
        'if found
        While dr.Read
            SchedulerFound = True
            DisplayName = dr("DisplayName").ToString
            SchedulerID = dr("Username").ToString
        End While

        'checking the result
        If StudentFound = True Then
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            Me.Hide()
            frmStudentMM.Show()
        ElseIf LecturerFound = True Then
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            Me.Hide()
            frmLecturerMM.Show()
        ElseIf SchedulerFound = True Then
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            Me.Hide()
            frmSchedulerMM.Show()
        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Invalid Username or Password!", vbExclamation & vbOKOnly, "Invalid Login")
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Select()
        End If

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If (String.Compare(txtUsername.Text, "") = 0) Then
            btnClear.Enabled = False
        Else
            btnClear.Enabled = True
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If (String.Compare(txtPassword.Text, "") = 0) Then
            btnClear.Enabled = False
        Else
            btnClear.Enabled = True
        End If
    End Sub

    Private Sub frmLecturerLoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        sql = "SELECT * FROM Credentials"
        da = New OleDb.OleDbDataAdapter(sql, connection)
        da.Fill(ds, "Credentials")

        txtUsername.Select()

    End Sub

    Private Sub frmLecturerLoginPage_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Select()
    End Sub
End Class