<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedulerMTimetableMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchedulerMTimetableMenu))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblLecturerAssigned = New System.Windows.Forms.Label()
        Me.lblModuleName = New System.Windows.Forms.Label()
        Me.cbTime = New System.Windows.Forms.ComboBox()
        Me.cbDay = New System.Windows.Forms.ComboBox()
        Me.cbLecturerAssigned = New System.Windows.Forms.ComboBox()
        Me.lblIntakeCode = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDayID = New System.Windows.Forms.TextBox()
        Me.cbTimetableID = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbIntakeCode = New System.Windows.Forms.ComboBox()
        Me.txtModuleName = New System.Windows.Forms.TextBox()
        Me.lblClassroomAssigned = New System.Windows.Forms.Label()
        Me.cbClassroomAssigned = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblModifyTimetableDetails = New System.Windows.Forms.Label()
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
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(8, 48)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(534, 62)
        Me.lblDesc.TabIndex = 62
        Me.lblDesc.Text = "Please fill in the information down below to modify the timetable for a specific " & _
    "intake."
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.PowderBlue
        Me.btnDelete.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(372, 379)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(128, 49)
        Me.btnDelete.TabIndex = 60
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.PowderBlue
        Me.btnUpdate.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(229, 379)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(133, 49)
        Me.btnUpdate.TabIndex = 59
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(155, 216)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(68, 28)
        Me.lblTime.TabIndex = 58
        Me.lblTime.Text = "Time: "
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.BackColor = System.Drawing.Color.Transparent
        Me.lblDay.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(166, 174)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(57, 28)
        Me.lblDay.TabIndex = 57
        Me.lblDay.Text = "Day: "
        '
        'lblLecturerAssigned
        '
        Me.lblLecturerAssigned.AutoSize = True
        Me.lblLecturerAssigned.BackColor = System.Drawing.Color.Transparent
        Me.lblLecturerAssigned.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLecturerAssigned.Location = New System.Drawing.Point(37, 340)
        Me.lblLecturerAssigned.Name = "lblLecturerAssigned"
        Me.lblLecturerAssigned.Size = New System.Drawing.Size(186, 28)
        Me.lblLecturerAssigned.TabIndex = 56
        Me.lblLecturerAssigned.Text = "Lecturer Assigned: "
        '
        'lblModuleName
        '
        Me.lblModuleName.AutoSize = True
        Me.lblModuleName.BackColor = System.Drawing.Color.Transparent
        Me.lblModuleName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModuleName.Location = New System.Drawing.Point(70, 258)
        Me.lblModuleName.Name = "lblModuleName"
        Me.lblModuleName.Size = New System.Drawing.Size(153, 28)
        Me.lblModuleName.TabIndex = 55
        Me.lblModuleName.Text = "Module Name: "
        '
        'cbTime
        '
        Me.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTime.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTime.FormattingEnabled = True
        Me.cbTime.Items.AddRange(New Object() {"0830 - 1030", "1045 - 1245", "1345 - 1545", "1600 - 1800", "1800 - 2000"})
        Me.cbTime.Location = New System.Drawing.Point(229, 213)
        Me.cbTime.Name = "cbTime"
        Me.cbTime.Size = New System.Drawing.Size(271, 36)
        Me.cbTime.TabIndex = 53
        '
        'cbDay
        '
        Me.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDay.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDay.FormattingEnabled = True
        Me.cbDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.cbDay.Location = New System.Drawing.Point(229, 171)
        Me.cbDay.Name = "cbDay"
        Me.cbDay.Size = New System.Drawing.Size(271, 36)
        Me.cbDay.TabIndex = 52
        '
        'cbLecturerAssigned
        '
        Me.cbLecturerAssigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLecturerAssigned.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLecturerAssigned.FormattingEnabled = True
        Me.cbLecturerAssigned.Location = New System.Drawing.Point(229, 337)
        Me.cbLecturerAssigned.Name = "cbLecturerAssigned"
        Me.cbLecturerAssigned.Size = New System.Drawing.Size(271, 36)
        Me.cbLecturerAssigned.TabIndex = 51
        '
        'lblIntakeCode
        '
        Me.lblIntakeCode.AutoSize = True
        Me.lblIntakeCode.BackColor = System.Drawing.Color.Transparent
        Me.lblIntakeCode.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeCode.Location = New System.Drawing.Point(90, 45)
        Me.lblIntakeCode.Name = "lblIntakeCode"
        Me.lblIntakeCode.Size = New System.Drawing.Size(133, 28)
        Me.lblIntakeCode.TabIndex = 50
        Me.lblIntakeCode.Text = "Intake Code: "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtDayID)
        Me.GroupBox1.Controls.Add(Me.cbTimetableID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbIntakeCode)
        Me.GroupBox1.Controls.Add(Me.txtModuleName)
        Me.GroupBox1.Controls.Add(Me.cbDay)
        Me.GroupBox1.Controls.Add(Me.lblLecturerAssigned)
        Me.GroupBox1.Controls.Add(Me.cbLecturerAssigned)
        Me.GroupBox1.Controls.Add(Me.lblClassroomAssigned)
        Me.GroupBox1.Controls.Add(Me.cbClassroomAssigned)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.lblIntakeCode)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.lblTime)
        Me.GroupBox1.Controls.Add(Me.lblDay)
        Me.GroupBox1.Controls.Add(Me.cbTime)
        Me.GroupBox1.Controls.Add(Me.lblModuleName)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 434)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        '
        'txtDayID
        '
        Me.txtDayID.Enabled = False
        Me.txtDayID.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDayID.Location = New System.Drawing.Point(229, 131)
        Me.txtDayID.Name = "txtDayID"
        Me.txtDayID.Size = New System.Drawing.Size(271, 34)
        Me.txtDayID.TabIndex = 73
        Me.txtDayID.Visible = False
        '
        'cbTimetableID
        '
        Me.cbTimetableID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTimetableID.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTimetableID.FormattingEnabled = True
        Me.cbTimetableID.Location = New System.Drawing.Point(229, 84)
        Me.cbTimetableID.Name = "cbTimetableID"
        Me.cbTimetableID.Size = New System.Drawing.Size(271, 36)
        Me.cbTimetableID.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 28)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Timetable ID: "
        '
        'cbIntakeCode
        '
        Me.cbIntakeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIntakeCode.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIntakeCode.FormattingEnabled = True
        Me.cbIntakeCode.Location = New System.Drawing.Point(229, 42)
        Me.cbIntakeCode.Name = "cbIntakeCode"
        Me.cbIntakeCode.Size = New System.Drawing.Size(271, 36)
        Me.cbIntakeCode.TabIndex = 70
        '
        'txtModuleName
        '
        Me.txtModuleName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModuleName.Location = New System.Drawing.Point(229, 255)
        Me.txtModuleName.Name = "txtModuleName"
        Me.txtModuleName.Size = New System.Drawing.Size(271, 34)
        Me.txtModuleName.TabIndex = 69
        '
        'lblClassroomAssigned
        '
        Me.lblClassroomAssigned.AutoSize = True
        Me.lblClassroomAssigned.BackColor = System.Drawing.Color.Transparent
        Me.lblClassroomAssigned.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassroomAssigned.Location = New System.Drawing.Point(17, 298)
        Me.lblClassroomAssigned.Name = "lblClassroomAssigned"
        Me.lblClassroomAssigned.Size = New System.Drawing.Size(206, 28)
        Me.lblClassroomAssigned.TabIndex = 68
        Me.lblClassroomAssigned.Text = "Classroom Assigned: "
        '
        'cbClassroomAssigned
        '
        Me.cbClassroomAssigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassroomAssigned.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClassroomAssigned.FormattingEnabled = True
        Me.cbClassroomAssigned.Location = New System.Drawing.Point(229, 295)
        Me.cbClassroomAssigned.Name = "cbClassroomAssigned"
        Me.cbClassroomAssigned.Size = New System.Drawing.Size(271, 36)
        Me.cbClassroomAssigned.TabIndex = 67
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.lblModifyTimetableDetails)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lblDesc)
        Me.Panel1.Location = New System.Drawing.Point(12, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 565)
        Me.Panel1.TabIndex = 63
        '
        'lblModifyTimetableDetails
        '
        Me.lblModifyTimetableDetails.AutoSize = True
        Me.lblModifyTimetableDetails.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModifyTimetableDetails.Location = New System.Drawing.Point(8, 10)
        Me.lblModifyTimetableDetails.Name = "lblModifyTimetableDetails"
        Me.lblModifyTimetableDetails.Size = New System.Drawing.Size(239, 28)
        Me.lblModifyTimetableDetails.TabIndex = 63
        Me.lblModifyTimetableDetails.Text = "Modify Timetable Details"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Location = New System.Drawing.Point(572, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(594, 620)
        Me.Panel2.TabIndex = 64
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
        Me.GroupBox2.Size = New System.Drawing.Size(588, 561)
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
        'frmSchedulerMTimetableMenu
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
        Me.Name = "frmSchedulerMTimetableMenu"
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
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblLecturerAssigned As System.Windows.Forms.Label
    Friend WithEvents lblModuleName As System.Windows.Forms.Label
    Friend WithEvents cbTime As System.Windows.Forms.ComboBox
    Friend WithEvents cbDay As System.Windows.Forms.ComboBox
    Friend WithEvents cbLecturerAssigned As System.Windows.Forms.ComboBox
    Friend WithEvents lblIntakeCode As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblModifyTimetableDetails As System.Windows.Forms.Label
    Friend WithEvents cbClassroomAssigned As System.Windows.Forms.ComboBox
    Friend WithEvents lblClassroomAssigned As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDigitalAnimation As System.Windows.Forms.Label
    Friend WithEvents txtModuleName As System.Windows.Forms.TextBox
    Friend WithEvents cbIntakeCode As System.Windows.Forms.ComboBox
    Friend WithEvents cbTimetableID As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDayID As System.Windows.Forms.TextBox
End Class
