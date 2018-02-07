<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Connect
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Connect))
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.lblPing = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.lblConnect = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblIPAddress = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNetwork = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPingms = New System.Windows.Forms.Label()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.picConnectionStatus = New System.Windows.Forms.PictureBox()
        Me.txtManual = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picConnectionStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCounter.Location = New System.Drawing.Point(211, 78)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(12, 12)
        Me.lblCounter.TabIndex = 34
        Me.lblCounter.Text = "0"
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.DarkGreen
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConnect.Location = New System.Drawing.Point(8, 156)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(84, 28)
        Me.btnConnect.TabIndex = 32
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'lblPing
        '
        Me.lblPing.AutoSize = True
        Me.lblPing.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPing.ForeColor = System.Drawing.Color.White
        Me.lblPing.Location = New System.Drawing.Point(96, 91)
        Me.lblPing.Name = "lblPing"
        Me.lblPing.Size = New System.Drawing.Size(40, 12)
        Me.lblPing.TabIndex = 31
        Me.lblPing.Text = "Ping:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(96, 78)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(117, 12)
        Me.lblTime.TabIndex = 30
        Me.lblTime.Text = "Connection Time:"
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblIP.ForeColor = System.Drawing.Color.White
        Me.lblIP.Location = New System.Drawing.Point(96, 45)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(26, 12)
        Me.lblIP.TabIndex = 29
        Me.lblIP.Text = "IP:"
        '
        'lblConnect
        '
        Me.lblConnect.AutoSize = True
        Me.lblConnect.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblConnect.ForeColor = System.Drawing.Color.White
        Me.lblConnect.Location = New System.Drawing.Point(95, 19)
        Me.lblConnect.Name = "lblConnect"
        Me.lblConnect.Size = New System.Drawing.Size(82, 12)
        Me.lblConnect.TabIndex = 28
        Me.lblConnect.Text = "Connection:"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(8, 19)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(85, 85)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 27
        Me.PictureBox4.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblIPAddress
        '
        Me.lblIPAddress.AutoSize = True
        Me.lblIPAddress.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblIPAddress.ForeColor = System.Drawing.Color.Red
        Me.lblIPAddress.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblIPAddress.Location = New System.Drawing.Point(123, 45)
        Me.lblIPAddress.Name = "lblIPAddress"
        Me.lblIPAddress.Size = New System.Drawing.Size(54, 12)
        Me.lblIPAddress.TabIndex = 39
        Me.lblIPAddress.Text = "0.0.0.0"
        Me.lblIPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(95, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 12)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Port:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(132, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 12)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "8080"
        '
        'lblNetwork
        '
        Me.lblNetwork.AutoSize = True
        Me.lblNetwork.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetwork.ForeColor = System.Drawing.Color.Yellow
        Me.lblNetwork.Location = New System.Drawing.Point(95, 31)
        Me.lblNetwork.Name = "lblNetwork"
        Me.lblNetwork.Size = New System.Drawing.Size(138, 12)
        Me.lblNetwork.TabIndex = 42
        Me.lblNetwork.Text = "Checking Network..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 12)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Packets Sent / Received:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPingms)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 104)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        '
        'lblPingms
        '
        Me.lblPingms.AutoSize = True
        Me.lblPingms.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPingms.ForeColor = System.Drawing.Color.White
        Me.lblPingms.Location = New System.Drawing.Point(131, 84)
        Me.lblPingms.Name = "lblPingms"
        Me.lblPingms.Size = New System.Drawing.Size(33, 12)
        Me.lblPingms.TabIndex = 47
        Me.lblPingms.Text = "0 ms"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.BackColor = System.Drawing.Color.Red
        Me.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisconnect.Location = New System.Drawing.Point(8, 184)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(127, 28)
        Me.btnDisconnect.TabIndex = 45
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = False
        '
        'picConnectionStatus
        '
        Me.picConnectionStatus.BackColor = System.Drawing.Color.Transparent
        Me.picConnectionStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picConnectionStatus.Image = Global.ProxyV4.My.Resources.Resources.icons8_cancel_80
        Me.picConnectionStatus.Location = New System.Drawing.Point(9, 69)
        Me.picConnectionStatus.Name = "picConnectionStatus"
        Me.picConnectionStatus.Size = New System.Drawing.Size(35, 34)
        Me.picConnectionStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picConnectionStatus.TabIndex = 46
        Me.picConnectionStatus.TabStop = False
        '
        'txtManual
        '
        Me.txtManual.BackColor = System.Drawing.Color.DimGray
        Me.txtManual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtManual.Location = New System.Drawing.Point(236, 190)
        Me.txtManual.Name = "txtManual"
        Me.txtManual.Size = New System.Drawing.Size(140, 20)
        Me.txtManual.TabIndex = 47
        Me.txtManual.Text = "IP Address"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gold
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(92, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 28)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "SSL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(281, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 104)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        '
        'Connect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtManual)
        Me.Controls.Add(Me.picConnectionStatus)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.lblNetwork)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblIPAddress)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.lblPing)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.lblConnect)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Connect"
        Me.Size = New System.Drawing.Size(503, 222)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picConnectionStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCounter As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents lblPing As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblIP As Label
    Friend WithEvents lblConnect As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblIPAddress As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNetwork As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents picConnectionStatus As PictureBox
    Friend WithEvents lblPingms As Label
    Friend WithEvents txtManual As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
