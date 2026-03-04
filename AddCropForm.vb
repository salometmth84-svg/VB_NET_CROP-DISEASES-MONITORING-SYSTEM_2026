Public Class AddCropForm

    Private Sub btnAddCrop_Click(sender As Object, e As EventArgs) Handles btnAddCrop.Click
        Dim cropName As String = txtCropName.Text.Trim()
        Dim farmerName As String = txtFarmerName.Text.Trim()

        If String.IsNullOrEmpty(cropName) Or String.IsNullOrEmpty(farmerName) Then
            MessageBox.Show("Please fill in all fields.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DatabaseHelper.AddCrop(cropName, farmerName)
        MessageBox.Show($"Crop '{cropName}' added successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtCropName.Clear()
        txtFarmerName.Clear()
        txtCropName.Focus()
    End Sub

End Class
