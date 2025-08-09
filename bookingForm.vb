Imports System.Data.SQLite

Public Class bookingForm
    Private userName As String

    ' Constructor to set active user name
    Public Sub New(activeUserName As String)
        Me.userName = activeUserName
        InitializeComponent()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub bookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If Not ValidateInputs() Then Return

        Dim connectionString As String = "Data Source=C:\Users\MY PC\OneDrive\Documents\sem3-LAPTOP-U8UDCC2N-3\301\trainSystem\trainSystem\bin\Debug\dataForTrainDatabase.db"

        If Not System.IO.File.Exists(connectionString.Replace("Data Source=", "")) Then
            MessageBox.Show("Database file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()

                ' Fetch the userName directly without relying on userID
                If Not IsUserNameValid(connection, userName) Then
                    MessageBox.Show("User not found in database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Insert data into userPick table using userName
                Dim bookingQuery As String = "INSERT INTO userPick (userName, departing, goingto, route, typePassager, leavingDate, leavingOption, returnDate, returnOption) " &
                                             "VALUES (@userName, @departing, @goingto, @route, @typePassager, @leavingDate, @leavingOption, @returnDate, @returnOption)"

                Using command As New SQLiteCommand(bookingQuery, connection)
                    command.Parameters.AddWithValue("@userName", userName)
                    command.Parameters.AddWithValue("@departing", cmbDeparting.Text)
                    command.Parameters.AddWithValue("@goingto", cmbGoingto.Text)

                    ' Determine route type (Single or Return)
                    Dim selectedRoute As String = If(radSingle.Checked, "Single", "Return")
                    command.Parameters.AddWithValue("@route", selectedRoute)
                    Dim passengerType As String = ""
                    If radNormal.Checked Then
                        passengerType = "Normal"
                    ElseIf radStudent.Checked Then
                        passengerType = "Student"
                    End If

                    command.Parameters.AddWithValue("@typePassager", passengerType)

                    command.Parameters.AddWithValue("@leavingDate", txtDateLeaving.Text)
                    command.Parameters.AddWithValue("@leavingOption", cmbJourney.Text)

                    ' For return option, check if it's a Return journey
                    If radSingle.Checked Then
                        command.Parameters.AddWithValue("@returnDate", DBNull.Value)
                        command.Parameters.AddWithValue("@returnOption", DBNull.Value)
                    Else
                        command.Parameters.AddWithValue("@returnDate", txtDateReturn.Text)
                        command.Parameters.AddWithValue("@returnOption", cmbJourneyReturn.Text)
                    End If

                    ' Execute the query
                    command.ExecuteNonQuery()

                    MessageBox.Show("Booking has been registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim seatFormInstance As New seatForm(userName)
                    seatFormInstance.Show()
                    Me.Hide()
                End Using

            Catch ex As SQLiteException
                MessageBox.Show($"SQLite Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function IsUserNameValid(connection As SQLiteConnection, userName As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE userName = @userName"
        Using cmd As New SQLiteCommand(query, connection)
            cmd.Parameters.AddWithValue("@userName", userName)
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return result > 0 ' Return true if the user exists
        End Using
    End Function

    Private Function ValidateInputs() As Boolean
        If cmbDeparting.SelectedIndex = -1 OrElse cmbGoingto.SelectedIndex = -1 OrElse cmbJourney.SelectedIndex = -1 Then
            MessageBox.Show("Please ensure all required fields are selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If cmbDeparting.Text = cmbGoingto.Text Then
            MessageBox.Show("Departing and destination locations cannot be the same.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not IsAnyRadioButtonSelected(gbAvoid) Then
            MessageBox.Show("Please select a journey type (Single or Return).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtDateLeaving.Text) Then
            MessageBox.Show("Please select a leaving date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If radReturn.Checked AndAlso String.IsNullOrWhiteSpace(txtDateReturn.Text) Then
            MessageBox.Show("Please select a return date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function IsAnyRadioButtonSelected(groupBox As GroupBox) As Boolean
        For Each control As Control In groupBox.Controls
            If TypeOf control Is RadioButton AndAlso CType(control, RadioButton).Checked Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btnCalendarLeaving_Click(sender As Object, e As EventArgs) Handles btnCalendarLeaving.Click
        MonthCalendar1.Visible = Not MonthCalendar1.Visible
    End Sub

    Private Sub btnCalendarReturn_Click(sender As Object, e As EventArgs) Handles btnCalendarReturn.Click
        MonthCalendar2.Visible = Not MonthCalendar2.Visible
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        txtDateLeaving.Text = e.Start.ToString("yyyy-MM-dd")
        MonthCalendar1.Visible = False
    End Sub

    Private Sub MonthCalendar2_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateSelected
        txtDateReturn.Text = e.Start.ToString("yyyy-MM-dd")
        MonthCalendar2.Visible = False
    End Sub

    Private Sub radSingle_CheckedChanged(sender As Object, e As EventArgs) Handles radSingle.CheckedChanged
        If radSingle.Checked Then gbReturn.Hide()
    End Sub

    Private Sub radReturn_CheckedChanged(sender As Object, e As EventArgs) Handles radReturn.CheckedChanged
        If radReturn.Checked Then gbReturn.Show()
    End Sub

    Private Sub btnGetTime_Click(sender As Object, e As EventArgs) Handles btnGetTime.Click
        Dim ticketFormInstance As New ticketForm()
        ticketFormInstance.Show()
        Me.Hide()
    End Sub


End Class