Public Class ADEstadoCivil
    Shared ctx As New SueldosLiquidadosEntities


    Shared Sub MostrarEstado_Civil(grid As DataGridView)
        Dim bank = (From b In ctx.Estado_Civil
                    Where b.estadobaja = True
                    Select b).ToList
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarEstado_CivilT(grid As DataGridView)
        Dim bank = (From b In ctx.Estado_Civil
                    Select b).ToList
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarEstado_Civil(obj As Estado_Civil)
        ctx.Estado_Civil.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Estado_Civil)
        ctx.Estado_Civil.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Estado_Civil
                  Where b.id_estadociv = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub DarAlta(id As Integer)
        Dim bn = (From b In ctx.Estado_Civil
                  Where b.id_estadociv = id
                  Select b).SingleOrDefault
        bn.estadobaja = 1
        ctx.SaveChanges()

    End Sub

    Shared Sub ModificarEstado_Civil(id As Integer, name As String)
        Dim tipo = (From t In ctx.Estado_Civil
                    Where t.id_estadociv = id
                    Select t).SingleOrDefault
        With tipo
            .descripcion = name
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Estado_Civil.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Estado_Civil) = (From c In ctx.Estado_Civil
                                             Where c.descripcion.StartsWith(txt.Text)
                                             Select c).ToList
        dgv.DataSource = tipo
    End Sub

    Function index() As Integer
        Dim i As Integer
        Dim ext = (From ex In ctx.Estado_Civil Order By ex.id_estadociv Descending Select ex).First().id_estadociv
        i = CInt(ext.ToString)
        If i > 0 Then
            Return i + 1
        Else
            i = 0
        End If
        Return i
    End Function


    Shared Function ExisteID(id As Integer) As Boolean
        Dim result As Boolean = False
        If ctx.Estado_Civil.Any(Function(o) o.id_estadociv = id) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Shared Function ExisteIDEstado(id As Integer) As Boolean
        Dim result As Boolean = False
        If ctx.Estado_Civil.Any(Function(o) o.id_estadociv = id) And (ctx.Estado_Civil.Any(Function(o) o.estadobaja = True)) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

End Class
