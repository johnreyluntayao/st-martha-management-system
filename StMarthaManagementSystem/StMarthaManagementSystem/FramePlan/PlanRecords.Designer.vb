<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanRecords
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
        Me.search_btnM = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.planRecDGVM = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.planRecDGVM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel1.Controls.Add(Me.search_btnM)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1450, 100)
        Me.Panel1.TabIndex = 0
        '
        'search_btnM
        '
        Me.search_btnM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.search_btnM.DefaultText = ""
        Me.search_btnM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.search_btnM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.search_btnM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.search_btnM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.search_btnM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search_btnM.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_btnM.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.search_btnM.Location = New System.Drawing.Point(710, 25)
        Me.search_btnM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.search_btnM.Name = "search_btnM"
        Me.search_btnM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.search_btnM.PlaceholderText = "Search"
        Me.search_btnM.SelectedText = ""
        Me.search_btnM.Size = New System.Drawing.Size(363, 46)
        Me.search_btnM.TabIndex = 113
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(43, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 49)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Plan Records"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.planRecDGVM)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1450, 563)
        Me.Panel2.TabIndex = 1
        '
        'planRecDGVM
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.planRecDGVM.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.planRecDGVM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.planRecDGVM.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.planRecDGVM.DefaultCellStyle = DataGridViewCellStyle3
        Me.planRecDGVM.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.planRecDGVM.Location = New System.Drawing.Point(95, 76)
        Me.planRecDGVM.Name = "planRecDGVM"
        Me.planRecDGVM.RowHeadersVisible = False
        Me.planRecDGVM.RowHeadersWidth = 51
        Me.planRecDGVM.RowTemplate.Height = 24
        Me.planRecDGVM.Size = New System.Drawing.Size(911, 379)
        Me.planRecDGVM.TabIndex = 6
        Me.planRecDGVM.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver
        Me.planRecDGVM.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.planRecDGVM.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.planRecDGVM.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.planRecDGVM.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.planRecDGVM.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.planRecDGVM.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.planRecDGVM.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.planRecDGVM.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.planRecDGVM.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.planRecDGVM.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planRecDGVM.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.planRecDGVM.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.planRecDGVM.ThemeStyle.HeaderStyle.Height = 30
        Me.planRecDGVM.ThemeStyle.ReadOnly = False
        Me.planRecDGVM.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.planRecDGVM.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.planRecDGVM.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.planRecDGVM.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.planRecDGVM.ThemeStyle.RowsStyle.Height = 24
        Me.planRecDGVM.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.planRecDGVM.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'PlanRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 725)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PlanRecords"
        Me.Text = "AddPlanForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.planRecDGVM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents search_btnM As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents planRecDGVM As Guna.UI2.WinForms.Guna2DataGridView
End Class
