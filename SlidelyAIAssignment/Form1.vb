Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    ' Declare the custom close button as a private member
    Private WithEvents btnCustomClose As Button = New Button()
    Private WithEvents lblTaskInfo As Label = New Label()

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    ' Handle keyboard shortcuts
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateNewSubmission.PerformClick()
        End If
    End Sub

    ' Form load event handler
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        ' Set the Text properties for buttons to display shortcuts
        btnViewSubmissions.Text = "View Submissions (Ctrl+V)"
        btnCreateNewSubmission.Text = "Create New Submission (Ctrl+N)"

        ' Set the BackColor properties for buttons
        btnViewSubmissions.BackColor = Color.Moccasin
        btnCreateNewSubmission.BackColor = Color.SkyBlue

        ' Ensure buttons do not use the default visual style
        btnViewSubmissions.UseVisualStyleBackColor = False
        btnCreateNewSubmission.UseVisualStyleBackColor = False

        ' Increase size of btnViewSubmissions and btnCreateNewSubmission by 40%
        Dim enlargedWidth As Integer = CInt(btnViewSubmissions.Width * 1.4)
        btnViewSubmissions.Size = New Size(enlargedWidth, btnViewSubmissions.Height)
        btnCreateNewSubmission.Size = New Size(enlargedWidth, btnCreateNewSubmission.Height)


        ' Hide the default control box (minimize, maximize, close)
        Me.ControlBox = False

        ' Add a label to display task information below the X button
        With lblTaskInfo
            .Text = "Rahaman, Slidely Task 2 - Slidely Form App"
            .ForeColor = Color.Black
            .Font = New Font("Arial", 8, FontStyle.Regular)
            .AutoSize = True
            ' Adjusted location with top margin and shifted towards the right
            .Location = New Point(Me.ClientSize.Width - .Width - 117, btnCustomClose.Bottom + 20)
        End With
        Me.Controls.Add(lblTaskInfo)

        ' Add a panel to create a blank field on the right side of the form
        Dim blankField As New Panel()
        With blankField
            .BackColor = Me.BackColor ' Set to form's background color
            .Dock = DockStyle.Right
            .Width = 30 ' Adjust width as needed
        End With
        Me.Controls.Add(blankField)

        ' Customize the close button (btnCustomClose)
        With btnCustomClose
            .Text = "X"
            .BackColor = Color.Pink
            .ForeColor = Color.White
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Font = New Font("Microsoft Sans Serif", 12.0!, FontStyle.Bold)
            .Size = New Size(27, 27) ' Adjust size as needed
            .Location = New Point(Me.ClientSize.Width - .Width - blankField.Width - 10, 10) ' Position at top right corner with margin
        End With

        ' Add btnCustomClose to the form's controls
        Me.Controls.Add(btnCustomClose)

        ' Adjust position of View Submissions button
        btnViewSubmissions.Location = New Point(btnViewSubmissions.Location.X, lblTaskInfo.Bottom + 10) ' Adjusted bottom margin

        ' Adjust position of Create New Submission button with margin
        btnCreateNewSubmission.Location = New Point(btnCreateNewSubmission.Location.X, btnViewSubmissions.Bottom + 10) ' Adjusted bottom margin
    End Sub

    ' Custom close button click event handler
    Private Sub btnCustomClose_Click(sender As Object, e As EventArgs) Handles btnCustomClose.Click
        Me.Close()
    End Sub
End Class
