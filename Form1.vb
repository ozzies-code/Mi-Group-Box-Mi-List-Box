Public Class Form1
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim persona As String = txtNombres.Text & " " & txtApellidos.Text
        liPersonas.Items.Add(persona)

        txtNombres.Clear()
        txtApellidos.Clear()

    End Sub

    Private Sub btnMensaje_Click(sender As Object, e As EventArgs) Handles btnMensaje.Click

        Dim personas As String = TryCast(liPersonas.SelectedItem, String)
        'convierte un objeto a una cadena con TryCast
        MsgBox(personas)

    End Sub
End Class
