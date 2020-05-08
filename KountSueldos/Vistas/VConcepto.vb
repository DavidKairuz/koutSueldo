Public Class VConcepto
    Dim ADConcepto As ADConcepto = New ADConcepto
    Dim validar As Validar = New Validar
    Private Sub VConcepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MConfiguracionF.TamañoForm(Me)
        MConfiguracionF.configDGV(dgvconcepto)
        Mostrardgv()
        MostrarComboTipoC()
        MostrarComboEstado()
        indice()
    End Sub

    Sub Mostrardgv()
        dgvmanual(dgvconcepto)
        ADConcepto.MostrarConcepto(dgvconcepto)
    End Sub
    Sub dgvmanual(dgv As DataGridView)

        dgv.AutoGenerateColumns = False
        dgv.Columns.Clear()
        Dim tipoconceto As New DataGridViewTextBoxColumn
        tipoconceto.Name = "tipoconcepto"
        tipoconceto.HeaderText = "Tipo Concepto"

        dgv.Columns.Add("id_concepto", "Código")
        dgv.Columns.Add("descripcion", "Concepto")
        dgv.Columns.Add("valor", "Valor")
        dgv.Columns.Add(tipoconceto)
        dgv.Columns.Add("codigo", "Ley Nº")
        dgv.Columns.Add("estado", "Tipo")
        'dgv.Columns.Add(valor)

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

        dgv.Columns(0).DataPropertyName = "id_concepto"
        dgv.Columns(1).DataPropertyName = "descripcion"
        dgv.Columns(2).DataPropertyName = "Valor"
        dgv.Columns(3).DataPropertyName = "Tipo Concepto"
        dgv.Columns(4).DataPropertyName = "Ley Nº"
        dgv.Columns(5).DataPropertyName = "Tipo"
        dgv.Columns(6).DataPropertyName = "Editar"
        dgv.Columns(7).DataPropertyName = "Eliminar"
        '  dgv.Columns(7).DataPropertyName = "estadobaja"

    End Sub

    Private Sub pbcerrar_Click(sender As Object, e As EventArgs) Handles pbcerrar.Click
        Me.Close()
    End Sub

    Sub Eliminar()
        Try
            If MsgBox("Seguro desea Eliminar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                Dim ide = dgvconcepto.CurrentRow().Cells(0).Value
                ADConcepto.DarBaja(ide)
                Mostrardgv()
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

    Sub MostrarComboTipoC()
        MConfiguracionF.configCombobox(cbotipoconcep)
        Dim ADTipoConcepto As New ADTipoConcepto
        ADTipoConcepto.MostrarCombo(cbotipoconcep)
    End Sub

    Sub MostrarComboEstado()
        MConfiguracionF.configCombobox(cboestado)
        cboestado.Items.Add("R")
        cboestado.Items.Add("N")
    End Sub


    Sub limpiar()
        txtcod.Clear()
        txtdescripcion.Clear()
        txtvalor.Clear()
        cboestado.SelectedValue = -1
        cbotipoconcep.SelectedValue = -1
    End Sub


    Sub indice()
        If ADConcepto.index() = 0 Then
            txtcod.Text = 1
        Else
            txtcod.Text = ADConcepto.index
        End If
    End Sub


    Function DatosVacios() As Boolean
        Dim result As Boolean = False
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

            If (ADConcepto.Existe(txtdescripcion.Text) = False) Then

                If MsgBox("Seguro agregar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    ADConcepto.AgregarConcepto(New Concepto() With
                                    {
                                    .descripcion = txtdescripcion.Text,
                                    .valor = txtvalor.Text,
                                    .tipoconcepto = cbotipoconcep.SelectedValue,
                                    .estado = cboestado.SelectedValue,
                                    .codigo = txtley.Text,
                                    .estadobaja = 1
                                                          })

                    Mostrardgv()
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
            If dgvconcepto.RowCount > 0 Then
                txtcod.Text = CStr(dgvconcepto.CurrentRow.Cells(0).Value)
                txtdescripcion.Text = dgvconcepto.CurrentRow.Cells(1).Value
                txtvalor.Text = dgvconcepto.CurrentRow.Cells(2).Value
                cbotipoconcep.SelectedValue = dgvconcepto.CurrentRow.Cells(3).Value
                txtley.Text = dgvconcepto.CurrentRow.Cells(4).Value
                cboestado.SelectedValue = dgvconcepto.CurrentRow.Cells(5).Value
            Else
                MsgBox("No hay registros para editar", MsgBoxStyle.Exclamation, "Error")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Function ExisteReg() As Boolean
        Dim res As Boolean
        Try
            If txtcod.Text.Trim <> "" Or txtcod.Text.Trim <> 0 Then
                Dim id As Integer = txtcod.Text
                If ADConcepto.ExisteID(id) = True Then
                    res = True
                    MsgBox("Existe")
                Else
                    MsgBox("no Existe")
                    res = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return res
    End Function

    Sub Guardar()
        Try
            If dgvconcepto.RowCount = 0 Then
                MsgBox("No hay registros para modificar", MsgBoxStyle.Critical, "Error")
            Else
                If txtdescripcion.Text.Trim = "" Or txtcod.Text.Trim = "" Then
                    MsgBox("Debe seleccionar un registro", MsgBoxStyle.Critical, "Error")
                Else
                    If ExisteReg() = True Then

                        If MsgBox("Seguro desea dar de modificar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                            Dim id As Integer = dgvconcepto.CurrentRow.Cells(0).Value
                            Dim bas As Decimal = 0
                            ' ADConcepto.ModificarConcepto(id, txtdescripcion.Text, bas)
                            MsgBox("el registro se modifico exitosamente", MsgBoxStyle.Information, "Modificación")
                            limpiar()
                            indice()
                        Else
                            MsgBox("Operación cancelada", MsgBoxStyle.Critical, "Cancelación")
                            limpiar()
                            indice()
                        End If
                    Else
                        MsgBox("Debe seleccionar el boton agregar para un nuevo registro,Guardar es para modificar datos", MsgBoxStyle.Information, "Mensaje")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Alta()
        Try
            If dgvconcepto.RowCount = 0 Then
                MsgBox("No hay registros para dar de alta", MsgBoxStyle.Critical, "Error")
            Else

                If MsgBox("Seguro desea dar de alta este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    Dim ide = dgvconcepto.CurrentRow().Cells(0).Value
                    If ide <> 0 Then
                        ADConcepto.DarAlta(ide)
                        ADConcepto.MostrarConcepto(dgvconcepto)
                        MsgBox("Registro actualizado con éxito", MsgBoxStyle.Information, "Actualización")
                        indice()
                    Else
                        MsgBox("Hubo un error al intentar acceder a la base de datos", MsgBoxStyle.Critical, "Error")
                    End If
                Else
                    MsgBox("Operación cancelada", MsgBoxStyle.Critical, "Cancelación")
                    limpiar()
                    indice()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Agregar()
        dgvconcepto.DataSource = Nothing
        Mostrardgv()

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Guardar()
        dgvconcepto.DataSource = Nothing
        Mostrardgv()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Alta()
        dgvconcepto.DataSource = Nothing
        Mostrardgv()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    Private Sub txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
        ADConcepto.Filtra(txtfiltro, dgvconcepto)
    End Sub

    Private Sub dgvconcepto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvconcepto.CellContentClick
        Try
            If dgvconcepto.RowCount <> 0 Then

                Select Case e.ColumnIndex
                    Case 6

                        Editar()
                        Return
                    Case 7
                        Eliminar()
                        Return

                    Case 8
                        MsgBox("Le dio check")
                        Return

                End Select
            Else

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Sub Mostrartodo() 'solovamos a mostrar los dados de baja
        Try
            If chktodo.Checked = True Then
                dgvmanual(dgvconcepto)
                ADConcepto.MostrarConceptoT(dgvconcepto)
                btnAlta.Enabled = True
            Else
                Mostrardgv()
                btnAlta.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chktodo_CheckedChanged(sender As Object, e As EventArgs) Handles chktodo.CheckedChanged
        Mostrartodo()
    End Sub
End Class