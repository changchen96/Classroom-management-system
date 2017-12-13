<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedulerGExtraClass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchedulerGExtraClass))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGenerateNewTimetable = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBookedby = New System.Windows.Forms.TextBox()
        Me.txtClassPurpose = New System.Windows.Forms.TextBox()
        Me.cbClassroomAssigned = New System.Windows.Forms.ComboBox()
        Me.lblClassroomAssigned = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblClassPurpose = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.cbDay = New System.Windows.Forms.ComboBox()
        Me.cbTime = New System.Windows.Forms.ComboBox()
        Me.lblBookedby = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.PowderBlue
        Me.btnBack.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 49)
        Me.btnBack.TabIndex = 50
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 51
        '
        'lblGenerateNewTimetable
        '
        Me.lblGenerateNewTimetable.AutoSize = True
        Me.lblGenerateNewTimetable.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenerateNewTimetable.Location = New System.Drawing.Point(19, 29)
        Me.lblGenerateNewTimetable.Name = "lblGenerateNewTimetable"
        Me.lblGenerateNewTimetable.Size = New System.Drawing.Size(196, 28)
        Me.lblGenerateNewTimetable.TabIndex = 49
        Me.lblGenerateNewTimetable.Text = "Generate Extra Class"
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(15, 71)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(526, 78)
        Me.lblDesc.TabIndex = 48
        Me.lblDesc.Text = "Please fill in the information down below to generate an extra class for a specif" & _
    "ic user identification."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtBookedby)
        Me.GroupBox1.Controls.Add(Me.txtClassPurpose)
        Me.GroupBox1.Controls.Add(Me.cbClassroomAssigned)
        Me.GroupBox1.Controls.Add(Me.lblClassroomAssigned)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.lblClassPurpose)
        Me.GroupBox1.Controls.Add(Me.lblTime)
        Me.GroupBox1.Controls.Add(Me.lblDay)
        Me.GroupBox1.Controls.Add(Me.cbDay)
        Me.GroupBox1.Controls.Add(Me.cbTime)
        Me.GroupBox1.Controls.Add(Me.lblBookedby)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 392)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'txtBookedby
        '
        Me.txtBookedby.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookedby.Location = New System.Drawing.Point(224, 245)
        Me.txtBookedby.Name = "txtBookedby"
        Me.txtBookedby.Size = New System.Drawing.Size(267, 34)
        Me.txtBookedby.TabIndex = 50
        '
        'txtClassPurpose
        '
        Me.txtClassPurpose.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClassPurpose.Location = New System.Drawing.Point(224, 79)
        Me.txtClassPurpose.Name = "txtClassPurpose"
        Me.txtClassPurpose.Size = New System.Drawing.Size(267, 34)
        Me.txtClassPurpose.TabIndex = 49
        '
        'cbClassroomAssigned
        '
        Me.cbClassroomAssigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassroomAssigned.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClassroomAssigned.FormattingEnabled = True
        Me.cbClassroomAssigned.Location = New System.Drawing.Point(224, 119)
        Me.cbClassroomAssigned.Name = "cbClassroomAssigned"
        Me.cbClassroomAssigned.Size = New System.Drawing.Size(267, 36)
        Me.cbClassroomAssigned.TabIndex = 47
        '
        'lblClassroomAssigned
        '
        Me.lblClassroomAssigned.AutoSize = True
        Me.lblClassroomAssigned.BackColor = System.Drawing.Color.Transparent
        Me.lblClassroomAssigned.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassroomAssigned.Location = New System.Drawing.Point(12, 122)
        Me.lblClassroomAssigned.Name = "lblClassroomAssigned"
        Me.lblClassroomAssigned.Size = New System.Drawing.Size(206, 28)
        Me.lblClassroomAssigned.TabIndex = 48
        Me.lblClassroomAssigned.Text = "Classroom Assigned: "
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
        'lblClassPurpose
        '
        Me.lblClassPurpose.AutoSize = True
        Me.lblClassPurpose.BackColor = System.Drawing.Color.Transparent
        Me.lblClassPurpose.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassPurpose.Location = New System.Drawing.Point(52, 57)
        Me.lblClassPurpose.Name = "lblClassPurpose"
        Me.lblClassPurpose.Size = New System.Drawing.Size(166, 56)
        Me.lblClassPurpose.TabIndex = 36
        Me.lblClassPurpose.Text = "Extra Class" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name/ Purpose: "
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(150, 206)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(68, 28)
        Me.lblTime.TabIndex = 44
        Me.lblTime.Text = "Time: "
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.BackColor = System.Drawing.Color.Transparent
        Me.lblDay.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(161, 164)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(57, 28)
        Me.lblDay.TabIndex = 43
        Me.lblDay.Text = "Day: "
        '
        'cbDay
        '
        Me.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDay.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDay.FormattingEnabled = True
        Me.cbDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.cbDay.Location = New System.Drawing.Point(224, 161)
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
        Me.cbTime.Location = New System.Drawing.Point(224, 203)
        Me.cbTime.Name = "cbTime"
        Me.cbTime.Size = New System.Drawing.Size(267, 36)
        Me.cbTime.TabIndex = 39
        '
        'lblBookedby
        '
        Me.lblBookedby.AutoSize = True
        Me.lblBookedby.BackColor = System.Drawing.Color.Transparent
        Me.lblBookedby.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookedby.Location = New System.Drawing.Point(97, 248)
        Me.lblBookedby.Name = "lblBookedby"
        Me.lblBookedby.Size = New System.Drawing.Size(121, 28)
        Me.lblBookedby.TabIndex = 41
        Me.lblBookedby.Text = "Booked by: "
        '
        'frmSchedulerGExtraClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(578, 644)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 700)
        Me.Name = "frmSchedulerGExtraClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Academic Timetabling System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblGenerateNewTimetable As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtClassPurpose As System.Windows.Forms.TextBox
    Friend WithEvents cbClassroomAssigned As System.Windows.Forms.ComboBox
    Friend WithEvents lblClassroomAssigned As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblClassPurpose As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents cbDay As System.Windows.Forms.ComboBox
    Friend WithEvents cbTime As System.Windows.Forms.ComboBox
    Friend WithEvents lblBookedby As System.Windows.Forms.Label
    Friend WithEvents txtBookedby As System.Windows.Forms.TextBox
End Class
