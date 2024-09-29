<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPlanForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radfemale = New System.Windows.Forms.RadioButton()
        Me.radmale = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.plandate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.proceed2Contract_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.planduedate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.plansave_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.planterm1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.plannamekintrustee1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.plangrossprice1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.planinstallment1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.planaddress1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.planname1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.planclientname1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1450, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(41, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 49)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Plan Information"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.plandate)
        Me.Panel2.Controls.Add(Me.proceed2Contract_bttn)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.planduedate)
        Me.Panel2.Controls.Add(Me.plansave_bttn)
        Me.Panel2.Controls.Add(Me.planterm1)
        Me.Panel2.Controls.Add(Me.plannamekintrustee1)
        Me.Panel2.Controls.Add(Me.plangrossprice1)
        Me.Panel2.Controls.Add(Me.planinstallment1)
        Me.Panel2.Controls.Add(Me.planaddress1)
        Me.Panel2.Controls.Add(Me.planname1)
        Me.Panel2.Controls.Add(Me.planclientname1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1450, 560)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radfemale)
        Me.GroupBox1.Controls.Add(Me.radmale)
        Me.GroupBox1.Location = New System.Drawing.Point(710, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 55)
        Me.GroupBox1.TabIndex = 153
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender:"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(722, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 24)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "Date"
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
        Me.plandate.Location = New System.Drawing.Point(720, 104)
        Me.plandate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.plandate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.plandate.Name = "plandate"
        Me.plandate.Size = New System.Drawing.Size(191, 53)
        Me.plandate.TabIndex = 151
        Me.plandate.Value = New Date(2022, 11, 22, 16, 42, 24, 410)
        '
        'proceed2Contract_bttn
        '
        Me.proceed2Contract_bttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.proceed2Contract_bttn.BorderColor = System.Drawing.Color.Transparent
        Me.proceed2Contract_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.proceed2Contract_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.proceed2Contract_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.proceed2Contract_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.proceed2Contract_bttn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.proceed2Contract_bttn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.proceed2Contract_bttn.ForeColor = System.Drawing.Color.White
        Me.proceed2Contract_bttn.Location = New System.Drawing.Point(44, 440)
        Me.proceed2Contract_bttn.Name = "proceed2Contract_bttn"
        Me.proceed2Contract_bttn.Size = New System.Drawing.Size(272, 55)
        Me.proceed2Contract_bttn.TabIndex = 97
        Me.proceed2Contract_bttn.Text = "Proceed to Contract"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(732, 356)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 24)
        Me.Label11.TabIndex = 133
        Me.Label11.Text = "Due Date"
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
        Me.planduedate.Location = New System.Drawing.Point(720, 299)
        Me.planduedate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.planduedate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.planduedate.Name = "planduedate"
        Me.planduedate.Size = New System.Drawing.Size(191, 53)
        Me.planduedate.TabIndex = 134
        Me.planduedate.Value = New Date(2022, 11, 22, 16, 42, 24, 410)
        '
        'plansave_bttn
        '
        Me.plansave_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.plansave_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.plansave_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.plansave_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.plansave_bttn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.plansave_bttn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.plansave_bttn.ForeColor = System.Drawing.Color.White
        Me.plansave_bttn.Location = New System.Drawing.Point(754, 440)
        Me.plansave_bttn.Name = "plansave_bttn"
        Me.plansave_bttn.Size = New System.Drawing.Size(154, 55)
        Me.plansave_bttn.TabIndex = 136
        Me.plansave_bttn.Text = "Save"
        '
        'planterm1
        '
        Me.planterm1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.planterm1.DefaultText = ""
        Me.planterm1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.planterm1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.planterm1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planterm1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planterm1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planterm1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.planterm1.ForeColor = System.Drawing.Color.Black
        Me.planterm1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planterm1.Location = New System.Drawing.Point(570, 299)
        Me.planterm1.Margin = New System.Windows.Forms.Padding(4)
        Me.planterm1.Name = "planterm1"
        Me.planterm1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.planterm1.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.planterm1.PlaceholderText = "Term"
        Me.planterm1.SelectedText = ""
        Me.planterm1.Size = New System.Drawing.Size(128, 53)
        Me.planterm1.TabIndex = 150
        '
        'plannamekintrustee1
        '
        Me.plannamekintrustee1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.plannamekintrustee1.DefaultText = ""
        Me.plannamekintrustee1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.plannamekintrustee1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.plannamekintrustee1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.plannamekintrustee1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.plannamekintrustee1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plannamekintrustee1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.plannamekintrustee1.ForeColor = System.Drawing.Color.Black
        Me.plannamekintrustee1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plannamekintrustee1.Location = New System.Drawing.Point(44, 201)
        Me.plannamekintrustee1.Margin = New System.Windows.Forms.Padding(4)
        Me.plannamekintrustee1.Name = "plannamekintrustee1"
        Me.plannamekintrustee1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.plannamekintrustee1.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.plannamekintrustee1.PlaceholderText = "Name of Kin/Trustee"
        Me.plannamekintrustee1.SelectedText = ""
        Me.plannamekintrustee1.Size = New System.Drawing.Size(544, 53)
        Me.plannamekintrustee1.TabIndex = 148
        '
        'plangrossprice1
        '
        Me.plangrossprice1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.plangrossprice1.DefaultText = ""
        Me.plangrossprice1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.plangrossprice1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.plangrossprice1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.plangrossprice1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.plangrossprice1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plangrossprice1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.plangrossprice1.ForeColor = System.Drawing.Color.Black
        Me.plangrossprice1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plangrossprice1.Location = New System.Drawing.Point(386, 299)
        Me.plangrossprice1.Margin = New System.Windows.Forms.Padding(4)
        Me.plangrossprice1.Name = "plangrossprice1"
        Me.plangrossprice1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.plangrossprice1.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.plangrossprice1.PlaceholderText = "Gross Price"
        Me.plangrossprice1.SelectedText = ""
        Me.plangrossprice1.Size = New System.Drawing.Size(161, 53)
        Me.plangrossprice1.TabIndex = 147
        '
        'planinstallment1
        '
        Me.planinstallment1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.planinstallment1.DefaultText = ""
        Me.planinstallment1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.planinstallment1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.planinstallment1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planinstallment1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planinstallment1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planinstallment1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.planinstallment1.ForeColor = System.Drawing.Color.Black
        Me.planinstallment1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planinstallment1.Location = New System.Drawing.Point(628, 201)
        Me.planinstallment1.Margin = New System.Windows.Forms.Padding(4)
        Me.planinstallment1.Name = "planinstallment1"
        Me.planinstallment1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.planinstallment1.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.planinstallment1.PlaceholderText = "Installment Payment"
        Me.planinstallment1.SelectedText = ""
        Me.planinstallment1.Size = New System.Drawing.Size(288, 53)
        Me.planinstallment1.TabIndex = 146
        '
        'planaddress1
        '
        Me.planaddress1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.planaddress1.DefaultText = ""
        Me.planaddress1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.planaddress1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.planaddress1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planaddress1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planaddress1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planaddress1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.planaddress1.ForeColor = System.Drawing.Color.Black
        Me.planaddress1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planaddress1.Location = New System.Drawing.Point(44, 104)
        Me.planaddress1.Margin = New System.Windows.Forms.Padding(4)
        Me.planaddress1.Name = "planaddress1"
        Me.planaddress1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.planaddress1.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.planaddress1.PlaceholderText = "Complete Address"
        Me.planaddress1.SelectedText = ""
        Me.planaddress1.Size = New System.Drawing.Size(631, 53)
        Me.planaddress1.TabIndex = 144
        '
        'planname1
        '
        Me.planname1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.planname1.DefaultText = ""
        Me.planname1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.planname1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.planname1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planname1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planname1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planname1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.planname1.ForeColor = System.Drawing.Color.Black
        Me.planname1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planname1.Location = New System.Drawing.Point(44, 299)
        Me.planname1.Margin = New System.Windows.Forms.Padding(4)
        Me.planname1.Name = "planname1"
        Me.planname1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.planname1.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.planname1.PlaceholderText = "Plan Name"
        Me.planname1.SelectedText = ""
        Me.planname1.Size = New System.Drawing.Size(316, 53)
        Me.planname1.TabIndex = 143
        '
        'planclientname1
        '
        Me.planclientname1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.planclientname1.DefaultText = ""
        Me.planclientname1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.planclientname1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.planclientname1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planclientname1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.planclientname1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planclientname1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.planclientname1.ForeColor = System.Drawing.Color.Black
        Me.planclientname1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planclientname1.Location = New System.Drawing.Point(44, 17)
        Me.planclientname1.Margin = New System.Windows.Forms.Padding(4)
        Me.planclientname1.Name = "planclientname1"
        Me.planclientname1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.planclientname1.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.planclientname1.PlaceholderText = "Complete Name"
        Me.planclientname1.SelectedText = ""
        Me.planclientname1.Size = New System.Drawing.Size(631, 53)
        Me.planclientname1.TabIndex = 142
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(583, 356)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 24)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "Term"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 24)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "Name of Kin/Trustee"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(639, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 24)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "Installment Payment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(395, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 24)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "Gross Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 24)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Plan Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 24)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Client Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(51, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 24)
        Me.Label10.TabIndex = 130
        Me.Label10.Text = "Complete Address"
        '
        'AddPlanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 725)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddPlanForm"
        Me.Text = "PlanRecords"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents planduedate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents plansave_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents planterm1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents plannamekintrustee1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents plangrossprice1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents planinstallment1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents planaddress1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents planname1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents planclientname1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents proceed2Contract_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radfemale As RadioButton
    Friend WithEvents radmale As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents plandate As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
