Public Class Marcas
    Dim dtMarca As New DataTable
    Dim dtMarca1 As New DataTable
    Dim resultado As MsgBoxResult

    Dim idMarcaEdit As Integer
    Dim idMarcaFree As Integer

    Sub mostrarMarcas()
        Try
            Dim obj As New Consulta
            dtMarca = obj.obtenerMarca
            dtMarca1 = obj.obtenerMarca

            If dtMarca.Rows.Count <> 0 Then

                ComboBoxModificar.DataSource = dtMarca
                ComboBoxModificar.DisplayMember = "Marca"
                ComboBoxModificar.ValueMember = "idMarca"

                ComboBoxEliminar.DataSource = dtMarca1
                ComboBoxEliminar.DisplayMember = "Marca"
                ComboBoxEliminar.ValueMember = "idMarca"

                limpiarText(Me)
            End If


        Catch ex As Exception
            MsgBox("sub Mostrar Marcas: " + ex.Message)

        End Try

    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idMarcaFree <> -1 Then
            Try
                Dim obj As New Consulta
                Dim logica As New Marca

                logica.IdMarca1 = idMarcaFree

                If obj.eliminarMarca(logica) Then
                    mostrarMarcas()
                End If
            Catch ex As Exception
                MsgBox("Modficando Marca: " + ex.Message)

            End Try

        Else

            MsgBox(" No ha seleccionado una Marca a eliminar")

        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If idMarcaEdit <> -1 And textMarca.Text <> "" Then
            Try
                Dim obj As New Consulta
                Dim logica As New Marca

                logica.Marca1 = Me.textMarca.Text
                logica.IdMarca1 = idMarcaEdit

                If obj.editarMarca(logica) Then
                    mostrarMarcas()
                End If
            Catch ex As Exception
                MsgBox("Modficando Marcas: " + ex.Message)

            End Try

        Else

            MsgBox(" No ha seleccionado una Marca a editar")

        End If
    End Sub

    Private Sub btnIngresarMarca_Click(sender As Object, e As EventArgs) Handles btnIngresarMarca.Click
        Try
            Dim consulta As New Consulta
            Dim logica As New Marca

            logica.Marca1 = Me.textMarca.Text

            If consulta.insertarMarca(logica) Then
                mostrarMarcas()
            End If


        Catch ex As Exception
            MsgBox("ingresando Marca: " + ex.Message)
        End Try
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

    Private Sub Marcas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Principal.Show()
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        limpiarText(Me)
        idMarcaEdit = -1
        idMarcaFree = -1
    End Sub

    Private Sub Marcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarMarcas()

    End Sub

    Private Sub ComboBoxEliminar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEliminar.SelectedIndexChanged
        idMarcaFree = CInt(CType(ComboBoxEliminar.DataSource, DataTable).Rows(ComboBoxEliminar.SelectedIndex)("idMarca").ToString)

    End Sub

    Private Sub ComboBoxModificar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxModificar.SelectedIndexChanged
        Me.textMarca.Text = ComboBoxModificar.Text
        idMarcaEdit = CInt(CType(ComboBoxModificar.DataSource, DataTable).Rows(ComboBoxModificar.SelectedIndex)("idMarca").ToString)

    End Sub
End Class