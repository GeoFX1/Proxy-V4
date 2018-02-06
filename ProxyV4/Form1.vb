Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

#Region "Tab Hovers"

    Dim UserSelectedMenu As String

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles pnlConnect.MouseEnter
        If UserSelectedMenu = "connect" Then
        Else
            pnlConnect.BackColor = Color.FromArgb(45, 45, 48)
        End If
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles pnlConnect.MouseLeave
        If UserSelectedMenu = "connect" Then
        Else
            pnlConnect.BackColor = Color.FromArgb(63, 63, 70)
        End If
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles lblConnect.MouseEnter
        If UserSelectedMenu = "connect" Then
        Else
            pnlConnect.BackColor = Color.FromArgb(45, 45, 48)
        End If
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles lblConnect.MouseLeave
        If UserSelectedMenu = "connect" Then
        Else
            pnlConnect.BackColor = Color.FromArgb(63, 63, 70)
        End If
    End Sub

    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles pnlSettings.MouseEnter
        If UserSelectedMenu = "settings" Then
        Else
            pnlSettings.BackColor = Color.FromArgb(45, 45, 48)
        End If
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles lblSettings.MouseEnter
        If UserSelectedMenu = "settings" Then
        Else
            pnlSettings.BackColor = Color.FromArgb(45, 45, 48)
        End If
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles pnlSettings.MouseLeave
        If UserSelectedMenu = "settings" Then
        Else
            pnlSettings.BackColor = Color.FromArgb(63, 63, 70)
        End If
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles lblSettings.MouseLeave
        If UserSelectedMenu = "settings" Then
        Else
            pnlSettings.BackColor = Color.FromArgb(63, 63, 70)
        End If
    End Sub

    Private Sub Panel3_MouseEnter(sender As Object, e As EventArgs) Handles pnlUpdate.MouseEnter
        If UserSelectedMenu = "update" Then
        Else
            pnlUpdate.BackColor = Color.FromArgb(45, 45, 48)
        End If
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles pnlUpdate.MouseLeave
        If UserSelectedMenu = "update" Then
        Else
            pnlUpdate.BackColor = Color.FromArgb(63, 63, 70)
        End If
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles lblUpdate.MouseEnter
        If UserSelectedMenu = "update" Then
        Else
            pnlUpdate.BackColor = Color.FromArgb(45, 45, 48)
        End If
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles lblUpdate.MouseLeave
        If UserSelectedMenu = "update" Then
        Else
            pnlUpdate.BackColor = Color.FromArgb(63, 63, 70)
        End If
    End Sub

    Private Sub Panel4_MouseEnter(sender As Object, e As EventArgs) Handles pnlHelp.MouseEnter
        If UserSelectedMenu = "help" Then
        Else
            pnlHelp.BackColor = Color.FromArgb(45, 45, 48)
        End If
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles lblHelp.MouseEnter
        If UserSelectedMenu = "help" Then
        Else
            pnlHelp.BackColor = Color.FromArgb(45, 45, 48)
        End If
    End Sub

    Private Sub Panel4_MouseLeave(sender As Object, e As EventArgs) Handles pnlHelp.MouseLeave
        If UserSelectedMenu = "help" Then
        Else
            pnlHelp.BackColor = Color.FromArgb(63, 63, 70)
        End If
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles lblHelp.MouseLeave
        If UserSelectedMenu = "help" Then
        Else
            pnlHelp.BackColor = Color.FromArgb(63, 63, 70)
        End If
    End Sub

    Private Sub Panel5_MouseEnter(sender As Object, e As EventArgs) Handles pnlConsole.MouseEnter
        If UserSelectedMenu = "console" Then
        Else
            pnlConsole.BackColor = Color.FromArgb(45, 45, 48)
        End If
    End Sub

    Private Sub Panel5_MouseLeave(sender As Object, e As EventArgs) Handles pnlConsole.MouseLeave
        pnlConsole.BackColor = Color.FromArgb(63, 63, 70)
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles lblConsole.MouseEnter
        If UserSelectedMenu = "console" Then
        Else
            pnlConsole.BackColor = Color.FromArgb(45, 45, 48)
        End If
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles lblConsole.MouseLeave
        If UserSelectedMenu = "console" Then
        Else
            pnlConsole.BackColor = Color.FromArgb(63, 63, 70)
        End If
    End Sub

