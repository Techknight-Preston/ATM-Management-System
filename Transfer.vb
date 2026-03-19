Public Class frmTransfer
    Private sourceAccount As Account
    Private allAccounts As List(Of Account)
    Private transactions As List(Of Transaction)

    Public Sub New(source As Account, accounts As List(Of Account), trans As List(Of Transaction))
        InitializeComponent()
        sourceAccount = source
        allAccounts = accounts
        transactions = trans
    End Sub

    Private Sub frmTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Text = "ATM - Transfer Funds"
        lblBalance.Text = $"Your Balance: ksh{sourceAccount.Balance:N2}"
        txtAmount.Enabled = False
        btnTransfer.Enabled = False
        lblTargetName.Visible = False
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If String.IsNullOrWhiteSpace(txtTargetAccount.Text) Then
            MessageBox.Show("Please enter target account number!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim target = allAccounts.FirstOrDefault(Function(a) a.AccountNumber = txtTargetAccount.Text)
        If target Is Nothing Then
            MessageBox.Show("Target account not found!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If target.AccountNumber = sourceAccount.AccountNumber Then
            MessageBox.Show("Cannot transfer to same account!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        lblTargetName.Text = $"To: {target.AccountHolderName}"
        lblTargetName.Visible = True
        txtAmount.Enabled = True
        btnTransfer.Enabled = True
        txtAmount.Focus()
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
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

        If amount > sourceAccount.Balance Then
            MessageBox.Show("Insufficient funds!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get target account
        Dim target = allAccounts.First(Function(a) a.AccountNumber = txtTargetAccount.Text)

        ' Process transfer
        sourceAccount.Balance -= amount
        target.Balance += amount

        ' Record transaction for sender (WITHDRAWAL/TRANSFER OUT)
        Dim txnOut As New Transaction() With {
            .AccountNumber = sourceAccount.AccountNumber,
            .Type = Transaction.TransactionType.Transfer,
            .Amount = amount,
            .Description = $"Transfer to {target.AccountNumber}",
            .BalanceAfter = sourceAccount.Balance,
            .TransactionDate = DateTime.Now
        }
        transactions.Add(txnOut)

        ' Record transaction for receiver (DEPOSIT/TRANSFER IN)
        Dim txnIn As New Transaction() With {
            .AccountNumber = target.AccountNumber,
            .Type = Transaction.TransactionType.Deposit,
            .Amount = amount,
            .Description = $"Transfer from {sourceAccount.AccountNumber}",
            .BalanceAfter = target.Balance,
            .TransactionDate = DateTime.Now
        }
        transactions.Add(txnIn)

        MessageBox.Show($"Transfer successful!{vbCrLf}" &
                       $"Amount: ksh{amount:N2}{vbCrLf}" &
                       $"To: {target.AccountHolderName}{vbCrLf}" &
                       $"New Balance: ksh{sourceAccount.Balance:N2}",
                       "ATM - Transfer Complete",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Ask if user wants a receipt
        Dim receipt = MessageBox.Show("Would you like a receipt?", "ATM - Receipt",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If receipt = DialogResult.Yes Then
            ShowReceipt(amount, target)
        End If

        Me.Close()
    End Sub

    Private Sub ShowReceipt(amount As Decimal, target As Account)
        Dim receipt As String = "=================================" & vbCrLf
        receipt &= "           TRANSFER RECEIPT        " & vbCrLf
        receipt &= "=================================" & vbCrLf
        receipt &= $"Date: {DateTime.Now:MM/dd/yyyy HH:mm}" & vbCrLf
        receipt &= $"ATM: ATM001" & vbCrLf
        receipt &= $"From: {sourceAccount.AccountNumber}" & vbCrLf
        receipt &= $"To: {target.AccountNumber}" & vbCrLf
        receipt &= $"To: {target.AccountHolderName}" & vbCrLf
        receipt &= $"Amount: ksh{amount:N2}" & vbCrLf
        receipt &= $"New Balance: ksh{sourceAccount.Balance:N2}" & vbCrLf
        receipt &= "=================================" & vbCrLf
        receipt &= "Thank you for using our ATM!" & vbCrLf
        receipt &= "================================="

        MessageBox.Show(receipt, "ATM - Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        ' Allow digits, control characters, and one decimal point
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        If e.KeyChar = "." AndAlso DirectCast(sender, TextBox).Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTargetAccount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTargetAccount.KeyPress
        ' Only allow digits for account number
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class