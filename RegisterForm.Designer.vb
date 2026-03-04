<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
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
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtNewUsername = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.lnkBackToLogin = New System.Windows.Forms.LinkLabel()
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()

        ' pnlTitle
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(45, 106, 45)
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Size = New System.Drawing.Size(430, 50)

        ' lblTitle
        Me.lblTitle.AutoSize = False
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 13, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Text = "Create Account"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' lblUser
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Arial", 10)
        Me.lblUser.Location = New System.Drawing.Point(25, 75)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Text = "Username:"

        ' txtNewUsername
        Me.txtNewUsername.Font = New System.Drawing.Font("Arial", 10)
        Me.txtNewUsername.Location = New System.Drawing.Point(175, 72)
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.Size = New System.Drawing.Size(220, 26)

        ' lblPass
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Arial", 10)
        Me.lblPass.Location = New System.Drawing.Point(25, 120)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Text = "Password:"

        ' txtNewPassword
        Me.txtNewPassword.Font = New System.Drawing.Font("Arial", 10)
        Me.txtNewPassword.Location = New System.Drawing.Point(175, 117)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = "*"c
        Me.txtNewPassword.Size = New System.Drawing.Size(220, 26)

        ' lblConfirm
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Font = New System.Drawing.Font("Arial", 10)
        Me.lblConfirm.Location = New System.Drawing.Point(25, 165)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Text = "Confirm Password:"

        ' txtConfirmPassword
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Arial", 10)
        Me.txtConfirmPassword.Location = New System.Drawing.Point(175, 162)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = "*"c
        Me.txtConfirmPassword.Size = New System.Drawing.Size(220, 26)

        ' btnRegister
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(76, 175, 80)
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(155, 210)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(120, 38)
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False

        ' lnkBackToLogin
        Me.lnkBackToLogin.Font = New System.Drawing.Font("Arial", 9)
        Me.lnkBackToLogin.Location = New System.Drawing.Point(155, 265)
        Me.lnkBackToLogin.Name = "lnkBackToLogin"
        Me.lnkBackToLogin.Size = New System.Drawing.Size(120, 23)
        Me.lnkBackToLogin.Text = "Back to Login"
        Me.lnkBackToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' RegisterForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(234, 244, 234)
        Me.ClientSize = New System.Drawing.Size(430, 310)
        Me.Controls.Add(Me.lnkBackToLogin)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.txtNewUsername)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.pnlTitle)
        Me.Font = New System.Drawing.Font("Arial", 10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Account"
        Me.pnlTitle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtNewUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents lnkBackToLogin As System.Windows.Forms.LinkLabel

End Class
