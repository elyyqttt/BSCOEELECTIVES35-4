Public Class Form1


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        tb.Text = tb.Text + 1

        If tb.Text = 2 Then
            pb1.BackColor = Color.Black
            pb2.BackColor = Color.DarkRed
            pb3.BackColor = Color.DarkRed
            pb4.BackColor = Color.Black
            pb5.BackColor = Color.Black
            pb6.BackColor = Color.Black
            pb7.BackColor = Color.Black

        ElseIf tb.Text = 3 Then
            pb1.BackColor = Color.DarkRed
            pb2.BackColor = Color.DarkRed
            pb3.BackColor = Color.Black
            pb7.BackColor = Color.DarkRed
            pb4.BackColor = Color.DarkRed
            pb5.BackColor = Color.DarkRed
            pb6.BackColor = Color.Black

        ElseIf tb.Text = 4 Then
            pb1.BackColor = Color.DarkRed
            pb2.BackColor = Color.DarkRed
            pb3.BackColor = Color.DarkRed
            pb4.BackColor = Color.DarkRed
            pb5.BackColor = Color.Black
            pb6.BackColor = Color.Black
            pb7.BackColor = Color.DarkRed

        ElseIf tb.Text = 5 Then
            pb1.BackColor = Color.Black
            pb2.BackColor = Color.DarkRed
            pb3.BackColor = Color.DarkRed
            pb4.BackColor = Color.Black
            pb5.BackColor = Color.Black
            pb6.BackColor = Color.DarkRed
            pb7.BackColor = Color.DarkRed

        ElseIf tb.Text = 6 Then
            pb1.BackColor = Color.DarkRed
            pb2.BackColor = Color.Black
            pb3.BackColor = Color.DarkRed
            pb4.BackColor = Color.DarkRed
            pb5.BackColor = Color.Black
            pb6.BackColor = Color.DarkRed
            pb7.BackColor = Color.DarkRed

        ElseIf tb.Text = 7 Then
            pb1.BackColor = Color.DarkRed
            pb2.BackColor = Color.Black
            pb3.BackColor = Color.DarkRed
            pb4.BackColor = Color.DarkRed
            pb5.BackColor = Color.DarkRed
            pb6.BackColor = Color.DarkRed
            pb7.BackColor = Color.DarkRed

        ElseIf tb.Text = 8 Then
            pb6.BackColor = Color.DarkRed
            pb1.BackColor = Color.DarkRed
            pb2.BackColor = Color.DarkRed
            pb3.BackColor = Color.DarkRed
            pb4.BackColor = Color.Black
            pb5.BackColor = Color.Black
            pb7.BackColor = Color.Black

        ElseIf tb.Text = 9 Then
            pb1.BackColor = Color.DarkRed
            pb2.BackColor = Color.DarkRed
            pb3.BackColor = Color.DarkRed
            pb4.BackColor = Color.DarkRed
            pb5.BackColor = Color.DarkRed
            pb6.BackColor = Color.DarkRed
            pb7.BackColor = Color.DarkRed

        ElseIf tb.Text = 10 Then
            pb1.BackColor = Color.DarkRed
            pb2.BackColor = Color.DarkRed
            pb3.BackColor = Color.DarkRed
            pb4.BackColor = Color.DarkRed
            pb5.BackColor = Color.Black
            pb6.BackColor = Color.DarkRed
            pb7.BackColor = Color.DarkRed

        ElseIf tb.Text = 11 Then
            pb1.BackColor = Color.DarkRed
            pb2.BackColor = Color.DarkRed
            pb3.BackColor = Color.DarkRed
            pb4.BackColor = Color.DarkRed
            pb5.BackColor = Color.DarkRed
            pb6.BackColor = Color.DarkRed
            pb7.BackColor = Color.Black
        End If

        Timer1.Interval = 1000

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
