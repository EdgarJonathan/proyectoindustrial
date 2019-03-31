Public Class productos
    Dim resultado As MsgBoxResult

    Dim dtCategoria As New DataTable
    Dim dtMarca As New DataTable

    '--------------------------------------Subrutinas----------:v
    Sub Categorias()
        Try
            Dim obj As New Consulta
            dtCategoria = obj.obtenerCategoria

            If dtCategoria.Rows.Count <> 0 Then

                ComboBoxCategoria.DataSource = dtCategoria
                ComboBoxCategoria.DisplayMember = "Categoria"
                ComboBoxCategoria.ValueMember = "idCategoria"
            End If


        Catch ex As Exception
            MsgBox("sub Categorias: " + ex.Message)

        End Try

    End Sub

    Sub mostrarMarcas()
        Try
            Dim obj As New Consulta
            dtMarca = obj.obtenerMarca


            If dtMarca.Rows.Count <> 0 Then
                ComboBoxMarca.DataSource = dtMarca
                ComboBoxMarca.DisplayMember = "Marca"
                ComboBoxMarca.ValueMember = "idMarca"


            End If


        Catch ex As Exception
            MsgBox("sub Mostrar Marcas: " + ex.Message)

        End Try

    End Sub

    Sub clean()
        limpiarText(Me)
        RichTextBox1.Text = ""
    End Sub
    Sub cargarDatos()
        Categorias()
        mostrarMarcas()
        clean()

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

    Private Sub productos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Principal.Show()
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        clean()

    End Sub

    Private Sub productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()

    End Sub
End Class