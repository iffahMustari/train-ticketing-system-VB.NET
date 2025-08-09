Imports System.Data.SQLite
Imports System.IO

Public Class loginForm
    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validate input fields
        If String.IsNullOrEmpty(txtUsername.Text) OrElse String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Please enter both Username and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Connection string to SQLite database
        Dim connectionString As String = "Data Source=C:\Users\MY PC\OneDrive\Documents\sem3-LAPTOP-U8UDCC2N-3\301\trainSystem\trainSystem\bin\Debug\dataForTrainDatabase.db"

        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()

                ' SQL query to check if username and password exist in Users table
                Dim query As String = "SELECT firstName, lastName, pictureUser FROM Users WHERE userName = @userName AND passWord = @passWord"

                Using command As New SQLiteCommand(query, connection)
                    ' Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@userName", txtUsername.Text)
                    command.Parameters.AddWithValue("@passWord", txtPassword.Text)

                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()

                            ' Get user's first and last name
                            Dim firstName As String = reader("firstName").ToString()
                            Dim lastName As String = reader("lastName").ToString()

                            ' Display a welcome message
                            MessageBox.Show("Welcome, " & firstName & " " & lastName & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Load user's picture
                            If Not IsDBNull(reader("pictureUser")) Then
                                Dim pictureData As Byte() = DirectCast(reader("pictureUser"), Byte())
                                PictureBox1.Image = ByteArrayToImage(pictureData)
                                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                            Else
                                PictureBox1.Image = Nothing ' Clear the PictureBox if no image
                            End If

                            ' Start Timer for delay
                            Timer1.Interval = 2000 ' 2 seconds
                            Timer1.Start()
                        Else
                            ' Login failed
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Convert byte array to image
    Private Function ByteArrayToImage(byteArray As Byte()) As Image
        Using ms As New MemoryStream(byteArray)
            Return Image.FromStream(ms)
        End Using
    End Function

    ' Navigate to mainForm after delay
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop() ' Stop Timer after it ticks
        homeForm.Show() ' Show mainForm
        Me.Hide() ' Hide loginForm
    End Sub
End Class

