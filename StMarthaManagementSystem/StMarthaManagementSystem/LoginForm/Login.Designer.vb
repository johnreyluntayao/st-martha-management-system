<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.username_tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.password_tb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.forgotPassword_label = New System.Windows.Forms.Label()
        Me.showPassword = New System.Windows.Forms.CheckBox()
        Me.LoginBttn = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.closebutton = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'username_tb
        '
        Me.username_tb.BorderRadius = 10
        Me.username_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username_tb.DefaultText = ""
        Me.username_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.username_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.username_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username_tb.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username_tb.Location = New System.Drawing.Point(558, 192)
        Me.username_tb.Margin = New System.Windows.Forms.Padding(4)
        Me.username_tb.Name = "username_tb"
        Me.username_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username_tb.PlaceholderText = "Username"
        Me.username_tb.SelectedText = ""
        Me.username_tb.Size = New System.Drawing.Size(200, 36)
        Me.username_tb.TabIndex = 4
        '
        'password_tb
        '
        Me.password_tb.BorderRadius = 10
        Me.password_tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password_tb.DefaultText = ""
        Me.password_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.password_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.password_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_tb.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_tb.Location = New System.Drawing.Point(558, 242)
        Me.password_tb.Margin = New System.Windows.Forms.Padding(4)
        Me.password_tb.Name = "password_tb"
        Me.password_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.password_tb.PlaceholderText = "Password"
        Me.password_tb.SelectedText = ""
        Me.password_tb.Size = New System.Drawing.Size(200, 36)
        Me.password_tb.TabIndex = 5
        '
        'forgotPassword_label
        '
        Me.forgotPassword_label.AutoSize = True
        Me.forgotPassword_label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.forgotPassword_label.Font = New System.Drawing.Font("Candara Light", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgotPassword_label.Location = New System.Drawing.Point(558, 286)
        Me.forgotPassword_label.Name = "forgotPassword_label"
        Me.forgotPassword_label.Size = New System.Drawing.Size(83, 13)
        Me.forgotPassword_label.TabIndex = 6
        Me.forgotPassword_label.Text = "Forgot Password?"
        '
        'showPassword
        '
        Me.showPassword.AutoSize = True
        Me.showPassword.Font = New System.Drawing.Font("Candara Light", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showPassword.Location = New System.Drawing.Point(663, 285)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(95, 17)
        Me.showPassword.TabIndex = 7
        Me.showPassword.Text = "Show Password"
        Me.showPassword.UseVisualStyleBackColor = True
        '
        'LoginBttn
        '
        Me.LoginBttn.BorderRadius = 10
        Me.LoginBttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LoginBttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LoginBttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginBttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LoginBttn.FillColor = System.Drawing.SystemColors.HotTrack
        Me.LoginBttn.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LoginBttn.ForeColor = System.Drawing.Color.White
        Me.LoginBttn.Location = New System.Drawing.Point(558, 328)
        Me.LoginBttn.Name = "LoginBttn"
        Me.LoginBttn.Size = New System.Drawing.Size(200, 45)
        Me.LoginBttn.TabIndex = 8
        Me.LoginBttn.Text = "Login"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.StMarthaManagementSystem.My.Resources.Resources.locked
        Me.PictureBox6.Location = New System.Drawing.Point(508, 239)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(43, 41)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 3
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.StMarthaManagementSystem.My.Resources.Resources.settings
        Me.PictureBox5.Location = New System.Drawing.Point(509, 192)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(42, 41)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'closebutton
        '
        Me.closebutton.Image = Global.StMarthaManagementSystem.My.Resources.Resources.close
        Me.closebutton.Location = New System.Drawing.Point(771, 12)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(41, 39)
        Me.closebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closebutton.TabIndex = 1
        Me.closebutton.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.StMarthaManagementSystem.My.Resources.Resources.LoginFormLogo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(460, 504)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(520, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 68)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "         St. Martha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Login
        '
        Me.ClientSize = New System.Drawing.Size(824, 504)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LoginBttn)
        Me.Controls.Add(Me.showPassword)
        Me.Controls.Add(Me.forgotPassword_label)
        Me.Controls.Add(Me.password_tb)
        Me.Controls.Add(Me.username_tb)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.closebutton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents close_bttn As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents userName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents showPass As CheckBox
    Friend WithEvents forgotPassword As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents loginButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents passWord As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents closebutton As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents username_tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents password_tb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents forgotPassword_label As Label
    Friend WithEvents showPassword As CheckBox
    Friend WithEvents LoginBttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
