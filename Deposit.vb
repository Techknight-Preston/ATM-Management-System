Public Class frmDeposit
    Private account As Account
    Private transactions As List(Of Transaction)

    Public Sub New(acc As Account, trans As List(Of Transaction))
        InitializeComponent()
        account = acc
        transactions = trans
    End Sub

    Private Sub frmDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        lblBalance.Text = $"Current Balance: ksh{account.Balance:N2}"
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        If String.IsNullOrWhiteSpace(txtAmount.Text) Then
            MessageBox.Show("Please enter amount!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim amount As Decimal
        If Not Decimal.TryParse(txtAmount.Text, amount) OrElse amount <= 0 Then
            MessageBox.Show("Invalid amount!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Process deposit
        account.Balance += amount

        ' Record transaction
        Dim txn As New Transaction() With {
            .AccountNumber = account.AccountNumber,
            .Type = Transaction.TransactionType.Deposit,
            .Amount = amount,
            .Description = $"Deposit of ksh{amount}",
            .BalanceAfter = account.Balance,
            .TransactionDate = DateTime.Now
        }
        transactions.Add(txn)

        MessageBox.Show($"Deposit successful!{vbCrLf}Amount: ksh{amount}{vbCrLf}New Balance: ksh{account.Balance:N2}",
                      "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class