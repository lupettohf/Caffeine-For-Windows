Imports System.Net

Public Class Settings
    Const Version = 1.1
    Private Sub Settings_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon_Tray.Visible = True
            Me.Visible = False
            NotifyIcon_Tray.BalloonTipText = "Double click on this icon to open the settings form."
            NotifyIcon_Tray.ShowBalloonTip(500)
        End If
    End Sub

    Private Sub ExecTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles ExecTimer.Tick
        SendKeys.Send("{F15}")
    End Sub

    Private Sub githuburl_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles githuburl.LinkClicked
        Process.Start("https://github.com/alecive/FlatWoken")
    End Sub

    Private Sub Quit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Quit.Click
        Environment.Exit(0)
    End Sub

    Private Sub Hide_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Hide.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub setbutton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles setbutton.Click
        If NumericTime.Value = 0 Then
            MsgBox("Value higher than 0.")
            NumericTime.Value = "1"
        End If
        ExecTimer.Interval = NumericTime.Value * 60000
    End Sub

    Private Sub StopStart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StopStart.Click
        If ExecTimer.Enabled Then
            ExecTimer.Stop()
            StopStart.Text = "Start Caffeine"
        Else
            ExecTimer.Start()
            StopStart.Text = "Stop Caffeine"
        End If
    End Sub

    Private Sub NotifyIcon_Tray_Click(ByVal sender As Object, ByVal e As MouseEventArgs) Handles NotifyIcon_Tray.MouseDoubleClick
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon_Tray.Visible = False
    End Sub

    Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        CheckUpdates()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CheckUpdates()
        Dim Net As New WebClient
        Try
            Dim RemoteVer As Single = Net.DownloadString("https://raw.githubusercontent.com/lupettohf/Caffeine-For-Windows/master/ver")
            If Version >= RemoteVer Then
                lblversion.ForeColor = Color.Green
            Else
                lblversion.ForeColor = Color.Red
                MsgBox("Please, update Caffeine. Current version:" & Version & ", Server version:" & RemoteVer, MsgBoxStyle.Information, "Caffeine Updater")
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Sorry, Caffeine crashed.")
        End Try

    End Sub
End Class
