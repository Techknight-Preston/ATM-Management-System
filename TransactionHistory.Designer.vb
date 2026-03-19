<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactionHistory
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
        lstTransactions = New ListBox()
        btnClose = New Button()
        lblCount = New Label()
        SuspendLayout()
        ' 
        ' lstTransactions
        ' 
        lstTransactions.FormattingEnabled = True
        lstTransactions.ItemHeight = 25
        lstTransactions.Location = New Point(151, 23)
        lstTransactions.Name = "lstTransactions"
        lstTransactions.Size = New Size(603, 329)
        lstTransactions.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(599, 393)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 34)
        btnClose.TabIndex = 1
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Location = New Point(151, 384)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(162, 25)
        lblCount.TabIndex = 2
        lblCount.Text = "Transaction History"
        ' 
        ' frmTransactionHistory
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblCount)
        Controls.Add(btnClose)
        Controls.Add(lstTransactions)
        Name = "frmTransactionHistory"
        Text = "TransactionHistory"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstTransactions As ListBox
    Friend WithEvents btnClose As Button
    Friend WithEvents lblCount As Label
End Class
