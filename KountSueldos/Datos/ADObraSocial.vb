Public Class ADObraSocial
    Shared ctx As New SueldosLiquidadosEntities


    Shared Sub MostrarObra_Social(grid As DataGridView)
        Dim bank = (From b In ctx.Obra_Social
                    Where b.estadobaja = True
                    Select b).ToList
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarObra_SocialT(grid As DataGridView)
        Dim bank = (From b In ctx.Obra_Social
                    Select b).ToList
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarObra_Social(obj As Obra_Social)
        ctx.Obra_Social.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Obra_Social)
        ctx.Obra_Social.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Obra_Social
                  Where b.id_obrasocial = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub DarAlta(id As Integer)
        Dim bn = (From b In ctx.Obra_Social
                  Where b.id_obrasocial = id
                  Select b).SingleOrDefault
        bn.estadobaja = 1
        ctx.SaveChanges()

    End Sub

    Shared Sub ModificarObra_Social(id As Integer, name As String)
        Dim tipo = (From t In ctx.Obra_Social
                    Where t.id_obrasocial = id
                    Select t).SingleOrDefault
        With tipo
            .descripcion = name
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Obra_Social.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Obra_Social) = (From c In ctx.Obra_Social
                                            Where c.descripcion.StartsWith(txt.Text)
                                            Select c).ToList
        dgv.DataSource = tipo
    End Sub

    Function index() As Integer
        Dim i As Integer
        Try
            Dim ext = (From ex In ctx.Obra_Social Order By ex.id_obrasocial Descending Select ex).First().id_obrasocial
            i = CInt(ext.ToString)
            If i > 0 Then
                Return i + 1
            Else
                i = 0
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return i
    End Function

    Shared Function ExisteID(id As Integer) As Boolean
        Dim result As Boolean = False
        If ctx.Obra_Social.Any(Function(o) o.id_obrasocial = id) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Shared Function ExisteIDEstado(id As Integer) As Boolean
        Dim result As Boolean = False
        If ctx.Obra_Social.Any(Function(o) o.id_obrasocial = id) And (ctx.Obra_Social.Any(Function(o) o.estadobaja = True)) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


End Class
