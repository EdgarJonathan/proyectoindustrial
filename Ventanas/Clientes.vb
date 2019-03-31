Public Class Clientes

    Dim resultado As MsgBoxResult
    Dim dtCliente As New DataTable
    Dim dtCliente1 As New DataTable
    Dim idClienteEdit As Integer
    Dim idClienteFree As Integer
    Sub mostrarClientes()
        Try
            Dim obj As New Consulta
            dtCliente = obj.obtenerCliente
            dtCliente1 = obj.obtenerCliente

            If dtCliente.Rows.Count <> 0 Then

                ComboBoxModificar.DataSource = dtCliente
                ComboBoxModificar.DisplayMember = "Nombre"
                ComboBoxModificar.ValueMember = "idCliente"

                ComboBoxEliminar.DataSource = dtCliente1
                ComboBoxEliminar.DisplayMember = "Nombre"
                ComboBoxEliminar.ValueMember = "idCliente"

                idClienteEdit = -1
                idClienteFree = -1
                limpiarText(Me)
            End If


        Catch ex As Exception
            MsgBox("sub Categorias: " + ex.Message)

        End Try

    End Sub
    Private Sub btnIngresarCliente_Click(sender As Object, e As EventArgs) Handles btnIngresarCliente.Click
        Try
            Dim consulta As New Consulta
            Dim logica As New Cliente

            logica.Nombre1 = Me.TextBoxNombreCliente.Text
            logica.Nit1 = Me.TextBoxNit.Text
            logica.Direccion1 = Me.TextBoxNombreCliente.Text
            logica.ClienteCol1 = "default"

            If consulta.insertarCliente(logica) Then
                mostrarClientes()
            End If


        Catch ex As Exception
            MsgBox("ingresando Categoria: " + ex.Message)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idClienteFree <> -1 Then
            Try
                Dim obj As New Consulta
                Dim logica As New Cliente

                logica.IdCliente1 = idClienteFree

                If obj.eliminarCliente(logica) Then
                    mostrarClientes()
                End If
            Catch ex As Exception
                MsgBox("Eliminando Ciente: " + ex.Message)

            End Try

        Else

            MsgBox(" No ha seleccionado un Cliente a eliminar")

        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If idClienteEdit <> -1 And TextBoxNombreCliente.Text <> "" Then
            Try
                Dim obj As New Consulta
                Dim logica As New Cliente

                logica.Nombre1 = Me.TextBoxNombreCliente.Text
                logica.Nit1 = Me.TextBoxNit.Text
                logica.Direccion1 = Me.TextBoxNombreCliente.Text
                logica.ClienteCol1 = "default"
                logica.IdCliente1 = idClienteEdit

                If obj.editarCliente(logica) Then
                    mostrarClientes()
                End If
            Catch ex As Exception
                MsgBox("Modficando Cliente: " + ex.Message)

            End Try

        Else

            MsgBox(" No ha seleccionado un Cliente a editar")

        End If
    End Sub

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

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        limpiarText(Me)
        idClienteEdit = -1
        idClienteFree = -1
    End Sub

    Private Sub Clientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Principal.Show()
    End Sub

    Private Sub ComboBoxEliminar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEliminar.SelectedIndexChanged
        Me.TextBoxNombreCliente.Text = ComboBoxEliminar.Text
        Me.TextBoxNit.Text = getValor(ComboBoxEliminar, "NIT")
        Me.TextBoxDireccion.Text = getValor(ComboBoxEliminar, "Direccion")
        idClienteFree = getId(ComboBoxEliminar, "idCliente")


    End Sub

    Private Sub ComboBoxModificar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxModificar.SelectedIndexChanged
        Me.TextBoxNombreCliente.Text = ComboBoxModificar.Text
        Me.TextBoxNit.Text = getValor(ComboBoxModificar, "NIT")
        Me.TextBoxDireccion.Text = getValor(ComboBoxModificar, "Direccion")
        idClienteEdit = getId(ComboBoxModificar, "idCliente")

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarClientes()
    End Sub
End Class