<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homeForm))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnMyTrip = New System.Windows.Forms.Button()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.btnMainForm = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(177, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 30)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(177, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 30)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Username :"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(316, 274)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(396, 40)
        Me.txtPassword.TabIndex = 24
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(316, 217)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(396, 40)
        Me.txtUsername.TabIndex = 23
        '
        'btnMyTrip
        '
        Me.btnMyTrip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMyTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyTrip.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyTrip.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnMyTrip.Location = New System.Drawing.Point(504, 373)
        Me.btnMyTrip.Name = "btnMyTrip"
        Me.btnMyTrip.Size = New System.Drawing.Size(208, 49)
        Me.btnMyTrip.TabIndex = 28
        Me.btnMyTrip.Text = "My Trip"
        Me.btnMyTrip.UseVisualStyleBackColor = False
        '
        'btnBooking
        '
        Me.btnBooking.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooking.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooking.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnBooking.Location = New System.Drawing.Point(266, 373)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(208, 49)
        Me.btnBooking.TabIndex = 27
        Me.btnBooking.Text = "Booking"
        Me.btnBooking.UseVisualStyleBackColor = False
        '
        'btnMainForm
        '
        Me.btnMainForm.Image = CType(resources.GetObject("btnMainForm.Image"), System.Drawing.Image)
        Me.btnMainForm.Location = New System.Drawing.Point(12, 455)
        Me.btnMainForm.Name = "btnMainForm"
        Me.btnMainForm.Size = New System.Drawing.Size(82, 74)
        Me.btnMainForm.TabIndex = 29
        Me.btnMainForm.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(682, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(253, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(83, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 51)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Home "
        '
        'homeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(947, 541)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnMainForm)
        Me.Controls.Add(Me.btnMyTrip)
        Me.Controls.Add(Me.btnBooking)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "homeForm"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnMyTrip As Button
    Friend WithEvents btnBooking As Button
    Friend WithEvents btnMainForm As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
End Class
