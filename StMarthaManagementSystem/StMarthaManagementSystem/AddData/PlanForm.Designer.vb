<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanForm
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
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.planDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.planduedate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.plan_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.planterm = New Guna.UI2.WinForms.Guna2TextBox()
        Me.plannamekintrustee = New Guna.UI2.WinForms.Guna2TextBox()
        Me.plangrossprice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.planinstallment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.planaddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.planname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.planclientname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 100)
        Me.Panel1.TabIndex = 0
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button2.Location = New System.Drawing.Point(752, 24)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(236, 45)
        Me.Guna2Button2.TabIndex = 94
        Me.Guna2Button2.Text = "See Plan Records"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(50, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 49)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Plan Information"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.planDate)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.planduedate)
        Me.Panel2.Controls.Add(Me.plan_bttn)
        Me.Panel2.Controls.Add(Me.planterm)
        Me.Panel2.Controls.Add(Me.plannamekintrustee)
        Me.Panel2.Controls.Add(Me.plangrossprice)
        Me.Panel2.Controls.Add(Me.planinstallment)
        Me.Panel2.Controls.Add(Me.planaddress)
        Me.Panel2.Controls.Add(Me.planname)
        Me.Panel2.Controls.Add(Me.planclientname)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 558)
        Me.Panel2.TabIndex = 1
        '
        'planDate
        '
        Me.planDate.BackColor = System.Drawing.Color.Transparent
        Me.planDate.Checked = True
        Me.planDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.planDate.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Bold)
        Me.planDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.planDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.planDate.Location = New System.Drawing.Point(682, 254)
        Me.planDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.planDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.planDate.Name = "planDate"
        Me.planDate.Size = New System.Drawing.Size(224, 49)
        Me.planDate.TabIndex = 109
        Me.planDate.Value = New Date(2022, 11, 22, 16, 42, 24, 410)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(92, 495)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 24)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Due Date"
        '
        'planduedate
        '
        Me.planduedate.BackColor = System.Drawing.Color.Transparent
        Me.planduedate.Checked = True
        Me.planduedate.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.planduedate.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Bold)
        Me.planduedate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.planduedate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.planduedate.Location = New System.Drawing.Point(84, 443)
        Me.planduedate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.planduedate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.planduedate.Name = "planduedate"
        Me.planduedate.Size = New System.Drawing.Size(223, 49)
        Me.planduedate.TabIndex = 94
        Me.planduedate.Value = New Date(2022, 11, 22, 16, 42, 24, 410)
        '
        'plan_bttn
        '
        Me.plan_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.plan_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.plan_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.plan_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.plan_bttn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.plan_bttn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.plan_bttn.ForeColor = System.Drawing.Color.White
        Me.plan_bttn.Location = New System.Drawing.Point(726, 443)
        Me.plan_bttn.Name = "plan_bttn"
        Me.plan_bttn.Size = New System.Drawing.Size(180, 45)
        Me.plan_bttn.TabIndex = 95
        Me.plan_bttn.Text = "Save"
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
        Me.planterm.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.planterm.ForeColor = System.Drawing.Color.Black
        Me.planterm.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planterm.Location = New System.Drawing.Point(801, 345)
        Me.planterm.Margin = New System.Windows.Forms.Padding(4)
        Me.planterm.Name = "planterm"
        Me.planterm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.planterm.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.planterm.PlaceholderText = "Term"
        Me.planterm.SelectedText = ""
        Me.planterm.Size = New System.Drawing.Size(114, 53)
        Me.planterm.TabIndex = 108
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
        Me.plannamekintrustee.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.plannamekintrustee.ForeColor = System.Drawing.Color.Black
        Me.plannamekintrustee.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plannamekintrustee.Location = New System.Drawing.Point(84, 250)
        Me.plannamekintrustee.Margin = New System.Windows.Forms.Padding(4)
        Me.plannamekintrustee.Name = "plannamekintrustee"
        Me.plannamekintrustee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.plannamekintrustee.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.plannamekintrustee.PlaceholderText = "Name of Trustee"
        Me.plannamekintrustee.SelectedText = ""
        Me.plannamekintrustee.Size = New System.Drawing.Size(544, 53)
        Me.plannamekintrustee.TabIndex = 106
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
        Me.plangrossprice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.plangrossprice.ForeColor = System.Drawing.Color.Black
        Me.plangrossprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.plangrossprice.Location = New System.Drawing.Point(391, 345)
        Me.plangrossprice.Margin = New System.Windows.Forms.Padding(4)
        Me.plangrossprice.Name = "plangrossprice"
        Me.plangrossprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.plangrossprice.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.plangrossprice.PlaceholderText = "Gross Price"
        Me.plangrossprice.SelectedText = ""
        Me.plangrossprice.Size = New System.Drawing.Size(237, 53)
        Me.plangrossprice.TabIndex = 105
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
        Me.planinstallment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.planinstallment.ForeColor = System.Drawing.Color.Black
        Me.planinstallment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planinstallment.Location = New System.Drawing.Point(80, 345)
        Me.planinstallment.Margin = New System.Windows.Forms.Padding(4)
        Me.planinstallment.Name = "planinstallment"
        Me.planinstallment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.planinstallment.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.planinstallment.PlaceholderText = "Installment Payment"
        Me.planinstallment.SelectedText = ""
        Me.planinstallment.Size = New System.Drawing.Size(288, 53)
        Me.planinstallment.TabIndex = 104
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
        Me.planaddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.planaddress.ForeColor = System.Drawing.Color.Black
        Me.planaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planaddress.Location = New System.Drawing.Point(84, 149)
        Me.planaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.planaddress.Name = "planaddress"
        Me.planaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.planaddress.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.planaddress.PlaceholderText = "Complete Address"
        Me.planaddress.SelectedText = ""
        Me.planaddress.Size = New System.Drawing.Size(831, 53)
        Me.planaddress.TabIndex = 102
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
        Me.planname.Location = New System.Drawing.Point(594, 47)
        Me.planname.Margin = New System.Windows.Forms.Padding(4)
        Me.planname.Name = "planname"
        Me.planname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.planname.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.planname.PlaceholderText = "Plan Name"
        Me.planname.SelectedText = ""
        Me.planname.Size = New System.Drawing.Size(321, 53)
        Me.planname.TabIndex = 101
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
        Me.planclientname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.planclientname.ForeColor = System.Drawing.Color.Black
        Me.planclientname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.planclientname.Location = New System.Drawing.Point(84, 47)
        Me.planclientname.Margin = New System.Windows.Forms.Padding(4)
        Me.planclientname.Name = "planclientname"
        Me.planclientname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.planclientname.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.planclientname.PlaceholderText = "Complete Name"
        Me.planclientname.SelectedText = ""
        Me.planclientname.Size = New System.Drawing.Size(457, 53)
        Me.planclientname.TabIndex = 100
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(807, 402)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 24)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Term"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 24)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Name of Kin/Trustee"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(688, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 24)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 402)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 24)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Installment Payment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(402, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 24)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Gross Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(608, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 24)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Plan Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Client Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(91, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 24)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Complete Address"
        '
        'PlanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1000, 658)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PlanForm"
        Me.Text = "PlanForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents planterm As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents plannamekintrustee As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents plangrossprice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents planinstallment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents planaddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents planname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents planclientname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents plan_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents planduedate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents planDate As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
