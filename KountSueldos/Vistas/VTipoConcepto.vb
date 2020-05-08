Public Class VTipoConcepto

    Private Sub VTipoConcepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MConfiguracionF.TamañoForm(Me)
        dgvmanual(dgvtipoconcep)
        MConfiguracionF.configDGV(dgvtipoconcep)
        Mostrardgv()
        indice()
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
        Try
            If ADTipoConcepto.index() = 0 Then
                txtcod.Text = 1
            Else
                txtcod.Text = ADTipoConcepto.index()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Function DatosVacios() As Boolean

        Dim result As Boolean
        Try

            If txtdescripcion.Text.Trim = "" Then
                result = True
            Else
                result = False

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
                    limpiar()

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
            If dgvtipoconcep.RowCount > 0 Then
                txtcod.Text = CStr(dgvtipoconcep.CurrentRow.Cells(0).Value)
                txtdescripcion.Text = CStr(dgvtipoconcep.CurrentRow.Cells(1).Value)
            Else
                MsgBox("No hay registros para editar", MsgBoxStyle.Information, "Mensaje")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Guardar()
        Try
            If dgvtipoconcep.RowCount = 0 Then
                MsgBox("No hay registros para editar", MsgBoxStyle.Critical, "Error")
            Else
                If txtdescripcion.Text.Trim = "" Or txtcod.Text.Trim = "" Then
                    MsgBox("Debe seleccionar un registro", MsgBoxStyle.Critical, "Error")
                Else

                    If MsgBox("Seguro desea dar de modificar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
                        Dim id As Integer = dgvtipoconcep.CurrentRow.Cells(0).Value
                        ADTipoConcepto.ModificarTipo_Concepto(id, txtdescripcion.Text)
                        MsgBox("el registro se modifico exitosamente", MsgBoxStyle.Information, "Modificación")
                    Else
                        MsgBox("Operación cancelada", MsgBoxStyle.Critical, "Cancelación")
                        limpiar()
                        'indice()

                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Alta()
        Try
            If dgvtipoconcep.RowCount = 0 Then
                MsgBox("No hay registros para dar de alta", MsgBoxStyle.Critical, "Error")
            Else

                If MsgBox("Seguro desea dar de alta este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    Dim ide = dgvtipoconcep.CurrentRow().Cells(0).Value
                    If ide <> 0 And txtdescripcion.Text.Trim <> "" Then
                        'aca hay que hacer otra funcion y ver que no exista el registro o controlar se haya clickeado sobre editar 

                        ADTipoConcepto.DarAlta(ide)
                        ADTipoConcepto.MostrarTipo_Concepto(dgvtipoconcep)
                        MsgBox("Registro actualizado con éxito", MsgBoxStyle.Information, "Actualización")
                        limpiar()
                        '  indice()
                    Else
                        MsgBox("Hubo un error al intentar acceder a la base de datos", MsgBoxStyle.Critical, "Error")
                    End If
                Else
                    MsgBox("Operación cancelada", MsgBoxStyle.Critical, "Cancelación")
                    limpiar()
                    '   indice()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
        ADTipoConcepto.Filtra(txtfiltro, dgvtipoconcep)
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Agregar()
        dgvtipoconcep.DataSource = Nothing
        Mostrardgv()
        limpiar()
        indice()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Guardar()
        dgvtipoconcep.DataSource = Nothing
        Mostrardgv()
        limpiar()
        indice()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Alta()
        dgvtipoconcep.DataSource = Nothing
        Mostrardgv()
        indice()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
        indice()
    End Sub

    Private Sub dgvtipoconcep_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtipoconcep.CellContentClick
        Try
            If dgvtipoconcep.RowCount <> 0 Then

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
End Class