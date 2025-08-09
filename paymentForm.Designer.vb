<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paymentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(paymentForm))
        Me.btnPay = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblUserEmail = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalWithTax = New System.Windows.Forms.Label()
        Me.lblTaxAndFee = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblPassengerType = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnPay.Location = New System.Drawing.Point(221, 546)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(596, 37)
        Me.btnPay.TabIndex = 31
        Me.btnPay.Text = "Pay With Card"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(760, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(253, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.lblUserEmail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblTotalWithTax)
        Me.GroupBox1.Controls.Add(Me.lblTaxAndFee)
        Me.GroupBox1.Controls.Add(Me.lblTotalAmount)
        Me.GroupBox1.Controls.Add(Me.lblPassengerType)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(50, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(908, 428)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'lblUserEmail
        '
        Me.lblUserEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblUserEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserEmail.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblUserEmail.Location = New System.Drawing.Point(150, 367)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(457, 27)
        Me.lblUserEmail.TabIndex = 41
        Me.lblUserEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Image = Global.trainSystem.My.Resources.Resources.Screenshot_2025_01_29_035355
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(19, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(599, 48)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "After payment, your confirmation wull be sent to :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(19, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(477, 38)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Here's what it costs"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(19, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(477, 27)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Total to Pay"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(20, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(477, 27)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Total With Tax and Fee"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(19, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(477, 27)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Total Without Tax"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(19, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 27)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Type of Passenger "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalWithTax
        '
        Me.lblTotalWithTax.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalWithTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalWithTax.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTotalWithTax.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWithTax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalWithTax.Location = New System.Drawing.Point(528, 248)
        Me.lblTotalWithTax.Name = "lblTotalWithTax"
        Me.lblTotalWithTax.Size = New System.Drawing.Size(350, 27)
        Me.lblTotalWithTax.TabIndex = 40
        Me.lblTotalWithTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTaxAndFee
        '
        Me.lblTaxAndFee.BackColor = System.Drawing.SystemColors.Control
        Me.lblTaxAndFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxAndFee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTaxAndFee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxAndFee.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTaxAndFee.Location = New System.Drawing.Point(528, 194)
        Me.lblTaxAndFee.Name = "lblTaxAndFee"
        Me.lblTaxAndFee.Size = New System.Drawing.Size(350, 27)
        Me.lblTaxAndFee.TabIndex = 39
        Me.lblTaxAndFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAmount.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTotalAmount.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTotalAmount.Location = New System.Drawing.Point(528, 144)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(350, 27)
        Me.lblTotalAmount.TabIndex = 38
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPassengerType
        '
        Me.lblPassengerType.BackColor = System.Drawing.SystemColors.Control
        Me.lblPassengerType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPassengerType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblPassengerType.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassengerType.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblPassengerType.Location = New System.Drawing.Point(528, 97)
        Me.lblPassengerType.Name = "lblPassengerType"
        Me.lblPassengerType.Size = New System.Drawing.Size(350, 27)
        Me.lblPassengerType.TabIndex = 37
        Me.lblPassengerType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'paymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1025, 609)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnPay)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "paymentForm"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPay As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPassengerType As Label
    Friend WithEvents lblTaxAndFee As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblTotalWithTax As Label
    Friend WithEvents lblUserEmail As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
