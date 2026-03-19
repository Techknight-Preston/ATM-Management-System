Public Class frmWithdrawal
    Private account As Account
    Private transactions As List(Of Transaction)

    Public Sub New(acc As Account, trans As List(Of Transaction))
        InitializeComponent()
        account = acc
        transactions = trans
    End Sub

    Private Sub frmWithdrawal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        lblBalance.Text = $"Current Balance: ksh{account.Balance:N2}"
    End Sub

    Private Sub btnAmount_Click(sender As Object, e As EventArgs) Handles btn50.Click, btn100.Click, btn200.Click, btn500.Click, btn1000.Click
        Dim btn As Button = CType(sender, Button)
        txtAmount.Text = btn.Text.Replace("Ksh", "").Replace("ksh", "").Trim()
    End Sub

    Private Sub btnOther_Click(sender As Object, e As EventArgs) Handles btnOther.Click
        txtAmount.ReadOnly = False
        txtAmount.Clear()
        txtAmount.Focus()
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
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

        ' Check sufficient balance
        If amount > account.Balance Then
            MessageBox.Show("Insufficient funds!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Process withdrawal
        account.Balance -= amount

        ' Record transaction
        Dim txn As New Transaction() With {
            .AccountNumber = account.AccountNumber,
            .Type = Transaction.TransactionType.Withdrawal,
            .Amount = amount,
            .Description = $"Withdrawal of ksh{amount}",
            .BalanceAfter = account.Balance,
            .TransactionDate = DateTime.Now
        }
        transactions.Add(txn)

        MessageBox.Show($"Withdrawal successful!{vbCrLf}Amount: ksh{amount}{vbCrLf}New Balance: {account.Balance:N2}",
                      "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class