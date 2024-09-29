<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPlanRecord
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.close_bttn = New System.Windows.Forms.PictureBox()
        Me.Home_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.search_btn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PlanRecordDGV = New System.Windows.Forms.DataGridView()
        Me.refresh_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PlanRecordDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.close_bttn)
        Me.Panel1.Controls.Add(Me.Home_bttn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 46)
        Me.Panel1.TabIndex = 1
        '
        'close_bttn
        '
        Me.close_bttn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_bttn.Dock = System.Windows.Forms.DockStyle.Right
        Me.close_bttn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.close1
        Me.close_bttn.Location = New System.Drawing.Point(1156, 0)
        Me.close_bttn.Name = "close_bttn"
        Me.close_bttn.Size = New System.Drawing.Size(44, 46)
        Me.close_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.close_bttn.TabIndex = 23
        Me.close_bttn.TabStop = False
        '
        'Home_bttn
        '
        Me.Home_bttn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Home_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Home_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Home_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Home_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Home_bttn.Dock = System.Windows.Forms.DockStyle.Left
        Me.Home_bttn.FillColor = System.Drawing.Color.SteelBlue
        Me.Home_bttn.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Home_bttn.ForeColor = System.Drawing.Color.White
        Me.Home_bttn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.home3
        Me.Home_bttn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Home_bttn.ImageOffset = New System.Drawing.Point(18, 0)
        Me.Home_bttn.ImageSize = New System.Drawing.Size(35, 35)
        Me.Home_bttn.Location = New System.Drawing.Point(0, 0)
        Me.Home_bttn.Name = "Home_bttn"
        Me.Home_bttn.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.Home_bttn.Size = New System.Drawing.Size(222, 46)
        Me.Home_bttn.TabIndex = 22
        Me.Home_bttn.Text = "Dashboard"
        Me.Home_bttn.TextOffset = New System.Drawing.Point(50, 0)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.search_btn)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 46)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1200, 73)
        Me.Panel3.TabIndex = 326
        '
        'search_btn
        '
        Me.search_btn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.search_btn.DefaultText = ""
        Me.search_btn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.search_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.search_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.search_btn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.search_btn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search_btn.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search_btn.Location = New System.Drawing.Point(812, 12)
        Me.search_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.search_btn.PlaceholderText = "Search"
        Me.search_btn.SelectedText = ""
        Me.search_btn.Size = New System.Drawing.Size(346, 46)
        Me.search_btn.TabIndex = 115
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Guna2HtmlLabel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Candara", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(30, 0)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(1170, 73)
        Me.Guna2HtmlLabel5.TabIndex = 1
        Me.Guna2HtmlLabel5.Text = "RECORDS"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Guna2HtmlLabel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Candara", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(39, 73)
        Me.Guna2HtmlLabel4.TabIndex = 0
        Me.Guna2HtmlLabel4.Text = Nothing
        '
        'PlanRecordDGV
        '
        Me.PlanRecordDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanRecordDGV.Location = New System.Drawing.Point(78, 202)
        Me.PlanRecordDGV.Name = "PlanRecordDGV"
        Me.PlanRecordDGV.RowHeadersWidth = 51
        Me.PlanRecordDGV.RowTemplate.Height = 24
        Me.PlanRecordDGV.Size = New System.Drawing.Size(1050, 409)
        Me.PlanRecordDGV.TabIndex = 327
        '
        'refresh_bttn
        '
        Me.refresh_bttn.BorderRadius = 20
        Me.refresh_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.refresh_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.refresh_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.refresh_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.refresh_bttn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.refresh_bttn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.refresh_bttn.ForeColor = System.Drawing.Color.White
        Me.refresh_bttn.Location = New System.Drawing.Point(965, 136)
        Me.refresh_bttn.Name = "refresh_bttn"
        Me.refresh_bttn.Size = New System.Drawing.Size(163, 46)
        Me.refresh_bttn.TabIndex = 328
        Me.refresh_bttn.Text = "Refresh"
        '
        'NewPlanRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 650)
        Me.Controls.Add(Me.refresh_bttn)
        Me.Controls.Add(Me.PlanRecordDGV)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NewPlanRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewPlanRecord"
        Me.Panel1.ResumeLayout(False)
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PlanRecordDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Home_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents search_btn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents close_bttn As PictureBox
    Friend WithEvents PlanRecordDGV As DataGridView
    Friend WithEvents refresh_bttn As Guna.UI2.WinForms.Guna2Button
End Class
