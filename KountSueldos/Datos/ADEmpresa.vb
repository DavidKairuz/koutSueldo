Public Class ADEmpresa
    Shared ctx As New KoutSueldosEntities


    Shared Sub MostrarEmpresa(grid As DataGridView)
        Dim emp = (From b In ctx.Empresa
                   Where b.estadobaja = True
                   Select b)
        grid.DataSource = emp
    End Sub



    Shared Sub MostrarEmpresaT(grid As DataGridView)
        Dim emp = (From b In ctx.Empresa
                   Select b)
        grid.DataSource = emp
    End Sub


    Shared Sub AgregarEmpresa(obj As Empresa)
        ctx.Empresa.Add(obj)
        ctx.SaveChanges()
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


    Shared Sub ModificarEmpresa(id As Integer, name As String, dir As String, tel As String, cuit As String, prov As Integer, razon As Integer)
        Dim tipo = (From t In ctx.Empresa
                    Where t.id_empresa = id
                    Select t).SingleOrDefault
        With tipo
            .nombrefantasia = name
            .direccion = dir
            .telefono = tel
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


    Sub FiltraName(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Empresa) = (From c In ctx.Empresa
                                        Where c.nombrefantasia.StartsWith(txt.Text)
                                        Select c).ToList
        dgv.DataSource = tipo
    End Sub
End Class
