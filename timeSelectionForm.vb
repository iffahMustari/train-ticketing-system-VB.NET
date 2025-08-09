Imports System.Data.SQLite

Public Class timeSelectionForm
    ' Simpan username aktif
    Private userName As String

    ' Dictionary untuk simpan tempoh perjalanan
    Private stationDurations As New Dictionary(Of String, Integer)

    ' Variable untuk simpan harga yang dipilih
    Private selectedPrice As Decimal = 0

    ' Connection String
    Private connectionString As String = "Data Source=\Users\MY PC\OneDrive\Documents\sem3-LAPTOP-U8UDCC2N-3\301\trainSystem\trainSystem\bin\Debug\dataForTrainDatabase.db"

    ' Constructor untuk menerima username
    Public Sub New(user As String)
        InitializeComponent()
        Me.userName = user
    End Sub

    Private Sub timeSelectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        LoadStationDurations()
        LoadUserRoute()
    End Sub

    ' Fungsi untuk ambil data stesen dari userPick berdasarkan userName
    Private Sub LoadUserRoute()
        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT departing, goingto FROM userPick WHERE userName = @userName"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@userName", userName)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim departing As String = reader("departing").ToString()
                            Dim goingTo As String = reader("goingto").ToString()

                            lblDeparting1.Text = departing
                            lblGoingTo1.Text = goingTo

                            lblDeparting2.Text = lblDeparting1.Text
                            lblGoingTo2.Text = lblGoingTo1.Text

                            lblDeparting3.Text = lblDeparting1.Text
                            lblGoingTo3.Text = lblGoingTo1.Text

                            CalculateArrivalTime(departing, goingTo)
                        Else
                            MessageBox.Show("No route found for this user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Fungsi untuk ambil data tempoh perjalanan dari database
    Private Sub LoadStationDurations()
        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT startStation, endStation, travelTime FROM StationDurations"
                Using command As New SQLiteCommand(query, connection)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim route As String = reader("startStation").ToString() & " - " & reader("endStation").ToString()
                            Dim travelTime As Integer = Convert.ToInt32(reader("travelTime"))
                            stationDurations(route) = travelTime
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Fungsi untuk kira waktu ketibaan dan tempoh perjalanan
    Private Sub CalculateArrivalTime(departing As String, goingTo As String)
        Dim routeKey As String = departing & " - " & goingTo

        If stationDurations.ContainsKey(routeKey) Then
            ' Retrieve the correct travel time
            Dim travelMinutes As Integer = stationDurations(routeKey)

            ' Define departure times
            Dim departureTimes As List(Of DateTime) = New List(Of DateTime) From {
                DateTime.Today.AddHours(12),
                DateTime.Today.AddHours(13),
                DateTime.Today.AddHours(14)
            }

            ' Calculate arrival times and update labels accordingly
            For i As Integer = 0 To departureTimes.Count - 1
                Dim arrivalTime As DateTime = departureTimes(i).AddMinutes(travelMinutes)
                Dim hours As Integer = travelMinutes \ 60
                Dim minutes As Integer = travelMinutes Mod 60

                Select Case i
                    Case 0
                        lblDeparture1.Text = departureTimes(i).ToString("hh:mm tt")
                        lblArrival1.Text = arrivalTime.ToString("hh:mm tt")
                        lblTravelTime1.Text = hours & " hours " & minutes & " minutes"
                    Case 1
                        lblDeparture2.Text = departureTimes(i).ToString("hh:mm tt")
                        lblArrival2.Text = arrivalTime.ToString("hh:mm tt")
                        lblTravelTime2.Text = hours & " hours " & minutes & " minutes"
                    Case 2
                        lblDeparture3.Text = departureTimes(i).ToString("hh:mm tt")
                        lblArrival3.Text = arrivalTime.ToString("hh:mm tt")
                        lblTravelTime3.Text = hours & " hours " & minutes & " minutes"
                End Select
            Next
        Else
            lblArrival1.Text = "No travel data found for this route."
        End If
    End Sub

    ' Fungsi untuk simpan pilihan waktu ke dalam database
    Private Sub SaveUserTimerSelection()
        If selectedPrice = 0 Then
            MessageBox.Show("Please select a price before saving.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()

                ' Get the route and travel time
                Dim routeKey As String = lblDeparting1.Text & " - " & lblGoingTo1.Text
                Dim travelTime As Integer = 0
                If stationDurations.ContainsKey(routeKey) Then
                    travelTime = stationDurations(routeKey)
                End If

                Dim query As String = "INSERT INTO UserTimers (userName, departing, goingTo, selectedDepartureTime, selectedArrivalTime, travelTime, price) " &
                                      "VALUES (@userName, @departing, @goingTo, @selectedDepartureTime, @selectedArrivalTime, @travelTime, @price)"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@userName", userName)
                    command.Parameters.AddWithValue("@departing", lblDeparting1.Text.Replace("Departing 1: ", ""))
                    command.Parameters.AddWithValue("@goingTo", lblGoingTo1.Text.Replace("Destination 1: ", ""))
                    command.Parameters.AddWithValue("@selectedDepartureTime", lblDeparture1.Text.Replace("Departure Time 1: ", ""))
                    command.Parameters.AddWithValue("@selectedArrivalTime", lblArrival1.Text.Replace("Arrival Time 1: ", ""))
                    command.Parameters.AddWithValue("@travelTime", travelTime) ' Use the calculated travel time
                    command.Parameters.AddWithValue("@price", selectedPrice)
                    command.ExecuteNonQuery()
                End Using

                MessageBox.Show("Selection saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving selection: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Fungsi untuk update harga pada label
    Private Sub UpdatePriceLabels()
        lblPrice1.Text = "Price: RM " & selectedPrice.ToString()
        lblPrice2.Text = "Price: RM " & selectedPrice.ToString()
        lblPrice3.Text = "Price: RM " & selectedPrice.ToString()
    End Sub

    ' Event untuk butang Standard
    Private Sub btnStandard_Click(sender As Object, e As EventArgs) Handles btnStandard.Click
        selectedPrice = 50
        UpdatePriceLabels() ' Kemaskini harga pada label
    End Sub

    ' Event untuk butang First Class
    Private Sub btnFirstClass_Click(sender As Object, e As EventArgs) Handles btnFirstClass.Click
        selectedPrice = 100
        UpdatePriceLabels() ' Kemaskini harga pada label
    End Sub

    ' Event untuk butang Save
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveUserTimerSelection()
    End Sub

    ' Event untuk butang Ticket
    Private Sub btnTicket_Click(sender As Object, e As EventArgs) Handles btnTicket.Click
        Dim ticketFormInstance As New ticketForm(userName)
        ticketFormInstance.Show()
        Me.Hide()
    End Sub
End Class