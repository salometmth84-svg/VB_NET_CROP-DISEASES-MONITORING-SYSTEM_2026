<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RecordDiseaseForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecordDiseaseForm))
        pnlTitle = New Panel()
        lblTitle = New Label()
        lblSelectCrop = New Label()
        cmbCrop = New ComboBox()
        lblDiseaseName = New Label()
        txtDiseaseName = New TextBox()
        lblSymptoms = New Label()
        txtSymptoms = New TextBox()
        lblSeverity = New Label()
        cmbSeverity = New ComboBox()
        lblDate = New Label()
        dtpDate = New DateTimePicker()
        btnAddDisease = New Button()
        pnlTitle.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTitle
        ' 
        pnlTitle.BackColor = Color.FromArgb(CByte(45), CByte(106), CByte(45))
        pnlTitle.Controls.Add(lblTitle)
        pnlTitle.Dock = DockStyle.Top
        pnlTitle.Location = New Point(0, 0)
        pnlTitle.Name = "pnlTitle"
        pnlTitle.Size = New Size(555, 50)
        pnlTitle.TabIndex = 11
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Font = New Font("Arial", 13.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(555, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Record Disease"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSelectCrop
        ' 
        lblSelectCrop.AutoSize = True
        lblSelectCrop.Font = New Font("Arial", 10.0F)
        lblSelectCrop.Location = New Point(20, 75)
        lblSelectCrop.Name = "lblSelectCrop"
        lblSelectCrop.Size = New Size(120, 23)
        lblSelectCrop.TabIndex = 10
        lblSelectCrop.Text = "Select Crop:"
        ' 
        ' cmbCrop
        ' 
        cmbCrop.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCrop.Font = New Font("Arial", 10.0F)
        cmbCrop.Location = New Point(150, 72)
        cmbCrop.Name = "cmbCrop"
        cmbCrop.Size = New Size(305, 31)
        cmbCrop.TabIndex = 9
        ' 
        ' lblDiseaseName
        ' 
        lblDiseaseName.AutoSize = True
        lblDiseaseName.Font = New Font("Arial", 10.0F)
        lblDiseaseName.Location = New Point(20, 120)
        lblDiseaseName.Name = "lblDiseaseName"
        lblDiseaseName.Size = New Size(144, 23)
        lblDiseaseName.TabIndex = 8
        lblDiseaseName.Text = "Disease Name:"
        ' 
        ' txtDiseaseName
        ' 
        txtDiseaseName.Font = New Font("Arial", 10.0F)
        txtDiseaseName.Location = New Point(150, 117)
        txtDiseaseName.Name = "txtDiseaseName"
        txtDiseaseName.Size = New Size(305, 30)
        txtDiseaseName.TabIndex = 7
        ' 
        ' lblSymptoms
        ' 
        lblSymptoms.AutoSize = True
        lblSymptoms.Font = New Font("Arial", 10.0F)
        lblSymptoms.Location = New Point(20, 165)
        lblSymptoms.Name = "lblSymptoms"
        lblSymptoms.Size = New Size(109, 23)
        lblSymptoms.TabIndex = 6
        lblSymptoms.Text = "Symptoms:"
        ' 
        ' txtSymptoms
        ' 
        txtSymptoms.Font = New Font("Arial", 10.0F)
        txtSymptoms.Location = New Point(150, 162)
        txtSymptoms.Multiline = True
        txtSymptoms.Name = "txtSymptoms"
        txtSymptoms.Size = New Size(305, 65)
        txtSymptoms.TabIndex = 5
        ' 
        ' lblSeverity
        ' 
        lblSeverity.AutoSize = True
        lblSeverity.Font = New Font("Arial", 10.0F)
        lblSeverity.Location = New Point(20, 248)
        lblSeverity.Name = "lblSeverity"
        lblSeverity.Size = New Size(87, 23)
        lblSeverity.TabIndex = 4
        lblSeverity.Text = "Severity:"
        ' 
        ' cmbSeverity
        ' 
        cmbSeverity.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSeverity.Font = New Font("Arial", 10.0F)
        cmbSeverity.Location = New Point(150, 245)
        cmbSeverity.Name = "cmbSeverity"
        cmbSeverity.Size = New Size(160, 31)
        cmbSeverity.TabIndex = 3
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Arial", 10.0F)
        lblDate.Location = New Point(20, 295)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(58, 23)
        lblDate.TabIndex = 2
        lblDate.Text = "Date:"
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Arial", 10.0F)
        dtpDate.Format = DateTimePickerFormat.Short
        dtpDate.Location = New Point(150, 292)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(200, 30)
        dtpDate.TabIndex = 1
        ' 
        ' btnAddDisease
        ' 
        btnAddDisease.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnAddDisease.FlatAppearance.BorderSize = 0
        btnAddDisease.FlatStyle = FlatStyle.Flat
        btnAddDisease.Font = New Font("Arial", 10.0F, FontStyle.Bold)
        btnAddDisease.ForeColor = Color.White
        btnAddDisease.Location = New Point(180, 345)
        btnAddDisease.Name = "btnAddDisease"
        btnAddDisease.Size = New Size(130, 38)
        btnAddDisease.TabIndex = 0
        btnAddDisease.Text = "Add Disease"
        btnAddDisease.UseVisualStyleBackColor = False
        ' 
        ' RecordDiseaseForm
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(234), CByte(244), CByte(234))
        ClientSize = New Size(555, 410)
        Controls.Add(btnAddDisease)
        Controls.Add(dtpDate)
        Controls.Add(lblDate)
        Controls.Add(cmbSeverity)
        Controls.Add(lblSeverity)
        Controls.Add(txtSymptoms)
        Controls.Add(lblSymptoms)
        Controls.Add(txtDiseaseName)
        Controls.Add(lblDiseaseName)
        Controls.Add(cmbCrop)
        Controls.Add(lblSelectCrop)
        Controls.Add(pnlTitle)
        Font = New Font("Arial", 10.0F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "RecordDiseaseForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Record Disease"
        pnlTitle.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSelectCrop As System.Windows.Forms.Label
    Friend WithEvents cmbCrop As System.Windows.Forms.ComboBox
    Friend WithEvents lblDiseaseName As System.Windows.Forms.Label
    Friend WithEvents txtDiseaseName As System.Windows.Forms.TextBox
    Friend WithEvents lblSymptoms As System.Windows.Forms.Label
    Friend WithEvents txtSymptoms As System.Windows.Forms.TextBox
    Friend WithEvents lblSeverity As System.Windows.Forms.Label
    Friend WithEvents cmbSeverity As System.Windows.Forms.ComboBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAddDisease As System.Windows.Forms.Button

End Class
