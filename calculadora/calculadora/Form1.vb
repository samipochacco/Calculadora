Public Class Form1
    Private Sub suma_Click(sender As Object, e As EventArgs) Handles suma.Click
        Dim a, b As Integer
        a = numero1.Text
        b = numero2.Text
        resultado.Text = a + b
    End Sub

    Private Sub resta_Click(sender As Object, e As EventArgs) Handles resta.Click
        Dim a, b As Integer
        a = numero1.Text
        b = numero2.Text
        resultado.Text = a - b
    End Sub

    Private Sub multiplicacion_Click(sender As Object, e As EventArgs) Handles multiplicacion.Click
        Dim a, b As Integer
        a = numero1.Text
        b = numero2.Text
        resultado.Text = a * b
    End Sub

    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click
        Dim a, b As Integer
        a = numero1.Text
        b = numero2.Text
        resultado.Text = a / b
    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        numero1.Text = ""
        numero2.Text = ""
        resultado.Text = ""
    End Sub
End Class
