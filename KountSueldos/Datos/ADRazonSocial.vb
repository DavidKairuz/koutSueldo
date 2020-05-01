﻿Public Class ADRazonSocial
    Shared ctx As New KoutSueldosEntities


    Shared Sub MostrarRazon_Social(grid As DataGridView)
        Dim bank = (From b In ctx.Razon_Social
                    Where b.estadobaja = True
                    Select b)
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarRazon_SocialT(grid As DataGridView)
        Dim bank = (From b In ctx.Razon_Social
                    Select b)
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
End Class