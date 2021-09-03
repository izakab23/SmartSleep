Public Class SettingForm
    Private Sub SettingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '=====================LAUNCH SETTINGS=====================
        'top buttons
        HubBtn.Text = "Hub"
        TimeBtn.Text = "Time"
        SettingBtn.Text = "Settings"
        DataBtn.Text = "Data"
        HelpBtn.Text = "Help"

        'Middle buttons
        SmrtSlpCheck.Text = "Smart Sleep on"
        SmrtClsCheck.Text = "Smart Close on"
        TwoStepCheck.Text = "Two Step Varification"
        DelayCheck.Text = "10 Second Start Delay"
        PopTabCeck.Text = "Pop-up Tab on"
        SlpTmrShtDwn.Text = "Sleep Timer Shutdown"

        VarTmeTxtBox.Text = Form1.VariableSmtTme
        RawOpCheck.Text = "Raw Output Form"

        'Bottom buttons
        CloseBtn.Text = "Close"
        SSVersion.Text = Form1.SSVersionNum
    End Sub

    '=====================NAVIGATION=====================
    'Hub
    Private Sub HubBtn_Click(sender As Object, e As EventArgs) Handles HubBtn.Click
        Form1.Location = Me.Location
        Me.Visible = False
        Form1.Visible = True
    End Sub

    'time
    Private Sub TimeBtn_Click(sender As Object, e As EventArgs) Handles TimeBtn.Click
        TimeForm.SlpTmeSet.Text = ((Form1.SleepTime / 60).ToString("n1")) + " Minutes (" + ((Form1.SleepTime / 3600).ToString("n1")) + " Hours)"
        TimeForm.MainTmrSet.Text = ((Form1.MainTime / 60).ToString("n1")) + " Minutes"
        TimeForm.Location = Me.Location
        Me.Visible = False
        TimeForm.Visible = True
    End Sub

    'data
    Private Sub DataBtn_Click(sender As Object, e As EventArgs) Handles DataBtn.Click
        Me.DataBtn.BackColor = (Color.Gainsboro)
        Form1.DataBtn.BackColor = (Color.Gainsboro)
        TimeForm.DataBtn.BackColor = (Color.Gainsboro)
        HelpForm.DataBtn.BackColor = (Color.Gainsboro)
        DataForm.Location = Me.Location
        Me.Visible = False
        DataForm.Visible = True
    End Sub

    'help
    Private Sub HelpBtn_Click(sender As Object, e As EventArgs) Handles HelpBtn.Click
        HelpForm.Location = Me.Location
        Me.Visible = 0
        HelpForm.Visible = 1
    End Sub

    '=====================SETTINGS=====================
    'Smart Sleep toggle
    Private Sub SmrtSlpCheck_CheckedChanged(sender As Object, e As EventArgs) Handles SmrtSlpCheck.CheckedChanged
        If SmrtSlpCheck.Checked Then
            SmrtClsCheck.Checked = 0
            Form1.SmrtSlpToggle = True
        Else
            Form1.SmrtSlpToggle = False
        End If
    End Sub

    'Smart Close toggle
    Private Sub SmtClsCheck_CheckedChanged(sender As Object, e As EventArgs) Handles SmrtClsCheck.CheckedChanged
        If SmrtClsCheck.Checked Then
            SmrtSlpCheck.Checked = 0
            Form1.SmrtClsToggle = True
        End If
    End Sub


    'Two Step Check
    Private Sub TwoStepCheck_CheckedChanged(sender As Object, e As EventArgs) Handles TwoStepCheck.CheckedChanged
        If TwoStepCheck.Checked Then
            Form1.EnableBtn.Enabled = 1
            Form1.EnableBtn.Visible = 1
            Form1.GoBtn.Enabled = 0
            Form1.GoBtn.BackColor = Color.Firebrick
        Else
            Form1.EnableBtn.Enabled = 0
            Form1.EnableBtn.Visible = 0
            Form1.GoBtn.Enabled = 1
            Form1.GoBtn.BackColor = Color.Gainsboro
        End If
    End Sub

    'Delay Check
    Private Sub DelayCheck_CheckedChanged(sender As Object, e As EventArgs) Handles DelayCheck.CheckedChanged
        If DelayCheck.Checked Then
            Form1.DelayCount = 10
        Else
            Form1.DelayCount = 0
        End If
    End Sub

    'Pop tab check
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles PopTabCeck.CheckedChanged
        If PopTabCeck.Checked Then
            Form1.ShowBtn.Visible = 1
            Form1.Location = Me.Location
            Form1.Height = Form1.MinimumSize.Height
            Form1.Opacity = 0.5
            Me.Visible = 0
            Form1.Visible = 1
        Else
            Form1.ShowBtn.Visible = 0
            Form1.PopTabTmr.Enabled = 0
        End If

    End Sub

    'Sleep Timer Shutdown
    Private Sub SlpTmrCls_CheckedChanged(sender As Object, e As EventArgs) Handles SlpTmrShtDwn.CheckedChanged
        If SlpTmrShtDwn.Checked Then
            Form1.SlpTmrShutDown = 1
            If Form1.SleepTime <> 0 Then
                Form1.MainLbl.Visible = 1
            End If
        Else
            Form1.MainLbl.Visible = 0
            Form1.SlpTmrShutDown = 0
        End If
    End Sub

    '=====================ADVANCED SETTINGS=====================
    'SmartSleep.Close Timer Variable
    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If IsNumeric(VarTmeTxtBox.Text) Then
            If CInt(VarTmeTxtBox.Text) <= Form1.MainTime Then
                Form1.VariableSmtTme = VarTmeTxtBox.Text
                UpdateBtn.Text = "Updated"
                UpdateBtn.BackColor = Color.LimeGreen
            Else
                UpdateBtn.Text = "Error"
                UpdateBtn.BackColor = Color.Firebrick
            End If
        Else
            UpdateBtn.Text = "Error"
            UpdateBtn.BackColor = Color.Firebrick
        End If
    End Sub

    Private Sub UpdateBtn_away(sender As Object, e As EventArgs) Handles UpdateBtn.MouseLeave
        UpdateBtn.Text = "Update"
        UpdateBtn.BackColor = Color.Gainsboro
    End Sub

    'Raw Output Check
    Private Sub RawOpCheck_CheckedChanged(sender As Object, e As EventArgs) Handles RawOpCheck.CheckedChanged
        If RawOpCheck.Checked Then
            RawOp.Visible = True
            RawOp.RawOpTimer.Enabled = True
        Else
            RawOp.Visible = False
            RawOp.RawOpTimer.Enabled = False
        End If
    End Sub

    '=====================CLOSE BUTTON=====================
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Form1.Close()
    End Sub
End Class