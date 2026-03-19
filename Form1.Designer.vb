<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblCurrentAccount = New Label()
        Label2 = New Label()
        btnLogin = New Button()
        txtAccountNumber = New TextBox()
        txtPin = New TextBox()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblCurrentAccount
        ' 
        lblCurrentAccount.AutoSize = True
        lblCurrentAccount.Location = New Point(67, 58)
        lblCurrentAccount.Name = "lblCurrentAccount"
        lblCurrentAccount.Size = New Size(147, 25)
        lblCurrentAccount.TabIndex = 0
        lblCurrentAccount.Text = "Account Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(67, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 25)
        Label2.TabIndex = 1
        Label2.Text = "PIN"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(86, 310)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(142, 65)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtAccountNumber
        ' 
        txtAccountNumber.Location = New Point(241, 58)
        txtAccountNumber.Name = "txtAccountNumber"
        txtAccountNumber.Size = New Size(258, 31)
        txtAccountNumber.TabIndex = 3
        ' 
        ' txtPin
        ' 
        txtPin.Location = New Point(241, 163)
        txtPin.Name = "txtPin"
        txtPin.Size = New Size(258, 31)
        txtPin.TabIndex = 4
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(536, 310)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(142, 65)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(txtPin)
        Controls.Add(txtAccountNumber)
        Controls.Add(btnLogin)
        Controls.Add(Label2)
        Controls.Add(lblCurrentAccount)
        Name = "frmLogin"
        Text = "frmLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCurrentAccount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents txtPin As TextBox
    Friend WithEvents btnExit As Button

End Class
