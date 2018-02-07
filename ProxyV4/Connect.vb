Imports System.Net
Imports System.IO

Public Class Connect
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblCounter.Text = lblCounter.Text + 1
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Timer1.Start()
        txtManual.Text = "IP Address"
    End Sub

    Private Sub btnDisconnect_Click_1(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        Timer1.Stop()
        lblCounter.Text = "0"
    End Sub

    Private Sub Connect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display IP Address
        Dim req As HttpWebRequest = WebRequest.Create("https://tools.feron.it/php/ip.php")
        Dim res As HttpWebResponse = req.GetResponse()
        Dim stream As Stream = res.GetResponseStream

        Dim sr As New StreamReader(stream)
        lblIPAddress.Text = sr.ReadToEnd()

        If My.Computer.Network.IsAvailable Then
            lblNetwork.Text = "Ready To Connect..."
            lblNetwork.ForeColor = Color.Green
            picConnectionStatus.Image = Image.FromFile("C:\Users\ethan\source\repos\ProxyV4\Proxy-V4\ProxyV4\Resources\icons8-ok-80 (1).png")
        Else
            lblNetwork.Text = "Checking Network..."
            lblNetwork.ForeColor = Color.Yellow
            picConnectionStatus.Image = Image.FromFile("C:\Users\ethan\source\repos\ProxyV4\Proxy-V4\ProxyV4\Resources\icons8-cancel-80.png")
        End If
    End Sub

    Private Sub txtManual_Enter(sender As Object, e As EventArgs) Handles txtManual.Enter
        txtManual.Text = ""
        'Upon entry set the Text Box to display nothing
    End Sub

    Private Sub txtManual_Leave(sender As Object, e As EventArgs) Handles txtManual.Leave
        If txtManual.Text = "" Then
            txtManual.Text = "IP Address"
        End If
        'Upon leaving, if the text box has nothing in it change text back to IP Address
    End Sub


End Class
