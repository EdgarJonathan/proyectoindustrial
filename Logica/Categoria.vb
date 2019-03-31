Public Class Categoria
    Private categoria As String
    Private idCategoria As Integer


    ' para generar los getter y setter  
    'seleccionar atributo a encapsular
    ' presionarl ctrl
    'y rapidadmente R y E y 
    'apareceran las opciones 

    Public Property gCategoria As String
        Get
            Return categoria
        End Get
        Set(value As String)
            categoria = value
        End Set
    End Property

    Public Property gIdCategoria As Integer
        Get
            Return idCategoria
        End Get
        Set(value As Integer)
            idCategoria = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ByVal categoria As String)
        gCategoria = categoria
        gIdCategoria = -1

    End Sub
    Public Sub New(ByVal categoria As String, ByVal id As Integer)
        gCategoria = categoria
        gIdCategoria = id

    End Sub
End Class
