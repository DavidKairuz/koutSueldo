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

Partial Public Class CategoriaC
    Public Property id_convenio As Integer
    Public Property id_categoria As Integer
    Public Property estadobaja As Nullable(Of Boolean)
    Public Property descripcion As String
    Public Property basico As Nullable(Of Decimal)

    Public Overridable Property Actividad As ICollection(Of Actividad) = New HashSet(Of Actividad)
    Public Overridable Property Convenio As Convenio

End Class
