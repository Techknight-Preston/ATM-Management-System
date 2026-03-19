Public Class Account
    Public Property AccountNumber As String
    Public Property Pin As String
    Public Property AccountHolderName As String
    Public Property Balance As Decimal
    Public Property AccountType As String

    Public Sub New(accountNumber As String, pin As String, accountHolderName As String, balance As Decimal, accountType As String)
        Me.AccountNumber = accountNumber
        Me.Pin = pin
        Me.AccountHolderName = accountHolderName
        Me.Balance = balance
        Me.AccountType = accountType
    End Sub
End Class