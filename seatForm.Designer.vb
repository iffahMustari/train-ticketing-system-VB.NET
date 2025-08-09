<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seatForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(seatForm))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbDirection = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCoachType = New System.Windows.Forms.ComboBox()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.cbPowerSocket = New System.Windows.Forms.CheckBox()
        Me.cbNearToilet = New System.Windows.Forms.CheckBox()
        Me.cbTableSeat = New System.Windows.Forms.CheckBox()
        Me.cbLuggageRack = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.btnSavePreferences = New System.Windows.Forms.Button()
        Me.gbOptions.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(60, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 30)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Direction"
        '
        'cmbDirection
        '
        Me.cmbDirection.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDirection.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbDirection.FormattingEnabled = True
        Me.cmbDirection.Items.AddRange(New Object() {"Facing forward", "Facing backward", "Sideways seating"})
        Me.cmbDirection.Location = New System.Drawing.Point(65, 193)
        Me.cmbDirection.Name = "cmbDirection"
        Me.cmbDirection.Size = New System.Drawing.Size(265, 45)
        Me.cmbDirection.TabIndex = 31
        Me.cmbDirection.Tag = ""
        Me.cmbDirection.Text = "No preference"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(360, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 30)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Position"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(655, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 30)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Coach Type"
        '
        'cmbCoachType
        '
        Me.cmbCoachType.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCoachType.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbCoachType.FormattingEnabled = True
        Me.cmbCoachType.Items.AddRange(New Object() {"Standard", "First Class"})
        Me.cmbCoachType.Location = New System.Drawing.Point(660, 193)
        Me.cmbCoachType.Name = "cmbCoachType"
        Me.cmbCoachType.Size = New System.Drawing.Size(265, 45)
        Me.cmbCoachType.TabIndex = 35
        Me.cmbCoachType.Tag = ""
        Me.cmbCoachType.Text = "No preference"
        '
        'gbOptions
        '
        Me.gbOptions.BackColor = System.Drawing.Color.Transparent
        Me.gbOptions.Controls.Add(Me.cbPowerSocket)
        Me.gbOptions.Controls.Add(Me.cbNearToilet)
        Me.gbOptions.Controls.Add(Me.cbTableSeat)
        Me.gbOptions.Controls.Add(Me.cbLuggageRack)
        Me.gbOptions.Location = New System.Drawing.Point(224, 287)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(554, 152)
        Me.gbOptions.TabIndex = 37
        Me.gbOptions.TabStop = False
        '
        'cbPowerSocket
        '
        Me.cbPowerSocket.AutoSize = True
        Me.cbPowerSocket.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPowerSocket.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbPowerSocket.Location = New System.Drawing.Point(351, 92)
        Me.cbPowerSocket.Name = "cbPowerSocket"
        Me.cbPowerSocket.Size = New System.Drawing.Size(175, 34)
        Me.cbPowerSocket.TabIndex = 3
        Me.cbPowerSocket.Text = "Power Socket"
        Me.cbPowerSocket.UseVisualStyleBackColor = True
        '
        'cbNearToilet
        '
        Me.cbNearToilet.AutoSize = True
        Me.cbNearToilet.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNearToilet.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbNearToilet.Location = New System.Drawing.Point(351, 31)
        Me.cbNearToilet.Name = "cbNearToilet"
        Me.cbNearToilet.Size = New System.Drawing.Size(148, 34)
        Me.cbNearToilet.TabIndex = 2
        Me.cbNearToilet.Text = "Near Toilet"
        Me.cbNearToilet.UseVisualStyleBackColor = True
        '
        'cbTableSeat
        '
        Me.cbTableSeat.AutoSize = True
        Me.cbTableSeat.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTableSeat.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbTableSeat.Location = New System.Drawing.Point(22, 92)
        Me.cbTableSeat.Name = "cbTableSeat"
        Me.cbTableSeat.Size = New System.Drawing.Size(141, 34)
        Me.cbTableSeat.TabIndex = 1
        Me.cbTableSeat.Text = "Table Seat"
        Me.cbTableSeat.UseVisualStyleBackColor = True
        '
        'cbLuggageRack
        '
        Me.cbLuggageRack.AutoSize = True
        Me.cbLuggageRack.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLuggageRack.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbLuggageRack.Location = New System.Drawing.Point(22, 31)
        Me.cbLuggageRack.Name = "cbLuggageRack"
        Me.cbLuggageRack.Size = New System.Drawing.Size(236, 34)
        Me.cbLuggageRack.TabIndex = 0
        Me.cbLuggageRack.Text = "Near Luggage Rack"
        Me.cbLuggageRack.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(760, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(253, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(12, 523)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 74)
        Me.btnBack.TabIndex = 39
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(56, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(377, 51)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Seating Preferences"
        '
        'cmbPosition
        '
        Me.cmbPosition.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPosition.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Items.AddRange(New Object() {"Window seat", "Aisle seat", "Middle seat", "Table seat"})
        Me.cmbPosition.Location = New System.Drawing.Point(365, 193)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(265, 45)
        Me.cmbPosition.TabIndex = 42
        Me.cmbPosition.Tag = ""
        Me.cmbPosition.Text = "No preference"
        '
        'btnSavePreferences
        '
        Me.btnSavePreferences.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSavePreferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePreferences.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePreferences.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSavePreferences.Location = New System.Drawing.Point(413, 466)
        Me.btnSavePreferences.Name = "btnSavePreferences"
        Me.btnSavePreferences.Size = New System.Drawing.Size(208, 49)
        Me.btnSavePreferences.TabIndex = 43
        Me.btnSavePreferences.Text = "Save"
        Me.btnSavePreferences.UseVisualStyleBackColor = False
        '
        'seatForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1025, 609)
        Me.Controls.Add(Me.btnSavePreferences)
        Me.Controls.Add(Me.cmbPosition)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCoachType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbDirection)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "seatForm"
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents cmbDirection As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCoachType As ComboBox
    Friend WithEvents gbOptions As GroupBox
    Friend WithEvents cbPowerSocket As CheckBox
    Friend WithEvents cbNearToilet As CheckBox
    Friend WithEvents cbTableSeat As CheckBox
    Friend WithEvents cbLuggageRack As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbPosition As ComboBox
    Friend WithEvents btnSavePreferences As Button
End Class
