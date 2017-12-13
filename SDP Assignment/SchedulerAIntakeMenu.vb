Imports System.Text.RegularExpressions
Imports System.Data.OleDb

Public Class frmAIntakeMenu
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim inc As Integer
    Dim MaxRows As Integer
    Dim RandomID As Integer = 0
    Private NumberValid As Boolean

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerIntakeMenu.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        txtIntakeCode.Clear()
        cbIntakeLevel.SelectedIndex = -1
        cbIntakeCourse.SelectedIndex = -1
        txtIntakeSize.Clear()
        cbIntakeLevel.Select()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [IntakeDetails] WHERE ([IntakeCode] = '" & txtIntakeCode.Text & "')", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim SimilarIntakeCode As Boolean = False

        'if found
        While dr.Read
            SimilarIntakeCode = True
        End While

        If SimilarIntakeCode = True Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Similar Intake Code has already been used!", vbExclamation & vbOKOnly, "Error")
        Else
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            NewIntakeCode()
        End If
    End Sub

    Private Sub NewIntakeCode()
        If txtIntakeCode.Text = "eg: TCAD001DA" Or txtIntakeCode.Text = "" Or cbIntakeLevel.SelectedIndex = -1 Or cbIntakeCourse.SelectedIndex = -1 Or txtIntakeSize.Text = "" Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Please make sure that all of the fields are filled in.", vbExclamation & vbOKOnly, "Empty Field(s)")

        ElseIf txtIntakeSize.Text > 50 Or txtIntakeSize.Text <= 0 Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Intake Size must be in between 1 and 50!", vbExclamation & vbOKOnly, "Invalid Intake Size")

        ElseIf DTPEndDate.Text = DTPStartDate.Text Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Start Date and End Date is not appropriate!", vbExclamation & vbOKOnly, "Invalid Date")

        Else
            MsgBox("The Intake Details have been successfully added!", vbOKOnly, "Successful")
            If inc <> 0 Then
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                Dim dsNewRow As DataRow
                dsNewRow = ds.Tables("IntakeDetails").NewRow
                dsNewRow.Item("IntakeCode") = txtIntakeCode.Text
                dsNewRow.Item("startDate") = DTPStartDate.Text
                dsNewRow.Item("endDate") = DTPEndDate.Text
                dsNewRow.Item("IntakeLevel") = cbIntakeLevel.Text
                dsNewRow.Item("IntakeCourse") = cbIntakeCourse.Text
                dsNewRow.Item("IntakeSize") = txtIntakeSize.Text
                dsNewRow.Item("IntakeID") = txtIntakeCode.Text
                dsNewRow.Item("RandomID") = RandomID

                ds.Tables("IntakeDetails").Rows.Add(dsNewRow)
                da.Update(ds, "IntakeDetails")

                txtIntakeCode.Clear()
                cbIntakeLevel.SelectedIndex = -1
                cbIntakeCourse.SelectedIndex = -1
                txtIntakeSize.Clear()
                txtIntakeCode.Text = "eg: TCAD001DA"
                txtIntakeCode.Select()
            End If
        End If
    End Sub

    Private Sub frmAIntakeMenu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        cbIntakeLevel.SelectedIndex = -1
        cbIntakeCourse.SelectedIndex = -1
        txtIntakeSize.Clear()
        txtIntakeCode.Select()
    End Sub

    Private Sub frmAIntakeMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        sql = "SELECT * FROM IntakeDetails ORDER BY [IntakeCourse],[IntakeCode]"
        da = New OleDb.OleDbDataAdapter(sql, connection)
        da.Fill(ds, "IntakeDetails")
        MaxRows = ds.Tables("IntakeDetails").Rows.Count
        inc = -1

        DTPStartDate.Format = DateTimePickerFormat.Custom
        DTPStartDate.CustomFormat = "dd MMMM yyyy"
        DTPEndDate.Format = DateTimePickerFormat.Custom
        DTPEndDate.CustomFormat = "dd MMMM yyyy"

    End Sub

    'Private Sub cbIntakeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIntakeLevel.SelectedIndexChanged
    '    AutoGeneration()
    'End Sub

    'Private Sub cbIntakeCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIntakeCourse.SelectedIndexChanged
    '    AutoGeneration()
    'End Sub

    'Private Sub AutoGeneration()
    '    Dim IntakeCode As String = Nothing
    '    Dim IntakeLevel As String = Nothing
    '    Dim IntakeCourse As String = Nothing
    '    Dim Increment As Integer = 0

    '    Select Case cbIntakeLevel.SelectedIndex
    '        Case 0
    '            IntakeLevel = "D"
    '    End Select

    '    Select Case cbIntakeCourse.SelectedIndex
    '        Case 0
    '            IntakeCourse = "DA"
    '        Case 1
    '            IntakeCourse = "MD"
    '    End Select

    '    'Get Increment from Database
    '    'increment

    '    IntakeCode = "TCA" + IntakeLevel + Increment + IntakeCourse
    '    txtIntakeCode.Text = IntakeCode
    'End Sub

    Private Sub DTPStartDate_ValueChanged(sender As Object, e As EventArgs) Handles DTPStartDate.ValueChanged
        DTPEndDate.Value = DTPStartDate.Value.AddDays(90)
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