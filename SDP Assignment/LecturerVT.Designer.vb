<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLecturerVT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLecturerVT))
        Me.TCAlogo = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.gbWelcome = New System.Windows.Forms.GroupBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbStudentMM = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.btnCAvailability = New System.Windows.Forms.Button()
        Me.btnRequest = New System.Windows.Forms.Button()
        Me.btnVT = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbLecturerName = New System.Windows.Forms.ComboBox()
        Me.lblLecturerName = New System.Windows.Forms.Label()
        Me.btnSearch2 = New System.Windows.Forms.Button()
        Me.lblIntakeCode = New System.Windows.Forms.Label()
        Me.btnSearch1 = New System.Windows.Forms.Button()
        Me.DGVLecturerVT = New System.Windows.Forms.DataGridView()
        Me.cbIntakeCode = New System.Windows.Forms.ComboBox()
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.gbWelcome.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbStudentMM.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVLecturerVT, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TCAlogo.TabIndex = 30
        Me.TCAlogo.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(98, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(242, 80)
        Me.Panel3.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 73)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "View Timetable Menu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 95)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(101, 28)
        Me.lblWelcome.TabIndex = 25
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
        Me.gbWelcome.TabIndex = 26
        Me.gbWelcome.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.PowderBlue
        Me.btnLogout.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(220, 120)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(118, 51)
        Me.btnLogout.TabIndex = 24
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.gbStudentMM)
        Me.Panel1.Location = New System.Drawing.Point(12, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 458)
        Me.Panel1.TabIndex = 27
        '
        'gbStudentMM
        '
        Me.gbStudentMM.BackColor = System.Drawing.Color.Transparent
        Me.gbStudentMM.Controls.Add(Me.btnBack)
        Me.gbStudentMM.Controls.Add(Me.btnFeedback)
        Me.gbStudentMM.Controls.Add(Me.btnCAvailability)
        Me.gbStudentMM.Controls.Add(Me.btnRequest)
        Me.gbStudentMM.Controls.Add(Me.btnVT)
        Me.gbStudentMM.Location = New System.Drawing.Point(11, 3)
        Me.gbStudentMM.Name = "gbStudentMM"
        Me.gbStudentMM.Size = New System.Drawing.Size(307, 445)
        Me.gbStudentMM.TabIndex = 6
        Me.gbStudentMM.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.PowderBlue
        Me.btnBack.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(201, 389)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 49)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnFeedback
        '
        Me.btnFeedback.BackColor = System.Drawing.Color.PowderBlue
        Me.btnFeedback.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeedback.Location = New System.Drawing.Point(6, 313)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(295, 70)
        Me.btnFeedback.TabIndex = 17
        Me.btnFeedback.Text = "Feedback and Comments"
        Me.btnFeedback.UseVisualStyleBackColor = False
        '
        'btnCAvailability
        '
        Me.btnCAvailability.BackColor = System.Drawing.Color.PowderBlue
        Me.btnCAvailability.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCAvailability.Location = New System.Drawing.Point(6, 237)
        Me.btnCAvailability.Name = "btnCAvailability"
        Me.btnCAvailability.Size = New System.Drawing.Size(295, 70)
        Me.btnCAvailability.TabIndex = 16
        Me.btnCAvailability.Text = "Classroom Availability"
        Me.btnCAvailability.UseVisualStyleBackColor = False
        '
        'btnRequest
        '
        Me.btnRequest.BackColor = System.Drawing.Color.PowderBlue
        Me.btnRequest.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequest.Location = New System.Drawing.Point(6, 161)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(295, 70)
        Me.btnRequest.TabIndex = 15
        Me.btnRequest.Text = "Request for Classroom"
        Me.btnRequest.UseVisualStyleBackColor = False
        '
        'btnVT
        '
        Me.btnVT.BackColor = System.Drawing.Color.PowderBlue
        Me.btnVT.Enabled = False
        Me.btnVT.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVT.Location = New System.Drawing.Point(6, 85)
        Me.btnVT.Name = "btnVT"
        Me.btnVT.Size = New System.Drawing.Size(295, 70)
        Me.btnVT.TabIndex = 14
        Me.btnVT.Text = "View Timetable"
        Me.btnVT.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.cbIntakeCode)
        Me.Panel2.Controls.Add(Me.cbLecturerName)
        Me.Panel2.Controls.Add(Me.lblLecturerName)
        Me.Panel2.Controls.Add(Me.btnSearch2)
        Me.Panel2.Controls.Add(Me.lblIntakeCode)
        Me.Panel2.Controls.Add(Me.btnSearch1)
        Me.Panel2.Controls.Add(Me.DGVLecturerVT)
        Me.Panel2.Location = New System.Drawing.Point(346, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(870, 620)
        Me.Panel2.TabIndex = 28
        '
        'cbLecturerName
        '
        Me.cbLecturerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLecturerName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLecturerName.FormattingEnabled = True
        Me.cbLecturerName.Location = New System.Drawing.Point(292, 80)
        Me.cbLecturerName.Name = "cbLecturerName"
        Me.cbLecturerName.Size = New System.Drawing.Size(305, 36)
        Me.cbLecturerName.TabIndex = 28
        '
        'lblLecturerName
        '
        Me.lblLecturerName.AutoSize = True
        Me.lblLecturerName.BackColor = System.Drawing.Color.Transparent
        Me.lblLecturerName.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLecturerName.Location = New System.Drawing.Point(117, 83)
        Me.lblLecturerName.Name = "lblLecturerName"
        Me.lblLecturerName.Size = New System.Drawing.Size(157, 28)
        Me.lblLecturerName.TabIndex = 25
        Me.lblLecturerName.Text = "Lecturer Name: "
        '
        'btnSearch2
        '
        Me.btnSearch2.BackColor = System.Drawing.Color.PowderBlue
        Me.btnSearch2.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch2.Location = New System.Drawing.Point(619, 80)
        Me.btnSearch2.Name = "btnSearch2"
        Me.btnSearch2.Size = New System.Drawing.Size(120, 50)
        Me.btnSearch2.TabIndex = 27
        Me.btnSearch2.Text = "SEARCH"
        Me.btnSearch2.UseVisualStyleBackColor = False
        '
        'lblIntakeCode
        '
        Me.lblIntakeCode.AutoSize = True
        Me.lblIntakeCode.BackColor = System.Drawing.Color.Transparent
        Me.lblIntakeCode.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeCode.Location = New System.Drawing.Point(141, 27)
        Me.lblIntakeCode.Name = "lblIntakeCode"
        Me.lblIntakeCode.Size = New System.Drawing.Size(133, 28)
        Me.lblIntakeCode.TabIndex = 22
        Me.lblIntakeCode.Text = "Intake Code: "
        '
        'btnSearch1
        '
        Me.btnSearch1.BackColor = System.Drawing.Color.PowderBlue
        Me.btnSearch1.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch1.Location = New System.Drawing.Point(619, 24)
        Me.btnSearch1.Name = "btnSearch1"
        Me.btnSearch1.Size = New System.Drawing.Size(120, 50)
        Me.btnSearch1.TabIndex = 24
        Me.btnSearch1.Text = "SEARCH"
        Me.btnSearch1.UseVisualStyleBackColor = False
        '
        'DGVLecturerVT
        '
        Me.DGVLecturerVT.AllowUserToAddRows = False
        Me.DGVLecturerVT.AllowUserToDeleteRows = False
        Me.DGVLecturerVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLecturerVT.Location = New System.Drawing.Point(3, 162)
        Me.DGVLecturerVT.Name = "DGVLecturerVT"
        Me.DGVLecturerVT.RowTemplate.Height = 28
        Me.DGVLecturerVT.Size = New System.Drawing.Size(864, 454)
        Me.DGVLecturerVT.TabIndex = 21
        '
        'cbIntakeCode
        '
        Me.cbIntakeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIntakeCode.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIntakeCode.FormattingEnabled = True
        Me.cbIntakeCode.Location = New System.Drawing.Point(292, 24)
        Me.cbIntakeCode.Name = "cbIntakeCode"
        Me.cbIntakeCode.Size = New System.Drawing.Size(305, 36)
        Me.cbIntakeCode.TabIndex = 29
        '
        'frmLecturerVT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1228, 644)
        Me.Controls.Add(Me.TCAlogo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.gbWelcome)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1250, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1250, 700)
        Me.Name = "frmLecturerVT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Academic Timetabling System"
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.gbWelcome.ResumeLayout(False)
        Me.gbWelcome.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.gbStudentMM.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGVLecturerVT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TCAlogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents gbWelcome As System.Windows.Forms.GroupBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbStudentMM As System.Windows.Forms.GroupBox
    Friend WithEvents btnFeedback As System.Windows.Forms.Button
    Friend WithEvents btnCAvailability As System.Windows.Forms.Button
    Friend WithEvents btnRequest As System.Windows.Forms.Button
    Friend WithEvents btnVT As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents DGVLecturerVT As System.Windows.Forms.DataGridView
    Friend WithEvents lblLecturerName As System.Windows.Forms.Label
    Friend WithEvents btnSearch2 As System.Windows.Forms.Button
    Friend WithEvents lblIntakeCode As System.Windows.Forms.Label
    Friend WithEvents btnSearch1 As System.Windows.Forms.Button
    Friend WithEvents cbLecturerName As System.Windows.Forms.ComboBox
    Friend WithEvents cbIntakeCode As System.Windows.Forms.ComboBox
End Class
