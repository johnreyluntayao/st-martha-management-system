<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractPaymentNew
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
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
        Me.Panel1.SuspendLayout()
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ContractPaymentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 1
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 46)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1200, 73)
        Me.Panel3.TabIndex = 326
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
        Me.backbutton.Location = New System.Drawing.Point(79, 600)
        Me.backbutton.Name = "backbutton"
        Me.backbutton.Size = New System.Drawing.Size(246, 38)
        Me.backbutton.TabIndex = 345
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
        Me.newbalance.Location = New System.Drawing.Point(79, 430)
        Me.newbalance.Name = "newbalance"
        Me.newbalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.newbalance.PlaceholderText = "New Balance"
        Me.newbalance.SelectedText = ""
        Me.newbalance.Size = New System.Drawing.Size(354, 36)
        Me.newbalance.TabIndex = 344
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
        Me.contractbalance.Location = New System.Drawing.Point(79, 342)
        Me.contractbalance.Name = "contractbalance"
        Me.contractbalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contractbalance.PlaceholderText = "Balance"
        Me.contractbalance.SelectedText = ""
        Me.contractbalance.Size = New System.Drawing.Size(354, 36)
        Me.contractbalance.TabIndex = 343
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
        Me.contractdeposit.Location = New System.Drawing.Point(79, 259)
        Me.contractdeposit.Name = "contractdeposit"
        Me.contractdeposit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contractdeposit.PlaceholderText = "Deposit"
        Me.contractdeposit.SelectedText = ""
        Me.contractdeposit.Size = New System.Drawing.Size(354, 36)
        Me.contractdeposit.TabIndex = 342
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
        Me.clientnamepayment.Location = New System.Drawing.Point(79, 171)
        Me.clientnamepayment.Name = "clientnamepayment"
        Me.clientnamepayment.Size = New System.Drawing.Size(354, 36)
        Me.clientnamepayment.TabIndex = 341
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(763, 125)
        Me.search.Multiline = True
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(354, 40)
        Me.search.TabIndex = 340
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
        Me.INBOX.Location = New System.Drawing.Point(581, 126)
        Me.INBOX.Margin = New System.Windows.Forms.Padding(4)
        Me.INBOX.Name = "INBOX"
        Me.INBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.INBOX.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.INBOX.PlaceholderText = ""
        Me.INBOX.SelectedText = ""
        Me.INBOX.Size = New System.Drawing.Size(54, 33)
        Me.INBOX.TabIndex = 339
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
        Me.paymentdate.Location = New System.Drawing.Point(79, 504)
        Me.paymentdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.paymentdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.paymentdate.Name = "paymentdate"
        Me.paymentdate.Size = New System.Drawing.Size(354, 39)
        Me.paymentdate.TabIndex = 338
        Me.paymentdate.Value = New Date(2022, 11, 22, 16, 42, 24, 410)
        '
        'newbal
        '
        Me.newbal.BackColor = System.Drawing.Color.Transparent
        Me.newbal.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newbal.Location = New System.Drawing.Point(97, 472)
        Me.newbal.Name = "newbal"
        Me.newbal.Size = New System.Drawing.Size(113, 26)
        Me.newbal.TabIndex = 337
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
        Me.paymentID.Location = New System.Drawing.Point(511, 126)
        Me.paymentID.Margin = New System.Windows.Forms.Padding(4)
        Me.paymentID.Name = "paymentID"
        Me.paymentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.paymentID.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.paymentID.PlaceholderText = ""
        Me.paymentID.SelectedText = ""
        Me.paymentID.Size = New System.Drawing.Size(54, 33)
        Me.paymentID.TabIndex = 336
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
        Me.update_bttn.Location = New System.Drawing.Point(645, 595)
        Me.update_bttn.Name = "update_bttn"
        Me.update_bttn.Size = New System.Drawing.Size(160, 43)
        Me.update_bttn.TabIndex = 335
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
        Me.clientID.Location = New System.Drawing.Point(439, 126)
        Me.clientID.Margin = New System.Windows.Forms.Padding(4)
        Me.clientID.Name = "clientID"
        Me.clientID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.clientID.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.clientID.PlaceholderText = ""
        Me.clientID.SelectedText = ""
        Me.clientID.Size = New System.Drawing.Size(49, 33)
        Me.clientID.TabIndex = 334
        '
        'ContractPaymentDGV
        '
        Me.ContractPaymentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ContractPaymentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContractPaymentDGV.Location = New System.Drawing.Point(487, 171)
        Me.ContractPaymentDGV.Name = "ContractPaymentDGV"
        Me.ContractPaymentDGV.RowHeadersWidth = 51
        Me.ContractPaymentDGV.RowTemplate.Height = 24
        Me.ContractPaymentDGV.Size = New System.Drawing.Size(630, 372)
        Me.ContractPaymentDGV.TabIndex = 333
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
        Me.save_bttn.Location = New System.Drawing.Point(906, 595)
        Me.save_bttn.Name = "save_bttn"
        Me.save_bttn.Size = New System.Drawing.Size(160, 43)
        Me.save_bttn.TabIndex = 327
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
        Me.contractid.Location = New System.Drawing.Point(364, 126)
        Me.contractid.Margin = New System.Windows.Forms.Padding(4)
        Me.contractid.Name = "contractid"
        Me.contractid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contractid.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.contractid.PlaceholderText = ""
        Me.contractid.SelectedText = ""
        Me.contractid.Size = New System.Drawing.Size(49, 33)
        Me.contractid.TabIndex = 332
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(99, 548)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(43, 26)
        Me.Guna2HtmlLabel1.TabIndex = 331
        Me.Guna2HtmlLabel1.Text = "Date"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(97, 398)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(70, 26)
        Me.Guna2HtmlLabel3.TabIndex = 330
        Me.Guna2HtmlLabel3.Text = "Balance"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(99, 310)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(68, 26)
        Me.Guna2HtmlLabel2.TabIndex = 329
        Me.Guna2HtmlLabel2.Text = "Deposit"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(95, 222)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(133, 31)
        Me.Guna2HtmlLabel6.TabIndex = 328
        Me.Guna2HtmlLabel6.Text = "Client Name"
        '
        'ContractPaymentNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 650)
        Me.Controls.Add(Me.backbutton)
        Me.Controls.Add(Me.newbalance)
        Me.Controls.Add(Me.contractbalance)
        Me.Controls.Add(Me.contractdeposit)
        Me.Controls.Add(Me.clientnamepayment)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.INBOX)
        Me.Controls.Add(Me.paymentdate)
        Me.Controls.Add(Me.newbal)
        Me.Controls.Add(Me.paymentID)
        Me.Controls.Add(Me.update_bttn)
        Me.Controls.Add(Me.clientID)
        Me.Controls.Add(Me.ContractPaymentDGV)
        Me.Controls.Add(Me.save_bttn)
        Me.Controls.Add(Me.contractid)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ContractPaymentNew"
        Me.Text = "ContractPaymentNew"
        Me.Panel1.ResumeLayout(False)
        CType(Me.close_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.ContractPaymentDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents close_bttn As PictureBox
    Friend WithEvents Home_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents backbutton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents newbalance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents contractbalance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents contractdeposit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents clientnamepayment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents search As TextBox
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
End Class
