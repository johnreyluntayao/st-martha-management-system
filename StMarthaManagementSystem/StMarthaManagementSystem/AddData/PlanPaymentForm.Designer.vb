<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanPaymentForm
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.plandate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pplanid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pdeposit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pbalance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ppayment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Button2.Location = New System.Drawing.Point(756, 29)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(199, 45)
        Me.Guna2Button2.TabIndex = 108
        Me.Guna2Button2.Text = "See Records"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 49)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Plan Information"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Search)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Guna2TextBox2)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.plandate)
        Me.Panel2.Controls.Add(Me.Guna2Button1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.pplanid)
        Me.Panel2.Controls.Add(Me.pdeposit)
        Me.Panel2.Controls.Add(Me.pbalance)
        Me.Panel2.Controls.Add(Me.ppayment)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 558)
        Me.Panel2.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(711, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 31)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Search"
        '
        'Search
        '
        Me.Search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Search.DefaultText = ""
        Me.Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Search.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Search.ForeColor = System.Drawing.Color.Black
        Me.Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Search.Location = New System.Drawing.Point(699, 151)
        Me.Search.Margin = New System.Windows.Forms.Padding(4)
        Me.Search.Name = "Search"
        Me.Search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Search.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.Search.PlaceholderText = "Search"
        Me.Search.SelectedText = ""
        Me.Search.Size = New System.Drawing.Size(237, 35)
        Me.Search.TabIndex = 120
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(372, 80)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(270, 32)
        Me.ComboBox1.TabIndex = 119
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(390, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 31)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "Date"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(65, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 31)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "OR No."
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(60, 80)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.Guna2TextBox2.PlaceholderText = "OR.ID"
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(270, 35)
        Me.Guna2TextBox2.TabIndex = 116
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(50, 237)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(916, 246)
        Me.DataGridView1.TabIndex = 114
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(717, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 31)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Date"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(368, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 31)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Balance"
        '
        'plandate
        '
        Me.plandate.BackColor = System.Drawing.Color.Transparent
        Me.plandate.Checked = True
        Me.plandate.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.plandate.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Bold)
        Me.plandate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.plandate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.plandate.Location = New System.Drawing.Point(721, 8)
        Me.plandate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.plandate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.plandate.Name = "plandate"
        Me.plandate.Size = New System.Drawing.Size(234, 35)
        Me.plandate.TabIndex = 107
        Me.plandate.Value = New Date(2022, 11, 22, 16, 42, 24, 410)
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(756, 501)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button1.TabIndex = 108
        Me.Guna2Button1.Text = "Save"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(56, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 31)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Deposit"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(61, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 31)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Plan ID"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(368, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 31)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Client Name"
        '
        'pplanid
        '
        Me.pplanid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pplanid.DefaultText = ""
        Me.pplanid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.pplanid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pplanid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pplanid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pplanid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pplanid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.pplanid.ForeColor = System.Drawing.Color.Black
        Me.pplanid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pplanid.Location = New System.Drawing.Point(60, 8)
        Me.pplanid.Margin = New System.Windows.Forms.Padding(4)
        Me.pplanid.Name = "pplanid"
        Me.pplanid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pplanid.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.pplanid.PlaceholderText = "Plan ID"
        Me.pplanid.SelectedText = ""
        Me.pplanid.Size = New System.Drawing.Size(270, 35)
        Me.pplanid.TabIndex = 109
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
        Me.pdeposit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.pdeposit.ForeColor = System.Drawing.Color.Black
        Me.pdeposit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pdeposit.Location = New System.Drawing.Point(60, 151)
        Me.pdeposit.Margin = New System.Windows.Forms.Padding(4)
        Me.pdeposit.Name = "pdeposit"
        Me.pdeposit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pdeposit.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.pdeposit.PlaceholderText = "Deposit"
        Me.pdeposit.SelectedText = ""
        Me.pdeposit.Size = New System.Drawing.Size(270, 35)
        Me.pdeposit.TabIndex = 108
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
        Me.pbalance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.pbalance.ForeColor = System.Drawing.Color.Black
        Me.pbalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pbalance.Location = New System.Drawing.Point(372, 150)
        Me.pbalance.Margin = New System.Windows.Forms.Padding(4)
        Me.pbalance.Name = "pbalance"
        Me.pbalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pbalance.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.pbalance.PlaceholderText = "Balance"
        Me.pbalance.SelectedText = ""
        Me.pbalance.Size = New System.Drawing.Size(270, 35)
        Me.pbalance.TabIndex = 107
        '
        'ppayment
        '
        Me.ppayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ppayment.DefaultText = ""
        Me.ppayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ppayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ppayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ppayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ppayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ppayment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ppayment.ForeColor = System.Drawing.Color.Black
        Me.ppayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ppayment.Location = New System.Drawing.Point(372, 8)
        Me.ppayment.Margin = New System.Windows.Forms.Padding(4)
        Me.ppayment.Name = "ppayment"
        Me.ppayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ppayment.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.ppayment.PlaceholderText = "Client Name"
        Me.ppayment.SelectedText = ""
        Me.ppayment.Size = New System.Drawing.Size(270, 35)
        Me.ppayment.TabIndex = 106
        '
        'PlanPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 658)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PlanPaymentForm"
        Me.Text = "PlanPaymentForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pdeposit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pbalance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ppayment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents plandate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pplanid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Search As Guna.UI2.WinForms.Guna2TextBox
End Class
