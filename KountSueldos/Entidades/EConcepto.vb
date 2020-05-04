Public Class EConcepto
    Private _id_concepto As Integer
    Private _descripcion As String
    Private _valor As Decimal
    Private _estadobaja As Boolean
    Private _tipoconcepto As Integer
    Private _codigo As Integer
    Private _estado As Char


    Public Property id_concepto As Integer
        Get
            Return _id_concepto
        End Get
        Set(value As Integer)
            _id_concepto = value
        End Set
    End Property

    Public Property tipoconcepto As Integer
        Get
            Return _tipoconcepto
        End Get
        Set(value As Integer)
            _tipoconcepto = value
        End Set
    End Property

    Public Property descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property valor As Decimal
        Get
            Return _valor
        End Get
        Set(value As Decimal)
            _valor = value
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
    Public Property estado As Char
        Get
            Return _estado
        End Get
        Set(value As Char)
            _estado = value
        End Set
    End Property

    Public Property codigo As Integer
        Get
            Return _codigo
        End Get
        Set(value As Integer)
            _codigo = value
        End Set
    End Property

End Class
