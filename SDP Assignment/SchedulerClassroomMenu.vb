Imports System.Data.OleDb
Public Class frmSchedulerClassroomMenu
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim MaxRows As String
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource

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

    Private Sub btnSClassroom_Click(sender As Object, e As EventArgs) Handles btnSClassroom.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)

        tables.Clear()  'avoid duplication in the DATA GRID VIEW when the 'Search' button is clicked x2

        Dim cmd As OleDb.OleDbCommand = New OleDbCommand("SELECT * FROM [Classroom] WHERE ([ClassroomName] = '" & cbClassroomName.Text & "')", connection)
        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim ClassroomName As Boolean = False

        'if found
        If dr.Read Then
            ClassroomName = True
        End If

        If ClassroomName = True Then
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            'this functions to display the table on the DATA GRID VIEW
            sql = "SELECT ClassroomName, ClassroomSize, ClassroomType FROM [Classroom] WHERE ([ClassroomName] = '" & cbClassroomName.Text & "')"
            da = New OleDb.OleDbDataAdapter(sql, connection)
            da.Fill(ds, "Classroom")
            'display the table on the DATA GRID VIEW when the 'Search' button is clicked
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DGVClassroom.DataSource = view
            'modifications
            DGVClassroom.Columns(0).HeaderText = "Classroom Name"
            DGVClassroom.Columns(1).HeaderText = "Classroom Size"
            DGVClassroom.Columns(2).HeaderText = "Classroom Type"
            DGVClassroom.Columns(0).Width = 160
            DGVClassroom.Columns(1).Width = 160
            DGVClassroom.Columns(2).Width = 165
        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Classroom Name not found!", vbExclamation & vbOKOnly, "Invalid Input")
            cbClassroomName.SelectedIndex = -1
            cbClassroomName.Select()
        End If


    End Sub

    Private Sub btnAClassroom_Click(sender As Object, e As EventArgs) Handles btnAClassroom.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerAClassroomMenu.Show()
    End Sub

    Private Sub btnMClassroom_Click(sender As Object, e As EventArgs) Handles btnMClassroom.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerMClassroomMenu.Show()
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

    Private Sub frmSchedulerClassroomMenu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        cbClassroomName.SelectedIndex = -1
        cbClassroomName.Select()
    End Sub

    Private Sub frmSchedulerClassroomMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'if the Classroom database is empty, users will not be able to click on "Modify Classroom"
        If ds.Tables("Classroom").Rows.Count = 0 Then
            btnMClassroom.Enabled = False
        Else
            btnMClassroom.Enabled = True
        End If
    End Sub

    Private Sub btnVClassroom_Click(sender As Object, e As EventArgs) Handles btnVClassroom.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)

        tables.Clear()  'avoid duplication in the DATA GRID VIEW when the 'Search' button is clicked x2

        Dim cmd As OleDb.OleDbCommand = New OleDbCommand("SELECT * FROM [Classroom]", connection)
        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim ClassroomName As Boolean = False

        'if found
        If dr.Read Then
            ClassroomName = True
        End If

        If ClassroomName = True Then
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            'this functions to display the table on the DATA GRID VIEW
            sql = "SELECT ClassroomName, ClassroomSize, ClassroomType FROM [Classroom] ORDER BY [ClassroomName]"
            da = New OleDb.OleDbDataAdapter(sql, connection)
            da.Fill(ds, "Classroom")
            'display the table on the DATA GRID VIEW when the 'Search' button is clicked
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DGVClassroom.DataSource = view
            'modifications
            DGVClassroom.Columns(0).HeaderText = "Classroom Name"
            DGVClassroom.Columns(1).HeaderText = "Classroom Size"
            DGVClassroom.Columns(2).HeaderText = "Classroom Type"
            DGVClassroom.Columns(0).Width = 160
            DGVClassroom.Columns(1).Width = 160
            DGVClassroom.Columns(2).Width = 155
        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("No Classrooms Available!", vbExclamation & vbOKOnly, "Error")
            cbClassroomName.SelectedIndex = -1
            cbClassroomName.Select()
        End If
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

    Private Sub btnClassroomAvailability_Click(sender As Object, e As EventArgs) Handles btnClassroomAvailability.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerClassroomAvailability.Show()
    End Sub
End Class