Imports MySql.Data.MySqlClient
Public Class Categorias
    Dim dtCategoria As New DataTable
    Dim dtCategoria1 As New DataTable

    Dim idCategoriaEdit As Integer
    Dim idCategoriaFree As Integer

    Dim resultado As MsgBoxResult


    '--------------------------------------Subrutinas----------:v
    Sub Categorias()
        Try
            Dim obj As New Consulta
            dtCategoria = obj.obtenerCategoria
            dtCategoria1 = obj.obtenerCategoria

            If dtCategoria.Rows.Count <> 0 Then

                ComboBoxModificar.DataSource = dtCategoria
                ComboBoxModificar.DisplayMember = "Categoria"
                ComboBoxModificar.ValueMember = "idCategoria"

                ComboBoxEliminar.DataSource = dtCategoria1
                ComboBoxEliminar.DisplayMember = "Categoria"
                ComboBoxEliminar.ValueMember = "idCategoria"

                limpiarText(Me)
            End If


        Catch ex As Exception
            MsgBox("sub Categorias: " + ex.Message)

        End Try

    End Sub



    Private Sub btnIngresarCategoria_Click(sender As Object, e As EventArgs) Handles btnIngresarCategoria.Click
        Try
            Dim consulta As New Consulta
            Dim logica As New Categoria

            logica.gCategoria = Me.textCategoria.Text

            If consulta.insertCategoria(logica) Then
                Categorias()
            End If


        Catch ex As Exception
            MsgBox("ingresando Categoria: " + ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idCategoriaFree <> -1 Then
            Try
                Dim obj As New Consulta
                Dim logica As New Categoria

                logica.gIdCategoria = idCategoriaFree

                If obj.eliminarCategoria(logica) Then
                    Categorias()
                End If
            Catch ex As Exception
                MsgBox("Eliminando Categoria: " + ex.Message)

            End Try

        Else

            MsgBox(" No ha seleccionado una categoria a eliminar")

        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If idCategoriaEdit <> -1 And textCategoria.Text <> "" Then
            Try
                Dim obj As New Consulta
                Dim logica As New Categoria

                logica.gCategoria = Me.textCategoria.Text
                logica.gIdCategoria = idCategoriaEdit

                If obj.editarCategoria(logica) Then
                    Categorias()
                End If
            Catch ex As Exception
                MsgBox("Modficando Categoria: " + ex.Message)

            End Try

        Else

            MsgBox(" No ha seleccionado una categoria a editar")

        End If
    End Sub

    Private Sub Categorias_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Principal.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        resultado = CType(MessageBox.Show("Desea salir de la aplicacion", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        limpiarText(Me)
        idCategoriaEdit = -1
        idCategoriaFree = -1
    End Sub

    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Categorias()

    End Sub

    Private Sub ComboBoxModificar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxModificar.SelectedIndexChanged
        Me.textCategoria.Text = ComboBoxModificar.Text
        idCategoriaEdit = getId(ComboBoxModificar, "idCategoria")
    End Sub

    Private Sub ComboBoxEliminar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEliminar.SelectedIndexChanged
        idCategoriaFree = getId(ComboBoxEliminar, "idCategoria")
    End Sub
End Class