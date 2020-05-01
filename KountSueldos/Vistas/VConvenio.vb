Public Class VConvenio
    Dim ADConvenio As ADConvenio = New ADConvenio
    Dim validar As Validar = New Validar

    Private Sub VTipoConvenio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MConfiguracionF.TamañoForm(Me)
        dgvmanual(dgvconvenio)
        MConfiguracionF.configDGV(dgvconvenio)
        Mostrardgv()
        indice()
    End Sub

    Sub Mostrardgv()
        ADConvenio.MostrarConvenioT(dgvconvenio)
    End Sub
    Sub dgvmanual(dgv As DataGridView)

        dgv.AutoGenerateColumns = False
        dgv.Columns.Clear()

        dgv.Columns.Add("id_convenio", "Código")
        dgv.Columns.Add("descripcion", "Descripción")

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
        dgv.Columns(0).DataPropertyName = "id_convenio"
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

                Dim ide = dgvconvenio.CurrentRow().Cells(0).Value
                ADConvenio.DarBaja(ide)
                ADConvenio.MostrarConvenio(dgvconvenio)
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

    Sub Agregar()
        If validar.vacio(txtdescripcion) = True Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Information, "Aviso")
            txtdescripcion.Focus()
        Else

            If (ADConvenio.Existe(txtdescripcion.Text) = False) Then

                If MsgBox("Seguro agregar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    ADConvenio.AgregarConvenio(New Convenio() With
                                    {
                                    .descripcion = txtdescripcion.Text,
                                    .estadobaja = 1
                                    })

                    ADConvenio.MostrarConvenio(dgvconvenio)
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

    Sub limpiar()
        txtcod.Clear()
        txtdescripcion.Clear()
    End Sub
    Sub indice()
        txtcod.Text = ADConvenio.index()

    End Sub
    Private Sub dgvtipo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvconvenio.CellContentClick

        Try
            If validar.DatagridVacio(dgvconvenio) = False Then


                Select Case e.ColumnIndex
                    Case 2

                        txtcod.Text = CStr(dgvconvenio.CurrentRow.Cells(0).Value)
                        txtdescripcion.Text = CStr(dgvconvenio.CurrentRow.Cells(1).Value)

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
        ADConvenio.Filtra(txtfiltro, dgvconvenio)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Agregar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub
End Class