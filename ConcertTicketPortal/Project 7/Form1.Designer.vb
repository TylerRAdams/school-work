<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Me.lblBand = New System.Windows.Forms.Label()
        Me.grpBoxTickets = New System.Windows.Forms.GroupBox()
        Me.comboUpper = New System.Windows.Forms.ComboBox()
        Me.comboClub = New System.Windows.Forms.ComboBox()
        Me.comboLower = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblClub = New System.Windows.Forms.Label()
        Me.lblUpper = New System.Windows.Forms.Label()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.lblLower = New System.Windows.Forms.Label()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpBoxTickets.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBand
        '
        Me.lblBand.AutoSize = True
        Me.lblBand.BackColor = System.Drawing.Color.Aqua
        Me.lblBand.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBand.ForeColor = System.Drawing.Color.Red
        Me.lblBand.Location = New System.Drawing.Point(88, 24)
        Me.lblBand.Name = "lblBand"
        Me.lblBand.Size = New System.Drawing.Size(271, 29)
        Me.lblBand.TabIndex = 0
        Me.lblBand.Text = "Down With Pseudocode"
        '
        'grpBoxTickets
        '
        Me.grpBoxTickets.Controls.Add(Me.comboUpper)
        Me.grpBoxTickets.Controls.Add(Me.comboClub)
        Me.grpBoxTickets.Controls.Add(Me.comboLower)
        Me.grpBoxTickets.Controls.Add(Me.Label4)
        Me.grpBoxTickets.Controls.Add(Me.lblClub)
        Me.grpBoxTickets.Controls.Add(Me.lblUpper)
        Me.grpBoxTickets.Controls.Add(Me.btnBuy)
        Me.grpBoxTickets.Controls.Add(Me.lblLower)
        Me.grpBoxTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxTickets.Location = New System.Drawing.Point(12, 75)
        Me.grpBoxTickets.Name = "grpBoxTickets"
        Me.grpBoxTickets.Size = New System.Drawing.Size(432, 245)
        Me.grpBoxTickets.TabIndex = 1
        Me.grpBoxTickets.TabStop = False
        Me.grpBoxTickets.Text = "Tickets"
        '
        'comboUpper
        '
        Me.comboUpper.FormattingEnabled = True
        Me.comboUpper.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "Other"})
        Me.comboUpper.Location = New System.Drawing.Point(242, 144)
        Me.comboUpper.Name = "comboUpper"
        Me.comboUpper.Size = New System.Drawing.Size(121, 28)
        Me.comboUpper.TabIndex = 8
        '
        'comboClub
        '
        Me.comboClub.FormattingEnabled = True
        Me.comboClub.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "Other"})
        Me.comboClub.Location = New System.Drawing.Point(242, 103)
        Me.comboClub.Name = "comboClub"
        Me.comboClub.Size = New System.Drawing.Size(121, 28)
        Me.comboClub.TabIndex = 7
        '
        'comboLower
        '
        Me.comboLower.FormattingEnabled = True
        Me.comboLower.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "Other"})
        Me.comboLower.Location = New System.Drawing.Point(242, 61)
        Me.comboLower.Name = "comboLower"
        Me.comboLower.Size = New System.Drawing.Size(121, 28)
        Me.comboLower.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Quantity"
        '
        'lblClub
        '
        Me.lblClub.AutoSize = True
        Me.lblClub.Location = New System.Drawing.Point(6, 106)
        Me.lblClub.Name = "lblClub"
        Me.lblClub.Size = New System.Drawing.Size(151, 20)
        Me.lblClub.TabIndex = 4
        Me.lblClub.Text = "Club Level     $75.00"
        '
        'lblUpper
        '
        Me.lblUpper.AutoSize = True
        Me.lblUpper.Location = New System.Drawing.Point(6, 147)
        Me.lblUpper.Name = "lblUpper"
        Me.lblUpper.Size = New System.Drawing.Size(151, 20)
        Me.lblUpper.TabIndex = 3
        Me.lblUpper.Text = "Upper Deck  $50.00"
        '
        'btnBuy
        '
        Me.btnBuy.BackColor = System.Drawing.Color.Black
        Me.btnBuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuy.ForeColor = System.Drawing.Color.White
        Me.btnBuy.Location = New System.Drawing.Point(160, 198)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(116, 41)
        Me.btnBuy.TabIndex = 2
        Me.btnBuy.Text = "Buy"
        Me.btnBuy.UseVisualStyleBackColor = False
        '
        'lblLower
        '
        Me.lblLower.AutoSize = True
        Me.lblLower.Location = New System.Drawing.Point(6, 64)
        Me.lblLower.Name = "lblLower"
        Me.lblLower.Size = New System.Drawing.Size(159, 20)
        Me.lblLower.TabIndex = 0
        Me.lblLower.Text = "Lower Level  $125.00"
        '
        'btnAdmin
        '
        Me.btnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.Location = New System.Drawing.Point(79, 341)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(98, 37)
        Me.btnAdmin.TabIndex = 2
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(277, 341)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 37)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 387)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.grpBoxTickets)
        Me.Controls.Add(Me.lblBand)
        Me.Name = "frmSales"
        Me.Text = "Sales"
        Me.grpBoxTickets.ResumeLayout(False)
        Me.grpBoxTickets.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBand As Label
    Friend WithEvents grpBoxTickets As GroupBox
    Friend WithEvents lblClub As Label
    Friend WithEvents lblUpper As Label
    Friend WithEvents btnBuy As Button
    Friend WithEvents lblLower As Label
    Friend WithEvents comboLower As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents comboUpper As ComboBox
    Friend WithEvents comboClub As ComboBox
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnClose As Button
End Class
