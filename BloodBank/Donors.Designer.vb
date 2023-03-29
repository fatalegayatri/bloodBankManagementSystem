<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Donors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Donors))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TransferLinkBtn = New System.Windows.Forms.Label()
        Me.DonateLinkBtn = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DAge = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DPhone = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DGend = New System.Windows.Forms.ListBox()
        Me.DBGroup = New System.Windows.Forms.ListBox()
        Me.DAdd = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.DltBtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DonorsDGV = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonorsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(550, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Donors"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(638, 14)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Patients"
        '
        'TransferLinkBtn
        '
        Me.TransferLinkBtn.AutoSize = True
        Me.TransferLinkBtn.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TransferLinkBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.TransferLinkBtn.Location = New System.Drawing.Point(819, 14)
        Me.TransferLinkBtn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TransferLinkBtn.Name = "TransferLinkBtn"
        Me.TransferLinkBtn.Size = New System.Drawing.Size(110, 17)
        Me.TransferLinkBtn.TabIndex = 11
        Me.TransferLinkBtn.Text = "Blood Transfer"
        '
        'DonateLinkBtn
        '
        Me.DonateLinkBtn.AutoSize = True
        Me.DonateLinkBtn.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DonateLinkBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.DonateLinkBtn.Location = New System.Drawing.Point(737, 14)
        Me.DonateLinkBtn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DonateLinkBtn.Name = "DonateLinkBtn"
        Me.DonateLinkBtn.Size = New System.Drawing.Size(58, 17)
        Me.DonateLinkBtn.TabIndex = 10
        Me.DonateLinkBtn.Text = "Donate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(430, 14)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Dashboard"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TransferLinkBtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DonateLinkBtn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(937, 42)
        Me.Panel1.TabIndex = 13
        '
        'DName
        '
        Me.DName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DName.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.DName.Location = New System.Drawing.Point(76, 118)
        Me.DName.Margin = New System.Windows.Forms.Padding(4)
        Me.DName.Name = "DName"
        Me.DName.PlaceholderText = "Enter Donor Name"
        Me.DName.Size = New System.Drawing.Size(258, 22)
        Me.DName.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(76, 94)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Donor Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(76, 148)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Age"
        '
        'DAge
        '
        Me.DAge.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DAge.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.DAge.Location = New System.Drawing.Point(76, 172)
        Me.DAge.Margin = New System.Windows.Forms.Padding(4)
        Me.DAge.Name = "DAge"
        Me.DAge.PlaceholderText = "Age"
        Me.DAge.Size = New System.Drawing.Size(258, 22)
        Me.DAge.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(76, 256)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Mobile No."
        '
        'DPhone
        '
        Me.DPhone.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DPhone.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.DPhone.Location = New System.Drawing.Point(76, 280)
        Me.DPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.DPhone.Name = "DPhone"
        Me.DPhone.PlaceholderText = "Enter Mobile No."
        Me.DPhone.Size = New System.Drawing.Size(258, 22)
        Me.DPhone.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.DarkRed
        Me.Label12.Location = New System.Drawing.Point(76, 202)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Address"
        '
        'DGend
        '
        Me.DGend.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DGend.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DGend.ForeColor = System.Drawing.Color.DarkRed
        Me.DGend.FormattingEnabled = True
        Me.DGend.HorizontalExtent = 2
        Me.DGend.ItemHeight = 16
        Me.DGend.Items.AddRange(New Object() {"Gender", "Male", "Female"})
        Me.DGend.Location = New System.Drawing.Point(76, 331)
        Me.DGend.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DGend.Name = "DGend"
        Me.DGend.Size = New System.Drawing.Size(123, 20)
        Me.DGend.TabIndex = 26
        '
        'DBGroup
        '
        Me.DBGroup.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DBGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DBGroup.ForeColor = System.Drawing.Color.DarkRed
        Me.DBGroup.FormattingEnabled = True
        Me.DBGroup.HorizontalExtent = 2
        Me.DBGroup.ItemHeight = 16
        Me.DBGroup.Items.AddRange(New Object() {"Blood Group", "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-"})
        Me.DBGroup.Location = New System.Drawing.Point(211, 331)
        Me.DBGroup.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DBGroup.Name = "DBGroup"
        Me.DBGroup.Size = New System.Drawing.Size(123, 20)
        Me.DBGroup.TabIndex = 27
        '
        'DAdd
        '
        Me.DAdd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DAdd.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.DAdd.Location = New System.Drawing.Point(76, 226)
        Me.DAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.DAdd.Multiline = True
        Me.DAdd.Name = "DAdd"
        Me.DAdd.PlaceholderText = "Address"
        Me.DAdd.Size = New System.Drawing.Size(258, 22)
        Me.DAdd.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(421, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(521, 356)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'AddBtn
        '
        Me.AddBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AddBtn.ForeColor = System.Drawing.Color.Red
        Me.AddBtn.Location = New System.Drawing.Point(76, 383)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(69, 26)
        Me.AddBtn.TabIndex = 30
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'EditBtn
        '
        Me.EditBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EditBtn.ForeColor = System.Drawing.Color.Red
        Me.EditBtn.Location = New System.Drawing.Point(170, 383)
        Me.EditBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(69, 26)
        Me.EditBtn.TabIndex = 31
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'DltBtn
        '
        Me.DltBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DltBtn.ForeColor = System.Drawing.Color.Red
        Me.DltBtn.Location = New System.Drawing.Point(264, 383)
        Me.DltBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.DltBtn.Name = "DltBtn"
        Me.DltBtn.Size = New System.Drawing.Size(69, 26)
        Me.DltBtn.TabIndex = 32
        Me.DltBtn.Text = "Delete"
        Me.DltBtn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(448, 472)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 24)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Donors List"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(970, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'DonorsDGV
        '
        Me.DonorsDGV.BackgroundColor = System.Drawing.Color.Cornsilk
        Me.DonorsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DonorsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DonorsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DonorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DonorsDGV.Location = New System.Drawing.Point(76, 511)
        Me.DonorsDGV.Name = "DonorsDGV"
        Me.DonorsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DonorsDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DonorsDGV.RowTemplate.Height = 25
        Me.DonorsDGV.Size = New System.Drawing.Size(866, 210)
        Me.DonorsDGV.TabIndex = 33
        '
        'Donors
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(1000, 749)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DonorsDGV)
        Me.Controls.Add(Me.DltBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DAdd)
        Me.Controls.Add(Me.DBGroup)
        Me.Controls.Add(Me.DGend)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DPhone)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DAge)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DName)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Donors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doners"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonorsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TransferLinkBtn As Label
    Friend WithEvents DonateLinkBtn As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DAge As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DPhone As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DGend As ListBox
    Friend WithEvents DBGroup As ListBox
    Friend WithEvents DAdd As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents DltBtn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DonorsDGV As DataGridView
End Class
