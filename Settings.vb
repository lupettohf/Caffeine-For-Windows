Public Class Settings
    Private Sub Settings_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon_Tray.Visible = True
            Me.Visible = False
            NotifyIcon_Tray.BalloonTipText = "Double click on this icon to open the settings form."
            NotifyIcon_Tray.ShowBalloonTip(500)
        End If
    End Sub

    Private Sub ExecTimer_Tick(sender As Object, e As EventArgs) Handles ExecTimer.Tick
        SendKeys.Send("{F15}")
    End Sub

    Private Sub githuburl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles githuburl.LinkClicked
        Process.Start("https://github.com/alecive/FlatWoken")
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Environment.Exit(0)
    End Sub

    Private Sub Hide_Click(sender As Object, e As EventArgs) Handles Hide.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub setbutton_Click(sender As Object, e As EventArgs) Handles setbutton.Click
        If NumericTime.Value = 0 Then
            MsgBox("Value higher than 0.")
            NumericTime.Value = "1"
        End If
        ExecTimer.Interval = NumericTime.Value * 60000
    End Sub

    Private Sub StopStart_Click(sender As Object, e As EventArgs) Handles StopStart.Click
        If ExecTimer.Enabled Then
            ExecTimer.Stop()
            StopStart.Text = "Start Timer"
        Else
            ExecTimer.Start()
            StopStart.Text = "Stop Timer"
        End If
    End Sub

    Private Sub NotifyIcon_Tray_Click(sender As Object, e As MouseEventArgs) Handles NotifyIcon_Tray.MouseDoubleClick
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon_Tray.Visible = False
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