#End Region
#Region "Tab Control"
    'Connect
    Private Sub pnlConnect_Click(sender As Object, e As EventArgs) Handles pnlConnect.Click
        Dim Display As New Connect
        pnlMenuDisplay.Controls.Clear()
        pnlMenuDisplay.Controls.Add(Display)

        UserSelectedMenu = "connect"
        pnlConnect.BackColor = Color.FromArgb(45, 45, 48)
        pnlSettings.BackColor = Color.FromArgb(63, 63, 70)
        pnlUpdate.BackColor = Color.FromArgb(63, 63, 70)
        pnlHelp.BackColor = Color.FromArgb(63, 63, 70)
        pnlConsole.BackColor = Color.FromArgb(63, 63, 70)
    End Sub
    Private Sub lblConnect_Click(sender As Object, e As EventArgs) Handles lblConnect.Click
        Dim Display As New Connect
        pnlMenuDisplay.Controls.Clear()
        pnlMenuDisplay.Controls.Add(Display)

        UserSelectedMenu = "connect"
        pnlConnect.BackColor = Color.FromArgb(45, 45, 48)
        pnlSettings.BackColor = Color.FromArgb(63, 63, 70)
        pnlUpdate.BackColor = Color.FromArgb(63, 63, 70)
        pnlHelp.BackColor = Color.FromArgb(63, 63, 70)
        pnlConsole.BackColor = Color.FromArgb(63, 63, 70)
    End Sub
    'Settings
    Private Sub pnlSettings_Click(sender As Object, e As EventArgs) Handles pnlSettings.Click
        Dim Display As New Settings
        pnlMenuDisplay.Controls.Clear()
        pnlMenuDisplay.Controls.Add(Display)

        UserSelectedMenu = "settings"
        pnlConnect.BackColor = Color.FromArgb(63, 63, 70)
        pnlSettings.BackColor = Color.FromArgb(45, 45, 48)
        pnlUpdate.BackColor = Color.FromArgb(63, 63, 70)
        pnlHelp.BackColor = Color.FromArgb(63, 63, 70)
        pnlConsole.BackColor = Color.FromArgb(63, 63, 70)
    End Sub
    Private Sub lblSettings_Click(sender As Object, e As EventArgs) Handles lblSettings.Click
        Dim Display As New Settings
        pnlMenuDisplay.Controls.Clear()
        pnlMenuDisplay.Controls.Add(Display)

        UserSelectedMenu = "settings"
        pnlConnect.BackColor = Color.FromArgb(63, 63, 70)
        pnlSettings.BackColor = Color.FromArgb(45, 45, 48)
        pnlUpdate.BackColor = Color.FromArgb(63, 63, 70)
        pnlHelp.BackColor = Color.FromArgb(63, 63, 70)
        pnlConsole.BackColor = Color.FromArgb(63, 63, 70)
    End Sub
    'Update
    Private Sub pnlUpdate_Click(sender As Object, e As EventArgs) Handles pnlUpdate.Click
        Dim Display As New Update
        pnlMenuDisplay.Controls.Clear()
        pnlMenuDisplay.Controls.Add(Display)

        UserSelectedMenu = "update"
        pnlConnect.BackColor = Color.FromArgb(63, 63, 70)
        pnlSettings.BackColor = Color.FromArgb(63, 63, 70)
        pnlUpdate.BackColor = Color.FromArgb(45, 45, 48)
        pnlHelp.BackColor = Color.FromArgb(63, 63, 70)
        pnlConsole.BackColor = Color.FromArgb(63, 63, 70)
    End Sub
    Private Sub lblUpdate_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click
        Dim Display As New Update
        pnlMenuDisplay.Controls.Clear()
        pnlMenuDisplay.Controls.Add(Display)

        UserSelectedMenu = "update"
        pnlConnect.BackColor = Color.FromArgb(63, 63, 70)
        pnlSettings.BackColor = Color.FromArgb(63, 63, 70)
        pnlUpdate.BackColor = Color.FromArgb(45, 45, 48)
        pnlHelp.BackColor = Color.FromArgb(63, 63, 70)
        pnlConsole.BackColor = Color.FromArgb(63, 63, 70)
    End Sub
    'Help
    Private Sub pnlHelp_Click(sender As Object, e As EventArgs) Handles pnlHelp.Click
        Dim Display As New Help
        pnlMenuDisplay.Controls.Clear()
        pnlMenuDisplay.Controls.Add(Display)

        UserSelectedMenu = "help"
        pnlConnect.BackColor = Color.FromArgb(63, 63, 70)
        pnlSettings.BackColor = Color.FromArgb(63, 63, 70)
        pnlUpdate.BackColor = Color.FromArgb(63, 63, 70)
        pnlHelp.BackColor = Color.FromArgb(45, 45, 48)
        pnlConsole.BackColor = Color.FromArgb(63, 63, 70)
    End Sub
    Private Sub lblHelp_Click(sender As Object, e As EventArgs) Handles lblHelp.Click
        Dim Display As New Help
        pnlMenuDisplay.Controls.Clear()
        pnlMenuDisplay.Controls.Add(Display)

        UserSelectedMenu = "help"
        pnlConnect.BackColor = Color.FromArgb(63, 63, 70)
        pnlSettings.BackColor = Color.FromArgb(63, 63, 70)
        pnlUpdate.BackColor = Color.FromArgb(63, 63, 70)
        pnlHelp.BackColor = Color.FromArgb(45, 45, 48)
        pnlConsole.BackColor = Color.FromArgb(63, 63, 70)
    End Sub
    'Console
    Private Sub pnlConsole_Click(sender As Object, e As EventArgs) Handles pnlConsole.Click
        Dim Display As New Console
        pnlMenuDisplay.Controls.Clear()
        pnlMenuDisplay.Controls.Add(Display)

        UserSelectedMenu = "console"
        pnlConnect.BackColor = Color.FromArgb(63, 63, 70)
        pnlSettings.BackColor = Color.FromArgb(63, 63, 70)
        pnlUpdate.BackColor = Color.FromArgb(63, 63, 70)
        pnlHelp.BackColor = Color.FromArgb(63, 63, 70)
        pnlConsole.BackColor = Color.FromArgb(45, 45, 48)
    End Sub
    Private Sub lblConsole_Click(sender As Object, e As EventArgs) Handles lblConsole.Click
        Dim Display As New Console
        pnlMenuDisplay.Controls.Clear()
        pnlMenuDisplay.Controls.Add(Display)

        UserSelectedMenu = "console"
        pnlConnect.BackColor = Color.FromArgb(63, 63, 70)
        pnlSettings.BackColor = Color.FromArgb(63, 63, 70)
        pnlUpdate.BackColor = Color.FromArgb(63, 63, 70)
        pnlHelp.BackColor = Color.FromArgb(63, 63, 70)
        pnlConsole.BackColor = Color.FromArgb(45, 45, 48)
    End Sub
#End Region
End Class
