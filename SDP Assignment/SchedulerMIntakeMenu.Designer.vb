<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMIntakeMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMIntakeMenu))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblIntakeCourse = New System.Windows.Forms.Label()
        Me.gbAIntakeMenu = New System.Windows.Forms.GroupBox()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.DTPStartDate = New System.Windows.Forms.DateTimePicker()
        Me.DTPEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblIntakeCode2 = New System.Windows.Forms.Label()
        Me.txtIntakeCode = New System.Windows.Forms.TextBox()
        Me.cbIntakeCode = New System.Windows.Forms.ComboBox()
        Me.lblIntakeCode = New System.Windows.Forms.Label()
        Me.cbIntakeCourse = New System.Windows.Forms.ComboBox()
        Me.cbIntakeLevel = New System.Windows.Forms.ComboBox()
        Me.lblIntakeLevel = New System.Windows.Forms.Label()
        Me.txtIntakeID = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtIntakeSize = New System.Windows.Forms.TextBox()
        Me.lblIntakeSize = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMIntake = New System.Windows.Forms.Label()
        Me.txtRandomID = New System.Windows.Forms.TextBox()
        Me.gbAIntakeMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblIntakeCourse
        '
        Me.lblIntakeCourse.AutoSize = True
        Me.lblIntakeCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblIntakeCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeCourse.Location = New System.Drawing.Point(24, 193)
        Me.lblIntakeCourse.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIntakeCourse.Name = "lblIntakeCourse"
        Me.lblIntakeCourse.Size = New System.Drawing.Size(118, 17)
        Me.lblIntakeCourse.TabIndex = 18
        Me.lblIntakeCourse.Text = "Intake Course: "
        '
        'gbAIntakeMenu
        '
        Me.gbAIntakeMenu.BackColor = System.Drawing.Color.Transparent
        Me.gbAIntakeMenu.Controls.Add(Me.lblEndDate)
        Me.gbAIntakeMenu.Controls.Add(Me.lblStartDate)
        Me.gbAIntakeMenu.Controls.Add(Me.DTPStartDate)
        Me.gbAIntakeMenu.Controls.Add(Me.DTPEndDate)
        Me.gbAIntakeMenu.Controls.Add(Me.lblIntakeCode2)
        Me.gbAIntakeMenu.Controls.Add(Me.txtIntakeCode)
        Me.gbAIntakeMenu.Controls.Add(Me.cbIntakeCode)
        Me.gbAIntakeMenu.Controls.Add(Me.lblIntakeCode)
        Me.gbAIntakeMenu.Controls.Add(Me.cbIntakeCourse)
        Me.gbAIntakeMenu.Controls.Add(Me.cbIntakeLevel)
        Me.gbAIntakeMenu.Controls.Add(Me.lblIntakeLevel)
        Me.gbAIntakeMenu.Controls.Add(Me.txtIntakeID)
        Me.gbAIntakeMenu.Controls.Add(Me.lblIntakeCourse)
        Me.gbAIntakeMenu.Controls.Add(Me.btnDelete)
        Me.gbAIntakeMenu.Controls.Add(Me.btnUpdate)
        Me.gbAIntakeMenu.Controls.Add(Me.txtIntakeSize)
        Me.gbAIntakeMenu.Controls.Add(Me.lblIntakeSize)
        Me.gbAIntakeMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAIntakeMenu.Location = New System.Drawing.Point(11, 99)
        Me.gbAIntakeMenu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbAIntakeMenu.Name = "gbAIntakeMenu"
        Me.gbAIntakeMenu.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbAIntakeMenu.Size = New System.Drawing.Size(347, 291)
        Me.gbAIntakeMenu.TabIndex = 19
        Me.gbAIntakeMenu.TabStop = False
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.BackColor = System.Drawing.Color.Transparent
        Me.lblEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.Location = New System.Drawing.Point(53, 115)
        Me.lblEndDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(85, 17)
        Me.lblEndDate.TabIndex = 39
        Me.lblEndDate.Text = "End Date: "
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.BackColor = System.Drawing.Color.Transparent
        Me.lblStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.Location = New System.Drawing.Point(48, 89)
        Me.lblStartDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(92, 17)
        Me.lblStartDate.TabIndex = 38
        Me.lblStartDate.Text = "Start Date: "
        '
        'DTPStartDate
        '
        Me.DTPStartDate.Location = New System.Drawing.Point(144, 86)
        Me.DTPStartDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DTPStartDate.Name = "DTPStartDate"
        Me.DTPStartDate.Size = New System.Drawing.Size(170, 23)
        Me.DTPStartDate.TabIndex = 37
        '
        'DTPEndDate
        '
        Me.DTPEndDate.Enabled = False
        Me.DTPEndDate.Location = New System.Drawing.Point(144, 112)
        Me.DTPEndDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DTPEndDate.Name = "DTPEndDate"
        Me.DTPEndDate.Size = New System.Drawing.Size(170, 23)
        Me.DTPEndDate.TabIndex = 36
        '
        'lblIntakeCode2
        '
        Me.lblIntakeCode2.AutoSize = True
        Me.lblIntakeCode2.BackColor = System.Drawing.Color.Transparent
        Me.lblIntakeCode2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeCode2.Location = New System.Drawing.Point(35, 140)
        Me.lblIntakeCode2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIntakeCode2.Name = "lblIntakeCode2"
        Me.lblIntakeCode2.Size = New System.Drawing.Size(104, 17)
        Me.lblIntakeCode2.TabIndex = 35
        Me.lblIntakeCode2.Text = "Intake Code: "
        '
        'txtIntakeCode
        '
        Me.txtIntakeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntakeCode.Location = New System.Drawing.Point(144, 138)
        Me.txtIntakeCode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIntakeCode.Name = "txtIntakeCode"
        Me.txtIntakeCode.Size = New System.Drawing.Size(170, 23)
        Me.txtIntakeCode.TabIndex = 34
        '
        'cbIntakeCode
        '
        Me.cbIntakeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIntakeCode.FormattingEnabled = True
        Me.cbIntakeCode.Items.AddRange(New Object() {"Diploma"})
        Me.cbIntakeCode.Location = New System.Drawing.Point(143, 32)
        Me.cbIntakeCode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbIntakeCode.Name = "cbIntakeCode"
        Me.cbIntakeCode.Size = New System.Drawing.Size(171, 24)
        Me.cbIntakeCode.TabIndex = 33
        '
        'lblIntakeCode
        '
        Me.lblIntakeCode.AutoSize = True
        Me.lblIntakeCode.BackColor = System.Drawing.Color.Transparent
        Me.lblIntakeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeCode.Location = New System.Drawing.Point(35, 34)
        Me.lblIntakeCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIntakeCode.Name = "lblIntakeCode"
        Me.lblIntakeCode.Size = New System.Drawing.Size(104, 17)
        Me.lblIntakeCode.TabIndex = 32
        Me.lblIntakeCode.Text = "Intake Code: "
        '
        'cbIntakeCourse
        '
        Me.cbIntakeCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIntakeCourse.FormattingEnabled = True
        Me.cbIntakeCourse.Items.AddRange(New Object() {"Digital Animation", "Multimedia Design"})
        Me.cbIntakeCourse.Location = New System.Drawing.Point(144, 191)
        Me.cbIntakeCourse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbIntakeCourse.Name = "cbIntakeCourse"
        Me.cbIntakeCourse.Size = New System.Drawing.Size(170, 24)
        Me.cbIntakeCourse.TabIndex = 31
        '
        'cbIntakeLevel
        '
        Me.cbIntakeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIntakeLevel.FormattingEnabled = True
        Me.cbIntakeLevel.Items.AddRange(New Object() {"Diploma"})
        Me.cbIntakeLevel.Location = New System.Drawing.Point(144, 164)
        Me.cbIntakeLevel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbIntakeLevel.Name = "cbIntakeLevel"
        Me.cbIntakeLevel.Size = New System.Drawing.Size(170, 24)
        Me.cbIntakeLevel.TabIndex = 30
        '
        'lblIntakeLevel
        '
        Me.lblIntakeLevel.AutoSize = True
        Me.lblIntakeLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblIntakeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeLevel.Location = New System.Drawing.Point(35, 166)
        Me.lblIntakeLevel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIntakeLevel.Name = "lblIntakeLevel"
        Me.lblIntakeLevel.Size = New System.Drawing.Size(106, 17)
        Me.lblIntakeLevel.TabIndex = 29
        Me.lblIntakeLevel.Text = "Intake Level: "
        '
        'txtIntakeID
        '
        Me.txtIntakeID.Enabled = False
        Me.txtIntakeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntakeID.Location = New System.Drawing.Point(144, 60)
        Me.txtIntakeID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIntakeID.Name = "txtIntakeID"
        Me.txtIntakeID.Size = New System.Drawing.Size(170, 23)
        Me.txtIntakeID.TabIndex = 27
        Me.txtIntakeID.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.PowderBlue
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(223, 245)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 42)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.PowderBlue
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(129, 245)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 42)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtIntakeSize
        '
        Me.txtIntakeSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntakeSize.Location = New System.Drawing.Point(144, 218)
        Me.txtIntakeSize.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIntakeSize.Name = "txtIntakeSize"
        Me.txtIntakeSize.Size = New System.Drawing.Size(170, 23)
        Me.txtIntakeSize.TabIndex = 18
        '
        'lblIntakeSize
        '
        Me.lblIntakeSize.AutoSize = True
        Me.lblIntakeSize.BackColor = System.Drawing.Color.Transparent
        Me.lblIntakeSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeSize.Location = New System.Drawing.Point(42, 220)
        Me.lblIntakeSize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIntakeSize.Name = "lblIntakeSize"
        Me.lblIntakeSize.Size = New System.Drawing.Size(98, 17)
        Me.lblIntakeSize.TabIndex = 17
        Me.lblIntakeSize.Text = "Intake Size: "
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(11, 57)
        Me.lblDesc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(347, 40)
        Me.lblDesc.TabIndex = 20
        Me.lblDesc.Text = "Please fill in the information down below to modify the intake details."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.lblMIntake)
        Me.Panel1.Controls.Add(Me.gbAIntakeMenu)
        Me.Panel1.Controls.Add(Me.lblDesc)
        Me.Panel1.Location = New System.Drawing.Point(8, 44)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 400)
        Me.Panel1.TabIndex = 21
        '
        'lblMIntake
        '
        Me.lblMIntake.AutoSize = True
        Me.lblMIntake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMIntake.Location = New System.Drawing.Point(11, 26)
        Me.lblMIntake.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMIntake.Name = "lblMIntake"
        Me.lblMIntake.Size = New System.Drawing.Size(104, 17)
        Me.lblMIntake.TabIndex = 21
        Me.lblMIntake.Text = "Modify Intake"
        '
        'txtRandomID
        '
        Me.txtRandomID.Enabled = False
        Me.txtRandomID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRandomID.Location = New System.Drawing.Point(192, 12)
        Me.txtRandomID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRandomID.Name = "txtRandomID"
        Me.txtRandomID.Size = New System.Drawing.Size(187, 23)
        Me.txtRandomID.TabIndex = 40
        Me.txtRandomID.Visible = False
        '
        'frmMIntakeMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(389, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtRandomID)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(405, 501)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(405, 486)
        Me.Name = "frmMIntakeMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Academic Timetabling System"
        Me.gbAIntakeMenu.ResumeLayout(False)
        Me.gbAIntakeMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblIntakeCourse As System.Windows.Forms.Label
    Friend WithEvents gbAIntakeMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtIntakeSize As System.Windows.Forms.TextBox
    Friend WithEvents lblIntakeSize As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMIntake As System.Windows.Forms.Label
    Friend WithEvents txtIntakeID As System.Windows.Forms.TextBox
    Friend WithEvents lblIntakeLevel As System.Windows.Forms.Label
    Friend WithEvents cbIntakeCourse As System.Windows.Forms.ComboBox
    Friend WithEvents cbIntakeLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cbIntakeCode As System.Windows.Forms.ComboBox
    Friend WithEvents lblIntakeCode As System.Windows.Forms.Label
    Friend WithEvents lblIntakeCode2 As System.Windows.Forms.Label
    Friend WithEvents txtIntakeCode As System.Windows.Forms.TextBox
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents DTPStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRandomID As System.Windows.Forms.TextBox
End Class
