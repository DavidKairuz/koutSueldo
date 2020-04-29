﻿Public Class ADBanco
    Shared ctx As New KoutSueldosEntities


    Shared Sub MostrarBanco(grid As DataGridView)
        Dim bank = (From b In ctx.Banco
                    Where b.estadobaja = True
                    Select b)
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarBancoT(grid As DataGridView)
        Dim bank = (From b In ctx.Banco
                    Select b)
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarBanco(obj As Banco)
        ctx.Banco.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Banco)
        ctx.Banco.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Banco
                  Where b.id_banco = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub ModificarBanco(id As Integer, name As String, dir As String, tel As String, suc As Integer)
        Dim tipo = (From t In ctx.Banco
                    Where t.id_banco = id
                    Select t).SingleOrDefault
        With tipo
            .nombre = name
            .direccion = dir
            .telefono = tel
            .sucursalb = suc
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Banco.Any(Function(o) o.nombre = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Banco) = (From c In ctx.Banco
                                      Where c.nombre.StartsWith(txt.Text)
                                      Select c).ToList
        dgv.DataSource = tipo
    End Sub
End Class
