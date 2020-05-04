Public Class EEmpleado
    Private _id_empleado As Integer
    Private _cuil As String
    Private _nombre As String
    Private _apellido As String
    Private _dni As String
    Private _direccion As String
    Private _telefono As String
    Private _fecha_ingreso As Date
    Private _fecha_egreso As Date
    Private _fecha_nac As Date
    Private _estado_civil As Integer
    Private _hijos As Integer
    Private _empresa As Integer
    Private _estadobaja As Boolean
    Private _antiguedad As Integer
    Private _id_categoria As Integer
    Private _id_actividad As Integer
    Private _obras As Integer
    Private _email As String







    Public Property id_empleado As Integer
        Get
            Return _id_empleado
        End Get
        Set(value As Integer)
            _id_empleado = value
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

    Public Property apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property dni As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
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

    Public Property fecha_ingreso As Date
        Get
            Return _fecha_ingreso
        End Get
        Set(value As Date)
            _fecha_ingreso = value
        End Set
    End Property

    Public Property fecha_egreso As Date
        Get
            Return _fecha_egreso
        End Get
        Set(value As Date)
            _fecha_egreso = value
        End Set
    End Property
    Public Property fecha_nac As Date
        Get
            Return _fecha_nac
        End Get
        Set(value As Date)
            _fecha_nac = value
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

    Public Property estado_civil As Integer
        Get
            Return _estado_civil
        End Get
        Set(value As Integer)
            _estado_civil = value
        End Set
    End Property

    Public Property hijos As Integer
        Get
            Return _hijos
        End Get
        Set(value As Integer)
            _hijos = value
        End Set
    End Property

    Public Property empresa As Integer
        Get
            Return _empresa
        End Get
        Set(value As Integer)
            _empresa = value
        End Set
    End Property

    Public Property antiguedad As Integer
        Get
            Return _antiguedad
        End Get
        Set(value As Integer)
            _antiguedad = value
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
    Public Property id_actividad As Integer
        Get
            Return _id_actividad
        End Get
        Set(value As Integer)
            _id_actividad = value
        End Set
    End Property


End Class
