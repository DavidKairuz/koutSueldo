Public Class ADLocalidad
    Shared ctx As New KoutSueldosEntities


    Shared Sub MostrarLocalidad(grid As DataGridView)
        Dim bank = (From b In ctx.Localidad
                    Where b.estadobaja = True
                    Select b)
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarLocalidadT(grid As DataGridView)
        Dim bank = (From b In ctx.Localidad
                    Select b)
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarLocalidad(obj As Localidad)
        ctx.Localidad.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Localidad)
        ctx.Localidad.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Localidad
                  Where b.id_localidad = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub ModificarLocalidad(id As Integer, name As String)
        Dim tipo = (From t In ctx.Localidad
                    Where t.id_localidad = id
                    Select t).SingleOrDefault
        With tipo
            .descripcion = name
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Localidad.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Localidad) = (From c In ctx.Localidad
                                          Where c.descripcion.StartsWith(txt.Text)
                                          Select c).ToList
        dgv.DataSource = tipo
    End Sub
End Class
