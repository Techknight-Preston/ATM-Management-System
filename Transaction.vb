Public Class Transaction
    Public Enum TransactionType
        Deposit
        Withdrawal
        Transfer
        BalanceInquiry
        PinChange
    End Enum

    Public Property AccountNumber As String
    Public Property Type As TransactionType
    Public Property Amount As Decimal
    Public Property Description As String
    Public Property BalanceAfter As Decimal
    Public Property TransactionDate As DateTime

    Public Sub New()
        TransactionDate = DateTime.Now
    End Sub
End Class