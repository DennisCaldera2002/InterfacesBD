Public Class frmCredenciales
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Me.Hide() 'ocultamos el form1
        Dim frmp As New frmMenuPpal()
        frmp.Show() 'visualizamos el formPpal
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub
End Class
