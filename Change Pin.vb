Public Class frmPinChange
    Private account As Account
    Private transactions As List(Of Transaction)

    Public Sub New(acc As Account, trans As List(Of Transaction))
        InitializeComponent()
        account = acc
        transactions = trans
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        ' Validate inputs
        If String.IsNullOrWhiteSpace(txtOldPin.Text) OrElse
           String.IsNullOrWhiteSpace(txtNewPin.Text) OrElse
           String.IsNullOrWhiteSpace(txtConfirmPin.Text) Then
            MessageBox.Show("Please fill all fields!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Verify old PIN
        If txtOldPin.Text <> account.Pin Then
            MessageBox.Show("Current PIN is incorrect!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check new PIN format
        If txtNewPin.Text.Length <> 4 OrElse Not IsNumeric(txtNewPin.Text) Then
            MessageBox.Show("New PIN must be 4 digits!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if new PIN matches confirm
        If txtNewPin.Text <> txtConfirmPin.Text Then
            MessageBox.Show("New PIN and confirm PIN do not match!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Change PIN
        account.Pin = txtNewPin.Text

        ' Record transaction - FIXED: Added TransactionDate
        Dim txn As New Transaction() With {
            .AccountNumber = account.AccountNumber,
            .Type = Transaction.TransactionType.PinChange,
            .Amount = 0,
            .Description = "PIN changed",
            .BalanceAfter = account.Balance,
            .TransactionDate = DateTime.Now
        }
        transactions.Add(txn)

        MessageBox.Show("PIN changed successfully! Please use your new PIN next login.",
                      "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class