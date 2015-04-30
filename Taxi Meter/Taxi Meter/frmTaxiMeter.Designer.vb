<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaxiMeter
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblOnly = New System.Windows.Forms.Label()
        Me.lblPerMile = New System.Windows.Forms.Label()
        Me.lblPlus = New System.Windows.Forms.Label()
        Me.lblMilesTraveled = New System.Windows.Forms.Label()
        Me.lblTotalFare = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.lblPricePerMile = New System.Windows.Forms.Label()
        Me.lblConstantPrice = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Taxi
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblHeading.Location = New System.Drawing.Point(239, 26)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(124, 29)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Taxi Fare"
        '
        'lblOnly
        '
        Me.lblOnly.AutoSize = True
        Me.lblOnly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnly.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblOnly.Location = New System.Drawing.Point(258, 96)
        Me.lblOnly.Name = "lblOnly"
        Me.lblOnly.Size = New System.Drawing.Size(40, 20)
        Me.lblOnly.TabIndex = 2
        Me.lblOnly.Text = "Only"
        '
        'lblPerMile
        '
        Me.lblPerMile.AutoSize = True
        Me.lblPerMile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerMile.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPerMile.Location = New System.Drawing.Point(321, 141)
        Me.lblPerMile.Name = "lblPerMile"
        Me.lblPerMile.Size = New System.Drawing.Size(65, 20)
        Me.lblPerMile.TabIndex = 3
        Me.lblPerMile.Text = "Per Mile"
        '
        'lblPlus
        '
        Me.lblPlus.AutoSize = True
        Me.lblPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlus.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPlus.Location = New System.Drawing.Point(230, 141)
        Me.lblPlus.Name = "lblPlus"
        Me.lblPlus.Size = New System.Drawing.Size(39, 20)
        Me.lblPlus.TabIndex = 4
        Me.lblPlus.Text = "Plus"
        '
        'lblMilesTraveled
        '
        Me.lblMilesTraveled.AutoSize = True
        Me.lblMilesTraveled.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilesTraveled.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblMilesTraveled.Location = New System.Drawing.Point(68, 204)
        Me.lblMilesTraveled.Name = "lblMilesTraveled"
        Me.lblMilesTraveled.Size = New System.Drawing.Size(109, 20)
        Me.lblMilesTraveled.TabIndex = 5
        Me.lblMilesTraveled.Text = "Miles Traveled"
        '
        'lblTotalFare
        '
        Me.lblTotalFare.AutoSize = True
        Me.lblTotalFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFare.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotalFare.Location = New System.Drawing.Point(68, 255)
        Me.lblTotalFare.Name = "lblTotalFare"
        Me.lblTotalFare.Size = New System.Drawing.Size(77, 20)
        Me.lblTotalFare.TabIndex = 6
        Me.lblTotalFare.Text = "TotalFare"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotal.Location = New System.Drawing.Point(213, 255)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 20)
        Me.lblTotal.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(38, 332)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate Total"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(176, 332)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(311, 332)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtMiles
        '
        Me.txtMiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiles.Location = New System.Drawing.Point(217, 201)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(34, 26)
        Me.txtMiles.TabIndex = 11
        Me.txtMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPricePerMile
        '
        Me.lblPricePerMile.AutoSize = True
        Me.lblPricePerMile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricePerMile.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPricePerMile.Location = New System.Drawing.Point(270, 141)
        Me.lblPricePerMile.Name = "lblPricePerMile"
        Me.lblPricePerMile.Size = New System.Drawing.Size(0, 20)
        Me.lblPricePerMile.TabIndex = 12
        '
        'lblConstantPrice
        '
        Me.lblConstantPrice.AutoSize = True
        Me.lblConstantPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConstantPrice.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblConstantPrice.Location = New System.Drawing.Point(297, 96)
        Me.lblConstantPrice.Name = "lblConstantPrice"
        Me.lblConstantPrice.Size = New System.Drawing.Size(0, 20)
        Me.lblConstantPrice.TabIndex = 13
        '
        'frmTaxiMeter
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(467, 389)
        Me.Controls.Add(Me.lblConstantPrice)
        Me.Controls.Add(Me.lblPricePerMile)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalFare)
        Me.Controls.Add(Me.lblMilesTraveled)
        Me.Controls.Add(Me.lblPlus)
        Me.Controls.Add(Me.lblPerMile)
        Me.Controls.Add(Me.lblOnly)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmTaxiMeter"
        Me.Text = "Taxi Fare"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblOnly As System.Windows.Forms.Label
    Friend WithEvents lblPerMile As System.Windows.Forms.Label
    Friend WithEvents lblPlus As System.Windows.Forms.Label
    Friend WithEvents lblMilesTraveled As System.Windows.Forms.Label
    Friend WithEvents lblTotalFare As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtMiles As System.Windows.Forms.TextBox
    Friend WithEvents lblPricePerMile As System.Windows.Forms.Label
    Friend WithEvents lblConstantPrice As System.Windows.Forms.Label

End Class
