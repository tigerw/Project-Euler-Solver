Public Class _1
    Dim total As Integer
    Dim current As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Do Until current = 1000
            If current Mod 3 = 0 Or current Mod 5 = 0 Then
                total += current
                current += 1
            Else
                current += 1
            End If
        Loop
        'For current = 0 To 10
        '    If current Mod 3 = 0 Or current Mod 5 = 0 Then
        '        total += current
        '    End If
        'Next current
        Label1.Text = total
    End Sub
End Class