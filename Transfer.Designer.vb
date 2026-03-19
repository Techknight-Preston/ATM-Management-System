<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransfer
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
        lblAccNo = New Label()
        Label2 = New Label()
        btnVerify = New Button()
        txtTargetAccount = New TextBox()
        lblTargetName = New TextBox()
        Label3 = New Label()
        txtAmount = New TextBox()
        btnTransfer = New Button()
        Label4 = New Label()
        btnCancel = New Button()
        lblBalance = New Label()
        SuspendLayout()
        ' 
        ' lblAccNo
        ' 
        lblAccNo.AutoSize = True
        lblAccNo.Location = New Point(85, 40)
        lblAccNo.Name = "lblAccNo"
        lblAccNo.Size = New Size(200, 25)
        lblAccNo.TabIndex = 0
        lblAccNo.Text = "Target Account Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(122, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 25)
        Label2.TabIndex = 1
        Label2.Text = "Target Name"
        ' 
        ' btnVerify
        ' 
        btnVerify.Location = New Point(240, 98)
        btnVerify.Name = "btnVerify"
        btnVerify.Size = New Size(112, 34)
        btnVerify.TabIndex = 2
        btnVerify.Text = "Verify"
        btnVerify.UseVisualStyleBackColor = True
        ' 
        ' txtTargetAccount
        ' 
        txtTargetAccount.Location = New Point(370, 34)
        txtTargetAccount.Name = "txtTargetAccount"
        txtTargetAccount.Size = New Size(217, 31)
        txtTargetAccount.TabIndex = 3
        ' 
        ' lblTargetName
        ' 
        lblTargetName.Location = New Point(370, 162)
        lblTargetName.Name = "lblTargetName"
        lblTargetName.Size = New Size(217, 31)
        lblTargetName.TabIndex = 4
        lblTargetName.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(122, 233)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 25)
        Label3.TabIndex = 5
        Label3.Text = "Amount"
        ' 
        ' txtAmount
        ' 
        txtAmount.Enabled = False
        txtAmount.Location = New Point(370, 233)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(217, 31)
        txtAmount.TabIndex = 6
        txtAmount.Visible = False
        ' 
        ' btnTransfer
        ' 
        btnTransfer.Location = New Point(100, 290)
        btnTransfer.Name = "btnTransfer"
        btnTransfer.Size = New Size(134, 64)
        btnTransfer.TabIndex = 7
        btnTransfer.Text = "Transfer"
        btnTransfer.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(122, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 25)
        Label4.TabIndex = 8
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(529, 290)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(134, 64)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.Location = New Point(108, 403)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(71, 25)
        lblBalance.TabIndex = 10
        lblBalance.Text = "Balance"
        ' 
        ' frmTransfer
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblBalance)
        Controls.Add(btnCancel)
        Controls.Add(Label4)
        Controls.Add(btnTransfer)
        Controls.Add(txtAmount)
        Controls.Add(Label3)
        Controls.Add(lblTargetName)
        Controls.Add(txtTargetAccount)
        Controls.Add(btnVerify)
        Controls.Add(Label2)
        Controls.Add(lblAccNo)
        Enabled = False
        Name = "frmTransfer"
        Text = "Transfer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAccNo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVerify As Button
    Friend WithEvents txtTargetAccount As TextBox
    Friend WithEvents lblTargetName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnTransfer As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblBalance As Label
End Class
