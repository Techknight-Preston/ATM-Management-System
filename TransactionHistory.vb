Public Class frmTransactionHistory
    Private accountNumber As String
    Private transactions As List(Of Transaction)

    Public Sub New(accNum As String, trans As List(Of Transaction))
        InitializeComponent()
        accountNumber = accNum
        transactions = trans
    End Sub

    Private Sub frmTransactionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        LoadTransactions()
    End Sub

    Private Sub LoadTransactions()
        ' Filter transactions for this account
        Dim accountTransactions = transactions.Where(Function(t) t.AccountNumber = accountNumber) _
                                              .OrderByDescending(Function(t) t.TransactionDate) _
                                              .ToList()

        ' Setup ListBox to display transactions
        lstTransactions.Items.Clear()

        If accountTransactions.Count = 0 Then
            lstTransactions.Items.Add("No transactions found.")
        Else
            For Each txn In accountTransactions
                Dim sign As String = ""
                If txn.Type = Transaction.TransactionType.Withdrawal Or
                   txn.Type = Transaction.TransactionType.Transfer Then
                    sign = "-"
                ElseIf txn.Type = Transaction.TransactionType.Deposit Then
                    sign = "+"
                End If

                Dim displayText As String = $"{txn.TransactionDate:dd/MM/yyyy HH:mm} | " &
                                           $"{txn.Type.ToString().PadRight(15)} | " &
                                           $"{sign}ksh{txn.Amount:N2} | " &
                                           $"Balance: ksh{txn.BalanceAfter:N2}"
                lstTransactions.Items.Add(displayText)
            Next

            lblCount.Text = $"Total Transactions: {accountTransactions.Count}"
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCount.Click

    End Sub
End Class