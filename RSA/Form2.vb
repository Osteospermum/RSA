Public Class frmEncrypt

    Private txtKeyVal As String

    Private Sub txtKey_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKey.KeyPress, txtKey2.KeyPress
        txtKeyVal = sender.Text
    End Sub

    Private Sub txtKey_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKey.TextChanged, txtKey2.TextChanged
        If IsNumeric(sender.Text) = False And sender.Text.Length > 0 Then
            sender.Text = txtKeyVal
            sender.SelectionStart = sender.Text.Length
        End If
    End Sub

    Private Sub cmbResultChoices_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbResultChoices.KeyPress, cmbModes.KeyPress, cmbDelim.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtKey.Clear()
        txtKey2.Clear()
        txtMessage.Clear()
        txtResult.Clear()
        cmbResultChoices.SelectedIndex = -1
        cmbResultChoices.Text = "Plaintext format"
        cmbDelim.SelectedIndex = -1
        cmbDelim.Text = ""
        cmbModes.SelectedIndex = 1
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        txtResult.Clear()
        Try
            'Verify validity of input
            Dim valid As Boolean = True
            If txtKey.Text.Length = 0 Or txtKey2.Text.Length < 3 Or txtMessage.Text.Length = 0 Or cmbResultChoices.SelectedIndex = -1 Or cmbDelim.SelectedIndex = -1 Then
                valid = False
            End If

            If valid = True Then
                Dim hexStr As String = ""
                Dim decStr As String = ""
                Dim partLen As Integer = txtKey2.Text.Length - 1
                Dim parts() As System.Numerics.BigInteger
                Dim partsResult() As System.Numerics.BigInteger
                If cmbResultChoices.SelectedIndex = 0 Then
                    For Each c As Char In txtMessage.Text
                        hexStr += Convert.ToString(Convert.ToInt32(c), 16)
                    Next
                ElseIf cmbResultChoices.SelectedIndex = 1 Then
                    hexStr = txtMessage.Text
                ElseIf cmbResultChoices.SelectedIndex = 2 Then
                    decStr = txtMessage.Text
                End If
                If cmbResultChoices.SelectedIndex < 2 Then
                    decStr = Convert.ToString(System.Numerics.BigInteger.Parse(hexStr, Globalization.NumberStyles.HexNumber))
                End If

                ReDim parts(Math.Ceiling(decStr.Length / partLen) - 1)
                For i As Integer = 0 To decStr.Length Step partLen
                    If i + partLen > decStr.Length Then
                        parts((i / partLen)) = System.Numerics.BigInteger.Parse(decStr.Substring(i))
                    Else
                        parts(i / partLen) = System.Numerics.BigInteger.Parse(decStr.Substring(i, partLen))
                    End If
                Next

                ReDim partsResult(parts.Length - 1)
                Dim keyE As System.Numerics.BigInteger = System.Numerics.BigInteger.Parse(txtKey.Text)
                Dim keyN As System.Numerics.BigInteger = System.Numerics.BigInteger.Parse(txtKey2.Text)
                For i As Integer = 0 To parts.Length - 1
                    partsResult(i) = System.Numerics.BigInteger.ModPow(parts(i), keyE, keyN)
                Next

                Dim delim As String = ""
                Select Case cmbDelim.SelectedIndex
                    Case 0
                        delim = ", "
                    Case 1
                        delim = ","
                    Case 2
                        delim = "; "
                    Case 3
                        delim = ";"
                    Case 4
                        delim = " "
                    Case 5
                        delim = vbCrLf
                    Case 6
                        delim = "," & vbCrLf
                    Case 7
                        delim = ";" & vbCrLf
                End Select

                For Each s As System.Numerics.BigInteger In partsResult
                    txtResult.Text += s.ToString + delim
                Next
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - delim.Length)
            Else
                'Notify user of invalid entry
                MessageBox.Show("Invalid entry")
            End If
        Catch ex As Exception
            'If an error occures, display the message
            MessageBox.Show("Error : " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub cmbModes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbModes.SelectedIndexChanged
        If cmbModes.SelectedIndex = 0 Then
            frmDecrypt.Show()
            frmDecrypt.Location = Me.Location
            btnReset.PerformClick()
            Me.Hide()
        ElseIf cmbModes.SelectedIndex = 2 Then
            frmGenerator.Show()
            frmGenerator.Location = Me.Location
            btnReset.PerformClick()
            Me.Hide()
        End If
    End Sub

    Private Sub frmEncrypt_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        cmbModes.SelectedIndex = 1
    End Sub

    Private Sub frmEncrypt_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmDecrypt.Close()
    End Sub
End Class