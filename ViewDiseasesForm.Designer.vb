<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewDiseasesForm
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
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.dgvDiseases = New System.Windows.Forms.DataGridView()
        Me.pnlTop.SuspendLayout()
        CType(Me.dgvDiseases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' pnlTop
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(45, 106, 45)
        Me.pnlTop.Controls.Add(Me.btnLoad)
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Size = New System.Drawing.Size(800, 50)

        ' lblTitle
        Me.lblTitle.AutoSize = False
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 13, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(650, 50)
        Me.lblTitle.Text = "View Disease Records"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' btnLoad
        Me.btnLoad.Anchor = CType(System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(76, 175, 80)
        Me.btnLoad.FlatAppearance.BorderSize = 0
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnLoad.ForeColor = System.Drawing.Color.White
        Me.btnLoad.Location = New System.Drawing.Point(660, 10)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(128, 30)
        Me.btnLoad.Text = "Load Records"
        Me.btnLoad.UseVisualStyleBackColor = False

        ' dgvDiseases
        Me.dgvDiseases.AllowUserToAddRows = False
        Me.dgvDiseases.AllowUserToDeleteRows = False
        Me.dgvDiseases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDiseases.BackgroundColor = System.Drawing.Color.FromArgb(234, 244, 234)
        Me.dgvDiseases.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 106, 45)
        Me.dgvDiseases.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvDiseases.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.dgvDiseases.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(45, 106, 45)
        Me.dgvDiseases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiseases.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(234, 244, 234)
        Me.dgvDiseases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDiseases.Font = New System.Drawing.Font("Arial", 9)
        Me.dgvDiseases.Name = "dgvDiseases"
        Me.dgvDiseases.ReadOnly = True
        Me.dgvDiseases.RowHeadersVisible = False
        Me.dgvDiseases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect

        ' ViewDiseasesForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(234, 244, 234)
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.dgvDiseases)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Arial", 10)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "ViewDiseasesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Diseases"
        Me.pnlTop.ResumeLayout(False)
        CType(Me.dgvDiseases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents dgvDiseases As System.Windows.Forms.DataGridView

End Class
