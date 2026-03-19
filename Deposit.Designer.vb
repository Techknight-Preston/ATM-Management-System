<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeposit
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
        Label1 = New Label()
        txtAmount = New TextBox()
        btnDeposit = New Button()
        btnCancel = New Button()
        lblBalance = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(76, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 25)
        Label1.TabIndex = 0
        Label1.Text = "Deposit Amount"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(327, 57)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(198, 31)
        txtAmount.TabIndex = 1
        ' 
        ' btnDeposit
        ' 
        btnDeposit.Location = New Point(74, 196)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(146, 89)
        btnDeposit.TabIndex = 2
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(370, 196)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(146, 89)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.Location = New Point(104, 345)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(71, 25)
        lblBalance.TabIndex = 4
        lblBalance.Text = "Balance"
        ' 
        ' frmDeposit
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblBalance)
        Controls.Add(btnCancel)
        Controls.Add(btnDeposit)
        Controls.Add(txtAmount)
        Controls.Add(Label1)
        Name = "frmDeposit"
        Text = "Deposit"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblBalance As Label
End Class
