<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bookingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bookingForm))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmbDeparting = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbGoingto = New System.Windows.Forms.ComboBox()
        Me.gbAvoid = New System.Windows.Forms.GroupBox()
        Me.radReturn = New System.Windows.Forms.RadioButton()
        Me.radSingle = New System.Windows.Forms.RadioButton()
        Me.gbPassengers = New System.Windows.Forms.GroupBox()
        Me.radStudent = New System.Windows.Forms.RadioButton()
        Me.radNormal = New System.Windows.Forms.RadioButton()
        Me.gbLeaving = New System.Windows.Forms.GroupBox()
        Me.btnCalendarLeaving = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbJourney = New System.Windows.Forms.ComboBox()
        Me.txtDateLeaving = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbReturn = New System.Windows.Forms.GroupBox()
        Me.cmbJourneyReturn = New System.Windows.Forms.ComboBox()
        Me.btnCalendarReturn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDateReturn = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnGetTime = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAvoid.SuspendLayout()
        Me.gbPassengers.SuspendLayout()
        Me.gbLeaving.SuspendLayout()
        Me.gbReturn.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(887, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(253, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'cmbDeparting
        '
        Me.cmbDeparting.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDeparting.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbDeparting.FormattingEnabled = True
        Me.cmbDeparting.Items.AddRange(New Object() {"KL Sentral", "Masjid Jamek", "Pasar Seni", "Bukit Bintang", "Hang Tuah", "Titiwangsa", "Bandaraya", "Merdeka", "Chow Kit", "Salak Selatan"})
        Me.cmbDeparting.Location = New System.Drawing.Point(137, 135)
        Me.cmbDeparting.Name = "cmbDeparting"
        Me.cmbDeparting.Size = New System.Drawing.Size(345, 45)
        Me.cmbDeparting.TabIndex = 8
        Me.cmbDeparting.Tag = ""
        Me.cmbDeparting.Text = "Station Name Or Code"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(471, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'cmbGoingto
        '
        Me.cmbGoingto.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGoingto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbGoingto.FormattingEnabled = True
        Me.cmbGoingto.Items.AddRange(New Object() {"KL Sentral", "Masjid Jamek", "Pasar Seni", "Bukit Bintang", "Hang Tuah", "Titiwangsa", "Bandaraya", "Merdeka", "Chow Kit", "Salak Selatan"})
        Me.cmbGoingto.Location = New System.Drawing.Point(630, 135)
        Me.cmbGoingto.Name = "cmbGoingto"
        Me.cmbGoingto.Size = New System.Drawing.Size(345, 45)
        Me.cmbGoingto.TabIndex = 10
        Me.cmbGoingto.Tag = ""
        Me.cmbGoingto.Text = "Station Name Or Code"
        '
        'gbAvoid
        '
        Me.gbAvoid.BackColor = System.Drawing.Color.Transparent
        Me.gbAvoid.Controls.Add(Me.radReturn)
        Me.gbAvoid.Controls.Add(Me.radSingle)
        Me.gbAvoid.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbAvoid.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gbAvoid.Location = New System.Drawing.Point(137, 212)
        Me.gbAvoid.Name = "gbAvoid"
        Me.gbAvoid.Size = New System.Drawing.Size(324, 123)
        Me.gbAvoid.TabIndex = 11
        Me.gbAvoid.TabStop = False
        Me.gbAvoid.Text = "Route vie / avoid"
        '
        'radReturn
        '
        Me.radReturn.AutoSize = True
        Me.radReturn.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radReturn.Location = New System.Drawing.Point(177, 65)
        Me.radReturn.Name = "radReturn"
        Me.radReturn.Size = New System.Drawing.Size(113, 36)
        Me.radReturn.TabIndex = 13
        Me.radReturn.TabStop = True
        Me.radReturn.Text = "Return"
        Me.radReturn.UseVisualStyleBackColor = True
        '
        'radSingle
        '
        Me.radSingle.AutoSize = True
        Me.radSingle.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSingle.Location = New System.Drawing.Point(17, 65)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(106, 36)
        Me.radSingle.TabIndex = 12
        Me.radSingle.TabStop = True
        Me.radSingle.Text = "Single"
        Me.radSingle.UseVisualStyleBackColor = True
        '
        'gbPassengers
        '
        Me.gbPassengers.BackColor = System.Drawing.Color.Transparent
        Me.gbPassengers.Controls.Add(Me.radStudent)
        Me.gbPassengers.Controls.Add(Me.radNormal)
        Me.gbPassengers.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbPassengers.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gbPassengers.Location = New System.Drawing.Point(630, 212)
        Me.gbPassengers.Name = "gbPassengers"
        Me.gbPassengers.Size = New System.Drawing.Size(324, 123)
        Me.gbPassengers.TabIndex = 14
        Me.gbPassengers.TabStop = False
        Me.gbPassengers.Text = "Passengers"
        '
        'radStudent
        '
        Me.radStudent.AutoSize = True
        Me.radStudent.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStudent.Location = New System.Drawing.Point(177, 65)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(124, 36)
        Me.radStudent.TabIndex = 13
        Me.radStudent.TabStop = True
        Me.radStudent.Text = "Student"
        Me.radStudent.UseVisualStyleBackColor = True
        '
        'radNormal
        '
        Me.radNormal.AutoSize = True
        Me.radNormal.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNormal.Location = New System.Drawing.Point(17, 65)
        Me.radNormal.Name = "radNormal"
        Me.radNormal.Size = New System.Drawing.Size(122, 36)
        Me.radNormal.TabIndex = 12
        Me.radNormal.TabStop = True
        Me.radNormal.Text = "Normal"
        Me.radNormal.UseVisualStyleBackColor = True
        '
        'gbLeaving
        '
        Me.gbLeaving.BackColor = System.Drawing.Color.Transparent
        Me.gbLeaving.Controls.Add(Me.btnCalendarLeaving)
        Me.gbLeaving.Controls.Add(Me.Label1)
        Me.gbLeaving.Controls.Add(Me.cmbJourney)
        Me.gbLeaving.Controls.Add(Me.txtDateLeaving)
        Me.gbLeaving.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbLeaving.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gbLeaving.Location = New System.Drawing.Point(102, 356)
        Me.gbLeaving.Name = "gbLeaving"
        Me.gbLeaving.Size = New System.Drawing.Size(460, 220)
        Me.gbLeaving.TabIndex = 14
        Me.gbLeaving.TabStop = False
        Me.gbLeaving.Text = "I am Leaving "
        '
        'btnCalendarLeaving
        '
        Me.btnCalendarLeaving.Image = CType(resources.GetObject("btnCalendarLeaving.Image"), System.Drawing.Image)
        Me.btnCalendarLeaving.Location = New System.Drawing.Point(395, 75)
        Me.btnCalendarLeaving.Name = "btnCalendarLeaving"
        Me.btnCalendarLeaving.Size = New System.Drawing.Size(48, 50)
        Me.btnCalendarLeaving.TabIndex = 16
        Me.btnCalendarLeaving.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 30)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Date "
        '
        'cmbJourney
        '
        Me.cmbJourney.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJourney.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbJourney.FormattingEnabled = True
        Me.cmbJourney.Items.AddRange(New Object() {"Fastest trains only", "Allow less time to transfer through Kuala Lumpur", "Search only sleeper trains", "Show only direct trains"})
        Me.cmbJourney.Location = New System.Drawing.Point(17, 158)
        Me.cmbJourney.Name = "cmbJourney"
        Me.cmbJourney.Size = New System.Drawing.Size(426, 45)
        Me.cmbJourney.TabIndex = 15
        Me.cmbJourney.Tag = ""
        Me.cmbJourney.Text = "Journey options"
        '
        'txtDateLeaving
        '
        Me.txtDateLeaving.Location = New System.Drawing.Point(17, 75)
        Me.txtDateLeaving.Multiline = True
        Me.txtDateLeaving.Name = "txtDateLeaving"
        Me.txtDateLeaving.Size = New System.Drawing.Size(426, 50)
        Me.txtDateLeaving.TabIndex = 15
        '
        'btnBack
        '
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(12, 591)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(82, 74)
        Me.btnBack.TabIndex = 25
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'gbReturn
        '
        Me.gbReturn.BackColor = System.Drawing.Color.Transparent
        Me.gbReturn.Controls.Add(Me.cmbJourneyReturn)
        Me.gbReturn.Controls.Add(Me.btnCalendarReturn)
        Me.gbReturn.Controls.Add(Me.Label2)
        Me.gbReturn.Controls.Add(Me.txtDateReturn)
        Me.gbReturn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbReturn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gbReturn.Location = New System.Drawing.Point(595, 356)
        Me.gbReturn.Name = "gbReturn"
        Me.gbReturn.Size = New System.Drawing.Size(460, 220)
        Me.gbReturn.TabIndex = 27
        Me.gbReturn.TabStop = False
        Me.gbReturn.Text = "I am Return"
        '
        'cmbJourneyReturn
        '
        Me.cmbJourneyReturn.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJourneyReturn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbJourneyReturn.FormattingEnabled = True
        Me.cmbJourneyReturn.Items.AddRange(New Object() {"Fastest trains only", "Allow less time to transfer through Kuala Lumpur", "Search only sleeper trains", "Show only direct trains"})
        Me.cmbJourneyReturn.Location = New System.Drawing.Point(17, 158)
        Me.cmbJourneyReturn.Name = "cmbJourneyReturn"
        Me.cmbJourneyReturn.Size = New System.Drawing.Size(426, 45)
        Me.cmbJourneyReturn.TabIndex = 27
        Me.cmbJourneyReturn.Tag = ""
        Me.cmbJourneyReturn.Text = "Journey options"
        '
        'btnCalendarReturn
        '
        Me.btnCalendarReturn.Image = CType(resources.GetObject("btnCalendarReturn.Image"), System.Drawing.Image)
        Me.btnCalendarReturn.Location = New System.Drawing.Point(395, 75)
        Me.btnCalendarReturn.Name = "btnCalendarReturn"
        Me.btnCalendarReturn.Size = New System.Drawing.Size(48, 50)
        Me.btnCalendarReturn.TabIndex = 16
        Me.btnCalendarReturn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 30)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Date "
        '
        'txtDateReturn
        '
        Me.txtDateReturn.Location = New System.Drawing.Point(17, 75)
        Me.txtDateReturn.Multiline = True
        Me.txtDateReturn.Name = "txtDateReturn"
        Me.txtDateReturn.Size = New System.Drawing.Size(426, 50)
        Me.txtDateReturn.TabIndex = 15
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnRegister.Location = New System.Drawing.Point(612, 616)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(208, 49)
        Me.btnRegister.TabIndex = 28
        Me.btnRegister.Text = "Register "
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnGetTime
        '
        Me.btnGetTime.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnGetTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetTime.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetTime.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnGetTime.Location = New System.Drawing.Point(832, 616)
        Me.btnGetTime.Name = "btnGetTime"
        Me.btnGetTime.Size = New System.Drawing.Size(308, 49)
        Me.btnGetTime.TabIndex = 29
        Me.btnGetTime.Text = "Get Times and Prices"
        Me.btnGetTime.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(132, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 30)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Departing From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(625, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 30)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Going to"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(466, 236)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 32
        Me.MonthCalendar1.Visible = False
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(878, 236)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 33
        Me.MonthCalendar2.Visible = False
        '
        'bookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1152, 677)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnGetTime)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.gbReturn)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.gbLeaving)
        Me.Controls.Add(Me.gbPassengers)
        Me.Controls.Add(Me.gbAvoid)
        Me.Controls.Add(Me.cmbGoingto)
        Me.Controls.Add(Me.cmbDeparting)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "bookingForm"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAvoid.ResumeLayout(False)
        Me.gbAvoid.PerformLayout()
        Me.gbPassengers.ResumeLayout(False)
        Me.gbPassengers.PerformLayout()
        Me.gbLeaving.ResumeLayout(False)
        Me.gbLeaving.PerformLayout()
        Me.gbReturn.ResumeLayout(False)
        Me.gbReturn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmbDeparting As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbGoingto As ComboBox
    Friend WithEvents gbAvoid As GroupBox
    Friend WithEvents radReturn As RadioButton
    Friend WithEvents radSingle As RadioButton
    Friend WithEvents gbPassengers As GroupBox
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents gbLeaving As GroupBox
    Friend WithEvents cmbJourney As ComboBox
    Friend WithEvents txtDateLeaving As TextBox
    Friend WithEvents btnCalendarLeaving As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents radNormal As RadioButton
    Friend WithEvents gbReturn As GroupBox
    Friend WithEvents cmbJourneyReturn As ComboBox
    Friend WithEvents btnCalendarReturn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDateReturn As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnGetTime As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents MonthCalendar2 As MonthCalendar
End Class
