Public Class frmMainMenu
    Private currentAccount As Account
    Private allAccounts As List(Of Account)
    Private transactions As New List(Of Transaction)()

    Public Sub New(account As Account, accounts As List(Of Account))
        InitializeComponent()
        currentAccount = account
        allAccounts = accounts
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        lblWelcome.Text = $"Welcome, {currentAccount.AccountHolderName}!"
        lblAccountInfo.Text = $"Account: {currentAccount.AccountNumber} ({currentAccount.AccountType})"
        UpdateBalanceDisplay()
    End Sub

    Private Sub UpdateBalanceDisplay()
        lblBalance.Text = $"Balance: ksh{currentAccount.Balance:N2}"
    End Sub

    Private Sub btnWithdrawal_Click(sender As Object, e As EventArgs) Handles btnWithdrawal.Click
        Dim frm As New frmWithdrawal(currentAccount, transactions)
        frm.ShowDialog()
        UpdateBalanceDisplay()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim frm As New frmDeposit(currentAccount, transactions)
        frm.ShowDialog()
        UpdateBalanceDisplay()
    End Sub

    Private Sub btnBalance_Click(sender As Object, e As EventArgs) Handles btnBalance.Click
        'Record balance 
        Dim txn As New Transaction() With {
            .AccountNumber = currentAccount.AccountNumber,
            .Type = Transaction.TransactionType.BalanceInquiry,
            .Amount = 0,
            .Description = "Balance inquiry",
            .BalanceAfter = currentAccount.Balance,
            .TransactionDate = DateTime.Now
        }
        transactions.Add(txn)

        MessageBox.Show($"Current Balance: ksh{currentAccount.Balance:N2}{vbCrLf}" &
                       $"Account: {currentAccount.AccountNumber}{vbCrLf}" &
                       $"Holder: {currentAccount.AccountHolderName}",
                       "Balance Inquiry", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        Dim frm As New frmTransfer(currentAccount, allAccounts, transactions)
        frm.ShowDialog()
        UpdateBalanceDisplay()
    End Sub

    Private Sub btnPinChange_Click(sender As Object, e As EventArgs) Handles btnPinChange.Click
        Dim frm As New frmPinChange(currentAccount, transactions)
        frm.ShowDialog()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim frm As New frmTransactionHistory(currentAccount.AccountNumber, transactions)
        frm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Confirm",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim login As New frmLogin()
            login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class