Public Class MainMenuForm

    Private Sub btnAddCrop_Click(sender As Object, e As EventArgs) Handles btnAddCrop.Click
        AddCropForm.Show()
    End Sub

    Private Sub btnRecordDisease_Click(sender As Object, e As EventArgs) Handles btnRecordDisease.Click
        RecordDiseaseForm.Show()
    End Sub

    Private Sub btnViewDiseases_Click(sender As Object, e As EventArgs) Handles btnViewDiseases.Click
        ViewDiseasesForm.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?",
                                     "Logout", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            LoginForm.Show()
            Me.Hide()
        End If
    End Sub

End Class
