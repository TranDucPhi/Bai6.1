Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim x1 As Single
        Dim x2 As Single
        a = Integer.Parse(txta.Text)
        b = Integer.Parse(txtb.Text)
        c = Integer.Parse(txtc.Text)
        If a = 0 Then
            x1 = -c / b
        Else
            Dim delta As Integer
            delta = b * b - 4 * a * c
            If delta < 0 Then
                MessageBox.Show("PT Vô Nghiệm")
            ElseIf delta = 0 Then
                x1 = -b / 2 * a
            Else
                x1 = (-b - Math.Sqrt(delta)) / (2 * a)
                x2 = -b + Math.Sqrt(delta) / (2 * a)
            End If

        End If
        txtx1.Text = x1
        txtx2.Text = x2

    End Sub
End Class
