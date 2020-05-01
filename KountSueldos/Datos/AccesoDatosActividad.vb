Public Class AccesoDatosActividad

    Shared ctx As New KoutSueldosEntities

    Shared Sub MostrarGrid(grid As DataGridView)
        Dim act = (From a In ctx.Actividad
                   Where a.estadobaja = True
                   Select a).ToList
        grid.DataSource = act


    End Sub

    Function index() As Integer
        Dim i As Integer
        Dim ext = (From ex In ctx.Actividad Order By ex.id_actividad Descending Select ex).First().id_actividad
        i = CInt(ext.ToString)
        If i > 0 Then
            Return i + 1
        Else
            i = 0
        End If
        Return i
    End Function
    Shared Sub MostrarGridT(grid As DataGridView)
        Dim act = (From a In ctx.Actividad
                   Select a).ToList
        grid.DataSource = act
    End Sub

    Shared Sub AgregarActividad(obj As Actividad)
        ctx.Actividad.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub EliminarActividad(obj As Actividad)
        ctx.Actividad.Remove(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim act = (From a In ctx.Actividad
                   Where a.id_actividad = id
                   Select a).SingleOrDefault

        act.estadobaja = 0
        ' ctx.Entry(act).State = Entity.EntityState.Modified
        ctx.SaveChanges()
    End Sub

    Shared Sub ModificarActividad(id As Integer, idconv As Integer, desc As String, valor As Decimal, unidad As Integer)
        Dim tipo = (From t In ctx.Actividad
                    Where t.id_actividad = id
                    Select t).SingleOrDefault
        With tipo
            .id_convenio = idconv
            .descripcion = desc
            .valor = valor
            .id_unidad = unidad
        End With

        ctx.SaveChanges()
    End Sub


    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Actividad.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Actividad) = (From c In ctx.Actividad
                                          Where c.descripcion.StartsWith(txt.Text)
                                          Select c).ToList
        dgv.DataSource = tipo
    End Sub

End Class
