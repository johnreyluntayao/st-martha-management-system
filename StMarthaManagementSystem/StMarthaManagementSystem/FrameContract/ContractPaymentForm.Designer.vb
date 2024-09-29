<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractPaymentForm
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
        Me.INBOXM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.paymentdateM = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.newbal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.paymentIDM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.newbalanceM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.update_bttnM = New Guna.UI2.WinForms.Guna2Button()
        Me.clientIDM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.searchM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ContractPaymentDGVM = New System.Windows.Forms.DataGridView()
        Me.save_bttnM = New Guna.UI2.WinForms.Guna2Button()
        Me.clientnamepaymentM = New System.Windows.Forms.ComboBox()
        Me.contractidM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.contractdepositM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.contractbalanceM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.CustomInstaller1 = New MySql.Data.MySqlClient.CustomInstaller()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ContractPaymentDGVM, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1450, 75)
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
        Me.Guna2Button2.Location = New System.Drawing.Point(716, 14)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(199, 45)
        Me.Guna2Button2.TabIndex = 92
        Me.Guna2Button2.Text = "See Records"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(28, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(540, 49)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Contract Payment Information"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.INBOXM)
        Me.Panel2.Controls.Add(Me.paymentdateM)
        Me.Panel2.Controls.Add(Me.newbal)
        Me.Panel2.Controls.Add(Me.paymentIDM)
        Me.Panel2.Controls.Add(Me.newbalanceM)
        Me.Panel2.Controls.Add(Me.update_bttnM)
        Me.Panel2.Controls.Add(Me.clientIDM)
        Me.Panel2.Controls.Add(Me.searchM)
        Me.Panel2.Controls.Add(Me.ContractPaymentDGVM)
        Me.Panel2.Controls.Add(Me.save_bttnM)
        Me.Panel2.Controls.Add(Me.clientnamepaymentM)
        Me.Panel2.Controls.Add(Me.contractidM)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel2.Controls.Add(Me.contractdepositM)
        Me.Panel2.Controls.Add(Me.contractbalanceM)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1450, 650)
        Me.Panel2.TabIndex = 1
        '
        'INBOXM
        '
        Me.INBOXM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.INBOXM.DefaultText = ""
        Me.INBOXM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.INBOXM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.INBOXM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.INBOXM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.INBOXM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.INBOXM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.INBOXM.ForeColor = System.Drawing.Color.Black
        Me.INBOXM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.INBOXM.Location = New System.Drawing.Point(280, 503)
        Me.INBOXM.Margin = New System.Windows.Forms.Padding(4)
        Me.INBOXM.Name = "INBOXM"
        Me.INBOXM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.INBOXM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.INBOXM.PlaceholderText = ""
        Me.INBOXM.SelectedText = ""
        Me.INBOXM.Size = New System.Drawing.Size(45, 35)
        Me.INBOXM.TabIndex = 250
        '
        'paymentdateM
        '
        Me.paymentdateM.BackColor = System.Drawing.Color.Transparent
        Me.paymentdateM.Checked = True
        Me.paymentdateM.CustomFormat = "yyyy/MM/dd"
        Me.paymentdateM.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.paymentdateM.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Bold)
        Me.paymentdateM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.paymentdateM.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.paymentdateM.Location = New System.Drawing.Point(65, 400)
        Me.paymentdateM.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.paymentdateM.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.paymentdateM.Name = "paymentdateM"
        Me.paymentdateM.Size = New System.Drawing.Size(228, 41)
        Me.paymentdateM.TabIndex = 249
        Me.paymentdateM.Value = New Date(2022, 11, 22, 16, 42, 24, 410)
        '
        'newbal
        '
        Me.newbal.BackColor = System.Drawing.Color.Transparent
        Me.newbal.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newbal.Location = New System.Drawing.Point(65, 368)
        Me.newbal.Name = "newbal"
        Me.newbal.Size = New System.Drawing.Size(113, 26)
        Me.newbal.TabIndex = 110
        Me.newbal.Text = "New Balance"
        '
        'paymentIDM
        '
        Me.paymentIDM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.paymentIDM.DefaultText = ""
        Me.paymentIDM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.paymentIDM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.paymentIDM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.paymentIDM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.paymentIDM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.paymentIDM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.paymentIDM.ForeColor = System.Drawing.Color.Black
        Me.paymentIDM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.paymentIDM.Location = New System.Drawing.Point(210, 503)
        Me.paymentIDM.Margin = New System.Windows.Forms.Padding(4)
        Me.paymentIDM.Name = "paymentIDM"
        Me.paymentIDM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.paymentIDM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.paymentIDM.PlaceholderText = ""
        Me.paymentIDM.SelectedText = ""
        Me.paymentIDM.Size = New System.Drawing.Size(45, 35)
        Me.paymentIDM.TabIndex = 108
        '
        'newbalanceM
        '
        Me.newbalanceM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.newbalanceM.DefaultText = ""
        Me.newbalanceM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.newbalanceM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.newbalanceM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newbalanceM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newbalanceM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newbalanceM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.newbalanceM.ForeColor = System.Drawing.Color.Black
        Me.newbalanceM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newbalanceM.Location = New System.Drawing.Point(63, 322)
        Me.newbalanceM.Margin = New System.Windows.Forms.Padding(4)
        Me.newbalanceM.Name = "newbalanceM"
        Me.newbalanceM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.newbalanceM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.newbalanceM.PlaceholderText = "New Balance"
        Me.newbalanceM.SelectedText = ""
        Me.newbalanceM.Size = New System.Drawing.Size(230, 48)
        Me.newbalanceM.TabIndex = 107
        '
        'update_bttnM
        '
        Me.update_bttnM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.update_bttnM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.update_bttnM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.update_bttnM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.update_bttnM.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.update_bttnM.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.update_bttnM.ForeColor = System.Drawing.Color.White
        Me.update_bttnM.Location = New System.Drawing.Point(513, 493)
        Me.update_bttnM.Name = "update_bttnM"
        Me.update_bttnM.Size = New System.Drawing.Size(180, 45)
        Me.update_bttnM.TabIndex = 106
        Me.update_bttnM.Text = "Update"
        '
        'clientIDM
        '
        Me.clientIDM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.clientIDM.DefaultText = ""
        Me.clientIDM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.clientIDM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.clientIDM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.clientIDM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.clientIDM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clientIDM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.clientIDM.ForeColor = System.Drawing.Color.Black
        Me.clientIDM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clientIDM.Location = New System.Drawing.Point(138, 503)
        Me.clientIDM.Margin = New System.Windows.Forms.Padding(4)
        Me.clientIDM.Name = "clientIDM"
        Me.clientIDM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.clientIDM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.clientIDM.PlaceholderText = ""
        Me.clientIDM.SelectedText = ""
        Me.clientIDM.Size = New System.Drawing.Size(40, 35)
        Me.clientIDM.TabIndex = 105
        '
        'searchM
        '
        Me.searchM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchM.DefaultText = ""
        Me.searchM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.searchM.ForeColor = System.Drawing.Color.Black
        Me.searchM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchM.Location = New System.Drawing.Point(615, 30)
        Me.searchM.Margin = New System.Windows.Forms.Padding(4)
        Me.searchM.Name = "searchM"
        Me.searchM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.searchM.PlaceholderText = "Search"
        Me.searchM.SelectedText = ""
        Me.searchM.Size = New System.Drawing.Size(300, 40)
        Me.searchM.TabIndex = 104
        '
        'ContractPaymentDGVM
        '
        Me.ContractPaymentDGVM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ContractPaymentDGVM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContractPaymentDGVM.Location = New System.Drawing.Point(322, 92)
        Me.ContractPaymentDGVM.Name = "ContractPaymentDGVM"
        Me.ContractPaymentDGVM.RowHeadersWidth = 51
        Me.ContractPaymentDGVM.RowTemplate.Height = 24
        Me.ContractPaymentDGVM.Size = New System.Drawing.Size(593, 349)
        Me.ContractPaymentDGVM.TabIndex = 103
        '
        'save_bttnM
        '
        Me.save_bttnM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.save_bttnM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.save_bttnM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.save_bttnM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.save_bttnM.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.save_bttnM.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.save_bttnM.ForeColor = System.Drawing.Color.White
        Me.save_bttnM.Location = New System.Drawing.Point(735, 493)
        Me.save_bttnM.Name = "save_bttnM"
        Me.save_bttnM.Size = New System.Drawing.Size(180, 45)
        Me.save_bttnM.TabIndex = 91
        Me.save_bttnM.Text = "Save"
        '
        'clientnamepaymentM
        '
        Me.clientnamepaymentM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.clientnamepaymentM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.clientnamepaymentM.BackColor = System.Drawing.Color.White
        Me.clientnamepaymentM.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientnamepaymentM.FormattingEnabled = True
        Me.clientnamepaymentM.Location = New System.Drawing.Point(63, 30)
        Me.clientnamepaymentM.MaxLength = 25
        Me.clientnamepaymentM.Name = "clientnamepaymentM"
        Me.clientnamepaymentM.Size = New System.Drawing.Size(354, 45)
        Me.clientnamepaymentM.TabIndex = 102
        '
        'contractidM
        '
        Me.contractidM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contractidM.DefaultText = ""
        Me.contractidM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.contractidM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.contractidM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contractidM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contractidM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contractidM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.contractidM.ForeColor = System.Drawing.Color.Black
        Me.contractidM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contractidM.Location = New System.Drawing.Point(63, 503)
        Me.contractidM.Margin = New System.Windows.Forms.Padding(4)
        Me.contractidM.Name = "contractidM"
        Me.contractidM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contractidM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.contractidM.PlaceholderText = ""
        Me.contractidM.SelectedText = ""
        Me.contractidM.Size = New System.Drawing.Size(40, 35)
        Me.contractidM.TabIndex = 100
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(65, 447)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(43, 26)
        Me.Guna2HtmlLabel4.TabIndex = 99
        Me.Guna2HtmlLabel4.Text = "Date"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(63, 278)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(70, 26)
        Me.Guna2HtmlLabel3.TabIndex = 98
        Me.Guna2HtmlLabel3.Text = "Balance"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(65, 178)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(68, 26)
        Me.Guna2HtmlLabel2.TabIndex = 97
        Me.Guna2HtmlLabel2.Text = "Deposit"
        '
        'contractdepositM
        '
        Me.contractdepositM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contractdepositM.DefaultText = ""
        Me.contractdepositM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.contractdepositM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.contractdepositM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contractdepositM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contractdepositM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contractdepositM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.contractdepositM.ForeColor = System.Drawing.Color.Black
        Me.contractdepositM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contractdepositM.Location = New System.Drawing.Point(63, 123)
        Me.contractdepositM.Margin = New System.Windows.Forms.Padding(4)
        Me.contractdepositM.Name = "contractdepositM"
        Me.contractdepositM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contractdepositM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.contractdepositM.PlaceholderText = "Deposit"
        Me.contractdepositM.SelectedText = ""
        Me.contractdepositM.Size = New System.Drawing.Size(230, 48)
        Me.contractdepositM.TabIndex = 96
        '
        'contractbalanceM
        '
        Me.contractbalanceM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contractbalanceM.DefaultText = ""
        Me.contractbalanceM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.contractbalanceM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.contractbalanceM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contractbalanceM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contractbalanceM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contractbalanceM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.contractbalanceM.ForeColor = System.Drawing.Color.Black
        Me.contractbalanceM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contractbalanceM.Location = New System.Drawing.Point(63, 220)
        Me.contractbalanceM.Margin = New System.Windows.Forms.Padding(4)
        Me.contractbalanceM.Name = "contractbalanceM"
        Me.contractbalanceM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contractbalanceM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.contractbalanceM.PlaceholderText = "Balance"
        Me.contractbalanceM.SelectedText = ""
        Me.contractbalanceM.Size = New System.Drawing.Size(230, 51)
        Me.contractbalanceM.TabIndex = 95
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(63, 81)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(133, 35)
        Me.Guna2HtmlLabel1.TabIndex = 94
        Me.Guna2HtmlLabel1.Text = "Client Name"
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'ContractPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 725)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ContractPaymentForm"
        Me.Text = "ContractPaymentForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ContractPaymentDGVM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents clientnamepaymentM As ComboBox
    Friend WithEvents contractidM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents contractdepositM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents contractbalanceM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents save_bttnM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents searchM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ContractPaymentDGVM As DataGridView
    Friend WithEvents clientIDM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents update_bttnM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents newbalanceM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents paymentIDM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents newbal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents paymentdateM As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents INBOXM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CustomInstaller1 As MySql.Data.MySqlClient.CustomInstaller
End Class
