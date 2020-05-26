Public Class ADEmpresa
    Shared ctx As New SueldosLiquidadosEntities


    Shared Sub MostrarEmpresa(grid As DataGridView)
        Dim emp = (From b In ctx.Empresa
                   Select b).ToList
        grid.DataSource = emp
    End Sub



    Shared Sub MostrarEmpresaT(grid As DataGridView)
        Dim emp = (From b In ctx.Empresa
                   Select b).ToList
        grid.DataSource = emp
    End Sub


    Shared Sub AgregarEmpresa(obj As Empresa)
        Try
            ctx.Empresa.Add(obj)
            ctx.SaveChanges()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Shared Sub Eliminar(obj As Empresa)
        ctx.Empresa.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Empresa
                  Where b.id_empresa = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub DarAlta(id As Integer)
        Dim bn = (From b In ctx.Empresa
                  Where b.id_empresa = id
                  Select b).SingleOrDefault
        bn.estadobaja = 1
        ctx.SaveChanges()

    End Sub


    Shared Sub ModificarEmpresa(id As Integer, name As String, dir As String, tel As String, mail As String, cuit As String, prov As Integer, razon As Integer)
        Dim tipo = (From t In ctx.Empresa
                    Where t.id_empresa = id
                    Select t).SingleOrDefault
        With tipo
            .nombrefantasia = name
            .direccion = dir
            .telefono = tel
            .email = mail
            .cuitE = cuit
            .provincia = prov
            .id_razonsocial = razon

        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Empresa.Any(Function(o) o.nombrefantasia = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Shared Sub FiltraName(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Empresa) = (From c In ctx.Empresa
                                        Where c.nombrefantasia.StartsWith(txt.Text)
                                        Select c).ToList
        dgv.DataSource = tipo
    End Sub

    Shared Function index() As Integer
        Dim i As Integer
        Try

            Dim ext = (From ex In ctx.Empresa Order By ex.id_empresa Descending Select ex).First().id_empresa
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
        If ctx.Empresa.Any(Function(o) o.id_empresa = id) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Shared Function ExisteIDEstado(id As Integer) As Boolean
        Dim result As Boolean = False
        If ctx.Empresa.Any(Function(o) o.id_empresa = id) And (ctx.Empresa.Any(Function(o) o.estadobaja = True)) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


End Class
