<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLecturerRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLecturerRequest))
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtLecturerID = New System.Windows.Forms.TextBox()
        Me.cbTime = New System.Windows.Forms.ComboBox()
        Me.cbDay = New System.Windows.Forms.ComboBox()
        Me.cbClassType = New System.Windows.Forms.ComboBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblClassSize = New System.Windows.Forms.Label()
        Me.gbRequest = New System.Windows.Forms.GroupBox()
        Me.lblLecturerID = New System.Windows.Forms.Label()
        Me.lblRequest = New System.Windows.Forms.Label()
        Me.lblDecs = New System.Windows.Forms.Label()
        Me.TCAlogo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.gbWelcome = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbStudentMM = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.btnCAvailability = New System.Windows.Forms.Button()
        Me.btnRequest = New System.Windows.Forms.Button()
        Me.btnVT = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbRequest.SuspendLayout()
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.gbWelcome.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbStudentMM.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.PowderBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(586, 519)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(120, 49)
        Me.btnSubmit.TabIndex = 19
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(167, 141)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(484, 169)
        Me.txtDescription.TabIndex = 11
        '
        'txtLecturerID
        '
        Me.txtLecturerID.Enabled = False
        Me.txtLecturerID.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLecturerID.Location = New System.Drawing.Point(167, 59)
        Me.txtLecturerID.Name = "txtLecturerID"
        Me.txtLecturerID.Size = New System.Drawing.Size(182, 34)
        Me.txtLecturerID.TabIndex = 10
        '
        'cbTime
        '
        Me.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTime.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTime.FormattingEnabled = True
        Me.cbTime.Items.AddRange(New Object() {"0830 - 1030", "1045 - 1245", "1345 - 1545", "1600 - 1800", "1800 - 2000"})
        Me.cbTime.Location = New System.Drawing.Point(469, 99)
        Me.cbTime.Name = "cbTime"
        Me.cbTime.Size = New System.Drawing.Size(182, 36)
        Me.cbTime.TabIndex = 8
        '
        'cbDay
        '
        Me.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDay.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDay.FormattingEnabled = True
        Me.cbDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.cbDay.Location = New System.Drawing.Point(469, 57)
        Me.cbDay.Name = "cbDay"
        Me.cbDay.Size = New System.Drawing.Size(182, 36)
        Me.cbDay.TabIndex = 7
        '
        'cbClassType
        '
        Me.cbClassType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassType.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClassType.FormattingEnabled = True
        Me.cbClassType.Items.AddRange(New Object() {"Basic Classroom", "Laboratory", "Auditorium"})
        Me.cbClassType.Location = New System.Drawing.Point(167, 99)
        Me.cbClassType.Name = "cbClassType"
        Me.cbClassType.Size = New System.Drawing.Size(182, 36)
        Me.cbClassType.TabIndex = 6
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(395, 102)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(68, 28)
        Me.lblTime.TabIndex = 4
        Me.lblTime.Text = "Time: "
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(35, 144)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(126, 28)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Description: "
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(406, 60)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(57, 28)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "Day: "
        '
        'lblClassSize
        '
        Me.lblClassSize.AutoSize = True
        Me.lblClassSize.Location = New System.Drawing.Point(45, 102)
        Me.lblClassSize.Name = "lblClassSize"
        Me.lblClassSize.Size = New System.Drawing.Size(116, 28)
        Me.lblClassSize.TabIndex = 1
        Me.lblClassSize.Text = "Class Type: "
        '
        'gbRequest
        '
        Me.gbRequest.BackColor = System.Drawing.Color.Transparent
        Me.gbRequest.Controls.Add(Me.txtDescription)
        Me.gbRequest.Controls.Add(Me.txtLecturerID)
        Me.gbRequest.Controls.Add(Me.cbTime)
        Me.gbRequest.Controls.Add(Me.cbDay)
        Me.gbRequest.Controls.Add(Me.cbClassType)
        Me.gbRequest.Controls.Add(Me.lblTime)
        Me.gbRequest.Controls.Add(Me.lblDescription)
        Me.gbRequest.Controls.Add(Me.lblDay)
        Me.gbRequest.Controls.Add(Me.lblClassSize)
        Me.gbRequest.Controls.Add(Me.lblLecturerID)
        Me.gbRequest.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRequest.Location = New System.Drawing.Point(11, 162)
        Me.gbRequest.Name = "gbRequest"
        Me.gbRequest.Size = New System.Drawing.Size(695, 334)
        Me.gbRequest.TabIndex = 18
        Me.gbRequest.TabStop = False
        '
        'lblLecturerID
        '
        Me.lblLecturerID.AutoSize = True
        Me.lblLecturerID.Location = New System.Drawing.Point(38, 62)
        Me.lblLecturerID.Name = "lblLecturerID"
        Me.lblLecturerID.Size = New System.Drawing.Size(123, 28)
        Me.lblLecturerID.TabIndex = 0
        Me.lblLecturerID.Text = "Lecturer ID: "
        '
        'lblRequest
        '
        Me.lblRequest.AutoSize = True
        Me.lblRequest.BackColor = System.Drawing.Color.Transparent
        Me.lblRequest.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequest.Location = New System.Drawing.Point(6, 52)
        Me.lblRequest.Name = "lblRequest"
        Me.lblRequest.Size = New System.Drawing.Size(180, 28)
        Me.lblRequest.TabIndex = 17
        Me.lblRequest.Text = "REQUEST DETAILS:"
        '
        'lblDecs
        '
        Me.lblDecs.BackColor = System.Drawing.Color.Transparent
        Me.lblDecs.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDecs.Location = New System.Drawing.Point(6, 91)
        Me.lblDecs.Name = "lblDecs"
        Me.lblDecs.Size = New System.Drawing.Size(700, 68)
        Me.lblDecs.TabIndex = 20
        Me.lblDecs.Text = "Please fill in every details into the form given below. Once confirmed, click on " & _
    "the submit button to request for a classroom."
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
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 80)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Classroom Request Menu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnRequest.Enabled = False
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
        Me.Panel2.Controls.Add(Me.btnSubmit)
        Me.Panel2.Controls.Add(Me.lblDecs)
        Me.Panel2.Controls.Add(Me.gbRequest)
        Me.Panel2.Controls.Add(Me.lblRequest)
        Me.Panel2.Location = New System.Drawing.Point(346, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(720, 620)
        Me.Panel2.TabIndex = 35
        '
        'frmLecturerRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1078, 644)
        Me.Controls.Add(Me.TCAlogo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.gbWelcome)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1100, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1100, 700)
        Me.Name = "frmLecturerRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Academic Timetabling System"
        Me.gbRequest.ResumeLayout(False)
        Me.gbRequest.PerformLayout()
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
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtLecturerID As System.Windows.Forms.TextBox
    Friend WithEvents cbTime As System.Windows.Forms.ComboBox
    Friend WithEvents cbDay As System.Windows.Forms.ComboBox
    Friend WithEvents cbClassType As System.Windows.Forms.ComboBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblClassSize As System.Windows.Forms.Label
    Friend WithEvents gbRequest As System.Windows.Forms.GroupBox
    Friend WithEvents lblLecturerID As System.Windows.Forms.Label
    Friend WithEvents lblRequest As System.Windows.Forms.Label
    Friend WithEvents lblDecs As System.Windows.Forms.Label
    Friend WithEvents TCAlogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents gbWelcome As System.Windows.Forms.GroupBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbStudentMM As System.Windows.Forms.GroupBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnFeedback As System.Windows.Forms.Button
    Friend WithEvents btnCAvailability As System.Windows.Forms.Button
    Friend WithEvents btnRequest As System.Windows.Forms.Button
    Friend WithEvents btnVT As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
