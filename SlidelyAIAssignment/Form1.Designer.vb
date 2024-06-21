<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.btnCreateNewSubmission = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.BackColor = System.Drawing.Color.Moccasin
        Me.btnViewSubmissions.Location = New System.Drawing.Point(38, 41)
        Me.btnViewSubmissions.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(112, 41)
        Me.btnViewSubmissions.TabIndex = 0
        Me.btnViewSubmissions.Text = "View Submissions (Ctrl+V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = False
        '
        'btnCreateNewSubmission
        '
        Me.btnCreateNewSubmission.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCreateNewSubmission.Location = New System.Drawing.Point(38, 98)
        Me.btnCreateNewSubmission.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        Me.btnCreateNewSubmission.Size = New System.Drawing.Size(112, 41)
        Me.btnCreateNewSubmission.TabIndex = 1
        Me.btnCreateNewSubmission.Text = "Create New Submission (Ctrl+N)"
        Me.btnCreateNewSubmission.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 163)
        Me.Controls.Add(Me.btnCreateNewSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle ' Optional: Prevents resizing
        Me.MaximizeBox = False ' Optional: Disables maximize button
        Me.MinimizeBox = False ' Optional: Disables minimize button
        Me.Name = "Form1"
        Me.Text = "Submission Management"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateNewSubmission As Button
End Class
