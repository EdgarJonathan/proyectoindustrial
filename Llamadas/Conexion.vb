Imports MySql.Data.MySqlClient
Public Class Conexion
    Protected con As MySqlConnection

    Public Function Conectado()
        Try
            con = New MySqlConnection
            con.ConnectionString = "server=localhost;userid=root;password=guatemala;database=progra092"
            con.Open()
            Return True
        Catch ex As MySqlException
            MsgBox("0: " + ex.Message)
            Return False
        End Try

    End Function

    Public Function Desconectado()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
                Return Nothing
            End If
            Return Nothing
        Catch ex As MySqlException
            MsgBox("iniciando Conexion: " + ex.Message)
            Return Nothing
        Finally
            con.Dispose()
        End Try
    End Function

End Class
