Imports System.Data.SQLite

Public Class seatForm

    ' Store the active username (from bookingForm)
    Private userName As String

    ' Default constructor
    Public Sub New()
    End Sub

    ' Constructor that receives the username from another form
    Public Sub New(userName As String)
        InitializeComponent()
        Me.userName = userName
    End Sub

    ' Center the form on the screen when it loads
    Private Sub seatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    ' Navigate back to the booking form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim bookingFormInstance As New bookingForm(userName) ' Pass userName to the previous form
        bookingFormInstance.Show()
        Me.Hide() ' Hide the current form, instead of Dispose
    End Sub

    ' Save seating preferences
    Private Sub btnSavePreferences_Click(sender As Object, e As EventArgs) Handles btnSavePreferences.Click
        ' Validate input
        If Not ValidatePreferences() Then
            Return
        End If

        ' Connection string (fix path)
        Dim connectionString As String = "Data Source=C:\Users\MY PC\OneDrive\Documents\sem3-LAPTOP-U8UDCC2N-3\301\trainSystem\trainSystem\bin\Debug\dataForTrainDatabase.db"

        ' Establish SQLite connection
        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()

                ' Insert into seatpreferences table
                Dim query As String = "INSERT INTO seatpreferences (direction, position, coachType, addoptions, userName) " &
                                      "VALUES (@direction, @position, @coachType, @addoptions, @userName)"
                Using command As New SQLiteCommand(query, connection)
                    ' Add parameters for the query
                    command.Parameters.AddWithValue("@direction", cmbDirection.SelectedItem.ToString())
                    command.Parameters.AddWithValue("@position", cmbPosition.SelectedItem.ToString())
                    command.Parameters.AddWithValue("@coachType", cmbCoachType.SelectedItem.ToString())
                    command.Parameters.AddWithValue("@addoptions", GetSelectedOptions())
                    command.Parameters.AddWithValue("@userName", userName)

                    ' Execute the query
                    command.ExecuteNonQuery()
                    MessageBox.Show($"Preferences saved successfully for user: {userName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

                ' Navigate to the timeSelectionForm
                Dim timeSelectionFormInstance As New timeSelectionForm(userName)
                timeSelectionFormInstance.Show()
                Me.Hide()

            Catch ex As SQLiteException
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Validate that all preferences are selected
    Private Function ValidatePreferences() As Boolean
        If cmbDirection.SelectedItem Is Nothing OrElse cmbPosition.SelectedItem Is Nothing OrElse cmbCoachType.SelectedItem Is Nothing Then
            MessageBox.Show("Please select all preferences before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    ' Collect selected options from CheckBoxes
    Private Function GetSelectedOptions() As String
        ' Check if any checkboxes are selected, if not return an empty string
        Dim selectedOptions = gbOptions.Controls.OfType(Of CheckBox)().Where(Function(cb) cb.Checked).Select(Function(cb) cb.Text).ToList()
        If selectedOptions.Any() Then
            Return String.Join(", ", selectedOptions)
        Else
            Return "None" ' Optional, depending on what you want to store for no extra options
        End If
    End Function

End Class
