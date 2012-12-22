Public Class _2

    Dim firstnum As Long = 1
    Dim secondnum As Long = 2
    Dim store As Long
    Dim currentselected As Long
    Dim result As Long

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Do While store <= 4000000
            'There seems to be an issue here where VSE lets this code run once more when
            'it detects store <= 4000000, so there is a result bigger than the aformented
            'value. Hm.
            store = firstnum + secondnum
            With ListBox1.Items
                .Add(store)
            End With
            firstnum = secondnum
            secondnum = store
        Loop
        Do Until currentselected = 32
            ListBox1.SetSelected(currentselected, True)
            If ListBox1.SelectedItem Mod 2 = 0 Then
                result += ListBox1.SelectedItem
                currentselected += 1
            Else : currentselected += 1
            End If
        Loop
        Label1.Text = result
    End Sub

    Private Sub _2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ListBox1.Items
            .Add(1)
            .Add(2)
        End With
    End Sub
End Class