Public Class VObrasocial


    Dim ADObraSocial As ADObraSocial = New ADObraSocial
    Dim validar As Validar = New Validar


    Private Sub VObrasocial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MConfiguracionF.TamañoForm(Me)
        MConfiguracionF.configDGV(dgvobras)
        Mostrardgv()
        indice()
    End Sub


    Sub Mostrardgv()
        dgvmanual(dgvobras)
        ADObraSocial.MostrarObra_Social(dgvobras)
    End Sub
    Sub dgvmanual(dgv As DataGridView)

        dgv.AutoGenerateColumns = False
        dgv.Columns.Clear()
        Dim tipoconceto As New DataGridViewTextBoxColumn
        tipoconceto.Name = "tipoconcepto"
        tipoconceto.HeaderText = "Tipo Concepto"

        dgv.Columns.Add("id_obrasocial", "Código")
        dgv.Columns.Add("descripcion", "Nombre")

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

        dgv.Columns(0).DataPropertyName = "id_obrasocial"
        dgv.Columns(1).DataPropertyName = "descripcion"
        dgv.Columns(2).DataPropertyName = "estadobaja"
        dgv.Columns(3).DataPropertyName = "estado"
        dgv.Columns(4).DataPropertyName = "Editar"
        dgv.Columns(5).DataPropertyName = "Eliminar"
        dgv.Columns(2).Visible = False

    End Sub

    Private Sub pbcerrar_Click(sender As Object, e As EventArgs) Handles pbcerrar.Click
        Me.Close()
    End Sub

    Sub Eliminar()
        Try
            If MsgBox("Seguro desea Eliminar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                Dim ide = dgvobras.CurrentRow().Cells(0).Value
                ADObraSocial.DarBaja(ide)
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

    End Sub


    Sub indice()
        If ADObraSocial.index() = 0 Then
            txtcod.Text = 1
        Else
            txtcod.Text = ADObraSocial.index
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

            If (ADObraSocial.Existe(txtdescripcion.Text) = False) Then

                If MsgBox("Seguro agregar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    ADObraSocial.AgregarObra_Social(New Obra_Social() With
                                    {
                                    .descripcion = txtdescripcion.Text,
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
            If dgvobras.RowCount > 0 Then
                txtcod.Text = CStr(dgvobras.CurrentRow.Cells(0).Value)
                txtdescripcion.Text = dgvobras.CurrentRow.Cells(1).Value
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
                If ADObraSocial.ExisteID(id) = True Then
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
            If dgvobras.RowCount = 0 Then
                MsgBox("No hay registros para modificar", MsgBoxStyle.Critical, "Error")
            Else
                If txtdescripcion.Text.Trim = "" Or txtcod.Text.Trim = "" Then
                    MsgBox("Debe seleccionar un registro", MsgBoxStyle.Critical, "Error")
                Else
                    If ExisteReg() = True Then

                        If MsgBox("Seguro desea dar de modificar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                            Dim id As Integer = dgvobras.CurrentRow.Cells(0).Value
                            Dim bas As Decimal = 0

                            ADObraSocial.ModificarObra_Social(txtcod.Text, txtdescripcion.Text)
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
            If dgvobras.RowCount = 0 Then
                MsgBox("No hay registros para dar de alta", MsgBoxStyle.Critical, "Error")
            Else

                If MsgBox("Seguro desea dar de alta este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    Dim ide = dgvobras.CurrentRow().Cells(0).Value
                    If ide <> 0 Then
                        ADObraSocial.DarAlta(ide)
                        ADObraSocial.MostrarObra_Social(dgvobras)
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
        dgvobras.DataSource = Nothing
        Mostrardgv()
        limpiar()
    End Sub

    Private Sub dgvobras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvobras.CellContentClick
        Try
            If dgvobras.RowCount <> 0 Then

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

                dgvmanual(dgvobras)
                ADObraSocial.MostrarObra_SocialT(dgvobras)
                btnAlta.Enabled = True
            Else
                Mostrardgv()
                btnAlta.Enabled = False
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
        indice()
    End Sub
End Class