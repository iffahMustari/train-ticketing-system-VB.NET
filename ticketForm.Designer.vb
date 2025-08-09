<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ticketForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ticketForm))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblArrivalTime = New System.Windows.Forms.Label()
        Me.lblDepartureTime = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblGoingTo = New System.Windows.Forms.Label()
        Me.lblTravelTime = New System.Windows.Forms.Label()
        Me.lblDeparting = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnAdd.Image = Global.trainSystem.My.Resources.Resources.Screenshot_2025_01_29_233015
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(446, 514)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(324, 49)
        Me.btnAdd.TabIndex = 30
        Me.btnAdd.Text = "Add Another Trip"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(887, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(253, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'btnCheckOut
        '
        Me.btnCheckOut.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckOut.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCheckOut.Location = New System.Drawing.Point(932, 616)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(208, 49)
        Me.btnCheckOut.TabIndex = 42
        Me.btnCheckOut.Text = "Check Out"
        Me.btnCheckOut.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.lblPrice)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lblDeparting)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1041, 349)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnRemove.Location = New System.Drawing.Point(839, 300)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(172, 32)
        Me.btnRemove.TabIndex = 45
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSelect.Location = New System.Drawing.Point(26, 300)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(172, 32)
        Me.btnSelect.TabIndex = 44
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblPrice.Location = New System.Drawing.Point(691, 31)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(320, 27)
        Me.lblPrice.TabIndex = 38
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblArrivalTime)
        Me.GroupBox2.Controls.Add(Me.lblDepartureTime)
        Me.GroupBox2.Controls.Add(Me.lblFullName)
        Me.GroupBox2.Controls.Add(Me.lblGoingTo)
        Me.GroupBox2.Controls.Add(Me.lblTravelTime)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(985, 205)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(600, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(358, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(610, 35)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "sit in any vacant unreserved seat except first class or reserved seat"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblArrivalTime
        '
        Me.lblArrivalTime.BackColor = System.Drawing.Color.Transparent
        Me.lblArrivalTime.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrivalTime.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblArrivalTime.Location = New System.Drawing.Point(639, 40)
        Me.lblArrivalTime.Name = "lblArrivalTime"
        Me.lblArrivalTime.Size = New System.Drawing.Size(329, 27)
        Me.lblArrivalTime.TabIndex = 50
        Me.lblArrivalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDepartureTime
        '
        Me.lblDepartureTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartureTime.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartureTime.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDepartureTime.Location = New System.Drawing.Point(255, 40)
        Me.lblDepartureTime.Name = "lblDepartureTime"
        Me.lblDepartureTime.Size = New System.Drawing.Size(324, 27)
        Me.lblDepartureTime.TabIndex = 49
        Me.lblDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFullName
        '
        Me.lblFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Image = Global.trainSystem.My.Resources.Resources.Screenshot_2025_01_29_040135
        Me.lblFullName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFullName.Location = New System.Drawing.Point(14, 149)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(225, 45)
        Me.lblFullName.TabIndex = 48
        Me.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGoingTo
        '
        Me.lblGoingTo.BackColor = System.Drawing.Color.Transparent
        Me.lblGoingTo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoingTo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblGoingTo.Location = New System.Drawing.Point(16, 93)
        Me.lblGoingTo.Name = "lblGoingTo"
        Me.lblGoingTo.Size = New System.Drawing.Size(335, 27)
        Me.lblGoingTo.TabIndex = 47
        Me.lblGoingTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTravelTime
        '
        Me.lblTravelTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTravelTime.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTravelTime.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTravelTime.Location = New System.Drawing.Point(600, 158)
        Me.lblTravelTime.Name = "lblTravelTime"
        Me.lblTravelTime.Size = New System.Drawing.Size(368, 27)
        Me.lblTravelTime.TabIndex = 46
        Me.lblTravelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDeparting
        '
        Me.lblDeparting.BackColor = System.Drawing.Color.Transparent
        Me.lblDeparting.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeparting.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDeparting.Location = New System.Drawing.Point(23, 31)
        Me.lblDeparting.Name = "lblDeparting"
        Me.lblDeparting.Size = New System.Drawing.Size(317, 27)
        Me.lblDeparting.TabIndex = 36
        Me.lblDeparting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(58, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(315, 51)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Select you ticket"
        '
        'ticketForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1152, 677)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnAdd)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ticketForm"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblDeparting As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblGoingTo As Label
    Friend WithEvents lblTravelTime As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblArrivalTime As Label
    Friend WithEvents lblDepartureTime As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
