<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDigitalDownloads
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
        Me.lblCostHeading = New System.Windows.Forms.Label()
        Me.lblDigitalDownlads = New System.Windows.Forms.Label()
        Me.lblTotalCostLabel = New System.Windows.Forms.Label()
        Me.lblTotalCostOfDownloads = New System.Windows.Forms.Label()
        Me.btnCalculateCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.textNumberOfDownloads = New System.Windows.Forms.TextBox()
        Me.lblCostPerDownload = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(40, 30)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(240, 27)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Digital Downloads"
        '
        'lblCostHeading
        '
        Me.lblCostHeading.AutoSize = True
        Me.lblCostHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostHeading.Location = New System.Drawing.Point(101, 82)
        Me.lblCostHeading.Name = "lblCostHeading"
        Me.lblCostHeading.Size = New System.Drawing.Size(108, 20)
        Me.lblCostHeading.TabIndex = 2
        Me.lblCostHeading.Text = "Per Download"
        '
        'lblDigitalDownlads
        '
        Me.lblDigitalDownlads.AutoSize = True
        Me.lblDigitalDownlads.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigitalDownlads.Location = New System.Drawing.Point(41, 211)
        Me.lblDigitalDownlads.Name = "lblDigitalDownlads"
        Me.lblDigitalDownlads.Size = New System.Drawing.Size(225, 21)
        Me.lblDigitalDownlads.TabIndex = 3
        Me.lblDigitalDownlads.Text = "Number of Song downloads"
        '
        'lblTotalCostLabel
        '
        Me.lblTotalCostLabel.AutoSize = True
        Me.lblTotalCostLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostLabel.Location = New System.Drawing.Point(41, 254)
        Me.lblTotalCostLabel.Name = "lblTotalCostLabel"
        Me.lblTotalCostLabel.Size = New System.Drawing.Size(199, 21)
        Me.lblTotalCostLabel.TabIndex = 5
        Me.lblTotalCostLabel.Text = "Total Cost of Downloads"
        '
        'lblTotalCostOfDownloads
        '
        Me.lblTotalCostOfDownloads.AutoSize = True
        Me.lblTotalCostOfDownloads.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostOfDownloads.Location = New System.Drawing.Point(268, 255)
        Me.lblTotalCostOfDownloads.Name = "lblTotalCostOfDownloads"
        Me.lblTotalCostOfDownloads.Size = New System.Drawing.Size(0, 20)
        Me.lblTotalCostOfDownloads.TabIndex = 6
        '
        'btnCalculateCost
        '
        Me.btnCalculateCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateCost.Location = New System.Drawing.Point(12, 302)
        Me.btnCalculateCost.Name = "btnCalculateCost"
        Me.btnCalculateCost.Size = New System.Drawing.Size(127, 23)
        Me.btnCalculateCost.TabIndex = 7
        Me.btnCalculateCost.Text = "Calculate"
        Me.btnCalculateCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(183, 302)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(127, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(353, 302)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(127, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DigitalDownloads.My.Resources.Resources.Music
        Me.PictureBox1.Location = New System.Drawing.Point(333, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'textNumberOfDownloads
        '
        Me.textNumberOfDownloads.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textNumberOfDownloads.Location = New System.Drawing.Point(272, 211)
        Me.textNumberOfDownloads.Name = "textNumberOfDownloads"
        Me.textNumberOfDownloads.Size = New System.Drawing.Size(32, 21)
        Me.textNumberOfDownloads.TabIndex = 10
        '
        'lblCostPerDownload
        '
        Me.lblCostPerDownload.AutoSize = True
        Me.lblCostPerDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerDownload.Location = New System.Drawing.Point(50, 82)
        Me.lblCostPerDownload.Name = "lblCostPerDownload"
        Me.lblCostPerDownload.Size = New System.Drawing.Size(0, 20)
        Me.lblCostPerDownload.TabIndex = 11
        '
        'frmDigitalDownloads
        '
        Me.AcceptButton = Me.btnCalculateCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(492, 372)
        Me.Controls.Add(Me.lblCostPerDownload)
        Me.Controls.Add(Me.textNumberOfDownloads)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateCost)
        Me.Controls.Add(Me.lblTotalCostOfDownloads)
        Me.Controls.Add(Me.lblTotalCostLabel)
        Me.Controls.Add(Me.lblDigitalDownlads)
        Me.Controls.Add(Me.lblCostHeading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmDigitalDownloads"
        Me.Text = "Download Music"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCostHeading As System.Windows.Forms.Label
    Friend WithEvents lblDigitalDownlads As System.Windows.Forms.Label
    Friend WithEvents lblTotalCostLabel As System.Windows.Forms.Label
    Friend WithEvents lblTotalCostOfDownloads As System.Windows.Forms.Label
    Friend WithEvents btnCalculateCost As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents textNumberOfDownloads As System.Windows.Forms.TextBox
    Friend WithEvents lblCostPerDownload As System.Windows.Forms.Label

End Class
