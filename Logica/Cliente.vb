Public Class Cliente

    Dim idCliente As Integer
    Dim Nombre As String
    Dim Nit As String
    Dim Direccion As String
    Dim ClienteCol As String

    Public Property IdCliente1 As Integer
        Get
            Return idCliente
        End Get
        Set(value As Integer)
            idCliente = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property Nit1 As String
        Get
            Return Nit
        End Get
        Set(value As String)
            Nit = value
        End Set
    End Property

    Public Property Direccion1 As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property

    Public Property ClienteCol1 As String
        Get
            Return ClienteCol
        End Get
        Set(value As String)
            ClienteCol = value
        End Set
    End Property

End Class
