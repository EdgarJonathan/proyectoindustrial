Public Class Marca
    Dim Marca As String
    Dim idMarca As Integer

    Public Property Marca1 As String
        Get
            Return Marca
        End Get
        Set(value As String)
            Marca = value
        End Set
    End Property

    Public Property IdMarca1 As Integer
        Get
            Return idMarca
        End Get
        Set(value As Integer)
            idMarca = value
        End Set
    End Property

    Public Sub New()
    End Sub

End Class
