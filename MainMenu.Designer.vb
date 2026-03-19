<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblWelcome = New Label()
        btnWithdrawal = New Button()
        btnDeposit = New Button()
        btnTransfer = New Button()
        btnBalance = New Button()
        btnPinChange = New Button()
        btnHistory = New Button()
        btnLogOut = New Button()
        btnExit = New Button()
        lblAccountInfo = New Label()
        lblBalance = New Label()
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Location = New Point(79, 18)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(85, 25)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome"
        ' 
        ' btnWithdrawal
        ' 
        btnWithdrawal.Location = New Point(160, 107)
        btnWithdrawal.Name = "btnWithdrawal"
        btnWithdrawal.Size = New Size(112, 34)
        btnWithdrawal.TabIndex = 1
        btnWithdrawal.Text = "Withdrawal"
        btnWithdrawal.UseVisualStyleBackColor = True
        ' 
        ' btnDeposit
        ' 
        btnDeposit.Location = New Point(160, 198)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(112, 34)
        btnDeposit.TabIndex = 2
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = True
        ' 
        ' btnTransfer
        ' 
        btnTransfer.Location = New Point(471, 107)
        btnTransfer.Name = "btnTransfer"
        btnTransfer.Size = New Size(112, 34)
        btnTransfer.TabIndex = 3
        btnTransfer.Text = "Transfer"
        btnTransfer.UseVisualStyleBackColor = True
        ' 
        ' btnBalance
        ' 
        btnBalance.Location = New Point(471, 198)
        btnBalance.Name = "btnBalance"
        btnBalance.Size = New Size(112, 34)
        btnBalance.TabIndex = 4
        btnBalance.Text = "Acc Balance"
        btnBalance.UseVisualStyleBackColor = True
        ' 
        ' btnPinChange
        ' 
        btnPinChange.Location = New Point(160, 285)
        btnPinChange.Name = "btnPinChange"
        btnPinChange.Size = New Size(112, 34)
        btnPinChange.TabIndex = 5
        btnPinChange.Text = "Change pin"
        btnPinChange.UseVisualStyleBackColor = True
        ' 
        ' btnHistory
        ' 
        btnHistory.Location = New Point(471, 285)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(112, 34)
        btnHistory.TabIndex = 6
        btnHistory.Text = "History"
        btnHistory.UseVisualStyleBackColor = True
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Location = New Point(618, 361)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(124, 69)
        btnLogOut.TabIndex = 7
        btnLogOut.Text = "logout"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(66, 361)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(130, 69)
        btnExit.TabIndex = 8
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblAccountInfo
        ' 
        lblAccountInfo.AutoSize = True
        lblAccountInfo.Location = New Point(317, 17)
        lblAccountInfo.Name = "lblAccountInfo"
        lblAccountInfo.Size = New Size(113, 25)
        lblAccountInfo.TabIndex = 9
        lblAccountInfo.Text = "Account info"
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.Location = New Point(618, 18)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(71, 25)
        lblBalance.TabIndex = 10
        lblBalance.Text = "Balance"
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblBalance)
        Controls.Add(lblAccountInfo)
        Controls.Add(btnExit)
        Controls.Add(btnLogOut)
        Controls.Add(btnHistory)
        Controls.Add(btnPinChange)
        Controls.Add(btnBalance)
        Controls.Add(btnTransfer)
        Controls.Add(btnDeposit)
        Controls.Add(btnWithdrawal)
        Controls.Add(lblWelcome)
        Name = "frmMainMenu"
        Text = "MainMenu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnWithdrawal As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnTransfer As Button
    Friend WithEvents btnBalance As Button
    Friend WithEvents btnPinChange As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAccountInfo As Label
    Friend WithEvents lblBalance As Label
End Class
