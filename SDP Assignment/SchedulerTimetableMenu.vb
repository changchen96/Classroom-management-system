Imports System.Data.OleDb
Public Class frmSchedulerTimetableMenu
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource

    Private Sub frmSchedulerTimetableMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblName.Text = frmLoginPage.DisplayName
        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        tables = ds.Tables

        IntakeTimetable()
        LecturerTimetable()
        UserIdentification()
    End Sub

    Private Sub IntakeTimetable()

        da = New OleDb.OleDbDataAdapter("SELECT IntakeCode FROM IntakeDetails ORDER BY [IntakeCourse],[IntakeCode]", connection)
        da.Fill(ds, "IntakeDetails")
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

    Private Sub UserIdentification()
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

    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch1.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        cbLecturerName.SelectedIndex = -1
        cbClassPurpose.SelectedIndex = -1

        tables.Clear()  'avoid duplication in the DATA GRID VIEW when the 'Search' button is clicked x2

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Timetable] WHERE ([Intake_Code] = '" & cbIntakeCode.Text & "')", connection)
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
            sql = "SELECT Day1, Time1, Classroom_Name, Module_Name, Lecturer_Assigned FROM [Timetable] WHERE ([Intake_Code] = '" & cbIntakeCode.Text & "') ORDER BY [DayID], [Time1]"
            da = New OleDbDataAdapter(sql, connection)
            da.Fill(ds, "Timetable")
            'display the table on the DATA GRID VIEW when the 'Search' button is clicked
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DGVTimetable.DataSource = view
            'modification
            DGVTimetable.Columns(0).HeaderText = "Day"
            DGVTimetable.Columns(1).HeaderText = "Time"
            DGVTimetable.Columns(2).HeaderText = "Classroom Name"
            DGVTimetable.Columns(3).HeaderText = "Module Name"
            DGVTimetable.Columns(4).HeaderText = "Lecturer Assigned"
            DGVTimetable.Columns(0).Width = 70
            DGVTimetable.Columns(1).Width = 70
            DGVTimetable.Columns(2).Width = 70
            DGVTimetable.Columns(3).Width = 220
            DGVTimetable.Columns(4).Width = 100

        ElseIf cbIntakeCode.SelectedIndex = -1 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("No intake code is selected!", vbExclamation & vbOKOnly, "Invalid Input")
            cbIntakeCode.SelectedIndex = -1
            cbLecturerName.SelectedIndex = -1
            cbClassPurpose.SelectedIndex = -1
            cbIntakeCode.Select()
            DGVTimetable.DataSource = Nothing

        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Timetable is not found for this Intake Code!", vbExclamation & vbOKOnly, "Invalid Input")
            cbIntakeCode.SelectedIndex = -1
            cbLecturerName.SelectedIndex = -1
            cbClassPurpose.SelectedIndex = -1
            cbIntakeCode.Select()
            DGVTimetable.DataSource = Nothing
        End If

    End Sub

    Private Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        cbIntakeCode.SelectedIndex = -1
        cbClassPurpose.SelectedIndex = -1

        tables.Clear()  'avoid duplication in the DATA GRID VIEW when the 'Search' button is clicked x2

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Timetable] WHERE ([Lecturer_Assigned] = '" & cbLecturerName.Text & "')", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim LecturerIDFound As Boolean = False

        'if found
        While dr.Read
            LecturerIDFound = True
        End While

        If LecturerIDFound = True Then
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            'this functions to display the table on the DATA GRID VIEW
            sql = "SELECT Day1, Time1, Classroom_Name, Module_Name, Intake_Code, Lecturer_Assigned FROM [Timetable] WHERE ([Lecturer_Assigned] = '" & cbLecturerName.Text & "') ORDER BY [DayID], [Time1]"
            da = New OleDbDataAdapter(sql, connection)
            da.Fill(ds, "Timetable")
            'display the table on the DATA GRID VIEW when the 'Search' button is clicked
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DGVTimetable.DataSource = view
            'modification
            DGVTimetable.Columns(0).HeaderText = "Day"
            DGVTimetable.Columns(1).HeaderText = "Time"
            DGVTimetable.Columns(2).HeaderText = "Classroom Name"
            DGVTimetable.Columns(3).HeaderText = "Module Name"
            DGVTimetable.Columns(4).HeaderText = "Inntake Code"
            DGVTimetable.Columns(5).HeaderText = "Lecturer Name"
            DGVTimetable.Columns(0).Width = 70
            DGVTimetable.Columns(1).Width = 70
            DGVTimetable.Columns(2).Width = 70
            DGVTimetable.Columns(3).Width = 220
            DGVTimetable.Columns(4).Width = 100
            DGVTimetable.Columns(5).Width = 150

        ElseIf cbLecturerName.SelectedIndex = -1 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("No lecturer is selected!", vbExclamation & vbOKOnly, "Invalid Input")
            cbIntakeCode.SelectedIndex = -1
            cbLecturerName.SelectedIndex = -1
            cbClassPurpose.SelectedIndex = -1
            cbIntakeCode.Select()
            DGVTimetable.DataSource = Nothing

        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Timetable is not found for this lecturer!", vbExclamation & vbOKOnly, "Invalid Input")
            cbIntakeCode.SelectedIndex = -1
            cbLecturerName.SelectedIndex = -1
            cbClassPurpose.SelectedIndex = -1
            cbIntakeCode.Select()
            DGVTimetable.DataSource = Nothing
        End If
    End Sub

    Private Sub btnSearch3_Click(sender As Object, e As EventArgs) Handles btnSearch3.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        cbIntakeCode.SelectedIndex = -1
        cbLecturerName.SelectedIndex = -1

        tables.Clear()  'avoid duplication in the DATA GRID VIEW when the 'Search' button is clicked x2

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Timetable] WHERE ([ExtraClassName_Purpose] = '" & cbClassPurpose.Text & "')", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim ClassPurpose As Boolean = False

        'if found
        While dr.Read
            ClassPurpose = True
        End While

        If ClassPurpose = True Then
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            'this functions to display the table on the DATA GRID VIEW
            sql = "SELECT ExtraClassName_Purpose, Day1, Time1, Classroom_Name, Bookedby FROM [Timetable] WHERE ([ExtraClassName_Purpose] = '" & cbClassPurpose.Text & "') ORDER BY [ExtraClassName_Purpose]"
            da = New OleDbDataAdapter(sql, connection)
            da.Fill(ds, "Timetable")
            'display the table on the DATA GRID VIEW when the 'Search' button is clicked
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DGVTimetable.DataSource = view
            'modification
            DGVTimetable.Columns(0).HeaderText = "Class Purpose"
            DGVTimetable.Columns(1).HeaderText = "Day"
            DGVTimetable.Columns(2).HeaderText = "Time"
            DGVTimetable.Columns(3).HeaderText = "Classroom Name"
            DGVTimetable.Columns(4).HeaderText = "Booked By"
            DGVTimetable.Columns(0).Width = 190
            DGVTimetable.Columns(1).Width = 70
            DGVTimetable.Columns(2).Width = 70
            DGVTimetable.Columns(3).Width = 100
            DGVTimetable.Columns(4).Width = 100

        ElseIf cbClassPurpose.SelectedIndex = -1 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("No Class Name or Purpose is selected!", vbExclamation & vbOKOnly, "Invalid Input")
            cbIntakeCode.SelectedIndex = -1
            cbLecturerName.SelectedIndex = -1
            cbClassPurpose.SelectedIndex = -1
            cbIntakeCode.Select()
            DGVTimetable.DataSource = Nothing

        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Timetable is not found for this Class Name or Purpose!", vbExclamation & vbOKOnly, "Invalid Input")
            cbIntakeCode.SelectedIndex = -1
            cbLecturerName.SelectedIndex = -1
            cbClassPurpose.SelectedIndex = -1
            cbIntakeCode.Select()
            DGVTimetable.DataSource = Nothing
        End If
    End Sub

    Private Sub btnGTimetable_Click(sender As Object, e As EventArgs) Handles btnGTimetable.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerGTimetableMenu.Show()
    End Sub

    Private Sub btnMTimetable_Click(sender As Object, e As EventArgs) Handles btnMTimetable.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerMTimetableMenu.Show()
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerMM.Show()
    End Sub

    Private Sub btnIntake_Click(sender As Object, e As EventArgs) Handles btnIntake.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerIntakeMenu.Show()
    End Sub

    Private Sub btnClassroom_Click(sender As Object, e As EventArgs) Handles btnClassroom.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerClassroomMenu.Show()
    End Sub

    Private Sub btnResponse_Click(sender As Object, e As EventArgs) Handles btnResponse.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerResponseMenu.Show()
    End Sub

    Private Sub frmSchedulerTimetableMenu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        cbIntakeCode.SelectedIndex = -1
        cbLecturerName.SelectedIndex = -1
        cbClassPurpose.SelectedIndex = -1
        cbIntakeCode.Select()
    End Sub

    Private Sub btnGExtraClass_Click(sender As Object, e As EventArgs) Handles btnGExtraClass.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerGExtraClass.Show()
    End Sub

    Private Sub btnMExtraClass_Click(sender As Object, e As EventArgs) Handles btnMExtraClass.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerMExtraClass.Show()
    End Sub
End Class