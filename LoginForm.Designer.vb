<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        pnlTitle = New Panel()
        lblTitle = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        btnLogin = New Button()
        lnkRegister = New LinkLabel()
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
        pnlTitle.Size = New Size(1173, 55)
        pnlTitle.TabIndex = 6
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Font = New Font("Arial", 13.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(1173, 55)
        lblTitle.TabIndex = 0
        lblTitle.Text = "CROP DISEASE MONITORING SYSTEM"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Arial", 10.0F)
        lblUsername.Location = New Point(305, 300)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(105, 23)
        lblUsername.TabIndex = 5
        lblUsername.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Arial", 10.0F)
        txtUsername.Location = New Point(502, 293)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(230, 30)
        txtUsername.TabIndex = 4
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Arial", 10.0F)
        lblPassword.Location = New Point(306, 374)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(104, 23)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Arial", 10.0F)
        txtPassword.Location = New Point(502, 371)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(230, 30)
        txtPassword.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Arial", 10.0F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(534, 443)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(120, 38)
        btnLogin.TabIndex = 1
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lnkRegister
        ' 
        lnkRegister.Font = New Font("Arial", 9.0F)
        lnkRegister.Location = New Point(452, 527)
        lnkRegister.Name = "lnkRegister"
        lnkRegister.Size = New Size(295, 23)
        lnkRegister.TabIndex = 0
        lnkRegister.TabStop = True
        lnkRegister.Text = "Don't have an account? Register"
        lnkRegister.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(234), CByte(244), CByte(234))
        ClientSize = New Size(1173, 661)
        Controls.Add(lnkRegister)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblUsername)
        Controls.Add(pnlTitle)
        Font = New Font("Arial", 10.0F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Crop Disease Monitoring System"
        pnlTitle.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lnkRegister As System.Windows.Forms.LinkLabel

End Class
