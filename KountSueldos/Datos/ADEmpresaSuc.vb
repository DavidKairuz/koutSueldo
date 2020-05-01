Public Class ADEmpresa_SucursalSuc
    Shared ctx As New KoutSueldosEntities


    Shared Sub MostrarEmpresa_Sucursal(grid As DataGridView)
        Dim emp = (From b In ctx.Empresa_Sucursal
                   Where b.estadobaja = True
                   Select b)
        grid.DataSource = emp
    End Sub



    Shared Sub MostrarEmpresa_SucursalT(grid As DataGridView)
        Dim emp = (From b In ctx.Empresa_Sucursal
                   Select b)
        grid.DataSource = emp
    End Sub


    Shared Sub AgregarEmpresa_Sucursal(obj As Empresa_Sucursal)
        ctx.Empresa_Sucursal.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Empresa_Sucursal)
        ctx.Empresa_Sucursal.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Empresa_Sucursal
                  Where b.id_sucursal = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub ModificarEmpresa_Sucursal(id As Integer, name As String, dir As String, tel As String, emp As String, prov As Integer, razon As Integer)
        Dim tipo = (From t In ctx.Empresa_Sucursal
                    Where t.id_sucursal = id
                    Select t).SingleOrDefault
        With tipo
            .descripcion = name
            .direccion = dir
            .telefono = tel
            .empresa = emp
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Empresa_Sucursal.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub FiltraName(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Empresa_Sucursal) = (From c In ctx.Empresa_Sucursal
                                                 Where c.descripcion.StartsWith(txt.Text)
                                                 Select c).ToList
        dgv.DataSource = tipo
    End Sub

    Function index() As Integer
        Dim i As Integer
        Dim ext = (From ex In ctx.Empresa_Sucursal Order By ex.id_sucursal Descending Select ex).First().id_sucursal
        i = CInt(ext.ToString)
        If i > 0 Then
            Return i + 1
        Else
            i = 0
        End If
        Return i
    End Function
End Class
