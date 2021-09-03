<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.GoBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MainProBar = New System.Windows.Forms.ProgressBar()
        Me.SlpProBar = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SlpTmeTot = New System.Windows.Forms.Label()
        Me.SlpTmeRem = New System.Windows.Forms.Label()
        Me.TmeRem = New System.Windows.Forms.Label()
        Me.TmeTot = New System.Windows.Forms.Label()
        Me.HubBtn = New System.Windows.Forms.Button()
        Me.TimeBtn = New System.Windows.Forms.Button()
        Me.SettingBtn = New System.Windows.Forms.Button()
        Me.DataBtn = New System.Windows.Forms.Button()
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.MainTmr = New System.Windows.Forms.Timer(Me.components)
        Me.SlpTmr = New System.Windows.Forms.Timer(Me.components)
        Me.SSVersion = New System.Windows.Forms.Label()
        Me.EnableBtn = New System.Windows.Forms.Button()
        Me.DelayTmr = New System.Windows.Forms.Timer(Me.components)
        Me.DelayProBar = New System.Windows.Forms.ProgressBar()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SleepLbl = New System.Windows.Forms.Label()
        Me.PopTabTmr = New System.Windows.Forms.Timer(Me.components)
        Me.ShowBtn = New System.Windows.Forms.Button()
        Me.MainLbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.CloseBtn.Location = New System.Drawing.Point(297, 376)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(66, 32)
        Me.CloseBtn.TabIndex = 0
        Me.CloseBtn.Text = "CloselBtn"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'GoBtn
        '
        Me.GoBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.GoBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GoBtn.Location = New System.Drawing.Point(216, 376)
        Me.GoBtn.Name = "GoBtn"
        Me.GoBtn.Size = New System.Drawing.Size(66, 32)
        Me.GoBtn.TabIndex = 1
        Me.GoBtn.Text = "GoBtn"
        Me.GoBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(2, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "______________________________________________________________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(2, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(379, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "______________________________________________________________"
        '
        'MainProBar
        '
        Me.MainProBar.ForeColor = System.Drawing.Color.Firebrick
        Me.MainProBar.Location = New System.Drawing.Point(7, 312)
        Me.MainProBar.Maximum = 120
        Me.MainProBar.Name = "MainProBar"
        Me.MainProBar.Size = New System.Drawing.Size(369, 40)
        Me.MainProBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.MainProBar.TabIndex = 4
        Me.MainProBar.Value = 120
        '
        'SlpProBar
        '
        Me.SlpProBar.BackColor = System.Drawing.Color.Black
        Me.SlpProBar.ForeColor = System.Drawing.Color.Firebrick
        Me.SlpProBar.Location = New System.Drawing.Point(7, 159)
        Me.SlpProBar.Maximum = 3600
        Me.SlpProBar.Name = "SlpProBar"
        Me.SlpProBar.Size = New System.Drawing.Size(369, 40)
        Me.SlpProBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.SlpProBar.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(12, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Main Timer:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(107, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Time:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(27, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Time Remaining:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(3, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(379, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "______________________________________________________________"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(35, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Time Remaining:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(109, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 18)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Time:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(12, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 24)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Sleep Timer:"
        '
        'SlpTmeTot
        '
        Me.SlpTmeTot.AutoSize = True
        Me.SlpTmeTot.Cursor = System.Windows.Forms.Cursors.Default
        Me.SlpTmeTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlpTmeTot.ForeColor = System.Drawing.Color.Gainsboro
        Me.SlpTmeTot.Location = New System.Drawing.Point(173, 101)
        Me.SlpTmeTot.Name = "SlpTmeTot"
        Me.SlpTmeTot.Size = New System.Drawing.Size(81, 18)
        Me.SlpTmeTot.TabIndex = 13
        Me.SlpTmeTot.Text = "SlpTmeTot"
        '
        'SlpTmeRem
        '
        Me.SlpTmeRem.AutoSize = True
        Me.SlpTmeRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlpTmeRem.ForeColor = System.Drawing.Color.Gainsboro
        Me.SlpTmeRem.Location = New System.Drawing.Point(173, 121)
        Me.SlpTmeRem.Name = "SlpTmeRem"
        Me.SlpTmeRem.Size = New System.Drawing.Size(91, 18)
        Me.SlpTmeRem.TabIndex = 14
        Me.SlpTmeRem.Text = "SlpTmeRem"
        '
        'TmeRem
        '
        Me.TmeRem.AutoSize = True
        Me.TmeRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TmeRem.ForeColor = System.Drawing.Color.Gainsboro
        Me.TmeRem.Location = New System.Drawing.Point(173, 284)
        Me.TmeRem.Name = "TmeRem"
        Me.TmeRem.Size = New System.Drawing.Size(70, 18)
        Me.TmeRem.TabIndex = 17
        Me.TmeRem.Text = "TmeRem"
        '
        'TmeTot
        '
        Me.TmeTot.AutoSize = True
        Me.TmeTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TmeTot.ForeColor = System.Drawing.Color.Gainsboro
        Me.TmeTot.Location = New System.Drawing.Point(173, 264)
        Me.TmeTot.Name = "TmeTot"
        Me.TmeTot.Size = New System.Drawing.Size(60, 18)
        Me.TmeTot.TabIndex = 16
        Me.TmeTot.Text = "TmeTot"
        '
        'HubBtn
        '
        Me.HubBtn.BackColor = System.Drawing.Color.DarkGray
        Me.HubBtn.Enabled = False
        Me.HubBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HubBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HubBtn.Location = New System.Drawing.Point(13, 21)
        Me.HubBtn.Name = "HubBtn"
        Me.HubBtn.Size = New System.Drawing.Size(66, 36)
        Me.HubBtn.TabIndex = 18
        Me.HubBtn.Text = "HubBtn"
        Me.HubBtn.UseVisualStyleBackColor = False
        '
        'TimeBtn
        '
        Me.TimeBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.TimeBtn.Location = New System.Drawing.Point(85, 21)
        Me.TimeBtn.Name = "TimeBtn"
        Me.TimeBtn.Size = New System.Drawing.Size(66, 32)
        Me.TimeBtn.TabIndex = 19
        Me.TimeBtn.Text = "TimeBtn"
        Me.TimeBtn.UseVisualStyleBackColor = False
        '
        'SettingBtn
        '
        Me.SettingBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.SettingBtn.Location = New System.Drawing.Point(157, 21)
        Me.SettingBtn.Name = "SettingBtn"
        Me.SettingBtn.Size = New System.Drawing.Size(66, 32)
        Me.SettingBtn.TabIndex = 20
        Me.SettingBtn.Text = "SettingBtn"
        Me.SettingBtn.UseVisualStyleBackColor = False
        '
        'DataBtn
        '
        Me.DataBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.DataBtn.Location = New System.Drawing.Point(231, 21)
        Me.DataBtn.Name = "DataBtn"
        Me.DataBtn.Size = New System.Drawing.Size(66, 32)
        Me.DataBtn.TabIndex = 21
        Me.DataBtn.Text = "DataBtn"
        Me.DataBtn.UseVisualStyleBackColor = False
        '
        'HelpBtn
        '
        Me.HelpBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.HelpBtn.Location = New System.Drawing.Point(303, 21)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(66, 32)
        Me.HelpBtn.TabIndex = 22
        Me.HelpBtn.Text = "HelpBtn"
        Me.HelpBtn.UseVisualStyleBackColor = False
        '
        'MainTmr
        '
        Me.MainTmr.Interval = 1000
        '
        'SlpTmr
        '
        Me.SlpTmr.Interval = 1000
        '
        'SSVersion
        '
        Me.SSVersion.AutoSize = True
        Me.SSVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SSVersion.Location = New System.Drawing.Point(2, 395)
        Me.SSVersion.Name = "SSVersion"
        Me.SSVersion.Size = New System.Drawing.Size(78, 13)
        Me.SSVersion.TabIndex = 46
        Me.SSVersion.Text = "SSVersionNum"
        '
        'EnableBtn
        '
        Me.EnableBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.EnableBtn.Enabled = False
        Me.EnableBtn.Location = New System.Drawing.Point(144, 376)
        Me.EnableBtn.Name = "EnableBtn"
        Me.EnableBtn.Size = New System.Drawing.Size(66, 32)
        Me.EnableBtn.TabIndex = 47
        Me.EnableBtn.Text = "EnableBtn"
        Me.EnableBtn.UseVisualStyleBackColor = False
        Me.EnableBtn.Visible = False
        '
        'DelayTmr
        '
        Me.DelayTmr.Interval = 1000
        '
        'DelayProBar
        '
        Me.DelayProBar.ForeColor = System.Drawing.Color.Gold
        Me.DelayProBar.Location = New System.Drawing.Point(7, 342)
        Me.DelayProBar.Maximum = 10
        Me.DelayProBar.Name = "DelayProBar"
        Me.DelayProBar.Size = New System.Drawing.Size(369, 10)
        Me.DelayProBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.DelayProBar.TabIndex = 48
        Me.DelayProBar.Value = 10
        Me.DelayProBar.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(303, 231)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(303, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'SleepLbl
        '
        Me.SleepLbl.AutoSize = True
        Me.SleepLbl.BackColor = System.Drawing.Color.Firebrick
        Me.SleepLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SleepLbl.ForeColor = System.Drawing.Color.Black
        Me.SleepLbl.Location = New System.Drawing.Point(175, 74)
        Me.SleepLbl.Name = "SleepLbl"
        Me.SleepLbl.Size = New System.Drawing.Size(79, 20)
        Me.SleepLbl.TabIndex = 49
        Me.SleepLbl.Text = "Disabled"
        '
        'PopTabTmr
        '
        Me.PopTabTmr.Interval = 1
        '
        'ShowBtn
        '
        Me.ShowBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.ShowBtn.Location = New System.Drawing.Point(13, -3)
        Me.ShowBtn.Name = "ShowBtn"
        Me.ShowBtn.Size = New System.Drawing.Size(356, 25)
        Me.ShowBtn.TabIndex = 50
        Me.ShowBtn.Text = "Show"
        Me.ShowBtn.UseVisualStyleBackColor = False
        Me.ShowBtn.Visible = False
        '
        'MainLbl
        '
        Me.MainLbl.AutoSize = True
        Me.MainLbl.BackColor = System.Drawing.Color.Firebrick
        Me.MainLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainLbl.ForeColor = System.Drawing.Color.Black
        Me.MainLbl.Location = New System.Drawing.Point(172, 235)
        Me.MainLbl.Name = "MainLbl"
        Me.MainLbl.Size = New System.Drawing.Size(79, 20)
        Me.MainLbl.TabIndex = 51
        Me.MainLbl.Text = "Disabled"
        Me.MainLbl.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(384, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainLbl)
        Me.Controls.Add(Me.ShowBtn)
        Me.Controls.Add(Me.SleepLbl)
        Me.Controls.Add(Me.DelayProBar)
        Me.Controls.Add(Me.EnableBtn)
        Me.Controls.Add(Me.SSVersion)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HelpBtn)
        Me.Controls.Add(Me.DataBtn)
        Me.Controls.Add(Me.SettingBtn)
        Me.Controls.Add(Me.TimeBtn)
        Me.Controls.Add(Me.HubBtn)
        Me.Controls.Add(Me.TmeRem)
        Me.Controls.Add(Me.TmeTot)
        Me.Controls.Add(Me.SlpTmeRem)
        Me.Controls.Add(Me.SlpTmeTot)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SlpProBar)
        Me.Controls.Add(Me.MainProBar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GoBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 450)
        Me.MinimumSize = New System.Drawing.Size(400, 60)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SmartSleep"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseBtn As Button
    Friend WithEvents GoBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MainProBar As ProgressBar
    Friend WithEvents SlpProBar As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents SlpTmeTot As Label
    Friend WithEvents SlpTmeRem As Label
    Friend WithEvents TmeRem As Label
    Friend WithEvents TmeTot As Label
    Friend WithEvents HubBtn As Button
    Friend WithEvents TimeBtn As Button
    Friend WithEvents SettingBtn As Button
    Friend WithEvents DataBtn As Button
    Friend WithEvents HelpBtn As Button
    Friend WithEvents MainTmr As Timer
    Friend WithEvents SlpTmr As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SSVersion As Label
    Friend WithEvents EnableBtn As Button
    Friend WithEvents DelayTmr As Timer
    Friend WithEvents DelayProBar As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SleepLbl As Label
    Friend WithEvents PopTabTmr As Timer
    Friend WithEvents ShowBtn As Button
    Friend WithEvents MainLbl As Label
End Class
