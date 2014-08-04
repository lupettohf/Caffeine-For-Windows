<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.setbutton = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.TimeBox = New System.Windows.Forms.GroupBox()
        Me.StopStart = New System.Windows.Forms.Button()
        Me.NumericTime = New System.Windows.Forms.NumericUpDown()
        Me.Hide = New System.Windows.Forms.Button()
        Me.timedesc = New System.Windows.Forms.Label()
        Me.ExecTimer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon_Tray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.IconLabel = New System.Windows.Forms.Label()
        Me.githuburl = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimeBox.SuspendLayout()
        CType(Me.NumericTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'setbutton
        '
        Me.setbutton.Location = New System.Drawing.Point(146, 16)
        Me.setbutton.Name = "setbutton"
        Me.setbutton.Size = New System.Drawing.Size(36, 20)
        Me.setbutton.TabIndex = 0
        Me.setbutton.Text = "set"
        Me.setbutton.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Location = New System.Drawing.Point(209, 47)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(44, 23)
        Me.Quit.TabIndex = 1
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'TimeBox
        '
        Me.TimeBox.Controls.Add(Me.StopStart)
        Me.TimeBox.Controls.Add(Me.NumericTime)
        Me.TimeBox.Controls.Add(Me.Hide)
        Me.TimeBox.Controls.Add(Me.timedesc)
        Me.TimeBox.Controls.Add(Me.Quit)
        Me.TimeBox.Controls.Add(Me.setbutton)
        Me.TimeBox.Location = New System.Drawing.Point(12, 12)
        Me.TimeBox.Name = "TimeBox"
        Me.TimeBox.Size = New System.Drawing.Size(259, 80)
        Me.TimeBox.TabIndex = 2
        Me.TimeBox.TabStop = False
        Me.TimeBox.Text = "Settings"
        '
        'StopStart
        '
        Me.StopStart.Location = New System.Drawing.Point(77, 47)
        Me.StopStart.Name = "StopStart"
        Me.StopStart.Size = New System.Drawing.Size(76, 23)
        Me.StopStart.TabIndex = 4
        Me.StopStart.Text = "Stop Timer"
        Me.StopStart.UseVisualStyleBackColor = True
        '
        'NumericTime
        '
        Me.NumericTime.Location = New System.Drawing.Point(102, 16)
        Me.NumericTime.Name = "NumericTime"
        Me.NumericTime.Size = New System.Drawing.Size(38, 20)
        Me.NumericTime.TabIndex = 3
        Me.NumericTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hide
        '
        Me.Hide.Location = New System.Drawing.Point(159, 47)
        Me.Hide.Name = "Hide"
        Me.Hide.Size = New System.Drawing.Size(44, 23)
        Me.Hide.TabIndex = 2
        Me.Hide.Text = "Hide"
        Me.Hide.UseVisualStyleBackColor = True
        '
        'timedesc
        '
        Me.timedesc.AutoSize = True
        Me.timedesc.Location = New System.Drawing.Point(3, 19)
        Me.timedesc.Name = "timedesc"
        Me.timedesc.Size = New System.Drawing.Size(93, 13)
        Me.timedesc.TabIndex = 1
        Me.timedesc.Text = "Set time (minutes):"
        '
        'ExecTimer
        '
        Me.ExecTimer.Enabled = True
        Me.ExecTimer.Interval = 60000
        '
        'NotifyIcon_Tray
        '
        Me.NotifyIcon_Tray.BalloonTipText = "Caffeine For Windows"
        Me.NotifyIcon_Tray.BalloonTipTitle = "Double click on this icon to open the settings form."
        Me.NotifyIcon_Tray.Icon = CType(resources.GetObject("NotifyIcon_Tray.Icon"), System.Drawing.Icon)
        Me.NotifyIcon_Tray.Text = "Notifyicontray"
        Me.NotifyIcon_Tray.Visible = True
        '
        'IconLabel
        '
        Me.IconLabel.AutoSize = True
        Me.IconLabel.Location = New System.Drawing.Point(12, 96)
        Me.IconLabel.Name = "IconLabel"
        Me.IconLabel.Size = New System.Drawing.Size(45, 13)
        Me.IconLabel.TabIndex = 3
        Me.IconLabel.Text = "Icon by:"
        '
        'githuburl
        '
        Me.githuburl.AutoSize = True
        Me.githuburl.Location = New System.Drawing.Point(64, 96)
        Me.githuburl.Name = "githuburl"
        Me.githuburl.Size = New System.Drawing.Size(41, 13)
        Me.githuburl.TabIndex = 4
        Me.githuburl.TabStop = True
        Me.githuburl.Text = "alecive"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Verison: 1.0.0"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 116)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.githuburl)
        Me.Controls.Add(Me.IconLabel)
        Me.Controls.Add(Me.TimeBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = False
        Me.Text = "Settings"
        Me.TimeBox.ResumeLayout(False)
        Me.TimeBox.PerformLayout()
        CType(Me.NumericTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents setbutton As System.Windows.Forms.Button
    Friend WithEvents Quit As System.Windows.Forms.Button
    Friend WithEvents TimeBox As System.Windows.Forms.GroupBox
    Friend WithEvents ExecTimer As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon_Tray As System.Windows.Forms.NotifyIcon
    Friend WithEvents IconLabel As System.Windows.Forms.Label
    Friend WithEvents githuburl As System.Windows.Forms.LinkLabel
    Friend WithEvents Hide As System.Windows.Forms.Button
    Friend WithEvents timedesc As System.Windows.Forms.Label
    Friend WithEvents NumericTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents StopStart As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
