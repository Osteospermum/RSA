Public Class frmDecrypt

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

    Private Sub cmbResultChoices_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbResultChoices.KeyPress, cmbModes.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtKey.Clear()
        txtKey2.Clear()
        txtMessage.Clear()
        txtResult.Clear()
        cmbResultChoices.SelectedIndex = -1
        cmbResultChoices.Text = "Result format"
        cmbModes.SelectedIndex = 0
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        txtResult.Clear()
        Try
            'Verify validity of input
            Dim parts() As String = txtMessage.Text.Split(New String() {" ", ",", ";", Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            Dim valid As Boolean = True
            If txtKey.Text.Length = 0 Or txtKey2.Text.Length = 0 Or parts.Length = 0 Or cmbResultChoices.SelectedIndex = -1 Then
                valid = False
            End If
            For Each s As String In parts
                If IsNumeric(s) = False Then
                    valid = False
                End If
            Next

            If valid = True Then
                'Dims
                Dim d As Numerics.BigInteger = Numerics.BigInteger.Parse(txtKey.Text)
                Dim n As Numerics.BigInteger = Numerics.BigInteger.Parse(txtKey2.Text)
                Dim partsVal(parts.Length - 1) As System.Numerics.BigInteger
                Dim resultLen As Integer = 0
                Dim resultParts(parts.Length - 1) As String
                Dim result As String = ""

                'Process the message fragments 
                For i As Integer = 0 To parts.Length - 1
                    partsVal(i) = System.Numerics.BigInteger.ModPow(System.Numerics.BigInteger.Parse(parts(i)), d, n)
                Next
                'Format the message fragments (for decrypting)
                For Each s As System.Numerics.BigInteger In partsVal
                    If s.ToString.Length > resultLen Then
                        resultLen = s.ToString.Length
                    End If
                Next
                For i As Integer = 0 To parts.Length - 2
                    resultParts(i) = partsVal(i).ToString("D" & resultLen.ToString)
                Next
                resultParts(parts.Length - 1) = partsVal(parts.Length - 1).ToString

                If cmbResultChoices.SelectedIndex = 2 Then
                    'Display the result as decimal
                    txtResult.Text = String.Join("", resultParts)

                ElseIf cmbResultChoices.SelectedIndex = 1 Then
                    'Display the result as hexadecimal
                    Dim hexStr As String = System.Numerics.BigInteger.Parse(String.Join("", resultParts)).ToString("X")
                    Dim hexResult As String = ""

                    For i As Integer = 0 To hexStr.Length - 1 Step 2
                        hexResult += hexStr.Substring(i, 2) & " "
                    Next
                    txtResult.Text = hexResult

                ElseIf cmbResultChoices.SelectedIndex = 0 Then
                    'Display the result as ascii
                    Dim hexStr As String = System.Numerics.BigInteger.Parse(String.Join("", resultParts)).ToString("X")
                    Dim asciiResult As String = ""
                    For i As Integer = 0 To hexStr.Length - 1 Step 2
                        asciiResult += Convert.ToChar(Convert.ToInt32(hexStr.Substring(i, 2), 16))
                    Next
                    txtResult.Text = asciiResult
                End If
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
        If cmbModes.SelectedIndex = 1 Then
            frmEncrypt.Show()
            frmEncrypt.Location = Me.Location
            btnReset.PerformClick()
            Me.Hide()
        ElseIf cmbModes.SelectedIndex = 2 Then
            frmGenerator.Show()
            frmGenerator.Location = Me.Location
            btnReset.PerformClick()
            Me.Hide()
        End If
    End Sub

    Private Sub frmDecrypt_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        cmbModes.SelectedIndex = 0
    End Sub
End Class
