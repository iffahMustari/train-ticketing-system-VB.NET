Imports System.Data.SQLite

Public Class registerForm

    ' Initialize form and center to screen
    Private Sub registerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        calendarDateOfBirth.Visible = False ' Hide calendar on load
    End Sub

    ' Navigate back to main form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        mainForm.Show()
        Me.Hide()
    End Sub

    ' Register button click
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Validate input fields
        If String.IsNullOrEmpty(txtFirstName.Text) OrElse
           String.IsNullOrEmpty(txtLastName.Text) OrElse
           String.IsNullOrEmpty(txtUsername.Text) OrElse
           String.IsNullOrEmpty(txtPassword.Text) OrElse
           String.IsNullOrEmpty(txtEmail.Text) OrElse
           String.IsNullOrEmpty(txtDateOfBirth.Text) OrElse
           PictureBox3.Image Is Nothing Then

            MessageBox.Show("Please fill all fields and upload a picture.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQLite database connection string
        Dim connectionString As String = "Data Source=C:\Users\MY PC\OneDrive\Documents\sem3-LAPTOP-U8UDCC2N-3\301\trainSystem\trainSystem\bin\Debug\dataForTrainDatabase.db"

        ' Ensure the database file exists
        If Not System.IO.File.Exists(connectionString.Replace("Data Source=", "")) Then
            MessageBox.Show("Database file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()

                ' SQL query to insert data
                Dim query As String = "INSERT INTO Users (firstName, lastName, userName, passWord, email, dateOfBirth, pictureUser) VALUES (@firstName, @lastName, @userName, @passWord, @email, @dateOfBirth, @pictureUser)"

                Using command As New SQLiteCommand(query, connection)
                    ' Add parameters
                    command.Parameters.AddWithValue("@firstName", txtFirstName.Text)
                    command.Parameters.AddWithValue("@lastName", txtLastName.Text)
                    command.Parameters.AddWithValue("@userName", txtUsername.Text)
                    command.Parameters.AddWithValue("@passWord", txtPassword.Text)
                    command.Parameters.AddWithValue("@email", txtEmail.Text)
                    command.Parameters.AddWithValue("@dateOfBirth", txtDateOfBirth.Text)

                    ' Convert image to byte array
                    Dim pictureData As Byte() = ConvertImageToByteArray(PictureBox3.Image)
                    command.Parameters.AddWithValue("@pictureUser", pictureData)

                    ' Execute query
                    command.ExecuteNonQuery()
                    MessageBox.Show("Account has been registered successfully!")

                    loginForm.Show()
                    Me.Hide() ' Hide loginForm
                End Using

            Catch ex As SQLiteException
                MessageBox.Show("SQLite Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Convert image to byte array for storage
    Private Function ConvertImageToByteArray(image As Image) As Byte()
        Using ms As New System.IO.MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

    ' Toggle calendar visibility
    Private Sub btnCalendar_Click(sender As Object, e As EventArgs) Handles btnCalendar.Click
        ' Toggle visibility of the calendar
        If calendarDateOfBirth.Visible = False Then
            calendarDateOfBirth.Visible = True ' Show calendar
        Else
            calendarDateOfBirth.Visible = False ' Hide calendar
        End If
    End Sub

    ' Handle date selection from calendar
    Private Sub calendarDateOfBirth_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendarDateOfBirth.DateChanged
        txtDateOfBirth.Text = e.Start.ToString("yyyy-MM-dd") ' Set the selected date in the textbox
    End Sub

    ' Upload picture
    Private Sub btnAddPicture_Click(sender As Object, e As EventArgs) Handles btnAddPicture.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"

        Try
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                PictureBox3.Image = Image.FromFile(openFileDialog.FileName)
                PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
