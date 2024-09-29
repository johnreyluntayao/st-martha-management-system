<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminInformation
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
        Me.Label17 = New System.Windows.Forms.Label()
        Me.uploadAuthorizedSig_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.save_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.adminName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.adminSigPic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.clientID_TB = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.adminSigPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(181, 291)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(163, 21)
        Me.Label17.TabIndex = 223
        Me.Label17.Text = "Authorized Signature"
        '
        'uploadAuthorizedSig_bttn
        '
        Me.uploadAuthorizedSig_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.uploadAuthorizedSig_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.uploadAuthorizedSig_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.uploadAuthorizedSig_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.uploadAuthorizedSig_bttn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.uploadAuthorizedSig_bttn.Font = New System.Drawing.Font("Candara", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploadAuthorizedSig_bttn.ForeColor = System.Drawing.Color.White
        Me.uploadAuthorizedSig_bttn.Location = New System.Drawing.Point(367, 284)
        Me.uploadAuthorizedSig_bttn.Name = "uploadAuthorizedSig_bttn"
        Me.uploadAuthorizedSig_bttn.Size = New System.Drawing.Size(66, 28)
        Me.uploadAuthorizedSig_bttn.TabIndex = 224
        Me.uploadAuthorizedSig_bttn.Text = "Upload"
        '
        'save_bttn
        '
        Me.save_bttn.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.save_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.save_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.save_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.save_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.save_bttn.FillColor = System.Drawing.Color.LimeGreen
        Me.save_bttn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_bttn.ForeColor = System.Drawing.Color.White
        Me.save_bttn.Location = New System.Drawing.Point(149, 342)
        Me.save_bttn.Name = "save_bttn"
        Me.save_bttn.Size = New System.Drawing.Size(250, 41)
        Me.save_bttn.TabIndex = 306
        Me.save_bttn.Text = "Proceed Payment"
        '
        'adminName
        '
        Me.adminName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.adminName.DefaultText = ""
        Me.adminName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.adminName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.adminName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.adminName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.adminName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.adminName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.adminName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.adminName.Location = New System.Drawing.Point(123, 102)
        Me.adminName.Name = "adminName"
        Me.adminName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.adminName.PlaceholderText = ""
        Me.adminName.SelectedText = ""
        Me.adminName.Size = New System.Drawing.Size(310, 50)
        Me.adminName.TabIndex = 307
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 24)
        Me.Label1.TabIndex = 308
        Me.Label1.Text = "Admin Name:"
        '
        'adminSigPic
        '
        Me.adminSigPic.ImageRotate = 0!
        Me.adminSigPic.Location = New System.Drawing.Point(123, 193)
        Me.adminSigPic.Name = "adminSigPic"
        Me.adminSigPic.Size = New System.Drawing.Size(310, 90)
        Me.adminSigPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.adminSigPic.TabIndex = 225
        Me.adminSigPic.TabStop = False
        '
        'clientID_TB
        '
        Me.clientID_TB.BackColor = System.Drawing.Color.White
        Me.clientID_TB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.clientID_TB.DefaultText = ""
        Me.clientID_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.clientID_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.clientID_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.clientID_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.clientID_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clientID_TB.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.clientID_TB.ForeColor = System.Drawing.Color.Black
        Me.clientID_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clientID_TB.Location = New System.Drawing.Point(414, 13)
        Me.clientID_TB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.clientID_TB.Name = "clientID_TB"
        Me.clientID_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.clientID_TB.PlaceholderText = ""
        Me.clientID_TB.SelectedText = ""
        Me.clientID_TB.Size = New System.Drawing.Size(68, 46)
        Me.clientID_TB.TabIndex = 310
        '
        'AdminInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 424)
        Me.Controls.Add(Me.clientID_TB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.adminName)
        Me.Controls.Add(Me.save_bttn)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.uploadAuthorizedSig_bttn)
        Me.Controls.Add(Me.adminSigPic)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminInformation"
        CType(Me.adminSigPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label17 As Label
    Friend WithEvents uploadAuthorizedSig_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adminSigPic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents save_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adminName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents clientID_TB As Guna.UI2.WinForms.Guna2TextBox
End Class
