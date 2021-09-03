<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataForm))
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.SettingBtn = New System.Windows.Forms.Button()
        Me.TimeBtn = New System.Windows.Forms.Button()
        Me.HubBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimeList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SlpTmeDate = New System.Windows.Forms.Label()
        Me.ClrBtn = New System.Windows.Forms.Button()
        Me.DataBtn = New System.Windows.Forms.Button()
        Me.SSVersion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HelpBtn
        '
        Me.HelpBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.HelpBtn.Location = New System.Drawing.Point(303, 21)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(66, 32)
        Me.HelpBtn.TabIndex = 40
        Me.HelpBtn.Text = "HelpBtn"
        Me.HelpBtn.UseVisualStyleBackColor = False
        '
        'SettingBtn
        '
        Me.SettingBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.SettingBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingBtn.Location = New System.Drawing.Point(157, 21)
        Me.SettingBtn.Name = "SettingBtn"
        Me.SettingBtn.Size = New System.Drawing.Size(66, 32)
        Me.SettingBtn.TabIndex = 38
        Me.SettingBtn.Text = "SettingBtn"
        Me.SettingBtn.UseVisualStyleBackColor = False
        '
        'TimeBtn
        '
        Me.TimeBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.TimeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeBtn.Location = New System.Drawing.Point(85, 21)
        Me.TimeBtn.Name = "TimeBtn"
        Me.TimeBtn.Size = New System.Drawing.Size(66, 32)
        Me.TimeBtn.TabIndex = 37
        Me.TimeBtn.Text = "TimeBtn"
        Me.TimeBtn.UseVisualStyleBackColor = False
        '
        'HubBtn
        '
        Me.HubBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.HubBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HubBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HubBtn.Location = New System.Drawing.Point(13, 21)
        Me.HubBtn.Name = "HubBtn"
        Me.HubBtn.Size = New System.Drawing.Size(66, 32)
        Me.HubBtn.TabIndex = 36
        Me.HubBtn.Text = "HubBtn"
        Me.HubBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(2, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(379, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "______________________________________________________________"
        '
        'TimeList
        '
        Me.TimeList.BackColor = System.Drawing.Color.Black
        Me.TimeList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeList.ForeColor = System.Drawing.Color.Gainsboro
        Me.TimeList.FormattingEnabled = True
        Me.TimeList.ItemHeight = 20
        Me.TimeList.Location = New System.Drawing.Point(12, 121)
        Me.TimeList.Name = "TimeList"
        Me.TimeList.Size = New System.Drawing.Size(360, 164)
        Me.TimeList.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(2, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "______________________________________________________________"
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.CloseBtn.Location = New System.Drawing.Point(297, 376)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(66, 32)
        Me.CloseBtn.TabIndex = 42
        Me.CloseBtn.Text = "CloselBtn"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(17, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 24)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Total:"
        '
        'DataTotal
        '
        Me.DataTotal.AutoSize = True
        Me.DataTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataTotal.ForeColor = System.Drawing.Color.Gainsboro
        Me.DataTotal.Location = New System.Drawing.Point(85, 78)
        Me.DataTotal.Name = "DataTotal"
        Me.DataTotal.Size = New System.Drawing.Size(97, 24)
        Me.DataTotal.TabIndex = 45
        Me.DataTotal.Text = "DataTotal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(10, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 18)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Latest Sleep Timer end:"
        '
        'SlpTmeDate
        '
        Me.SlpTmeDate.AutoSize = True
        Me.SlpTmeDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlpTmeDate.ForeColor = System.Drawing.Color.Gainsboro
        Me.SlpTmeDate.Location = New System.Drawing.Point(202, 315)
        Me.SlpTmeDate.Name = "SlpTmeDate"
        Me.SlpTmeDate.Size = New System.Drawing.Size(95, 16)
        Me.SlpTmeDate.TabIndex = 47
        Me.SlpTmeDate.Text = "SlpTmeDate"
        '
        'ClrBtn
        '
        Me.ClrBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.ClrBtn.Location = New System.Drawing.Point(216, 376)
        Me.ClrBtn.Name = "ClrBtn"
        Me.ClrBtn.Size = New System.Drawing.Size(66, 32)
        Me.ClrBtn.TabIndex = 48
        Me.ClrBtn.Text = "ClrBtn"
        Me.ClrBtn.UseVisualStyleBackColor = False
        '
        'DataBtn
        '
        Me.DataBtn.BackColor = System.Drawing.Color.DarkGray
        Me.DataBtn.Enabled = False
        Me.DataBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataBtn.Location = New System.Drawing.Point(231, 21)
        Me.DataBtn.Name = "DataBtn"
        Me.DataBtn.Size = New System.Drawing.Size(66, 36)
        Me.DataBtn.TabIndex = 49
        Me.DataBtn.Text = "DataBtn"
        Me.DataBtn.UseVisualStyleBackColor = False
        '
        'SSVersion
        '
        Me.SSVersion.AutoSize = True
        Me.SSVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SSVersion.Location = New System.Drawing.Point(2, 395)
        Me.SSVersion.Name = "SSVersion"
        Me.SSVersion.Size = New System.Drawing.Size(78, 13)
        Me.SSVersion.TabIndex = 50
        Me.SSVersion.Text = "SSVersionNum"
        '
        'DataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(384, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.SSVersion)
        Me.Controls.Add(Me.DataBtn)
        Me.Controls.Add(Me.ClrBtn)
        Me.Controls.Add(Me.SlpTmeDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.TimeList)
        Me.Controls.Add(Me.HelpBtn)
        Me.Controls.Add(Me.SettingBtn)
        Me.Controls.Add(Me.TimeBtn)
        Me.Controls.Add(Me.HubBtn)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 450)
        Me.MinimumSize = New System.Drawing.Size(400, 450)
        Me.Name = "DataForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SmartSleep"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HelpBtn As Button
    Friend WithEvents SettingBtn As Button
    Friend WithEvents TimeBtn As Button
    Friend WithEvents HubBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TimeList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseBtn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents DataTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SlpTmeDate As Label
    Friend WithEvents ClrBtn As Button
    Friend WithEvents DataBtn As Button
    Friend WithEvents SSVersion As Label
End Class
