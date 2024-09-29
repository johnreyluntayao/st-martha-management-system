<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateNewPlanForm
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.plantclient_ID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Age = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.plangrossprice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.planname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.planinstallment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.plannamekintrustee = New Guna.UI2.WinForms.Guna2TextBox()
        Me.planaddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.planclientname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.plansaveupdate_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.plandate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.planduedate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radfemale = New System.Windows.Forms.RadioButton()
        Me.radmale = New System.Windows.Forms.RadioButton()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.planterm = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Panel1.TabIndex = 2
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
        Me.Panel2.Controls.Add(Me.plantclient_ID)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 73)
        Me.Panel2.TabIndex = 326
        '
        'plantclient_ID
        '
        Me.plantclient_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.plantclient_ID.DefaultText = ""
        Me.plantclient_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.plantclient_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.plantclient_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.plantclient_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.plantclient_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plantclient_ID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.plantclient_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plantclient_ID.Location = New System.Drawing.Point(1099, 21)
        Me.plantclient_ID.Name = "plantclient_ID"
        Me.plantclient_ID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.plantclient_ID.PlaceholderText = ""
        Me.plantclient_ID.SelectedText = ""
        Me.plantclient_ID.Size = New System.Drawing.Size(76, 36)
        Me.plantclient_ID.TabIndex = 2
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Guna2HtmlLabel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Candara Light", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(834, 0)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(366, 73)
        Me.Guna2HtmlLabel5.TabIndex = 1
        Me.Guna2HtmlLabel5.Text = Nothing
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
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(836, 73)
        Me.Guna2HtmlLabel4.TabIndex = 0
        Me.Guna2HtmlLabel4.Text = "UPDATE PLAN INFORMATION"
        '
        'Age
        '
        Me.Age.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Age.DefaultText = ""
        Me.Age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Age.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Age.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Age.ForeColor = System.Drawing.Color.Black
        Me.Age.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Age.Location = New System.Drawing.Point(894, 229)
        Me.Age.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Age.Name = "Age"
        Me.Age.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Age.PlaceholderText = "Age"
        Me.Age.SelectedText = ""
        Me.Age.Size = New System.Drawing.Size(190, 54)
        Me.Age.TabIndex = 348
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(909, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 24)
        Me.Label1.TabIndex = 347
        Me.Label1.Text = "Age"
        '
        'plangrossprice
        '
        Me.plangrossprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.plangrossprice.DefaultText = ""
        Me.plangrossprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.plangrossprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.plangrossprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.plangrossprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.plangrossprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plangrossprice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plangrossprice.ForeColor = System.Drawing.Color.Black
        Me.plangrossprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plangrossprice.Location = New System.Drawing.Point(530, 412)
        Me.plangrossprice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.plangrossprice.Name = "plangrossprice"
        Me.plangrossprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.plangrossprice.PlaceholderText = "Gross Price"
        Me.plangrossprice.SelectedText = ""
        Me.plangrossprice.Size = New System.Drawing.Size(252, 54)
        Me.plangrossprice.TabIndex = 346
        '
        'planname
        '
        Me.planname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.planname.DefaultText = ""
        Me.planname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.planname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.planname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.planname.ForeColor = System.Drawing.Color.Black
        Me.planname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planname.Location = New System.Drawing.Point(165, 412)
        Me.planname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.planname.Name = "planname"
        Me.planname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.planname.PlaceholderText = "Plan Name"
        Me.planname.SelectedText = ""
        Me.planname.Size = New System.Drawing.Size(316, 54)
        Me.planname.TabIndex = 345
        '
        'planinstallment
        '
        Me.planinstallment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.planinstallment.DefaultText = ""
        Me.planinstallment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.planinstallment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.planinstallment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planinstallment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planinstallment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planinstallment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planinstallment.ForeColor = System.Drawing.Color.Black
        Me.planinstallment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planinstallment.Location = New System.Drawing.Point(163, 502)
        Me.planinstallment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.planinstallment.Name = "planinstallment"
        Me.planinstallment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.planinstallment.PlaceholderText = "Install Payment"
        Me.planinstallment.SelectedText = ""
        Me.planinstallment.Size = New System.Drawing.Size(189, 54)
        Me.planinstallment.TabIndex = 344
        '
        'plannamekintrustee
        '
        Me.plannamekintrustee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.plannamekintrustee.DefaultText = ""
        Me.plannamekintrustee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.plannamekintrustee.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.plannamekintrustee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.plannamekintrustee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.plannamekintrustee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plannamekintrustee.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plannamekintrustee.ForeColor = System.Drawing.Color.Black
        Me.plannamekintrustee.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plannamekintrustee.Location = New System.Drawing.Point(165, 327)
        Me.plannamekintrustee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.plannamekintrustee.Name = "plannamekintrustee"
        Me.plannamekintrustee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.plannamekintrustee.PlaceholderText = "Name of Kin/Trustee"
        Me.plannamekintrustee.SelectedText = ""
        Me.plannamekintrustee.Size = New System.Drawing.Size(617, 54)
        Me.plannamekintrustee.TabIndex = 343
        '
        'planaddress
        '
        Me.planaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.planaddress.DefaultText = ""
        Me.planaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.planaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.planaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planaddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planaddress.ForeColor = System.Drawing.Color.Black
        Me.planaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planaddress.Location = New System.Drawing.Point(165, 229)
        Me.planaddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.planaddress.Name = "planaddress"
        Me.planaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.planaddress.PlaceholderText = "Contract Address"
        Me.planaddress.SelectedText = ""
        Me.planaddress.Size = New System.Drawing.Size(619, 54)
        Me.planaddress.TabIndex = 342
        '
        'planclientname
        '
        Me.planclientname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.planclientname.DefaultText = ""
        Me.planclientname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.planclientname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.planclientname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planclientname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planclientname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planclientname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planclientname.ForeColor = System.Drawing.Color.Black
        Me.planclientname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planclientname.Location = New System.Drawing.Point(163, 131)
        Me.planclientname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.planclientname.Name = "planclientname"
        Me.planclientname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.planclientname.PlaceholderText = "Client Name"
        Me.planclientname.SelectedText = ""
        Me.planclientname.Size = New System.Drawing.Size(619, 54)
        Me.planclientname.TabIndex = 341
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(617, 561)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 24)
        Me.Label11.TabIndex = 339
        Me.Label11.Text = "Due Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(394, 561)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 24)
        Me.Label9.TabIndex = 340
        Me.Label9.Text = "Term"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(526, 475)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 24)
        Me.Label4.TabIndex = 338
        Me.Label4.Text = "Gross Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(909, 385)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 24)
        Me.Label8.TabIndex = 337
        Me.Label8.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(140, 559)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 24)
        Me.Label5.TabIndex = 336
        Me.Label5.Text = "Installment Payment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(161, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 24)
        Me.Label7.TabIndex = 334
        Me.Label7.Text = "Name of Kin/Trustee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 475)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 24)
        Me.Label3.TabIndex = 333
        Me.Label3.Text = "Plan Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 24)
        Me.Label2.TabIndex = 335
        Me.Label2.Text = "Client Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(161, 300)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 24)
        Me.Label10.TabIndex = 332
        Me.Label10.Text = "Complete Address"
        '
        'plansaveupdate_bttn
        '
        Me.plansaveupdate_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.plansaveupdate_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.plansaveupdate_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.plansaveupdate_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.plansaveupdate_bttn.FillColor = System.Drawing.Color.DarkCyan
        Me.plansaveupdate_bttn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.plansaveupdate_bttn.ForeColor = System.Drawing.Color.White
        Me.plansaveupdate_bttn.Location = New System.Drawing.Point(900, 528)
        Me.plansaveupdate_bttn.Name = "plansaveupdate_bttn"
        Me.plansaveupdate_bttn.Size = New System.Drawing.Size(185, 55)
        Me.plansaveupdate_bttn.TabIndex = 331
        Me.plansaveupdate_bttn.Text = "Update"
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
        Me.plandate.Location = New System.Drawing.Point(894, 329)
        Me.plandate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.plandate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.plandate.Name = "plandate"
        Me.plandate.Size = New System.Drawing.Size(191, 53)
        Me.plandate.TabIndex = 330
        Me.plandate.Value = New Date(2022, 11, 22, 16, 42, 24, 410)
        '
        'planduedate
        '
        Me.planduedate.BackColor = System.Drawing.Color.Transparent
        Me.planduedate.Checked = True
        Me.planduedate.CustomFormat = "yyyy/MM/dd"
        Me.planduedate.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.planduedate.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Bold)
        Me.planduedate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.planduedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.planduedate.Location = New System.Drawing.Point(593, 504)
        Me.planduedate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.planduedate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.planduedate.Name = "planduedate"
        Me.planduedate.Size = New System.Drawing.Size(191, 53)
        Me.planduedate.TabIndex = 329
        Me.planduedate.Value = New Date(2022, 11, 22, 16, 42, 24, 410)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radfemale)
        Me.GroupBox2.Controls.Add(Me.radmale)
        Me.GroupBox2.Location = New System.Drawing.Point(895, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 55)
        Me.GroupBox2.TabIndex = 328
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gender:"
        '
        'radfemale
        '
        Me.radfemale.AutoSize = True
        Me.radfemale.Location = New System.Drawing.Point(99, 29)
        Me.radfemale.Name = "radfemale"
        Me.radfemale.Size = New System.Drawing.Size(91, 28)
        Me.radfemale.TabIndex = 1
        Me.radfemale.TabStop = True
        Me.radfemale.Text = "Female"
        Me.radfemale.UseVisualStyleBackColor = True
        '
        'radmale
        '
        Me.radmale.AutoSize = True
        Me.radmale.Location = New System.Drawing.Point(7, 29)
        Me.radmale.Name = "radmale"
        Me.radmale.Size = New System.Drawing.Size(72, 28)
        Me.radmale.TabIndex = 0
        Me.radmale.TabStop = True
        Me.radmale.Text = "Male"
        Me.radmale.UseVisualStyleBackColor = True
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'planterm
        '
        Me.planterm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.planterm.DefaultText = ""
        Me.planterm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.planterm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.planterm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planterm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planterm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planterm.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planterm.ForeColor = System.Drawing.Color.Black
        Me.planterm.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planterm.Location = New System.Drawing.Point(377, 503)
        Me.planterm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.planterm.Name = "planterm"
        Me.planterm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.planterm.PlaceholderText = "Term"
        Me.planterm.SelectedText = ""
        Me.planterm.Size = New System.Drawing.Size(172, 54)
        Me.planterm.TabIndex = 350
        '
        'UpdateNewPlanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 650)
        Me.Controls.Add(Me.planterm)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.plangrossprice)
        Me.Controls.Add(Me.planname)
        Me.Controls.Add(Me.planinstallment)
        Me.Controls.Add(Me.plannamekintrustee)
        Me.Controls.Add(Me.planaddress)
        Me.Controls.Add(Me.planclientname)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.plansaveupdate_bttn)
        Me.Controls.Add(Me.plandate)
        Me.Controls.Add(Me.planduedate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UpdateNewPlanForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateNewPlanForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents close_bttn As PictureBox
    Friend WithEvents Home_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Age As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents plangrossprice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents planname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents planinstallment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents plannamekintrustee As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents planaddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents planclientname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents plansaveupdate_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents plandate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents planduedate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radfemale As RadioButton
    Friend WithEvents radmale As RadioButton
    Friend WithEvents plantclient_ID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents planterm As Guna.UI2.WinForms.Guna2TextBox
End Class
