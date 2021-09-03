Public Class DataForm
    Private Sub DataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LAUNCH SETTINGS
        'top buttons
        HubBtn.Text = "Hub"
        TimeBtn.Text = "Time"
        SettingBtn.Text = "Settings"
        DataBtn.Text = "Data"
        HelpBtn.Text = "Help"

        'Middle
        DataTotal.Text = "0 Times"
        SlpTmeDate.Text = "N/A"

        'bottom
        CloseBtn.Text = "Close"
        ClrBtn.Text = "Clear"
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

    'settings
    Private Sub SettingBtn_Click(sender As Object, e As EventArgs) Handles SettingBtn.Click
        SettingForm.Location = Me.Location
        Me.Visible = False
        SettingForm.Visible = True
    End Sub

    'help
    Private Sub HelpBtn_Click(sender As Object, e As EventArgs) Handles HelpBtn.Click
        HelpForm.Location = Me.Location
        Me.Visible = 0
        HelpForm.Visible = 1
    End Sub


    '=====================CLOSE BUTTON=====================
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Form1.Close()
    End Sub

    '=====================CLEAR BUTTON=====================
    Private Sub ClrBtn_Click(sender As Object, e As EventArgs) Handles ClrBtn.Click
        TimeList.Items.Clear()
        Form1.Count = 0
        DataTotal.Text = "0 Times"
        SlpTmeDate.Text = "N/A"
    End Sub
End Class