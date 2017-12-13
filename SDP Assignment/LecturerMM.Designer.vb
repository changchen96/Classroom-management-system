<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLecturerMM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLecturerMM))
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.gbWelcome = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.TCAlogo = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbStudentMM = New System.Windows.Forms.GroupBox()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.btnCAvailability = New System.Windows.Forms.Button()
        Me.btnRequest = New System.Windows.Forms.Button()
        Me.btnVT = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbWelcome.SuspendLayout()
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbStudentMM.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(6, 22)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(298, 65)
        Me.lblDesc.TabIndex = 10
        Me.lblDesc.Text = "Welcome to the Lecturer Main Menu. What would you like to do?"
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbWelcome
        '
        Me.gbWelcome.BackColor = System.Drawing.Color.DarkCyan
        Me.gbWelcome.Controls.Add(Me.lblName)
        Me.gbWelcome.Location = New System.Drawing.Point(12, 120)
        Me.gbWelcome.Name = "gbWelcome"
        Me.gbWelcome.Size = New System.Drawing.Size(202, 51)
        Me.gbWelcome.TabIndex = 16
        Me.gbWelcome.TabStop = False
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
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.PowderBlue
        Me.btnLogout.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(220, 120)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(118, 51)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'TCAlogo
        '
        Me.TCAlogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TCAlogo.Image = CType(resources.GetObject("TCAlogo.Image"), System.Drawing.Image)
        Me.TCAlogo.Location = New System.Drawing.Point(12, 12)
        Me.TCAlogo.Name = "TCAlogo"
        Me.TCAlogo.Size = New System.Drawing.Size(80, 80)
        Me.TCAlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TCAlogo.TabIndex = 20
        Me.TCAlogo.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 95)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(101, 28)
        Me.lblWelcome.TabIndex = 15
        Me.lblWelcome.Text = "Welcome,"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(98, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(242, 80)
        Me.Panel3.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 80)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Lecturer Main Menu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.gbStudentMM)
        Me.Panel1.Location = New System.Drawing.Point(12, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 458)
        Me.Panel1.TabIndex = 17
        '
        'gbStudentMM
        '
        Me.gbStudentMM.BackColor = System.Drawing.Color.Transparent
        Me.gbStudentMM.Controls.Add(Me.btnFeedback)
        Me.gbStudentMM.Controls.Add(Me.btnCAvailability)
        Me.gbStudentMM.Controls.Add(Me.btnRequest)
        Me.gbStudentMM.Controls.Add(Me.btnVT)
        Me.gbStudentMM.Controls.Add(Me.lblDesc)
        Me.gbStudentMM.Location = New System.Drawing.Point(11, 3)
        Me.gbStudentMM.Name = "gbStudentMM"
        Me.gbStudentMM.Size = New System.Drawing.Size(307, 440)
        Me.gbStudentMM.TabIndex = 6
        Me.gbStudentMM.TabStop = False
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
        Me.Panel2.Location = New System.Drawing.Point(346, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(720, 620)
        Me.Panel2.TabIndex = 18
        '
        'frmLecturerMM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1078, 644)
        Me.Controls.Add(Me.gbWelcome)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.TCAlogo)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1100, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1100, 700)
        Me.Name = "frmLecturerMM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Academic Timetabling System"
        Me.gbWelcome.ResumeLayout(False)
        Me.gbWelcome.PerformLayout()
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.gbStudentMM.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents gbWelcome As System.Windows.Forms.GroupBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents TCAlogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbStudentMM As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnFeedback As System.Windows.Forms.Button
    Friend WithEvents btnCAvailability As System.Windows.Forms.Button
    Friend WithEvents btnRequest As System.Windows.Forms.Button
    Friend WithEvents btnVT As System.Windows.Forms.Button
End Class
