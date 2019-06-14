Public Class frmAdmin

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click 'Typical close button
        Me.Close()
    End Sub

    Private Sub btnSalesForm_Click(sender As Object, e As EventArgs) Handles btnSalesForm.Click 'Just another close
        Me.Close()
    End Sub

    Private Sub btnPurchForm_Click(sender As Object, e As EventArgs) Handles btnPurchForm.Click
        frmPurchase.ShowDialog()
    End Sub

    Private Sub btnGuestLook_Click(sender As Object, e As EventArgs) Handles btnGuestLook.Click 'Calls a function
        Dim searchForThisEmail As String
        searchForThisEmail = InputBox("Enter the Email you want to search for: ", "Enter Email Address")
        emailLookup(searchForThisEmail)
    End Sub

    Private Sub btnConfLook_Click(sender As Object, e As EventArgs) Handles btnConfLook.Click 'Calls a function
        Dim searchForThisNumber As Integer
        searchForThisNumber = InputBox("Enter the Confirmation Number you want to search for: ", "Enter Number")
        confLookup(searchForThisNumber)
    End Sub

    Private Sub emailLookup(email) 'Looks for a user based on their email
        Dim counter As Integer = 0
        Dim exists As Boolean = False
        While counter < theDataGrid.RowCount - 1
            If theDataGrid.Rows(counter).Cells(2).Value.ToString = email Then
                theDataGrid.CurrentCell = theDataGrid.Rows(counter).Cells(0)
                exists = True
                Exit While
            Else
                exists = False
            End If
            counter += 1
        End While
        If exists = False Then
            MessageBox.Show("Email not found.", "Error.")
        End If
    End Sub

    Private Sub confLookup(number) 'Almost same thing as email but with confirmation number
        Dim counter As Integer = 0
        Dim exists As Boolean = False
        While counter < theDataGrid.RowCount - 1
            If theDataGrid.Rows(counter).Cells(10).Value.ToString = number Then
                theDataGrid.CurrentCell = theDataGrid.Rows(counter).Cells(0)
                exists = True
                Exit While
            Else
                exists = False
            End If
            counter += 1
        End While
        If exists = False Then
            MessageBox.Show("Confirmation Number not found.", "Error.")
        End If
    End Sub

    Public Function emailAlreadyExists(email) 'Used only on the purchase form
        Dim counter As Integer = 0
        Dim exists As Boolean = False
        While counter < theDataGrid.RowCount - 1
            If theDataGrid.Rows(counter).Cells(2).Value.ToString = email Then
                exists = True
                Exit While
            End If
            counter += 1
        End While
        If exists = True Then
            Return True
        Else
            Return False
        End If
    End Function

End Class