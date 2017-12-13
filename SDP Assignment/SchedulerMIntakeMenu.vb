Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class frmMIntakeMenu
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim MaxRows As Integer
    Dim tables As DataTableCollection
    Dim RandomID As Integer
    Private NumberValid As Boolean

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerIntakeMenu.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim dr As OleDbDataReader

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM IntakeDetails WHERE IntakeCode = '" & txtIntakeCode.Text & "' AND IntakeLevel = '" & cbIntakeLevel.Text & "' AND IntakeCourse = '" & cbIntakeCourse.Text & "' AND IntakeSize = '" & txtIntakeSize.Text & "' AND RandomID = '" & txtRandomID.Text & "'", connection)
        dr = cmd.ExecuteReader
        Dim SimilarIntakeDetails As Boolean = False
        'if found
        While dr.Read
            SimilarIntakeDetails = True
        End While

        Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT * FROM IntakeDetails WHERE IntakeCode = '" & cbIntakeCode.Text & "' AND IntakeCode = '" & txtIntakeCode.Text & "' AND IntakeLevel <> '" & cbIntakeLevel.Text & "' OR IntakeCourse <> '" & cbIntakeCourse.Text & "' OR IntakeSize <> '" & txtIntakeSize.Text & "'", connection)
        dr = cmd2.ExecuteReader
        Dim NewIntakeDetails As Boolean = False
        'if found
        While dr.Read
            NewIntakeDetails = True
        End While

        Dim cmd3 As OleDbCommand = New OleDbCommand("SELECT * FROM IntakeDetails WHERE IntakeCode = '" & txtIntakeCode.Text & "' AND IntakeID <> '" & txtIntakeID.Text & "'", connection)
        dr = cmd3.ExecuteReader
        Dim SimilarIntakeCode As Boolean = False
        'if found
        While dr.Read
            SimilarIntakeCode = True
        End While

        If SimilarIntakeDetails = True Then   'intake duplication
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Similar intake details has been found in the database!", vbExclamation & vbOKOnly, "Error")

        ElseIf NewIntakeDetails = True And SimilarIntakeCode = False Then    'change intake details
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            UpdateIntakeDetails()

        ElseIf SimilarIntakeCode = True Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)  'similar intake code
            MsgBox("Similar intake code has been found in the database!", vbExclamation & vbOKOnly, "Error")

        Else
            cmd = New OleDbCommand("SELECT * FROM IntakeDetails", connection)
            dr = cmd.ExecuteReader
            cmd2 = New OleDbCommand("SELECT * FROM IntakeDetails", connection)
            dr = cmd2.ExecuteReader
            cmd3 = New OleDbCommand("SELECT * FROM IntakeDetails", connection)
            dr = cmd3.ExecuteReader
            da = New OleDb.OleDbDataAdapter(sql, connection)
            da.Fill(ds, "IntakeDetails")
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            UpdateIntakeDetails()
        End If
    End Sub

    Private Sub UpdateIntakeDetails()
        If txtIntakeID.Text = "" Or cbIntakeLevel.SelectedIndex = -1 Or cbIntakeCourse.SelectedIndex = -1 Or txtIntakeSize.Text = "" Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Please make sure that all of the fields are filled in.", vbExclamation & vbOKOnly, "Empty Field(s)")

        ElseIf txtIntakeSize.Text > 50 Or txtIntakeSize.Text <= 0 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Intake Size must be in between 1 and 50!", vbExclamation & vbOKOnly, "Invalid Intake Size")

        ElseIf DTPEndDate.Text = DTPStartDate.Text Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Start Date and End Date is not appropriate!", vbExclamation & vbOKOnly, "Invalid Date")

        Else
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            MsgBox("The Intake Details have been successfully updated!", vbOKOnly, "Successful Update")
            Dim SqlUpdate As String
            SqlUpdate = "UPDATE IntakeDetails SET [IntakeCode] = '" & txtIntakeCode.Text & "', [IntakeID] = '" & txtIntakeCode.Text & "', [IntakeLevel] = '" & cbIntakeLevel.Text & "', [IntakeCourse] = '" & cbIntakeCourse.Text & "', [IntakeSize] = '" & txtIntakeSize.Text & "', [RandomID] = '" & txtRandomID.Text & "', [startDate] = '" & DTPStartDate.Text & "', [endDate] = '" & DTPEndDate.Text & "' WHERE [IntakeCode] = '" & cbIntakeCode.Text & "'"
            Dim cmd As OleDbCommand = New OleDbCommand(SqlUpdate, connection)
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Catch ex As Exception
            End Try
            Me.Close()
            frmSchedulerIntakeMenu.Show()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If txtIntakeID.Text = "" Or cbIntakeLevel.SelectedIndex = -1 Or cbIntakeCourse.SelectedIndex = -1 Or txtIntakeSize.Text = "" Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Empty field(s) cannot be deleted!", vbExclamation & vbOKOnly, "Empty Field(s)")
        Else
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                MsgBox("The Intake Details have been successfully removed!", vbOKOnly, "Successful Deletion")
                Dim SqlDelete As String
                SqlDelete = "DELETE * FROM IntakeDetails WHERE IntakeCode = '" & cbIntakeCode.Text & "'"
                Dim cmd As OleDbCommand = New OleDbCommand(SqlDelete, connection)
                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Catch ex As Exception
                End Try
                cbIntakeCode.SelectedIndex = -1
                cbIntakeLevel.SelectedIndex = -1
                cbIntakeCourse.SelectedIndex = -1
                txtIntakeSize.Clear()
                Me.Close()
                frmSchedulerIntakeMenu.Show()

                If ds.Tables("IntakeDetails").Rows.Count = 0 Then   'if there is no more records in the database
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                    MsgBox("There are no more records to be modified or deleted!", vbExclamation & vbOKOnly, "Empty Record")
                    Me.Close()
                    frmSchedulerIntakeMenu.Show()
                End If
            End If
        End If


    End Sub

    Private Sub frmMIntakeMenu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        cbIntakeCode.SelectedIndex = -1
        txtIntakeID.Clear()
        txtIntakeCode.Clear()
        cbIntakeLevel.SelectedIndex = -1
        cbIntakeCourse.SelectedIndex = -1
        txtIntakeSize.Clear()
        cbIntakeCode.Select()
    End Sub

    Private Sub frmMIntakeMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        sql = "SELECT * FROM IntakeDetails ORDER BY [IntakeCourse],[IntakeCode]"
        da = New OleDb.OleDbDataAdapter(sql, connection)
        da.Fill(ds, "IntakeDetails")
        MaxRows = ds.Tables("IntakeDetails").Rows.Count

        DTPStartDate.Format = DateTimePickerFormat.Custom
        DTPStartDate.CustomFormat = "dd MMMM yyyy"
        DTPEndDate.Format = DateTimePickerFormat.Custom
        DTPEndDate.CustomFormat = "dd MMMM yyyy"

        tables = ds.Tables
        IntakeCodeDropDown()
    End Sub

    Private Sub IntakeCodeDropDown()
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

    Private Sub cbIntakeCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIntakeCode.SelectedIndexChanged

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [IntakeDetails] WHERE ([IntakeCode] = '" & cbIntakeCode.Text & "')", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim SimilarIntakeCode As Boolean = False

        'if found
        While dr.Read
            SimilarIntakeCode = True
            txtRandomID.Text = dr("RandomID").ToString()
            DTPStartDate.Text = dr("startDate").ToString()
            DTPEndDate.Text = dr("endDate").ToString()
            txtIntakeID.Text = dr("IntakeID").ToString()
            txtIntakeCode.Text = dr("IntakeCode").ToString()
            cbIntakeLevel.Text = dr("IntakeLevel").ToString()
            cbIntakeCourse.Text = dr("IntakeCourse").ToString()
            txtIntakeSize.Text = dr("IntakeSize").ToString()
        End While
    End Sub

    Private Sub DTPStartDate_ValueChanged(sender As Object, e As EventArgs) Handles DTPStartDate.ValueChanged
        DTPEndDate.Value = DTPStartDate.Value.AddDays(90)
        RandomID += 1
        txtRandomID.Text = RandomID
    End Sub

    Private Sub txtIntakeSize_Leave(sender As Object, e As EventArgs) Handles txtIntakeSize.Leave
        If Not Regex.Match(txtIntakeSize.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only Numbers

            My.Computer.Audio.Play(My.Resources.Button_Error, AudioPlayMode.Background)
            MessageBox.Show("Please Enter Numbers Only!", "Intake Size Error") 'Inform User

            txtIntakeSize.Focus() 'Return Focus
            txtIntakeSize.Clear() 'Clear TextBox

            NumberValid = False 'Boolean = False
        Else

            NumberValid = True 'Everything Fine

        End If
    End Sub
End Class