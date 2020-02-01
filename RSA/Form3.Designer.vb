<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerator
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
        Me.cmbModes = New System.Windows.Forms.ComboBox()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.txtE = New System.Windows.Forms.TextBox()
        Me.lblN = New System.Windows.Forms.Label()
        Me.lblE = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.updOrder = New System.Windows.Forms.NumericUpDown()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnRest = New System.Windows.Forms.Button()
        CType(Me.updOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'cmbModes
        '
        Me.cmbModes.FormattingEnabled = True
        Me.cmbModes.Items.AddRange(New Object() {"Decrypt", "Encrypt", "Generate keys"})
        Me.cmbModes.Location = New System.Drawing.Point(12, 12)
        Me.cmbModes.Name = "cmbModes"
        Me.cmbModes.Size = New System.Drawing.Size(121, 21)
        Me.cmbModes.TabIndex = 8
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(83, 229)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(121, 20)
        Me.txtN.TabIndex = 5
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(151, 178)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(121, 20)
        Me.txtD.TabIndex = 4
        '
        'txtE
        '
        Me.txtE.Location = New System.Drawing.Point(12, 178)
        Me.txtE.Name = "txtE"
        Me.txtE.Size = New System.Drawing.Size(121, 20)
        Me.txtE.TabIndex = 3
        '
        'lblN
        '
        Me.lblN.Location = New System.Drawing.Point(80, 213)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(124, 13)
        Me.lblN.TabIndex = 43
        Me.lblN.Text = "Common key"
        Me.lblN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblE
        '
        Me.lblE.Location = New System.Drawing.Point(9, 162)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(124, 13)
        Me.lblE.TabIndex = 44
        Me.lblE.Text = "Public key"
        Me.lblE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblD
        '
        Me.lblD.Location = New System.Drawing.Point(148, 162)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(124, 13)
        Me.lblD.TabIndex = 45
        Me.lblD.Text = "Private key"
        Me.lblD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'updOrder
        '
        Me.updOrder.Location = New System.Drawing.Point(83, 77)
        Me.updOrder.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.updOrder.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.updOrder.Name = "updOrder"
        Me.updOrder.Size = New System.Drawing.Size(121, 20)
        Me.updOrder.TabIndex = 1
        Me.updOrder.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblOrder
        '
        Me.lblOrder.Location = New System.Drawing.Point(80, 57)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(124, 17)
        Me.lblOrder.TabIndex = 47
        Me.lblOrder.Text = "Orders of magnitude :"
        Me.lblOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(83, 117)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(121, 28)
        Me.btnProcess.TabIndex = 2
        Me.btnProcess.Text = "Create key pair"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnRest
        '
        Me.btnRest.Location = New System.Drawing.Point(226, 213)
        Me.btnRest.Name = "btnRest"
        Me.btnRest.Size = New System.Drawing.Size(46, 36)
        Me.btnRest.TabIndex = 6
        Me.btnRest.Text = "Other values"
        Me.btnRest.UseVisualStyleBackColor = True
        '
        'frmGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnRest)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.updOrder)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lblE)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.txtE)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.cmbModes)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "frmGenerator"
        Me.Text = "RSA Key pairs"
        CType(Me.updOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents cmbModes As System.Windows.Forms.ComboBox
    Friend WithEvents txtN As System.Windows.Forms.TextBox
    Friend WithEvents txtD As System.Windows.Forms.TextBox
    Friend WithEvents txtE As System.Windows.Forms.TextBox
    Friend WithEvents lblN As System.Windows.Forms.Label
    Friend WithEvents lblE As System.Windows.Forms.Label
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents updOrder As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnRest As System.Windows.Forms.Button
End Class
