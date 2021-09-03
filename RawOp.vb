Public Class RawOp

    Private Sub RawOpTimer_Tick(sender As Object, e As EventArgs) Handles RawOpTimer.Tick
        MainTimeLbl.Text = Form1.MainTime
        MainTimeCountLbl.Text = Form1.MainTimeCount
        SleepTimeLbl.Text = Form1.SleepTime
        SleepTimeCountLbl.Text = Form1.SleepTimeCount
        MousePosXLbl.Text = Form1.MousePosX
        MousePosYLbl.Text = Form1.MousePosY
        MouseCurrentX.Text = MousePosition.X
        MouseCurrentY.Text = MousePosition.Y
        VariableSmtTmeLbl.Text = Form1.VariableSmtTme
        FormX.Text = Form1.Location.X
        FormY.Text = Form1.Location.Y

        If Me.Visible = False Then
            RawOpTimer.Enabled = False
        End If
    End Sub

    Private Sub SleepTimeCountLbl_TextChanged(sender As Object, e As EventArgs) Handles SleepTimeCountLbl.TextChanged

    End Sub
End Class