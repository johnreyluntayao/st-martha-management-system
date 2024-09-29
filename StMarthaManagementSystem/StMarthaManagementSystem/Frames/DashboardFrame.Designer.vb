<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardFrame
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardFrame))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.regplanclient = New Guna.UI2.WinForms.Guna2Button()
        Me.rregnewclient = New Guna.UI2.WinForms.Guna2Button()
        Me.dashboardnew = New Guna.UI2.WinForms.Guna2Button()
        Me.Logout = New Guna.UI2.WinForms.Guna2Button()
        Me.dashboardcalendarM = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.numbercontract = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Clocktime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.close_bttn = New System.Windows.Forms.PictureBox()
        Me.Guna2GradientPanel3 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.numberplan = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2CircleButton3 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel3.SuspendLayout()
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
        Me.MenuPanel.Controls.Add(Me.Panel3)
        Me.MenuPanel.Controls.Add(Me.Logout)
        Me.MenuPanel.Controls.Add(Me.Panel1)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(262, 725)
        Me.MenuPanel.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel3.Controls.Add(Me.regplanclient)
        Me.Panel3.Controls.Add(Me.rregnewclient)
        Me.Panel3.Controls.Add(Me.dashboardnew)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 130)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(262, 330)
        Me.Panel3.TabIndex = 33
        '
        'regplanclient
        '
        Me.regplanclient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.regplanclient.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.regplanclient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.regplanclient.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.regplanclient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.regplanclient.Dock = System.Windows.Forms.DockStyle.Top
        Me.regplanclient.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.regplanclient.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.regplanclient.ForeColor = System.Drawing.Color.White
        Me.regplanclient.Image = Global.StMarthaManagementSystem.My.Resources.Resources.planning
        Me.regplanclient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.regplanclient.ImageOffset = New System.Drawing.Point(18, 0)
        Me.regplanclient.ImageSize = New System.Drawing.Size(35, 35)
        Me.regplanclient.Location = New System.Drawing.Point(0, 156)
        Me.regplanclient.Name = "regplanclient"
        Me.regplanclient.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.regplanclient.Size = New System.Drawing.Size(262, 78)
        Me.regplanclient.TabIndex = 33
        Me.regplanclient.Text = "Register New Plan"
        Me.regplanclient.TextOffset = New System.Drawing.Point(50, 0)
        '
        'rregnewclient
        '
        Me.rregnewclient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rregnewclient.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.rregnewclient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.rregnewclient.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.rregnewclient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.rregnewclient.Dock = System.Windows.Forms.DockStyle.Top
        Me.rregnewclient.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.rregnewclient.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rregnewclient.ForeColor = System.Drawing.Color.White
        Me.rregnewclient.Image = Global.StMarthaManagementSystem.My.Resources.Resources.user
        Me.rregnewclient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.rregnewclient.ImageOffset = New System.Drawing.Point(18, 0)
        Me.rregnewclient.ImageSize = New System.Drawing.Size(35, 35)
        Me.rregnewclient.Location = New System.Drawing.Point(0, 78)
        Me.rregnewclient.Name = "rregnewclient"
        Me.rregnewclient.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.rregnewclient.Size = New System.Drawing.Size(262, 78)
        Me.rregnewclient.TabIndex = 21
        Me.rregnewclient.Text = "Register New Client"
        Me.rregnewclient.TextOffset = New System.Drawing.Point(50, 0)
        '
        'dashboardnew
        '
        Me.dashboardnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dashboardnew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.dashboardnew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.dashboardnew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.dashboardnew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.dashboardnew.Dock = System.Windows.Forms.DockStyle.Top
        Me.dashboardnew.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.dashboardnew.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold)
        Me.dashboardnew.ForeColor = System.Drawing.Color.White
        Me.dashboardnew.Image = Global.StMarthaManagementSystem.My.Resources.Resources.dashboard
        Me.dashboardnew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.dashboardnew.ImageOffset = New System.Drawing.Point(18, 0)
        Me.dashboardnew.ImageSize = New System.Drawing.Size(35, 35)
        Me.dashboardnew.Location = New System.Drawing.Point(0, 0)
        Me.dashboardnew.Name = "dashboardnew"
        Me.dashboardnew.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.dashboardnew.Size = New System.Drawing.Size(262, 78)
        Me.dashboardnew.TabIndex = 20
        Me.dashboardnew.Text = "Dashboard"
        Me.dashboardnew.TextOffset = New System.Drawing.Point(50, 0)
        '
        'Logout
        '
        Me.Logout.BorderRadius = 10
        Me.Logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Logout.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Logout.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.ForeColor = System.Drawing.Color.White
        Me.Logout.Image = Global.StMarthaManagementSystem.My.Resources.Resources.logout
        Me.Logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Logout.ImageSize = New System.Drawing.Size(30, 30)
        Me.Logout.Location = New System.Drawing.Point(76, 595)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(138, 53)
        Me.Logout.TabIndex = 15
        Me.Logout.Text = "Log Out"
        Me.Logout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dashboardcalendarM
        '
        Me.dashboardcalendarM.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dashboardcalendarM.BorderRadius = 20
        Me.dashboardcalendarM.Checked = True
        Me.dashboardcalendarM.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.dashboardcalendarM.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboardcalendarM.ForeColor = System.Drawing.SystemColors.Control
        Me.dashboardcalendarM.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dashboardcalendarM.Location = New System.Drawing.Point(495, 47)
        Me.dashboardcalendarM.Margin = New System.Windows.Forms.Padding(4)
        Me.dashboardcalendarM.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dashboardcalendarM.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dashboardcalendarM.Name = "dashboardcalendarM"
        Me.dashboardcalendarM.Size = New System.Drawing.Size(352, 44)
        Me.dashboardcalendarM.TabIndex = 1
        Me.dashboardcalendarM.Value = New Date(2022, 12, 9, 0, 0, 0, 0)
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(120, 40)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(264, 39)
        Me.Guna2HtmlLabel2.TabIndex = 0
        Me.Guna2HtmlLabel2.Text = "CONTRACT CLIENT"
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Guna2GradientPanel2.BorderRadius = 10
        Me.Guna2GradientPanel2.Controls.Add(Me.Guna2CircleButton1)
        Me.Guna2GradientPanel2.Controls.Add(Me.numbercontract)
        Me.Guna2GradientPanel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GradientPanel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Guna2GradientPanel2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(409, 309)
        Me.Guna2GradientPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(420, 185)
        Me.Guna2GradientPanel2.TabIndex = 47
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.Image = Global.StMarthaManagementSystem.My.Resources.Resources.customer
        Me.Guna2CircleButton1.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(16, 25)
        Me.Guna2CircleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(84, 81)
        Me.Guna2CircleButton1.TabIndex = 1
        '
        'numbercontract
        '
        Me.numbercontract.BackColor = System.Drawing.Color.Transparent
        Me.numbercontract.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numbercontract.ForeColor = System.Drawing.Color.White
        Me.numbercontract.Location = New System.Drawing.Point(220, 101)
        Me.numbercontract.Margin = New System.Windows.Forms.Padding(4)
        Me.numbercontract.Name = "numbercontract"
        Me.numbercontract.Size = New System.Drawing.Size(28, 53)
        Me.numbercontract.TabIndex = 0
        Me.numbercontract.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Clocktime)
        Me.Panel2.Controls.Add(Me.dashboardcalendarM)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.close_bttn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(262, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1188, 100)
        Me.Panel2.TabIndex = 52
        '
        'Clocktime
        '
        Me.Clocktime.AutoSize = True
        Me.Clocktime.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clocktime.ForeColor = System.Drawing.SystemColors.Control
        Me.Clocktime.Location = New System.Drawing.Point(874, 47)
        Me.Clocktime.Name = "Clocktime"
        Me.Clocktime.Size = New System.Drawing.Size(176, 49)
        Me.Clocktime.TabIndex = 14
        Me.Clocktime.Text = "00:00:00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(41, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 49)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Dashboard"
        '
        'close_bttn
        '
        Me.close_bttn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_bttn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.close1
        Me.close_bttn.Location = New System.Drawing.Point(1148, 3)
        Me.close_bttn.Name = "close_bttn"
        Me.close_bttn.Size = New System.Drawing.Size(34, 30)
        Me.close_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.close_bttn.TabIndex = 12
        Me.close_bttn.TabStop = False
        '
        'Guna2GradientPanel3
        '
        Me.Guna2GradientPanel3.BorderRadius = 10
        Me.Guna2GradientPanel3.Controls.Add(Me.numberplan)
        Me.Guna2GradientPanel3.Controls.Add(Me.Guna2CircleButton3)
        Me.Guna2GradientPanel3.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2GradientPanel3.FillColor = System.Drawing.Color.Maroon
        Me.Guna2GradientPanel3.FillColor2 = System.Drawing.Color.RosyBrown
        Me.Guna2GradientPanel3.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientPanel3.Location = New System.Drawing.Point(875, 309)
        Me.Guna2GradientPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GradientPanel3.Name = "Guna2GradientPanel3"
        Me.Guna2GradientPanel3.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Guna2GradientPanel3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2GradientPanel3.Size = New System.Drawing.Size(409, 185)
        Me.Guna2GradientPanel3.TabIndex = 53
        '
        'numberplan
        '
        Me.numberplan.BackColor = System.Drawing.Color.Transparent
        Me.numberplan.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberplan.ForeColor = System.Drawing.Color.White
        Me.numberplan.Location = New System.Drawing.Point(197, 101)
        Me.numberplan.Margin = New System.Windows.Forms.Padding(4)
        Me.numberplan.Name = "numberplan"
        Me.numberplan.Size = New System.Drawing.Size(28, 53)
        Me.numberplan.TabIndex = 2
        Me.numberplan.Text = "0"
        '
        'Guna2CircleButton3
        '
        Me.Guna2CircleButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton3.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CircleButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton3.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton3.Image = Global.StMarthaManagementSystem.My.Resources.Resources.audience
        Me.Guna2CircleButton3.ImageSize = New System.Drawing.Size(65, 65)
        Me.Guna2CircleButton3.Location = New System.Drawing.Point(31, 26)
        Me.Guna2CircleButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2CircleButton3.Name = "Guna2CircleButton3"
        Me.Guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton3.Size = New System.Drawing.Size(80, 80)
        Me.Guna2CircleButton3.TabIndex = 1
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(142, 40)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(180, 39)
        Me.Guna2HtmlLabel4.TabIndex = 0
        Me.Guna2HtmlLabel4.Text = "CLIENT PLAN"
        '
        'Timer1
        '
        '
        'DashboardFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 725)
        Me.Controls.Add(Me.Guna2GradientPanel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.MenuPanel)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DashboardFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashboardFrame"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel3.ResumeLayout(False)
        Me.Guna2GradientPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents close_bttn As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Logout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents dashboardcalendarM As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents numbercontract As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2GradientPanel3 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2CircleButton3 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents numberplan As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Clocktime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents regplanclient As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents rregnewclient As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dashboardnew As Guna.UI2.WinForms.Guna2Button
End Class
