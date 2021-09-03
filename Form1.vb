Public Class Form1

    '=====================VARIABLES=====================
    Public MainTime As Integer = 120
    Public SleepTime As Integer = 0
    Public MainTimeCount As Integer = 120
    Public SleepTimeCount As Integer = 0
    Public MainTimeMin As Decimal = (MainTimeCount / 60)
    Public SleepTimeMin As Decimal = (SleepTimeCount / 60)
    Public SleepToggle As Boolean = 0
    Dim HourCheck As Boolean = 0
    Public Count As Integer
    Public DelayCount As Integer = 0
    Public SmrtSlpToggle As Boolean = 1
    Public SmrtClsToggle As Boolean = 0
    Public SlpTmrShutDown As Boolean = 0
    Public MousePosX As Decimal
    Public MousePosY As Decimal
    Public VariableSmtTme As Integer = 15
    Public SSVersionNum As String = "SS Version: 1.0.4.0"
    Public CurrentForm As Point

    '=====================LAUNCH SETTINGS=====================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = 0
        Me.Visible = 1
        TimeForm.Visible = 1
        TimeForm.Visible = 0
        SettingForm.Visible = 1
        SettingForm.Visible = 0
        DataForm.Visible = 1
        DataForm.Visible = 0
        HelpForm.Visible = 1
        HelpForm.Visible = 0
        RawOp.Visible = 1
        RawOp.Visible = 0



        'top buttons
        HubBtn.Text = "Hub"
        TimeBtn.Text = "Time"
        SettingBtn.Text = "Settings"
        DataBtn.Text = "Data"
        HelpBtn.Text = "Help"

        'middle section
        SlpTmeTot.Text = (SleepTimeMin.ToString("n1")) + " Minutes"
        SlpTmeRem.Text = (SleepTimeMin.ToString("n1")) + " Minutes"
        TmeTot.Text = (MainTimeMin.ToString("n1")) + " Minutes"
        TmeRem.Text = (MainTimeMin.ToString("n1")) + " Minutes"

        'bottom buttons
        GoBtn.Text = "Start"
        CloseBtn.Text = "Close"
        EnableBtn.Text = "Enable"
        SSVersion.Text = SSVersionNum
    End Sub

    '=====================ENABLE BUTTON=====================
    Private Sub EnableBtn_Click(sender As Object, e As EventArgs) Handles EnableBtn.Click
        If DelayProBar.Visible = False Then
            GoBtn.Enabled = True
            GoBtn.BackColor = Color.Gainsboro
        End If
    End Sub

    '=====================START/STOP BUTTON=====================
    Private Sub GoBtn_Click(sender As Object, e As EventArgs) Handles GoBtn.Click

        If SettingForm.DelayCheck.Checked And SleepTime = 0 And GoBtn.Text = "Start" Then
            DelayProBar.Value = 10
            DelayTmr.Enabled = True
            DelayProBar.Visible = True
            GoBtn.Enabled = False

            TimeBtn.Enabled = 0
            SettingBtn.Enabled = 0
            DataBtn.Enabled = 0
            HelpBtn.Enabled = 0

        End If
        If SleepToggle = 0 And SleepTime = 0 And DelayCount = 0 And GoBtn.Text = "Start" Then
            GoBtn.Enabled = True
            MainTimeCount = MainTime
            MainProBar.Maximum = MainTime
            MainProBar.ForeColor = Color.LimeGreen
            MainTmr.Enabled = 1
            GoBtn.Text = "Stop"

            TimeBtn.Enabled = 0
            SettingBtn.Enabled = 0
            DataBtn.Enabled = 0
            HelpBtn.Enabled = 0

            Shell("shutdown -h") '==SLEEP==

        ElseIf SleepToggle = True And SleepTime = 0 And DelayCount = 0 And GoBtn.Text = "Start" Then
            GoBtn.Enabled = True
            SleepTimeCount = SleepTime
            MainTimeCount = MainTime
            SlpProBar.Maximum = SleepTime
            SlpProBar.ForeColor = Color.LimeGreen
            SlpTmr.Enabled = 1
            GoBtn.Text = "Stop"

            TimeBtn.Enabled = 0
            SettingBtn.Enabled = 0
            DataBtn.Enabled = 0
            HelpBtn.Enabled = 0

        ElseIf SleepTime <> 0 And GoBtn.Text = "Start"Then
            GoBtn.Text = "Stop"
            SlpProBar.ForeColor = Color.LimeGreen
            SleepTimeCount = SleepTime
            SlpTmr.Enabled = True

            TimeBtn.Enabled = 0
            SettingBtn.Enabled = 0
            DataBtn.Enabled = 0
            HelpBtn.Enabled = 0

        ElseIf GoBtn.Text = "Stop" Then
            GoBtn.Text = "Start"
            MainTmr.Enabled = 0
            MainProBar.Value = MainTime
            MainProBar.ForeColor = Color.Firebrick
            MainTimeCount = MainTime
            MainTimeMin = (MainTime / 60)
            TmeRem.Text = (MainTimeMin.ToString("n1")) + " Minutes"

            SlpTmr.Enabled = 0
            SlpProBar.Value = SleepTime
            SlpProBar.ForeColor = Color.Firebrick
            SleepTimeCount = SleepTime
            SleepTimeMin = (SleepTime / 60)
            SlpTmeRem.Text = (SleepTimeMin.ToString("n1")) + " Minutes"

            TimeBtn.Enabled = 1
            SettingBtn.Enabled = 1
            DataBtn.Enabled = 1
            HelpBtn.Enabled = 1

            If EnableBtn.Visible = True Then
                GoBtn.Enabled = False
                GoBtn.BackColor = Color.Firebrick
            End If
        End If
    End Sub

    '=====================DELAY TIMER=====================
    Private Sub DelayTmr_Tick(sender As Object, e As EventArgs) Handles DelayTmr.Tick
        DelayCount -= 1
        DelayProBar.Value = DelayCount
        If DelayCount = 0 And SlpTmrShutDown = 0 Then
            GoBtn.Enabled = True
            GoBtn.PerformClick()
            DelayCount = 10
            DelayProBar.Visible = 0
            DelayTmr.Enabled = 0
        ElseIf DelayCount = 0 And SlpTmrShutDown = 1 Then
            Shell("shutdown -s")
        End If
    End Sub

    '=====================MAIN TIMER=====================
    Private Sub MainTmr_Tick(sender As Object, e As EventArgs) Handles MainTmr.Tick
        MainTimeCount -= 1
        MainProBar.Value = MainTimeCount
        MainTimeMin = (MainTimeCount / 60)
        TmeRem.Text = (MainTimeMin.ToString("n1")) + " Minutes"

        'SMART SLEEP FUNCITON
        If MainTimeCount = (MainTime - VariableSmtTme) Then
            MousePosX = MousePosition.X
            MousePosY = MousePosition.Y
        End If

        If MainTimeCount < (MainTime - VariableSmtTme) And SmrtSlpToggle = True Then

            If (MousePosition.X > (MousePosX + 150)) Or (MousePosition.X < (MousePosX - 150)) Or (MousePosition.Y > (MousePosY + 150)) Or (MousePosition.Y < (MousePosY - 150)) Then
                If EnableBtn.Visible = True Then
                    GoBtn.Enabled = False
                    GoBtn.BackColor = Color.Firebrick
                End If
                MainTimeCount = MainTime
                GoBtn.Text = "Start"
                MainProBar.Value = MainTime
                MainProBar.ForeColor = Color.Firebrick
                MainTimeCount = MainTime
                MainTimeMin = (MainTime / 60)
                TmeRem.Text = (MainTimeMin.ToString("n1")) + " Minutes"

                SlpProBar.Value = SleepTime
                SlpProBar.ForeColor = Color.Firebrick
                SleepTimeCount = SleepTime
                SleepTimeMin = (SleepTime / 60)
                SlpTmeRem.Text = (SleepTimeMin.ToString("n1")) + " Minutes"

                TimeBtn.Enabled = 1
                SettingBtn.Enabled = 1
                DataBtn.Enabled = 1
                HelpBtn.Enabled = 1
                MainTmr.Enabled = 0
            End If
        End If
        'SMART CLOSE FUNCTION
        If MainTimeCount < (MainTime - 10) And SmrtClsToggle = True Then
            If (MousePosition.X > (MousePosX + 150)) Or (MousePosition.X < (MousePosX - 150)) Or (MousePosition.Y > (MousePosY + 150)) Or (MousePosition.Y < (MousePosY - 150)) Then
                Me.Close()
            End If
        End If

        'TIMER REACHES 0
        If MainTimeCount < 1 Then
            DataForm.TimeList.Items.Add(Now)
            DataBtn.BackColor = (Color.DeepSkyBlue)
            TimeForm.DataBtn.BackColor = (Color.DeepSkyBlue)
            SettingForm.DataBtn.BackColor = (Color.DeepSkyBlue)
            HelpForm.DataBtn.BackColor = (Color.DeepSkyBlue)
            Count += 1
            DataForm.DataTotal.Text = Count.ToString + " Times"
            MainTimeCount = MainTime
            MainTimeMin = (MainTime / 60)
            Shell("shutdown -h") '==SLEEP==
        End If
    End Sub

    '=====================SLEEP TIMER FUNCTION=====================
    Private Sub SlpTmr_Tick(sender As Object, e As EventArgs) Handles SlpTmr.Tick
        SleepTimeCount -= 1
        SlpProBar.Value = SleepTimeCount
        SleepTimeMin = (SleepTimeCount / 60)
        If HourCheck = 0 Then
            SlpTmeRem.Text = (SleepTimeMin.ToString("n1")) + " Minutes"
        End If
        If SleepTimeCount < 1 Then
            MainTmr.Enabled = True
            MainProBar.Maximum = MainTime
            MainProBar.ForeColor = Color.LimeGreen
            MainTmr.Enabled = 1
            GoBtn.Text = "Stop"
            DataForm.SlpTmeDate.Text = Now
            DataBtn.BackColor = (Color.DeepSkyBlue)
            TimeForm.DataBtn.BackColor = (Color.DeepSkyBlue)
            SettingForm.DataBtn.BackColor = (Color.DeepSkyBlue)
            HelpForm.DataBtn.BackColor = (Color.DeepSkyBlue)
            SlpTmr.Enabled = False
        End If
    End Sub

    '=====================POPTAB TIMER=====================
    Private Sub PopTabTmr_Tick(sender As Object, e As EventArgs) Handles PopTabTmr.Tick
        If Me.Visible = True Then
            CurrentForm = Me.Location
        ElseIf TimeForm.Visible = True Then
            CurrentForm = TimeForm.Location
        ElseIf SettingForm.Visible = True Then
            CurrentForm = SettingForm.Location
        ElseIf DataForm.Visible = True Then
            CurrentForm = DataForm.Location
        ElseIf HelpForm.Visible = True Then
            CurrentForm = HelpForm.Location
        End If
        If MousePosition.X < CurrentForm.X Or MousePosition.Y < CurrentForm.Y Or MousePosition.X > (CurrentForm.X + Width) Or MousePosition.Y > (CurrentForm.Y + Height) Then 'When mouse leaves Location
            Me.Location = CurrentForm
            Me.Visible = True
            Me.Opacity = 0.5
            SettingForm.Visible = False
            TimeForm.Visible = False
            DataForm.Visible = False
            HelpForm.Visible = False
            ShowBtn.Visible = True
            Height = Me.MinimumSize.Height
            PopTabTmr.Enabled = 0
        End If
    End Sub

    'Show Button
    Private Sub ShowBtn_Click(sender As Object, e As EventArgs) Handles ShowBtn.Click   'When "show" is pressed
        If SettingForm.PopTabCeck.Checked Then
            ShowBtn.Visible = False
            Me.Opacity = 1
            Height = Me.MaximumSize.Height
            PopTabTmr.Enabled = True
        End If

    End Sub
    '=====================CLOSE BUTTON=====================
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub


    '=====================SLEEP TIMER HOUR CHECK HOVER=====================
    Private Sub SlpTmeTot_MouseHover(sender As Object, e As EventArgs) Handles SlpTmeTot.MouseHover
        SlpTmeTot.Text = ((SleepTime / 3600).ToString("n1")) + " Hours"
        SlpTmeRem.Text = ((SleepTimeMin / 60).ToString("n1")) + " Hours"
        HourCheck = 1
    End Sub
    Private Sub SlpTmeTot_MouseLeave(sender As Object, e As EventArgs) Handles SlpTmeTot.MouseLeave
        SlpTmeTot.Text = (SleepTime / 60).ToString("n1") + " Minutes"
        SlpTmeRem.Text = (SleepTimeMin.ToString("n1")) + " Minutes"
        HourCheck = 0
    End Sub

    '===================================NAVIGATION====================================
    'time
    Private Sub TimeBtn_Click(sender As Object, e As EventArgs) Handles TimeBtn.Click
        TimeForm.MainTime2 = MainTime
        TimeForm.SleepTime2 = SleepTime
        TimeForm.SlpTmeSet.Text = ((SleepTime / 60).ToString("n1")) + " Minutes (" + ((SleepTime / 3600).ToString("n1")) + " Hours)"
        TimeForm.MainTmrSet.Text = ((MainTime / 60).ToString("n1")) + " Minutes"
        TimeForm.Location = Me.Location
        Me.Visible = False
        TimeForm.Visible = True

        If SettingForm.TwoStepCheck.Checked Then
            EnableBtn.Enabled = 1
            EnableBtn.Visible = 1
            GoBtn.Enabled = 0
            GoBtn.BackColor = Color.Firebrick
        End If
    End Sub

    'settings
    Private Sub SettingBtn_Click(sender As Object, e As EventArgs) Handles SettingBtn.Click
        SettingForm.Location = Me.Location
        Me.Visible = False
        SettingForm.Visible = True

        If SettingForm.TwoStepCheck.Checked Then
            EnableBtn.Enabled = 1
            EnableBtn.Visible = 1
            GoBtn.Enabled = 0
            GoBtn.BackColor = Color.Firebrick
        End If
    End Sub

    'data
    Private Sub DataBtn_Click(sender As Object, e As EventArgs) Handles DataBtn.Click
        Me.DataBtn.BackColor = (Color.Gainsboro)
        TimeForm.DataBtn.BackColor = (Color.Gainsboro)
        SettingForm.DataBtn.BackColor = (Color.Gainsboro)
        HelpForm.DataBtn.BackColor = (Color.Gainsboro)
        DataForm.Location = Me.Location
        Me.Visible = False
        DataForm.Visible = True

        If SettingForm.TwoStepCheck.Checked Then
            EnableBtn.Enabled = 1
            EnableBtn.Visible = 1
            GoBtn.Enabled = 0
            GoBtn.BackColor = Color.Firebrick
        End If
    End Sub

    'help
    Private Sub HelpBtn_Click(sender As Object, e As EventArgs) Handles HelpBtn.Click
        HelpForm.Location = Me.Location
        Me.Visible = 0
        HelpForm.Visible = 1

        If SettingForm.TwoStepCheck.Checked Then
            EnableBtn.Enabled = 1
            EnableBtn.Visible = 1
            GoBtn.Enabled = 0
            GoBtn.BackColor = Color.Firebrick
        End If
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------
End Class
