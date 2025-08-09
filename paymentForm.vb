Imports System.Data.SQLite

Public Class paymentForm
    ' Simpan username aktif yang dihantar dari form sebelumnya
    Private ActiveUserName As String
    ' Constants for price calculations
    Private Const basePrice As Decimal = 50 ' Standard ticket price
    Private Const studentDiscount As Decimal = 0.1 ' 10% discount for students
    Private Const fee As Decimal = 5 ' Fixed fee
    Private Const taxRate As Decimal = 0.06 ' 6% tax

    Public Sub New()
    End Sub

    ' Constructor untuk terima username
    Public Sub New(userName As String)
        InitializeComponent()
        ActiveUserName = userName
    End Sub

    Private Sub paymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        LoadUserEmail()  ' Load the user's email when the payment form loads
        LoadTicketDetails() ' Load ticket details to calculate price
    End Sub

    ' Fungsi untuk ambil email dari Users table
    Private Sub LoadUserEmail()
        Dim connectionString As String = "Data Source=C:\Users\MY PC\OneDrive\Documents\sem3-LAPTOP-U8UDCC2N-3\301\trainSystem\trainSystem\bin\Debug\dataForTrainDatabase.db;"

        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()
                ' Ambil email berdasarkan username dari Users table
                Dim query As String = "SELECT email FROM Users WHERE userName = @userName"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@userName", ActiveUserName)

                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Display email in the label
                            lblUserEmail.Text = "Email: " & reader("email").ToString()
                        Else
                            lblUserEmail.Text = "Email: Not found"
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Fungsi untuk ambil ticket details dan kira harga
    Private Sub LoadTicketDetails()
        Dim connectionString As String = "Data Source=C:\Users\MY PC\OneDrive\Documents\sem3-LAPTOP-U8UDCC2N-3\301\trainSystem\trainSystem\bin\Debug\dataForTrainDatabase.db;"

        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()
                ' Ambil data ticket dari UserSelectedTickets
                Dim query As String = "SELECT price, typePassager FROM UserSelectedTickets WHERE userName = @userName LIMIT 1"

                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@userName", ActiveUserName)

                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Call the method to calculate and display the ticket price
                            CalculateAndDisplayPrice(reader("price"), reader("typePassager").ToString())
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

    ' Fungsi untuk kira harga dan paparkan pada label
    Private Sub CalculateAndDisplayPrice(ticketPrice As Decimal, typePassager As String)
        ' Calculate the base price and apply student discount if necessary
        Dim price As Decimal = ticketPrice
        If typePassager.ToLower() = "student" Then
            price = ticketPrice - (ticketPrice * studentDiscount)
            lblPassengerType.Text = "Student"
        Else
            lblPassengerType.Text = "Normal"
        End If

        ' Add fee and calculate total
        Dim totalWithoutTax As Decimal = price + fee
        Dim tax As Decimal = totalWithoutTax * taxRate
        Dim totalWithTax As Decimal = totalWithoutTax + tax

        ' Update the labels with the calculated values
        lblTotalAmount.Text =  totalWithoutTax.ToString("0.00")
        lblTaxAndFee.Text = "Tax & Fee: RM " & (fee + tax).ToString("0.00")
        lblTotalWithTax.Text = "Total with Tax: RM " & totalWithTax.ToString("0.00")
    End Sub

    ' Event untuk Button Pay - Simpan pembayaran ke table PaymentHistory
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If SavePayment() Then
            MessageBox.Show("Congratulations! Your payment was successful!", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Payment failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Fungsi untuk simpan pembayaran ke dalam table PaymentHistory
    Private Function SavePayment() As Boolean
        Dim connectionString As String = "Data Source=C:\Users\MY PC\OneDrive\Documents\sem3-LAPTOP-U8UDCC2N-3\301\trainSystem\trainSystem\bin\Debug\dataForTrainDatabase.db;"
        Dim success As Boolean = False

        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO PaymentHistory (userName, amountPaid) " &
                                      "VALUES (@userName, @amountPaid)"

                Using command As New SQLiteCommand(query, connection)
                    ' Assign data ke parameter
                    command.Parameters.AddWithValue("@userName", ActiveUserName)
                    command.Parameters.AddWithValue("@amountPaid", Convert.ToDecimal(lblTotalWithTax.Text.Replace("Total with Tax: RM ", "")))

                    command.ExecuteNonQuery()
                    success = True
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return success
    End Function


End Class
