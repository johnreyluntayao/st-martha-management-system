<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TESTDATE
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
        Me.birthdateee = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.birthdate = New System.Windows.Forms.DateTimePicker()
        Me.kyut = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.SuspendLayout()
        '
        'birthdateee
        '
        Me.birthdateee.Checked = True
        Me.birthdateee.CustomFormat = ""
        Me.birthdateee.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.birthdateee.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.birthdateee.Location = New System.Drawing.Point(295, 186)
        Me.birthdateee.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.birthdateee.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.birthdateee.Name = "birthdateee"
        Me.birthdateee.Size = New System.Drawing.Size(250, 36)
        Me.birthdateee.TabIndex = 0
        Me.birthdateee.Value = New Date(2022, 12, 4, 1, 53, 39, 400)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(359, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'birthdate
        '
        Me.birthdate.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack
        Me.birthdate.CalendarTitleBackColor = System.Drawing.Color.IndianRed
        Me.birthdate.CustomFormat = ""
        Me.birthdate.Font = New System.Drawing.Font("Candara", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.birthdate.Location = New System.Drawing.Point(295, 114)
        Me.birthdate.Name = "birthdate"
        Me.birthdate.Size = New System.Drawing.Size(250, 40)
        Me.birthdate.TabIndex = 2
        Me.birthdate.Value = New Date(2022, 12, 25, 0, 0, 0, 0)
        '
        'kyut
        '
        Me.kyut.Checked = True
        Me.kyut.CustomFormat = "yyyy/MM/dd"
        Me.kyut.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kyut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.kyut.Location = New System.Drawing.Point(295, 253)
        Me.kyut.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.kyut.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.kyut.Name = "kyut"
        Me.kyut.Size = New System.Drawing.Size(250, 36)
        Me.kyut.TabIndex = 3
        Me.kyut.Value = New Date(2022, 12, 4, 2, 38, 19, 334)
        '
        'TESTDATE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.kyut)
        Me.Controls.Add(Me.birthdate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.birthdateee)
        Me.Name = "TESTDATE"
        Me.Text = "TESTDATE"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents birthdateee As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents birthdate As DateTimePicker
    Friend WithEvents kyut As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
