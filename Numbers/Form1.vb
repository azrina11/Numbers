Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intNum As Integer
        If IsNumeric(txtInput.Text) Then
        End If
        intNum = txtInput.Text
            If (intNum Mod 2 <> 0) Then
            lblResult.Text = txtInput.Text & " is odd "
        Else
            lblResult.Text = txtInput.Text & " is even "
        End If
            txtInput.Text = " "
            txtInput.Focus()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub
End Class
