<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDecrypt
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
        Me.cmbModes = New System.Windows.Forms.ComboBox()
        Me.cmbResultChoices = New System.Windows.Forms.ComboBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtKey2 = New System.Windows.Forms.TextBox()
        Me.lblKey2 = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbModes
        '
        Me.cmbModes.FormattingEnabled = True
        Me.cmbModes.Items.AddRange(New Object() {"Decrypt", "Encrypt", "Generate keys"})
        Me.cmbModes.Location = New System.Drawing.Point(12, 12)
        Me.cmbModes.Name = "cmbModes"
        Me.cmbModes.Size = New System.Drawing.Size(121, 21)
        Me.cmbModes.TabIndex = 8
        '
        'cmbResultChoices
        '
        Me.cmbResultChoices.FormattingEnabled = True
        Me.cmbResultChoices.Items.AddRange(New Object() {"ASCII UTF-8", "Hexadecimal", "Decimal"})
        Me.cmbResultChoices.Location = New System.Drawing.Point(13, 202)
        Me.cmbResultChoices.Name = "cmbResultChoices"
        Me.cmbResultChoices.Size = New System.Drawing.Size(90, 21)
        Me.cmbResultChoices.TabIndex = 4
        Me.cmbResultChoices.Text = "Result format"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(12, 232)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(43, 13)
        Me.lblResult.TabIndex = 21
        Me.lblResult.Text = "Result :"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(73, 229)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(199, 20)
        Me.txtResult.TabIndex = 6
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(197, 200)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 23)
        Me.btnProcess.TabIndex = 5
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(13, 104)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(59, 78)
        Me.lblMessage.TabIndex = 18
        Me.lblMessage.Text = "Message :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Delims :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Space," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comma," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Semicolon," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Linebreak"
        '
        'txtKey2
        '
        Me.txtKey2.Location = New System.Drawing.Point(108, 70)
        Me.txtKey2.Name = "txtKey2"
        Me.txtKey2.Size = New System.Drawing.Size(165, 20)
        Me.txtKey2.TabIndex = 2
        '
        'lblKey2
        '
        Me.lblKey2.AutoSize = True
        Me.lblKey2.Location = New System.Drawing.Point(13, 73)
        Me.lblKey2.Name = "lblKey2"
        Me.lblKey2.Size = New System.Drawing.Size(89, 13)
        Me.lblKey2.TabIndex = 16
        Me.lblKey2.Text = "Common key (n) :"
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(108, 40)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(165, 20)
        Me.txtKey.TabIndex = 1
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Location = New System.Drawing.Point(13, 43)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(81, 13)
        Me.lblKey.TabIndex = 14
        Me.lblKey.Text = "Private key (d) :"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(74, 104)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(198, 78)
        Me.txtMessage.TabIndex = 3
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(197, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmDecrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.cmbModes)
        Me.Controls.Add(Me.cmbResultChoices)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtKey2)
        Me.Controls.Add(Me.lblKey2)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.lblKey)
        Me.MaximizeBox = False
        Me.Name = "frmDecrypt"
        Me.Text = "RSA Decryption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbModes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbResultChoices As System.Windows.Forms.ComboBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents txtKey2 As System.Windows.Forms.TextBox
    Friend WithEvents lblKey2 As System.Windows.Forms.Label
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents lblKey As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
