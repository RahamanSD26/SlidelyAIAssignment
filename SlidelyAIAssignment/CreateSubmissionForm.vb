Imports System.IO
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class CreateSubmissionForm

    Private ReadOnly apiUrl As String = "http://localhost:5000/submit"
    Private startTime As DateTime
    Private isTimerRunning As Boolean = False

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize form with default values or configurations
        txtStopwatchTime.Text = "00:00:00"
        Me.KeyPreview = True ' Enable KeyPreview on form load
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle keyboard shortcut (Ctrl+S) to submit form
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
            e.Handled = True ' Mark event as handled to prevent further processing
        End If

        ' Handle keyboard shortcut (Ctrl+T) to toggle stopwatch
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
            e.Handled = True ' Mark event as handled to prevent further processing
        End If
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If Not isTimerRunning Then
            ' Start the timer
            startTime = DateTime.Now
            Timer1.Start()
            isTimerRunning = True
            btnToggleStopwatch.Text = "Stop"
        Else
            ' Stop the timer
            Timer1.Stop()
            isTimerRunning = False
            btnToggleStopwatch.Text = "Start"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update stopwatch display every tick
        Dim elapsed As TimeSpan = DateTime.Now - startTime
        txtStopwatchTime.Text = $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}"
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Validate if all required fields are filled
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(txtPhoneNumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtGitHubLink.Text) Then
            MessageBox.Show("Please fill in all fields (Name, Email, Phone Number, GitHub Link).", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Prepare data to be submitted
        Dim submissionData As New Dictionary(Of String, Object)()
        submissionData.Add("name", txtName.Text)
        submissionData.Add("email", txtEmail.Text)
        submissionData.Add("phone", txtPhoneNumber.Text)
        submissionData.Add("github_link", txtGitHubLink.Text)

        ' Format stopwatch_time as HH:mm:ss
        Dim elapsed As TimeSpan = DateTime.Now - startTime
        Dim stopwatchTimeFormatted As String = $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}"
        submissionData.Add("stopwatch_time", stopwatchTimeFormatted)

        Try
            ' Example of sending data to backend using HttpClient (make sure to adjust your endpoint)
            Using client As New HttpClient()
                Dim json As String = JsonConvert.SerializeObject(submissionData)
                Dim content As New StringContent(json, System.Text.Encoding.UTF8, "application/json")

                Dim response = client.PostAsync(apiUrl, content).Result
                response.EnsureSuccessStatusCode()

                Dim responseContent = response.Content.ReadAsStringAsync().Result
                MessageBox.Show($"Submission successful! Response: {responseContent}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Close the form after successful submission (optional)
                Me.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error submitting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close the form
        Me.Close()
    End Sub

End Class