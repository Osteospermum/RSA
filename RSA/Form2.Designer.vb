<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEncrypt
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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
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
        Me.cmbDelim = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(197, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(74, 109)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(198, 20)
        Me.txtMessage.TabIndex = 3
        '
        'cmbModes
        '
        Me.cmbModes.FormattingEnabled = True
        Me.cmbModes.Items.AddRange(New Object() {"Decrypt", "Encrypt", "Generate keys"})
        Me.cmbModes.Location = New System.Drawing.Point(12, 12)
        Me.cmbModes.Name = "cmbModes"
        Me.cmbModes.Size = New System.Drawing.Size(121, 21)
        Me.cmbModes.TabIndex = 9
        '
        'cmbResultChoices
        '
        Me.cmbResultChoices.FormattingEnabled = True
        Me.cmbResultChoices.Items.AddRange(New Object() {"ASCII UTF-8", "Hexadecimal", "Decimal"})
        Me.cmbResultChoices.Location = New System.Drawing.Point(13, 147)
        Me.cmbResultChoices.Name = "cmbResultChoices"
        Me.cmbResultChoices.Size = New System.Drawing.Size(98, 21)
        Me.cmbResultChoices.TabIndex = 4
        Me.cmbResultChoices.Text = "Plaintext format"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(12, 180)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(43, 39)
        Me.lblResult.TabIndex = 33
        Me.lblResult.Text = "Result :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Delim :"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(73, 180)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResult.Size = New System.Drawing.Size(199, 69)
        Me.txtResult.TabIndex = 7
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(197, 145)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 23)
        Me.btnProcess.TabIndex = 6
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(12, 112)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(56, 13)
        Me.lblMessage.TabIndex = 30
        Me.lblMessage.Text = "Message :"
        '
        'txtKey2
        '
        Me.txtKey2.Location = New System.Drawing.Point(107, 83)
        Me.txtKey2.Name = "txtKey2"
        Me.txtKey2.Size = New System.Drawing.Size(165, 20)
        Me.txtKey2.TabIndex = 2
        '
        'lblKey2
        '
        Me.lblKey2.AutoSize = True
        Me.lblKey2.Location = New System.Drawing.Point(12, 86)
        Me.lblKey2.Name = "lblKey2"
        Me.lblKey2.Size = New System.Drawing.Size(89, 13)
        Me.lblKey2.TabIndex = 28
        Me.lblKey2.Text = "Common key (n) :"
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(107, 57)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(165, 20)
        Me.txtKey.TabIndex = 1
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Location = New System.Drawing.Point(12, 60)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(77, 13)
        Me.lblKey.TabIndex = 26
        Me.lblKey.Text = "Public key (e) :"
        '
        'cmbDelim
        '
        Me.cmbDelim.FormattingEnabled = True
        Me.cmbDelim.Items.AddRange(New Object() {""", """, """,""", """; """, """;""", """ """, """\n""", """,\n""", """;\n"""})
        Me.cmbDelim.Location = New System.Drawing.Point(12, 228)
        Me.cmbDelim.Name = "cmbDelim"
        Me.cmbDelim.Size = New System.Drawing.Size(55, 21)
        Me.cmbDelim.TabIndex = 5
        '
        'frmEncrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cmbDelim)
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
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "frmEncrypt"
        Me.Text = "RSA Encryption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
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
    Friend WithEvents cmbDelim As System.Windows.Forms.ComboBox
End Class
