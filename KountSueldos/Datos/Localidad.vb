'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Localidad
    Public Property id_provincia As Integer
    Public Property id_localidad As Integer
    Public Property descripcion As String
    Public Property estadobaja As Nullable(Of Boolean)

    Public Overridable Property Provincia As Provincia
    Public Overridable Property Sueldo_Cab As ICollection(Of Sueldo_Cab) = New HashSet(Of Sueldo_Cab)

End Class
