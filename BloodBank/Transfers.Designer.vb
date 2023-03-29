<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transfers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transfers))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DashboardLinkBtn = New System.Windows.Forms.Label()
        Me.TransferLinkBtn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DonateLinkBtn = New System.Windows.Forms.Label()
        Me.DonorsLinkBtn = New System.Windows.Forms.Label()
        Me.PatientLinkBtn = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PatientName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PatientBGroup = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TransferBtn = New System.Windows.Forms.Button()
        Me.PatientId = New System.Windows.Forms.ComboBox()
        Me.Available = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DashboardLinkBtn)
        Me.Panel1.Controls.Add(Me.TransferLinkBtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DonateLinkBtn)
        Me.Panel1.Controls.Add(Me.DonorsLinkBtn)
        Me.Panel1.Controls.Add(Me.PatientLinkBtn)
        Me.Panel1.Location = New System.Drawing.Point(42, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(902, 42)
        Me.Panel1.TabIndex = 16
        '
        'DashboardLinkBtn
        '
        Me.DashboardLinkBtn.AutoSize = True
        Me.DashboardLinkBtn.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DashboardLinkBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.DashboardLinkBtn.Location = New System.Drawing.Point(468, 14)
        Me.DashboardLinkBtn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DashboardLinkBtn.Name = "DashboardLinkBtn"
        Me.DashboardLinkBtn.Size = New System.Drawing.Size(83, 17)
        Me.DashboardLinkBtn.TabIndex = 12
        Me.DashboardLinkBtn.Text = "Dashboard"
        '
        'TransferLinkBtn
        '
        Me.TransferLinkBtn.AutoSize = True
        Me.TransferLinkBtn.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TransferLinkBtn.ForeColor = System.Drawing.Color.Red
        Me.TransferLinkBtn.Location = New System.Drawing.Point(787, 14)
        Me.TransferLinkBtn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TransferLinkBtn.Name = "TransferLinkBtn"
        Me.TransferLinkBtn.Size = New System.Drawing.Size(110, 17)
        Me.TransferLinkBtn.TabIndex = 11
        Me.TransferLinkBtn.Text = "Blood Transfer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Blood Bank"
        '
        'DonateLinkBtn
        '
        Me.DonateLinkBtn.AutoSize = True
        Me.DonateLinkBtn.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DonateLinkBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.DonateLinkBtn.Location = New System.Drawing.Point(715, 14)
        Me.DonateLinkBtn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DonateLinkBtn.Name = "DonateLinkBtn"
        Me.DonateLinkBtn.Size = New System.Drawing.Size(58, 17)
        Me.DonateLinkBtn.TabIndex = 10
        Me.DonateLinkBtn.Text = "Donate"
        '
        'DonorsLinkBtn
        '
        Me.DonorsLinkBtn.AutoSize = True
        Me.DonorsLinkBtn.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DonorsLinkBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.DonorsLinkBtn.Location = New System.Drawing.Point(565, 14)
        Me.DonorsLinkBtn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DonorsLinkBtn.Name = "DonorsLinkBtn"
        Me.DonorsLinkBtn.Size = New System.Drawing.Size(58, 17)
        Me.DonorsLinkBtn.TabIndex = 6
        Me.DonorsLinkBtn.Text = "Donors"
        '
        'PatientLinkBtn
        '
        Me.PatientLinkBtn.AutoSize = True
        Me.PatientLinkBtn.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PatientLinkBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.PatientLinkBtn.Location = New System.Drawing.Point(637, 14)
        Me.PatientLinkBtn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PatientLinkBtn.Name = "PatientLinkBtn"
        Me.PatientLinkBtn.Size = New System.Drawing.Size(64, 17)
        Me.PatientLinkBtn.TabIndex = 7
        Me.PatientLinkBtn.Text = "Patients"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(407, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 19)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Blood Transfer"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.PatientName)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.PatientBGroup)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.TransferBtn)
        Me.Panel2.Location = New System.Drawing.Point(237, 129)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(454, 246)
        Me.Panel2.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(36, 24)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 15)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Select Patient Id"
        '
        'PatientName
        '
        Me.PatientName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PatientName.Enabled = False
        Me.PatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PatientName.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.PatientName.Location = New System.Drawing.Point(35, 93)
        Me.PatientName.Margin = New System.Windows.Forms.Padding(4)
        Me.PatientName.Name = "PatientName"
        Me.PatientName.Size = New System.Drawing.Size(169, 22)
        Me.PatientName.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(35, 124)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 15)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Blood Group"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(35, 75)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 15)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Name"
        '
        'PatientBGroup
        '
        Me.PatientBGroup.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PatientBGroup.Enabled = False
        Me.PatientBGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PatientBGroup.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.PatientBGroup.Location = New System.Drawing.Point(35, 142)
        Me.PatientBGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.PatientBGroup.Name = "PatientBGroup"
        Me.PatientBGroup.Size = New System.Drawing.Size(169, 22)
        Me.PatientBGroup.TabIndex = 56
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(237, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'TransferBtn
        '
        Me.TransferBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TransferBtn.ForeColor = System.Drawing.Color.Red
        Me.TransferBtn.Location = New System.Drawing.Point(80, 187)
        Me.TransferBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.TransferBtn.Name = "TransferBtn"
        Me.TransferBtn.Size = New System.Drawing.Size(78, 26)
        Me.TransferBtn.TabIndex = 48
        Me.TransferBtn.Text = "Transfer"
        Me.TransferBtn.UseVisualStyleBackColor = True
        '
        'PatientId
        '
        Me.PatientId.FormattingEnabled = True
        Me.PatientId.Location = New System.Drawing.Point(274, 172)
        Me.PatientId.Name = "PatientId"
        Me.PatientId.Size = New System.Drawing.Size(170, 23)
        Me.PatientId.TabIndex = 61
        '
        'Available
        '
        Me.Available.AutoSize = True
        Me.Available.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Available.ForeColor = System.Drawing.Color.DarkRed
        Me.Available.Location = New System.Drawing.Point(401, 100)
        Me.Available.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Available.Name = "Available"
        Me.Available.Size = New System.Drawing.Size(163, 19)
        Me.Available.TabIndex = 55
        Me.Available.Text = "No Blood Available"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(951, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 62
        Me.PictureBox2.TabStop = False
        '
        'Transfers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(980, 630)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PatientId)
        Me.Controls.Add(Me.Available)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transfers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DashboardLinkBtn As Label
    Friend WithEvents TransferLinkBtn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DonateLinkBtn As Label
    Friend WithEvents DonorsLinkBtn As Label
    Friend WithEvents PatientLinkBtn As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TransferBtn As Button
    Friend WithEvents PatientName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PatientBGroup As TextBox
    Friend WithEvents PatientId As ComboBox
    Friend WithEvents Available As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
