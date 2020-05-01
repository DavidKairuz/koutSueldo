Public Class ADContrato
    Shared ctx As New KoutSueldosEntities


    Shared Sub MostrarContrato(grid As DataGridView)
        Dim bank = (From b In ctx.Contrato
                    Where b.estadobaja = True
                    Select b)
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarContratoT(grid As DataGridView)
        Dim bank = (From b In ctx.Contrato
                    Select b)
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarContrato(obj As Contrato)
        ctx.Contrato.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Contrato)
        ctx.Contrato.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Contrato
                  Where b.id_contrato = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub ModificarContrato(id As Integer, per As Integer, emi As Date, venc As Date, tip As Integer)
        Dim tipo = (From t In ctx.Contrato
                    Where t.id_contrato = id
                    Select t).SingleOrDefault
        With tipo
            .periodo = per
            .fecha_emision = emi
            .fecha_vencimiento = venc
            .tipo = tip
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Contrato.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Contrato) = (From c In ctx.Contrato
                                         Where c.descripcion.StartsWith(txt.Text)
                                         Select c).ToList
        dgv.DataSource = tipo
    End Sub
    Function index() As Integer
        Dim i As Integer
        Dim ext = (From ex In ctx.Contrato Order By ex.id_contrato Descending Select ex).First().id_contrato
        i = CInt(ext.ToString)
        If i > 0 Then
            Return i + 1
        Else
            i = 0
        End If
        Return i
    End Function
End Class
