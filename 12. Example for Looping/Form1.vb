Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Counter As Integer
        For Counter = 1 To 10
            ListBox1.Items.Add(Counter)
        Next


    End Sub
End Class
