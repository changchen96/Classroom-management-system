﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLecturerCAvailability
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLecturerCAvailability))
        Me.lblClassroomName = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.cbDay = New System.Windows.Forms.ComboBox()
        Me.DGVAvailability = New System.Windows.Forms.DataGridView()
        Me.gbLecturerCAvailability = New System.Windows.Forms.GroupBox()
        Me.cbClassroomName = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblViewCAvailablity = New System.Windows.Forms.Label()
        Me.TCAlogo = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.gbWelcome = New System.Windows.Forms.GroupBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbStudentMM = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.btnCAvailability = New System.Windows.Forms.Button()
        Me.btnRequest = New System.Windows.Forms.Button()
        Me.btnVT = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.DGVAvailability, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLecturerCAvailability.SuspendLayout()
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.gbWelcome.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbStudentMM.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClassroomName
        '
        Me.lblClassroomName.AutoSize = True
        Me.lblClassroomName.BackColor = System.Drawing.Color.Transparent
        Me.lblClassroomName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassroomName.Location = New System.Drawing.Point(38, 28)
        Me.lblClassroomName.Name = "lblClassroomName"
        Me.lblClassroomName.Size = New System.Drawing.Size(177, 28)
        Me.lblClassroomName.TabIndex = 21
        Me.lblClassroomName.Text = "Classroom Name: "
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.BackColor = System.Drawing.Color.Transparent
        Me.lblDay.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(158, 68)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(57, 28)
        Me.lblDay.TabIndex = 23
        Me.lblDay.Text = "Day: "
        '
        'cbDay
        '
        Me.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDay.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDay.FormattingEnabled = True
        Me.cbDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.cbDay.Location = New System.Drawing.Point(221, 65)
        Me.cbDay.Name = "cbDay"
        Me.cbDay.Size = New System.Drawing.Size(213, 36)
        Me.cbDay.TabIndex = 24
        '
        'DGVAvailability
        '
        Me.DGVAvailability.AllowUserToAddRows = False
        Me.DGVAvailability.AllowUserToDeleteRows = False
        Me.DGVAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAvailability.Location = New System.Drawing.Point(6, 109)
        Me.DGVAvailability.Name = "DGVAvailability"
        Me.DGVAvailability.RowTemplate.Height = 28
        Me.DGVAvailability.Size = New System.Drawing.Size(675, 332)
        Me.DGVAvailability.TabIndex = 25
        '
        'gbLecturerCAvailability
        '
        Me.gbLecturerCAvailability.BackColor = System.Drawing.Color.Transparent
        Me.gbLecturerCAvailability.Controls.Add(Me.cbClassroomName)
        Me.gbLecturerCAvailability.Controls.Add(Me.cbDay)
        Me.gbLecturerCAvailability.Controls.Add(Me.btnSubmit)
        Me.gbLecturerCAvailability.Controls.Add(Me.lblDay)
        Me.gbLecturerCAvailability.Controls.Add(Me.DGVAvailability)
        Me.gbLecturerCAvailability.Controls.Add(Me.lblClassroomName)
        Me.gbLecturerCAvailability.Location = New System.Drawing.Point(17, 162)
        Me.gbLecturerCAvailability.Name = "gbLecturerCAvailability"
        Me.gbLecturerCAvailability.Size = New System.Drawing.Size(687, 448)
        Me.gbLecturerCAvailability.TabIndex = 26
        Me.gbLecturerCAvailability.TabStop = False
        '
        'cbClassroomName
        '
        Me.cbClassroomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassroomName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClassroomName.FormattingEnabled = True
        Me.cbClassroomName.IntegralHeight = False
        Me.cbClassroomName.Location = New System.Drawing.Point(221, 23)
        Me.cbClassroomName.Name = "cbClassroomName"
        Me.cbClassroomName.Size = New System.Drawing.Size(213, 36)
        Me.cbClassroomName.TabIndex = 28
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.PowderBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(440, 23)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(147, 78)
        Me.btnSubmit.TabIndex = 27
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(12, 101)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(692, 58)
        Me.lblDesc.TabIndex = 27
        Me.lblDesc.Text = "In order to view the availability of the classrooms, please fill in the form belo" & _
    "w can click on the submit button."
        '
        'lblViewCAvailablity
        '
        Me.lblViewCAvailablity.AutoSize = True
        Me.lblViewCAvailablity.BackColor = System.Drawing.Color.Transparent
        Me.lblViewCAvailablity.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewCAvailablity.Location = New System.Drawing.Point(12, 52)
        Me.lblViewCAvailablity.Name = "lblViewCAvailablity"
        Me.lblViewCAvailablity.Size = New System.Drawing.Size(259, 28)
        Me.lblViewCAvailablity.TabIndex = 28
        Me.lblViewCAvailablity.Text = "View Classroom Availability"
        '
        'TCAlogo
        '
        Me.TCAlogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TCAlogo.Image = CType(resources.GetObject("TCAlogo.Image"), System.Drawing.Image)
        Me.TCAlogo.Location = New System.Drawing.Point(12, 12)
        Me.TCAlogo.Name = "TCAlogo"
        Me.TCAlogo.Size = New System.Drawing.Size(80, 80)
        Me.TCAlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TCAlogo.TabIndex = 37
        Me.TCAlogo.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(98, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(242, 80)
        Me.Panel3.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 80)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Classroom Availability Menu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 95)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(101, 28)
        Me.lblWelcome.TabIndex = 32
        Me.lblWelcome.Text = "Welcome,"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(6, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(69, 28)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Label1"
        '
        'gbWelcome
        '
        Me.gbWelcome.BackColor = System.Drawing.Color.DarkCyan
        Me.gbWelcome.Controls.Add(Me.lblName)
        Me.gbWelcome.Location = New System.Drawing.Point(12, 120)
        Me.gbWelcome.Name = "gbWelcome"
        Me.gbWelcome.Size = New System.Drawing.Size(202, 51)
        Me.gbWelcome.TabIndex = 33
        Me.gbWelcome.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.PowderBlue
        Me.btnLogout.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(220, 120)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(118, 51)
        Me.btnLogout.TabIndex = 31
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.gbStudentMM)
        Me.Panel1.Location = New System.Drawing.Point(12, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 458)
        Me.Panel1.TabIndex = 34
        '
        'gbStudentMM
        '
        Me.gbStudentMM.BackColor = System.Drawing.Color.Transparent
        Me.gbStudentMM.Controls.Add(Me.btnBack)
        Me.gbStudentMM.Controls.Add(Me.btnFeedback)
        Me.gbStudentMM.Controls.Add(Me.btnCAvailability)
        Me.gbStudentMM.Controls.Add(Me.btnRequest)
        Me.gbStudentMM.Controls.Add(Me.btnVT)
        Me.gbStudentMM.Location = New System.Drawing.Point(11, 3)
        Me.gbStudentMM.Name = "gbStudentMM"
        Me.gbStudentMM.Size = New System.Drawing.Size(307, 445)
        Me.gbStudentMM.TabIndex = 6
        Me.gbStudentMM.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.PowderBlue
        Me.btnBack.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(201, 389)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 49)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnFeedback
        '
        Me.btnFeedback.BackColor = System.Drawing.Color.PowderBlue
        Me.btnFeedback.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeedback.Location = New System.Drawing.Point(6, 313)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(295, 70)
        Me.btnFeedback.TabIndex = 17
        Me.btnFeedback.Text = "Feedback and Comments"
        Me.btnFeedback.UseVisualStyleBackColor = False
        '
        'btnCAvailability
        '
        Me.btnCAvailability.BackColor = System.Drawing.Color.PowderBlue
        Me.btnCAvailability.Enabled = False
        Me.btnCAvailability.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCAvailability.Location = New System.Drawing.Point(6, 237)
        Me.btnCAvailability.Name = "btnCAvailability"
        Me.btnCAvailability.Size = New System.Drawing.Size(295, 70)
        Me.btnCAvailability.TabIndex = 16
        Me.btnCAvailability.Text = "Classroom Availability"
        Me.btnCAvailability.UseVisualStyleBackColor = False
        '
        'btnRequest
        '
        Me.btnRequest.BackColor = System.Drawing.Color.PowderBlue
        Me.btnRequest.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequest.Location = New System.Drawing.Point(6, 161)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(295, 70)
        Me.btnRequest.TabIndex = 15
        Me.btnRequest.Text = "Request for Classroom"
        Me.btnRequest.UseVisualStyleBackColor = False
        '
        'btnVT
        '
        Me.btnVT.BackColor = System.Drawing.Color.PowderBlue
        Me.btnVT.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVT.Location = New System.Drawing.Point(6, 85)
        Me.btnVT.Name = "btnVT"
        Me.btnVT.Size = New System.Drawing.Size(295, 70)
        Me.btnVT.TabIndex = 14
        Me.btnVT.Text = "View Timetable"
        Me.btnVT.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.lblViewCAvailablity)
        Me.Panel2.Controls.Add(Me.gbLecturerCAvailability)
        Me.Panel2.Controls.Add(Me.lblDesc)
        Me.Panel2.Location = New System.Drawing.Point(346, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(720, 620)
        Me.Panel2.TabIndex = 35
        '
        'frmLecturerCAvailability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1078, 644)
        Me.Controls.Add(Me.TCAlogo)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.gbWelcome)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1100, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1100, 700)
        Me.Name = "frmLecturerCAvailability"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Academic Timetabling System"
        CType(Me.DGVAvailability, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLecturerCAvailability.ResumeLayout(False)
        Me.gbLecturerCAvailability.PerformLayout()
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.gbWelcome.ResumeLayout(False)
        Me.gbWelcome.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.gbStudentMM.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClassroomName As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents cbDay As System.Windows.Forms.ComboBox
    Friend WithEvents DGVAvailability As System.Windows.Forms.DataGridView
    Friend WithEvents gbLecturerCAvailability As System.Windows.Forms.GroupBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents lblViewCAvailablity As System.Windows.Forms.Label
    Friend WithEvents TCAlogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents gbWelcome As System.Windows.Forms.GroupBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbStudentMM As System.Windows.Forms.GroupBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnFeedback As System.Windows.Forms.Button
    Friend WithEvents btnCAvailability As System.Windows.Forms.Button
    Friend WithEvents btnRequest As System.Windows.Forms.Button
    Friend WithEvents btnVT As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbClassroomName As System.Windows.Forms.ComboBox
End Class
