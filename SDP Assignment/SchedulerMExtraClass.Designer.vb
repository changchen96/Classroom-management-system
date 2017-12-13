<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedulerMExtraClass
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGenerateNewTimetable = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbClassPurpose = New System.Windows.Forms.ComboBox()
        Me.txtDayID = New System.Windows.Forms.TextBox()
        Me.txtBookedby = New System.Windows.Forms.TextBox()
        Me.cbClassroomAssigned = New System.Windows.Forms.ComboBox()
        Me.lblClassroomAssigned = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
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
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(8, 8)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(67, 32)
        Me.btnBack.TabIndex = 52
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.lblGenerateNewTimetable)
        Me.Panel1.Controls.Add(Me.lblDesc)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(8, 44)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 367)
        Me.Panel1.TabIndex = 53
        '
        'lblGenerateNewTimetable
        '
        Me.lblGenerateNewTimetable.AutoSize = True
        Me.lblGenerateNewTimetable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenerateNewTimetable.Location = New System.Drawing.Point(13, 19)
        Me.lblGenerateNewTimetable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGenerateNewTimetable.Name = "lblGenerateNewTimetable"
        Me.lblGenerateNewTimetable.Size = New System.Drawing.Size(141, 17)
        Me.lblGenerateNewTimetable.TabIndex = 49
        Me.lblGenerateNewTimetable.Text = "Modify Extra Class"
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(10, 46)
        Me.lblDesc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(351, 51)
        Me.lblDesc.TabIndex = 48
        Me.lblDesc.Text = "Please fill in the information down below to modify the extra class for a specifi" & _
    "c user identification."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbClassPurpose)
        Me.GroupBox1.Controls.Add(Me.txtDayID)
        Me.GroupBox1.Controls.Add(Me.txtBookedby)
        Me.GroupBox1.Controls.Add(Me.cbClassroomAssigned)
        Me.GroupBox1.Controls.Add(Me.lblClassroomAssigned)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.lblClassPurpose)
        Me.GroupBox1.Controls.Add(Me.lblTime)
        Me.GroupBox1.Controls.Add(Me.lblDay)
        Me.GroupBox1.Controls.Add(Me.cbDay)
        Me.GroupBox1.Controls.Add(Me.cbTime)
        Me.GroupBox1.Controls.Add(Me.lblBookedby)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 99)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(347, 255)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'cbClassPurpose
        '
        Me.cbClassPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClassPurpose.FormattingEnabled = True
        Me.cbClassPurpose.Location = New System.Drawing.Point(169, 43)
        Me.cbClassPurpose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbClassPurpose.Name = "cbClassPurpose"
        Me.cbClassPurpose.Size = New System.Drawing.Size(161, 24)
        Me.cbClassPurpose.TabIndex = 77
        '
        'txtDayID
        '
        Me.txtDayID.Enabled = False
        Me.txtDayID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDayID.Location = New System.Drawing.Point(169, 70)
        Me.txtDayID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDayID.Name = "txtDayID"
        Me.txtDayID.Size = New System.Drawing.Size(161, 23)
        Me.txtDayID.TabIndex = 74
        Me.txtDayID.Visible = False
        '
        'txtBookedby
        '
        Me.txtBookedby.Enabled = False
        Me.txtBookedby.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookedby.Location = New System.Drawing.Point(169, 178)
        Me.txtBookedby.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBookedby.Name = "txtBookedby"
        Me.txtBookedby.Size = New System.Drawing.Size(161, 23)
        Me.txtBookedby.TabIndex = 50
        '
        'cbClassroomAssigned
        '
        Me.cbClassroomAssigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassroomAssigned.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClassroomAssigned.FormattingEnabled = True
        Me.cbClassroomAssigned.Location = New System.Drawing.Point(169, 96)
        Me.cbClassroomAssigned.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbClassroomAssigned.Name = "cbClassroomAssigned"
        Me.cbClassroomAssigned.Size = New System.Drawing.Size(161, 24)
        Me.cbClassroomAssigned.TabIndex = 47
        '
        'lblClassroomAssigned
        '
        Me.lblClassroomAssigned.AutoSize = True
        Me.lblClassroomAssigned.BackColor = System.Drawing.Color.Transparent
        Me.lblClassroomAssigned.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassroomAssigned.Location = New System.Drawing.Point(9, 98)
        Me.lblClassroomAssigned.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClassroomAssigned.Name = "lblClassroomAssigned"
        Me.lblClassroomAssigned.Size = New System.Drawing.Size(164, 17)
        Me.lblClassroomAssigned.TabIndex = 48
        Me.lblClassroomAssigned.Text = "Classroom Assigned: "
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.PowderBlue
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(243, 210)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 32)
        Me.btnDelete.TabIndex = 46
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.PowderBlue
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(151, 210)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(85, 32)
        Me.btnUpdate.TabIndex = 45
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblClassPurpose
        '
        Me.lblClassPurpose.AutoSize = True
        Me.lblClassPurpose.BackColor = System.Drawing.Color.Transparent
        Me.lblClassPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassPurpose.Location = New System.Drawing.Point(36, 30)
        Me.lblClassPurpose.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClassPurpose.Name = "lblClassPurpose"
        Me.lblClassPurpose.Size = New System.Drawing.Size(129, 34)
        Me.lblClassPurpose.TabIndex = 36
        Me.lblClassPurpose.Text = "Extra Class" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name/ Purpose: "
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(101, 153)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(53, 17)
        Me.lblTime.TabIndex = 44
        Me.lblTime.Text = "Time: "
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.BackColor = System.Drawing.Color.Transparent
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(109, 125)
        Me.lblDay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(46, 17)
        Me.lblDay.TabIndex = 43
        Me.lblDay.Text = "Day: "
        '
        'cbDay
        '
        Me.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDay.FormattingEnabled = True
        Me.cbDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.cbDay.Location = New System.Drawing.Point(169, 123)
        Me.cbDay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbDay.Name = "cbDay"
        Me.cbDay.Size = New System.Drawing.Size(161, 24)
        Me.cbDay.TabIndex = 38
        '
        'cbTime
        '
        Me.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTime.FormattingEnabled = True
        Me.cbTime.Items.AddRange(New Object() {"0830 - 1030", "1045 - 1245", "1345 - 1545", "1600 - 1800", "1800 - 2000"})
        Me.cbTime.Location = New System.Drawing.Point(169, 151)
        Me.cbTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbTime.Name = "cbTime"
        Me.cbTime.Size = New System.Drawing.Size(161, 24)
        Me.cbTime.TabIndex = 39
        '
        'lblBookedby
        '
        Me.lblBookedby.AutoSize = True
        Me.lblBookedby.BackColor = System.Drawing.Color.Transparent
        Me.lblBookedby.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookedby.Location = New System.Drawing.Point(66, 180)
        Me.lblBookedby.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBookedby.Name = "lblBookedby"
        Me.lblBookedby.Size = New System.Drawing.Size(95, 17)
        Me.lblBookedby.TabIndex = 41
        Me.lblBookedby.Text = "Booked By: "
        '
        'frmSchedulerMExtraClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(389, 430)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(405, 469)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(405, 469)
        Me.Name = "frmSchedulerMExtraClass"
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
    Friend WithEvents txtBookedby As System.Windows.Forms.TextBox
    Friend WithEvents cbClassroomAssigned As System.Windows.Forms.ComboBox
    Friend WithEvents lblClassroomAssigned As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblClassPurpose As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents cbDay As System.Windows.Forms.ComboBox
    Friend WithEvents cbTime As System.Windows.Forms.ComboBox
    Friend WithEvents lblBookedby As System.Windows.Forms.Label
    Friend WithEvents txtDayID As System.Windows.Forms.TextBox
    Friend WithEvents cbClassPurpose As System.Windows.Forms.ComboBox
End Class
