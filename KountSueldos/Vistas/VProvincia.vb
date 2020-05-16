Public Class VProvincia

    Dim ADProvincia As ADProvincia = New ADProvincia
    Dim validar As Validar = New Validar


    Private Sub VProvincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MConfiguracionF.TamañoForm(Me)
        dgvmanual(dgvprovincia)
        MConfiguracionF.configDGV(dgvprovincia)
        Mostrardgv()
        ' indice()
    End Sub


    Sub Mostrardgv()
        ADProvincia.MostrarProvincia(dgvprovincia)
    End Sub
    Sub dgvmanual(dgv As DataGridView)

        dgv.AutoGenerateColumns = False
        dgv.Columns.Clear()

        dgv.Columns.Add("id_provincia", "Código")
        dgv.Columns.Add("descripcion", "Provincia")

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
        dgv.Columns(0).DataPropertyName = "id_provincia"
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

                Dim ide = dgvprovincia.CurrentRow().Cells(0).Value
                ADProvincia.DarBaja(ide)
                ADProvincia.MostrarProvincia(dgvprovincia)
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
            If ADProvincia.index() = 0 Then
                txtcod.Text = 1
            Else
                txtcod.Text = ADProvincia.index
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

            If (ADProvincia.Existe(txtdescripcion.Text) = False) Then

                If MsgBox("Seguro agregar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    ADProvincia.AgregarProvincia(New Provincia() With
                                    {
                                    .descripcion = txtdescripcion.Text,
                                    .estadobaja = 1
                                                          })

                    ADProvincia.MostrarProvincia(dgvprovincia)
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
            If dgvprovincia.RowCount > 0 Then
                txtcod.Text = CStr(dgvprovincia.CurrentRow.Cells(0).Value)
                txtdescripcion.Text = CStr(dgvprovincia.CurrentRow.Cells(1).Value)
            Else
                MsgBox("No hay registros para editar", MsgBoxStyle.Exclamation, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Guardar()
        Try
            If dgvprovincia.RowCount = 0 Then
                MsgBox("No hay registros para editar", MsgBoxStyle.Critical, "Error")
            Else
                If txtdescripcion.Text.Trim = "" Or txtcod.Text.Trim = "" Then
                    MsgBox("Debe seleccionar un registro", MsgBoxStyle.Information, "Seleccionar")
                Else
                    If MsgBox("Seguro desea dar de modificar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                        ' Dim id As Integer = dgvprovincia.CurrentRow.Cells(0).Value
                        ADProvincia.ModificarProvincia(txtcod.Text, txtdescripcion.Text)
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
            If dgvprovincia.RowCount = 0 Then
                MsgBox("No hay registros para dar de alta", MsgBoxStyle.Critical, "Error")
            Else

                If MsgBox("Seguro desea dar de alta este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    Dim ide = dgvprovincia.CurrentRow().Cells(0).Value
                    If ide <> 0 Then
                        ADProvincia.DarAlta(ide)
                        ADProvincia.MostrarProvincia(dgvprovincia)
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
    Private Sub dgvprovincia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvprovincia.CellContentClick
        Try
            If validar.DatagridVacio(dgvprovincia) = False Then
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


    Sub Refrescar()
        dgvprovincia.DataSource = Nothing
        Mostrardgv()
        limpiar()
        indice()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs)
        Agregar()
        Refrescar()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
        Refrescar()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Guardar()
        Refrescar()
    End Sub



    Private Sub txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
        ADProvincia.Filtra(txtfiltro, dgvprovincia)
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Alta()
        Refrescar()
    End Sub
End Class