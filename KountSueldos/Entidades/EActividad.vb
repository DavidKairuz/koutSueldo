Public Class EActividad
    Private _id_actividad As Integer
    Private _id_convenio As Integer
    Private _descripcion As String
    Private _valor As Decimal
    Private _estadobaja As Boolean
    Private _id_categoria As Integer



    Public Property id_actividad As Integer
        Get
            Return _id_actividad
        End Get
        Set(value As Integer)
            _id_actividad = value
        End Set
    End Property

    Public Property id_convenio As Integer
        Get
            Return _id_convenio
        End Get
        Set(value As Integer)
            _id_convenio = value
        End Set
    End Property
    Public Property id_categoria As Integer
        Get
            Return _id_categoria
        End Get
        Set(value As Integer)
            _id_categoria = value
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
End Class
