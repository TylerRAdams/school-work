Public Class frmPurchase
    Dim totalCost As Integer = (GlobalVariables.boughtLower * 125) + (GlobalVariables.boughtClub * 75) + (GlobalVariables.boughtUpper * 50)
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalCost.Text = "Total Sales = $" & totalCost
    End Sub
    Private Sub frmPurchase_Close(sender As Object, e As EventArgs) Handles MyBase.Load 'Clears out user info when the form closes
        txtName.Clear()
        txtAge.Clear()
        txtEmail.Clear()
        txtCardName.Clear()
        txtCCN.Clear()
        txtCSV.Clear()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (frmAdmin.emailAlreadyExists(txtEmail.Text) = False) Then 'Checks if the email exists
            If (String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txtEmail.Text) Or String.IsNullOrEmpty(txtAge.Text) Or String.IsNullOrEmpty(txtCCN.Text)) Or String.IsNullOrEmpty(txtCSV.Text) Or String.IsNullOrEmpty(txtCardName.Text) Then
                MessageBox.Show("Error. You are missing one or more fields.", "Error!") 'Makes sure every field is filled
            Else
                If MessageBox.Show("Can't wait to see you! " & txtName.Text & vbNewLine & "Summary: " & vbNewLine & "Amount to be Charged: $" & totalCost & vbNewLine & "Contact E-Mail: " & txtEmail.Text & vbNewLine & "Please click Yes to confirm your order.", "Confirmation", MessageBoxButtons.YesNoCancel) = 6 Then
                    Static Generator As System.Random = New System.Random() 'Generates confirmation number
                    Dim Confirmation As New Integer
                    Confirmation = Generator.Next(1000, 9999)
                    MessageBox.Show("Order Confirmation Number: " & Confirmation)
                    Dim swVar As IO.StreamWriter = IO.File.AppendText("info.txt") 'This is used to save the data
                    swVar.WriteLine(txtName.Text & "," & txtAge.Text & "," & txtEmail.Text & "," & txtCCN.Text & "," & txtCardName.Text & "," & txtCSV.Text & "," & totalCost & "," & GlobalVariables.boughtLower & "," & GlobalVariables.boughtClub & "," & GlobalVariables.boughtUpper & "," & Confirmation)
                    swVar.Close()
                    Me.Close()
                End If

            End If
        Else
            MessageBox.Show("Email already exists within our system.", "Error!")
        End If
    End Sub
End Class