﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentFeedback
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentFeedback))
        Me.lblFeedback = New System.Windows.Forms.Label()
        Me.gbFeedback = New System.Windows.Forms.GroupBox()
        Me.txtFeedback = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRequest = New System.Windows.Forms.Button()
        Me.btnVT = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbFeedback.SuspendLayout()
        Me.gbWelcome.SuspendLayout()
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbStudentMM.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFeedback
        '
        Me.lblFeedback.AutoSize = True
        Me.lblFeedback.BackColor = System.Drawing.Color.Transparent
        Me.lblFeedback.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedback.Location = New System.Drawing.Point(30, 52)
        Me.lblFeedback.Name = "lblFeedback"
        Me.lblFeedback.Size = New System.Drawing.Size(274, 28)
        Me.lblFeedback.TabIndex = 9
        Me.lblFeedback.Text = "FEEDBACK AND COMMENTS:"
        '
        'gbFeedback
        '
        Me.gbFeedback.BackColor = System.Drawing.Color.Transparent
        Me.gbFeedback.Controls.Add(Me.txtFeedback)
        Me.gbFeedback.Location = New System.Drawing.Point(35, 184)
        Me.gbFeedback.Name = "gbFeedback"
        Me.gbFeedback.Size = New System.Drawing.Size(650, 288)
        Me.gbFeedback.TabIndex = 10
        Me.gbFeedback.TabStop = False
        '
        'txtFeedback
        '
        Me.txtFeedback.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeedback.Location = New System.Drawing.Point(6, 25)
        Me.txtFeedback.Multiline = True
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFeedback.Size = New System.Drawing.Size(638, 257)
        Me.txtFeedback.TabIndex = 12
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.PowderBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(565, 497)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(120, 49)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(30, 108)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(655, 73)
        Me.lblDesc.TabIndex = 12
        Me.lblDesc.Text = "Please do fill in your feedback or comments down below regarding the facilities o" & _
    "r any problems you faced in The Creative Academy."
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
        Me.btnLogout.TabIndex = 23
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
        Me.TCAlogo.TabIndex = 29
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
        Me.lblWelcome.TabIndex = 24
        Me.lblWelcome.Text = "Welcome,"
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
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 80)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Feedback and Comments Menu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.gbStudentMM)
        Me.Panel1.Location = New System.Drawing.Point(12, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 458)
        Me.Panel1.TabIndex = 26
        '
        'gbStudentMM
        '
        Me.gbStudentMM.BackColor = System.Drawing.Color.Transparent
        Me.gbStudentMM.Controls.Add(Me.btnBack)
        Me.gbStudentMM.Controls.Add(Me.btnRequest)
        Me.gbStudentMM.Controls.Add(Me.btnVT)
        Me.gbStudentMM.Controls.Add(Me.btnFeedback)
        Me.gbStudentMM.Location = New System.Drawing.Point(11, 3)
        Me.gbStudentMM.Name = "gbStudentMM"
        Me.gbStudentMM.Size = New System.Drawing.Size(307, 440)
        Me.gbStudentMM.TabIndex = 6
        Me.gbStudentMM.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.PowderBlue
        Me.btnBack.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(201, 385)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 49)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnRequest
        '
        Me.btnRequest.BackColor = System.Drawing.Color.PowderBlue
        Me.btnRequest.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequest.Location = New System.Drawing.Point(6, 161)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(293, 70)
        Me.btnRequest.TabIndex = 1
        Me.btnRequest.Text = "Request for Classroom"
        Me.btnRequest.UseVisualStyleBackColor = False
        '
        'btnVT
        '
        Me.btnVT.BackColor = System.Drawing.Color.PowderBlue
        Me.btnVT.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVT.Location = New System.Drawing.Point(6, 85)
        Me.btnVT.Name = "btnVT"
        Me.btnVT.Size = New System.Drawing.Size(293, 70)
        Me.btnVT.TabIndex = 0
        Me.btnVT.Text = "View Timetable"
        Me.btnVT.UseVisualStyleBackColor = False
        '
        'btnFeedback
        '
        Me.btnFeedback.BackColor = System.Drawing.Color.PowderBlue
        Me.btnFeedback.Enabled = False
        Me.btnFeedback.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeedback.Location = New System.Drawing.Point(6, 237)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(293, 70)
        Me.btnFeedback.TabIndex = 2
        Me.btnFeedback.Text = "Feedback and Comments"
        Me.btnFeedback.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.lblDesc)
        Me.Panel2.Controls.Add(Me.gbFeedback)
        Me.Panel2.Controls.Add(Me.btnSubmit)
        Me.Panel2.Controls.Add(Me.lblFeedback)
        Me.Panel2.Location = New System.Drawing.Point(346, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(720, 620)
        Me.Panel2.TabIndex = 27
        '
        'frmStudentFeedback
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
        Me.Name = "frmStudentFeedback"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Academic Timetabling System"
        Me.gbFeedback.ResumeLayout(False)
        Me.gbFeedback.PerformLayout()
        Me.gbWelcome.ResumeLayout(False)
        Me.gbWelcome.PerformLayout()
        CType(Me.TCAlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.gbStudentMM.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFeedback As System.Windows.Forms.Label
    Friend WithEvents gbFeedback As System.Windows.Forms.GroupBox
    Friend WithEvents txtFeedback As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
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
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnRequest As System.Windows.Forms.Button
    Friend WithEvents btnVT As System.Windows.Forms.Button
    Friend WithEvents btnFeedback As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
