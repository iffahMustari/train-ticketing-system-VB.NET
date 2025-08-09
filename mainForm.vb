Public Class mainForm
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        registerForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        loginForm.Show()
        Me.Hide()
    End Sub
End Class
