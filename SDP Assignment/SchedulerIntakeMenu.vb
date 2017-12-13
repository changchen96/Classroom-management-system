Imports System.Data.OleDb
Public Class frmSchedulerIntakeMenu
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim MaxRows As Integer
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource

    Private Sub btnAIntake_Click(sender As Object, e As EventArgs) Handles btnAIntake.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmAIntakeMenu.Show()
    End Sub

    Private Sub btnMIntake_Click(sender As Object, e As EventArgs) Handles btnMIntake.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmMIntakeMenu.Show()
    End Sub

    Private Sub btnSIntake_Click(sender As Object, e As EventArgs) Handles btnSIntake.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)

        tables.Clear()  'avoid duplication in the DATA GRID VIEW when the 'Search' button is clicked x2

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [IntakeDetails] WHERE ([IntakeCode] = '" & cbIntakeCode.Text & "')", connection)
        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim IntakeCodeFound As Boolean = False

        'if found
        While dr.Read
            IntakeCodeFound = True
        End While

        If IntakeCodeFound = True Then
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            'this functions to display the table on the DATA GRID VIEW
            sql = "SELECT IntakeCode, IntakeLevel, IntakeCourse, IntakeSize, startDate, endDate FROM [IntakeDetails] WHERE ([IntakeCode] = '" & cbIntakeCode.Text & "')"
            da = New OleDb.OleDbDataAdapter(sql, connection)
            da.Fill(ds, "IntakeDetails")
            'display the table on the DATA GRID VIEW when the 'Search' button is clicked
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DGVIntakeMenu.DataSource = view
            'modifications
            DGVIntakeMenu.Columns(0).HeaderText = "Intake Code"
            DGVIntakeMenu.Columns(1).HeaderText = "Intake Level"
            DGVIntakeMenu.Columns(2).HeaderText = "Intake Course"
            DGVIntakeMenu.Columns(3).HeaderText = "Intake Size"
            DGVIntakeMenu.Columns(4).HeaderText = "Start Date"
            DGVIntakeMenu.Columns(5).HeaderText = "End Date"
            DGVIntakeMenu.Columns(0).Width = 100
            DGVIntakeMenu.Columns(1).Width = 100
            DGVIntakeMenu.Columns(2).Width = 200
            DGVIntakeMenu.Columns(3).Width = 90
            DGVIntakeMenu.Columns(4).Width = 90
            DGVIntakeMenu.Columns(5).Width = 90
        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Intake Code not found!", vbExclamation & vbOKOnly, "Invalid Input")
            cbIntakeCode.SelectedIndex = -1
            cbIntakeCode.Select()
        End If

    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerMM.Show()
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

    Private Sub btnClassroom_Click(sender As Object, e As EventArgs) Handles btnClassroom.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerClassroomMenu.Show()
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

    Private Sub frmSchedulerIntakeMenu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        cbIntakeCode.SelectedIndex = -1
        cbIntakeCode.Select()
    End Sub

    Private Sub frmSchedulerIntakeMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblName.Text = frmLoginPage.DisplayName
        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        sql = "SELECT * FROM IntakeDetails ORDER BY [IntakeCourse], [IntakeCode]"
        da = New OleDb.OleDbDataAdapter(sql, connection)
        da.Fill(ds, "IntakeDetails")
        MaxRows = ds.Tables("IntakeDetails").Rows.Count

        tables = ds.Tables
        IntakeCodeDropDown()

        'if the IntakeDetails database is empty, users will not be able to click on "Modify Intake"
        If ds.Tables("IntakeDetails").Rows.Count = 0 Then
            btnMIntake.Enabled = False
        Else
            btnMIntake.Enabled = True
        End If
    End Sub

    Private Sub btnVIntake_Click(sender As Object, e As EventArgs) Handles btnVIntake.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)

        cbIntakeCode.SelectedIndex = -1
        tables.Clear()  'avoid duplication in the DATA GRID VIEW when the 'Search' button is clicked x2

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [IntakeDetails] ORDER BY [IntakeCourse],[IntakeCode]", connection)
        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim IntakeAvailable As Boolean = False

        'if found
        While dr.Read
            IntakeAvailable = True
        End While

        If IntakeAvailable = True Then
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            'this functions to display the table on the DATA GRID VIEW
            sql = "SELECT IntakeCode, IntakeLevel, IntakeCourse, IntakeSize, startDate, endDate FROM [IntakeDetails] ORDER BY [IntakeCourse],[IntakeCode]"
            da = New OleDb.OleDbDataAdapter(sql, connection)
            da.Fill(ds, "IntakeDetails")
            'display the table on the DATA GRID VIEW when the 'Search' button is clicked
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DGVIntakeMenu.DataSource = view
            'modifications
            DGVIntakeMenu.Columns(0).HeaderText = "Intake Code"
            DGVIntakeMenu.Columns(1).HeaderText = "Intake Level"
            DGVIntakeMenu.Columns(2).HeaderText = "Intake Course"
            DGVIntakeMenu.Columns(3).HeaderText = "Intake Size"
            DGVIntakeMenu.Columns(4).HeaderText = "Start Date"
            DGVIntakeMenu.Columns(5).HeaderText = "End Date"
            DGVIntakeMenu.Columns(0).Width = 100
            DGVIntakeMenu.Columns(1).Width = 100
            DGVIntakeMenu.Columns(2).Width = 200
            DGVIntakeMenu.Columns(3).Width = 90
            DGVIntakeMenu.Columns(4).Width = 90
            DGVIntakeMenu.Columns(5).Width = 90
        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("No Intakes Available!", vbExclamation & vbOKOnly, "Error")
            cbIntakeCode.SelectedIndex = -1
            cbIntakeCode.Select()
        End If
    End Sub

    Private Sub IntakeCodeDropDown()
        Dim view As New DataView(tables(0))
        'With ... End With is used to reduce repetition of Name. eg: dont have to type cbIntakeCode x4
        With cbIntakeCode   'without the With ... End With,
            .DataSource = ds.Tables("IntakeDetails")
            .DisplayMember = "IntakeCode"
            .ValueMember = "IntakeCode"
            .SelectedIndex = -1
            .DropDownHeight = 106
        End With
    End Sub
End Class