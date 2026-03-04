<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenuForm
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
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAddCrop = New System.Windows.Forms.Button()
        Me.btnRecordDisease = New System.Windows.Forms.Button()
        Me.btnViewDiseases = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()

        ' pnlTitle
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(45, 106, 45)
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Size = New System.Drawing.Size(380, 55)

        ' lblTitle
        Me.lblTitle.AutoSize = False
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 13, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Text = "Main Menu"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' btnAddCrop
        Me.btnAddCrop.BackColor = System.Drawing.Color.FromArgb(245, 215, 138)
        Me.btnAddCrop.FlatAppearance.BorderSize = 0
        Me.btnAddCrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCrop.Font = New System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold)
        Me.btnAddCrop.Location = New System.Drawing.Point(90, 80)
        Me.btnAddCrop.Name = "btnAddCrop"
        Me.btnAddCrop.Size = New System.Drawing.Size(200, 50)
        Me.btnAddCrop.Text = "Add Crop"
        Me.btnAddCrop.UseVisualStyleBackColor = False

        ' btnRecordDisease
        Me.btnRecordDisease.BackColor = System.Drawing.Color.FromArgb(76, 175, 80)
        Me.btnRecordDisease.FlatAppearance.BorderSize = 0
        Me.btnRecordDisease.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecordDisease.Font = New System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold)
        Me.btnRecordDisease.ForeColor = System.Drawing.Color.White
        Me.btnRecordDisease.Location = New System.Drawing.Point(90, 148)
        Me.btnRecordDisease.Name = "btnRecordDisease"
        Me.btnRecordDisease.Size = New System.Drawing.Size(200, 50)
        Me.btnRecordDisease.Text = "Record Disease"
        Me.btnRecordDisease.UseVisualStyleBackColor = False

        ' btnViewDiseases
        Me.btnViewDiseases.BackColor = System.Drawing.Color.FromArgb(76, 175, 80)
        Me.btnViewDiseases.FlatAppearance.BorderSize = 0
        Me.btnViewDiseases.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewDiseases.Font = New System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold)
        Me.btnViewDiseases.ForeColor = System.Drawing.Color.White
        Me.btnViewDiseases.Location = New System.Drawing.Point(90, 216)
        Me.btnViewDiseases.Name = "btnViewDiseases"
        Me.btnViewDiseases.Size = New System.Drawing.Size(200, 50)
        Me.btnViewDiseases.Text = "View Diseases"
        Me.btnViewDiseases.UseVisualStyleBackColor = False

        ' btnLogout
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(211, 211, 211)
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold)
        Me.btnLogout.Location = New System.Drawing.Point(115, 290)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(150, 45)
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False

        ' MainMenuForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(234, 244, 234)
        Me.ClientSize = New System.Drawing.Size(380, 360)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnViewDiseases)
        Me.Controls.Add(Me.btnRecordDisease)
        Me.Controls.Add(Me.btnAddCrop)
        Me.Controls.Add(Me.pnlTitle)
        Me.Font = New System.Drawing.Font("Arial", 10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.pnlTitle.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnAddCrop As System.Windows.Forms.Button
    Friend WithEvents btnRecordDisease As System.Windows.Forms.Button
    Friend WithEvents btnViewDiseases As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button

End Class
