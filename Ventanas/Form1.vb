Imports MySql.Data.MySqlClient

Public Class Principal

    Dim mysqlconn As MySqlConnection

    Dim resultado As MsgBoxResult

    '--------------------------Sub rutinas--------------------------------


    Private Sub btnAdminProductos_Click(sender As Object, e As EventArgs) Handles btnAdminProductos.Click
        Me.Hide()
        productos.Show()
    End Sub

    Private Sub btnAdminCategoria_Click(sender As Object, e As EventArgs) Handles btnAdminCategoria.Click
        Me.Hide()
        Categorias.Show()
    End Sub

    Private Sub btnAdminMarca_Click(sender As Object, e As EventArgs) Handles btnAdminMarca.Click
        Me.Hide()
        Marcas.Show()
    End Sub

    Private Sub btnAdminCliente_Click(sender As Object, e As EventArgs) Handles btnAdminCliente.Click
        Me.Hide()
        Clientes.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        resultado = CType(MessageBox.Show("Desea salir de la aplicacion", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)

        If resultado = MsgBoxResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        resultado = CType(MessageBox.Show("Desea salir de la aplicacion", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)

        If resultado = MsgBoxResult.No Then

            e.Cancel = True

        Else
            e.Cancel = False

        End If


    End Sub

    Private Sub btnGestionVenta_Click(sender As Object, e As EventArgs) Handles btnGestionVenta.Click
        Me.Hide()
        GestionVenta.Show()
    End Sub

    Private Sub ConectarBDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConectarBDToolStripMenuItem.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;userid=root;password=guatemala;database=progra092"
        Try
            mysqlconn.Open()
            MsgBox("Conexion Exitosa")
            mysqlconn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            mysqlconn.Dispose()

        End Try


    End Sub
End Class
