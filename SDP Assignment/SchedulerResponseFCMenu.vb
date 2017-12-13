Public Class frmSchedulerResponseFCMenu
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim inc As Integer
    Dim MaxRows As Integer
    Dim tables As DataTableCollection

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

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'enable users to edit the data in the textbox and combobox
        txtResponse.Enabled = True

        btnend.Enabled = True
        btnprevious.Enabled = True
        btnnext.Enabled = True

        txtResponse.Clear() 'clear the response textbox when the users navigate around the feedback

        If inc <> 0 Then
            inc = 0
            txtFeedback.Text = ds.Tables("Feedback").Rows(inc).Item(1)
            txtResponse.Text = ds.Tables("Feedback").Rows(inc).Item(2)
            btnstart.Enabled = False
            btnprevious.Enabled = False

            If ds.Tables("Feedback").Rows.Count = 1 Then    'if there's is only 1 record
                btnstart.Enabled = False
                btnend.Enabled = False
                btnprevious.Enabled = False
                btnnext.Enabled = False
            End If

        ElseIf inc = 0 Then
            btnstart.Enabled = False
        End If

    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'enable users to edit the data in the textboxes
        txtResponse.Enabled = True

        btnend.Enabled = True
        btnstart.Enabled = True
        btnnext.Enabled = True

        txtResponse.Clear() 'clear the response textbox when the users navigate around the feedback

        If inc > 0 Then
            inc = inc - 1
            txtFeedback.Text = ds.Tables("Feedback").Rows(inc).Item(1)
            txtResponse.Text = ds.Tables("Feedback").Rows(inc).Item(2)

            If ds.Tables("Feedback").Rows.Count = 1 Then    'if there's is only 1 record
                btnstart.Enabled = False
                btnend.Enabled = False
                btnprevious.Enabled = False
                btnnext.Enabled = False

            ElseIf inc = 0 Then 'disallow user from clicking the previous button once the first record is shown
                btnprevious.Enabled = False
                btnstart.Enabled = False
            End If

        ElseIf inc = 0 Then
            btnprevious.Enabled = False
        End If
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'enable users to edit the data in the textboxes
        txtResponse.Enabled = True

        btnend.Enabled = True
        btnprevious.Enabled = True
        btnstart.Enabled = True

        txtResponse.Clear() 'clear the response textbox when the users navigate around the feedback

        If inc <> MaxRows - 1 Then
            inc = inc + 1
            txtFeedback.Text = ds.Tables("Feedback").Rows(inc).Item(1)
            txtResponse.Text = ds.Tables("Feedback").Rows(inc).Item(2)

            If ds.Tables("Feedback").Rows.Count = 1 Then    'if there's is only 1 record
                btnstart.Enabled = False
                btnend.Enabled = False
                btnprevious.Enabled = False
                btnnext.Enabled = False

            ElseIf inc = MaxRows - 1 Then   'disallow user from clicking the next button once the last record is shown
                btnnext.Enabled = False
                btnend.Enabled = False
            End If

        ElseIf inc = MaxRows - 1 Then
            btnnext.Enabled = False
        End If
    End Sub

    Private Sub btnend_Click(sender As Object, e As EventArgs) Handles btnend.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        'enable users to edit the data in the textboxes
        txtResponse.Enabled = True

        btnstart.Enabled = True
        btnprevious.Enabled = True
        btnnext.Enabled = True

        txtResponse.Clear() 'clear the response textbox when the users navigate around the feedback

        If inc <> MaxRows - 1 Then
            inc = MaxRows - 1
            txtFeedback.Text = ds.Tables("Feedback").Rows(inc).Item(1)
            txtResponse.Text = ds.Tables("Feedback").Rows(inc).Item(2)

            If ds.Tables("Feedback").Rows.Count = 1 Then    'if there's is only 1 record
                btnstart.Enabled = False
                btnend.Enabled = False
                btnprevious.Enabled = False
                btnnext.Enabled = False
            End If

            btnend.Enabled = False
            btnnext.Enabled = False
        ElseIf inc = MaxRows - 1 Then
            btnend.Enabled = False
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If txtResponse.Text = "" Or txtResponse.Text = "(NO RESPONSE YET)" Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Please fill in the response before submitting!", vbExclamation & vbOKOnly, "Empty Field")

        Else
            My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
            MsgBox("The response to the feedback has been sent!", vbOKOnly, "Response Sent")
            Dim cb As New OleDb.OleDbCommandBuilder(da)

            ds.Tables("Feedback").Rows(inc).Item(2) = txtResponse.Text
            da.Update(ds, "Feedback")
        End If
    End Sub

    Private Sub btnSubmit_VisibleChanged(sender As Object, e As EventArgs) Handles btnSubmit.VisibleChanged
        Me.CenterToScreen()
        txtResponse.Select()
    End Sub

    Private Sub frmSchedulerResponseFCMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblName.Text = frmLoginPage.DisplayName
        dbProvider = "PROVIDER = Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        sql = "SELECT * FROM Feedback"
        da = New OleDb.OleDbDataAdapter(sql, connection)
        da.Fill(ds, "Feedback")
        MaxRows = ds.Tables("Feedback").Rows.Count
        inc = -1

        tables = ds.Tables

        'avoid users from entering data when the textbox is empty
        txtResponse.Enabled = False

        'avoid users from selecting previous and next button when the information is not yet displayed
        btnprevious.Enabled = False
        btnnext.Enabled = False

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmSchedulerResponseMenu.Show()
    End Sub
End Class