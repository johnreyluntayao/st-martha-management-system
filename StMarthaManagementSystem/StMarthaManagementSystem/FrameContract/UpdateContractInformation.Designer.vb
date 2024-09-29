<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateContractInformation
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
        Me.ContractPrintBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.back_bttn = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.update_PackagesCM = New Guna.UI2.WinForms.Guna2Button()
        Me.ClientNameCM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.clear_bttnM = New Guna.UI2.WinForms.Guna2Button()
        Me.clientID_TBM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.uploadAuthorizedSig_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.save_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.adminSigPic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.clientSigPic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.totalamountC = New Guna.UI2.WinForms.Guna2TextBox()
        Me.uploadClientSig_bttn = New Guna.UI2.WinForms.Guna2Button()
        Me.datecontract = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.deceasedbirthdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.deceaseddatedeath = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.deceasedaddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.deceasedage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.namedeceasedM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.relationship = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.contactnumberM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.addressM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ageM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.back_bttn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adminSigPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clientSigPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ContractPrintBtn)
        Me.Panel1.Controls.Add(Me.back_bttn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 71)
        Me.Panel1.TabIndex = 2
        '
        'ContractPrintBtn
        '
        Me.ContractPrintBtn.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ContractPrintBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ContractPrintBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ContractPrintBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ContractPrintBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ContractPrintBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ContractPrintBtn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold)
        Me.ContractPrintBtn.ForeColor = System.Drawing.Color.Black
        Me.ContractPrintBtn.Location = New System.Drawing.Point(844, 12)
        Me.ContractPrintBtn.Name = "ContractPrintBtn"
        Me.ContractPrintBtn.Size = New System.Drawing.Size(97, 45)
        Me.ContractPrintBtn.TabIndex = 163
        Me.ContractPrintBtn.Text = "Print"
        '
        'back_bttn
        '
        Me.back_bttn.Image = Global.StMarthaManagementSystem.My.Resources.Resources.left_arrow
        Me.back_bttn.Location = New System.Drawing.Point(12, 18)
        Me.back_bttn.Name = "back_bttn"
        Me.back_bttn.Size = New System.Drawing.Size(31, 25)
        Me.back_bttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.back_bttn.TabIndex = 26
        Me.back_bttn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(301, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 49)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contract Information"
        '
        'update_PackagesCM
        '
        Me.update_PackagesCM.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.update_PackagesCM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.update_PackagesCM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.update_PackagesCM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.update_PackagesCM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.update_PackagesCM.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.update_PackagesCM.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_PackagesCM.ForeColor = System.Drawing.Color.White
        Me.update_PackagesCM.Location = New System.Drawing.Point(22, 509)
        Me.update_PackagesCM.Name = "update_PackagesCM"
        Me.update_PackagesCM.Size = New System.Drawing.Size(260, 45)
        Me.update_PackagesCM.TabIndex = 278
        Me.update_PackagesCM.Text = "Update Packages"
        Me.update_PackagesCM.Visible = False
        '
        'ClientNameCM
        '
        Me.ClientNameCM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ClientNameCM.DefaultText = ""
        Me.ClientNameCM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ClientNameCM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientNameCM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ClientNameCM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ClientNameCM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientNameCM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ClientNameCM.ForeColor = System.Drawing.Color.Black
        Me.ClientNameCM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientNameCM.Location = New System.Drawing.Point(31, 107)
        Me.ClientNameCM.Margin = New System.Windows.Forms.Padding(4)
        Me.ClientNameCM.Name = "ClientNameCM"
        Me.ClientNameCM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ClientNameCM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.ClientNameCM.PlaceholderText = "ClientName"
        Me.ClientNameCM.SelectedText = ""
        Me.ClientNameCM.Size = New System.Drawing.Size(420, 39)
        Me.ClientNameCM.TabIndex = 277
        '
        'clear_bttnM
        '
        Me.clear_bttnM.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.clear_bttnM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.clear_bttnM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.clear_bttnM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.clear_bttnM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.clear_bttnM.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.clear_bttnM.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_bttnM.ForeColor = System.Drawing.Color.White
        Me.clear_bttnM.Location = New System.Drawing.Point(22, 582)
        Me.clear_bttnM.Name = "clear_bttnM"
        Me.clear_bttnM.Size = New System.Drawing.Size(191, 45)
        Me.clear_bttnM.TabIndex = 270
        Me.clear_bttnM.Text = "Clear"
        '
        'clientID_TBM
        '
        Me.clientID_TBM.BackColor = System.Drawing.Color.White
        Me.clientID_TBM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.clientID_TBM.DefaultText = ""
        Me.clientID_TBM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.clientID_TBM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.clientID_TBM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.clientID_TBM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.clientID_TBM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clientID_TBM.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.clientID_TBM.ForeColor = System.Drawing.Color.Black
        Me.clientID_TBM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clientID_TBM.Location = New System.Drawing.Point(873, 170)
        Me.clientID_TBM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.clientID_TBM.Name = "clientID_TBM"
        Me.clientID_TBM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.clientID_TBM.PlaceholderText = ""
        Me.clientID_TBM.SelectedText = ""
        Me.clientID_TBM.Size = New System.Drawing.Size(68, 43)
        Me.clientID_TBM.TabIndex = 268
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(689, 533)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(163, 21)
        Me.Label17.TabIndex = 218
        Me.Label17.Text = "Authorized Signature"
        '
        'uploadAuthorizedSig_bttn
        '
        Me.uploadAuthorizedSig_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.uploadAuthorizedSig_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.uploadAuthorizedSig_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.uploadAuthorizedSig_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.uploadAuthorizedSig_bttn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.uploadAuthorizedSig_bttn.Font = New System.Drawing.Font("Candara", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploadAuthorizedSig_bttn.ForeColor = System.Drawing.Color.White
        Me.uploadAuthorizedSig_bttn.Location = New System.Drawing.Point(875, 526)
        Me.uploadAuthorizedSig_bttn.Name = "uploadAuthorizedSig_bttn"
        Me.uploadAuthorizedSig_bttn.Size = New System.Drawing.Size(66, 28)
        Me.uploadAuthorizedSig_bttn.TabIndex = 221
        Me.uploadAuthorizedSig_bttn.Text = "Upload"
        '
        'save_bttn
        '
        Me.save_bttn.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.save_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.save_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.save_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.save_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.save_bttn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.save_bttn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_bttn.ForeColor = System.Drawing.Color.White
        Me.save_bttn.Location = New System.Drawing.Point(761, 572)
        Me.save_bttn.Name = "save_bttn"
        Me.save_bttn.Size = New System.Drawing.Size(180, 45)
        Me.save_bttn.TabIndex = 223
        Me.save_bttn.Text = "Update"
        '
        'adminSigPic
        '
        Me.adminSigPic.ImageRotate = 0!
        Me.adminSigPic.Location = New System.Drawing.Point(631, 435)
        Me.adminSigPic.Name = "adminSigPic"
        Me.adminSigPic.Size = New System.Drawing.Size(310, 90)
        Me.adminSigPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.adminSigPic.TabIndex = 222
        Me.adminSigPic.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(699, 338)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 22)
        Me.Label10.TabIndex = 265
        Me.Label10.Text = "Client's Signature"
        '
        'clientSigPic
        '
        Me.clientSigPic.ImageRotate = 0!
        Me.clientSigPic.Location = New System.Drawing.Point(641, 242)
        Me.clientSigPic.Name = "clientSigPic"
        Me.clientSigPic.Size = New System.Drawing.Size(310, 90)
        Me.clientSigPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.clientSigPic.TabIndex = 264
        Me.clientSigPic.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(417, 585)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 21)
        Me.Label9.TabIndex = 219
        Me.Label9.Text = "Total Amount:"
        '
        'totalamountC
        '
        Me.totalamountC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.totalamountC.DefaultText = ""
        Me.totalamountC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.totalamountC.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.totalamountC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalamountC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalamountC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalamountC.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalamountC.ForeColor = System.Drawing.Color.Black
        Me.totalamountC.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalamountC.Location = New System.Drawing.Point(352, 509)
        Me.totalamountC.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.totalamountC.Name = "totalamountC"
        Me.totalamountC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.totalamountC.PlaceholderForeColor = System.Drawing.Color.Black
        Me.totalamountC.PlaceholderText = ""
        Me.totalamountC.SelectedText = ""
        Me.totalamountC.Size = New System.Drawing.Size(245, 63)
        Me.totalamountC.TabIndex = 220
        '
        'uploadClientSig_bttn
        '
        Me.uploadClientSig_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.uploadClientSig_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.uploadClientSig_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.uploadClientSig_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.uploadClientSig_bttn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.uploadClientSig_bttn.Font = New System.Drawing.Font("Candara", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploadClientSig_bttn.ForeColor = System.Drawing.Color.White
        Me.uploadClientSig_bttn.Location = New System.Drawing.Point(875, 294)
        Me.uploadClientSig_bttn.Name = "uploadClientSig_bttn"
        Me.uploadClientSig_bttn.Size = New System.Drawing.Size(66, 28)
        Me.uploadClientSig_bttn.TabIndex = 263
        Me.uploadClientSig_bttn.Text = "Upload"
        '
        'datecontract
        '
        Me.datecontract.BackColor = System.Drawing.Color.Transparent
        Me.datecontract.Checked = True
        Me.datecontract.CustomFormat = "yyyy/MM/dd"
        Me.datecontract.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.datecontract.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Bold)
        Me.datecontract.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.datecontract.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datecontract.Location = New System.Drawing.Point(474, 242)
        Me.datecontract.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.datecontract.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.datecontract.Name = "datecontract"
        Me.datecontract.Size = New System.Drawing.Size(147, 41)
        Me.datecontract.TabIndex = 248
        Me.datecontract.Value = New Date(2022, 11, 22, 16, 42, 24, 410)
        '
        'deceasedbirthdate
        '
        Me.deceasedbirthdate.Checked = True
        Me.deceasedbirthdate.CustomFormat = "yyyy/MM/dd"
        Me.deceasedbirthdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.deceasedbirthdate.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Bold)
        Me.deceasedbirthdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.deceasedbirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.deceasedbirthdate.Location = New System.Drawing.Point(513, 369)
        Me.deceasedbirthdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.deceasedbirthdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.deceasedbirthdate.Name = "deceasedbirthdate"
        Me.deceasedbirthdate.Size = New System.Drawing.Size(168, 38)
        Me.deceasedbirthdate.TabIndex = 247
        Me.deceasedbirthdate.Value = New Date(2022, 11, 22, 16, 42, 24, 410)
        '
        'deceaseddatedeath
        '
        Me.deceaseddatedeath.Checked = True
        Me.deceaseddatedeath.CustomFormat = "yyyy/MM/dd"
        Me.deceaseddatedeath.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.deceaseddatedeath.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deceaseddatedeath.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.deceaseddatedeath.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.deceaseddatedeath.Location = New System.Drawing.Point(765, 369)
        Me.deceaseddatedeath.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.deceaseddatedeath.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.deceaseddatedeath.Name = "deceaseddatedeath"
        Me.deceaseddatedeath.Size = New System.Drawing.Size(176, 38)
        Me.deceaseddatedeath.TabIndex = 244
        Me.deceaseddatedeath.Value = New Date(2022, 11, 22, 16, 42, 24, 410)
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(41, 477)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(141, 21)
        Me.Label24.TabIndex = 243
        Me.Label24.Text = "Complete Address"
        '
        'deceasedaddress
        '
        Me.deceasedaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.deceasedaddress.DefaultText = ""
        Me.deceasedaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.deceasedaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.deceasedaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.deceasedaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.deceasedaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.deceasedaddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.deceasedaddress.ForeColor = System.Drawing.Color.Black
        Me.deceasedaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.deceasedaddress.Location = New System.Drawing.Point(32, 435)
        Me.deceasedaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.deceasedaddress.Name = "deceasedaddress"
        Me.deceasedaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.deceasedaddress.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.deceasedaddress.PlaceholderText = "Complete Address"
        Me.deceasedaddress.SelectedText = ""
        Me.deceasedaddress.Size = New System.Drawing.Size(503, 38)
        Me.deceasedaddress.TabIndex = 242
        '
        'deceasedage
        '
        Me.deceasedage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.deceasedage.DefaultText = ""
        Me.deceasedage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.deceasedage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.deceasedage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.deceasedage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.deceasedage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.deceasedage.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.deceasedage.ForeColor = System.Drawing.Color.Black
        Me.deceasedage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.deceasedage.Location = New System.Drawing.Point(386, 368)
        Me.deceasedage.Margin = New System.Windows.Forms.Padding(4)
        Me.deceasedage.Name = "deceasedage"
        Me.deceasedage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.deceasedage.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.deceasedage.PlaceholderText = "Age"
        Me.deceasedage.SelectedText = ""
        Me.deceasedage.Size = New System.Drawing.Size(65, 38)
        Me.deceasedage.TabIndex = 241
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(403, 410)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 21)
        Me.Label23.TabIndex = 240
        Me.Label23.Text = "Age"
        '
        'namedeceasedM
        '
        Me.namedeceasedM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.namedeceasedM.DefaultText = ""
        Me.namedeceasedM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.namedeceasedM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.namedeceasedM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.namedeceasedM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.namedeceasedM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namedeceasedM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.namedeceasedM.ForeColor = System.Drawing.Color.Black
        Me.namedeceasedM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namedeceasedM.Location = New System.Drawing.Point(32, 368)
        Me.namedeceasedM.Margin = New System.Windows.Forms.Padding(4)
        Me.namedeceasedM.Name = "namedeceasedM"
        Me.namedeceasedM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.namedeceasedM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.namedeceasedM.PlaceholderText = "Complete Name"
        Me.namedeceasedM.SelectedText = ""
        Me.namedeceasedM.Size = New System.Drawing.Size(333, 38)
        Me.namedeceasedM.TabIndex = 239
        '
        'relationship
        '
        Me.relationship.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.relationship.DefaultText = ""
        Me.relationship.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.relationship.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.relationship.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.relationship.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.relationship.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.relationship.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.relationship.ForeColor = System.Drawing.Color.Black
        Me.relationship.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.relationship.Location = New System.Drawing.Point(32, 242)
        Me.relationship.Margin = New System.Windows.Forms.Padding(4)
        Me.relationship.Name = "relationship"
        Me.relationship.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.relationship.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.relationship.PlaceholderText = "Relationship"
        Me.relationship.SelectedText = ""
        Me.relationship.Size = New System.Drawing.Size(419, 35)
        Me.relationship.TabIndex = 237
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(21, 18)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(338, 43)
        Me.Guna2HtmlLabel1.TabIndex = 236
        Me.Guna2HtmlLabel1.Text = "Client Information"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 217)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 21)
        Me.Label3.TabIndex = 235
        Me.Label3.Text = "Complete Address"
        '
        'contactnumberM
        '
        Me.contactnumberM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contactnumberM.DefaultText = ""
        Me.contactnumberM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.contactnumberM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.contactnumberM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contactnumberM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contactnumberM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contactnumberM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.contactnumberM.ForeColor = System.Drawing.Color.Black
        Me.contactnumberM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contactnumberM.Location = New System.Drawing.Point(578, 105)
        Me.contactnumberM.Margin = New System.Windows.Forms.Padding(4)
        Me.contactnumberM.Name = "contactnumberM"
        Me.contactnumberM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contactnumberM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.contactnumberM.PlaceholderText = "Contact Number"
        Me.contactnumberM.SelectedText = ""
        Me.contactnumberM.Size = New System.Drawing.Size(363, 41)
        Me.contactnumberM.TabIndex = 234
        '
        'addressM
        '
        Me.addressM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.addressM.DefaultText = ""
        Me.addressM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.addressM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.addressM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.addressM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.addressM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.addressM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.addressM.ForeColor = System.Drawing.Color.Black
        Me.addressM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.addressM.Location = New System.Drawing.Point(32, 175)
        Me.addressM.Margin = New System.Windows.Forms.Padding(4)
        Me.addressM.Name = "addressM"
        Me.addressM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.addressM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.addressM.PlaceholderText = "Complete Address"
        Me.addressM.SelectedText = ""
        Me.addressM.Size = New System.Drawing.Size(787, 38)
        Me.addressM.TabIndex = 233
        '
        'ageM
        '
        Me.ageM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ageM.DefaultText = ""
        Me.ageM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ageM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ageM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ageM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ageM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ageM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ageM.ForeColor = System.Drawing.Color.Black
        Me.ageM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ageM.Location = New System.Drawing.Point(464, 107)
        Me.ageM.Margin = New System.Windows.Forms.Padding(4)
        Me.ageM.Name = "ageM"
        Me.ageM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ageM.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.ageM.PlaceholderText = "Age"
        Me.ageM.SelectedText = ""
        Me.ageM.Size = New System.Drawing.Size(89, 41)
        Me.ageM.TabIndex = 232
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.clientID_TBM)
        Me.Panel2.Controls.Add(Me.update_PackagesCM)
        Me.Panel2.Controls.Add(Me.ClientNameCM)
        Me.Panel2.Controls.Add(Me.clear_bttnM)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.uploadAuthorizedSig_bttn)
        Me.Panel2.Controls.Add(Me.save_bttn)
        Me.Panel2.Controls.Add(Me.adminSigPic)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.clientSigPic)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.totalamountC)
        Me.Panel2.Controls.Add(Me.uploadClientSig_bttn)
        Me.Panel2.Controls.Add(Me.datecontract)
        Me.Panel2.Controls.Add(Me.deceasedbirthdate)
        Me.Panel2.Controls.Add(Me.deceaseddatedeath)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.deceasedaddress)
        Me.Panel2.Controls.Add(Me.deceasedage)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.namedeceasedM)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel2.Controls.Add(Me.relationship)
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.contactnumberM)
        Me.Panel2.Controls.Add(Me.addressM)
        Me.Panel2.Controls.Add(Me.ageM)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(968, 672)
        Me.Panel2.TabIndex = 3
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(21, 320)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(347, 41)
        Me.Guna2HtmlLabel2.TabIndex = 238
        Me.Guna2HtmlLabel2.Text = "Deceased Information"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(585, 150)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 21)
        Me.Label5.TabIndex = 229
        Me.Label5.Text = "Contact Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(481, 152)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 21)
        Me.Label6.TabIndex = 230
        Me.Label6.Text = "Age"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 149)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 20)
        Me.Label7.TabIndex = 231
        Me.Label7.Text = "Client Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(520, 410)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 21)
        Me.Label14.TabIndex = 224
        Me.Label14.Text = "Birthdate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(792, 411)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 21)
        Me.Label12.TabIndex = 228
        Me.Label12.Text = "Date of Death"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 410)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 21)
        Me.Label11.TabIndex = 225
        Me.Label11.Text = "Name of Deceased"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(470, 286)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 21)
        Me.Label8.TabIndex = 226
        Me.Label8.Text = "Date of Contract"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 281)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 21)
        Me.Label4.TabIndex = 227
        Me.Label4.Text = "Relationship to the Deceased"
        '
        'UpdateContractInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 672)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UpdateContractInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateContractInformation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.back_bttn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adminSigPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clientSigPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents update_PackagesCM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ClientNameCM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents clear_bttnM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clientID_TBM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents uploadAuthorizedSig_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents save_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adminSigPic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents clientSigPic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents totalamountC As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents uploadClientSig_bttn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents datecontract As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents deceasedbirthdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents deceaseddatedeath As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents deceasedaddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents deceasedage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents namedeceasedM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents relationship As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents contactnumberM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents addressM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ageM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents back_bttn As PictureBox
    Friend WithEvents ContractPrintBtn As Guna.UI2.WinForms.Guna2Button
End Class
