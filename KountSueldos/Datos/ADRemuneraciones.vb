Public Class ADRemuneraciones
    Shared ctx As New KoutSueldosEntities


    Shared Sub MostrarRemuneraciones(grid As DataGridView)
        Dim bank = (From b In ctx.Remuneraciones
                    Where b.estadobaja = True
                    Select b)
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarRemuneracionesT(grid As DataGridView)
        Dim bank = (From b In ctx.Remuneraciones
                    Select b)
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarRemuneraciones(obj As Remuneraciones)
        ctx.Remuneraciones.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Remuneraciones)
        ctx.Remuneraciones.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Remuneraciones
                  Where b.id_remuneraciones = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub ModificarRemuneraciones(id As Integer, val As String, fec As Date, act As Integer, uni As Integer)
        Dim tipo = (From t In ctx.Remuneraciones
                    Where t.id_remuneraciones = id
                    Select t).SingleOrDefault
        With tipo
            .valor = val
            .fecha = fec
            .actividad = act
            .unidad = uni
        End With

        ctx.SaveChanges()
    End Sub

    'Shared Function Existe(id As Integer) As Boolean
    '    Dim result As Boolean = False
    '    If ctx.Remuneraciones.Any(Function(o) o.id_remuneraciones = id) Then
    '        result = True
    '    Else
    '        result = False
    '    End If
    '    Return result
    'End Function


    'Sub Filtra(txt As TextBox, dgv As DataGridView)
    '    Dim tipo As List(Of Remuneraciones) = (From c In ctx.Remuneraciones
    '                                           Where c.descripcion.StartsWith(txt.Text)
    '                                           Select c).ToList
    '    dgv.DataSource = tipo
    'End Sub
End Class
