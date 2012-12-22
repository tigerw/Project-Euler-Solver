Public Class _3

    Dim currentlyfactorising As Integer
    Dim factor As Integer = 3
    Dim numofitems As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Try
            currentlyfactorising = TextBox1.Text
            Do While currentlyfactorising Mod 2 = 0
                currentlyfactorising = TextBox1.Text / 2
                numofitems += 1
                With ListBox1.Items
                    .Add(2)
                End With
            Loop
            Do While factor * factor <= currentlyfactorising
                If currentlyfactorising Mod factor = 0 Then
                    With ListBox1.Items
                        .Add(factor)
                    End With
                    currentlyfactorising \= factor
                    numofitems += 1
                Else : factor += 2
                End If
            Loop
            If currentlyfactorising > 1 Then
                With ListBox1.Items
                    .Add(currentlyfactorising)
                End With
                numofitems += 1
            End If
            ListBox1.SetSelected(numofitems - 1, True)
            Dim i As String = Convert.ToString(ListBox1.SelectedItem)
            MsgBox("The largest prime number is " + i, MsgBoxStyle.Information)
        Catch ex As InvalidCastException
            MsgBox("Only numbers can be entered into the input box!", MsgBoxStyle.Exclamation)
        Catch ex As OverflowException
            MsgBox("Too large a number was entered, try smaller.", MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class