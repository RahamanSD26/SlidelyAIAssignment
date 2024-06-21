Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private ReadOnly apiUrl As String = "http://localhost:5000/read?index="
    Private currentSubmissionIndex As Integer = 0
    Private submission As ViewSubmission

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' Enable KeyPreview on form load
        Await LoadSubmission(currentSubmissionIndex)
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl & index)
                response.EnsureSuccessStatusCode()

                Dim json As String = Await response.Content.ReadAsStringAsync()
                submission = JsonConvert.DeserializeObject(Of ViewSubmission)(json)

                UpdateUIWithSubmission()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading submission from API: " & ex.Message)
        End Try
    End Function

    Private Sub UpdateUIWithSubmission()
        If submission IsNot Nothing Then
            ' Populate UI elements with submission data
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhoneNumber.Text = submission.Phone
            txtGitHubLink.Text = submission.GitHub_Link
            txtStopwatchTime.Text = submission.Stopwatch_Time ' Assigning directly as string

            ' Set background color of text boxes to grey
            txtName.BackColor = Color.LightGray
            txtEmail.BackColor = Color.LightGray
            txtPhoneNumber.BackColor = Color.LightGray
            txtGitHubLink.BackColor = Color.LightGray
            txtStopwatchTime.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentSubmissionIndex > 0 Then
            currentSubmissionIndex -= 1
            LoadSubmission(currentSubmissionIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentSubmissionIndex += 1
        LoadSubmission(currentSubmissionIndex)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' Handle keyboard shortcuts
    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
            e.Handled = True ' Mark event as handled to prevent further processing
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
            e.Handled = True ' Mark event as handled to prevent further processing
        End If
    End Sub

    ' Increase width of both buttons by 10% on form load
    Private Sub ViewSubmissionsForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim enlargedWidth As Integer = CInt(btnPrevious.Width * 1.1)
        btnPrevious.Width = enlargedWidth
        btnNext.Width = enlargedWidth
    End Sub
End Class

Public Class ViewSubmission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHub_Link As String
    Public Property Stopwatch_Time As String ' Change Stopwatch_Time to String

    ' Constructor to initialize properties
    Public Sub New()
        Me.Name = String.Empty
        Me.Email = String.Empty
        Me.Phone = String.Empty
        Me.GitHub_Link = String.Empty
        Me.Stopwatch_Time = String.Empty ' Initialize as String.Empty
    End Sub
End Class
