Imports System.Data.SQLite
Imports System.IO

Public Class homeForm
    Private Sub homeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    ' Fungsi untuk memuatkan maklumat pengguna
    Private Sub LoadUserDetails(userName As String)
        Dim connectionString As String = "Data Source=C:\Users\MY PC\OneDrive\Documents\sem3-LAPTOP-U8UDCC2N-3\301\trainSystem\trainSystem\bin\Debug\dataForTrainDatabase.db"

        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT firstName, lastName FROM Users WHERE userName = @userName"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@userName", userName)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            Dim firstName As String = reader("firstName").ToString()
                            Dim lastName As String = reader("lastName").ToString()
                            MessageBox.Show("Hello, " & firstName & " " & lastName, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnMainForm_Click(sender As Object, e As EventArgs) Handles btnMainForm.Click
        Dim mainFormInstance As New mainForm()
        mainFormInstance.Show()
        Me.Hide()
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        If String.IsNullOrEmpty(txtUsername.Text) OrElse String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Please enter both Username and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connectionString As String = "Data Source=C:\Users\MY PC\OneDrive\Documents\sem3-LAPTOP-U8UDCC2N-3\301\trainSystem\trainSystem\bin\Debug\dataForTrainDatabase.db"

        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT firstName, lastName FROM Users WHERE userName = @userName AND passWord = @passWord"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@userName", txtUsername.Text)
                    command.Parameters.AddWithValue("@passWord", txtPassword.Text)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            Dim firstName As String = reader("firstName").ToString()
                            Dim lastName As String = reader("lastName").ToString()
                            MessageBox.Show("Welcome, " & firstName & " " & lastName & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadUserDetails(txtUsername.Text)
                            Dim bookingFormInstance As New bookingForm(txtUsername.Text)
                            bookingFormInstance.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnMyTrip_Click(sender As Object, e As EventArgs) Handles btnMyTrip.Click
        Try
            Dim ticketFormInstance As New ticketForm(txtUsername.Text)
            ticketFormInstance.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error opening ticket form: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
