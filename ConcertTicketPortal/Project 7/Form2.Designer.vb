<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchase
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
        Me.grpBoxCont = New System.Windows.Forms.GroupBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.grpBoxPurch = New System.Windows.Forms.GroupBox()
        Me.txtCSV = New System.Windows.Forms.TextBox()
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.txtCCN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.grpBoxCont.SuspendLayout()
        Me.grpBoxPurch.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBoxCont
        '
        Me.grpBoxCont.Controls.Add(Me.lblTotalCost)
        Me.grpBoxCont.Controls.Add(Me.txtEmail)
        Me.grpBoxCont.Controls.Add(Me.txtAge)
        Me.grpBoxCont.Controls.Add(Me.txtName)
        Me.grpBoxCont.Controls.Add(Me.Label2)
        Me.grpBoxCont.Controls.Add(Me.Label1)
        Me.grpBoxCont.Controls.Add(Me.lblName)
        Me.grpBoxCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxCont.Location = New System.Drawing.Point(12, 12)
        Me.grpBoxCont.Name = "grpBoxCont"
        Me.grpBoxCont.Size = New System.Drawing.Size(312, 174)
        Me.grpBoxCont.TabIndex = 0
        Me.grpBoxCont.TabStop = False
        Me.grpBoxCont.Text = "Contact Information"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTotalCost.Location = New System.Drawing.Point(85, 27)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(121, 20)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "Total Cost: $0"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(89, 140)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(164, 22)
        Me.txtEmail.TabIndex = 5
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(89, 101)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(164, 22)
        Me.txtAge.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(89, 62)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(164, 22)
        Me.txtName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Age:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(7, 65)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(48, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'grpBoxPurch
        '
        Me.grpBoxPurch.Controls.Add(Me.txtCSV)
        Me.grpBoxPurch.Controls.Add(Me.txtCardName)
        Me.grpBoxPurch.Controls.Add(Me.txtCCN)
        Me.grpBoxPurch.Controls.Add(Me.Label5)
        Me.grpBoxPurch.Controls.Add(Me.Label4)
        Me.grpBoxPurch.Controls.Add(Me.Label3)
        Me.grpBoxPurch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxPurch.Location = New System.Drawing.Point(12, 192)
        Me.grpBoxPurch.Name = "grpBoxPurch"
        Me.grpBoxPurch.Size = New System.Drawing.Size(312, 182)
        Me.grpBoxPurch.TabIndex = 1
        Me.grpBoxPurch.TabStop = False
        Me.grpBoxPurch.Text = "Purchase Information"
        '
        'txtCSV
        '
        Me.txtCSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCSV.Location = New System.Drawing.Point(142, 117)
        Me.txtCSV.Name = "txtCSV"
        Me.txtCSV.Size = New System.Drawing.Size(164, 22)
        Me.txtCSV.TabIndex = 8
        '
        'txtCardName
        '
        Me.txtCardName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardName.Location = New System.Drawing.Point(142, 80)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(164, 22)
        Me.txtCardName.TabIndex = 7
        '
        'txtCCN
        '
        Me.txtCCN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCCN.Location = New System.Drawing.Point(142, 38)
        Me.txtCCN.Name = "txtCCN"
        Me.txtCCN.Size = New System.Drawing.Size(164, 22)
        Me.txtCCN.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Name on Card:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "CSV:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Credit Card Number:"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(22, 393)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(95, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(170, 393)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(95, 30)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 435)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpBoxPurch)
        Me.Controls.Add(Me.grpBoxCont)
        Me.Name = "frmPurchase"
        Me.Text = "Purchase"
        Me.grpBoxCont.ResumeLayout(False)
        Me.grpBoxCont.PerformLayout()
        Me.grpBoxPurch.ResumeLayout(False)
        Me.grpBoxPurch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpBoxCont As GroupBox
    Friend WithEvents grpBoxPurch As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCSV As TextBox
    Friend WithEvents txtCardName As TextBox
    Friend WithEvents txtCCN As TextBox
    Friend WithEvents lblTotalCost As Label
End Class
