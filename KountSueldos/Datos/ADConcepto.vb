﻿Public Class ADConcepto
    Shared ctx As New KoutSueldosEntities


    Shared Sub MostrarConcepto(grid As DataGridView)
        Dim bank = (From b In ctx.Concepto
                    Where b.estadobaja = True
                    Select b)
        grid.DataSource = bank
    End Sub



    Shared Sub MostrarConceptoT(grid As DataGridView)
        Dim bank = (From b In ctx.Concepto
                    Select b)
        grid.DataSource = bank
    End Sub


    Shared Sub AgregarConcepto(obj As Concepto)
        ctx.Concepto.Add(obj)
        ctx.SaveChanges()
    End Sub

    Shared Sub Eliminar(obj As Concepto)
        ctx.Concepto.Remove(obj)
        ctx.SaveChanges()

    End Sub

    Shared Sub DarBaja(id As Integer)
        Dim bn = (From b In ctx.Concepto
                  Where b.id_concepto = id
                  Select b).SingleOrDefault
        bn.estadobaja = 0
        ctx.SaveChanges()

    End Sub


    Shared Sub ModificarConcepto(id As Integer, name As String, val As Decimal, est As Boolean, cod As Integer)
        Dim tipo = (From t In ctx.Concepto
                    Where t.id_concepto = id
                    Select t).SingleOrDefault
        With tipo
            .descripcion = name
            .valor = val
            .estado = est
            .codigo = cod
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function Existe(name As String) As Boolean
        Dim result As Boolean = False
        If ctx.Concepto.Any(Function(o) o.descripcion = name) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function


    Sub Filtra(txt As TextBox, dgv As DataGridView)
        Dim tipo As List(Of Concepto) = (From c In ctx.Concepto
                                         Where c.descripcion.StartsWith(txt.Text)
                                         Select c).ToList
        dgv.DataSource = tipo
    End Sub
End Class
