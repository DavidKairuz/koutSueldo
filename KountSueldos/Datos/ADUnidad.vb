Public Class ADUnidad
    Shared ctx As New SueldosLiquidadosEntities


    Shared Sub MostrarUnidad(grid As DataGridView)
        Dim bank = (From b In ctx.Unidad
                    Where b.estadobaja = True
                    Select b).ToList
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarUnidadT(grid As DataGridView)
        Dim bank = (From b In ctx.Unidad
                    Select b).ToList
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarUnidad(obj As Unidad)
        ctx.Unidad.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Unidad)
        ctx.Unidad.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Unidad
                  Where b.id_unidad = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub

    Shared Sub DarAlta(id As Integer)
        Dim bn = (From b In ctx.Unidad
                  Where b.id_unidad = id
                  Select b).SingleOrDefault
        bn.estadobaja = 1
        ctx.SaveChanges()

    End Sub


    Shared Sub ModificarUnidad(id As Integer, name As String)
        Dim tipo = (From t In ctx.Unidad
                    Where t.id_unidad = id
                    Select t).SingleOrDefault
        With tipo
            .descripcion = name
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Unidad.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Unidad) = (From c In ctx.Unidad
                                       Where c.descripcion.StartsWith(txt.Text)
                                       Select c).ToList
        dgv.DataSource = tipo
    End Sub

    Function index() As Integer
        Dim i As Integer
        Dim ext = (From ex In ctx.Unidad Order By ex.id_unidad Descending Select ex).First().id_unidad
        i = CInt(ext.ToString)
        If i > 0 Then
            Return i + 1
        Else
            i = 0
        End If
        Return i
    End Function
End Class
