<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeeklyPayCalculator
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
        Me.lblHeadding = New System.Windows.Forms.Label()
        Me.lblHeadding2 = New System.Windows.Forms.Label()
        Me.lblTotalMinutes = New System.Windows.Forms.Label()
        Me.lblHourlyPay = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblHoursLabel = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblMinutesLabel = New System.Windows.Forms.Label()
        Me.lblWeeklyPay = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtTotalMinutes = New System.Windows.Forms.TextBox()
        Me.txtHourlyPay = New System.Windows.Forms.TextBox()
        Me.btnCalulate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeadding
        '
        Me.lblHeadding.AutoSize = True
        Me.lblHeadding.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadding.Location = New System.Drawing.Point(252, 29)
        Me.lblHeadding.Name = "lblHeadding"
        Me.lblHeadding.Size = New System.Drawing.Size(226, 25)
        Me.lblHeadding.TabIndex = 0
        Me.lblHeadding.Text = "Western Distribution"
        '
        'lblHeadding2
        '
        Me.lblHeadding2.AutoSize = True
        Me.lblHeadding2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadding2.Location = New System.Drawing.Point(309, 111)
        Me.lblHeadding2.Name = "lblHeadding2"
        Me.lblHeadding2.Size = New System.Drawing.Size(116, 40)
        Me.lblHeadding2.TabIndex = 1
        Me.lblHeadding2.Text = "Weekly Paroll" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculation"
        Me.lblHeadding2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTotalMinutes
        '
        Me.lblTotalMinutes.AutoSize = True
        Me.lblTotalMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMinutes.Location = New System.Drawing.Point(136, 228)
        Me.lblTotalMinutes.Name = "lblTotalMinutes"
        Me.lblTotalMinutes.Size = New System.Drawing.Size(206, 20)
        Me.lblTotalMinutes.TabIndex = 2
        Me.lblTotalMinutes.Text = "Enter Total Minutes Worked"
        '
        'lblHourlyPay
        '
        Me.lblHourlyPay.AutoSize = True
        Me.lblHourlyPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourlyPay.Location = New System.Drawing.Point(136, 283)
        Me.lblHourlyPay.Name = "lblHourlyPay"
        Me.lblHourlyPay.Size = New System.Drawing.Size(127, 20)
        Me.lblHourlyPay.TabIndex = 3
        Me.lblHourlyPay.Text = "Enter Hourly Pay"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(87, 383)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(111, 20)
        Me.lblHours.TabIndex = 4
        Me.lblHours.Text = "Hours Worked"
        '
        'lblHoursLabel
        '
        Me.lblHoursLabel.AutoSize = True
        Me.lblHoursLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursLabel.Location = New System.Drawing.Point(204, 383)
        Me.lblHoursLabel.Name = "lblHoursLabel"
        Me.lblHoursLabel.Size = New System.Drawing.Size(0, 20)
        Me.lblHoursLabel.TabIndex = 5
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.Location = New System.Drawing.Point(295, 383)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(127, 20)
        Me.lblMinutes.TabIndex = 6
        Me.lblMinutes.Text = "Leftover Minutes"
        '
        'lblMinutesLabel
        '
        Me.lblMinutesLabel.AutoSize = True
        Me.lblMinutesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutesLabel.Location = New System.Drawing.Point(428, 383)
        Me.lblMinutesLabel.Name = "lblMinutesLabel"
        Me.lblMinutesLabel.Size = New System.Drawing.Size(0, 20)
        Me.lblMinutesLabel.TabIndex = 7
        '
        'lblWeeklyPay
        '
        Me.lblWeeklyPay.AutoSize = True
        Me.lblWeeklyPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeeklyPay.Location = New System.Drawing.Point(190, 433)
        Me.lblWeeklyPay.Name = "lblWeeklyPay"
        Me.lblWeeklyPay.Size = New System.Drawing.Size(90, 20)
        Me.lblWeeklyPay.TabIndex = 8
        Me.lblWeeklyPay.Text = "Weekly Pay"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(286, 433)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 20)
        Me.lblTotal.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Payroll
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 193)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'txtTotalMinutes
        '
        Me.txtTotalMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMinutes.Location = New System.Drawing.Point(362, 225)
        Me.txtTotalMinutes.Name = "txtTotalMinutes"
        Me.txtTotalMinutes.Size = New System.Drawing.Size(44, 26)
        Me.txtTotalMinutes.TabIndex = 11
        Me.txtTotalMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHourlyPay
        '
        Me.txtHourlyPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHourlyPay.Location = New System.Drawing.Point(362, 283)
        Me.txtHourlyPay.Name = "txtHourlyPay"
        Me.txtHourlyPay.Size = New System.Drawing.Size(45, 26)
        Me.txtHourlyPay.TabIndex = 12
        Me.txtHourlyPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalulate
        '
        Me.btnCalulate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalulate.Location = New System.Drawing.Point(44, 336)
        Me.btnCalulate.Name = "btnCalulate"
        Me.btnCalulate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalulate.TabIndex = 13
        Me.btnCalulate.Text = "Calculate"
        Me.btnCalulate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(234, 335)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(424, 335)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'WeeklyPayCalculator
        '
        Me.AcceptButton = Me.btnCalulate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(542, 476)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalulate)
        Me.Controls.Add(Me.txtHourlyPay)
        Me.Controls.Add(Me.txtTotalMinutes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblWeeklyPay)
        Me.Controls.Add(Me.lblMinutesLabel)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.lblHoursLabel)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblHourlyPay)
        Me.Controls.Add(Me.lblTotalMinutes)
        Me.Controls.Add(Me.lblHeadding2)
        Me.Controls.Add(Me.lblHeadding)
        Me.Name = "WeeklyPayCalculator"
        Me.Text = "Western Distribution Weekly Payroll"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeadding As System.Windows.Forms.Label
    Friend WithEvents lblHeadding2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalMinutes As System.Windows.Forms.Label
    Friend WithEvents lblHourlyPay As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents lblHoursLabel As System.Windows.Forms.Label
    Friend WithEvents lblMinutes As System.Windows.Forms.Label
    Friend WithEvents lblMinutesLabel As System.Windows.Forms.Label
    Friend WithEvents lblWeeklyPay As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtTotalMinutes As System.Windows.Forms.TextBox
    Friend WithEvents txtHourlyPay As System.Windows.Forms.TextBox
    Friend WithEvents btnCalulate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
