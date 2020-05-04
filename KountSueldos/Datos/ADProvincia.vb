Public Class ADProvincia
    Shared ctx As New SueldosLiquidadosEntities


    Shared Sub MostrarProvincia(grid As DataGridView)
        Dim bank = (From b In ctx.Provincia
                    Where b.estadobaja = True
                    Select b)
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarProvinciaT(grid As DataGridView)
        Dim bank = (From b In ctx.Provincia
                    Select b)
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarProvincia(obj As Provincia)
        ctx.Provincia.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Provincia)
        ctx.Provincia.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Provincia
                  Where b.id_provincia = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub ModificarProvincia(id As Integer, name As String)
        Dim tipo = (From t In ctx.Provincia
                    Where t.id_provincia = id
                    Select t).SingleOrDefault
        With tipo
            .descripcion = name
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Provincia.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Provincia) = (From c In ctx.Provincia
                                          Where c.descripcion.StartsWith(txt.Text)
                                          Select c).ToList
        dgv.DataSource = tipo
    End Sub

    Function index() As Integer
        Dim i As Integer
        Dim ext = (From ex In ctx.Provincia Order By ex.id_provincia Descending Select ex).First().id_provincia
        i = CInt(ext.ToString)
        If i > 0 Then
            Return i + 1
        Else
            i = 0
        End If
        Return i
    End Function
End Class
