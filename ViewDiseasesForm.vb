Public Class ViewDiseasesForm

    Private Sub ViewDiseasesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDiseases()
    End Sub

    Private Sub LoadDiseases()
        Dim dt As DataTable = DatabaseHelper.GetDiseases()
        dgvDiseases.DataSource = dt

        If dgvDiseases.Columns.Count > 0 Then
            dgvDiseases.Columns("ID").HeaderText = "ID"
            dgvDiseases.Columns("CropName").HeaderText = "Crop"
            dgvDiseases.Columns("DiseaseName").HeaderText = "Disease"
            dgvDiseases.Columns("Symptoms").HeaderText = "Symptoms"
            dgvDiseases.Columns("Severity").HeaderText = "Severity"
            dgvDiseases.Columns("DateRecorded").HeaderText = "Date"
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadDiseases()
        MessageBox.Show("Records loaded!", "Done",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
