Public Class VActividad
    Dim AccesoDatosActividad As AccesoDatosActividad = New AccesoDatosActividad
    Dim ADConvenio As ADConvenio = New ADConvenio
    Dim validar As Validar = New Validar
    Private Sub lbltitulo_Click(sender As Object, e As EventArgs) Handles lbltitulo.Click

    End Sub

    Private Sub VActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MConfiguracionF.TamañoForm(Me)
        dgvmanual(dgvactividad)
        MConfiguracionF.configDGV(dgvactividad)
        Mostrardgv()
        indice()
        MostrarComboConvenio()
        MostrarComboCategoria()
    End Sub
    Sub Mostrardgv()
        AccesoDatosActividad.MostrarGrid(dgvactividad)
    End Sub
    Sub indice()
        txtcod.Text = AccesoDatosActividad.index()

    End Sub
    Sub dgvmanual(dgv As DataGridView)
        Dim codigo As New DataGridViewColumn
        Dim convenio As New DataGridViewColumn
        Dim unidad As New DataGridViewColumn
        Dim valor As New DataGridViewColumn
        Dim descripcion As New DataGridViewColumn
        dgv.AutoGenerateColumns = False
        dgv.Columns.Clear()


        codigo.Name = "Codigo"
        descripcion.Name = "Actividad"
        convenio.Name = "Convenio"
        unidad.Name = "Categoria"
        valor.Name = "Valor"

        dgv.Columns.Add(codigo)
        dgv.Columns.Add(convenio)
        dgv.Columns.Add(unidad)
        dgv.Columns.Add(valor)
        dgv.Columns.Add(descripcion)

        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
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
        dgv.Columns(0).DataPropertyName = "Codigo"
        dgv.Columns(1).DataPropertyName = "Actividad"
        dgv.Columns(2).DataPropertyName = "Convenio"
        dgv.Columns(3).DataPropertyName = "Categoria"
        dgv.Columns(4).DataPropertyName = "Editar"
        dgv.Columns(5).DataPropertyName = "Eliminar"
        dgv.Columns(6).DataPropertyName = "estadobaja"

    End Sub

    Private Sub pbcerrar_Click(sender As Object, e As EventArgs) Handles pbcerrar.Click
        Me.Close()
    End Sub
    Sub MostrarComboConvenio()
        MConfiguracionF.configCombobox(cboconvenio)
        AccesoDatosActividad.MostrarComboConvenio(cboconvenio)
    End Sub

    Sub MostrarComboCategoria()
        MConfiguracionF.configCombobox(cbocategoria)
        AccesoDatosActividad.MostrarComboCategoria(cbocategoria)
    End Sub
    Sub limpiar()
        txtcod.Clear()
        txtdescripcion.Clear()
    End Sub

    Sub Eliminar()
        Try
            If MsgBox("Seguro desea Eliminar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                Dim ide = dgvactividad.CurrentRow().Cells(0).Value
                AccesoDatosActividad.DarBaja(ide)
                AccesoDatosActividad.MostrarGrid(dgvactividad)
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
    Function DatosVacios() As Boolean

        Dim result As Boolean
        Try

            If txtdescripcion.Text.Trim = "" Or cboconvenio.SelectedValue = -1 Or cbocategoria.SelectedValue = -1 Then
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

            If (AccesoDatosActividad.Existe(txtdescripcion.Text) = False) Then

                If MsgBox("Seguro agregar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    AccesoDatosActividad.AgregarActividad(New Actividad() With
                                    {
                                    .id_convenio = CInt(cboconvenio.SelectedValue.ToString),
                                    .descripcion = txtdescripcion.Text,
                                    .id_categoria = CInt(cbocategoria.SelectedValue.ToString),
                                    .estadobaja = 1
                                                          })




                    AccesoDatosActividad.MostrarGrid(dgvactividad)
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
        txtcod.Text = CStr(dgvactividad.CurrentRow.Cells(0).Value)
        cboconvenio.SelectedValue = dgvactividad.CurrentRow.Cells(2).Value
        txtdescripcion.Text = CStr(dgvactividad.CurrentRow.Cells(1).Value)
        cbocategoria.SelectedValue = dgvactividad.CurrentRow.Cells(4).Value
    End Sub
    Private Sub dgvactividad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvactividad.CellContentClick
        Try
            If validar.DatagridVacio(dgvactividad) = False Then


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


    Private Sub txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
        AccesoDatosActividad.Filtra(txtfiltro, dgvactividad)
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Agregar()
    End Sub

    Private Sub chktodo_CheckedChanged(sender As Object, e As EventArgs) Handles chktodo.CheckedChanged

    End Sub
End Class