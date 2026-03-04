Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabaseHelper.InitializeDatabase()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String = txtUsername.Text.Trim()
        Dim pass As String = txtPassword.Text

        If String.IsNullOrEmpty(user) Or String.IsNullOrEmpty(pass) Then
            MessageBox.Show("Please enter username and password.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If DatabaseHelper.ValidateLogin(user, pass) Then
            MainMenuForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.",
                            "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
        End If
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) _
                                         Handles lnkRegister.LinkClicked
        RegisterForm.Show()
        Me.Hide()
    End Sub

End Class
