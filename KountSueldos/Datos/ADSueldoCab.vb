Public Class ADSueldoCab
    Shared ctx As New KoutSueldosEntities


    Shared Sub MostrarSueldo_Cab(grid As DataGridView)
        Dim bank = (From b In ctx.Sueldo_Cab
                    Where b.estadobaja = True
                    Select b)
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarSueldo_CabT(grid As DataGridView)
        Dim bank = (From b In ctx.Sueldo_Cab
                    Select b)
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarSueldo_Cab(obj As Sueldo_Cab)
        ctx.Sueldo_Cab.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Sueldo_Cab)
        ctx.Sueldo_Cab.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer, fec As Date)
        Dim bn = (From b In ctx.Sueldo_Cab
                  Where b.id_reciboC = id And b.fecha = fec
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub ModificarSueldo_Cab(id As Integer, fec As Date, idemp As Integer, per As Integer, perliq As Date, total As Decimal, totalbr As Decimal, totalnet As Decimal, prov As Integer, loc As Integer, bank As Integer, emp As Integer)
        Dim tipo = (From t In ctx.Sueldo_Cab
                    Where t.id_reciboC = id And t.fecha = fec
                    Select t).SingleOrDefault
        With tipo
            .id_empresa = idemp
            .periodo = per
            .periodoLiq = perliq
            .total = total
            .total_bruto = totalbr
            .total_neto = totalnet
            .id_provincia = prov
            .id_localidad = loc
            .id_banco = bank
            .empleado = emp
        End With

        ctx.SaveChanges()
    End Sub
    ' tambien hay que modificar por alguna posibilidad
    Shared Function Existe(id As Integer, fec As Date) As Boolean
        Dim result As Boolean = False
        If ctx.Sueldo_Cab.Any(Function(o) o.id_reciboC = id) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    '<hay que filtrar por fechas o nombres de empleados
    'Sub Filtra(txt As TextBox, dgv As DataGridView)
    '    Dim tipo As List(Of Sueldo_Cab) = (From c In ctx.Sueldo_Cab
    '                                       Where c.descripcion.StartsWith(txt.Text)
    '                                       Select c).ToList
    '    dgv.DataSource = tipo
    'End Sub
End Class
