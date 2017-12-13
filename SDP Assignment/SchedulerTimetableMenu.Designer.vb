<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedulerTimetableMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchedulerTimetableMenu))
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
        Me.cbClassPurpose = New System.Windows.Forms.ComboBox()
        Me.lblClassPurpose = New System.Windows.Forms.Label()
        Me.btnSearch3 = New System.Windows.Forms.Button()
        Me.btnMExtraClass = New System.Windows.Forms.Button()
        Me.btnGExtraClass = New System.Windows.Forms.Button()
        Me.cbLecturerName = New System.Windows.Forms.ComboBox()
        Me.cbIntakeCode = New System.Windows.Forms.ComboBox()
        Me.lblLecturerName = New System.Windows.Forms.Label()
        Me.btnSearch2 = New System.Windows.Forms.Button()
        Me.lblIntakeCode = New System.Windows.Forms.Label()
        Me.btnSearch1 = New System.Windows.Forms.Button()
        Me.DGVTimetable = New System.Windows.Forms.DataGridView()
        Me.btnMTimetable = New System.Windows.Forms.Button()
        Me.btnGTimetable = New System.Windows.Forms.Button()
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.gbWelcome.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVTimetable, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TCAlogo.TabIndex = 43
        Me.TCAlogo.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 80)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Scheduler Timetable Menu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(98, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(242, 80)
        Me.Panel3.TabIndex = 42
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 95)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(101, 28)
        Me.lblWelcome.TabIndex = 38
        Me.lblWelcome.Text = "Welcome,"
        '
        'gbWelcome
        '
        Me.gbWelcome.BackColor = System.Drawing.Color.DarkCyan
        Me.gbWelcome.Controls.Add(Me.lblName)
        Me.gbWelcome.Location = New System.Drawing.Point(12, 120)
        Me.gbWelcome.Name = "gbWelcome"
        Me.gbWelcome.Size = New System.Drawing.Size(202, 51)
        Me.gbWelcome.TabIndex = 39
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
        Me.btnLogout.TabIndex = 37
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 558)
        Me.Panel1.TabIndex = 40
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
        Me.btnTimetable.Enabled = False
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.cbClassPurpose)
        Me.Panel2.Controls.Add(Me.lblClassPurpose)
        Me.Panel2.Controls.Add(Me.btnSearch3)
        Me.Panel2.Controls.Add(Me.btnMExtraClass)
        Me.Panel2.Controls.Add(Me.btnGExtraClass)
        Me.Panel2.Controls.Add(Me.cbLecturerName)
        Me.Panel2.Controls.Add(Me.cbIntakeCode)
        Me.Panel2.Controls.Add(Me.lblLecturerName)
        Me.Panel2.Controls.Add(Me.btnSearch2)
        Me.Panel2.Controls.Add(Me.lblIntakeCode)
        Me.Panel2.Controls.Add(Me.btnSearch1)
        Me.Panel2.Controls.Add(Me.DGVTimetable)
        Me.Panel2.Controls.Add(Me.btnMTimetable)
        Me.Panel2.Controls.Add(Me.btnGTimetable)
        Me.Panel2.Location = New System.Drawing.Point(346, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(870, 720)
        Me.Panel2.TabIndex = 41
        '
        'cbClassPurpose
        '
        Me.cbClassPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassPurpose.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClassPurpose.FormattingEnabled = True
        Me.cbClassPurpose.Location = New System.Drawing.Point(315, 123)
        Me.cbClassPurpose.Name = "cbClassPurpose"
        Me.cbClassPurpose.Size = New System.Drawing.Size(305, 36)
        Me.cbClassPurpose.TabIndex = 40
        '
        'lblClassPurpose
        '
        Me.lblClassPurpose.AutoSize = True
        Me.lblClassPurpose.BackColor = System.Drawing.Color.Transparent
        Me.lblClassPurpose.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassPurpose.Location = New System.Drawing.Point(13, 126)
        Me.lblClassPurpose.Name = "lblClassPurpose"
        Me.lblClassPurpose.Size = New System.Drawing.Size(284, 28)
        Me.lblClassPurpose.TabIndex = 38
        Me.lblClassPurpose.Text = "Extra Class Name or Purpose: "
        '
        'btnSearch3
        '
        Me.btnSearch3.BackColor = System.Drawing.Color.PowderBlue
        Me.btnSearch3.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch3.Location = New System.Drawing.Point(642, 123)
        Me.btnSearch3.Name = "btnSearch3"
        Me.btnSearch3.Size = New System.Drawing.Size(120, 50)
        Me.btnSearch3.TabIndex = 39
        Me.btnSearch3.Text = "SEARCH"
        Me.btnSearch3.UseVisualStyleBackColor = False
        '
        'btnMExtraClass
        '
        Me.btnMExtraClass.BackColor = System.Drawing.Color.PowderBlue
        Me.btnMExtraClass.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMExtraClass.Location = New System.Drawing.Point(642, 590)
        Me.btnMExtraClass.Name = "btnMExtraClass"
        Me.btnMExtraClass.Size = New System.Drawing.Size(200, 70)
        Me.btnMExtraClass.TabIndex = 37
        Me.btnMExtraClass.Text = "Modify Extra Class"
        Me.btnMExtraClass.UseVisualStyleBackColor = False
        '
        'btnGExtraClass
        '
        Me.btnGExtraClass.BackColor = System.Drawing.Color.PowderBlue
        Me.btnGExtraClass.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGExtraClass.Location = New System.Drawing.Point(436, 590)
        Me.btnGExtraClass.Name = "btnGExtraClass"
        Me.btnGExtraClass.Size = New System.Drawing.Size(200, 70)
        Me.btnGExtraClass.TabIndex = 36
        Me.btnGExtraClass.Text = "Generate Extra Class"
        Me.btnGExtraClass.UseVisualStyleBackColor = False
        '
        'cbLecturerName
        '
        Me.cbLecturerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLecturerName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLecturerName.FormattingEnabled = True
        Me.cbLecturerName.Location = New System.Drawing.Point(315, 66)
        Me.cbLecturerName.Name = "cbLecturerName"
        Me.cbLecturerName.Size = New System.Drawing.Size(305, 36)
        Me.cbLecturerName.TabIndex = 35
        '
        'cbIntakeCode
        '
        Me.cbIntakeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIntakeCode.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIntakeCode.FormattingEnabled = True
        Me.cbIntakeCode.Location = New System.Drawing.Point(315, 10)
        Me.cbIntakeCode.Name = "cbIntakeCode"
        Me.cbIntakeCode.Size = New System.Drawing.Size(305, 36)
        Me.cbIntakeCode.TabIndex = 34
        '
        'lblLecturerName
        '
        Me.lblLecturerName.AutoSize = True
        Me.lblLecturerName.BackColor = System.Drawing.Color.Transparent
        Me.lblLecturerName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLecturerName.Location = New System.Drawing.Point(140, 69)
        Me.lblLecturerName.Name = "lblLecturerName"
        Me.lblLecturerName.Size = New System.Drawing.Size(157, 28)
        Me.lblLecturerName.TabIndex = 31
        Me.lblLecturerName.Text = "Lecturer Name: "
        '
        'btnSearch2
        '
        Me.btnSearch2.BackColor = System.Drawing.Color.PowderBlue
        Me.btnSearch2.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch2.Location = New System.Drawing.Point(642, 66)
        Me.btnSearch2.Name = "btnSearch2"
        Me.btnSearch2.Size = New System.Drawing.Size(120, 50)
        Me.btnSearch2.TabIndex = 33
        Me.btnSearch2.Text = "SEARCH"
        Me.btnSearch2.UseVisualStyleBackColor = False
        '
        'lblIntakeCode
        '
        Me.lblIntakeCode.AutoSize = True
        Me.lblIntakeCode.BackColor = System.Drawing.Color.Transparent
        Me.lblIntakeCode.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeCode.Location = New System.Drawing.Point(164, 13)
        Me.lblIntakeCode.Name = "lblIntakeCode"
        Me.lblIntakeCode.Size = New System.Drawing.Size(133, 28)
        Me.lblIntakeCode.TabIndex = 28
        Me.lblIntakeCode.Text = "Intake Code: "
        '
        'btnSearch1
        '
        Me.btnSearch1.BackColor = System.Drawing.Color.PowderBlue
        Me.btnSearch1.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch1.Location = New System.Drawing.Point(642, 10)
        Me.btnSearch1.Name = "btnSearch1"
        Me.btnSearch1.Size = New System.Drawing.Size(120, 50)
        Me.btnSearch1.TabIndex = 30
        Me.btnSearch1.Text = "SEARCH"
        Me.btnSearch1.UseVisualStyleBackColor = False
        '
        'DGVTimetable
        '
        Me.DGVTimetable.AllowUserToAddRows = False
        Me.DGVTimetable.AllowUserToDeleteRows = False
        Me.DGVTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTimetable.Location = New System.Drawing.Point(3, 179)
        Me.DGVTimetable.Name = "DGVTimetable"
        Me.DGVTimetable.RowTemplate.Height = 28
        Me.DGVTimetable.Size = New System.Drawing.Size(864, 405)
        Me.DGVTimetable.TabIndex = 21
        '
        'btnMTimetable
        '
        Me.btnMTimetable.BackColor = System.Drawing.Color.PowderBlue
        Me.btnMTimetable.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMTimetable.Location = New System.Drawing.Point(230, 590)
        Me.btnMTimetable.Name = "btnMTimetable"
        Me.btnMTimetable.Size = New System.Drawing.Size(200, 70)
        Me.btnMTimetable.TabIndex = 12
        Me.btnMTimetable.Text = "Modify Timetable"
        Me.btnMTimetable.UseVisualStyleBackColor = False
        '
        'btnGTimetable
        '
        Me.btnGTimetable.BackColor = System.Drawing.Color.PowderBlue
        Me.btnGTimetable.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGTimetable.Location = New System.Drawing.Point(24, 590)
        Me.btnGTimetable.Name = "btnGTimetable"
        Me.btnGTimetable.Size = New System.Drawing.Size(200, 70)
        Me.btnGTimetable.TabIndex = 11
        Me.btnGTimetable.Text = "Generate Timetable"
        Me.btnGTimetable.UseVisualStyleBackColor = False
        '
        'frmSchedulerTimetableMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1228, 684)
        Me.Controls.Add(Me.TCAlogo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.gbWelcome)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1250, 740)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1250, 740)
        Me.Name = "frmSchedulerTimetableMenu"
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
        CType(Me.DGVTimetable, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnMTimetable As System.Windows.Forms.Button
    Friend WithEvents btnGTimetable As System.Windows.Forms.Button
    Friend WithEvents DGVTimetable As System.Windows.Forms.DataGridView
    Friend WithEvents lblLecturerName As System.Windows.Forms.Label
    Friend WithEvents btnSearch2 As System.Windows.Forms.Button
    Friend WithEvents lblIntakeCode As System.Windows.Forms.Label
    Friend WithEvents btnSearch1 As System.Windows.Forms.Button
    Friend WithEvents cbLecturerName As System.Windows.Forms.ComboBox
    Friend WithEvents cbIntakeCode As System.Windows.Forms.ComboBox
    Friend WithEvents btnGExtraClass As System.Windows.Forms.Button
    Friend WithEvents btnMExtraClass As System.Windows.Forms.Button
    Friend WithEvents cbClassPurpose As System.Windows.Forms.ComboBox
    Friend WithEvents lblClassPurpose As System.Windows.Forms.Label
    Friend WithEvents btnSearch3 As System.Windows.Forms.Button
End Class
