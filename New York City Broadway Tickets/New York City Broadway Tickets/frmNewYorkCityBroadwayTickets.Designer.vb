<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewYorkCityBroadwayTickets
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblPricePerTicket = New System.Windows.Forms.Label()
        Me.lblPerTicket = New System.Windows.Forms.Label()
        Me.lblNumberOfTickets = New System.Windows.Forms.Label()
        Me.txtNumberOfTickets = New System.Windows.Forms.TextBox()
        Me.lblTotalCostOfTickets = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.picBroadway = New System.Windows.Forms.PictureBox()
        Me.btnCalculateCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picBroadway, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblHeading.Location = New System.Drawing.Point(189, 36)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(198, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Broadway Tickets"
        '
        'lblPricePerTicket
        '
        Me.lblPricePerTicket.AutoSize = True
        Me.lblPricePerTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricePerTicket.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPricePerTicket.Location = New System.Drawing.Point(213, 92)
        Me.lblPricePerTicket.Name = "lblPricePerTicket"
        Me.lblPricePerTicket.Size = New System.Drawing.Size(0, 16)
        Me.lblPricePerTicket.TabIndex = 1
        '
        'lblPerTicket
        '
        Me.lblPerTicket.AutoSize = True
        Me.lblPerTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerTicket.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPerTicket.Location = New System.Drawing.Point(265, 89)
        Me.lblPerTicket.Name = "lblPerTicket"
        Me.lblPerTicket.Size = New System.Drawing.Size(89, 20)
        Me.lblPerTicket.TabIndex = 2
        Me.lblPerTicket.Text = "Per Ticket"
        '
        'lblNumberOfTickets
        '
        Me.lblNumberOfTickets.AutoSize = True
        Me.lblNumberOfTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfTickets.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblNumberOfTickets.Location = New System.Drawing.Point(189, 195)
        Me.lblNumberOfTickets.Name = "lblNumberOfTickets"
        Me.lblNumberOfTickets.Size = New System.Drawing.Size(180, 20)
        Me.lblNumberOfTickets.TabIndex = 3
        Me.lblNumberOfTickets.Text = "Enter Number of Tickets"
        '
        'txtNumberOfTickets
        '
        Me.txtNumberOfTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfTickets.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNumberOfTickets.Location = New System.Drawing.Point(375, 193)
        Me.txtNumberOfTickets.Name = "txtNumberOfTickets"
        Me.txtNumberOfTickets.Size = New System.Drawing.Size(32, 22)
        Me.txtNumberOfTickets.TabIndex = 4
        Me.txtNumberOfTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalCostOfTickets
        '
        Me.lblTotalCostOfTickets.AutoSize = True
        Me.lblTotalCostOfTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostOfTickets.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotalCostOfTickets.Location = New System.Drawing.Point(190, 254)
        Me.lblTotalCostOfTickets.Name = "lblTotalCostOfTickets"
        Me.lblTotalCostOfTickets.Size = New System.Drawing.Size(153, 20)
        Me.lblTotalCostOfTickets.TabIndex = 5
        Me.lblTotalCostOfTickets.Text = "Total Cost of Tickets"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotal.Location = New System.Drawing.Point(372, 257)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 16)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'picBroadway
        '
        Me.picBroadway.Image = Global.WindowsApplication1.My.Resources.Resources.Broadway
        Me.picBroadway.Location = New System.Drawing.Point(12, 1)
        Me.picBroadway.Name = "picBroadway"
        Me.picBroadway.Size = New System.Drawing.Size(123, 444)
        Me.picBroadway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBroadway.TabIndex = 7
        Me.picBroadway.TabStop = False
        '
        'btnCalculateCost
        '
        Me.btnCalculateCost.Location = New System.Drawing.Point(143, 380)
        Me.btnCalculateCost.Name = "btnCalculateCost"
        Me.btnCalculateCost.Size = New System.Drawing.Size(86, 23)
        Me.btnCalculateCost.TabIndex = 8
        Me.btnCalculateCost.Text = "Calculate Cost"
        Me.btnCalculateCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(257, 380)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(371, 380)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmNewYorkCityBroadwayTickets
        '
        Me.AcceptButton = Me.btnCalculateCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(501, 457)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateCost)
        Me.Controls.Add(Me.picBroadway)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalCostOfTickets)
        Me.Controls.Add(Me.txtNumberOfTickets)
        Me.Controls.Add(Me.lblNumberOfTickets)
        Me.Controls.Add(Me.lblPerTicket)
        Me.Controls.Add(Me.lblPricePerTicket)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmNewYorkCityBroadwayTickets"
        Me.Text = "Broadway Theatre"
        CType(Me.picBroadway, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblPricePerTicket As System.Windows.Forms.Label
    Friend WithEvents lblPerTicket As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfTickets As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfTickets As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalCostOfTickets As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents picBroadway As System.Windows.Forms.PictureBox
    Friend WithEvents btnCalculateCost As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
