<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlConnect = New System.Windows.Forms.Panel()
        Me.lblConnect = New System.Windows.Forms.Label()
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.pnlUpdate = New System.Windows.Forms.Panel()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.pnlHelp = New System.Windows.Forms.Panel()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.pnlConsole = New System.Windows.Forms.Panel()
        Me.lblConsole = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlMenuDisplay = New System.Windows.Forms.Panel()
        Me.pnlConnect.SuspendLayout()
        Me.pnlSettings.SuspendLayout()
        Me.pnlUpdate.SuspendLayout()
        Me.pnlHelp.SuspendLayout()
        Me.pnlConsole.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlConnect
        '
        Me.pnlConnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlConnect.Controls.Add(Me.lblConnect)
        Me.pnlConnect.Location = New System.Drawing.Point(-4, 22)
        Me.pnlConnect.Name = "pnlConnect"
        Me.pnlConnect.Size = New System.Drawing.Size(101, 32)
        Me.pnlConnect.TabIndex = 0
        '
        'lblConnect
        '
        Me.lblConnect.AutoSize = True
        Me.lblConnect.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnect.ForeColor = System.Drawing.SystemColors.Control
        Me.lblConnect.Location = New System.Drawing.Point(22, 10)
        Me.lblConnect.Name = "lblConnect"
        Me.lblConnect.Size = New System.Drawing.Size(54, 12)
        Me.lblConnect.TabIndex = 5
        Me.lblConnect.Text = "Connect"
        '
        'pnlSettings
        '
        Me.pnlSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlSettings.Controls.Add(Me.lblSettings)
        Me.pnlSettings.Location = New System.Drawing.Point(97, 22)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(101, 32)
        Me.pnlSettings.TabIndex = 1
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSettings.Location = New System.Drawing.Point(21, 10)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(61, 12)
        Me.lblSettings.TabIndex = 6
        Me.lblSettings.Text = "Settings"
        '
        'pnlUpdate
        '
        Me.pnlUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlUpdate.Controls.Add(Me.lblUpdate)
        Me.pnlUpdate.Location = New System.Drawing.Point(198, 22)
        Me.pnlUpdate.Name = "pnlUpdate"
        Me.pnlUpdate.Size = New System.Drawing.Size(101, 32)
        Me.pnlUpdate.TabIndex = 2
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUpdate.Location = New System.Drawing.Point(28, 10)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(47, 12)
        Me.lblUpdate.TabIndex = 7
        Me.lblUpdate.Text = "Update"
        '
        'pnlHelp
        '
        Me.pnlHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlHelp.Controls.Add(Me.lblHelp)
        Me.pnlHelp.Location = New System.Drawing.Point(299, 22)
        Me.pnlHelp.Name = "pnlHelp"
        Me.pnlHelp.Size = New System.Drawing.Size(101, 32)
        Me.pnlHelp.TabIndex = 3
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHelp.Location = New System.Drawing.Point(34, 10)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(33, 12)
        Me.lblHelp.TabIndex = 8
        Me.lblHelp.Text = "Help"
        '
        'pnlConsole
        '
        Me.pnlConsole.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlConsole.Controls.Add(Me.lblConsole)
        Me.pnlConsole.Location = New System.Drawing.Point(400, 22)
        Me.pnlConsole.Name = "pnlConsole"
        Me.pnlConsole.Size = New System.Drawing.Size(111, 32)
        Me.pnlConsole.TabIndex = 4
        '
        'lblConsole
        '
        Me.lblConsole.AutoSize = True
        Me.lblConsole.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsole.ForeColor = System.Drawing.SystemColors.Control
        Me.lblConsole.Location = New System.Drawing.Point(25, 10)
        Me.lblConsole.Name = "lblConsole"
        Me.lblConsole.Size = New System.Drawing.Size(54, 12)
        Me.lblConsole.TabIndex = 9
        Me.lblConsole.Text = "Console"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(36, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 12)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Proxy Connect"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(479, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'pnlMenuDisplay
        '
        Me.pnlMenuDisplay.Location = New System.Drawing.Point(-1, 55)
        Me.pnlMenuDisplay.Name = "pnlMenuDisplay"
        Me.pnlMenuDisplay.Size = New System.Drawing.Size(503, 222)
        Me.pnlMenuDisplay.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(503, 276)
        Me.Controls.Add(Me.pnlMenuDisplay)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlConsole)
        Me.Controls.Add(Me.pnlHelp)
        Me.Controls.Add(Me.pnlUpdate)
        Me.Controls.Add(Me.pnlSettings)
        Me.Controls.Add(Me.pnlConnect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlConnect.ResumeLayout(False)
        Me.pnlConnect.PerformLayout()
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlSettings.PerformLayout()
        Me.pnlUpdate.ResumeLayout(False)
        Me.pnlUpdate.PerformLayout()
        Me.pnlHelp.ResumeLayout(False)
        Me.pnlHelp.PerformLayout()
        Me.pnlConsole.ResumeLayout(False)
        Me.pnlConsole.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlConnect As Panel
    Friend WithEvents pnlSettings As Panel
    Friend WithEvents pnlUpdate As Panel
    Friend WithEvents pnlHelp As Panel
    Friend WithEvents lblConnect As Label
    Friend WithEvents lblSettings As Label
    Friend WithEvents lblUpdate As Label
    Friend WithEvents lblHelp As Label
    Friend WithEvents pnlConsole As Panel
    Friend WithEvents lblConsole As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pnlMenuDisplay As Panel
End Class
