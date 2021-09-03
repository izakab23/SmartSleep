Public Class TimeForm
    Public SleepTime2 As Decimal
    Public MainTime2 As Decimal

    '=====================LAUNCH SETTINGS=====================
    Private Sub TimeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'top buttons
        HubBtn.Text = "Hub"
        TimeBtn.Text = "Time"
        SettingBtn.Text = "Settings"
        DataBtn.Text = "Data"
        HelpBtn.Text = "Help"

        'middle
        SleepTime2 = Form1.SleepTime
        MainTime2 = Form1.MainTime
        Min60.Text = "- 1 Hour"
        Min15.Text = "- 15 Min"
        Plus15.Text = "+ 15 Min"
        Plus60.Text = "+ 1 Hour"

        Min5.Text = "- 5 Min"
        Min30.Text = "- 30 Sec"
        Plus30.Text = "+ 30 Sec"
        Plus5.Text = "+ 5 Min"

        'bottom
        SaveBtn.Text = "Save"
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

    'settings
    Private Sub SettingBtn_Click(sender As Object, e As EventArgs) Handles SettingBtn.Click
        SettingForm.Location = Me.Location
        Me.Visible = False
        SettingForm.Visible = True
    End Sub

    'data
    Private Sub DataBtn_Click(sender As Object, e As EventArgs) Handles DataBtn.Click
        Me.DataBtn.BackColor = (Color.Gainsboro)
        Form1.DataBtn.BackColor = (Color.Gainsboro)
        SettingForm.DataBtn.BackColor = (Color.Gainsboro)
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



    '=====================SLEEP TIMER SET=====================
    'MINUS 60 MINS
    Private Sub Min60_Click(sender As Object, e As EventArgs) Handles Min60.Click
        If SleepTime2 >= 3600 Then
            SleepTime2 -= 3600
            SlpTmeSet.Text = ((SleepTime2 / 60).ToString("n1")) + " Minutes (" + ((SleepTime2 / 3600).ToString("n1")) + " Hours)"
        End If
    End Sub
    'MINUS 15 MINS
    Private Sub Min15_Click(sender As Object, e As EventArgs) Handles Min15.Click
        If SleepTime2 >= 900 Then
            SleepTime2 -= 900
            SlpTmeSet.Text = ((SleepTime2 / 60).ToString("n1")) + " Minutes (" + ((SleepTime2 / 3600).ToString("n1")) + " Hours)"
        End If
    End Sub
    'PLUS 15 MINS
    Private Sub Plus15_Click(sender As Object, e As EventArgs) Handles Plus15.Click
        SleepTime2 += 900
        SlpTmeSet.Text = ((SleepTime2 / 60).ToString("n1")) + " Minutes (" + ((SleepTime2 / 3600).ToString("n1")) + " Hours)"
    End Sub
    'PLUS 60 MINS
    Private Sub Plus60_Click(sender As Object, e As EventArgs) Handles Plus60.Click
        SleepTime2 += 3600
        SlpTmeSet.Text = ((SleepTime2 / 60).ToString("n1")) + " Minutes (" + ((SleepTime2 / 3600).ToString("n1")) + " Hours)"
    End Sub


    '=====================MAIN TIMER SET=====================
    'MINUS 5 MINS
    Private Sub Min5_Click(sender As Object, e As EventArgs) Handles Min5.Click
        If MainTime2 > 300 Then
            MainTime2 -= 300
            MainTmrSet.Text = ((MainTime2 / 60).ToString("n1")) + " Minutes"
        End If
    End Sub
    'MINUS 30 SEC
    Private Sub Min30_Click(sender As Object, e As EventArgs) Handles Min30.Click
        If MainTime2 > 30 Then
            MainTime2 -= 30
            MainTmrSet.Text = ((MainTime2 / 60).ToString("n1")) + " Minutes"
        End If
    End Sub
    'PLUS 30 SEC
    Private Sub Plus30_Click(sender As Object, e As EventArgs) Handles Plus30.Click
        MainTime2 += 30
        MainTmrSet.Text = ((MainTime2 / 60).ToString("n1")) + " Minutes"
    End Sub
    'PLUS 5 MINS
    Private Sub Plus5_Click(sender As Object, e As EventArgs) Handles Plus5.Click
        MainTime2 += 300
        MainTmrSet.Text = ((MainTime2 / 60).ToString("n1")) + " Minutes"
    End Sub

    '=====================SAVE BUTTON=====================
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Form1.SleepTime = SleepTime2
        Form1.MainTime = MainTime2
        Form1.SleepTimeMin = (Form1.SleepTime \ 60)
        Form1.SlpTmeTot.Text = (Form1.SleepTimeMin.ToString("n1")) + " Minutes"
        Form1.SlpTmeRem.Text = (Form1.SleepTimeMin.ToString("n1")) + " Minutes"
        Form1.SlpProBar.Maximum = Form1.SleepTime
        Form1.SlpProBar.Value = Form1.SleepTime
        Form1.MainTimeMin = (Form1.MainTime \ 60)
        Form1.TmeTot.Text = ((MainTime2 / 60).ToString("n1")) + " Minutes"
        Form1.TmeRem.Text = ((MainTime2 / 60).ToString("n1")) + " Minutes"
        Form1.MainProBar.Maximum = Form1.MainTime
        Form1.MainProBar.Value = Form1.MainTime

        Form1.Location = Me.Location
        Me.Visible = False
        Form1.Visible = True

        If Form1.SleepTime <> 0 Then
            Form1.SleepLbl.BackColor = Color.LimeGreen
            Form1.SleepLbl.Text = "Enabled"
            If SettingForm.SlpTmrShtDwn.Checked = True Then
                Form1.MainLbl.Visible = True
            End If
        Else
            Form1.SleepLbl.BackColor = Color.Firebrick
            Form1.SleepLbl.Text = "Disabled"
            Form1.MainLbl.Visible = False
        End If

    End Sub

    '=====================CLOSE BUTTON=====================
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Form1.Close()
    End Sub
End Class