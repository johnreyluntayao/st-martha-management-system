<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewContractPayment
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.backbutton = New Guna.UI2.WinForms.Guna2Button()
        Me.newbalance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.contractbalance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.contractdeposit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.clientnamepayment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.search = New System.Windows.Forms.TextBox()
        Me.INBOX = New Guna.UI2.WinForms.Guna2TextBox()
        Me.paymentdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.newbal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.paymentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.update_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.clientID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ContractPaymentDGV = New System.Windows.Forms.DataGridView()
        Me.save_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.contractid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CustomInstaller1 = New MySql.Data.MySqlClient.CustomInstaller()
        Me.newcon = New Guna.UI2.WinForms.Guna2Button()
        Me.close_bttn = New System.Windows.Forms.PictureBox()
        Me.Home_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ContractPaymentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 604)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.backbutton)
        Me.GroupBox1.Controls.Add(Me.newbalance)
        Me.GroupBox1.Controls.Add(Me.contractbalance)
        Me.GroupBox1.Controls.Add(Me.contractdeposit)
        Me.GroupBox1.Controls.Add(Me.clientnamepayment)
        Me.GroupBox1.Controls.Add(Me.search)
        Me.GroupBox1.Controls.Add(Me.INBOX)
        Me.GroupBox1.Controls.Add(Me.paymentdate)
        Me.GroupBox1.Controls.Add(Me.newbal)
        Me.GroupBox1.Controls.Add(Me.paymentID)
        Me.GroupBox1.Controls.Add(Me.update_bttn)
        Me.GroupBox1.Controls.Add(Me.clientID)
        Me.GroupBox1.Controls.Add(Me.ContractPaymentDGV)
        Me.GroupBox1.Controls.Add(Me.save_bttn)
        Me.GroupBox1.Controls.Add(Me.contractid)
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1200, 531)
        Me.GroupBox1.TabIndex = 326
        Me.GroupBox1.TabStop = False
        '
        'backbutton
        '
        Me.backbutton.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.backbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.backbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.backbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.backbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.backbutton.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.backbutton.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbutton.ForeColor = System.Drawing.SystemColors.Control
        Me.backbutton.Location = New System.Drawing.Point(92, 481)
        Me.backbutton.Name = "backbutton"
        Me.backbutton.Size = New System.Drawing.Size(246, 38)
        Me.backbutton.TabIndex = 306
        Me.backbutton.Text = "BACK"
        '
        'newbalance
        '
        Me.newbalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.newbalance.DefaultText = ""
        Me.newbalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.newbalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.newbalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newbalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newbalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newbalance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.newbalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newbalance.Location = New System.Drawing.Point(92, 311)
        Me.newbalance.Name = "newbalance"
        Me.newbalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.newbalance.PlaceholderText = "New Balance"
        Me.newbalance.SelectedText = ""
        Me.newbalance.Size = New System.Drawing.Size(354, 36)
        Me.newbalance.TabIndex = 277
        '
        'contractbalance
        '
        Me.contractbalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contractbalance.DefaultText = ""
        Me.contractbalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.contractbalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.contractbalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contractbalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contractbalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contractbalance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.contractbalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contractbalance.Location = New System.Drawing.Point(92, 223)
        Me.contractbalance.Name = "contractbalance"
        Me.contractbalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contractbalance.PlaceholderText = "Balance"
        Me.contractbalance.SelectedText = ""
        Me.contractbalance.Size = New System.Drawing.Size(354, 36)
        Me.contractbalance.TabIndex = 276
        '
        'contractdeposit
        '
        Me.contractdeposit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contractdeposit.DefaultText = ""
        Me.contractdeposit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.contractdeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.contractdeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contractdeposit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contractdeposit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contractdeposit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.contractdeposit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contractdeposit.Location = New System.Drawing.Point(92, 140)
        Me.contractdeposit.Name = "contractdeposit"
        Me.contractdeposit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contractdeposit.PlaceholderText = "Deposit"
        Me.contractdeposit.SelectedText = ""
        Me.contractdeposit.Size = New System.Drawing.Size(354, 36)
        Me.contractdeposit.TabIndex = 275
        '
        'clientnamepayment
        '
        Me.clientnamepayment.BackColor = System.Drawing.Color.Transparent
        Me.clientnamepayment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.clientnamepayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.clientnamepayment.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clientnamepayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clientnamepayment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.clientnamepayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.clientnamepayment.ItemHeight = 30
        Me.clientnamepayment.Location = New System.Drawing.Point(92, 52)
        Me.clientnamepayment.Name = "clientnamepayment"
        Me.clientnamepayment.Size = New System.Drawing.Size(354, 36)
        Me.clientnamepayment.TabIndex = 274
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(776, 6)
        Me.search.Multiline = True
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(354, 40)
        Me.search.TabIndex = 273
        '
        'INBOX
        '
        Me.INBOX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.INBOX.DefaultText = ""
        Me.INBOX.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.INBOX.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.INBOX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.INBOX.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.INBOX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.INBOX.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.INBOX.ForeColor = System.Drawing.Color.Black
        Me.INBOX.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.INBOX.Location = New System.Drawing.Point(594, 7)
        Me.INBOX.Margin = New System.Windows.Forms.Padding(4)
        Me.INBOX.Name = "INBOX"
        Me.INBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.INBOX.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.INBOX.PlaceholderText = ""
        Me.INBOX.SelectedText = ""
        Me.INBOX.Size = New System.Drawing.Size(54, 33)
        Me.INBOX.TabIndex = 268
        '
        'paymentdate
        '
        Me.paymentdate.BackColor = System.Drawing.Color.Transparent
        Me.paymentdate.Checked = True
        Me.paymentdate.CustomFormat = "yyyy/MM/dd"
        Me.paymentdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.paymentdate.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Bold)
        Me.paymentdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.paymentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.paymentdate.Location = New System.Drawing.Point(92, 385)
        Me.paymentdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.paymentdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.paymentdate.Name = "paymentdate"
        Me.paymentdate.Size = New System.Drawing.Size(354, 39)
        Me.paymentdate.TabIndex = 267
        Me.paymentdate.Value = New Date(2022, 11, 22, 16, 42, 24, 410)
        '
        'newbal
        '
        Me.newbal.BackColor = System.Drawing.Color.Transparent
        Me.newbal.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newbal.Location = New System.Drawing.Point(110, 353)
        Me.newbal.Name = "newbal"
        Me.newbal.Size = New System.Drawing.Size(113, 26)
        Me.newbal.TabIndex = 266
        Me.newbal.Text = "New Balance"
        '
        'paymentID
        '
        Me.paymentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.paymentID.DefaultText = ""
        Me.paymentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.paymentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.paymentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.paymentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.paymentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.paymentID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.paymentID.ForeColor = System.Drawing.Color.Black
        Me.paymentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.paymentID.Location = New System.Drawing.Point(524, 7)
        Me.paymentID.Margin = New System.Windows.Forms.Padding(4)
        Me.paymentID.Name = "paymentID"
        Me.paymentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.paymentID.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.paymentID.PlaceholderText = ""
        Me.paymentID.SelectedText = ""
        Me.paymentID.Size = New System.Drawing.Size(54, 33)
        Me.paymentID.TabIndex = 265
        '
        'update_bttn
        '
        Me.update_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.update_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.update_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.update_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.update_bttn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.update_bttn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.update_bttn.ForeColor = System.Drawing.Color.White
        Me.update_bttn.Location = New System.Drawing.Point(658, 476)
        Me.update_bttn.Name = "update_bttn"
        Me.update_bttn.Size = New System.Drawing.Size(160, 43)
        Me.update_bttn.TabIndex = 263
        Me.update_bttn.Text = "Update"
        '
        'clientID
        '
        Me.clientID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.clientID.DefaultText = ""
        Me.clientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.clientID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.clientID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.clientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.clientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clientID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.clientID.ForeColor = System.Drawing.Color.Black
        Me.clientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clientID.Location = New System.Drawing.Point(452, 7)
        Me.clientID.Margin = New System.Windows.Forms.Padding(4)
        Me.clientID.Name = "clientID"
        Me.clientID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.clientID.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.clientID.PlaceholderText = ""
        Me.clientID.SelectedText = ""
        Me.clientID.Size = New System.Drawing.Size(49, 33)
        Me.clientID.TabIndex = 262
        '
        'ContractPaymentDGV
        '
        Me.ContractPaymentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ContractPaymentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContractPaymentDGV.Location = New System.Drawing.Point(500, 52)
        Me.ContractPaymentDGV.Name = "ContractPaymentDGV"
        Me.ContractPaymentDGV.RowHeadersWidth = 51
        Me.ContractPaymentDGV.RowTemplate.Height = 24
        Me.ContractPaymentDGV.Size = New System.Drawing.Size(630, 372)
        Me.ContractPaymentDGV.TabIndex = 260
        '
        'save_bttn
        '
        Me.save_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.save_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.save_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.save_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.save_bttn.FillColor = System.Drawing.Color.Lime
        Me.save_bttn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.save_bttn.ForeColor = System.Drawing.Color.White
        Me.save_bttn.Location = New System.Drawing.Point(919, 476)
        Me.save_bttn.Name = "save_bttn"
        Me.save_bttn.Size = New System.Drawing.Size(160, 43)
        Me.save_bttn.TabIndex = 251
        Me.save_bttn.Text = "Save"
        '
        'contractid
        '
        Me.contractid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contractid.DefaultText = ""
        Me.contractid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.contractid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.contractid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contractid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contractid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contractid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.contractid.ForeColor = System.Drawing.Color.Black
        Me.contractid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contractid.Location = New System.Drawing.Point(377, 7)
        Me.contractid.Margin = New System.Windows.Forms.Padding(4)
        Me.contractid.Name = "contractid"
        Me.contractid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contractid.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.contractid.PlaceholderText = ""
        Me.contractid.SelectedText = ""
        Me.contractid.Size = New System.Drawing.Size(49, 33)
        Me.contractid.TabIndex = 258
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(112, 429)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(43, 26)
        Me.Guna2HtmlLabel1.TabIndex = 257
        Me.Guna2HtmlLabel1.Text = "Date"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(110, 279)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(70, 26)
        Me.Guna2HtmlLabel3.TabIndex = 256
        Me.Guna2HtmlLabel3.Text = "Balance"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(112, 191)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(68, 26)
        Me.Guna2HtmlLabel2.TabIndex = 255
        Me.Guna2HtmlLabel2.Text = "Deposit"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(108, 103)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(133, 31)
        Me.Guna2HtmlLabel6.TabIndex = 252
        Me.Guna2HtmlLabel6.Text = "Client Name"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.newcon)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1200, 73)
        Me.Panel3.TabIndex = 325
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Guna2HtmlLabel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Candara", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(276, 0)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(924, 73)
        Me.Guna2HtmlLabel5.TabIndex = 1
        Me.Guna2HtmlLabel5.Text = "PAYMENT"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Silver
        Me.Guna2HtmlLabel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Candara Light", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(279, 73)
        Me.Guna2HtmlLabel4.TabIndex = 0
        Me.Guna2HtmlLabel4.Text = "CONTRACTS"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'newcon
        '
        Me.newcon.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.newcon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.newcon.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.newcon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.newcon.FillColor = System.Drawing.Color.Lime
        Me.newcon.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.newcon.ForeColor = System.Drawing.Color.White
        Me.newcon.Location = New System.Drawing.Point(896, 15)
        Me.newcon.Name = "newcon"
        Me.newcon.Size = New System.Drawing.Size(265, 52)
        Me.newcon.TabIndex = 252
        Me.newcon.Text = "New Contract"
        '
        'close_bttn
        '
        Me.close_bttn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_bttn.Dock = System.Windows.Forms.DockStyle.Right
        Me.close_bttn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.close1
        Me.close_bttn.Location = New System.Drawing.Point(1158, 0)
        Me.close_bttn.Name = "close_bttn"
        Me.close_bttn.Size = New System.Drawing.Size(42, 46)
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
        'NewContractPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 650)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NewContractPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewPaymentContract"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ContractPaymentDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents INBOX As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents paymentdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents newbal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents paymentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents update_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clientID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ContractPaymentDGV As DataGridView
    Friend WithEvents save_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents contractid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents search As TextBox
    Friend WithEvents Home_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents close_bttn As PictureBox
    Friend WithEvents CustomInstaller1 As MySql.Data.MySqlClient.CustomInstaller
    Friend WithEvents clientnamepayment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents contractdeposit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents contractbalance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents newbalance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents backbutton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents newcon As Guna.UI2.WinForms.Guna2Button
End Class
