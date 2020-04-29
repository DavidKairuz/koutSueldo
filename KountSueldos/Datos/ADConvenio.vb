Public Class ADConvenio
    Shared ctx As New KoutSueldosEntities


    Shared Sub MostrarConvenio(grid As DataGridView)
        Dim bank = (From b In ctx.Convenio
                    Where b.estadobaja = True
                    Select b)
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarConvenioT(grid As DataGridView)
        Dim bank = (From b In ctx.Convenio
                    Select b)
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarConvenio(obj As Convenio)
        ctx.Convenio.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Convenio)
        ctx.Convenio.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Convenio
                  Where b.id_convenio = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub ModificarConvenio(id As Integer, name As String)
        Dim tipo = (From t In ctx.Convenio
                    Where t.id_convenio = id
                    Select t).SingleOrDefault
        With tipo
            .descripcion = name
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Convenio.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Convenio) = (From c In ctx.Convenio
                                         Where c.descripcion.StartsWith(txt.Text)
                                         Select c).ToList
        dgv.DataSource = tipo
    End Sub
End Class
