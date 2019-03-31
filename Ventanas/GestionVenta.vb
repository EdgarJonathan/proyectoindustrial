Public Class GestionVenta

    Dim resultado As MsgBoxResult
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        resultado = CType(MessageBox.Show("Desea salir de la aplicacion", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)

        If resultado = MsgBoxResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub GestionVenta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Principal.Show()
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        limpiarText(Me)
    End Sub
End Class