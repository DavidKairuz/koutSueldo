Public Class EContrato
    Private _id_contrato As Integer
    Private _fechac As Date
    Private _descripcion As String
    Private _periodo As Integer
    Private _estadobaja As Boolean
    Private _fecha_emision As Date
    Private _fecha_vencimiento As Date
    Private _tipo As Integer
    Private _idempleado As Integer




    Public Property fechac As Date
        Get
            Return _fechac
        End Get
        Set(value As Date)
            _fechac = value
        End Set
    End Property

    Public Property fecha_emision As Date
        Get
            Return _fecha_emision
        End Get
        Set(value As Date)
            _fecha_emision = value
        End Set
    End Property

    Public Property fecha_vencimiento As Date
        Get
            Return _fecha_vencimiento
        End Get
        Set(value As Date)
            _fecha_vencimiento = value
        End Set
    End Property
    Public Property id_contrato As Integer
        Get
            Return _id_contrato
        End Get
        Set(value As Integer)
            _id_contrato = value
        End Set
    End Property

    Public Property id_empleado As Integer
        Get
            Return _idempleado
        End Get
        Set(value As Integer)
            _idempleado = value
        End Set
    End Property

    Public Property tipo As Integer
        Get
            Return _tipo
        End Get
        Set(value As Integer)
            _tipo = value
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

    Public Property periodo As Integer
        Get
            Return _periodo
        End Get
        Set(value As Integer)
            _periodo = value
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
