<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesReportFrame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesReportFrame))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.salesreport = New Guna.UI2.WinForms.Guna2Button()
        Me.records = New Guna.UI2.WinForms.Guna2Button()
        Me.regnewclient = New Guna.UI2.WinForms.Guna2Button()
        Me.dashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.LogOut = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ContractPrintBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.close_bttn = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(105, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 80)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "St. Martha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Memorial Homes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 130)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MenuPanel
        '
        Me.MenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.MenuPanel.Controls.Add(Me.salesreport)
        Me.MenuPanel.Controls.Add(Me.records)
        Me.MenuPanel.Controls.Add(Me.regnewclient)
        Me.MenuPanel.Controls.Add(Me.dashboard)
        Me.MenuPanel.Controls.Add(Me.LogOut)
        Me.MenuPanel.Controls.Add(Me.Panel1)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(262, 725)
        Me.MenuPanel.TabIndex = 49
        '
        'salesreport
        '
        Me.salesreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.salesreport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.salesreport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.salesreport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.salesreport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.salesreport.Dock = System.Windows.Forms.DockStyle.Top
        Me.salesreport.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.salesreport.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salesreport.ForeColor = System.Drawing.Color.White
        Me.salesreport.Image = Global.StMarthaManagementSystem.My.Resources.Resources.analysis__1_1
        Me.salesreport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.salesreport.ImageOffset = New System.Drawing.Point(18, 0)
        Me.salesreport.ImageSize = New System.Drawing.Size(35, 35)
        Me.salesreport.Location = New System.Drawing.Point(0, 364)
        Me.salesreport.Name = "salesreport"
        Me.salesreport.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.salesreport.Size = New System.Drawing.Size(262, 78)
        Me.salesreport.TabIndex = 23
        Me.salesreport.Text = "Sales Report"
        Me.salesreport.TextOffset = New System.Drawing.Point(50, 0)
        '
        'records
        '
        Me.records.Cursor = System.Windows.Forms.Cursors.Hand
        Me.records.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.records.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.records.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.records.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.records.Dock = System.Windows.Forms.DockStyle.Top
        Me.records.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.records.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.records.ForeColor = System.Drawing.Color.White
        Me.records.Image = Global.StMarthaManagementSystem.My.Resources.Resources.edit1
        Me.records.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.records.ImageOffset = New System.Drawing.Point(18, 0)
        Me.records.ImageSize = New System.Drawing.Size(35, 35)
        Me.records.Location = New System.Drawing.Point(0, 286)
        Me.records.Name = "records"
        Me.records.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.records.Size = New System.Drawing.Size(262, 78)
        Me.records.TabIndex = 22
        Me.records.Text = "Records"
        Me.records.TextOffset = New System.Drawing.Point(50, 0)
        '
        'regnewclient
        '
        Me.regnewclient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.regnewclient.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.regnewclient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.regnewclient.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.regnewclient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.regnewclient.Dock = System.Windows.Forms.DockStyle.Top
        Me.regnewclient.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.regnewclient.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regnewclient.ForeColor = System.Drawing.Color.White
        Me.regnewclient.Image = Global.StMarthaManagementSystem.My.Resources.Resources.user1
        Me.regnewclient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.regnewclient.ImageOffset = New System.Drawing.Point(18, 0)
        Me.regnewclient.ImageSize = New System.Drawing.Size(35, 35)
        Me.regnewclient.Location = New System.Drawing.Point(0, 208)
        Me.regnewclient.Name = "regnewclient"
        Me.regnewclient.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.regnewclient.Size = New System.Drawing.Size(262, 78)
        Me.regnewclient.TabIndex = 20
        Me.regnewclient.Text = "Register New Client"
        Me.regnewclient.TextOffset = New System.Drawing.Point(50, 0)
        '
        'dashboard
        '
        Me.dashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.dashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.dashboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.dashboard.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboard.ForeColor = System.Drawing.Color.White
        Me.dashboard.Image = Global.StMarthaManagementSystem.My.Resources.Resources.dashboard1
        Me.dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.dashboard.ImageOffset = New System.Drawing.Point(18, 0)
        Me.dashboard.ImageSize = New System.Drawing.Size(35, 35)
        Me.dashboard.Location = New System.Drawing.Point(0, 130)
        Me.dashboard.Name = "dashboard"
        Me.dashboard.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.dashboard.Size = New System.Drawing.Size(262, 78)
        Me.dashboard.TabIndex = 19
        Me.dashboard.Text = "Dashboard"
        Me.dashboard.TextOffset = New System.Drawing.Point(50, 0)
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
        Me.LogOut.Image = Global.StMarthaManagementSystem.My.Resources.Resources.logout1
        Me.LogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LogOut.ImageSize = New System.Drawing.Size(30, 30)
        Me.LogOut.Location = New System.Drawing.Point(76, 595)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(138, 53)
        Me.LogOut.TabIndex = 15
        Me.LogOut.Text = "Log Out"
        Me.LogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ContractPrintBtn)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.close_bttn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(262, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1188, 100)
        Me.Panel2.TabIndex = 51
        '
        'ContractPrintBtn
        '
        Me.ContractPrintBtn.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ContractPrintBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ContractPrintBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ContractPrintBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ContractPrintBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ContractPrintBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ContractPrintBtn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.ContractPrintBtn.ForeColor = System.Drawing.Color.Black
        Me.ContractPrintBtn.Location = New System.Drawing.Point(829, 30)
        Me.ContractPrintBtn.Name = "ContractPrintBtn"
        Me.ContractPrintBtn.Size = New System.Drawing.Size(97, 45)
        Me.ContractPrintBtn.TabIndex = 164
        Me.ContractPrintBtn.Text = "Print"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(41, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 49)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sales Report"
        '
        'close_bttn
        '
        Me.close_bttn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_bttn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.close4
        Me.close_bttn.Location = New System.Drawing.Point(934, 0)
        Me.close_bttn.Name = "close_bttn"
        Me.close_bttn.Size = New System.Drawing.Size(34, 30)
        Me.close_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.close_bttn.TabIndex = 50
        Me.close_bttn.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(327, 149)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(850, 509)
        Me.DataGridView1.TabIndex = 52
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'SalesReportFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 725)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuPanel)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SalesReportFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalesReportFrame"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents salesreport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents records As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents regnewclient As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LogOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents close_bttn As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ContractPrintBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
