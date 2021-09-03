<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HelpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpForm))
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.DataBtn = New System.Windows.Forms.Button()
        Me.SettingBtn = New System.Windows.Forms.Button()
        Me.TimeBtn = New System.Windows.Forms.Button()
        Me.HubBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'HelpBtn
        '
        Me.HelpBtn.BackColor = System.Drawing.Color.DarkGray
        Me.HelpBtn.Enabled = False
        Me.HelpBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpBtn.Location = New System.Drawing.Point(303, 21)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(66, 36)
        Me.HelpBtn.TabIndex = 46
        Me.HelpBtn.Text = "HelpBtn"
        Me.HelpBtn.UseVisualStyleBackColor = False
        '
        'DataBtn
        '
        Me.DataBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.DataBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataBtn.Location = New System.Drawing.Point(231, 21)
        Me.DataBtn.Name = "DataBtn"
        Me.DataBtn.Size = New System.Drawing.Size(66, 32)
        Me.DataBtn.TabIndex = 45
        Me.DataBtn.Text = "DataBtn"
        Me.DataBtn.UseVisualStyleBackColor = False
        '
        'SettingBtn
        '
        Me.SettingBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.SettingBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingBtn.Location = New System.Drawing.Point(157, 21)
        Me.SettingBtn.Name = "SettingBtn"
        Me.SettingBtn.Size = New System.Drawing.Size(66, 32)
        Me.SettingBtn.TabIndex = 44
        Me.SettingBtn.Text = "SettingBtn"
        Me.SettingBtn.UseVisualStyleBackColor = False
        '
        'TimeBtn
        '
        Me.TimeBtn.BackColor = System.Drawing.Color.LightGray
        Me.TimeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeBtn.Location = New System.Drawing.Point(85, 21)
        Me.TimeBtn.Name = "TimeBtn"
        Me.TimeBtn.Size = New System.Drawing.Size(66, 32)
        Me.TimeBtn.TabIndex = 43
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
        Me.HubBtn.TabIndex = 42
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
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "______________________________________________________________"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(5, 79)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(374, 320)
        Me.TextBox1.TabIndex = 47
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'HelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(384, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
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
        Me.Name = "HelpForm"
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
    Friend WithEvents TextBox1 As TextBox
End Class
