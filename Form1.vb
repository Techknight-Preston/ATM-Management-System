Imports System.Linq
Imports System.Collections.Generic

Public Class frmLogin
    Private accounts As New List(Of Account)()
    Private loginAttempts As Integer = 0

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        InitializeAccounts()
        txtAccountNumber.Focus()
    End Sub

    Private Sub InitializeAccounts()
        'sample accounts
        accounts.Add(New Account("1001", "1234", "Mark Preston", 100000, "Savings"))
        accounts.Add(New Account("1002", "5678", "Clare Michelle", 500000, "Current"))
        accounts.Add(New Account("1003", "9012", "Muktar Abdi", 250000, "Savings"))
        accounts.Add(New Account("1004", "3456", "Tracy Wambui", 750000, "Current"))
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtAccountNumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtPin.Text) Then
            MessageBox.Show("Please enter account number and PIN!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Find account
        Dim account = accounts.FirstOrDefault(Function(a) a.AccountNumber = txtAccountNumber.Text AndAlso
                                                         a.Pin = txtPin.Text)

        If account IsNot Nothing Then
            ' Successful login
            loginAttempts = 0
            Dim mainMenu As New frmMainMenu(account, accounts)
            mainMenu.Show()
            Me.Hide()
        Else
            loginAttempts += 1
            If loginAttempts >= 3 Then
                MessageBox.Show("Too many failed attempts! Application will close.",
                              "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            Else
                MessageBox.Show($"Invalid account number or PIN! Attempts left: {3 - loginAttempts}",
                              "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPin.Clear()
                txtPin.Focus()
            End If
        End If
    End Sub




    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPin.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class