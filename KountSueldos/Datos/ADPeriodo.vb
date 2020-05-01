Public Class ADPeriodo
    Shared ctx As New KoutSueldosEntities


    Shared Sub MostrarPeriodo(grid As DataGridView)
        Dim bank = (From b In ctx.Periodo
                    Where b.estadobaja = True
                    Select b)
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarPeriodoT(grid As DataGridView)
        Dim bank = (From b In ctx.Periodo
                    Select b)
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarPeriodo(obj As Periodo)
        ctx.Periodo.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Periodo)
        ctx.Periodo.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Periodo
                  Where b.id_periodo = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub ModificarPeriodo(id As Integer, name As String, anio As Integer)
        Dim tipo = (From t In ctx.Periodo
                    Where t.id_periodo = id
                    Select t).SingleOrDefault
        With tipo
            .mes = name
            .año = anio

        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Periodo.Any(Function(o) o.mes = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Periodo) = (From c In ctx.Periodo
                                        Where c.mes.StartsWith(txt.Text)
                                        Select c).ToList
        dgv.DataSource = tipo
    End Sub

    Function index() As Integer
        Dim i As Integer
        Dim ext = (From ex In ctx.Periodo Order By ex.id_periodo Descending Select ex).First().id_periodo
        i = CInt(ext.ToString)
        If i > 0 Then
            Return i + 1
        Else
            i = 0
        End If
        Return i
    End Function
End Class
