<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedulerIntakeMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchedulerIntakeMenu))
        Me.gbStudentMM = New System.Windows.Forms.GroupBox()
        Me.DGVIntakeMenu = New System.Windows.Forms.DataGridView()
        Me.btnMIntake = New System.Windows.Forms.Button()
        Me.btnAIntake = New System.Windows.Forms.Button()
        Me.TCAlogo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.gbWelcome = New System.Windows.Forms.GroupBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnResponse = New System.Windows.Forms.Button()
        Me.btnTimetable = New System.Windows.Forms.Button()
        Me.btnClassroom = New System.Windows.Forms.Button()
        Me.btnIntake = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbIntakeCode = New System.Windows.Forms.ComboBox()
        Me.btnVIntake = New System.Windows.Forms.Button()
        Me.lblIntakeCode = New System.Windows.Forms.Label()
        Me.btnSIntake = New System.Windows.Forms.Button()
        Me.gbStudentMM.SuspendLayout()
        CType(Me.DGVIntakeMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.gbWelcome.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbStudentMM
        '
        Me.gbStudentMM.BackColor = System.Drawing.Color.Transparent
        Me.gbStudentMM.Controls.Add(Me.DGVIntakeMenu)
        Me.gbStudentMM.Location = New System.Drawing.Point(3, 83)
        Me.gbStudentMM.Name = "gbStudentMM"
        Me.gbStudentMM.Size = New System.Drawing.Size(814, 471)
        Me.gbStudentMM.TabIndex = 15
        Me.gbStudentMM.TabStop = False
        '
        'DGVIntakeMenu
        '
        Me.DGVIntakeMenu.AllowUserToAddRows = False
        Me.DGVIntakeMenu.AllowUserToDeleteRows = False
        Me.DGVIntakeMenu.AllowUserToOrderColumns = True
        Me.DGVIntakeMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVIntakeMenu.Location = New System.Drawing.Point(6, 25)
        Me.DGVIntakeMenu.Name = "DGVIntakeMenu"
        Me.DGVIntakeMenu.RowTemplate.Height = 28
        Me.DGVIntakeMenu.Size = New System.Drawing.Size(802, 440)
        Me.DGVIntakeMenu.TabIndex = 16
        '
        'btnMIntake
        '
        Me.btnMIntake.BackColor = System.Drawing.Color.PowderBlue
        Me.btnMIntake.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMIntake.Location = New System.Drawing.Point(323, 560)
        Me.btnMIntake.Name = "btnMIntake"
        Me.btnMIntake.Size = New System.Drawing.Size(200, 70)
        Me.btnMIntake.TabIndex = 12
        Me.btnMIntake.Text = "Modify Intake"
        Me.btnMIntake.UseVisualStyleBackColor = False
        '
        'btnAIntake
        '
        Me.btnAIntake.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAIntake.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAIntake.Location = New System.Drawing.Point(117, 560)
        Me.btnAIntake.Name = "btnAIntake"
        Me.btnAIntake.Size = New System.Drawing.Size(200, 70)
        Me.btnAIntake.TabIndex = 11
        Me.btnAIntake.Text = "Add Intake"
        Me.btnAIntake.UseVisualStyleBackColor = False
        '
        'TCAlogo
        '
        Me.TCAlogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TCAlogo.Image = CType(resources.GetObject("TCAlogo.Image"), System.Drawing.Image)
        Me.TCAlogo.Location = New System.Drawing.Point(12, 12)
        Me.TCAlogo.Name = "TCAlogo"
        Me.TCAlogo.Size = New System.Drawing.Size(80, 80)
        Me.TCAlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TCAlogo.TabIndex = 29
        Me.TCAlogo.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 80)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Scheduler Intake Menu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(98, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(242, 80)
        Me.Panel3.TabIndex = 28
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 95)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(101, 28)
        Me.lblWelcome.TabIndex = 24
        Me.lblWelcome.Text = "Welcome,"
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
        'gbWelcome
        '
        Me.gbWelcome.BackColor = System.Drawing.Color.DarkCyan
        Me.gbWelcome.Controls.Add(Me.lblName)
        Me.gbWelcome.Location = New System.Drawing.Point(12, 120)
        Me.gbWelcome.Name = "gbWelcome"
        Me.gbWelcome.Size = New System.Drawing.Size(202, 51)
        Me.gbWelcome.TabIndex = 25
        Me.gbWelcome.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.PowderBlue
        Me.btnLogout.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(220, 120)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(118, 51)
        Me.btnLogout.TabIndex = 23
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
        Me.Panel1.TabIndex = 26
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
        Me.btnIntake.Enabled = False
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
        Me.Panel2.Controls.Add(Me.cbIntakeCode)
        Me.Panel2.Controls.Add(Me.btnVIntake)
        Me.Panel2.Controls.Add(Me.lblIntakeCode)
        Me.Panel2.Controls.Add(Me.btnSIntake)
        Me.Panel2.Controls.Add(Me.btnMIntake)
        Me.Panel2.Controls.Add(Me.gbStudentMM)
        Me.Panel2.Controls.Add(Me.btnAIntake)
        Me.Panel2.Location = New System.Drawing.Point(346, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(820, 660)
        Me.Panel2.TabIndex = 27
        '
        'cbIntakeCode
        '
        Me.cbIntakeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIntakeCode.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIntakeCode.FormattingEnabled = True
        Me.cbIntakeCode.Location = New System.Drawing.Point(323, 28)
        Me.cbIntakeCode.Name = "cbIntakeCode"
        Me.cbIntakeCode.Size = New System.Drawing.Size(228, 36)
        Me.cbIntakeCode.TabIndex = 36
        '
        'btnVIntake
        '
        Me.btnVIntake.BackColor = System.Drawing.Color.PowderBlue
        Me.btnVIntake.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVIntake.Location = New System.Drawing.Point(529, 560)
        Me.btnVIntake.Name = "btnVIntake"
        Me.btnVIntake.Size = New System.Drawing.Size(200, 70)
        Me.btnVIntake.TabIndex = 18
        Me.btnVIntake.Text = "View All Intake"
        Me.btnVIntake.UseVisualStyleBackColor = False
        '
        'lblIntakeCode
        '
        Me.lblIntakeCode.AutoSize = True
        Me.lblIntakeCode.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeCode.Location = New System.Drawing.Point(184, 31)
        Me.lblIntakeCode.Name = "lblIntakeCode"
        Me.lblIntakeCode.Size = New System.Drawing.Size(133, 28)
        Me.lblIntakeCode.TabIndex = 16
        Me.lblIntakeCode.Text = "Intake Code: "
        '
        'btnSIntake
        '
        Me.btnSIntake.BackColor = System.Drawing.Color.PowderBlue
        Me.btnSIntake.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSIntake.Location = New System.Drawing.Point(557, 28)
        Me.btnSIntake.Name = "btnSIntake"
        Me.btnSIntake.Size = New System.Drawing.Size(118, 51)
        Me.btnSIntake.TabIndex = 13
        Me.btnSIntake.Text = "Search"
        Me.btnSIntake.UseVisualStyleBackColor = False
        '
        'frmSchedulerIntakeMenu
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
        Me.Name = "frmSchedulerIntakeMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Academic Timetabling System"
        Me.gbStudentMM.ResumeLayout(False)
        CType(Me.DGVIntakeMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.gbWelcome.ResumeLayout(False)
        Me.gbWelcome.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbStudentMM As System.Windows.Forms.GroupBox
    Friend WithEvents btnMIntake As System.Windows.Forms.Button
    Friend WithEvents btnAIntake As System.Windows.Forms.Button
    Friend WithEvents TCAlogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents gbWelcome As System.Windows.Forms.GroupBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnResponse As System.Windows.Forms.Button
    Friend WithEvents btnTimetable As System.Windows.Forms.Button
    Friend WithEvents btnClassroom As System.Windows.Forms.Button
    Friend WithEvents btnIntake As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents DGVIntakeMenu As System.Windows.Forms.DataGridView
    Friend WithEvents lblIntakeCode As System.Windows.Forms.Label
    Friend WithEvents btnSIntake As System.Windows.Forms.Button
    Friend WithEvents btnVIntake As System.Windows.Forms.Button
    Friend WithEvents cbIntakeCode As System.Windows.Forms.ComboBox
End Class
