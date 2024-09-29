<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewPaymentPlan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.close_bttn = New System.Windows.Forms.PictureBox()
        Me.Home_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.IN_ID = New System.Windows.Forms.TextBox()
        Me.planidM = New System.Windows.Forms.TextBox()
        Me.monthidM = New System.Windows.Forms.TextBox()
        Me.IDM = New System.Windows.Forms.TextBox()
        Me.PlanPaymenDGV = New System.Windows.Forms.DataGridView()
        Me.planPayment_saveBttn = New Guna.UI2.WinForms.Guna2Button()
        Me.CNPlanP_CB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.month_CB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.plandate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.OrNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pdeposit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pbalance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.newbal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.search_box = New Guna.UI2.WinForms.Guna2TextBox()
        Me.refresh_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PlanPaymenDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1200, 41)
        Me.Panel1.TabIndex = 1
        '
        'close_bttn
        '
        Me.close_bttn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_bttn.Dock = System.Windows.Forms.DockStyle.Right
        Me.close_bttn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.close1
        Me.close_bttn.Location = New System.Drawing.Point(1158, 0)
        Me.close_bttn.Name = "close_bttn"
        Me.close_bttn.Size = New System.Drawing.Size(42, 41)
        Me.close_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.close_bttn.TabIndex = 24
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
        Me.Home_bttn.Size = New System.Drawing.Size(222, 41)
        Me.Home_bttn.TabIndex = 23
        Me.Home_bttn.Text = "Dashboard"
        Me.Home_bttn.TextOffset = New System.Drawing.Point(50, 0)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 73)
        Me.Panel2.TabIndex = 325
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Silver
        Me.Guna2HtmlLabel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Candara Light", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(886, 0)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(314, 73)
        Me.Guna2HtmlLabel5.TabIndex = 1
        Me.Guna2HtmlLabel5.Text = "PAYMENT"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Guna2HtmlLabel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Candara", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(889, 73)
        Me.Guna2HtmlLabel4.TabIndex = 0
        Me.Guna2HtmlLabel4.Text = "PLAN INFORMATION"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IN_ID
        '
        Me.IN_ID.Location = New System.Drawing.Point(426, 589)
        Me.IN_ID.Name = "IN_ID"
        Me.IN_ID.Size = New System.Drawing.Size(57, 32)
        Me.IN_ID.TabIndex = 337
        '
        'planidM
        '
        Me.planidM.Location = New System.Drawing.Point(343, 589)
        Me.planidM.Name = "planidM"
        Me.planidM.Size = New System.Drawing.Size(55, 32)
        Me.planidM.TabIndex = 336
        '
        'monthidM
        '
        Me.monthidM.Location = New System.Drawing.Point(265, 589)
        Me.monthidM.Name = "monthidM"
        Me.monthidM.Size = New System.Drawing.Size(57, 32)
        Me.monthidM.TabIndex = 335
        '
        'IDM
        '
        Me.IDM.Location = New System.Drawing.Point(206, 589)
        Me.IDM.Name = "IDM"
        Me.IDM.Size = New System.Drawing.Size(53, 32)
        Me.IDM.TabIndex = 334
        '
        'PlanPaymenDGV
        '
        Me.PlanPaymenDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PlanPaymenDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanPaymenDGV.Location = New System.Drawing.Point(136, 364)
        Me.PlanPaymenDGV.Name = "PlanPaymenDGV"
        Me.PlanPaymenDGV.RowHeadersWidth = 51
        Me.PlanPaymenDGV.RowTemplate.Height = 24
        Me.PlanPaymenDGV.Size = New System.Drawing.Size(907, 206)
        Me.PlanPaymenDGV.TabIndex = 338
        '
        'planPayment_saveBttn
        '
        Me.planPayment_saveBttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.planPayment_saveBttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.planPayment_saveBttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.planPayment_saveBttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.planPayment_saveBttn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.planPayment_saveBttn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.planPayment_saveBttn.ForeColor = System.Drawing.Color.White
        Me.planPayment_saveBttn.Location = New System.Drawing.Point(863, 589)
        Me.planPayment_saveBttn.Name = "planPayment_saveBttn"
        Me.planPayment_saveBttn.Size = New System.Drawing.Size(180, 45)
        Me.planPayment_saveBttn.TabIndex = 339
        Me.planPayment_saveBttn.Text = "Save"
        '
        'CNPlanP_CB
        '
        Me.CNPlanP_CB.BackColor = System.Drawing.Color.Transparent
        Me.CNPlanP_CB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CNPlanP_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CNPlanP_CB.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CNPlanP_CB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CNPlanP_CB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNPlanP_CB.ForeColor = System.Drawing.Color.Black
        Me.CNPlanP_CB.ItemHeight = 30
        Me.CNPlanP_CB.Location = New System.Drawing.Point(136, 143)
        Me.CNPlanP_CB.Name = "CNPlanP_CB"
        Me.CNPlanP_CB.Size = New System.Drawing.Size(445, 36)
        Me.CNPlanP_CB.TabIndex = 347
        '
        'month_CB
        '
        Me.month_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.month_CB.BackColor = System.Drawing.Color.Transparent
        Me.month_CB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.month_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.month_CB.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.month_CB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.month_CB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.month_CB.ForeColor = System.Drawing.Color.Black
        Me.month_CB.ItemHeight = 30
        Me.month_CB.Location = New System.Drawing.Point(610, 143)
        Me.month_CB.Name = "month_CB"
        Me.month_CB.Size = New System.Drawing.Size(184, 36)
        Me.month_CB.TabIndex = 348
        '
        'plandate
        '
        Me.plandate.BackColor = System.Drawing.Color.Transparent
        Me.plandate.Checked = True
        Me.plandate.CustomFormat = "yyyy/MM/dd"
        Me.plandate.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.plandate.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Bold)
        Me.plandate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.plandate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.plandate.Location = New System.Drawing.Point(843, 143)
        Me.plandate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.plandate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.plandate.Name = "plandate"
        Me.plandate.Size = New System.Drawing.Size(228, 41)
        Me.plandate.TabIndex = 349
        Me.plandate.Value = New Date(2022, 11, 22, 16, 42, 24, 410)
        '
        'OrNum
        '
        Me.OrNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OrNum.DefaultText = ""
        Me.OrNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.OrNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.OrNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.OrNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.OrNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OrNum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrNum.ForeColor = System.Drawing.Color.Black
        Me.OrNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OrNum.Location = New System.Drawing.Point(136, 213)
        Me.OrNum.Margin = New System.Windows.Forms.Padding(4)
        Me.OrNum.Name = "OrNum"
        Me.OrNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.OrNum.PlaceholderText = "Or No."
        Me.OrNum.SelectedText = ""
        Me.OrNum.Size = New System.Drawing.Size(208, 51)
        Me.OrNum.TabIndex = 350
        '
        'pdeposit
        '
        Me.pdeposit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pdeposit.DefaultText = ""
        Me.pdeposit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.pdeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pdeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pdeposit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pdeposit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pdeposit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdeposit.ForeColor = System.Drawing.Color.Black
        Me.pdeposit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pdeposit.Location = New System.Drawing.Point(374, 213)
        Me.pdeposit.Margin = New System.Windows.Forms.Padding(4)
        Me.pdeposit.Name = "pdeposit"
        Me.pdeposit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pdeposit.PlaceholderText = "Deposit"
        Me.pdeposit.SelectedText = ""
        Me.pdeposit.Size = New System.Drawing.Size(191, 51)
        Me.pdeposit.TabIndex = 351
        '
        'pbalance
        '
        Me.pbalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pbalance.DefaultText = ""
        Me.pbalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.pbalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pbalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pbalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pbalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pbalance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pbalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pbalance.Location = New System.Drawing.Point(610, 213)
        Me.pbalance.Margin = New System.Windows.Forms.Padding(4)
        Me.pbalance.Name = "pbalance"
        Me.pbalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pbalance.PlaceholderText = "Balance"
        Me.pbalance.SelectedText = ""
        Me.pbalance.Size = New System.Drawing.Size(184, 51)
        Me.pbalance.TabIndex = 352
        '
        'newbal
        '
        Me.newbal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.newbal.DefaultText = ""
        Me.newbal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.newbal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.newbal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newbal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newbal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newbal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newbal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newbal.Location = New System.Drawing.Point(843, 213)
        Me.newbal.Margin = New System.Windows.Forms.Padding(4)
        Me.newbal.Name = "newbal"
        Me.newbal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.newbal.PlaceholderText = "New Balance"
        Me.newbal.SelectedText = ""
        Me.newbal.Size = New System.Drawing.Size(200, 51)
        Me.newbal.TabIndex = 352
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(149, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 31)
        Me.Label1.TabIndex = 360
        Me.Label1.Text = "Client Name"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(146, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 31)
        Me.Label9.TabIndex = 361
        Me.Label9.Text = "OR No."
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(622, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 31)
        Me.Label10.TabIndex = 362
        Me.Label10.Text = "Month"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(397, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 31)
        Me.Label11.TabIndex = 363
        Me.Label11.Text = "Deposit"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(622, 277)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 31)
        Me.Label13.TabIndex = 365
        Me.Label13.Text = "Balance"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(859, 268)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 31)
        Me.Label14.TabIndex = 366
        Me.Label14.Text = "NewBalance"
        '
        'search_box
        '
        Me.search_box.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.search_box.DefaultText = ""
        Me.search_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.search_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.search_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.search_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.search_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search_box.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_box.ForeColor = System.Drawing.Color.Black
        Me.search_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search_box.Location = New System.Drawing.Point(136, 312)
        Me.search_box.Margin = New System.Windows.Forms.Padding(4)
        Me.search_box.Name = "search_box"
        Me.search_box.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.search_box.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.search_box.PlaceholderText = "Search"
        Me.search_box.SelectedText = ""
        Me.search_box.Size = New System.Drawing.Size(283, 48)
        Me.search_box.TabIndex = 367
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
        Me.refresh_bttn.Location = New System.Drawing.Point(880, 311)
        Me.refresh_bttn.Name = "refresh_bttn"
        Me.refresh_bttn.Size = New System.Drawing.Size(163, 46)
        Me.refresh_bttn.TabIndex = 368
        Me.refresh_bttn.Text = "Refresh"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(859, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 31)
        Me.Label2.TabIndex = 369
        Me.Label2.Text = "Date"
        '
        'NewPaymentPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 650)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.refresh_bttn)
        Me.Controls.Add(Me.search_box)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newbal)
        Me.Controls.Add(Me.pbalance)
        Me.Controls.Add(Me.pdeposit)
        Me.Controls.Add(Me.OrNum)
        Me.Controls.Add(Me.plandate)
        Me.Controls.Add(Me.month_CB)
        Me.Controls.Add(Me.CNPlanP_CB)
        Me.Controls.Add(Me.planPayment_saveBttn)
        Me.Controls.Add(Me.PlanPaymenDGV)
        Me.Controls.Add(Me.IN_ID)
        Me.Controls.Add(Me.planidM)
        Me.Controls.Add(Me.monthidM)
        Me.Controls.Add(Me.IDM)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NewPaymentPlan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewPaymentPlan"
        Me.Panel1.ResumeLayout(False)
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PlanPaymenDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents IN_ID As TextBox
    Friend WithEvents planidM As TextBox
    Friend WithEvents monthidM As TextBox
    Friend WithEvents IDM As TextBox
    Friend WithEvents PlanPaymenDGV As DataGridView
    Friend WithEvents planPayment_saveBttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Home_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents close_bttn As PictureBox
    Friend WithEvents CNPlanP_CB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents month_CB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents plandate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents OrNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pdeposit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pbalance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents newbal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents search_box As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents refresh_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
End Class
