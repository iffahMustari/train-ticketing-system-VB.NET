Imports System.Data.SQLite

Public Class ticketForm
    ' Simpan username aktif yang dihantar dari form sebelum ini
    Private userName As String

    Public Sub New()
    End Sub

    ' Constructor untuk terima username
    Public Sub New(userName As String)
        InitializeComponent()
        Me.userName = userName
    End Sub

    Private Sub ticketForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        LoadUserTicket()
        LoadUserFullName()
    End Sub

    ' Fungsi untuk ambil data dari UserTimers
    Private Sub LoadUserTicket()
        Dim connectionString As String = "Data Source=C:\Users\MY PC\OneDrive\Documents\sem3-LAPTOP-U8UDCC2N-3\301\trainSystem\trainSystem\bin\Debug\dataForTrainDatabase.db;"

        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT departing, goingTo, selectedDepartureTime, selectedArrivalTime, travelTime, price FROM UserTimers WHERE userName = @userName ORDER BY departureIndex LIMIT 1"

                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@userName", userName)

                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            lblDeparting.Text = "Departing: " & reader("departing").ToString()
                            lblGoingTo.Text = "Destination: " & reader("goingTo").ToString()
                            lblDepartureTime.Text = "Departure Time: " & reader("selectedDepartureTime").ToString()
                            lblArrivalTime.Text = "Arrival Time: " & reader("selectedArrivalTime").ToString()

                            ' Betulkan jika arrival lebih awal dari departure
                            Dim departureTime As DateTime = DateTime.Parse(reader("selectedDepartureTime").ToString())
                            Dim arrivalTime As DateTime = DateTime.Parse(reader("selectedArrivalTime").ToString())
                            If arrivalTime < departureTime Then
                                Dim temp = departureTime
                                departureTime = arrivalTime
                                arrivalTime = temp
                            End If
                            lblDepartureTime.Text = "Departure Time: " & departureTime.ToString("hh:mm tt")
                            lblArrivalTime.Text = "Arrival Time: " & arrivalTime.ToString("hh:mm tt")

                            ' Tukar travel duration ke format jam & minit
                            Dim travelTimeMinutes As Integer = Convert.ToInt32(reader("travelTime"))
                            Dim hours As Integer = travelTimeMinutes \ 60
                            Dim minutes As Integer = travelTimeMinutes Mod 60
                            lblTravelTime.Text = $"Travel Duration: {hours} hours {minutes} minutes"

                            lblPrice.Text = "Price: RM " & Convert.ToDecimal(reader("price")).ToString("F2")
                        Else
                            MessageBox.Show("No ticket found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Fungsi untuk ambil full name dari Users table
    Private Sub LoadUserFullName()
        Dim connectionString As String = "Data Source=C:\Users\MY PC\OneDrive\Documents\sem3-LAPTOP-U8UDCC2N-3\301\trainSystem\trainSystem\bin\Debug\dataForTrainDatabase.db;"

        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT firstName, lastName FROM Users WHERE userName = @userName"

                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@userName", userName)

                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            lblFullName.Text = "Name: " & reader("firstName").ToString() & " " & reader("lastName").ToString()
                        Else
                            lblFullName.Text = "Name: Unknown"
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Fungsi untuk simpan tiket yang dipilih ke dalam table UserSelectedTickets
    Private Sub SaveSelectedTicket()
        Dim connectionString As String = "Data Source=C:\Users\MY PC\OneDrive\Documents\sem3-LAPTOP-U8UDCC2N-3\301\trainSystem\trainSystem\bin\Debug\dataForTrainDatabase.db;"

        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO UserSelectedTickets (userName, departing, goingTo, departureTime, arrivalTime, travelTime, price, typePassager) " &
                                      "VALUES (@userName, @departing, @goingTo, @departureTime, @arrivalTime, @travelTime, @price, @typePassager)"

                Using command As New SQLiteCommand(query, connection)
                    ' Assign data ke parameter
                    command.Parameters.AddWithValue("@userName", userName)
                    command.Parameters.AddWithValue("@departing", lblDeparting.Text.Replace("Departing: ", ""))
                    command.Parameters.AddWithValue("@goingTo", lblGoingTo.Text.Replace("Destination: ", ""))
                    command.Parameters.AddWithValue("@departureTime", lblDepartureTime.Text.Replace("Departure Time: ", ""))
                    command.Parameters.AddWithValue("@arrivalTime", lblArrivalTime.Text.Replace("Arrival Time: ", ""))
                    command.Parameters.AddWithValue("@travelTime", lblTravelTime.Text.Replace("Travel Duration: ", "").Replace(" hours", "").Replace(" minutes", ""))
                    command.Parameters.AddWithValue("@price", Convert.ToDecimal(lblPrice.Text.Replace("Price: RM ", "")))

                    ' Get passenger type from userPick table
                    Dim passengerType As String = GetPassengerType()  ' Function to retrieve passengerType from userPick table
                    command.Parameters.AddWithValue("@typePassager", passengerType)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Ticket successfully selected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Fungsi untuk dapatkan typePassager dari table userPick
    Private Function GetPassengerType() As String
        Dim typePassager As String = "Normal" ' Default value

        Dim connectionString As String = "Data Source=C:\Users\MY PC\OneDrive\Documents\sem3-LAPTOP-U8UDCC2N-3\301\trainSystem\trainSystem\bin\Debug\dataForTrainDatabase.db;"

        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT typePassager FROM userPick WHERE userName = @userName LIMIT 1"

                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@userName", userName)

                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            typePassager = reader("typePassager").ToString()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return typePassager
    End Function

    ' Event untuk Button Select - Simpan tiket ke table UserSelectedTickets
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        SaveSelectedTicket()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim paymentFormInstance As New paymentForm(userName)
        paymentFormInstance.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Buka form bookingForm dan hantar ActiveUserName ke form tersebut
        Dim bookingFormInstance As New bookingForm(userName)
        bookingFormInstance.Show()
        Me.Hide()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim connectionString As String = "Data Source=C:\Users\MY PC\OneDrive\Documents\sem3-LAPTOP-U8UDCC2N-3\301\trainSystem\trainSystem\bin\Debug\dataForTrainDatabase.db;"

        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()
                ' Query untuk padam tiket yang dipaparkan berdasarkan username
                Dim query As String = "DELETE FROM UserTimers WHERE userName = @userName AND departing = @departing AND goingTo = @goingTo LIMIT 1"

                Using command As New SQLiteCommand(query, connection)
                    ' Assign parameter untuk query
                    command.Parameters.AddWithValue("@userName", userName)
                    command.Parameters.AddWithValue("@departing", lblDeparting.Text.Replace("Departing: ", ""))
                    command.Parameters.AddWithValue("@goingTo", lblGoingTo.Text.Replace("Destination: ", ""))

                    ' Eksekusi query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Semak jika tiket berjaya dipadam
                    If rowsAffected > 0 Then
                        MessageBox.Show("Ticket successfully removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Reset paparan (atau refresh data)
                        lblDeparting.Text = "Departing: -"
                        lblGoingTo.Text = "Destination: -"
                        lblDepartureTime.Text = "Departure Time: -"
                        lblArrivalTime.Text = "Arrival Time: -"
                        lblTravelTime.Text = "Travel Duration: -"
                        lblPrice.Text = "Price: RM -"
                    Else
                        MessageBox.Show("No matching ticket found to remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


End Class
