<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedulerClassroomMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchedulerClassroomMenu))
        Me.TCAlogo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.gbWelcome = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnResponse = New System.Windows.Forms.Button()
        Me.btnTimetable = New System.Windows.Forms.Button()
        Me.btnClassroom = New System.Windows.Forms.Button()
        Me.btnIntake = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClassroomAvailability = New System.Windows.Forms.Button()
        Me.cbClassroomName = New System.Windows.Forms.ComboBox()
        Me.btnVClassroom = New System.Windows.Forms.Button()
        Me.lblClassroomName = New System.Windows.Forms.Label()
        Me.btnSClassroom = New System.Windows.Forms.Button()
        Me.btnMClassroom = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGVClassroom = New System.Windows.Forms.DataGridView()
        Me.btnAClassroom = New System.Windows.Forms.Button()
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.gbWelcome.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVClassroom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCAlogo
        '
        Me.TCAlogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TCAlogo.Image = CType(resources.GetObject("TCAlogo.Image"), System.Drawing.Image)
        Me.TCAlogo.Location = New System.Drawing.Point(12, 12)
        Me.TCAlogo.Name = "TCAlogo"
        Me.TCAlogo.Size = New System.Drawing.Size(80, 80)
        Me.TCAlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TCAlogo.TabIndex = 36
        Me.TCAlogo.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 74)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Scheduler Classroom Menu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(98, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(242, 80)
        Me.Panel3.TabIndex = 35
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 95)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(101, 28)
        Me.lblWelcome.TabIndex = 31
        Me.lblWelcome.Text = "Welcome,"
        '
        'gbWelcome
        '
        Me.gbWelcome.BackColor = System.Drawing.Color.DarkCyan
        Me.gbWelcome.Controls.Add(Me.lblName)
        Me.gbWelcome.Location = New System.Drawing.Point(12, 120)
        Me.gbWelcome.Name = "gbWelcome"
        Me.gbWelcome.Size = New System.Drawing.Size(202, 51)
        Me.gbWelcome.TabIndex = 32
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
        Me.btnLogout.TabIndex = 30
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 498)
        Me.Panel1.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Controls.Add(Me.btnResponse)
        Me.GroupBox1.Controls.Add(Me.btnTimetable)
        Me.GroupBox1.Controls.Add(Me.btnClassroom)
        Me.GroupBox1.Controls.Add(Me.btnIntake)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 476)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.PowderBlue
        Me.btnBack.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(197, 416)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 49)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
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
        Me.btnClassroom.Enabled = False
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.btnClassroomAvailability)
        Me.Panel2.Controls.Add(Me.cbClassroomName)
        Me.Panel2.Controls.Add(Me.btnVClassroom)
        Me.Panel2.Controls.Add(Me.lblClassroomName)
        Me.Panel2.Controls.Add(Me.btnSClassroom)
        Me.Panel2.Controls.Add(Me.btnMClassroom)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.btnAClassroom)
        Me.Panel2.Location = New System.Drawing.Point(346, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(820, 660)
        Me.Panel2.TabIndex = 34
        '
        'btnClassroomAvailability
        '
        Me.btnClassroomAvailability.BackColor = System.Drawing.Color.PowderBlue
        Me.btnClassroomAvailability.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassroomAvailability.Location = New System.Drawing.Point(528, 560)
        Me.btnClassroomAvailability.Name = "btnClassroomAvailability"
        Me.btnClassroomAvailability.Size = New System.Drawing.Size(230, 81)
        Me.btnClassroomAvailability.TabIndex = 36
        Me.btnClassroomAvailability.Text = "View Classroom Availability"
        Me.btnClassroomAvailability.UseVisualStyleBackColor = False
        '
        'cbClassroomName
        '
        Me.cbClassroomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassroomName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClassroomName.FormattingEnabled = True
        Me.cbClassroomName.Location = New System.Drawing.Point(323, 28)
        Me.cbClassroomName.Name = "cbClassroomName"
        Me.cbClassroomName.Size = New System.Drawing.Size(228, 36)
        Me.cbClassroomName.TabIndex = 35
        '
        'btnVClassroom
        '
        Me.btnVClassroom.BackColor = System.Drawing.Color.PowderBlue
        Me.btnVClassroom.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVClassroom.Location = New System.Drawing.Point(372, 560)
        Me.btnVClassroom.Name = "btnVClassroom"
        Me.btnVClassroom.Size = New System.Drawing.Size(150, 81)
        Me.btnVClassroom.TabIndex = 19
        Me.btnVClassroom.Text = "View All Classrooms"
        Me.btnVClassroom.UseVisualStyleBackColor = False
        '
        'lblClassroomName
        '
        Me.lblClassroomName.AutoSize = True
        Me.lblClassroomName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassroomName.Location = New System.Drawing.Point(140, 31)
        Me.lblClassroomName.Name = "lblClassroomName"
        Me.lblClassroomName.Size = New System.Drawing.Size(177, 28)
        Me.lblClassroomName.TabIndex = 16
        Me.lblClassroomName.Text = "Classroom Name: "
        '
        'btnSClassroom
        '
        Me.btnSClassroom.BackColor = System.Drawing.Color.PowderBlue
        Me.btnSClassroom.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSClassroom.Location = New System.Drawing.Point(557, 26)
        Me.btnSClassroom.Name = "btnSClassroom"
        Me.btnSClassroom.Size = New System.Drawing.Size(118, 51)
        Me.btnSClassroom.TabIndex = 13
        Me.btnSClassroom.Text = "Search"
        Me.btnSClassroom.UseVisualStyleBackColor = False
        '
        'btnMClassroom
        '
        Me.btnMClassroom.BackColor = System.Drawing.Color.PowderBlue
        Me.btnMClassroom.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMClassroom.Location = New System.Drawing.Point(216, 560)
        Me.btnMClassroom.Name = "btnMClassroom"
        Me.btnMClassroom.Size = New System.Drawing.Size(150, 81)
        Me.btnMClassroom.TabIndex = 12
        Me.btnMClassroom.Text = "Modify Classroom"
        Me.btnMClassroom.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DGVClassroom)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(814, 471)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'DGVClassroom
        '
        Me.DGVClassroom.AllowUserToAddRows = False
        Me.DGVClassroom.AllowUserToDeleteRows = False
        Me.DGVClassroom.AllowUserToOrderColumns = True
        Me.DGVClassroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClassroom.Location = New System.Drawing.Point(6, 25)
        Me.DGVClassroom.Name = "DGVClassroom"
        Me.DGVClassroom.RowTemplate.Height = 28
        Me.DGVClassroom.Size = New System.Drawing.Size(802, 440)
        Me.DGVClassroom.TabIndex = 16
        '
        'btnAClassroom
        '
        Me.btnAClassroom.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAClassroom.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAClassroom.Location = New System.Drawing.Point(60, 560)
        Me.btnAClassroom.Name = "btnAClassroom"
        Me.btnAClassroom.Size = New System.Drawing.Size(150, 81)
        Me.btnAClassroom.TabIndex = 11
        Me.btnAClassroom.Text = "Add Classroom"
        Me.btnAClassroom.UseVisualStyleBackColor = False
        '
        'frmSchedulerClassroomMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1178, 684)
        Me.Controls.Add(Me.TCAlogo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.gbWelcome)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1200, 740)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1200, 740)
        Me.Name = "frmSchedulerClassroomMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Academic Timetabling System"
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.gbWelcome.ResumeLayout(False)
        Me.gbWelcome.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGVClassroom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TCAlogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents gbWelcome As System.Windows.Forms.GroupBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnResponse As System.Windows.Forms.Button
    Friend WithEvents btnTimetable As System.Windows.Forms.Button
    Friend WithEvents btnClassroom As System.Windows.Forms.Button
    Friend WithEvents btnIntake As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblClassroomName As System.Windows.Forms.Label
    Friend WithEvents btnSClassroom As System.Windows.Forms.Button
    Friend WithEvents btnMClassroom As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVClassroom As System.Windows.Forms.DataGridView
    Friend WithEvents btnAClassroom As System.Windows.Forms.Button
    Friend WithEvents btnVClassroom As System.Windows.Forms.Button
    Friend WithEvents cbClassroomName As System.Windows.Forms.ComboBox
    Friend WithEvents btnClassroomAvailability As System.Windows.Forms.Button
End Class
