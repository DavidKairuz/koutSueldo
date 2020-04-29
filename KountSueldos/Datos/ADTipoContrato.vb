Public Class ADTipoContrato
    Shared ctx As New KoutSueldosEntities


    Shared Sub MostrarTipo_Contrato(grid As DataGridView)
        Dim bank = (From b In ctx.Tipo_Contrato
                    Where b.estadobaja = True
                    Select b)
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarTipo_ContratoT(grid As DataGridView)
        Dim bank = (From b In ctx.Tipo_Contrato
                    Select b)
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarTipo_Contrato(obj As Tipo_Contrato)
        ctx.Tipo_Contrato.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Tipo_Contrato)
        ctx.Tipo_Contrato.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Tipo_Contrato
                  Where b.id_tipocontrato = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub ModificarTipo_Contrato(id As Integer, name As String)
        Dim tipo = (From t In ctx.Tipo_Contrato
                    Where t.id_tipocontrato = id
                    Select t).SingleOrDefault
        With tipo
            .descripcion = name
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Tipo_Contrato.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Tipo_Contrato) = (From c In ctx.Tipo_Contrato
                                              Where c.descripcion.StartsWith(txt.Text)
                                              Select c).ToList
        dgv.DataSource = tipo
    End Sub
End Class
