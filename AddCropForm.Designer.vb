<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddCropForm
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
        Me.lblCropName = New System.Windows.Forms.Label()
        Me.txtCropName = New System.Windows.Forms.TextBox()
        Me.lblFarmerName = New System.Windows.Forms.Label()
        Me.txtFarmerName = New System.Windows.Forms.TextBox()
        Me.btnAddCrop = New System.Windows.Forms.Button()
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()

        ' pnlTitle
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(45, 106, 45)
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Size = New System.Drawing.Size(440, 50)

        ' lblTitle
        Me.lblTitle.AutoSize = False
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 13, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Text = "Add Crop"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' lblCropName
        Me.lblCropName.AutoSize = True
        Me.lblCropName.Font = New System.Drawing.Font("Arial", 10)
        Me.lblCropName.Location = New System.Drawing.Point(25, 80)
        Me.lblCropName.Name = "lblCropName"
        Me.lblCropName.Text = "Crop Name:"

        ' txtCropName
        Me.txtCropName.Font = New System.Drawing.Font("Arial", 10)
        Me.txtCropName.Location = New System.Drawing.Point(150, 77)
        Me.txtCropName.Name = "txtCropName"
        Me.txtCropName.Size = New System.Drawing.Size(255, 26)

        ' lblFarmerName
        Me.lblFarmerName.AutoSize = True
        Me.lblFarmerName.Font = New System.Drawing.Font("Arial", 10)
        Me.lblFarmerName.Location = New System.Drawing.Point(25, 130)
        Me.lblFarmerName.Name = "lblFarmerName"
        Me.lblFarmerName.Text = "Farmer Name:"

        ' txtFarmerName
        Me.txtFarmerName.Font = New System.Drawing.Font("Arial", 10)
        Me.txtFarmerName.Location = New System.Drawing.Point(150, 127)
        Me.txtFarmerName.Name = "txtFarmerName"
        Me.txtFarmerName.Size = New System.Drawing.Size(255, 26)

        ' btnAddCrop
        Me.btnAddCrop.BackColor = System.Drawing.Color.FromArgb(76, 175, 80)
        Me.btnAddCrop.FlatAppearance.BorderSize = 0
        Me.btnAddCrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCrop.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnAddCrop.ForeColor = System.Drawing.Color.White
        Me.btnAddCrop.Location = New System.Drawing.Point(165, 180)
        Me.btnAddCrop.Name = "btnAddCrop"
        Me.btnAddCrop.Size = New System.Drawing.Size(120, 38)
        Me.btnAddCrop.Text = "Add Crop"
        Me.btnAddCrop.UseVisualStyleBackColor = False

        ' AddCropForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(234, 244, 234)
        Me.ClientSize = New System.Drawing.Size(440, 245)
        Me.Controls.Add(Me.btnAddCrop)
        Me.Controls.Add(Me.txtFarmerName)
        Me.Controls.Add(Me.lblFarmerName)
        Me.Controls.Add(Me.txtCropName)
        Me.Controls.Add(Me.lblCropName)
        Me.Controls.Add(Me.pnlTitle)
        Me.Font = New System.Drawing.Font("Arial", 10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AddCropForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Crop"
        Me.pnlTitle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCropName As System.Windows.Forms.Label
    Friend WithEvents txtCropName As System.Windows.Forms.TextBox
    Friend WithEvents lblFarmerName As System.Windows.Forms.Label
    Friend WithEvents txtFarmerName As System.Windows.Forms.TextBox
    Friend WithEvents btnAddCrop As System.Windows.Forms.Button

End Class
