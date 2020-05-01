﻿Public Class ADEmpleado
    Shared ctx As New KoutSueldosEntities


    Shared Sub MostrarEmpleado(grid As DataGridView)
        Dim emp = (From b In ctx.Empleado
                   Where b.estadobaja = True
                   Select b)
        grid.DataSource = emp
    End Sub



    Shared Sub MostrarEmpleadoT(grid As DataGridView)
        Dim emp = (From b In ctx.Empleado
                   Select b)
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
End Class