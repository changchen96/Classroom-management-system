<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedulerGTimetableMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchedulerGTimetableMenu))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cbIntakeCode = New System.Windows.Forms.ComboBox()
        Me.lblIntakeCode = New System.Windows.Forms.Label()
        Me.cbDay = New System.Windows.Forms.ComboBox()
        Me.cbTime = New System.Windows.Forms.ComboBox()
        Me.lblModuleName = New System.Windows.Forms.Label()
        Me.lblLecturerAssigned = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbLecturerAssigned = New System.Windows.Forms.ComboBox()
        Me.txtModuleName = New System.Windows.Forms.TextBox()
        Me.cbClassroomAssigned = New System.Windows.Forms.ComboBox()
        Me.lblClassroomAssigned = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGenerateNewTimetable = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDigitalAnimation = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.PowderBlue
        Me.btnBack.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 49)
        Me.btnBack.TabIndex = 34
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'cbIntakeCode
        '
        Me.cbIntakeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIntakeCode.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIntakeCode.FormattingEnabled = True
        Me.cbIntakeCode.Location = New System.Drawing.Point(224, 52)
        Me.cbIntakeCode.Name = "cbIntakeCode"
        Me.cbIntakeCode.Size = New System.Drawing.Size(267, 36)
        Me.cbIntakeCode.TabIndex = 35
        '
        'lblIntakeCode
        '
        Me.lblIntakeCode.AutoSize = True
        Me.lblIntakeCode.BackColor = System.Drawing.Color.Transparent
        Me.lblIntakeCode.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeCode.Location = New System.Drawing.Point(85, 55)
        Me.lblIntakeCode.Name = "lblIntakeCode"
        Me.lblIntakeCode.Size = New System.Drawing.Size(133, 28)
        Me.lblIntakeCode.TabIndex = 36
        Me.lblIntakeCode.Text = "Intake Code: "
        '
        'cbDay
        '
        Me.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDay.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDay.FormattingEnabled = True
        Me.cbDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.cbDay.Location = New System.Drawing.Point(224, 220)
        Me.cbDay.Name = "cbDay"
        Me.cbDay.Size = New System.Drawing.Size(267, 36)
        Me.cbDay.TabIndex = 38
        '
        'cbTime
        '
        Me.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTime.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTime.FormattingEnabled = True
        Me.cbTime.Items.AddRange(New Object() {"0830 - 1030", "1045 - 1245", "1345 - 1545", "1600 - 1800", "1800 - 2000"})
        Me.cbTime.Location = New System.Drawing.Point(224, 262)
        Me.cbTime.Name = "cbTime"
        Me.cbTime.Size = New System.Drawing.Size(267, 36)
        Me.cbTime.TabIndex = 39
        '
        'lblModuleName
        '
        Me.lblModuleName.AutoSize = True
        Me.lblModuleName.BackColor = System.Drawing.Color.Transparent
        Me.lblModuleName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModuleName.Location = New System.Drawing.Point(65, 97)
        Me.lblModuleName.Name = "lblModuleName"
        Me.lblModuleName.Size = New System.Drawing.Size(153, 28)
        Me.lblModuleName.TabIndex = 41
        Me.lblModuleName.Text = "Module Name: "
        '
        'lblLecturerAssigned
        '
        Me.lblLecturerAssigned.AutoSize = True
        Me.lblLecturerAssigned.BackColor = System.Drawing.Color.Transparent
        Me.lblLecturerAssigned.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLecturerAssigned.Location = New System.Drawing.Point(32, 181)
        Me.lblLecturerAssigned.Name = "lblLecturerAssigned"
        Me.lblLecturerAssigned.Size = New System.Drawing.Size(186, 28)
        Me.lblLecturerAssigned.TabIndex = 42
        Me.lblLecturerAssigned.Text = "Lecturer Assigned: "
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.BackColor = System.Drawing.Color.Transparent
        Me.lblDay.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(161, 223)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(57, 28)
        Me.lblDay.TabIndex = 43
        Me.lblDay.Text = "Day: "
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(150, 265)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(68, 28)
        Me.lblTime.TabIndex = 44
        Me.lblTime.Text = "Time: "
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAdd.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(224, 304)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 49)
        Me.btnAdd.TabIndex = 45
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PowderBlue
        Me.btnClear.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(363, 304)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(128, 49)
        Me.btnClear.TabIndex = 46
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbLecturerAssigned)
        Me.GroupBox1.Controls.Add(Me.txtModuleName)
        Me.GroupBox1.Controls.Add(Me.cbClassroomAssigned)
        Me.GroupBox1.Controls.Add(Me.lblClassroomAssigned)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.cbIntakeCode)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.lblIntakeCode)
        Me.GroupBox1.Controls.Add(Me.lblTime)
        Me.GroupBox1.Controls.Add(Me.lblDay)
        Me.GroupBox1.Controls.Add(Me.cbDay)
        Me.GroupBox1.Controls.Add(Me.lblLecturerAssigned)
        Me.GroupBox1.Controls.Add(Me.cbTime)
        Me.GroupBox1.Controls.Add(Me.lblModuleName)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 392)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'cbLecturerAssigned
        '
        Me.cbLecturerAssigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLecturerAssigned.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLecturerAssigned.FormattingEnabled = True
        Me.cbLecturerAssigned.Location = New System.Drawing.Point(224, 178)
        Me.cbLecturerAssigned.Name = "cbLecturerAssigned"
        Me.cbLecturerAssigned.Size = New System.Drawing.Size(267, 36)
        Me.cbLecturerAssigned.TabIndex = 50
        '
        'txtModuleName
        '
        Me.txtModuleName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModuleName.Location = New System.Drawing.Point(224, 94)
        Me.txtModuleName.Name = "txtModuleName"
        Me.txtModuleName.Size = New System.Drawing.Size(267, 34)
        Me.txtModuleName.TabIndex = 49
        '
        'cbClassroomAssigned
        '
        Me.cbClassroomAssigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassroomAssigned.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClassroomAssigned.FormattingEnabled = True
        Me.cbClassroomAssigned.Location = New System.Drawing.Point(224, 136)
        Me.cbClassroomAssigned.Name = "cbClassroomAssigned"
        Me.cbClassroomAssigned.Size = New System.Drawing.Size(267, 36)
        Me.cbClassroomAssigned.TabIndex = 47
        '
        'lblClassroomAssigned
        '
        Me.lblClassroomAssigned.AutoSize = True
        Me.lblClassroomAssigned.BackColor = System.Drawing.Color.Transparent
        Me.lblClassroomAssigned.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassroomAssigned.Location = New System.Drawing.Point(12, 139)
        Me.lblClassroomAssigned.Name = "lblClassroomAssigned"
        Me.lblClassroomAssigned.Size = New System.Drawing.Size(206, 28)
        Me.lblClassroomAssigned.TabIndex = 48
        Me.lblClassroomAssigned.Text = "Classroom Assigned: "
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(15, 71)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(526, 78)
        Me.lblDesc.TabIndex = 48
        Me.lblDesc.Text = "Please fill in the information down below to generate a new timetable for a speci" & _
    "fic intake."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.lblGenerateNewTimetable)
        Me.Panel1.Controls.Add(Me.lblDesc)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 565)
        Me.Panel1.TabIndex = 49
        '
        'lblGenerateNewTimetable
        '
        Me.lblGenerateNewTimetable.AutoSize = True
        Me.lblGenerateNewTimetable.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenerateNewTimetable.Location = New System.Drawing.Point(19, 29)
        Me.lblGenerateNewTimetable.Name = "lblGenerateNewTimetable"
        Me.lblGenerateNewTimetable.Size = New System.Drawing.Size(238, 28)
        Me.lblGenerateNewTimetable.TabIndex = 49
        Me.lblGenerateNewTimetable.Text = "Generate New Timetable"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Location = New System.Drawing.Point(572, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(594, 620)
        Me.Panel2.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 28)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Module Name List:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblDigitalAnimation)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(588, 558)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 546)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'lblDigitalAnimation
        '
        Me.lblDigitalAnimation.AutoSize = True
        Me.lblDigitalAnimation.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigitalAnimation.Location = New System.Drawing.Point(6, 14)
        Me.lblDigitalAnimation.Name = "lblDigitalAnimation"
        Me.lblDigitalAnimation.Size = New System.Drawing.Size(272, 546)
        Me.lblDigitalAnimation.TabIndex = 0
        Me.lblDigitalAnimation.Text = resources.GetString("lblDigitalAnimation.Text")
        '
        'frmSchedulerGTimetableMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1178, 644)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1200, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1200, 700)
        Me.Name = "frmSchedulerGTimetableMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Academic Timetabling System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents cbIntakeCode As System.Windows.Forms.ComboBox
    Friend WithEvents lblIntakeCode As System.Windows.Forms.Label
    Friend WithEvents cbDay As System.Windows.Forms.ComboBox
    Friend WithEvents cbTime As System.Windows.Forms.ComboBox
    Friend WithEvents lblModuleName As System.Windows.Forms.Label
    Friend WithEvents lblLecturerAssigned As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblGenerateNewTimetable As System.Windows.Forms.Label
    Friend WithEvents cbClassroomAssigned As System.Windows.Forms.ComboBox
    Friend WithEvents lblClassroomAssigned As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDigitalAnimation As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtModuleName As System.Windows.Forms.TextBox
    Friend WithEvents cbLecturerAssigned As System.Windows.Forms.ComboBox
End Class
