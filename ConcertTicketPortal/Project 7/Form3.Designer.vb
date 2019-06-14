<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.grpBoxSeats = New System.Windows.Forms.GroupBox()
        Me.lblUpper = New System.Windows.Forms.Label()
        Me.lblClub = New System.Windows.Forms.Label()
        Me.lblLower = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.theDataGrid = New System.Windows.Forms.DataGridView()
        Me.personName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boughtLower = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clubBought = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.upperBought = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmConfirmation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSalesForm = New System.Windows.Forms.Button()
        Me.btnPurchForm = New System.Windows.Forms.Button()
        Me.btnGuestLook = New System.Windows.Forms.Button()
        Me.btnConfLook = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.grpBoxSeats.SuspendLayout()
        CType(Me.theDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBoxSeats
        '
        Me.grpBoxSeats.Controls.Add(Me.lblUpper)
        Me.grpBoxSeats.Controls.Add(Me.lblClub)
        Me.grpBoxSeats.Controls.Add(Me.lblLower)
        Me.grpBoxSeats.Controls.Add(Me.Label3)
        Me.grpBoxSeats.Controls.Add(Me.Label2)
        Me.grpBoxSeats.Controls.Add(Me.Label1)
        Me.grpBoxSeats.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxSeats.Location = New System.Drawing.Point(29, 12)
        Me.grpBoxSeats.Name = "grpBoxSeats"
        Me.grpBoxSeats.Size = New System.Drawing.Size(349, 98)
        Me.grpBoxSeats.TabIndex = 0
        Me.grpBoxSeats.TabStop = False
        Me.grpBoxSeats.Text = "Seats Remaining"
        '
        'lblUpper
        '
        Me.lblUpper.AutoSize = True
        Me.lblUpper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpper.Location = New System.Drawing.Point(264, 48)
        Me.lblUpper.Name = "lblUpper"
        Me.lblUpper.Size = New System.Drawing.Size(0, 16)
        Me.lblUpper.TabIndex = 5
        '
        'lblClub
        '
        Me.lblClub.AutoSize = True
        Me.lblClub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClub.Location = New System.Drawing.Point(150, 48)
        Me.lblClub.Name = "lblClub"
        Me.lblClub.Size = New System.Drawing.Size(0, 16)
        Me.lblClub.TabIndex = 4
        '
        'lblLower
        '
        Me.lblLower.AutoSize = True
        Me.lblLower.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLower.Location = New System.Drawing.Point(42, 48)
        Me.lblLower.Name = "lblLower"
        Me.lblLower.Size = New System.Drawing.Size(0, 16)
        Me.lblLower.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(237, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Upper Deck"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(131, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Club Level"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lower Level"
        '
        'theDataGrid
        '
        Me.theDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.theDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.personName, Me.clmAge, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.boughtLower, Me.clubBought, Me.upperBought, Me.clmConfirmation})
        Me.theDataGrid.Location = New System.Drawing.Point(29, 116)
        Me.theDataGrid.Name = "theDataGrid"
        Me.theDataGrid.ReadOnly = True
        Me.theDataGrid.Size = New System.Drawing.Size(739, 142)
        Me.theDataGrid.TabIndex = 1
        '
        'personName
        '
        Me.personName.HeaderText = "Name"
        Me.personName.Name = "personName"
        Me.personName.ReadOnly = True
        '
        'clmAge
        '
        Me.clmAge.HeaderText = "Age"
        Me.clmAge.Name = "clmAge"
        Me.clmAge.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Email"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Card Number"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name on Card"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "CCV"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Cost"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'boughtLower
        '
        Me.boughtLower.HeaderText = "Lower Bought"
        Me.boughtLower.Name = "boughtLower"
        Me.boughtLower.ReadOnly = True
        '
        'clubBought
        '
        Me.clubBought.HeaderText = "Club Bought"
        Me.clubBought.Name = "clubBought"
        Me.clubBought.ReadOnly = True
        '
        'upperBought
        '
        Me.upperBought.HeaderText = "Upper Bought"
        Me.upperBought.Name = "upperBought"
        Me.upperBought.ReadOnly = True
        '
        'clmConfirmation
        '
        Me.clmConfirmation.HeaderText = "Confirmation Number"
        Me.clmConfirmation.Name = "clmConfirmation"
        Me.clmConfirmation.ReadOnly = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(628, 279)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(140, 34)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSalesForm
        '
        Me.btnSalesForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesForm.Location = New System.Drawing.Point(29, 279)
        Me.btnSalesForm.Name = "btnSalesForm"
        Me.btnSalesForm.Size = New System.Drawing.Size(140, 34)
        Me.btnSalesForm.TabIndex = 3
        Me.btnSalesForm.Text = "Sales Form"
        Me.btnSalesForm.UseVisualStyleBackColor = True
        '
        'btnPurchForm
        '
        Me.btnPurchForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchForm.Location = New System.Drawing.Point(192, 279)
        Me.btnPurchForm.Name = "btnPurchForm"
        Me.btnPurchForm.Size = New System.Drawing.Size(140, 34)
        Me.btnPurchForm.TabIndex = 4
        Me.btnPurchForm.Text = "Purchase Form"
        Me.btnPurchForm.UseVisualStyleBackColor = True
        '
        'btnGuestLook
        '
        Me.btnGuestLook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuestLook.Location = New System.Drawing.Point(384, 22)
        Me.btnGuestLook.Name = "btnGuestLook"
        Me.btnGuestLook.Size = New System.Drawing.Size(119, 41)
        Me.btnGuestLook.TabIndex = 5
        Me.btnGuestLook.Text = "Guest Lookup"
        Me.btnGuestLook.UseVisualStyleBackColor = True
        '
        'btnConfLook
        '
        Me.btnConfLook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfLook.Location = New System.Drawing.Point(384, 69)
        Me.btnConfLook.Name = "btnConfLook"
        Me.btnConfLook.Size = New System.Drawing.Size(119, 41)
        Me.btnConfLook.TabIndex = 6
        Me.btnConfLook.Text = "Confirmation Lookup"
        Me.btnConfLook.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Green
        Me.lblTotal.Location = New System.Drawing.Point(529, 43)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(92, 20)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total Sales:"
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.ForeColor = System.Drawing.Color.Green
        Me.lblSales.Location = New System.Drawing.Point(633, 43)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(0, 20)
        Me.lblSales.TabIndex = 8
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 325)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnConfLook)
        Me.Controls.Add(Me.btnGuestLook)
        Me.Controls.Add(Me.btnPurchForm)
        Me.Controls.Add(Me.btnSalesForm)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.theDataGrid)
        Me.Controls.Add(Me.grpBoxSeats)
        Me.Name = "frmAdmin"
        Me.Text = "Admin View"
        Me.grpBoxSeats.ResumeLayout(False)
        Me.grpBoxSeats.PerformLayout()
        CType(Me.theDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBoxSeats As GroupBox
    Friend WithEvents theDataGrid As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSalesForm As Button
    Friend WithEvents btnPurchForm As Button
    Friend WithEvents btnGuestLook As Button
    Friend WithEvents btnConfLook As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUpper As Label
    Friend WithEvents lblClub As Label
    Friend WithEvents lblLower As Label
    Friend WithEvents personName As DataGridViewTextBoxColumn
    Friend WithEvents clmAge As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents boughtLower As DataGridViewTextBoxColumn
    Friend WithEvents clubBought As DataGridViewTextBoxColumn
    Friend WithEvents upperBought As DataGridViewTextBoxColumn
    Friend WithEvents clmConfirmation As DataGridViewTextBoxColumn
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSales As Label
End Class
