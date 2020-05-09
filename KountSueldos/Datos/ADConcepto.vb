Public Class ADConcepto
    Shared ctx As New SueldosLiquidadosEntities


    Shared Sub MostrarConcepto(grid As DataGridView)
        Dim bank = (From b In ctx.Concepto
                    Where b.estadobaja = True
                    Select b.id_concepto, b.descripcion, Valor = b.valor, TipoConcepto = b.Tipo_Concepto.descripcion, b.codigo, estado = b.estado).ToList
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarConceptoT(grid As DataGridView)
        Dim bank = (From b In ctx.Concepto
                    Select b).ToList
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarConcepto(obj As Concepto)
        ctx.Concepto.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Concepto)
        ctx.Concepto.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Concepto
                  Where b.id_concepto = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub

    Shared Sub DarAlta(id As Integer)
        Dim bn = (From b In ctx.Concepto
                  Where b.id_concepto = id
                  Select b).SingleOrDefault
        bn.estadobaja = 1
        ctx.SaveChanges()

    End Sub

    Shared Sub ModificarConcepto(id As Integer, name As String, val As Decimal, est As Char, cod As Integer, tip As Integer)
        Dim tipo = (From t In ctx.Concepto
                    Where t.id_concepto = id
                    Select t).SingleOrDefault
        With tipo
            .descripcion = name
            .valor = val
            .estado = est
            .codigo = cod
            .tipoconcepto = tip
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Concepto.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Concepto) = (From c In ctx.Concepto
                                         Where c.descripcion.StartsWith(txt.Text)
                                         Select c).ToList
        dgv.DataSource = tipo
    End Sub

    Function index() As Integer
        Dim i As Integer
        Dim ext = (From ex In ctx.Concepto Order By ex.id_concepto Descending Select ex).First().id_concepto
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
        If ctx.Concepto.Any(Function(o) o.id_concepto = id) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Shared Function ExisteIDEstado(id As Integer) As Boolean
        Dim result As Boolean = False
        If ctx.Concepto.Any(Function(o) o.id_concepto = id) And (ctx.Concepto.Any(Function(o) o.estadobaja = True)) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


End Class
