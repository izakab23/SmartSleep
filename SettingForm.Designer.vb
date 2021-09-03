<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingForm))
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.DataBtn = New System.Windows.Forms.Button()
        Me.SettingBtn = New System.Windows.Forms.Button()
        Me.TimeBtn = New System.Windows.Forms.Button()
        Me.HubBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.SmrtSlpCheck = New System.Windows.Forms.CheckBox()
        Me.SmrtClsCheck = New System.Windows.Forms.CheckBox()
        Me.TwoStepCheck = New System.Windows.Forms.CheckBox()
        Me.DelayCheck = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VarTmeTxtBox = New System.Windows.Forms.TextBox()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.RawOpCheck = New System.Windows.Forms.CheckBox()
        Me.SSVersion = New System.Windows.Forms.Label()
        Me.PopTabCeck = New System.Windows.Forms.CheckBox()
        Me.SlpTmrShtDwn = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'HelpBtn
        '
        Me.HelpBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.HelpBtn.Location = New System.Drawing.Point(303, 21)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(66, 32)
        Me.HelpBtn.TabIndex = 34
        Me.HelpBtn.Text = "HelpBtn"
        Me.HelpBtn.UseVisualStyleBackColor = False
        '
        'DataBtn
        '
        Me.DataBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.DataBtn.Location = New System.Drawing.Point(231, 21)
        Me.DataBtn.Name = "DataBtn"
        Me.DataBtn.Size = New System.Drawing.Size(66, 32)
        Me.DataBtn.TabIndex = 33
        Me.DataBtn.Text = "DataBtn"
        Me.DataBtn.UseVisualStyleBackColor = False
        '
        'SettingBtn
        '
        Me.SettingBtn.BackColor = System.Drawing.Color.DarkGray
        Me.SettingBtn.Enabled = False
        Me.SettingBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingBtn.Location = New System.Drawing.Point(157, 21)
        Me.SettingBtn.Name = "SettingBtn"
        Me.SettingBtn.Size = New System.Drawing.Size(66, 36)
        Me.SettingBtn.TabIndex = 32
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
        Me.TimeBtn.TabIndex = 31
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
        Me.HubBtn.TabIndex = 30
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
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "______________________________________________________________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(2, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "______________________________________________________________"
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.CloseBtn.Location = New System.Drawing.Point(297, 376)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(66, 32)
        Me.CloseBtn.TabIndex = 35
        Me.CloseBtn.Text = "CloselBtn"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'SmrtSlpCheck
        '
        Me.SmrtSlpCheck.AutoSize = True
        Me.SmrtSlpCheck.Checked = True
        Me.SmrtSlpCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SmrtSlpCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SmrtSlpCheck.ForeColor = System.Drawing.Color.Gainsboro
        Me.SmrtSlpCheck.Location = New System.Drawing.Point(12, 101)
        Me.SmrtSlpCheck.Name = "SmrtSlpCheck"
        Me.SmrtSlpCheck.Size = New System.Drawing.Size(130, 24)
        Me.SmrtSlpCheck.TabIndex = 38
        Me.SmrtSlpCheck.Text = "SmrtSlpCheck"
        Me.SmrtSlpCheck.UseVisualStyleBackColor = True
        '
        'SmrtClsCheck
        '
        Me.SmrtClsCheck.AutoSize = True
        Me.SmrtClsCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SmrtClsCheck.ForeColor = System.Drawing.Color.Gainsboro
        Me.SmrtClsCheck.Location = New System.Drawing.Point(12, 131)
        Me.SmrtClsCheck.Name = "SmrtClsCheck"
        Me.SmrtClsCheck.Size = New System.Drawing.Size(129, 24)
        Me.SmrtClsCheck.TabIndex = 42
        Me.SmrtClsCheck.Text = "SmrtClsCheck"
        Me.SmrtClsCheck.UseVisualStyleBackColor = True
        '
        'TwoStepCheck
        '
        Me.TwoStepCheck.AutoSize = True
        Me.TwoStepCheck.Checked = True
        Me.TwoStepCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TwoStepCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TwoStepCheck.ForeColor = System.Drawing.Color.Gainsboro
        Me.TwoStepCheck.Location = New System.Drawing.Point(157, 101)
        Me.TwoStepCheck.Name = "TwoStepCheck"
        Me.TwoStepCheck.Size = New System.Drawing.Size(136, 24)
        Me.TwoStepCheck.TabIndex = 43
        Me.TwoStepCheck.Text = "TwoStepCheck"
        Me.TwoStepCheck.UseVisualStyleBackColor = True
        '
        'DelayCheck
        '
        Me.DelayCheck.AutoSize = True
        Me.DelayCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelayCheck.ForeColor = System.Drawing.Color.Gainsboro
        Me.DelayCheck.Location = New System.Drawing.Point(157, 131)
        Me.DelayCheck.Name = "DelayCheck"
        Me.DelayCheck.Size = New System.Drawing.Size(113, 24)
        Me.DelayCheck.TabIndex = 44
        Me.DelayCheck.Text = "DelayCheck"
        Me.DelayCheck.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(3, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(379, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "______________________________________________________________"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(12, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 24)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Settings:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(12, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 24)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Advanced Settings:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(12, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(246, 20)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "SmartSleep/Close Timer Variable:"
        '
        'VarTmeTxtBox
        '
        Me.VarTmeTxtBox.BackColor = System.Drawing.Color.Black
        Me.VarTmeTxtBox.ForeColor = System.Drawing.Color.Gainsboro
        Me.VarTmeTxtBox.Location = New System.Drawing.Point(259, 267)
        Me.VarTmeTxtBox.Name = "VarTmeTxtBox"
        Me.VarTmeTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.VarTmeTxtBox.TabIndex = 49
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.UpdateBtn.Location = New System.Drawing.Point(272, 293)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(75, 23)
        Me.UpdateBtn.TabIndex = 50
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = False
        '
        'RawOpCheck
        '
        Me.RawOpCheck.AutoSize = True
        Me.RawOpCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RawOpCheck.ForeColor = System.Drawing.Color.Gainsboro
        Me.RawOpCheck.Location = New System.Drawing.Point(12, 309)
        Me.RawOpCheck.Name = "RawOpCheck"
        Me.RawOpCheck.Size = New System.Drawing.Size(126, 24)
        Me.RawOpCheck.TabIndex = 51
        Me.RawOpCheck.Text = "RawOpCheck"
        Me.RawOpCheck.UseVisualStyleBackColor = True
        '
        'SSVersion
        '
        Me.SSVersion.AutoSize = True
        Me.SSVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SSVersion.Location = New System.Drawing.Point(2, 395)
        Me.SSVersion.Name = "SSVersion"
        Me.SSVersion.Size = New System.Drawing.Size(78, 13)
        Me.SSVersion.TabIndex = 52
        Me.SSVersion.Text = "SSVersionNum"
        '
        'PopTabCeck
        '
        Me.PopTabCeck.AutoSize = True
        Me.PopTabCeck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopTabCeck.ForeColor = System.Drawing.Color.Gainsboro
        Me.PopTabCeck.Location = New System.Drawing.Point(13, 161)
        Me.PopTabCeck.Name = "PopTabCeck"
        Me.PopTabCeck.Size = New System.Drawing.Size(128, 24)
        Me.PopTabCeck.TabIndex = 53
        Me.PopTabCeck.Text = "PopTabCheck"
        Me.PopTabCeck.UseVisualStyleBackColor = True
        '
        'SlpTmrShtDwn
        '
        Me.SlpTmrShtDwn.AutoSize = True
        Me.SlpTmrShtDwn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlpTmrShtDwn.ForeColor = System.Drawing.Color.Gainsboro
        Me.SlpTmrShtDwn.Location = New System.Drawing.Point(157, 161)
        Me.SlpTmrShtDwn.Name = "SlpTmrShtDwn"
        Me.SlpTmrShtDwn.Size = New System.Drawing.Size(135, 24)
        Me.SlpTmrShtDwn.TabIndex = 54
        Me.SlpTmrShtDwn.Text = "SlpTmrShtDwn"
        Me.SlpTmrShtDwn.UseVisualStyleBackColor = True
        '
        'SettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(384, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.SlpTmrShtDwn)
        Me.Controls.Add(Me.PopTabCeck)
        Me.Controls.Add(Me.SSVersion)
        Me.Controls.Add(Me.RawOpCheck)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.VarTmeTxtBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DelayCheck)
        Me.Controls.Add(Me.TwoStepCheck)
        Me.Controls.Add(Me.SmrtClsCheck)
        Me.Controls.Add(Me.SmrtSlpCheck)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.HelpBtn)
        Me.Controls.Add(Me.DataBtn)
        Me.Controls.Add(Me.SettingBtn)
        Me.Controls.Add(Me.TimeBtn)
        Me.Controls.Add(Me.HubBtn)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 450)
        Me.MinimumSize = New System.Drawing.Size(400, 450)
        Me.Name = "SettingForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SmartSleep"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HelpBtn As Button
    Friend WithEvents DataBtn As Button
    Friend WithEvents SettingBtn As Button
    Friend WithEvents TimeBtn As Button
    Friend WithEvents HubBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseBtn As Button
    Friend WithEvents SmrtSlpCheck As CheckBox
    Friend WithEvents SmrtClsCheck As CheckBox
    Friend WithEvents TwoStepCheck As CheckBox
    Friend WithEvents DelayCheck As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents VarTmeTxtBox As TextBox
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents RawOpCheck As CheckBox
    Friend WithEvents SSVersion As Label
    Friend WithEvents PopTabCeck As CheckBox
    Friend WithEvents SlpTmrShtDwn As CheckBox
End Class
