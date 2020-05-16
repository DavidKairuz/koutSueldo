Public Class VEmpleado
    Dim ADEmpleado As ADEmpleado = New ADEmpleado
    Dim validar As Validar = New Validar


    Dim formPosition As Point
    Dim mouseAction As Boolean

    Private Sub frmPA_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        formPosition = New Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y)
        mouseAction = True
    End Sub

    Private Sub frmPA_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If mouseAction = True Then
            Location = New Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y)
        End If
    End Sub

    Private Sub frmPA_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        mouseAction = False
    End Sub


    Private Sub VEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MConfiguracionF.TamañoForm(Me)
        dgvmanual(dgvempleado)
        MConfiguracionF.configDGV(dgvempleado)
        Mostrardgv()
    End Sub





    Private Sub rbcuil_CheckedChanged(sender As Object, e As EventArgs) Handles rbcuil.CheckedChanged
        Elegirfiltro()
    End Sub

    Sub Elegirfiltro()
        If rbcuil.Checked = True Then
            txtfiltrocuil.Enabled = True
            rbapellido.Checked = False
            txtfiltro.Enabled = False
        Else
            rbapellido.Checked = True
            rbcuil.Checked = False
            txtfiltro.Enabled = True
            txtfiltrocuil.Enabled = False

        End If
    End Sub

    Sub Mostrardgv()
        ADEmpleado.MostrarEmpleado(dgvempleado)
    End Sub
    Sub dgvmanual(dgv As DataGridView)

        Dim obrasoc As New DataGridViewTextBoxColumn
        obrasoc.Name = "obrasocial"
        obrasoc.HeaderText = "Obra social"

        Dim estadocivil As New DataGridViewTextBoxColumn
        estadocivil.HeaderText = "EstadoCivil"
        estadocivil.Name = "estadocivil"

        Dim categoria As New DataGridViewTextBoxColumn
        categoria.Name = "categoria"
        categoria.HeaderText = "Categoria"

        Dim actividad As New DataGridViewTextBoxColumn
        actividad.Name = "actividad"
        actividad.HeaderText = "Actividad"

        Dim empresa As New DataGridViewTextBoxColumn
        empresa.Name = "empresa"
        empresa.HeaderText = "Empresa"

        dgv.AutoGenerateColumns = False
        dgv.Columns.Clear()
        dgv.Columns.Add("id_empleado", "Código")
        dgv.Columns.Add("cuil", "CUIL")
        dgv.Columns.Add("nombre", "Nombre")
        dgv.Columns.Add("apellido", "Apellido")
        dgv.Columns.Add("dni", "DNI")
        dgv.Columns.Add("direccion", "Direccion")
        dgv.Columns.Add("telefono", "Telefono")
        dgv.Columns.Add("email", "Email")
        dgv.Columns.Add("fecha_ing", "Ingreso")
        dgv.Columns.Add("fecha_nac", "F.Nacimiento")
        dgv.Columns.Add("hijos", "Nº Hijos")
        dgv.Columns.Add("antiguedad", "Antiguedad")

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
        dgv.Columns(0).DataPropertyName = "id_empleado"
        dgv.Columns(1).DataPropertyName = "nombre"
        dgv.Columns(2).DataPropertyName = "apellido"
        dgv.Columns(3).DataPropertyName = "dni"
        dgv.Columns(4).DataPropertyName = "direccion"
        dgv.Columns(5).DataPropertyName = "telefono"
        dgv.Columns(6).DataPropertyName = "email"
        dgv.Columns(7).DataPropertyName = "fecha_nac"
        dgv.Columns(8).DataPropertyName = "fecha_ing"
        dgv.Columns(9).DataPropertyName = "empresa"
        dgv.Columns(10).DataPropertyName = "actividad"

        'dgv.Columns().DataPropertyName = "Editar"
        'dgv.Columns().DataPropertyName = "Eliminar"
        'dgv.Columns().DataPropertyName = "estadobaja"
        'dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
    End Sub

    Private Sub pbcerrar_Click(sender As Object, e As EventArgs) Handles pbcerrar.Click
        Me.Close()
    End Sub

    Sub Eliminar()
        Try
            If MsgBox("Seguro desea Eliminar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                Dim ide = dgvempleado.CurrentRow().Cells(0).Value
                ADEmpleado.DarBaja(ide)
                ADEmpleado.MostrarEmpleado(dgvempleado)
                MsgBox("Registro Eliminado con éxito", MsgBoxStyle.Information, "Eliminación")
                indice()
            Else
                MsgBox("Operación cancelada", MsgBoxStyle.Critical, "Cancelación")
                Limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub indice()
        Try
            If ADEmpleado.index() = 0 Then
                txtcod.Text = 1
            Else
                txtcod.Text = ADEmpleado.index()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Function DatosVacios() As Boolean

        Dim result As Boolean
        Try

            If txtdireccion.Text.Trim = "" Or txtcuil.Text.Trim = "" Or txtapellido.Text.Trim = "" Or txtempresa.Text.Trim Then
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
            txtcuil.Focus()
        Else

            If (ADEmpleado.Existe(txtcuil.Text) = False) Then

                If MsgBox("Seguro agregar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    ADEmpleado.AgregarEmpleado(New Empleado() With
                                    { ' .descripcion = txtdescripcion.Text,
                    .estadobaja = 1
                                                          })

                    ADEmpleado.MostrarEmpleado(dgvempleado)
                    Limpiar()
                    MsgBox("El registro ha sido agregado exitosamente", MsgBoxStyle.Information, "Gestión")
                    Limpiar()

                Else
                    MsgBox("Operación cancelada", MsgBoxStyle.Critical, "Cancelación")
                    Limpiar()
                End If

            Else
                MsgBox("Ya existe un registro con este nombre", MsgBoxStyle.Exclamation, "Alerta")
                Limpiar()
            End If

        End If

    End Sub


    Sub Editar()
        Try
            If dgvempleado.RowCount > 0 Then
                txtcod.Text = CStr(dgvempleado.CurrentRow.Cells(0).Value)
                ' txtdescripcion.Text = CStr(dgvtipoconcep.CurrentRow.Cells(1).Value)
            Else
                MsgBox("No hay registros para editar", MsgBoxStyle.Information, "Mensaje")
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
                If ADEmpleado.ExisteID(id) = True Then
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
            If dgvempleado.RowCount = 0 Then
                MsgBox("No hay registros para editar", MsgBoxStyle.Critical, "Error")
            Else
                If txtcuil.Text.Trim = "" Or txtcod.Text.Trim = "" Then
                    MsgBox("Debe seleccionar un registro", MsgBoxStyle.Critical, "Error")
                Else
                    If ExisteReg() = True Then
                        If MsgBox("Seguro desea dar de modificar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
                            Dim id As Integer = dgvempleado.CurrentRow.Cells(0).Value
                            'ADEmpleado.ModificarEmpleado(id)
                            MsgBox("el registro se modifico exitosamente", MsgBoxStyle.Information, "Modificación")
                            btnguardar.Enabled = False
                        Else
                            MsgBox("Operación cancelada", MsgBoxStyle.Critical, "Cancelación")
                            Limpiar()
                            'indice()

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
            If dgvempleado.RowCount = 0 Then
                MsgBox("No hay registros para dar de alta", MsgBoxStyle.Critical, "Error")
            Else

                If MsgBox("Seguro desea dar de alta este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    Dim ide = dgvempleado.CurrentRow().Cells(0).Value
                    If ide <> 0 And txtcuil.Text.Trim <> "" Then
                        'aca hay que hacer otra funcion y ver que no exista el registro o controlar se haya clickeado sobre editar 

                        ADEmpleado.DarAlta(ide)
                        ADEmpleado.MostrarEmpleado(dgvempleado)
                        MsgBox("Registro actualizado con éxito", MsgBoxStyle.Information, "Actualización")
                        Limpiar()
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


    Private Sub btndesplazar_Click(sender As Object, e As EventArgs) Handles btndesplazar.Click
        Pestaña1.SelectedTab = Pestaña1.TabPages.Item(1)
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndesplazar2.Click
        Pestaña1.SelectedTab = Pestaña1.TabPages.Item(2)
    End Sub

    Private Sub btnatras2_Click(sender As Object, e As EventArgs) Handles btnatras2.Click
        Pestaña1.SelectedTab = Pestaña1.TabPages.Item(0)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnatras3.Click
        Pestaña1.SelectedTab = Pestaña1.TabPages.Item(1)
    End Sub



    Sub Limpiar()
        txtcod.Clear()
        txtnombre.Clear()
        txtapellido.Clear()
        txtdireccion.Clear()
        txtcuil.Clear()
        txtempresa.Clear()
        txttelefono.Clear()
        txtmail.Clear()
        cboestadocivil.SelectedValue = -1
        cboobra.SelectedValue = -1
        'dtpnacimiento.Select
    End Sub

    Private Sub dgvempleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvempleado.CellContentClick
        Try
            If validar.DatagridVacio(dgvempleado) = False Then


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

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Alta()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Guardar()
    End Sub


    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Agregar()
    End Sub
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        Limpiar()
    End Sub


End Class