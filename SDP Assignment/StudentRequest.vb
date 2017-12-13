Imports System.Text.RegularExpressions
Public Class frmStudentRequest
    Dim connection As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim inc As Integer
    Dim MaxRows As Integer

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        If cbClassType.SelectedIndex = -1 Or cbDay.SelectedIndex = -1 Or cbTime.SelectedIndex = -1 Or txtDescription.Text = "" Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Please make sure that all of the fields are filled in.", vbExclamation & vbOKOnly, "Empty Field(s)")
        Else
            MsgBox("The request has been successfully delivered for verification.", vbOKOnly, "Request Sent")
            If inc <> 0 Then
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                Dim dsNewRow As DataRow
                dsNewRow = ds.Tables("FacilityRequest").NewRow()
                dsNewRow.Item("User_ID") = txtStudentID.Text
                dsNewRow.Item("ClassType") = cbClassType.Text
                dsNewRow.Item("Day1") = cbDay.Text
                dsNewRow.Item("Time1") = cbTime.Text
                dsNewRow.Item("Description") = txtDescription.Text
                dsNewRow.Item("Response") = "(NO RESPONSE YET)"

                ds.Tables("FacilityRequest").Rows.Add(dsNewRow)
                da.Update(ds, "FacilityRequest")

                cbClassType.SelectedIndex = -1
                cbDay.SelectedIndex = -1
                cbTime.SelectedIndex = -1
                txtDescription.Clear()
                cbClassType.Select()
            End If
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmStudentMM.Show() 'when users click on logout button, they will be redirected back to the MAIN MENU first before actually logging out
            frmStudentMM.Close()    '(continue) this prevents error when displaying "DisplayName" label (lblName.Text)
            frmLoginPage.Show()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmStudentMM.Show()
    End Sub

    Private Sub btnVT_Click(sender As Object, e As EventArgs) Handles btnVT.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmStudentVT.Show()
    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmStudentFeedback.Show()
    End Sub

    Private Sub frmStudentRequest_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        txtStudentID.Text = frmLoginPage.StudentID   'the student ID will be automatically filled in
        cbClassType.SelectedIndex = -1
        cbDay.SelectedIndex = -1
        cbTime.SelectedIndex = -1
        txtDescription.Clear()
        cbClassType.Select()
    End Sub

    Private Sub frmStudentRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblName.Text = frmLoginPage.DisplayName
        dbProvider = "Provider = Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        sql = "SELECT * FROM FacilityRequest"
        da = New OleDb.OleDbDataAdapter(sql, connection)
        da.Fill(ds, "FacilityRequest")
        MaxRows = ds.Tables("FacilityRequest").Rows.Count
        inc = -1
    End Sub
End Class