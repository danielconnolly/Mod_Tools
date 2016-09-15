Imports GCExt

Public Class Webbing_Mods
    Private Sub txtWebX_TextChanged(sender As Object, e As EventArgs) Handles txtWebX.TextChanged
        Dim selStart As Integer = txtWebX.SelectionStart
        Dim selMoveLeft As Integer = 0
        Dim newStr As String = "" 'Build a new string by copying each valid character from the existing string. The new string starts as blank and valid characters are added 1 at a time.

        For i As Integer = 0 To txtWebX.Text.Length - 1

            If "0123456789".IndexOf(txtWebX.Text(i)) <> -1 Then 'Characters that are in the allowed set will be added to the new string.
                newStr = newStr & txtWebX.Text(i)

            ElseIf i < selStart Then 'Characters that are not valid are removed - if these characters are before the cursor, we need to move the cursor left to account for their removal.
                selMoveLeft = selMoveLeft + 1

            End If
        Next

        txtWebX.Text = newStr 'Place the new text into the textbox.
        txtWebX.SelectionStart = selStart - selMoveLeft 'Move the cursor to the appropriate location.
    End Sub

    Private Sub txtWebY_TextChanged(sender As Object, e As EventArgs) Handles txtWebY.TextChanged
        Dim selStart As Integer = txtWebY.SelectionStart
        Dim selMoveLeft As Integer = 0
        Dim newStr As String = "" 'Build a new string by copying each valid character from the existing string. The new string starts as blank and valid characters are added 1 at a time.

        For i As Integer = 0 To txtWebY.Text.Length - 1

            If "0123456789".IndexOf(txtWebY.Text(i)) <> -1 Then 'Characters that are in the allowed set will be added to the new string.
                newStr = newStr & txtWebY.Text(i)

            ElseIf i < selStart Then 'Characters that are not valid are removed - if these characters are before the cursor, we need to move the cursor left to account for their removal.
                selMoveLeft = selMoveLeft + 1

            End If
        Next

        txtWebY.Text = newStr 'Place the new text into the textbox.
        txtWebY.SelectionStart = selStart - selMoveLeft 'Move the cursor to the appropriate location.
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Gf.SplitPads(GCB_PADSPLIT_PATTERN.PLUS, txtWebX.Text, txtWebY.Text, GCB_PADSPLIT_CRITERIA.GAP_WIDTH, New EDistance(txtGap.Text), New EDistance(0), False, chkScan.Checked)
        Apr.IsVisible = False
        Me.Close()
    End Sub

    Private Sub txtGap_TextChanged(sender As Object, e As EventArgs) Handles txtGap.TextChanged
        Dim selStart As Integer = txtWebY.SelectionStart
        Dim selMoveLeft As Integer = 0
        Dim newStr As String = "" 'Build a new string by copying each valid character from the existing string. The new string starts as blank and valid characters are added 1 at a time.

        For i As Integer = 0 To txtWebY.Text.Length - 1

            If "0123456789.".IndexOf(txtWebY.Text(i)) <> -1 Then 'Characters that are in the allowed set will be added to the new string.
                newStr = newStr & txtWebY.Text(i)

            ElseIf i < selStart Then 'Characters that are not valid are removed - if these characters are before the cursor, we need to move the cursor left to account for their removal.
                selMoveLeft = selMoveLeft + 1

            End If
        Next

        txtWebY.Text = newStr 'Place the new text into the textbox.
        txtWebY.SelectionStart = selStart - selMoveLeft 'Move the cursor to the appropriate location.
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Webbing_Mods_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class