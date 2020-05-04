Public Class EConvenio
    Private _id_convenio As Integer
    Private _descripcion As String
    Private _estadobaja As Boolean



    Public Property id_convenio As Integer
        Get
            Return _id_convenio
        End Get
        Set(value As Integer)
            _id_convenio = value
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

    Public Property estadobaja As Boolean
        Get
            Return _estadobaja
        End Get
        Set(value As Boolean)
            _estadobaja = value
        End Set
    End Property

End Class
