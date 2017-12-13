<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAIntakeMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAIntakeMenu))
        Me.lblIntakeCourse = New System.Windows.Forms.Label()
        Me.gbAIntakeMenu = New System.Windows.Forms.GroupBox()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.DTPStartDate = New System.Windows.Forms.DateTimePicker()
        Me.DTPEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblExample = New System.Windows.Forms.Label()
        Me.cbIntakeCourse = New System.Windows.Forms.ComboBox()
        Me.cbIntakeLevel = New System.Windows.Forms.ComboBox()
        Me.lblIntakeLevel = New System.Windows.Forms.Label()
        Me.txtIntakeCode = New System.Windows.Forms.TextBox()
        Me.lblIntakeCode = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtIntakeSize = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAIntake = New System.Windows.Forms.Label()
        Me.gbAIntakeMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIntakeCourse
        '
        Me.lblIntakeCourse.AutoSize = True
        Me.lblIntakeCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblIntakeCourse.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeCourse.Location = New System.Drawing.Point(29, 305)
        Me.lblIntakeCourse.Name = "lblIntakeCourse"
        Me.lblIntakeCourse.Size = New System.Drawing.Size(149, 28)
        Me.lblIntakeCourse.TabIndex = 14
        Me.lblIntakeCourse.Text = "Intake Course: "
        '
        'gbAIntakeMenu
        '
        Me.gbAIntakeMenu.BackColor = System.Drawing.Color.Transparent
        Me.gbAIntakeMenu.Controls.Add(Me.lblEndDate)
        Me.gbAIntakeMenu.Controls.Add(Me.lblStartDate)
        Me.gbAIntakeMenu.Controls.Add(Me.DTPStartDate)
        Me.gbAIntakeMenu.Controls.Add(Me.DTPEndDate)
        Me.gbAIntakeMenu.Controls.Add(Me.lblExample)
        Me.gbAIntakeMenu.Controls.Add(Me.cbIntakeCourse)
        Me.gbAIntakeMenu.Controls.Add(Me.cbIntakeLevel)
        Me.gbAIntakeMenu.Controls.Add(Me.lblIntakeLevel)
        Me.gbAIntakeMenu.Controls.Add(Me.txtIntakeCode)
        Me.gbAIntakeMenu.Controls.Add(Me.lblIntakeCode)
        Me.gbAIntakeMenu.Controls.Add(Me.lblIntakeCourse)
        Me.gbAIntakeMenu.Controls.Add(Me.btnClear)
        Me.gbAIntakeMenu.Controls.Add(Me.btnAdd)
        Me.gbAIntakeMenu.Controls.Add(Me.txtIntakeSize)
        Me.gbAIntakeMenu.Controls.Add(Me.Label1)
        Me.gbAIntakeMenu.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAIntakeMenu.Location = New System.Drawing.Point(31, 144)
        Me.gbAIntakeMenu.Name = "gbAIntakeMenu"
        Me.gbAIntakeMenu.Size = New System.Drawing.Size(498, 454)
        Me.gbAIntakeMenu.TabIndex = 16
        Me.gbAIntakeMenu.TabStop = False
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.BackColor = System.Drawing.Color.Transparent
        Me.lblEndDate.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.Location = New System.Drawing.Point(73, 225)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(105, 28)
        Me.lblEndDate.TabIndex = 43
        Me.lblEndDate.Text = "End Date: "
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.BackColor = System.Drawing.Color.Transparent
        Me.lblStartDate.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.Location = New System.Drawing.Point(65, 185)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(113, 28)
        Me.lblStartDate.TabIndex = 42
        Me.lblStartDate.Text = "Start Date: "
        '
        'DTPStartDate
        '
        Me.DTPStartDate.Location = New System.Drawing.Point(184, 180)
        Me.DTPStartDate.Name = "DTPStartDate"
        Me.DTPStartDate.Size = New System.Drawing.Size(283, 34)
        Me.DTPStartDate.TabIndex = 41
        '
        'DTPEndDate
        '
        Me.DTPEndDate.Enabled = False
        Me.DTPEndDate.Location = New System.Drawing.Point(184, 220)
        Me.DTPEndDate.Name = "DTPEndDate"
        Me.DTPEndDate.Size = New System.Drawing.Size(283, 34)
        Me.DTPEndDate.TabIndex = 40
        '
        'lblExample
        '
        Me.lblExample.AutoSize = True
        Me.lblExample.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExample.Location = New System.Drawing.Point(85, 81)
        Me.lblExample.Name = "lblExample"
        Me.lblExample.Size = New System.Drawing.Size(369, 84)
        Me.lblExample.TabIndex = 28
        Me.lblExample.Text = "        TCA:    The Creative Academy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            D:    Diploma" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         001:   " & _
    " First Intake" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          DA:    Digital Animation (Course Name Initials)"
        '
        'cbIntakeCourse
        '
        Me.cbIntakeCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIntakeCourse.FormattingEnabled = True
        Me.cbIntakeCourse.Items.AddRange(New Object() {"Digital Animation", "Multimedia Design"})
        Me.cbIntakeCourse.Location = New System.Drawing.Point(184, 302)
        Me.cbIntakeCourse.Name = "cbIntakeCourse"
        Me.cbIntakeCourse.Size = New System.Drawing.Size(283, 36)
        Me.cbIntakeCourse.TabIndex = 27
        '
        'cbIntakeLevel
        '
        Me.cbIntakeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIntakeLevel.FormattingEnabled = True
        Me.cbIntakeLevel.Items.AddRange(New Object() {"Diploma"})
        Me.cbIntakeLevel.Location = New System.Drawing.Point(184, 260)
        Me.cbIntakeLevel.Name = "cbIntakeLevel"
        Me.cbIntakeLevel.Size = New System.Drawing.Size(283, 36)
        Me.cbIntakeLevel.TabIndex = 26
        '
        'lblIntakeLevel
        '
        Me.lblIntakeLevel.AutoSize = True
        Me.lblIntakeLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblIntakeLevel.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeLevel.Location = New System.Drawing.Point(45, 263)
        Me.lblIntakeLevel.Name = "lblIntakeLevel"
        Me.lblIntakeLevel.Size = New System.Drawing.Size(133, 28)
        Me.lblIntakeLevel.TabIndex = 25
        Me.lblIntakeLevel.Text = "Intake Level: "
        '
        'txtIntakeCode
        '
        Me.txtIntakeCode.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntakeCode.Location = New System.Drawing.Point(184, 33)
        Me.txtIntakeCode.Name = "txtIntakeCode"
        Me.txtIntakeCode.Size = New System.Drawing.Size(283, 34)
        Me.txtIntakeCode.TabIndex = 24
        Me.txtIntakeCode.Text = "eg: TCAD001DA"
        '
        'lblIntakeCode
        '
        Me.lblIntakeCode.AutoSize = True
        Me.lblIntakeCode.BackColor = System.Drawing.Color.Transparent
        Me.lblIntakeCode.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeCode.Location = New System.Drawing.Point(45, 36)
        Me.lblIntakeCode.Name = "lblIntakeCode"
        Me.lblIntakeCode.Size = New System.Drawing.Size(133, 28)
        Me.lblIntakeCode.TabIndex = 23
        Me.lblIntakeCode.Text = "Intake Code: "
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PowderBlue
        Me.btnClear.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(329, 384)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(138, 64)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAdd.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(184, 384)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(138, 64)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtIntakeSize
        '
        Me.txtIntakeSize.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntakeSize.Location = New System.Drawing.Point(184, 344)
        Me.txtIntakeSize.Name = "txtIntakeSize"
        Me.txtIntakeSize.Size = New System.Drawing.Size(283, 34)
        Me.txtIntakeSize.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 28)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Intake Size: "
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(26, 79)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(503, 62)
        Me.lblDesc.TabIndex = 17
        Me.lblDesc.Text = "Please fill in the information down below to add a new intake."
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.PowderBlue
        Me.btnBack.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 49)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.lblAIntake)
        Me.Panel1.Controls.Add(Me.lblDesc)
        Me.Panel1.Controls.Add(Me.gbAIntakeMenu)
        Me.Panel1.Location = New System.Drawing.Point(12, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 615)
        Me.Panel1.TabIndex = 18
        '
        'lblAIntake
        '
        Me.lblAIntake.AutoSize = True
        Me.lblAIntake.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAIntake.Location = New System.Drawing.Point(26, 34)
        Me.lblAIntake.Name = "lblAIntake"
        Me.lblAIntake.Size = New System.Drawing.Size(159, 28)
        Me.lblAIntake.TabIndex = 18
        Me.lblAIntake.Text = "Add New Intake"
        '
        'frmAIntakeMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(578, 694)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 750)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 750)
        Me.Name = "frmAIntakeMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Academic Timetabling System"
        Me.gbAIntakeMenu.ResumeLayout(False)
        Me.gbAIntakeMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblIntakeCourse As System.Windows.Forms.Label
    Friend WithEvents gbAIntakeMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtIntakeSize As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblAIntake As System.Windows.Forms.Label
    Friend WithEvents txtIntakeCode As System.Windows.Forms.TextBox
    Friend WithEvents lblIntakeCode As System.Windows.Forms.Label
    Friend WithEvents cbIntakeCourse As System.Windows.Forms.ComboBox
    Friend WithEvents cbIntakeLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lblIntakeLevel As System.Windows.Forms.Label
    Friend WithEvents lblExample As System.Windows.Forms.Label
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents DTPStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPEndDate As System.Windows.Forms.DateTimePicker
End Class
