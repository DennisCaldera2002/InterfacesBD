Public Class frmMenuPpal
    Private Sub menuSalir_Click(sender As Object, e As EventArgs) Handles menuSalir.Click
        frmCredenciales.Close() 'Cerramos completamente la aplicación

    End Sub

    Private Sub menuUsuarios_Click(sender As Object, e As EventArgs) Handles menuUsuarios.Click
        Dim frmU As New frmUsuarios()
        frmU.Show()
    End Sub
End Class