Public Class HelpForm
    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '=====================LAUNCH SETTINGS=====================
        HubBtn.Text = "Hub"
        TimeBtn.Text = "Time"
        SettingBtn.Text = "Settings"
        DataBtn.Text = "Data"
        HelpBtn.Text = "Help"
    End Sub

    '=====================NAVIGATION=====================
    'Form1
    Private Sub HubBtn_Click(sender As Object, e As EventArgs) Handles HubBtn.Click
        Form1.Location = Me.Location
        Me.Visible = False
        Form1.Visible = True
    End Sub

    'time
    Private Sub TimeBtn_Click(sender As Object, e As EventArgs) Handles TimeBtn.Click
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

    'data
    Private Sub DataBtn_Click(sender As Object, e As EventArgs) Handles DataBtn.Click
        Me.DataBtn.BackColor = (Color.Gainsboro)
        Form1.DataBtn.BackColor = (Color.Gainsboro)
        TimeForm.DataBtn.BackColor = (Color.Gainsboro)
        SettingForm.DataBtn.BackColor = (Color.Gainsboro)
        DataForm.Location = Me.Location
        Me.Visible = False
        DataForm.Visible = True
    End Sub
End Class