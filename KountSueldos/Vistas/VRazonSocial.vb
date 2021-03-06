﻿Public Class VRazonSocial
    Dim ADRazonSocial As ADRazonSocial = New ADRazonSocial
    Dim validar As Validar = New Validar
    Private Sub VRazonSocial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MConfiguracionF.TamañoForm(Me)
        dgvmanual(dgvrazon)
        MConfiguracionF.configDGV(dgvrazon)
        Mostrardgv()
        indice()
    End Sub

    Sub Mostrardgv()
        ADRazonSocial.MostrarRazon_Social(dgvrazon)
    End Sub
    Sub dgvmanual(dgv As DataGridView)

        dgv.AutoGenerateColumns = False
        dgv.Columns.Clear()

        dgv.Columns.Add("id_razonsocial", "Código")
        dgv.Columns.Add("descripcion", "Razón Social")

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
        dgv.Columns(0).DataPropertyName = "id_razonsocial"
        dgv.Columns(1).DataPropertyName = "descripcion"
        dgv.Columns(2).DataPropertyName = "Editar"
        dgv.Columns(3).DataPropertyName = "Eliminar"
        dgv.Columns(4).DataPropertyName = "estadobaja"
    End Sub

    Private Sub pbcerrar_Click(sender As Object, e As EventArgs) Handles pbcerrar.Click
        Me.Close()
    End Sub

    Sub Eliminar()
        Try
            If MsgBox("Seguro desea Eliminar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                Dim ide = dgvrazon.CurrentRow().Cells(0).Value
                ADRazonSocial.DarBaja(ide)
                ADRazonSocial.MostrarRazon_Social(dgvrazon)
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
        If ADRazonSocial.index() = 0 Then
            txtcod.Text = 1
        Else
            txtcod.Text = ADRazonSocial.index
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
            If (ADRazonSocial.Existe(txtdescripcion.Text) = False) Then
                If MsgBox("Seguro agregar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    ADRazonSocial.AgregarRazon_Social(New Razon_Social() With
                                    {
                                    .descripcion = txtdescripcion.Text,
                                    .estadobaja = 1
                                                          })
                    ADRazonSocial.MostrarRazon_Social(dgvrazon)
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
            If dgvrazon.RowCount > 0 Then
                txtcod.Text = CStr(dgvrazon.CurrentRow.Cells(0).Value)
                txtdescripcion.Text = CStr(dgvrazon.CurrentRow.Cells(1).Value)
            Else
                MsgBox("No hay registros para editar", MsgBoxStyle.Exclamation, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Guardar()
        Try
            If dgvrazon.RowCount = 0 Then
                MsgBox("No hay registros para editar", MsgBoxStyle.Critical, "Error")
            Else
                If txtdescripcion.Text.Trim = "" Or txtcod.Text.Trim = "" Then
                    MsgBox("Debe seleccionar un registro", MsgBoxStyle.Information, "Seleccionar")
                Else
                    If MsgBox("Seguro desea dar de modificar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                        Dim id As Integer = dgvrazon.CurrentRow.Cells(0).Value
                        ADRazonSocial.ModificarRazon_Social(id, txtdescripcion.Text)
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
            If dgvrazon.RowCount = 0 Then
                MsgBox("No hay registros para dar de alta", MsgBoxStyle.Critical, "Error")
            Else

                If MsgBox("Seguro desea dar de alta este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    Dim ide = dgvrazon.CurrentRow().Cells(0).Value
                    If ide <> 0 And chktodo.Checked = True Then
                        ADRazonSocial.DarAlta(ide)
                        ADRazonSocial.MostrarRazon_Social(dgvrazon)
                        MsgBox("Registro actualizado con éxito", MsgBoxStyle.Information, "Actualización")
                        indice()
                    Else
                        MsgBox("Debe seleccionar un registro dado de baja para esta operación", MsgBoxStyle.Critical, "Error")
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


    Sub Refrescar()
        dgvrazon.DataSource = Nothing
        Mostrardgv()
        limpiar()
        indice()
    End Sub


    Sub Mostrartodo() 'solovamos a mostrar los dados de baja
        Try
            If chktodo.Checked = True Then
                dgvmanual(dgvrazon)
                ADRazonSocial.MostrarRazon_SocialT(dgvrazon)
                btnAlta.Enabled = True
            Else
                Mostrardgv()
                btnAlta.Enabled = False
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
                If ADRazonSocial.ExisteID(id) = True Then
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




    Private Sub btnnuevo_Click_1(sender As Object, e As EventArgs) Handles btnnuevo.Click
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

    Private Sub txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
        ADRazonSocial.Filtra(txtfiltro, dgvrazon)
    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged
        '        Dim texto As String
        '       texto = txtdescripcion.Text
        '      validar.validartexto(texto, e)
    End Sub

    Private Sub dgvrazon_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvrazon.CellContentClick
        Try
            If dgvrazon.RowCount <> 0 Then

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