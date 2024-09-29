<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddPlanPayment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.newbalA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.plandateM = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.andreiMM = New System.Windows.Forms.TextBox()
        Me.planidMM = New System.Windows.Forms.TextBox()
        Me.monthidMM = New System.Windows.Forms.TextBox()
        Me.IDMM = New System.Windows.Forms.TextBox()
        Me.CNPlanP_CBMA = New System.Windows.Forms.ComboBox()
        Me.SearchM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.month_CBM = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2TextBox2M = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridView1M = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.planPayment_saveBttnM = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pdepositM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pbalanceM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1M, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 49)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Plan Payment"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.newbalA)
        Me.Panel2.Controls.Add(Me.plandateM)
        Me.Panel2.Controls.Add(Me.andreiMM)
        Me.Panel2.Controls.Add(Me.planidMM)
        Me.Panel2.Controls.Add(Me.monthidMM)
        Me.Panel2.Controls.Add(Me.IDMM)
        Me.Panel2.Controls.Add(Me.CNPlanP_CBMA)
        Me.Panel2.Controls.Add(Me.SearchM)
        Me.Panel2.Controls.Add(Me.month_CBM)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Guna2TextBox2M)
        Me.Panel2.Controls.Add(Me.DataGridView1M)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.planPayment_saveBttnM)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.pdepositM)
        Me.Panel2.Controls.Add(Me.pbalanceM)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1450, 563)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(714, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 31)
        Me.Label2.TabIndex = 252
        Me.Label2.Text = "NewBalance"
        '
        'newbalA
        '
        Me.newbalA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.newbalA.DefaultText = ""
        Me.newbalA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.newbalA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.newbalA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newbalA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newbalA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newbalA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.newbalA.ForeColor = System.Drawing.Color.Black
        Me.newbalA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newbalA.Location = New System.Drawing.Point(716, 79)
        Me.newbalA.Margin = New System.Windows.Forms.Padding(4)
        Me.newbalA.Name = "newbalA"
        Me.newbalA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.newbalA.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.newbalA.PlaceholderText = "New Balance"
        Me.newbalA.SelectedText = ""
        Me.newbalA.Size = New System.Drawing.Size(191, 49)
        Me.newbalA.TabIndex = 251
        '
        'plandateM
        '
        Me.plandateM.BackColor = System.Drawing.Color.Transparent
        Me.plandateM.Checked = True
        Me.plandateM.CustomFormat = "yyyy/MM/dd"
        Me.plandateM.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.plandateM.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Bold)
        Me.plandateM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.plandateM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.plandateM.Location = New System.Drawing.Point(716, 11)
        Me.plandateM.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.plandateM.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.plandateM.Name = "plandateM"
        Me.plandateM.Size = New System.Drawing.Size(228, 41)
        Me.plandateM.TabIndex = 250
        Me.plandateM.Value = New Date(2022, 11, 22, 16, 42, 24, 410)
        '
        'andreiMM
        '
        Me.andreiMM.Location = New System.Drawing.Point(249, 192)
        Me.andreiMM.Name = "andreiMM"
        Me.andreiMM.Size = New System.Drawing.Size(42, 32)
        Me.andreiMM.TabIndex = 145
        Me.andreiMM.Visible = False
        '
        'planidMM
        '
        Me.planidMM.Location = New System.Drawing.Point(203, 192)
        Me.planidMM.Name = "planidMM"
        Me.planidMM.Size = New System.Drawing.Size(40, 32)
        Me.planidMM.TabIndex = 143
        Me.planidMM.Visible = False
        '
        'monthidMM
        '
        Me.monthidMM.Location = New System.Drawing.Point(155, 192)
        Me.monthidMM.Name = "monthidMM"
        Me.monthidMM.Size = New System.Drawing.Size(42, 32)
        Me.monthidMM.TabIndex = 142
        Me.monthidMM.Visible = False
        '
        'IDMM
        '
        Me.IDMM.Location = New System.Drawing.Point(109, 192)
        Me.IDMM.Name = "IDMM"
        Me.IDMM.Size = New System.Drawing.Size(38, 32)
        Me.IDMM.TabIndex = 141
        Me.IDMM.Visible = False
        '
        'CNPlanP_CBMA
        '
        Me.CNPlanP_CBMA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CNPlanP_CBMA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CNPlanP_CBMA.BackColor = System.Drawing.Color.White
        Me.CNPlanP_CBMA.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNPlanP_CBMA.FormattingEnabled = True
        Me.CNPlanP_CBMA.Location = New System.Drawing.Point(35, 6)
        Me.CNPlanP_CBMA.MaxLength = 25
        Me.CNPlanP_CBMA.Name = "CNPlanP_CBMA"
        Me.CNPlanP_CBMA.Size = New System.Drawing.Size(435, 45)
        Me.CNPlanP_CBMA.TabIndex = 140
        '
        'SearchM
        '
        Me.SearchM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchM.DefaultText = ""
        Me.SearchM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SearchM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SearchM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SearchM.ForeColor = System.Drawing.Color.Black
        Me.SearchM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchM.Location = New System.Drawing.Point(650, 176)
        Me.SearchM.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchM.Name = "SearchM"
        Me.SearchM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.SearchM.PlaceholderText = "Search"
        Me.SearchM.SelectedText = ""
        Me.SearchM.Size = New System.Drawing.Size(283, 48)
        Me.SearchM.TabIndex = 138
        '
        'month_CBM
        '
        Me.month_CBM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.month_CBM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.month_CBM.Font = New System.Drawing.Font("Candara Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.month_CBM.FormattingEnabled = True
        Me.month_CBM.Location = New System.Drawing.Point(496, 7)
        Me.month_CBM.Name = "month_CBM"
        Me.month_CBM.Size = New System.Drawing.Size(199, 45)
        Me.month_CBM.TabIndex = 137
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(492, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 31)
        Me.Label8.TabIndex = 136
        Me.Label8.Text = "Month"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(37, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 31)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "OR No."
        '
        'Guna2TextBox2M
        '
        Me.Guna2TextBox2M.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2M.DefaultText = ""
        Me.Guna2TextBox2M.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2M.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2M.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2M.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2M.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2M.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox2M.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox2M.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2M.Location = New System.Drawing.Point(35, 83)
        Me.Guna2TextBox2M.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2TextBox2M.Name = "Guna2TextBox2M"
        Me.Guna2TextBox2M.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2M.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.Guna2TextBox2M.PlaceholderText = "Plan ID"
        Me.Guna2TextBox2M.SelectedText = ""
        Me.Guna2TextBox2M.Size = New System.Drawing.Size(142, 45)
        Me.Guna2TextBox2M.TabIndex = 134
        '
        'DataGridView1M
        '
        Me.DataGridView1M.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1M.Location = New System.Drawing.Point(92, 246)
        Me.DataGridView1M.Name = "DataGridView1M"
        Me.DataGridView1M.RowHeadersWidth = 51
        Me.DataGridView1M.RowTemplate.Height = 24
        Me.DataGridView1M.Size = New System.Drawing.Size(841, 246)
        Me.DataGridView1M.TabIndex = 133
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(712, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 31)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "Date"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(496, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 31)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "Balance"
        '
        'planPayment_saveBttnM
        '
        Me.planPayment_saveBttnM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.planPayment_saveBttnM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.planPayment_saveBttnM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.planPayment_saveBttnM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.planPayment_saveBttnM.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.planPayment_saveBttnM.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.planPayment_saveBttnM.ForeColor = System.Drawing.Color.White
        Me.planPayment_saveBttnM.Location = New System.Drawing.Point(753, 515)
        Me.planPayment_saveBttnM.Name = "planPayment_saveBttnM"
        Me.planPayment_saveBttnM.Size = New System.Drawing.Size(180, 45)
        Me.planPayment_saveBttnM.TabIndex = 126
        Me.planPayment_saveBttnM.Text = "Save"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(196, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 31)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Deposit"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(31, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 31)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Client Name"
        '
        'pdepositM
        '
        Me.pdepositM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pdepositM.DefaultText = ""
        Me.pdepositM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.pdepositM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pdepositM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pdepositM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pdepositM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pdepositM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.pdepositM.ForeColor = System.Drawing.Color.Black
        Me.pdepositM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pdepositM.Location = New System.Drawing.Point(200, 79)
        Me.pdepositM.Margin = New System.Windows.Forms.Padding(4)
        Me.pdepositM.Name = "pdepositM"
        Me.pdepositM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pdepositM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.pdepositM.PlaceholderText = "Deposit"
        Me.pdepositM.SelectedText = ""
        Me.pdepositM.Size = New System.Drawing.Size(270, 49)
        Me.pdepositM.TabIndex = 125
        '
        'pbalanceM
        '
        Me.pbalanceM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pbalanceM.DefaultText = ""
        Me.pbalanceM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.pbalanceM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pbalanceM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pbalanceM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pbalanceM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pbalanceM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.pbalanceM.ForeColor = System.Drawing.Color.Black
        Me.pbalanceM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pbalanceM.Location = New System.Drawing.Point(496, 79)
        Me.pbalanceM.Margin = New System.Windows.Forms.Padding(4)
        Me.pbalanceM.Name = "pbalanceM"
        Me.pbalanceM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pbalanceM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.pbalanceM.PlaceholderText = "Balance"
        Me.pbalanceM.SelectedText = ""
        Me.pbalanceM.Size = New System.Drawing.Size(191, 49)
        Me.pbalanceM.TabIndex = 123
        '
        'AddPlanPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 725)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddPlanPayment"
        Me.Text = "AddPlanPayment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1M, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SearchM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents month_CBM As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2TextBox2M As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataGridView1M As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents planPayment_saveBttnM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pdepositM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pbalanceM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CNPlanP_CBMA As ComboBox
    Friend WithEvents IDMM As TextBox
    Friend WithEvents monthidMM As TextBox
    Friend WithEvents planidMM As TextBox
    Friend WithEvents andreiMM As TextBox
    Friend WithEvents plandateM As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents newbalA As Guna.UI2.WinForms.Guna2TextBox
End Class
