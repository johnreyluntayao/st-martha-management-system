<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractPaymentRecord
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.search_btn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.contractPaymentRecDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.contractPaymentRecDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel1.Controls.Add(Me.search_btn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 100)
        Me.Panel1.TabIndex = 0
        '
        'search_btn
        '
        Me.search_btn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.search_btn.DefaultText = ""
        Me.search_btn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.search_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.search_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.search_btn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.search_btn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search_btn.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search_btn.Location = New System.Drawing.Point(593, 25)
        Me.search_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.search_btn.PlaceholderText = "Search"
        Me.search_btn.SelectedText = ""
        Me.search_btn.Size = New System.Drawing.Size(363, 46)
        Me.search_btn.TabIndex = 110
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(36, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(458, 49)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Contract Payment Record"
        '
        'contractPaymentRecDGV
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.contractPaymentRecDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.contractPaymentRecDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.contractPaymentRecDGV.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.contractPaymentRecDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.contractPaymentRecDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.contractPaymentRecDGV.Location = New System.Drawing.Point(45, 179)
        Me.contractPaymentRecDGV.Name = "contractPaymentRecDGV"
        Me.contractPaymentRecDGV.RowHeadersVisible = False
        Me.contractPaymentRecDGV.RowHeadersWidth = 51
        Me.contractPaymentRecDGV.RowTemplate.Height = 24
        Me.contractPaymentRecDGV.Size = New System.Drawing.Size(911, 379)
        Me.contractPaymentRecDGV.TabIndex = 4
        Me.contractPaymentRecDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver
        Me.contractPaymentRecDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.contractPaymentRecDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.contractPaymentRecDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.contractPaymentRecDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.contractPaymentRecDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.contractPaymentRecDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.contractPaymentRecDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.contractPaymentRecDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.contractPaymentRecDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.contractPaymentRecDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contractPaymentRecDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.contractPaymentRecDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.contractPaymentRecDGV.ThemeStyle.HeaderStyle.Height = 30
        Me.contractPaymentRecDGV.ThemeStyle.ReadOnly = False
        Me.contractPaymentRecDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.contractPaymentRecDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.contractPaymentRecDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contractPaymentRecDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.contractPaymentRecDGV.ThemeStyle.RowsStyle.Height = 24
        Me.contractPaymentRecDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.contractPaymentRecDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'ContractPaymentRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 658)
        Me.Controls.Add(Me.contractPaymentRecDGV)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ContractPaymentRecord"
        Me.Text = "ContractPaymentRecord"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.contractPaymentRecDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents search_btn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents contractPaymentRecDGV As Guna.UI2.WinForms.Guna2DataGridView
End Class
