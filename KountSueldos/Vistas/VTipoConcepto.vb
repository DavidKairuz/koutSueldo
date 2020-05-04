Public Class VTipoConcepto
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click

    End Sub

    Private Sub VTipoConcepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MConfiguracionF.TamañoForm(Me)
        dgvmanual(dgvtipoconcep)
        MConfiguracionF.configDGV(dgvtipoconcep)
        Mostrardgv()
        ' indice()
    End Sub

    Sub Mostrardgv()
        ADTipoConcepto.MostrarTipo_Concepto(dgvtipoconcep)
    End Sub
    Sub dgvmanual(dgv As DataGridView)

        dgv.AutoGenerateColumns = False
        dgv.Columns.Clear()

        dgv.Columns.Add("id_tipoconcepto", "Código")
        dgv.Columns.Add("descripcion", "Tipo Concepto")

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
        dgv.Columns(0).DataPropertyName = "id_tipoconcepto"
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

                Dim ide = dgvtipoconcep.CurrentRow().Cells(0).Value
                ADTipoConcepto.DarBaja(ide)
                ADTipoConcepto.MostrarTipo_Concepto(dgvtipoconcep)
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
        txtdescripcion.Clear()
    End Sub
    Sub indice()
        txtcod.Text = ADTipoConcepto.index()

    End Sub
    Function DatosVacios() As Boolean

        Dim result As Boolean
        Try

            If txtdescripcion.Text.Trim = "" Then
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
            txtdescripcion.Focus()
        Else

            If (ADTipoConcepto.Existe(txtdescripcion.Text) = False) Then

                If MsgBox("Seguro agregar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    ADTipoConcepto.AgregarTipo_Concepto(New Tipo_Concepto() With
                                    {
                                    .descripcion = txtdescripcion.Text,
                                    .estadobaja = 1
                                                          })




                    ADTipoConcepto.MostrarTipo_Concepto(dgvtipoconcep)
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
        txtcod.Text = CStr(dgvtipoconcep.CurrentRow.Cells(0).Value)
        txtdescripcion.Text = CStr(dgvtipoconcep.CurrentRow.Cells(1).Value)
    End Sub

    Sub Guardar()
        Try
            If dgvtipoconcep.RowCount = 0 Then
                MsgBox("No hay registros para editar", MsgBoxStyle.Critical, "Error")
            Else
                If txtdescripcion.Text.Trim = "" Or txtcod.Text.Trim = "" Then

                Else

                    Dim id As Integer = dgvtipoconcep.CurrentRow.Cells(0).Value
                    ADTipoConcepto.ModificarTipo_Concepto(id, txtdescripcion.Text)
                End If


            End If
        Catch ex As Exception

        End Try

    End Sub
    Sub Alta()
        Try
            If dgvtipoconcep.RowCount = 0 Then
                MsgBox("No hay registros para dar de alta", MsgBoxStyle.Critical, "Error")
            Else

                If MsgBox("Seguro desea dar de alta este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    Dim ide = dgvtipoconcep.CurrentRow().Cells(0).Value
                    If ide <> 0 Then


                        ADTipoConcepto.DarAlta(ide)
                        ADTipoConcepto.MostrarTipo_Concepto(dgvtipoconcep)
                        MsgBox("Registro actualizado con éxito", MsgBoxStyle.Information, "Actualización")
                        indice()
                    Else
                        MsgBox("Hubo un error al intentar acceder a la base de datos", MsgBoxStyle.Critical, "Error")
                    End If
                Else
                    MsgBox("Operación cancelada", MsgBoxStyle.Critical, "Cancelación")
                    limpiar()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
        ADTipoConcepto.Filtra(txtfiltro, dgvtipoconcep)
    End Sub
End Class