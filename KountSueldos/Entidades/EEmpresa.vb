Public Class EEmpresa
    Public Property id_empresa As Integer
    Public Property nombrefantasia As String
    Public Property direccion As String
    Public Property telefono As String
    Public Property cuitE As String
    Public Property provincia As Nullable(Of Integer)
    Public Property estadobaja As Nullable(Of Boolean)
    Public Property id_razonsocial As Nullable(Of Integer)
    Public Property email As String

    Public Overridable Property Empleado As ICollection(Of Empleado) = New HashSet(Of Empleado)
    Public Overridable Property Provincia1 As Provincia
    Public Overridable Property Razon_Social As Razon_Social


End Class
