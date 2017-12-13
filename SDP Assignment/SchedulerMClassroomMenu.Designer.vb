<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedulerMClassroomMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchedulerMClassroomMenu))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbAIntakeMenu = New System.Windows.Forms.GroupBox()
        Me.txtClassroomID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbClassroomName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbClassroomSize = New System.Windows.Forms.ComboBox()
        Me.lblClassroomName = New System.Windows.Forms.Label()
        Me.lblClassroomType = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cbClassroomType = New System.Windows.Forms.ComboBox()
        Me.txtClassroomName = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAClassroom = New System.Windows.Forms.Label()
        Me.gbAIntakeMenu.SuspendLayout()
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
        'gbAIntakeMenu
        '
        Me.gbAIntakeMenu.BackColor = System.Drawing.Color.Transparent
        Me.gbAIntakeMenu.Controls.Add(Me.txtClassroomID)
        Me.gbAIntakeMenu.Controls.Add(Me.Label2)
        Me.gbAIntakeMenu.Controls.Add(Me.cbClassroomName)
        Me.gbAIntakeMenu.Controls.Add(Me.Label1)
        Me.gbAIntakeMenu.Controls.Add(Me.cbClassroomSize)
        Me.gbAIntakeMenu.Controls.Add(Me.lblClassroomName)
        Me.gbAIntakeMenu.Controls.Add(Me.lblClassroomType)
        Me.gbAIntakeMenu.Controls.Add(Me.btnDelete)
        Me.gbAIntakeMenu.Controls.Add(Me.btnUpdate)
        Me.gbAIntakeMenu.Controls.Add(Me.cbClassroomType)
        Me.gbAIntakeMenu.Controls.Add(Me.txtClassroomName)
        Me.gbAIntakeMenu.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAIntakeMenu.Location = New System.Drawing.Point(32, 134)
        Me.gbAIntakeMenu.Name = "gbAIntakeMenu"
        Me.gbAIntakeMenu.Size = New System.Drawing.Size(488, 361)
        Me.gbAIntakeMenu.TabIndex = 27
        Me.gbAIntakeMenu.TabStop = False
        '
        'txtClassroomID
        '
        Me.txtClassroomID.Enabled = False
        Me.txtClassroomID.Location = New System.Drawing.Point(202, 75)
        Me.txtClassroomID.Name = "txtClassroomID"
        Me.txtClassroomID.Size = New System.Drawing.Size(267, 34)
        Me.txtClassroomID.TabIndex = 31
        Me.txtClassroomID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 28)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Classroom Name: "
        '
        'cbClassroomName
        '
        Me.cbClassroomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassroomName.FormattingEnabled = True
        Me.cbClassroomName.Location = New System.Drawing.Point(202, 33)
        Me.cbClassroomName.Name = "cbClassroomName"
        Me.cbClassroomName.Size = New System.Drawing.Size(267, 36)
        Me.cbClassroomName.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 28)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Classroom Size: "
        '
        'cbClassroomSize
        '
        Me.cbClassroomSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassroomSize.FormattingEnabled = True
        Me.cbClassroomSize.Items.AddRange(New Object() {"30", "40", "50", "60", "100"})
        Me.cbClassroomSize.Location = New System.Drawing.Point(201, 199)
        Me.cbClassroomSize.Name = "cbClassroomSize"
        Me.cbClassroomSize.Size = New System.Drawing.Size(267, 36)
        Me.cbClassroomSize.TabIndex = 27
        '
        'lblClassroomName
        '
        Me.lblClassroomName.AutoSize = True
        Me.lblClassroomName.BackColor = System.Drawing.Color.Transparent
        Me.lblClassroomName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassroomName.Location = New System.Drawing.Point(16, 118)
        Me.lblClassroomName.Name = "lblClassroomName"
        Me.lblClassroomName.Size = New System.Drawing.Size(177, 28)
        Me.lblClassroomName.TabIndex = 18
        Me.lblClassroomName.Text = "Classroom Name: "
        '
        'lblClassroomType
        '
        Me.lblClassroomType.AutoSize = True
        Me.lblClassroomType.BackColor = System.Drawing.Color.Transparent
        Me.lblClassroomType.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassroomType.Location = New System.Drawing.Point(28, 160)
        Me.lblClassroomType.Name = "lblClassroomType"
        Me.lblClassroomType.Size = New System.Drawing.Size(165, 28)
        Me.lblClassroomType.TabIndex = 18
        Me.lblClassroomType.Text = "Classroom Type: "
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.PowderBlue
        Me.btnDelete.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(338, 241)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 64)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.PowderBlue
        Me.btnUpdate.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(202, 241)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(130, 64)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'cbClassroomType
        '
        Me.cbClassroomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassroomType.FormattingEnabled = True
        Me.cbClassroomType.Items.AddRange(New Object() {"Basic Classroom", "Laboratory", "Auditorium"})
        Me.cbClassroomType.Location = New System.Drawing.Point(201, 157)
        Me.cbClassroomType.Name = "cbClassroomType"
        Me.cbClassroomType.Size = New System.Drawing.Size(267, 36)
        Me.cbClassroomType.TabIndex = 19
        '
        'txtClassroomName
        '
        Me.txtClassroomName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClassroomName.Location = New System.Drawing.Point(201, 115)
        Me.txtClassroomName.Name = "txtClassroomName"
        Me.txtClassroomName.Size = New System.Drawing.Size(267, 34)
        Me.txtClassroomName.TabIndex = 18
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(27, 69)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(493, 62)
        Me.lblDesc.TabIndex = 28
        Me.lblDesc.Text = "Please fill in the information down below to modify the classroom details."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.lblAClassroom)
        Me.Panel1.Controls.Add(Me.gbAIntakeMenu)
        Me.Panel1.Controls.Add(Me.lblDesc)
        Me.Panel1.Location = New System.Drawing.Point(12, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 515)
        Me.Panel1.TabIndex = 29
        '
        'lblAClassroom
        '
        Me.lblAClassroom.AutoSize = True
        Me.lblAClassroom.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAClassroom.Location = New System.Drawing.Point(27, 27)
        Me.lblAClassroom.Name = "lblAClassroom"
        Me.lblAClassroom.Size = New System.Drawing.Size(243, 28)
        Me.lblAClassroom.TabIndex = 33
        Me.lblAClassroom.Text = "Modify Classroom Details"
        '
        'frmSchedulerMClassroomMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(578, 594)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 650)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 650)
        Me.Name = "frmSchedulerMClassroomMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Academic Timetabling System"
        Me.gbAIntakeMenu.ResumeLayout(False)
        Me.gbAIntakeMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents gbAIntakeMenu As System.Windows.Forms.GroupBox
    Friend WithEvents lblClassroomName As System.Windows.Forms.Label
    Friend WithEvents lblClassroomType As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents cbClassroomType As System.Windows.Forms.ComboBox
    Friend WithEvents txtClassroomName As System.Windows.Forms.TextBox
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblAClassroom As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbClassroomName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbClassroomSize As System.Windows.Forms.ComboBox
    Friend WithEvents txtClassroomID As System.Windows.Forms.TextBox
End Class
