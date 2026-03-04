Public Class RecordDiseaseForm

    Private Sub RecordDiseaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCrops()
        cmbSeverity.Items.AddRange({"Low", "Medium", "High"})
        cmbSeverity.SelectedIndex = 0
    End Sub

    Private Sub LoadCrops()
        Dim dt As DataTable = DatabaseHelper.GetCrops()
        cmbCrop.DataSource = dt
        cmbCrop.DisplayMember = "CropName"
        cmbCrop.ValueMember = "ID"
    End Sub

    Private Sub btnAddDisease_Click(sender As Object, e As EventArgs) Handles btnAddDisease.Click
        If cmbCrop.SelectedIndex = -1 Then
            MessageBox.Show("Please select a crop first. Add crops from the main menu.",
                            "No Crop Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim cropID As Integer = CInt(cmbCrop.SelectedValue)
        Dim diseaseName As String = txtDiseaseName.Text.Trim()
        Dim symptoms As String = txtSymptoms.Text.Trim()
        Dim severity As String = cmbSeverity.SelectedItem.ToString()
        Dim dateRecorded As String = dtpDate.Value.ToString("MM/dd/yyyy")

        If String.IsNullOrEmpty(diseaseName) Then
            MessageBox.Show("Disease name is required.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DatabaseHelper.AddDisease(cropID, diseaseName, symptoms, severity, dateRecorded)
        MessageBox.Show("Disease recorded successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtDiseaseName.Clear()
        txtSymptoms.Clear()
        cmbSeverity.SelectedIndex = 0
    End Sub

    Private Sub RecordDiseaseForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LoadCrops()
    End Sub

End Class
