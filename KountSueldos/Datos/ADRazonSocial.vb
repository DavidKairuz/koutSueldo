Public Class ADRazonSocial
    Shared ctx As New SueldosLiquidadosEntities


    Shared Sub MostrarRazon_Social(grid As DataGridView)
        Dim bank = (From b In ctx.Razon_Social
                    Where b.estadobaja = True
                    Select b).ToList
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarRazon_SocialT(grid As DataGridView)
        Dim bank = (From b In ctx.Razon_Social
                    Select b).ToList
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarRazon_Social(obj As Razon_Social)
        ctx.Razon_Social.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Razon_Social)
        ctx.Razon_Social.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Razon_Social
                  Where b.id_razonsocial = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub

    Shared Sub DarAlta(id As Integer)
        Dim bn = (From b In ctx.Razon_Social
                  Where b.id_razonsocial = id
                  Select b).SingleOrDefault
        bn.estadobaja = 1
        ctx.SaveChanges()

    End Sub
    Shared Sub ModificarRazon_Social(id As Integer, name As String)
        Dim tipo = (From t In ctx.Razon_Social
                    Where t.id_razonsocial = id
                    Select t).SingleOrDefault
        With tipo
            .descripcion = name
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Razon_Social.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Razon_Social) = (From c In ctx.Razon_Social
                                             Where c.descripcion.StartsWith(txt.Text)
                                             Select c).ToList
        dgv.DataSource = tipo
    End Sub

    Function index() As Integer
        Dim i As Integer
        Try

            Dim ext = (From ex In ctx.Razon_Social Order By ex.id_razonsocial Descending Select ex).First().id_razonsocial
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


    Shared Sub MostrarCombo(combo As ComboBox)
        Dim uni = (From e In ctx.Razon_Social
                   Select e).ToList

        combo.DataSource = uni
        combo.DisplayMember = "descripcion"
        combo.ValueMember = "id_razonsocial"
        combo.SelectedValue = -1

    End Sub


    Shared Function ExisteID(id As Integer) As Boolean
        Dim result As Boolean = False
        If ctx.Razon_Social.Any(Function(o) o.id_razonsocial = id) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Shared Function ExisteIDEstado(id As Integer) As Boolean
        Dim result As Boolean = False
        If ctx.Razon_Social.Any(Function(o) o.id_razonsocial = id) And (ctx.Razon_Social.Any(Function(o) o.estadobaja = True)) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

End Class
