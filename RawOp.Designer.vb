<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RawOp
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RawOp))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RawOpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MainTimeLbl = New System.Windows.Forms.TextBox()
        Me.MainTimeCountLbl = New System.Windows.Forms.TextBox()
        Me.SleepTimeLbl = New System.Windows.Forms.TextBox()
        Me.SleepTimeCountLbl = New System.Windows.Forms.TextBox()
        Me.MousePosXLbl = New System.Windows.Forms.TextBox()
        Me.MousePosYLbl = New System.Windows.Forms.TextBox()
        Me.VariableSmtTmeLbl = New System.Windows.Forms.TextBox()
        Me.MouseCurrentX = New System.Windows.Forms.TextBox()
        Me.MouseCurrentY = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FormX = New System.Windows.Forms.TextBox()
        Me.FormY = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(113, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "MainTime:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(108, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "SleepTime:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(68, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "SleepTimeCount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(73, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "MainTimeCount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(59, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "MousePosX (Var):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(60, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "MousePosY (Var):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(69, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "VariableSmtTme:"
        '
        'RawOpTimer
        '
        Me.RawOpTimer.Interval = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(96, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 18)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "MousePosY:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(95, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 18)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "MousePosX:"
        '
        'MainTimeLbl
        '
        Me.MainTimeLbl.Location = New System.Drawing.Point(196, 84)
        Me.MainTimeLbl.Name = "MainTimeLbl"
        Me.MainTimeLbl.ReadOnly = True
        Me.MainTimeLbl.Size = New System.Drawing.Size(100, 20)
        Me.MainTimeLbl.TabIndex = 30
        Me.MainTimeLbl.Text = "MainTimeLbl"
        '
        'MainTimeCountLbl
        '
        Me.MainTimeCountLbl.Location = New System.Drawing.Point(196, 110)
        Me.MainTimeCountLbl.Name = "MainTimeCountLbl"
        Me.MainTimeCountLbl.ReadOnly = True
        Me.MainTimeCountLbl.Size = New System.Drawing.Size(100, 20)
        Me.MainTimeCountLbl.TabIndex = 31
        Me.MainTimeCountLbl.Text = "MainTimeCountLbl"
        '
        'SleepTimeLbl
        '
        Me.SleepTimeLbl.Location = New System.Drawing.Point(196, 136)
        Me.SleepTimeLbl.Name = "SleepTimeLbl"
        Me.SleepTimeLbl.ReadOnly = True
        Me.SleepTimeLbl.Size = New System.Drawing.Size(100, 20)
        Me.SleepTimeLbl.TabIndex = 32
        Me.SleepTimeLbl.Text = "SleepTimeLbl"
        '
        'SleepTimeCountLbl
        '
        Me.SleepTimeCountLbl.Location = New System.Drawing.Point(196, 162)
        Me.SleepTimeCountLbl.Name = "SleepTimeCountLbl"
        Me.SleepTimeCountLbl.ReadOnly = True
        Me.SleepTimeCountLbl.Size = New System.Drawing.Size(100, 20)
        Me.SleepTimeCountLbl.TabIndex = 33
        Me.SleepTimeCountLbl.Text = "SleepTimeCountLbl"
        '
        'MousePosXLbl
        '
        Me.MousePosXLbl.Location = New System.Drawing.Point(196, 188)
        Me.MousePosXLbl.Name = "MousePosXLbl"
        Me.MousePosXLbl.ReadOnly = True
        Me.MousePosXLbl.Size = New System.Drawing.Size(100, 20)
        Me.MousePosXLbl.TabIndex = 34
        Me.MousePosXLbl.Text = "MousePosXLbl"
        '
        'MousePosYLbl
        '
        Me.MousePosYLbl.Location = New System.Drawing.Point(196, 214)
        Me.MousePosYLbl.Name = "MousePosYLbl"
        Me.MousePosYLbl.ReadOnly = True
        Me.MousePosYLbl.Size = New System.Drawing.Size(100, 20)
        Me.MousePosYLbl.TabIndex = 35
        Me.MousePosYLbl.Text = "MousePosYLbl"
        '
        'VariableSmtTmeLbl
        '
        Me.VariableSmtTmeLbl.Location = New System.Drawing.Point(196, 292)
        Me.VariableSmtTmeLbl.Name = "VariableSmtTmeLbl"
        Me.VariableSmtTmeLbl.ReadOnly = True
        Me.VariableSmtTmeLbl.Size = New System.Drawing.Size(100, 20)
        Me.VariableSmtTmeLbl.TabIndex = 37
        Me.VariableSmtTmeLbl.Text = "VariableSmtTmeLbl"
        '
        'MouseCurrentX
        '
        Me.MouseCurrentX.Location = New System.Drawing.Point(196, 240)
        Me.MouseCurrentX.Name = "MouseCurrentX"
        Me.MouseCurrentX.ReadOnly = True
        Me.MouseCurrentX.Size = New System.Drawing.Size(100, 20)
        Me.MouseCurrentX.TabIndex = 38
        Me.MouseCurrentX.Text = "MouseCurrentX"
        '
        'MouseCurrentY
        '
        Me.MouseCurrentY.Location = New System.Drawing.Point(196, 266)
        Me.MouseCurrentY.Name = "MouseCurrentY"
        Me.MouseCurrentY.ReadOnly = True
        Me.MouseCurrentY.Size = New System.Drawing.Size(100, 20)
        Me.MouseCurrentY.TabIndex = 39
        Me.MouseCurrentY.Text = "MouseCurrentY"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(105, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 18)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "FormPosX:"
        '
        'FormX
        '
        Me.FormX.Location = New System.Drawing.Point(196, 318)
        Me.FormX.Name = "FormX"
        Me.FormX.ReadOnly = True
        Me.FormX.Size = New System.Drawing.Size(100, 20)
        Me.FormX.TabIndex = 41
        Me.FormX.Text = "FormX"
        '
        'FormY
        '
        Me.FormY.Location = New System.Drawing.Point(196, 344)
        Me.FormY.Name = "FormY"
        Me.FormY.ReadOnly = True
        Me.FormY.Size = New System.Drawing.Size(100, 20)
        Me.FormY.TabIndex = 42
        Me.FormY.Text = "FormY"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label11.Location = New System.Drawing.Point(105, 346)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 18)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "FormPosY:"
        '
        'RawOp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(384, 411)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.FormY)
        Me.Controls.Add(Me.FormX)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.MouseCurrentY)
        Me.Controls.Add(Me.MouseCurrentX)
        Me.Controls.Add(Me.VariableSmtTmeLbl)
        Me.Controls.Add(Me.MousePosYLbl)
        Me.Controls.Add(Me.MousePosXLbl)
        Me.Controls.Add(Me.SleepTimeCountLbl)
        Me.Controls.Add(Me.SleepTimeLbl)
        Me.Controls.Add(Me.MainTimeCountLbl)
        Me.Controls.Add(Me.MainTimeLbl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 450)
        Me.MinimumSize = New System.Drawing.Size(400, 450)
        Me.Name = "RawOp"
        Me.Text = "SmartSleep"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RawOpTimer As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MainTimeLbl As TextBox
    Friend WithEvents MainTimeCountLbl As TextBox
    Friend WithEvents SleepTimeLbl As TextBox
    Friend WithEvents SleepTimeCountLbl As TextBox
    Friend WithEvents MousePosXLbl As TextBox
    Friend WithEvents MousePosYLbl As TextBox
    Friend WithEvents VariableSmtTmeLbl As TextBox
    Friend WithEvents MouseCurrentX As TextBox
    Friend WithEvents MouseCurrentY As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents FormX As TextBox
    Friend WithEvents FormY As TextBox
    Friend WithEvents Label11 As Label
End Class
