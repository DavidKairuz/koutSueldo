Public Class ADSueldoDet
    Shared ctx As New KoutSueldosEntities


    Shared Sub MostrarSueldo_Det(grid As DataGridView)
        Dim bank = (From b In ctx.Sueldo_Det
                    Where b.estadobaja = True
                    Select b)
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarSueldo_DetT(grid As DataGridView)
        Dim bank = (From b In ctx.Sueldo_Det
                    Select b)
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarSueldo_Det(obj As Sueldo_Det)
        ctx.Sueldo_Det.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Sueldo_Det)
        ctx.Sueldo_Det.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer, fec As Date)
        Dim bn = (From b In ctx.Sueldo_Det
                  Where b.id_reciboc = id And b.fecha = fec
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub ModificarSueldo_Det(id As Integer, fec As Date, concep As Integer, cant As Integer, unid As Integer, subt As Decimal, imp As Decimal)
        Dim tipo = (From t In ctx.Sueldo_Det
                    Where t.id_reciboc = id And t.fecha = fec
                    Select t).SingleOrDefault
        With tipo
            .concepto = concep
            .cantidad = cant
            .unidad = unid
            .subtotal = subt
            .importe = imp

        End With

        ctx.SaveChanges()
    End Sub
    ' tambien hay que modificar por alguna posibilidad
    Shared Function Existe(id As Integer, fec As Date) As Boolean
        Dim result As Boolean = False
        If ctx.Sueldo_Det.Any(Function(o) o.id_reciboc = id) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    '<hay que filtrar por fechas o nombres de empleados
    'Sub Filtra(txt As TextBox, dgv As DataGridView)
    '    Dim tipo As List(Of Sueldo_Det) = (From c In ctx.Sueldo_Det
    '                                       Where c.descripcion.StartsWith(txt.Text)
    '                                       Select c).ToList
    '    dgv.DataSource = tipo
    'End Sub

    Function index() As Integer
        Dim i As Integer
        Dim ext = (From ex In ctx.Sueldo_Det Order By ex.id_recibo_det Descending Select ex).First().id_recibo_det
        i = CInt(ext.ToString)
        If i > 0 Then
            Return i + 1
        Else
            i = 0
        End If
        Return i
    End Function
End Class
