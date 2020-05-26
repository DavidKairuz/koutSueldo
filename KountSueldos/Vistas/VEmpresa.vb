Public Class VEmpresa
    Dim ADEmpresa As ADEmpresa = New ADEmpresa
    Dim validar As Validar = New Validar

    ' Dim Empresa As EEmpresa = New EEmpresa

    Private Sub VEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MConfiguracionF.TamañoForm(Me)
        dgvmanual(dgvempresa)
        MConfiguracionF.configDGV(dgvempresa)
        Mostrardgv()
        MostrarComboProvincia()
        MostrarComboRazonsocial()
        indice()
    End Sub

    Sub Mostrardgv()
        ADEmpresa.MostrarEmpresa(dgvempresa)
    End Sub

    Sub MostrarComboProvincia()
        MConfiguracionF.configCombobox(cboprovincia)
        Dim ADProvincia As New ADProvincia
        ADProvincia.MostrarCombo(cboprovincia)
    End Sub

    Sub MostrarComboRazonsocial()
        MConfiguracionF.configCombobox(cborazonsoc)
        Dim ADRazonSocial As New ADRazonSocial
        ADRazonSocial.MostrarCombo(cborazonsoc)
    End Sub


    Sub dgvmanual(dgv As DataGridView)

        dgv.AutoGenerateColumns = False
        dgv.Columns.Clear()

        Dim provinciacol As New DataGridViewTextBoxColumn
        provinciacol.Name = "provincia"
        provinciacol.HeaderText = "Provincia"

        Dim razonsocialcol As New DataGridViewTextBoxColumn
        razonsocialcol.Name = "razonsocial"
        razonsocialcol.HeaderText = "RazonSocial"

        dgv.Columns.Add("id_empresa", "Código")
        dgv.Columns.Add("nombrefantasia", "Nombre")
        dgv.Columns.Add("direccion", "Dirección")
        dgv.Columns.Add("telefono", "Telefono")
        dgv.Columns.Add("email", "E-mail")
        dgv.Columns.Add("ciuE", "CUIT")
        ' dgv.Columns.Add(provinciacol)
        'dgv.Columns.Add(razonsocialcol)


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
        dgv.Columns(0).DataPropertyName = "id_empresa"
        dgv.Columns(1).DataPropertyName = "nombrefantasia"
        dgv.Columns(2).DataPropertyName = "direccion"
        dgv.Columns(3).DataPropertyName = "telefono"
        dgv.Columns(4).DataPropertyName = "email"
        dgv.Columns(5).DataPropertyName = "cuitE"
        '  dgv.Columns(6).DataPropertyName = "provincia"
        ' dgv.Columns(7).DataPropertyName = "razonsocial"
        dgv.Columns(6).DataPropertyName = "Editar"
        dgv.Columns(7).DataPropertyName = "Eliminar"
        '  dgv.Columns(10).DataPropertyName = "estadobaja"
        ' dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '  dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
    End Sub

    Private Sub pbcerrar_Click(sender As Object, e As EventArgs) Handles pbcerrar.Click
        Me.Close()
    End Sub

    Sub Eliminar()
        Try
            If MsgBox("Seguro desea Eliminar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                Dim ide = dgvempresa.CurrentRow().Cells(0).Value
                ADEmpresa.DarBaja(ide)
                ADEmpresa.MostrarEmpresa(dgvempresa)
                MsgBox("Registro Eliminado con éxito", MsgBoxStyle.Information, "Eliminación")
                indice()
            Else
                MsgBox("Operación cancelada", MsgBoxStyle.Critical, "Cancelación")
                limpiar()
                indice()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub limpiar()
        txtcod.Clear()
        txtnombrefsia.Clear()
        txtdireccion.Clear()
        txtemail.Clear()
        txttelefono.Clear()
        mkcuit.Clear()
        cboprovincia.SelectedIndex = -1
        cborazonsoc.SelectedIndex = -1
    End Sub


    Sub indice()

        If ADEmpresa.index() = 0 Then
            txtcod.Text = 1
        Else
            txtcod.Text = ADEmpresa.index()
        End If

    End Sub
    Function DatosVacios() As Boolean

        Dim result As Boolean
        Try

            If txtnombrefsia.Text.Trim = "" Or txtemail.Text.Trim = "" Or txttelefono.Text.Trim = "" Or cboprovincia.SelectedValue <> -1 Or cborazonsoc.SelectedValue <> -1 Then
                result = False
            Else
                result = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
        End Try
        Return result
    End Function

    Function ConvertirCuit(palabra As String) As String
        Dim texto1 As String = ""
        Try
            If palabra <> "" Then
                texto1 = palabra
                texto1 = texto1.Replace("-", "")
            Else
                texto1 = "00000000000"

            End If
        Catch ex As Exception

        End Try

        Return texto1
    End Function
    Sub Agregar()
        If DatosVacios() = True Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Information, "Aviso")
            txtnombrefsia.Focus()
        Else

            If (ADEmpresa.Existe(txtnombrefsia.Text) = False) Then

                If MsgBox("Seguro agregar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
                    Dim cuit As String = ConvertirCuit(mkcuit.Text)
                    ADEmpresa.AgregarEmpresa(New Empresa() With
                                    {
                                    .nombrefantasia = CStr(txtnombrefsia.Text),
                                    .direccion = CStr(txtdireccion.Text),
                                    .email = CStr(txtemail.Text),
                                    .telefono = CStr(txttelefono.Text),
                                    .cuitE = cuit,
                                    .estadobaja = 1
                                                          })

                    ADEmpresa.MostrarEmpresa(dgvempresa)
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



    Function ExisteReg() As Boolean
        Dim res As Boolean
        Try
            If txtcod.Text.Trim <> "" Or txtcod.Text.Trim <> 0 Then
                Dim id As Integer = txtcod.Text
                If ADEmpresa.ExisteID(id) = True Then
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
            If dgvempresa.RowCount = 0 Then
                MsgBox("No hay registros para modificar", MsgBoxStyle.Critical, "Error")
            Else
                If txtnombrefsia.Text.Trim = "" Or txtcod.Text.Trim = "" Then
                    MsgBox("Debe seleccionar un registro", MsgBoxStyle.Critical, "Error")
                Else
                    If ExisteReg() = True Then

                        If MsgBox("Seguro desea dar de modificar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                            Dim id As Integer = dgvempresa.CurrentRow.Cells(0).Value
                            Dim bas As Decimal = 0

                            ADEmpresa.ModificarEmpresa(txtcod.Text, txtnombrefsia.Text, txtdireccion.Text, txttelefono.Text, txtemail.Text, mkcuit.Text, cboprovincia.SelectedValue, cborazonsoc.SelectedValue)

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


    Sub codigoaguradr()
        '  .provincia = cboprovincia.SelectedValue,
        '.id_razonsocial = cborazonsoc.SelectedValue,
    End Sub
    Sub Alta()
        Try
            If dgvempresa.RowCount = 0 Then
                MsgBox("No hay registros para dar de alta", MsgBoxStyle.Critical, "Error")
            Else

                If MsgBox("Seguro desea dar de alta este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    Dim ide = dgvempresa.CurrentRow().Cells(0).Value
                    If ide <> 0 Then
                        ADEmpresa.DarAlta(ide)
                        ADEmpresa.MostrarEmpresa(dgvempresa)
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
        dgvempresa.DataSource = Nothing
        Mostrardgv()
        limpiar()
    End Sub

    Sub Editar()
        Try
            If dgvempresa.RowCount > 0 Then
                txtcod.Text = CStr(dgvempresa.CurrentRow.Cells(0).Value)
                txtnombrefsia.Text = CStr(dgvempresa.CurrentRow.Cells(1).Value)
                txtdireccion.Text = dgvempresa.CurrentRow.Cells(2).Value
                txttelefono.Text = dgvempresa.CurrentRow.Cells(3).Value
                txtemail.Text = dgvempresa.CurrentRow.Cells(4).Value
                mkcuit.Text = dgvempresa.CurrentRow.Cells(5).Value
                '  cboprovincia.Text = dgvempresa.CurrentRow.Cells(6).Value
                ' cborazonsoc.Text = dgvempresa.CurrentRow.Cells(7).Value
            Else
                MsgBox("No hay registros para editar", MsgBoxStyle.Exclamation, "Error")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub dgvempresa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvempresa.CellContentClick
        Try
            If dgvempresa.RowCount <> 0 Then

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
                dgvmanual(dgvempresa)
                ADEmpresa.MostrarEmpresaT(dgvempresa)
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
        Refrescar()
    End Sub

    Private Sub txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
        ADEmpresa.FiltraName(txtfiltro, dgvempresa)
    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtnombrefsia.TextChanged

    End Sub
End Class