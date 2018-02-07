Public Class Update
    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblClient.Text = lblServer.Text Then
            lblUpdate.Text = "You Are Up-To-Date!"
        Else
            lblUpdate.Text = "You have Pending Updates!"
            lblUpdate.ForeColor = Color.Yellow
        End If
    End Sub
End Class
