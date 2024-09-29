<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordFrame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecordFrame))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LogOut = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.planPprec_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.planrec_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.contractprec_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.contractrec_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.clientrec_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.back_bttn = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.back_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 725)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel4.Controls.Add(Me.LogOut)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 594)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(262, 131)
        Me.Panel4.TabIndex = 2
        '
        'LogOut
        '
        Me.LogOut.BorderRadius = 10
        Me.LogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LogOut.FillColor = System.Drawing.Color.CornflowerBlue
        Me.LogOut.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.ForeColor = System.Drawing.Color.White
        Me.LogOut.Image = Global.StMarthaManagementSystem.My.Resources.Resources.logout2
        Me.LogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LogOut.ImageSize = New System.Drawing.Size(30, 30)
        Me.LogOut.Location = New System.Drawing.Point(62, 39)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(138, 53)
        Me.LogOut.TabIndex = 16
        Me.LogOut.Text = "Log Out"
        Me.LogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.Controls.Add(Me.planPprec_btn)
        Me.Panel3.Controls.Add(Me.planrec_btn)
        Me.Panel3.Controls.Add(Me.contractprec_btn)
        Me.Panel3.Controls.Add(Me.contractrec_btn)
        Me.Panel3.Controls.Add(Me.clientrec_btn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 130)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(262, 391)
        Me.Panel3.TabIndex = 1
        '
        'planPprec_btn
        '
        Me.planPprec_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.planPprec_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.planPprec_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.planPprec_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.planPprec_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.planPprec_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.planPprec_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.planPprec_btn.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planPprec_btn.ForeColor = System.Drawing.Color.White
        Me.planPprec_btn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.folder__1_
        Me.planPprec_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.planPprec_btn.ImageOffset = New System.Drawing.Point(18, 0)
        Me.planPprec_btn.ImageSize = New System.Drawing.Size(35, 35)
        Me.planPprec_btn.Location = New System.Drawing.Point(0, 312)
        Me.planPprec_btn.Name = "planPprec_btn"
        Me.planPprec_btn.Padding = New System.Windows.Forms.Padding(60, 10, 0, 0)
        Me.planPprec_btn.Size = New System.Drawing.Size(262, 78)
        Me.planPprec_btn.TabIndex = 28
        Me.planPprec_btn.Text = "Plan Payment Records"
        Me.planPprec_btn.TextOffset = New System.Drawing.Point(10, 0)
        '
        'planrec_btn
        '
        Me.planrec_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.planrec_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.planrec_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.planrec_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.planrec_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.planrec_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.planrec_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.planrec_btn.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planrec_btn.ForeColor = System.Drawing.Color.White
        Me.planrec_btn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.medical_file
        Me.planrec_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.planrec_btn.ImageOffset = New System.Drawing.Point(18, 0)
        Me.planrec_btn.ImageSize = New System.Drawing.Size(35, 35)
        Me.planrec_btn.Location = New System.Drawing.Point(0, 234)
        Me.planrec_btn.Name = "planrec_btn"
        Me.planrec_btn.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.planrec_btn.Size = New System.Drawing.Size(262, 78)
        Me.planrec_btn.TabIndex = 27
        Me.planrec_btn.Text = "Plan Records"
        Me.planrec_btn.TextOffset = New System.Drawing.Point(50, 0)
        '
        'contractprec_btn
        '
        Me.contractprec_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.contractprec_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.contractprec_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.contractprec_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.contractprec_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.contractprec_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.contractprec_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.contractprec_btn.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contractprec_btn.ForeColor = System.Drawing.Color.White
        Me.contractprec_btn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.folder
        Me.contractprec_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.contractprec_btn.ImageOffset = New System.Drawing.Point(18, 0)
        Me.contractprec_btn.ImageSize = New System.Drawing.Size(35, 35)
        Me.contractprec_btn.Location = New System.Drawing.Point(0, 156)
        Me.contractprec_btn.Name = "contractprec_btn"
        Me.contractprec_btn.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.contractprec_btn.Size = New System.Drawing.Size(262, 78)
        Me.contractprec_btn.TabIndex = 26
        Me.contractprec_btn.Text = "Contract Payment  Records"
        Me.contractprec_btn.TextOffset = New System.Drawing.Point(50, 0)
        '
        'contractrec_btn
        '
        Me.contractrec_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.contractrec_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.contractrec_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.contractrec_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.contractrec_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.contractrec_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.contractrec_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.contractrec_btn.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contractrec_btn.ForeColor = System.Drawing.Color.White
        Me.contractrec_btn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.medical_record1
        Me.contractrec_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.contractrec_btn.ImageOffset = New System.Drawing.Point(18, 0)
        Me.contractrec_btn.ImageSize = New System.Drawing.Size(35, 35)
        Me.contractrec_btn.Location = New System.Drawing.Point(0, 78)
        Me.contractrec_btn.Name = "contractrec_btn"
        Me.contractrec_btn.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.contractrec_btn.Size = New System.Drawing.Size(262, 78)
        Me.contractrec_btn.TabIndex = 25
        Me.contractrec_btn.Text = "Contract Records"
        Me.contractrec_btn.TextOffset = New System.Drawing.Point(50, 0)
        '
        'clientrec_btn
        '
        Me.clientrec_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clientrec_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.clientrec_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.clientrec_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.clientrec_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.clientrec_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.clientrec_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.clientrec_btn.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.clientrec_btn.ForeColor = System.Drawing.Color.White
        Me.clientrec_btn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.personal_information
        Me.clientrec_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.clientrec_btn.ImageOffset = New System.Drawing.Point(18, 0)
        Me.clientrec_btn.ImageSize = New System.Drawing.Size(35, 35)
        Me.clientrec_btn.Location = New System.Drawing.Point(0, 0)
        Me.clientrec_btn.Name = "clientrec_btn"
        Me.clientrec_btn.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.clientrec_btn.Size = New System.Drawing.Size(262, 78)
        Me.clientrec_btn.TabIndex = 24
        Me.clientrec_btn.Text = "Client Records"
        Me.clientrec_btn.TextOffset = New System.Drawing.Point(50, 0)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 130)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(105, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 80)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "St. Martha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Memorial Homes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'contentPanel
        '
        Me.contentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.contentPanel.Location = New System.Drawing.Point(262, 53)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(1188, 672)
        Me.contentPanel.TabIndex = 8
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel6.Controls.Add(Me.back_bttn)
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(262, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1188, 28)
        Me.Panel6.TabIndex = 9
        '
        'back_bttn
        '
        Me.back_bttn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.left_arrow1
        Me.back_bttn.Location = New System.Drawing.Point(0, 0)
        Me.back_bttn.Name = "back_bttn"
        Me.back_bttn.Size = New System.Drawing.Size(31, 25)
        Me.back_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.back_bttn.TabIndex = 25
        Me.back_bttn.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.StMarthaManagementSystem.My.Resources.Resources.close3
        Me.PictureBox2.Location = New System.Drawing.Point(934, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'RecordFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 725)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RecordFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RecordFrame"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.back_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LogOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents planPprec_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents planrec_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents contractprec_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents contractrec_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clientrec_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents contentPanel As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents back_bttn As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
