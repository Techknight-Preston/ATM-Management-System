<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPinChange
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
        btnChange = New Button()
        Label2 = New Label()
        Label3 = New Label()
        txtOldPin = New TextBox()
        txtNewPin = New TextBox()
        txtConfirmPin = New TextBox()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(51, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 25)
        Label1.TabIndex = 0
        Label1.Text = "Current PIN"
        ' 
        ' btnChange
        ' 
        btnChange.Location = New Point(102, 329)
        btnChange.Name = "btnChange"
        btnChange.Size = New Size(143, 64)
        btnChange.TabIndex = 2
        btnChange.Text = "Update"
        btnChange.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(51, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 25)
        Label2.TabIndex = 3
        Label2.Text = "New PIN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(51, 235)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 25)
        Label3.TabIndex = 4
        Label3.Text = "Confirm PIN"
        ' 
        ' txtOldPin
        ' 
        txtOldPin.Location = New Point(293, 46)
        txtOldPin.Name = "txtOldPin"
        txtOldPin.Size = New Size(217, 31)
        txtOldPin.TabIndex = 5
        ' 
        ' txtNewPin
        ' 
        txtNewPin.Location = New Point(293, 141)
        txtNewPin.Name = "txtNewPin"
        txtNewPin.Size = New Size(217, 31)
        txtNewPin.TabIndex = 6
        ' 
        ' txtConfirmPin
        ' 
        txtConfirmPin.Location = New Point(293, 229)
        txtConfirmPin.Name = "txtConfirmPin"
        txtConfirmPin.Size = New Size(217, 31)
        txtConfirmPin.TabIndex = 7
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(400, 329)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(143, 64)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' frmPinChange
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCancel)
        Controls.Add(txtConfirmPin)
        Controls.Add(txtNewPin)
        Controls.Add(txtOldPin)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnChange)
        Controls.Add(Label1)
        Name = "frmPinChange"
        Text = "Change Pin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnChange As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOldPin As TextBox
    Friend WithEvents txtNewPin As TextBox
    Friend WithEvents txtConfirmPin As TextBox
    Friend WithEvents btnCancel As Button
End Class
