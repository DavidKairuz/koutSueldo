Public Class EBanco
    Private _id_banco As Integer
    Private _nombre As String
    Private _direccion As String
    Private _telefono As String
    Private _sucursalb As Integer
    Private _email As String
    Private _estadobaja As Boolean




    Public Property id_banco As Integer
        Get
            Return _id_banco
        End Get
        Set(value As Integer)
            _id_banco = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property sucursalb As Decimal
        Get
            Return _sucursalb
        End Get
        Set(value As Decimal)
            _sucursalb = value
        End Set
    End Property

    Public Property estadobaja As Boolean
        Get
            Return _estadobaja
        End Get
        Set(value As Boolean)
            _estadobaja = value
        End Set
    End Property
    Public Property email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
End Class
