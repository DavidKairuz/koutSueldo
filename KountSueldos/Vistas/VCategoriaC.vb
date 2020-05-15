Public Class VCategoriaC
    Dim ADCategoriaC As ADCategoriaC = New ADCategoriaC
    Dim validas As Validar = New Validar


    Private Sub VCategoriaC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MConfiguracionF.TamañoForm(Me)
        dgvmanual(dgvcategoria)
        MConfiguracionF.configDGV(dgvcategoria)
        Mostrardgv()
        MostrarComboConvenio()
        indice()
    End Sub

    Sub Mostrardgv()
        ADCategoriaC.MostrarCategoria(dgvcategoria)
    End Sub
    Sub dgvmanual(dgv As DataGridView)

        dgv.AutoGenerateColumns = False
        dgv.Columns.Clear()

        Dim con As New DataGridViewTextBoxColumn
        con.Name = "convenio"
        con.HeaderText = "Convenio"
        Dim basico As New DataGridViewTextBoxColumn
        basico.Name = "basico"

        basico.HeaderText = "Sueldo Basico"
        dgv.Columns.Add("id_categoria", "Código")
        dgv.Columns.Add("descripcion", "Categoria")
        dgv.Columns.Add(con)
        dgv.Columns.Add(basico)

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
        dgv.Columns(0).DataPropertyName = "id_categoria"
        dgv.Columns(1).DataPropertyName = "descripcion"
        dgv.Columns(2).DataPropertyName = "Convenio"
        dgv.Columns(3).DataPropertyName = "Sueldo Basico"
        dgv.Columns(4).DataPropertyName = "Editar"
        dgv.Columns(5).DataPropertyName = "Eliminar"
        dgv.Columns(6).DataPropertyName = "estadobaja"
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
    End Sub

    Private Sub pbcerrar_Click(sender As Object, e As EventArgs) Handles pbcerrar.Click
        Me.Close()
    End Sub

    Sub Eliminar()
        Try
            If MsgBox("Seguro desea Eliminar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                Dim ide = dgvcategoria.CurrentRow().Cells(0).Value
                ADCategoriaC.DarBaja(ide)
                ADCategoriaC.MostrarCategoria(dgvcategoria)
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

    Sub MostrarComboConvenio()
        MConfiguracionF.configCombobox(cboconvenio)
        Dim ADConvenio As New ADConvenio
        ADConvenio.MostrarComboConvenio(cboconvenio)
    End Sub
    Sub limpiar()
        txtcod.Clear()
        txtdescripcion.Clear()
        cboconvenio.SelectedValue = -1
        txtbasico.Clear()
    End Sub
    Sub indice()
        If ADCategoriaC.index() = 0 Then
            txtcod.Text = 1
        Else
            txtcod.Text = ADCategoriaC.index
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

            If (ADCategoriaC.Existe(txtdescripcion.Text) = False) Then

                If MsgBox("Seguro agregar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    ADCategoriaC.AgregarCategoria(New CategoriaC() With
                                    {
                                    .descripcion = txtdescripcion.Text,
                                    .estadobaja = 1
                                                          })

                    ADCategoriaC.MostrarCategoria(dgvcategoria)
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
            If dgvcategoria.RowCount > 0 Then
                txtcod.Text = CStr(dgvcategoria.CurrentRow.Cells(0).Value)
                txtdescripcion.Text = dgvcategoria.CurrentRow.Cells(1).Value
                cboconvenio.SelectedValue = dgvcategoria.CurrentRow.Cells(2).Value
                txtbasico.Text = dgvcategoria.CurrentRow.Cells(3).Value

            Else
                MsgBox("No hay registros para editar", MsgBoxStyle.Exclamation, "Error")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Sub Guardar()
        Try
            If dgvcategoria.RowCount = 0 Then
                MsgBox("No hay registros para editar", MsgBoxStyle.Critical, "Error")
            Else
                If txtdescripcion.Text.Trim = "" Or txtcod.Text.Trim = "" Then
                    MsgBox("Debe seleccionar un registro", MsgBoxStyle.Critical, "Error")
                Else
                    If MsgBox("Seguro desea dar de modificar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                        Dim id As Integer = dgvcategoria.CurrentRow.Cells(0).Value
                        Dim bas As Decimal = 0
                        ADCategoriaC.ModificarCategoriaC(id, txtdescripcion.Text, bas)
                        MsgBox("el registro se modifico exitosamente", MsgBoxStyle.Information, "Modificación")
                    Else
                        MsgBox("Operación cancelada", MsgBoxStyle.Critical, "Cancelación")
                        limpiar()
                        indice()

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Alta()
        Try
            If dgvcategoria.RowCount = 0 Then
                MsgBox("No hay registros para dar de alta", MsgBoxStyle.Critical, "Error")
            Else

                If MsgBox("Seguro desea dar de alta este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    Dim ide = dgvcategoria.CurrentRow().Cells(0).Value
                    If ide <> 0 Then


                        ADCategoriaC.DarAlta(ide)
                        ADCategoriaC.MostrarCategoria(dgvcategoria)
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

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs)
        Agregar()
        limpiar()
        indice()
    End Sub



    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Guardar()
        limpiar()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Alta()
        limpiar()
        indice()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
        indice()
    End Sub

    Private Sub txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
        ADCategoriaC.Filtra(txtfiltro, dgvcategoria)
    End Sub

    Private Sub dgvcategoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcategoria.CellContentClick
        Try
            If dgvcategoria.RowCount <> 0 Then

                Select Case e.ColumnIndex
                    Case 4

                        Editar()
                        Return
                    Case 5
                        Eliminar()
                        Return

                    Case 6
                        MsgBox("Le dio check")
                        Return

                End Select
            Else

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtbasico_TextChanged(sender As Object, e As EventArgs) Handles txtbasico.TextChanged
        Dim texto As String
        texto = txtdescripcion.Text
        validas.validarnumeros(texto, e)
    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged
        Dim texto As String
        texto = txtdescripcion.Text
        validas.validartexto(texto, e)
    End Sub
End Class