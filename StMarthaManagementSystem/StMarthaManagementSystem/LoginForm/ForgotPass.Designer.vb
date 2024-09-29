<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgotPass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.answerBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.questionBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.passwordBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.showPassBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.back_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_bttn = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'answerBox
        '
        Me.answerBox.BorderRadius = 15
        Me.answerBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.answerBox.DefaultText = ""
        Me.answerBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.answerBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.answerBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.answerBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.answerBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.answerBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.answerBox.ForeColor = System.Drawing.Color.Black
        Me.answerBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.answerBox.Location = New System.Drawing.Point(79, 292)
        Me.answerBox.Margin = New System.Windows.Forms.Padding(4)
        Me.answerBox.Name = "answerBox"
        Me.answerBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.answerBox.PlaceholderText = ""
        Me.answerBox.SelectedText = ""
        Me.answerBox.Size = New System.Drawing.Size(294, 36)
        Me.answerBox.TabIndex = 32
        '
        'questionBox
        '
        Me.questionBox.BorderRadius = 15
        Me.questionBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.questionBox.DefaultText = ""
        Me.questionBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.questionBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.questionBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.questionBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.questionBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.questionBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.questionBox.ForeColor = System.Drawing.Color.Black
        Me.questionBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.questionBox.Location = New System.Drawing.Point(79, 219)
        Me.questionBox.Margin = New System.Windows.Forms.Padding(4)
        Me.questionBox.Name = "questionBox"
        Me.questionBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.questionBox.PlaceholderText = ""
        Me.questionBox.SelectedText = ""
        Me.questionBox.Size = New System.Drawing.Size(294, 33)
        Me.questionBox.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 267)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 21)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Answer:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 194)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 21)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Question:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 36)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Hint Password"
        '
        'passwordBox
        '
        Me.passwordBox.BorderRadius = 15
        Me.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordBox.DefaultText = ""
        Me.passwordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.passwordBox.ForeColor = System.Drawing.Color.Black
        Me.passwordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordBox.Location = New System.Drawing.Point(79, 351)
        Me.passwordBox.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.passwordBox.PlaceholderText = ""
        Me.passwordBox.SelectedText = ""
        Me.passwordBox.Size = New System.Drawing.Size(294, 38)
        Me.passwordBox.TabIndex = 34
        '
        'showPassBtn
        '
        Me.showPassBtn.BorderRadius = 15
        Me.showPassBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showPassBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.showPassBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.showPassBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.showPassBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.showPassBtn.FillColor = System.Drawing.SystemColors.MenuHighlight
        Me.showPassBtn.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showPassBtn.ForeColor = System.Drawing.Color.White
        Me.showPassBtn.Location = New System.Drawing.Point(79, 427)
        Me.showPassBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.showPassBtn.Name = "showPassBtn"
        Me.showPassBtn.Size = New System.Drawing.Size(294, 35)
        Me.showPassBtn.TabIndex = 31
        Me.showPassBtn.Text = "Continue"
        '
        'back_bttn
        '
        Me.back_bttn.BorderRadius = 15
        Me.back_bttn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.back_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.back_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.back_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.back_bttn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.back_bttn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.back_bttn.ForeColor = System.Drawing.Color.White
        Me.back_bttn.Location = New System.Drawing.Point(13, 13)
        Me.back_bttn.Margin = New System.Windows.Forms.Padding(4)
        Me.back_bttn.Name = "back_bttn"
        Me.back_bttn.Size = New System.Drawing.Size(87, 32)
        Me.back_bttn.TabIndex = 36
        Me.back_bttn.Text = "Cancel"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.StMarthaManagementSystem.My.Resources.Resources.icons8_answer_58
        Me.PictureBox1.Location = New System.Drawing.Point(185, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'close_bttn
        '
        Me.close_bttn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_bttn.Location = New System.Drawing.Point(370, 13)
        Me.close_bttn.Name = "close_bttn"
        Me.close_bttn.Size = New System.Drawing.Size(32, 25)
        Me.close_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.close_bttn.TabIndex = 37
        Me.close_bttn.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.StMarthaManagementSystem.My.Resources.Resources.lock
        Me.PictureBox2.Location = New System.Drawing.Point(30, 354)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'ForgotPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 528)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.close_bttn)
        Me.Controls.Add(Me.back_bttn)
        Me.Controls.Add(Me.answerBox)
        Me.Controls.Add(Me.questionBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.passwordBox)
        Me.Controls.Add(Me.showPassBtn)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ForgotPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ForgotPass"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents answerBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents questionBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents passwordBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents showPassBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents close_bttn As PictureBox
    Friend WithEvents back_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
