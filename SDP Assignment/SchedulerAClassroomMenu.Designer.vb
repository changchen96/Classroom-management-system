<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedulerAClassroomMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchedulerAClassroomMenu))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtClassroomName = New System.Windows.Forms.TextBox()
        Me.cbClassroomType = New System.Windows.Forms.ComboBox()
        Me.gbAddClassroom = New System.Windows.Forms.GroupBox()
        Me.lblClassroomSize = New System.Windows.Forms.Label()
        Me.lblExample = New System.Windows.Forms.Label()
        Me.lblClassroomType = New System.Windows.Forms.Label()
        Me.lblClassroomName = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAClassroom = New System.Windows.Forms.Label()
        Me.cbClassroomSize = New System.Windows.Forms.ComboBox()
        Me.gbAddClassroom.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.PowderBlue
        Me.btnBack.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 49)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtClassroomName
        '
        Me.txtClassroomName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClassroomName.Location = New System.Drawing.Point(212, 37)
        Me.txtClassroomName.Name = "txtClassroomName"
        Me.txtClassroomName.Size = New System.Drawing.Size(243, 34)
        Me.txtClassroomName.TabIndex = 27
        Me.txtClassroomName.Text = "eg: L1-01-BC"
        '
        'cbClassroomType
        '
        Me.cbClassroomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassroomType.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClassroomType.FormattingEnabled = True
        Me.cbClassroomType.Items.AddRange(New Object() {"Basic Classroom", "Laboratory", "Auditorium"})
        Me.cbClassroomType.Location = New System.Drawing.Point(213, 186)
        Me.cbClassroomType.Name = "cbClassroomType"
        Me.cbClassroomType.Size = New System.Drawing.Size(243, 36)
        Me.cbClassroomType.TabIndex = 28
        '
        'gbAddClassroom
        '
        Me.gbAddClassroom.BackColor = System.Drawing.Color.Transparent
        Me.gbAddClassroom.Controls.Add(Me.cbClassroomSize)
        Me.gbAddClassroom.Controls.Add(Me.lblClassroomSize)
        Me.gbAddClassroom.Controls.Add(Me.lblExample)
        Me.gbAddClassroom.Controls.Add(Me.lblClassroomType)
        Me.gbAddClassroom.Controls.Add(Me.lblClassroomName)
        Me.gbAddClassroom.Controls.Add(Me.txtClassroomName)
        Me.gbAddClassroom.Controls.Add(Me.btnClear)
        Me.gbAddClassroom.Controls.Add(Me.btnAdd)
        Me.gbAddClassroom.Controls.Add(Me.cbClassroomType)
        Me.gbAddClassroom.Location = New System.Drawing.Point(31, 160)
        Me.gbAddClassroom.Name = "gbAddClassroom"
        Me.gbAddClassroom.Size = New System.Drawing.Size(490, 387)
        Me.gbAddClassroom.TabIndex = 30
        Me.gbAddClassroom.TabStop = False
        '
        'lblClassroomSize
        '
        Me.lblClassroomSize.AutoSize = True
        Me.lblClassroomSize.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassroomSize.Location = New System.Drawing.Point(48, 231)
        Me.lblClassroomSize.Name = "lblClassroomSize"
        Me.lblClassroomSize.Size = New System.Drawing.Size(159, 28)
        Me.lblClassroomSize.TabIndex = 37
        Me.lblClassroomSize.Text = "Classroom Size: "
        '
        'lblExample
        '
        Me.lblExample.AutoSize = True
        Me.lblExample.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExample.Location = New System.Drawing.Point(-10, 93)
        Me.lblExample.Name = "lblExample"
        Me.lblExample.Size = New System.Drawing.Size(465, 63)
        Me.lblExample.TabIndex = 35
        Me.lblExample.Text = "        L1:    First Floor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        01:    Room Number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        BC:    Basic Clas" & _
    "sroom/ LAB = Laboratory/ AUD = Auditorium"
        '
        'lblClassroomType
        '
        Me.lblClassroomType.AutoSize = True
        Me.lblClassroomType.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassroomType.Location = New System.Drawing.Point(42, 189)
        Me.lblClassroomType.Name = "lblClassroomType"
        Me.lblClassroomType.Size = New System.Drawing.Size(165, 28)
        Me.lblClassroomType.TabIndex = 32
        Me.lblClassroomType.Text = "Classroom Type: "
        '
        'lblClassroomName
        '
        Me.lblClassroomName.AutoSize = True
        Me.lblClassroomName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassroomName.Location = New System.Drawing.Point(29, 40)
        Me.lblClassroomName.Name = "lblClassroomName"
        Me.lblClassroomName.Size = New System.Drawing.Size(177, 28)
        Me.lblClassroomName.TabIndex = 31
        Me.lblClassroomName.Text = "Classroom Name: "
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PowderBlue
        Me.btnClear.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(338, 280)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(118, 64)
        Me.btnClear.TabIndex = 30
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAdd.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(212, 280)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(118, 64)
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(26, 95)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(495, 62)
        Me.lblDesc.TabIndex = 31
        Me.lblDesc.Text = "Please fill in the information down below to add a new classroom."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.lblAClassroom)
        Me.Panel1.Controls.Add(Me.lblDesc)
        Me.Panel1.Controls.Add(Me.gbAddClassroom)
        Me.Panel1.Location = New System.Drawing.Point(12, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 565)
        Me.Panel1.TabIndex = 32
        '
        'lblAClassroom
        '
        Me.lblAClassroom.AutoSize = True
        Me.lblAClassroom.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAClassroom.Location = New System.Drawing.Point(26, 48)
        Me.lblAClassroom.Name = "lblAClassroom"
        Me.lblAClassroom.Size = New System.Drawing.Size(196, 28)
        Me.lblAClassroom.TabIndex = 32
        Me.lblAClassroom.Text = "Add New Classroom"
        '
        'cbClassroomSize
        '
        Me.cbClassroomSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassroomSize.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClassroomSize.FormattingEnabled = True
        Me.cbClassroomSize.Items.AddRange(New Object() {"30", "40", "50", "60", "100"})
        Me.cbClassroomSize.Location = New System.Drawing.Point(212, 228)
        Me.cbClassroomSize.Name = "cbClassroomSize"
        Me.cbClassroomSize.Size = New System.Drawing.Size(243, 36)
        Me.cbClassroomSize.TabIndex = 38
        '
        'frmSchedulerAClassroomMenu
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
        Me.Name = "frmSchedulerAClassroomMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Academic Timetabling System"
        Me.gbAddClassroom.ResumeLayout(False)
        Me.gbAddClassroom.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtClassroomName As System.Windows.Forms.TextBox
    Friend WithEvents cbClassroomType As System.Windows.Forms.ComboBox
    Friend WithEvents gbAddClassroom As System.Windows.Forms.GroupBox
    Friend WithEvents lblClassroomType As System.Windows.Forms.Label
    Friend WithEvents lblClassroomName As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblAClassroom As System.Windows.Forms.Label
    Friend WithEvents lblExample As System.Windows.Forms.Label
    Friend WithEvents lblClassroomSize As System.Windows.Forms.Label
    Friend WithEvents cbClassroomSize As System.Windows.Forms.ComboBox
End Class
