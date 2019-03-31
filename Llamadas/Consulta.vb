Imports MySql.Data.MySqlClient
Public Class Consulta

    Inherits Conexion
    Dim cmd As New MySqlCommand

    Public Function obtenerCategoria() As DataTable
        Try
            Conectado()
            cmd = New MySqlCommand("obtenerTablaCategoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            MsgBox("Consulta Categoria: " + ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try

    End Function

    Public Function insertCategoria(ByVal dato As Categoria) As Boolean
        Try
            Conectado()
            cmd = New MySqlCommand("insertarCategoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("miCategoria", dato.gCategoria)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("insertar Categoria: " + ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try

    End Function


    Public Function editarCategoria(ByVal dato As Categoria) As Boolean

        Try
            Conectado()
            cmd = New MySqlCommand("editarCategoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("miIdCategoria", dato.gIdCategoria)
            cmd.Parameters.AddWithValue("miCategoria", dato.gCategoria)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Editar categoria: " + ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try

    End Function

    Public Function eliminarCategoria(ByVal dato As Categoria) As Boolean
        Try
            Conectado()
            cmd = New MySqlCommand("eliminarCategoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("miIdCategoria", dato.gIdCategoria)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Eliminar categoria: " + ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try
    End Function


    Public Function obtenerMarca() As DataTable
        Try
            Conectado()
            cmd = New MySqlCommand("cargarMarca")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            MsgBox("Consulta Cargar Marca: " + ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try

    End Function

    Public Function insertarMarca(ByVal dato As Marca) As Boolean
        Try
            Conectado()
            cmd = New MySqlCommand("insertarMarca")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("miMarca", dato.Marca1)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("insertar Marca: " + ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try

    End Function


    Public Function editarMarca(ByVal dato As Marca) As Boolean

        Try
            Conectado()
            cmd = New MySqlCommand("editarMarca")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("miIdMarca", dato.IdMarca1)
            cmd.Parameters.AddWithValue("miMarca", dato.Marca1)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Editar Marca: " + ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try

    End Function


    Public Function eliminarMarca(ByVal dato As Marca) As Boolean
        Try
            Conectado()
            cmd = New MySqlCommand("eliminarMarca")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("miIdMarca", dato.IdMarca1)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Eliminar  Marca: " + ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try
    End Function


    Public Function obtenerCliente() As DataTable
        Try
            Conectado()
            cmd = New MySqlCommand("cargarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            MsgBox("Consulta Cargar Cliente: " + ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try

    End Function


    Public Function insertarCliente(ByVal dato As Cliente) As Boolean
        Try
            Conectado()
            cmd = New MySqlCommand("insertarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("miNombre", dato.Nombre1)
            cmd.Parameters.AddWithValue("miNIT", dato.Nit1)
            cmd.Parameters.AddWithValue("miDir", dato.Direccion1)
            cmd.Parameters.AddWithValue("miClienteCol", dato.ClienteCol1)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("insertar Cliente: " + ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try

    End Function


    Public Function editarCliente(ByVal dato As Cliente) As Boolean

        Try
            Conectado()
            cmd = New MySqlCommand("editarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("miIdCliente", dato.IdCliente1)
            cmd.Parameters.AddWithValue("miNombre", dato.Nombre1)
            cmd.Parameters.AddWithValue("miNIT", dato.Nit1)
            cmd.Parameters.AddWithValue("miDir", dato.Direccion1)
            cmd.Parameters.AddWithValue("miClienteCol", dato.ClienteCol1)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Editar Marca: " + ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try

    End Function

    Public Function eliminarCliente(ByVal dato As Cliente) As Boolean
        Try
            Conectado()
            cmd = New MySqlCommand("eliminarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("miIdCliente", dato.IdCliente1)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Eliminar  Cliente: " + ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try
    End Function


End Class
