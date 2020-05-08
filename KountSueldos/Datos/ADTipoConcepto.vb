Public Class ADTipoConcepto
    Shared ctx As New SueldosLiquidadosEntities


    Shared Sub MostrarTipo_Concepto(grid As DataGridView)
        Dim bank = (From b In ctx.Tipo_Concepto
                    Where b.estadobaja = True
                    Select b).ToList
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarTipo_ConceptoT(grid As DataGridView)
        Dim bank = (From b In ctx.Tipo_Concepto
                    Select b).ToList
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarTipo_Concepto(obj As Tipo_Concepto)
        ctx.Tipo_Concepto.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Tipo_Concepto)
        ctx.Tipo_Concepto.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Tipo_Concepto
                  Where b.id_tipoconcepto = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub

    Shared Sub DarAlta(id As Integer)
        Dim bn = (From b In ctx.Tipo_Concepto
                  Where b.id_tipoconcepto = id
                  Select b).SingleOrDefault
        bn.estadobaja = 1
        ctx.SaveChanges()

    End Sub

    Shared Sub ModificarTipo_Concepto(id As Integer, name As String)
        Dim tipo = (From t In ctx.Tipo_Concepto
                    Where t.id_tipoconcepto = id
                    Select t).SingleOrDefault
        With tipo
            .descripcion = name
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Tipo_Concepto.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function



    Shared Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Tipo_Concepto) = (From c In ctx.Tipo_Concepto
                                              Where c.descripcion.StartsWith(txt.Text)
                                              Select c).ToList
        dgv.DataSource = tipo
    End Sub

    Shared Function index() As Integer
        Dim i As Integer
        Dim ext = (From ex In ctx.Tipo_Concepto Order By ex.id_tipoconcepto Descending Select ex).First().id_tipoconcepto
        i = CInt(ext.ToString)
        If i > 0 Then
            Return i + 1
        ElseIf IsDBNull(i) Then
            i = 1
        Else
            i = 0

        End If
        Return i
    End Function


    Shared Sub MostrarCombo(combo As ComboBox)
        Dim uni = (From e In ctx.Tipo_Concepto
                   Select e).ToList

        combo.DataSource = uni
        combo.DisplayMember = "descripcion"
        combo.ValueMember = "id_tipoconcepto"
        combo.SelectedValue = -1

    End Sub


    Shared Function ExisteID(id As Integer) As Boolean
        Dim result As Boolean = False
        If ctx.Tipo_Concepto.Any(Function(o) o.id_tipoconcepto = id) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Shared Function ExisteIDEstado(id As Integer) As Boolean
        Dim result As Boolean = False
        If ctx.Tipo_Concepto.Any(Function(o) o.id_tipoconcepto = id) And (ctx.Tipo_Concepto.Any(Function(o) o.estadobaja = True)) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

End Class
