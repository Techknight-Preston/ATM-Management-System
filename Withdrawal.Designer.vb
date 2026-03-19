<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWithdrawal
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
        btn50 = New Button()
        btn100 = New Button()
        btn200 = New Button()
        btn500 = New Button()
        btn1000 = New Button()
        btnOther = New Button()
        Label1 = New Label()
        txtAmount = New TextBox()
        btnWithdraw = New Button()
        btnCancel = New Button()
        lblBalance = New Label()
        SuspendLayout()
        ' 
        ' btn50
        ' 
        btn50.Location = New Point(150, 82)
        btn50.Name = "btn50"
        btn50.Size = New Size(112, 34)
        btn50.TabIndex = 1
        btn50.Text = "50"
        btn50.UseVisualStyleBackColor = True
        ' 
        ' btn100
        ' 
        btn100.Location = New Point(150, 164)
        btn100.Name = "btn100"
        btn100.Size = New Size(112, 42)
        btn100.TabIndex = 2
        btn100.Text = "100"
        btn100.UseVisualStyleBackColor = True
        ' 
        ' btn200
        ' 
        btn200.Location = New Point(358, 82)
        btn200.Name = "btn200"
        btn200.Size = New Size(112, 34)
        btn200.TabIndex = 3
        btn200.Text = "200"
        btn200.UseVisualStyleBackColor = True
        ' 
        ' btn500
        ' 
        btn500.Location = New Point(374, 168)
        btn500.Name = "btn500"
        btn500.Size = New Size(112, 34)
        btn500.TabIndex = 4
        btn500.Text = "500"
        btn500.UseVisualStyleBackColor = True
        ' 
        ' btn1000
        ' 
        btn1000.Location = New Point(561, 82)
        btn1000.Name = "btn1000"
        btn1000.Size = New Size(112, 34)
        btn1000.TabIndex = 5
        btn1000.Text = "1000"
        btn1000.UseVisualStyleBackColor = True
        ' 
        ' btnOther
        ' 
        btnOther.Location = New Point(561, 168)
        btnOther.Name = "btnOther"
        btnOther.Size = New Size(112, 34)
        btnOther.TabIndex = 6
        btnOther.Text = "Other Amount"
        btnOther.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(173, 256)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 25)
        Label1.TabIndex = 0
        Label1.Text = "Amount"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(374, 256)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(236, 31)
        txtAmount.TabIndex = 8
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.Location = New Point(59, 358)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(152, 80)
        btnWithdraw.TabIndex = 9
        btnWithdraw.Text = "Withdraw"
        btnWithdraw.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(620, 367)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(145, 71)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.Location = New Point(173, 29)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(71, 25)
        lblBalance.TabIndex = 11
        lblBalance.Text = "Balance"
        ' 
        ' frmWithdrawal
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblBalance)
        Controls.Add(btnCancel)
        Controls.Add(btnWithdraw)
        Controls.Add(txtAmount)
        Controls.Add(Label1)
        Controls.Add(btnOther)
        Controls.Add(btn1000)
        Controls.Add(btn500)
        Controls.Add(btn200)
        Controls.Add(btn100)
        Controls.Add(btn50)
        Name = "frmWithdrawal"
        Text = "Withdrawal"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btn50 As Button
    Friend WithEvents btn100 As Button
    Friend WithEvents btn200 As Button
    Friend WithEvents btn500 As Button
    Friend WithEvents btn1000 As Button
    Friend WithEvents btnOther As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblBalance As Label
End Class
