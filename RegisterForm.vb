Public Class RegisterForm

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim user As String = txtNewUsername.Text.Trim()
        Dim pass As String = txtNewPassword.Text
        Dim confirm As String = txtConfirmPassword.Text

        If String.IsNullOrEmpty(user) Or String.IsNullOrEmpty(pass) Then
            MessageBox.Show("All fields are required.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If pass <> confirm Then
            MessageBox.Show("Passwords do not match.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtConfirmPassword.Clear()
            Return
        End If

        If pass.Length < 6 Then
            MessageBox.Show("Password must be at least 6 characters.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim success As Boolean = DatabaseHelper.RegisterUser(user, pass)

        If success Then
            MessageBox.Show("Account created successfully! Please login.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoginForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Username already exists. Choose another.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lnkBackToLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) _
                                            Handles lnkBackToLogin.LinkClicked
        LoginForm.Show()
        Me.Close()
    End Sub

End Class
