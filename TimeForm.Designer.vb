<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TimeForm))
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.DataBtn = New System.Windows.Forms.Button()
        Me.SettingBtn = New System.Windows.Forms.Button()
        Me.TimeBtn = New System.Windows.Forms.Button()
        Me.HubBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SlpTmeSet = New System.Windows.Forms.Label()
        Me.Plus15 = New System.Windows.Forms.Button()
        Me.Plus60 = New System.Windows.Forms.Button()
        Me.Min15 = New System.Windows.Forms.Button()
        Me.Min60 = New System.Windows.Forms.Button()
        Me.MainTmrSet = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Min5 = New System.Windows.Forms.Button()
        Me.Min30 = New System.Windows.Forms.Button()
        Me.Plus5 = New System.Windows.Forms.Button()
        Me.Plus30 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.SSVersion = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HelpBtn
        '
        Me.HelpBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.HelpBtn.Location = New System.Drawing.Point(303, 21)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(66, 32)
        Me.HelpBtn.TabIndex = 28
        Me.HelpBtn.Text = "HelpBtn"
        Me.HelpBtn.UseVisualStyleBackColor = False
        '
        'DataBtn
        '
        Me.DataBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.DataBtn.Location = New System.Drawing.Point(231, 21)
        Me.DataBtn.Name = "DataBtn"
        Me.DataBtn.Size = New System.Drawing.Size(66, 32)
        Me.DataBtn.TabIndex = 27
        Me.DataBtn.Text = "DataBtn"
        Me.DataBtn.UseVisualStyleBackColor = False
        '
        'SettingBtn
        '
        Me.SettingBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.SettingBtn.Location = New System.Drawing.Point(157, 21)
        Me.SettingBtn.Name = "SettingBtn"
        Me.SettingBtn.Size = New System.Drawing.Size(66, 32)
        Me.SettingBtn.TabIndex = 26
        Me.SettingBtn.Text = "SettingBtn"
        Me.SettingBtn.UseVisualStyleBackColor = False
        '
        'TimeBtn
        '
        Me.TimeBtn.BackColor = System.Drawing.Color.DarkGray
        Me.TimeBtn.Enabled = False
        Me.TimeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeBtn.Location = New System.Drawing.Point(85, 21)
        Me.TimeBtn.Name = "TimeBtn"
        Me.TimeBtn.Size = New System.Drawing.Size(66, 36)
        Me.TimeBtn.TabIndex = 25
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
        Me.HubBtn.TabIndex = 24
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
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "______________________________________________________________"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(3, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(379, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "______________________________________________________________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(21, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Main Timer:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(12, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 24)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Sleep Timer:"
        '
        'SlpTmeSet
        '
        Me.SlpTmeSet.AutoSize = True
        Me.SlpTmeSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlpTmeSet.ForeColor = System.Drawing.Color.Gainsboro
        Me.SlpTmeSet.Location = New System.Drawing.Point(148, 75)
        Me.SlpTmeSet.Name = "SlpTmeSet"
        Me.SlpTmeSet.Size = New System.Drawing.Size(81, 18)
        Me.SlpTmeSet.TabIndex = 33
        Me.SlpTmeSet.Text = "SlpTmeSet"
        '
        'Plus15
        '
        Me.Plus15.BackColor = System.Drawing.Color.Gainsboro
        Me.Plus15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plus15.Location = New System.Drawing.Point(231, 132)
        Me.Plus15.Name = "Plus15"
        Me.Plus15.Size = New System.Drawing.Size(66, 32)
        Me.Plus15.TabIndex = 34
        Me.Plus15.Text = "Plus15"
        Me.Plus15.UseVisualStyleBackColor = False
        '
        'Plus60
        '
        Me.Plus60.BackColor = System.Drawing.Color.Gainsboro
        Me.Plus60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plus60.Location = New System.Drawing.Point(303, 132)
        Me.Plus60.Name = "Plus60"
        Me.Plus60.Size = New System.Drawing.Size(66, 32)
        Me.Plus60.TabIndex = 35
        Me.Plus60.Text = "Plus60"
        Me.Plus60.UseVisualStyleBackColor = False
        '
        'Min15
        '
        Me.Min15.BackColor = System.Drawing.Color.Gainsboro
        Me.Min15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Min15.Location = New System.Drawing.Point(85, 132)
        Me.Min15.Name = "Min15"
        Me.Min15.Size = New System.Drawing.Size(66, 32)
        Me.Min15.TabIndex = 36
        Me.Min15.Text = "Min15"
        Me.Min15.UseVisualStyleBackColor = False
        '
        'Min60
        '
        Me.Min60.BackColor = System.Drawing.Color.Gainsboro
        Me.Min60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Min60.Location = New System.Drawing.Point(13, 132)
        Me.Min60.Name = "Min60"
        Me.Min60.Size = New System.Drawing.Size(66, 32)
        Me.Min60.TabIndex = 37
        Me.Min60.Text = "Min60"
        Me.Min60.UseVisualStyleBackColor = False
        '
        'MainTmrSet
        '
        Me.MainTmrSet.AutoSize = True
        Me.MainTmrSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTmrSet.ForeColor = System.Drawing.Color.Gainsboro
        Me.MainTmrSet.Location = New System.Drawing.Point(148, 242)
        Me.MainTmrSet.Name = "MainTmrSet"
        Me.MainTmrSet.Size = New System.Drawing.Size(89, 18)
        Me.MainTmrSet.TabIndex = 39
        Me.MainTmrSet.Text = "MainTmrSet"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(157, 277)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'Min5
        '
        Me.Min5.BackColor = System.Drawing.Color.Gainsboro
        Me.Min5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Min5.Location = New System.Drawing.Point(13, 295)
        Me.Min5.Name = "Min5"
        Me.Min5.Size = New System.Drawing.Size(66, 32)
        Me.Min5.TabIndex = 43
        Me.Min5.Text = "Min5"
        Me.Min5.UseVisualStyleBackColor = False
        '
        'Min30
        '
        Me.Min30.BackColor = System.Drawing.Color.Gainsboro
        Me.Min30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Min30.Location = New System.Drawing.Point(85, 295)
        Me.Min30.Name = "Min30"
        Me.Min30.Size = New System.Drawing.Size(66, 32)
        Me.Min30.TabIndex = 42
        Me.Min30.Text = "Min30"
        Me.Min30.UseVisualStyleBackColor = False
        '
        'Plus5
        '
        Me.Plus5.BackColor = System.Drawing.Color.Gainsboro
        Me.Plus5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plus5.Location = New System.Drawing.Point(303, 295)
        Me.Plus5.Name = "Plus5"
        Me.Plus5.Size = New System.Drawing.Size(66, 32)
        Me.Plus5.TabIndex = 41
        Me.Plus5.Text = "Plus5"
        Me.Plus5.UseVisualStyleBackColor = False
        '
        'Plus30
        '
        Me.Plus30.BackColor = System.Drawing.Color.Gainsboro
        Me.Plus30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plus30.Location = New System.Drawing.Point(231, 295)
        Me.Plus30.Name = "Plus30"
        Me.Plus30.Size = New System.Drawing.Size(66, 32)
        Me.Plus30.TabIndex = 40
        Me.Plus30.Text = "Plus30"
        Me.Plus30.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(2, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "______________________________________________________________"
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.SaveBtn.Location = New System.Drawing.Point(216, 376)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(66, 32)
        Me.SaveBtn.TabIndex = 46
        Me.SaveBtn.Text = "SaveBtn"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.CloseBtn.Location = New System.Drawing.Point(297, 376)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(66, 32)
        Me.CloseBtn.TabIndex = 45
        Me.CloseBtn.Text = "CloselBtn"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SmartSleep.My.Resources.Resources.SSIconTimer
        Me.PictureBox3.Location = New System.Drawing.Point(159, 96)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(66, 81)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 48
        Me.PictureBox3.TabStop = False
        '
        'SSVersion
        '
        Me.SSVersion.AutoSize = True
        Me.SSVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SSVersion.Location = New System.Drawing.Point(3, 395)
        Me.SSVersion.Name = "SSVersion"
        Me.SSVersion.Size = New System.Drawing.Size(78, 13)
        Me.SSVersion.TabIndex = 49
        Me.SSVersion.Text = "SSVersionNum"
        '
        'TimeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(384, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.SSVersion)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Min5)
        Me.Controls.Add(Me.Min30)
        Me.Controls.Add(Me.Plus5)
        Me.Controls.Add(Me.Plus30)
        Me.Controls.Add(Me.MainTmrSet)
        Me.Controls.Add(Me.Min60)
        Me.Controls.Add(Me.Min15)
        Me.Controls.Add(Me.Plus60)
        Me.Controls.Add(Me.Plus15)
        Me.Controls.Add(Me.SlpTmeSet)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
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
        Me.Name = "TimeForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SmartSleep"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HelpBtn As Button
    Friend WithEvents DataBtn As Button
    Friend WithEvents SettingBtn As Button
    Friend WithEvents TimeBtn As Button
    Friend WithEvents HubBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents SlpTmeSet As Label
    Friend WithEvents Plus15 As Button
    Friend WithEvents Plus60 As Button
    Friend WithEvents Min15 As Button
    Friend WithEvents Min60 As Button
    Friend WithEvents MainTmrSet As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Min5 As Button
    Friend WithEvents Min30 As Button
    Friend WithEvents Plus5 As Button
    Friend WithEvents Plus30 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents CloseBtn As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents SSVersion As Label
End Class
