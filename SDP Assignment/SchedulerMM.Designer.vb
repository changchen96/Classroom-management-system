<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedulerMM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchedulerMM))
        Me.gbStudentMM = New System.Windows.Forms.GroupBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.btnResponse = New System.Windows.Forms.Button()
        Me.btnTimetable = New System.Windows.Forms.Button()
        Me.btnClassroom = New System.Windows.Forms.Button()
        Me.btnIntake = New System.Windows.Forms.Button()
        Me.TCAlogo = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbWelcome = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbStudentMM.SuspendLayout()
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.gbWelcome.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbStudentMM
        '
        Me.gbStudentMM.BackColor = System.Drawing.Color.Transparent
        Me.gbStudentMM.Controls.Add(Me.lblDesc)
        Me.gbStudentMM.Controls.Add(Me.btnResponse)
        Me.gbStudentMM.Controls.Add(Me.btnTimetable)
        Me.gbStudentMM.Controls.Add(Me.btnClassroom)
        Me.gbStudentMM.Controls.Add(Me.btnIntake)
        Me.gbStudentMM.Location = New System.Drawing.Point(11, 3)
        Me.gbStudentMM.Name = "gbStudentMM"
        Me.gbStudentMM.Size = New System.Drawing.Size(304, 476)
        Me.gbStudentMM.TabIndex = 15
        Me.gbStudentMM.TabStop = False
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(6, 22)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(292, 87)
        Me.lblDesc.TabIndex = 14
        Me.lblDesc.Text = "Welcome to the Scheduler Main Menu. Please select the option you wish to add, mod" & _
    "ify or delete."
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnResponse
        '
        Me.btnResponse.BackColor = System.Drawing.Color.PowderBlue
        Me.btnResponse.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResponse.Location = New System.Drawing.Point(6, 340)
        Me.btnResponse.Name = "btnResponse"
        Me.btnResponse.Size = New System.Drawing.Size(292, 70)
        Me.btnResponse.TabIndex = 11
        Me.btnResponse.Text = "Response"
        Me.btnResponse.UseVisualStyleBackColor = False
        '
        'btnTimetable
        '
        Me.btnTimetable.BackColor = System.Drawing.Color.PowderBlue
        Me.btnTimetable.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimetable.Location = New System.Drawing.Point(6, 264)
        Me.btnTimetable.Name = "btnTimetable"
        Me.btnTimetable.Size = New System.Drawing.Size(292, 70)
        Me.btnTimetable.TabIndex = 13
        Me.btnTimetable.Text = "Timetable"
        Me.btnTimetable.UseVisualStyleBackColor = False
        '
        'btnClassroom
        '
        Me.btnClassroom.BackColor = System.Drawing.Color.PowderBlue
        Me.btnClassroom.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassroom.Location = New System.Drawing.Point(6, 188)
        Me.btnClassroom.Name = "btnClassroom"
        Me.btnClassroom.Size = New System.Drawing.Size(292, 70)
        Me.btnClassroom.TabIndex = 12
        Me.btnClassroom.Text = "Classroom"
        Me.btnClassroom.UseVisualStyleBackColor = False
        '
        'btnIntake
        '
        Me.btnIntake.BackColor = System.Drawing.Color.PowderBlue
        Me.btnIntake.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIntake.Location = New System.Drawing.Point(6, 112)
        Me.btnIntake.Name = "btnIntake"
        Me.btnIntake.Size = New System.Drawing.Size(292, 70)
        Me.btnIntake.TabIndex = 11
        Me.btnIntake.Text = "Intake"
        Me.btnIntake.UseVisualStyleBackColor = False
        '
        'TCAlogo
        '
        Me.TCAlogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TCAlogo.Image = CType(resources.GetObject("TCAlogo.Image"), System.Drawing.Image)
        Me.TCAlogo.Location = New System.Drawing.Point(12, 12)
        Me.TCAlogo.Name = "TCAlogo"
        Me.TCAlogo.Size = New System.Drawing.Size(80, 80)
        Me.TCAlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TCAlogo.TabIndex = 22
        Me.TCAlogo.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(98, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(242, 80)
        Me.Panel3.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 80)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Scheduler Main Menu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbWelcome
        '
        Me.gbWelcome.BackColor = System.Drawing.Color.DarkCyan
        Me.gbWelcome.Controls.Add(Me.lblName)
        Me.gbWelcome.Location = New System.Drawing.Point(12, 120)
        Me.gbWelcome.Name = "gbWelcome"
        Me.gbWelcome.Size = New System.Drawing.Size(202, 51)
        Me.gbWelcome.TabIndex = 18
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
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 95)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(101, 28)
        Me.lblWelcome.TabIndex = 17
        Me.lblWelcome.Text = "Welcome,"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.PowderBlue
        Me.btnLogout.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(220, 120)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(118, 51)
        Me.btnLogout.TabIndex = 16
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.gbStudentMM)
        Me.Panel1.Location = New System.Drawing.Point(12, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 498)
        Me.Panel1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Location = New System.Drawing.Point(346, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(820, 660)
        Me.Panel2.TabIndex = 20
        '
        'frmSchedulerMM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1178, 684)
        Me.Controls.Add(Me.TCAlogo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.gbWelcome)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1200, 740)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1200, 740)
        Me.Name = "frmSchedulerMM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Academic Timetabling System"
        Me.gbStudentMM.ResumeLayout(False)
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.gbWelcome.ResumeLayout(False)
        Me.gbWelcome.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbStudentMM As System.Windows.Forms.GroupBox
    Friend WithEvents btnResponse As System.Windows.Forms.Button
    Friend WithEvents btnTimetable As System.Windows.Forms.Button
    Friend WithEvents btnClassroom As System.Windows.Forms.Button
    Friend WithEvents btnIntake As System.Windows.Forms.Button
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents TCAlogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbWelcome As System.Windows.Forms.GroupBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
