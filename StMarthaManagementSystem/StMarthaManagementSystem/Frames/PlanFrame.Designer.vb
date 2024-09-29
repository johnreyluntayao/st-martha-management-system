<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlanFrame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlanFrame))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.logOut = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.planrecord_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.planpayment_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.addplann_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.back_bttn = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.logOut)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 725)
        Me.Panel1.TabIndex = 0
        '
        'logOut
        '
        Me.logOut.BorderRadius = 10
        Me.logOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.logOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.logOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.logOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.logOut.FillColor = System.Drawing.Color.CornflowerBlue
        Me.logOut.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOut.ForeColor = System.Drawing.Color.White
        Me.logOut.Image = Global.StMarthaManagementSystem.My.Resources.Resources.logout3
        Me.logOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.logOut.ImageSize = New System.Drawing.Size(30, 30)
        Me.logOut.Location = New System.Drawing.Point(64, 576)
        Me.logOut.Name = "logOut"
        Me.logOut.Size = New System.Drawing.Size(138, 53)
        Me.logOut.TabIndex = 17
        Me.logOut.Text = "Log Out"
        Me.logOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel3.Controls.Add(Me.planrecord_btn)
        Me.Panel3.Controls.Add(Me.planpayment_btn)
        Me.Panel3.Controls.Add(Me.addplann_btn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 130)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(262, 347)
        Me.Panel3.TabIndex = 1
        '
        'planrecord_btn
        '
        Me.planrecord_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.planrecord_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.planrecord_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.planrecord_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.planrecord_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.planrecord_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.planrecord_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.planrecord_btn.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planrecord_btn.ForeColor = System.Drawing.Color.White
        Me.planrecord_btn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.medical_record2
        Me.planrecord_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.planrecord_btn.ImageOffset = New System.Drawing.Point(18, 0)
        Me.planrecord_btn.ImageSize = New System.Drawing.Size(35, 35)
        Me.planrecord_btn.Location = New System.Drawing.Point(0, 156)
        Me.planrecord_btn.Name = "planrecord_btn"
        Me.planrecord_btn.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.planrecord_btn.Size = New System.Drawing.Size(262, 78)
        Me.planrecord_btn.TabIndex = 29
        Me.planrecord_btn.Text = "Records"
        Me.planrecord_btn.TextOffset = New System.Drawing.Point(50, 0)
        '
        'planpayment_btn
        '
        Me.planpayment_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.planpayment_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.planpayment_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.planpayment_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.planpayment_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.planpayment_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.planpayment_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.planpayment_btn.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planpayment_btn.ForeColor = System.Drawing.Color.White
        Me.planpayment_btn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.budget1
        Me.planpayment_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.planpayment_btn.ImageOffset = New System.Drawing.Point(18, 0)
        Me.planpayment_btn.ImageSize = New System.Drawing.Size(35, 35)
        Me.planpayment_btn.Location = New System.Drawing.Point(0, 78)
        Me.planpayment_btn.Name = "planpayment_btn"
        Me.planpayment_btn.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.planpayment_btn.Size = New System.Drawing.Size(262, 78)
        Me.planpayment_btn.TabIndex = 28
        Me.planpayment_btn.Text = "Payment"
        Me.planpayment_btn.TextOffset = New System.Drawing.Point(50, 0)
        '
        'addplann_btn
        '
        Me.addplann_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addplann_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addplann_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addplann_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addplann_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addplann_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.addplann_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.addplann_btn.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addplann_btn.ForeColor = System.Drawing.Color.White
        Me.addplann_btn.Image = Global.StMarthaManagementSystem.My.Resources.Resources._1user
        Me.addplann_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.addplann_btn.ImageOffset = New System.Drawing.Point(18, 0)
        Me.addplann_btn.ImageSize = New System.Drawing.Size(35, 35)
        Me.addplann_btn.Location = New System.Drawing.Point(0, 0)
        Me.addplann_btn.Name = "addplann_btn"
        Me.addplann_btn.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.addplann_btn.Size = New System.Drawing.Size(262, 78)
        Me.addplann_btn.TabIndex = 27
        Me.addplann_btn.Text = "Add Plan"
        Me.addplann_btn.TextOffset = New System.Drawing.Point(50, 0)
        '
        'Panel2
        '
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
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "St. Martha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Memorial Homes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
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
        Me.Panel6.TabIndex = 2
        '
        'back_bttn
        '
        Me.back_bttn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.left_arrow
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
        Me.PictureBox2.Image = Global.StMarthaManagementSystem.My.Resources.Resources.close2
        Me.PictureBox2.Location = New System.Drawing.Point(934, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'contentPanel
        '
        Me.contentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.contentPanel.Location = New System.Drawing.Point(262, 28)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(1188, 672)
        Me.contentPanel.TabIndex = 3
        '
        'PlanFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 725)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PlanFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PlanFrame"
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents planrecord_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents planpayment_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addplann_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents logOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents back_bttn As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents contentPanel As Panel
End Class
