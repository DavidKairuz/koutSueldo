Public Class ADCategoriaC

    Shared ctx As New SueldosLiquidadosEntities


    Shared Sub MostrarCategoria(grid As DataGridView)
        Dim bank = (From b In ctx.CategoriaC
                    Where b.estadobaja = True
                    Select b)
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarCategoriaT(grid As DataGridView)
        Dim bank = (From b In ctx.CategoriaC
                    Select b)
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarCategoria(obj As CategoriaC)
        ctx.CategoriaC.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As CategoriaC)
        ctx.CategoriaC.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.CategoriaC
                  Where b.id_categoria = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub
    Shared Sub DarAlta(id As Integer)
        Dim bn = (From b In ctx.CategoriaC
                  Where b.id_categoria = id
                  Select b).SingleOrDefault
        bn.estadobaja = 1
        ctx.SaveChanges()

    End Sub

    Shared Sub ModificarCategoriaC(id As Integer, desc As String, bas As Decimal)
        Dim tipo = (From t In ctx.CategoriaC
                    Where t.id_categoria = id
                    Select t).SingleOrDefault
        With tipo
            .descripcion = desc
            .basico = bas
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.CategoriaC.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of CategoriaC) = (From c In ctx.CategoriaC
                                           Where c.descripcion.StartsWith(txt.Text)
                                           Select c).ToList
        dgv.DataSource = tipo
    End Sub



    Function index() As Integer
        Dim i As Integer
        Dim ext = (From ex In ctx.CategoriaC Order By ex.id_categoria Descending Select ex).First().id_categoria
        i = CInt(ext.ToString)
        If i > 0 Then
            Return i + 1
        Else
            i = 0
        End If
        Return i
    End Function
End Class
