<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtGitHubLink = New System.Windows.Forms.TextBox()
        Me.txtStopwatchTime = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblGitHubLink = New System.Windows.Forms.Label()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        ' txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 22)
        Me.txtName.TabIndex = 0
        '
        ' txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 90)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 22)
        Me.txtEmail.TabIndex = 1
        '
        ' txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(150, 130)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(200, 22)
        Me.txtPhoneNumber.TabIndex = 2
        '
        ' txtGitHubLink
        '
        Me.txtGitHubLink.Location = New System.Drawing.Point(150, 170)
        Me.txtGitHubLink.Name = "txtGitHubLink"
        Me.txtGitHubLink.Size = New System.Drawing.Size(200, 22)
        Me.txtGitHubLink.TabIndex = 3
        '
        ' txtStopwatchTime
        '
        Me.txtStopwatchTime.BackColor = System.Drawing.Color.White
        Me.txtStopwatchTime.Location = New System.Drawing.Point(150, 210)
        Me.txtStopwatchTime.Name = "txtStopwatchTime"
        Me.txtStopwatchTime.ReadOnly = True
        Me.txtStopwatchTime.Size = New System.Drawing.Size(100, 22)
        Me.txtStopwatchTime.TabIndex = 4
        Me.txtStopwatchTime.Text = "00:00:00"
        '
        ' btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSubmit.Location = New System.Drawing.Point(150, 260)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 50)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit (Ctrl+S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '

        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(300, 15)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Rahaman Slidely - Task2 CreateSubmission"
        '
        ' lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(50, 50)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 17)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name:"
        '
        ' lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(50, 90)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(46, 17)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email:"
        '
        ' lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(50, 130)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(49, 17)
        Me.lblPhoneNumber.TabIndex = 10
        Me.lblPhoneNumber.Text = "Phone:"
        '
        ' lblGitHubLink
        '
        Me.lblGitHubLink.AutoSize = True
        Me.lblGitHubLink.Location = New System.Drawing.Point(50, 170)
        Me.lblGitHubLink.Name = "lblGitHubLink"
        Me.lblGitHubLink.Size = New System.Drawing.Size(87, 17)
        Me.lblGitHubLink.TabIndex = 11
        Me.lblGitHubLink.Text = "GitHub Link:"
        '
        ' btnToggleStopwatch
        '
        Me.btnToggleStopwatch.BackColor = System.Drawing.Color.Moccasin
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(50, 210)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(98, 30)
        Me.btnToggleStopwatch.TabIndex = 12
        Me.btnToggleStopwatch.Text = "TSW(Ctrl+T)"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = False
        '
        ' Timer1
        '
        Me.Timer1.Interval = 1000
        '
        ' CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 320)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.lblGitHubLink)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtStopwatchTime)
        Me.Controls.Add(Me.txtGitHubLink)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "Create Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents Timer1 As Timer
End Class
