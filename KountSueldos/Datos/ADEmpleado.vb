Public Class ADEmpleado
    Shared ctx As New SueldosLiquidadosEntities


    Shared Sub MostrarEmpleado(grid As DataGridView)
        Dim emp = (From b In ctx.Empleado
                   Where b.estadobaja = True
                   Select b).ToList
        grid.DataSource = emp
    End Sub



    Shared Sub MostrarEmpleadoT(grid As DataGridView)
        Dim emp = (From b In ctx.Empleado
                   Select b).ToList
        grid.DataSource = emp
    End Sub


    Shared Sub AgregarEmpleado(obj As Empleado)
        ctx.Empleado.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Empleado)
        ctx.Empleado.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Empleado
                  Where b.id_empleado = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub DarAlta(id As Integer)
        Dim bn = (From b In ctx.Empleado
                  Where b.id_empleado = id
                  Select b).SingleOrDefault
        bn.estadobaja = 1
        ctx.SaveChanges()

    End Sub


    Shared Sub ModificarEmpleado(id As Integer, name As String, ape As String, dni As String, dir As String, tel As String, ing As Date, nac As Date, antig As Integer, son As Integer, empres As Integer, act As Integer)
        Dim tipo = (From t In ctx.Empleado
                    Where t.id_empleado = id
                    Select t).SingleOrDefault
        With tipo
            .nombre = name
            .apellido = ape
            .dni = dni
            .direccion = dir
            .telefono = tel
            .fecha_ing = ing
            .fecha_nac = nac
            .antiguedad = antig
            .hijos = son
            .empresa = empres
            .id_actividad = act
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Empleado.Any(Function(o) o.apellido = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub FiltraApellido(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Empleado) = (From c In ctx.Empleado
                                         Where c.apellido.StartsWith(txt.Text)
                                         Select c).ToList
        dgv.DataSource = tipo
    End Sub

    Function index() As Integer
        Dim i As Integer
        Dim ext = (From ex In ctx.Empleado Order By ex.id_empleado Descending Select ex).First().id_empleado
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
        If ctx.Empleado.Any(Function(o) o.id_empleado = id) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Shared Function ExisteIDEstado(id As Integer) As Boolean
        Dim result As Boolean = False
        If ctx.Empleado.Any(Function(o) o.id_empleado = id) And (ctx.Empleado.Any(Function(o) o.estadobaja = True)) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


End Class
