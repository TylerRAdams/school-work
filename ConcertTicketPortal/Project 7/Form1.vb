
Public Class frmSales
    Dim password As String = "8675309"
    Dim totalLowerAmount As Integer = 200
    Dim totalClubAmount As Integer = 75
    Dim totalUpperAmount As Integer = 200
    Dim totalSales As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboClub.SelectedIndex = 0
        comboLower.SelectedIndex = 0
        comboUpper.SelectedIndex = 0

        If (totalLowerAmount = 0) Then 'Sold Out Labels
            lblLower.Text = "Sold Out!"
        End If
        If (totalClubAmount = 0) Then
            lblClub.Text = "Sold Out!"
        End If
        If (totalUpperAmount = 0) Then
            lblUpper.Text = "Sold Out!"
        End If

        For Each line In (IO.File.ReadAllLines("info.txt")) 'Adds stuff from the file to the data grid view
            frmAdmin.theDataGrid.Rows.Add(line.Split(","))
        Next
        For index As Integer = 0 To frmAdmin.theDataGrid.RowCount - 1 'Counts how many tickets are left and calculates money
            totalLowerAmount -= frmAdmin.theDataGrid.Rows(index).Cells(7).Value
            totalClubAmount -= frmAdmin.theDataGrid.Rows(index).Cells(8).Value
            totalUpperAmount -= frmAdmin.theDataGrid.Rows(index).Cells(9).Value
            totalSales += frmAdmin.theDataGrid.Rows(index).Cells(6).Value
        Next

        frmAdmin.lblLower.Text = totalLowerAmount 'Deals with labels for the admin form
        frmAdmin.lblClub.Text = totalClubAmount
        frmAdmin.lblUpper.Text = totalUpperAmount
        frmAdmin.lblSales.Text = "$" & totalSales
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click 'Do I even have to say what this is at this point
        Me.Close()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click 'Goes to admin form
        If (InputBox("Enter the Password: ", "Password Needed") = password) Then
            frmAdmin.ShowDialog()
        Else
            MessageBox.Show("Password is incorrect.", "Incorrect Password.")
        End If


    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click 'Lots of error handling and goes to purchase
        Try
            If (comboLower.Text < totalLowerAmount And comboClub.Text < totalClubAmount And comboUpper.Text < totalUpperAmount) Then
                'The outer if statement ensures you can't buy more tickets than available
                If (IsNumeric(comboLower.Text And comboUpper.Text And comboClub.Text)) Then 'Cannot input non numeric values
                    If (comboLower.Text <= 0 And comboUpper.Text <= 0 And comboClub.Text <= 0) Then 'Have to buy 1 ticket
                        MessageBox.Show("Error! Must specify some amount of tickets to buy.", "Error!")
                    Else
                        GlobalVariables.boughtLower = comboLower.Text
                        GlobalVariables.boughtClub = comboClub.Text
                        GlobalVariables.boughtUpper = comboUpper.Text
                        frmPurchase.ShowDialog()
                    End If
                End If
            Else
                MessageBox.Show("There are not enough remaining tickets. Please reduce number of tickets.")
            End If
        Catch
            MessageBox.Show("Error. Tickets must be numeric value.", "Error!")
        End Try
    End Sub
End Class
Public Class GlobalVariables 'I kind of hate these and would not use them next time.
    Public Shared boughtLower As Integer
    Public Shared boughtUpper As Integer
    Public Shared boughtClub As Integer
End Class