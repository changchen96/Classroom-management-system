Imports System.Text.RegularExpressions
Public Class frmLecturerFeedback
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
        If txtFeedback.Text = "" Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Field is empty! Please make sure to fill in the feedback form before submitting.", vbExclamation & vbOKOnly, "Empty Field")
        Else
            MsgBox("Thank you for submitting your feedback.", vbOKOnly, "Successful Feedback")
            If inc <> 0 Then
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                Dim dsNewRow As DataRow

                dsNewRow = ds.Tables("Feedback").NewRow()

                dsNewRow.Item("Feedback_Comments") = txtFeedback.Text   'can also be dsNewRow.Item(1) = txtFeedback.Text
                dsNewRow.Item("Response") = "(NO RESPONSE YET)"

                ds.Tables("Feedback").Rows.Add(dsNewRow)
                da.Update(ds, "Feedback")

                txtFeedback.Clear()
                txtFeedback.Select()
            End If
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmLecturerMM.Show() 'when users click on logout button, they will be redirected back to the MAIN MENU first before actually logging out
            frmLecturerMM.Close()    '(continue) this prevents error when displaying "DisplayName" label (lblName.Text)
            frmLoginPage.Show()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmLecturerMM.Show()
    End Sub

    Private Sub btnVT_Click(sender As Object, e As EventArgs) Handles btnVT.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmLecturerVT.Show()
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmLecturerRequest.Show()
    End Sub

    Private Sub btnCAvailability_Click(sender As Object, e As EventArgs) Handles btnCAvailability.Click
        My.Computer.Audio.Play(My.Resources.Button_Click, AudioPlayMode.Background)
        Me.Close()
        frmLecturerCAvailability.Show()
    End Sub

    Private Sub frmLecturerFeedback_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CenterToScreen()
        txtFeedback.Clear()
        txtFeedback.Select()
    End Sub

    Private Sub frmLecturerFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblName.Text = frmLoginPage.DisplayName
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = SDP Database Latest.accdb"

        connection.ConnectionString = dbProvider & dbSource
        connection.Open()

        sql = "SELECT * FROM Feedback"
        da = New OleDb.OleDbDataAdapter(sql, connection)
        da.Fill(ds, "Feedback")
        MaxRows = ds.Tables("Feedback").Rows.Count
        inc = -1
    End Sub
End Class