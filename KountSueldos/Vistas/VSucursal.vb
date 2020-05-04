Public Class VSucursal
    Dim ADEmpresa_SucursalSuc As ADEmpresa_SucursalSuc = New ADEmpresa_SucursalSuc
    Dim validar As Validar = New Validar
    Private Sub VSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MConfiguracionF.TamañoForm(Me)
        dgvmanual(dgvsucursal)
        MConfiguracionF.configDGV(dgvsucursal)
        Mostrardgv()
        ' indice()
    End Sub

    Sub Mostrardgv()
        ADEmpresa_SucursalSuc.MostrarEmpresa_Sucursal(dgvsucursal)
    End Sub
    Sub dgvmanual(dgv As DataGridView)

        dgv.AutoGenerateColumns = False
        dgv.Columns.Clear()

        dgv.Columns.Add("id_sucursal", "Código")
        dgv.Columns.Add("descripcion", "Nombre")

        Dim btnck As New DataGridViewCheckBoxColumn
        btnck.Name = "estado"
        btnck.HeaderText = "Estado"

        Dim btne As New DataGridViewButtonColumn
        btne.Name = "editar"
        btne.HeaderText = "Editar"

        Dim btnd As New DataGridViewButtonColumn
        btnd.Name = "eliminar"
        btnd.HeaderText = "Eliminar"
        dgv.Columns.Add(btne)
        dgv.Columns.Add(btnd)
        dgv.Columns.Add(btnck)
        dgv.Columns(0).DataPropertyName = "id_sucursal"
        dgv.Columns(1).DataPropertyName = "descripcion"
        dgv.Columns(2).DataPropertyName = "Editar"
        dgv.Columns(3).DataPropertyName = "Eliminar"
        dgv.Columns(4).DataPropertyName = "estadobaja"
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
    End Sub

    Private Sub pbcerrar_Click(sender As Object, e As EventArgs) Handles pbcerrar.Click
        Me.Close()
    End Sub

    Sub Eliminar()
        Try
            If MsgBox("Seguro desea Eliminar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                Dim ide = dgvsucursal.CurrentRow().Cells(0).Value
                ADEmpresa_SucursalSuc.DarBaja(ide)
                ADEmpresa_SucursalSuc.MostrarEmpresa_Sucursal(dgvsucursal)
                MsgBox("Registro Eliminado con éxito", MsgBoxStyle.Information, "Eliminación")
                indice()
            Else
                MsgBox("Operación cancelada", MsgBoxStyle.Critical, "Cancelación")
                limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub limpiar()
        txtcod.Clear()
        txtnombre.Clear()
    End Sub
    Sub indice()
        txtcod.Text = ADEmpresa_SucursalSuc.index()

    End Sub
    Function DatosVacios() As Boolean

        Dim result As Boolean
        Try
            If txtnombre.Text.Trim = "" Then
                result = False
            Else
                result = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
        End Try
        Return result
    End Function
    Sub Agregar()
        If DatosVacios() = True Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Information, "Aviso")
            txtnombre.Focus()
        Else
            If (ADEmpresa_SucursalSuc.Existe(txtnombre.Text) = False) Then

                If MsgBox("Seguro agregar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    ADEmpresa_SucursalSuc.AgregarEmpresa_Sucursal(New Empresa_Sucursal() With
                                    {
                                    .descripcion = txtnombre.Text,
                                    .estadobaja = 1
                                                          })

                    ADEmpresa_SucursalSuc.MostrarEmpresa_Sucursal(dgvsucursal)
                    limpiar()
                    MsgBox("El registro ha sido agregado exitosamente", MsgBoxStyle.Information, "Gestión")
                    indice()
                Else
                    MsgBox("Operación cancelada", MsgBoxStyle.Critical, "Cancelación")
                    limpiar()
                End If
            Else
                MsgBox("Ya existe un registro con este nombre", MsgBoxStyle.Exclamation, "Alerta")
                limpiar()
            End If
        End If
    End Sub


    Sub Editar()

        Try
            txtcod.Text = CStr(dgvsucursal.CurrentRow.Cells(0).Value)
            txtnombre.Text = CStr(dgvsucursal.CurrentRow.Cells(1).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub dgvsucursal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsucursal.CellContentClick
        Try
            If validar.DatagridVacio(dgvsucursal) = False Then

                Select Case e.ColumnIndex
                    Case 2
                        Editar()
                        Return
                    Case 3
                        Eliminar()
                        Return
                    Case 4
                        MsgBox("Le dio check")
                        Return
                End Select
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Guardar()
        Try
            If dgvsucursal.RowCount = 0 Then
                MsgBox("No hay registros para editar", MsgBoxStyle.Critical, "Error")
            Else
                If txtnombre.Text.Trim = "" Or txtcod.Text.Trim = "" Then

                Else

                    Dim id As Integer = dgvsucursal.CurrentRow.Cells(0).Value
                    '    ADEmpresa_SucursalSuc.ModificarEmpresa_Sucursal(id, txtnombre.Text)
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Agregar()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Guardar()
    End Sub

    Private Sub txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
        ADEmpresa_SucursalSuc.FiltraName(txtnombre, dgvsucursal)
    End Sub
End Class