Public Class VLocalidad

    Dim ADLocalidad As ADLocalidad = New ADLocalidad
    Dim validar As Validar = New Validar


    Private Sub VLocalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MConfiguracionF.TamañoForm(Me)
        dgvmanual(dgvlocalidad)
        MConfiguracionF.configDGV(dgvlocalidad)
        Mostrardgv()
        MostrarComboProvincia()
        indice()
    End Sub


    Sub MostrarComboProvincia()
        MConfiguracionF.configCombobox(cboprovincia)
        Dim ADProvincia As New ADProvincia
        ADProvincia.MostrarCombo(cboprovincia)
    End Sub



    Sub Mostrardgv()
        dgvmanual(dgvlocalidad)
        ADLocalidad.MostrarLocalidad(dgvlocalidad)
    End Sub
    Sub dgvmanual(dgv As DataGridView)
        Dim provincia As New DataGridViewTextBoxColumn
        provincia.Name = "provincia"
        provincia.HeaderText = "Provincia"

        dgv.AutoGenerateColumns = False
        dgv.Columns.Clear()
        dgv.Columns.Add("id_estadociv", "Código")
        dgv.Columns.Add("descripcion", "Nombre")
        dgv.Columns.Add(provincia)
        dgv.Columns.Add("estadobaja", "Estado Baja")


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

        dgv.Columns(0).DataPropertyName = "id_estadociv"
        dgv.Columns(1).DataPropertyName = "descripcion"
        dgv.Columns(2).DataPropertyName = "provincia"
        dgv.Columns(3).DataPropertyName = "Editar"
        dgv.Columns(4).DataPropertyName = "Eliminar"
        dgv.Columns(5).DataPropertyName = "Estado"
        dgv.Columns(6).DataPropertyName = "estadobaja"
        dgv.Columns(3).Visible = False

    End Sub

    Private Sub pbcerrar_Click(sender As Object, e As EventArgs) Handles pbcerrar.Click
        Me.Close()
    End Sub

    Sub Eliminar()
        Try
            If MsgBox("Seguro desea Eliminar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                Dim ide = dgvlocalidad.CurrentRow().Cells(0).Value
                ADLocalidad.DarBaja(ide)
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


    Sub limpiar()
        txtcod.Clear()
        txtdescripcion.Clear()
        cboprovincia.SelectedValue = -1
    End Sub


    Sub indice()
        If ADLocalidad.index() = 0 Then
            txtcod.Text = 1
        Else
            txtcod.Text = ADLocalidad.index()
        End If
    End Sub


    Function DatosVacios() As Boolean
        Dim result As Boolean = False
        Try
            If txtdescripcion.Text.Trim = "" Or cboprovincia.SelectedValue = -1 Then
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

            If (ADLocalidad.Existe(txtdescripcion.Text) = False) Then

                If MsgBox("Seguro agregar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    ADLocalidad.AgregarLocalidad(New Localidad() With
                                    {
                                    .descripcion = txtdescripcion.Text,
                                    .id_provincia = cboprovincia.SelectedValue.text,
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
            If dgvlocalidad.RowCount > 0 Then
                txtcod.Text = CStr(dgvlocalidad.CurrentRow.Cells(0).Value)
                txtdescripcion.Text = dgvlocalidad.CurrentRow.Cells(1).Value
                cboprovincia.Text = dgvlocalidad.CurrentRow.Cells(2).Value
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
                If ADLocalidad.ExisteID(id) = True Then
                    res = True
                    ' MsgBox("Existe")
                Else
                    'MsgBox("no Existe")
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
            If dgvlocalidad.RowCount = 0 Then
                MsgBox("No hay registros para modificar", MsgBoxStyle.Critical, "Error")
            Else
                If txtdescripcion.Text.Trim = "" Or txtcod.Text.Trim = "" Then
                    MsgBox("Debe seleccionar un registro", MsgBoxStyle.Critical, "Error")
                Else
                    If ExisteReg() = True Then

                        If MsgBox("Seguro desea dar de modificar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                            Dim id As Integer = dgvlocalidad.CurrentRow.Cells(0).Value
                            Dim bas As Decimal = 0

                            ADLocalidad.ModificarLocalidad(txtcod.Text, txtdescripcion.Text)
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
            If dgvlocalidad.RowCount = 0 Then
                MsgBox("No hay registros para dar de alta", MsgBoxStyle.Critical, "Error")
            Else

                If MsgBox("Seguro desea dar de alta este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    Dim ide = dgvlocalidad.CurrentRow().Cells(0).Value
                    If ide <> 0 Then
                        ADLocalidad.DarAlta(ide)
                        ADLocalidad.MostrarLocalidad(dgvlocalidad)
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

    Sub Refrescar()
        dgvlocalidad.DataSource = Nothing
        Mostrardgv()
        limpiar()
        indice()
    End Sub

    Private Sub dgvlocalidad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlocalidad.CellContentClick
        Try
            If validar.DatagridVacio(dgvlocalidad) = False Then
                Select Case e.ColumnIndex
                    Case 3

                        Editar()
                        Return
                    Case 4
                        Eliminar()
                        Return

                    Case 5
                        MsgBox("Le dio check")
                        Return

                End Select
            Else

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Agregar()
        Refrescar()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Guardar()
        Refrescar()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Alta()
        Refrescar()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
        Refrescar()
    End Sub

    Private Sub txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
        ADLocalidad.Filtra(txtfiltro, dgvlocalidad)
    End Sub
End Class