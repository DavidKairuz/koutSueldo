Public Class VBanco
    Dim ADBanco As ADBanco = New ADBanco
    Dim validar As Validar = New Validar
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) 
        Agregar()
    End Sub

    Private Sub VBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MConfiguracionF.TamañoForm(Me)
        dgvmanual(dgvbanco)
        MConfiguracionF.configDGV(dgvbanco)
        Mostrardgv()
        indice()
    End Sub

    Sub Mostrardgv()
        ADBanco.MostrarBanco(dgvbanco)
    End Sub
    Sub dgvmanual(dgv As DataGridView)

        dgv.AutoGenerateColumns = False
        dgv.Columns.Clear()
        Dim dir As New DataGridViewTextBoxColumn
        dir.Name = "dirección"
        dir.HeaderText = "Dirección"
        Dim tel As New DataGridViewTextBoxColumn
        tel.Name = "telefono"
        tel.HeaderText = "Telefono"
        Dim suc As New DataGridViewTextBoxColumn
        suc.Name = "sucursal"
        suc.HeaderText = "Sucursal"
        Dim mail As New DataGridViewTextBoxColumn

        mail.Name = "email"
        mail.HeaderText = "Email"

        dgv.Columns.Add("id_banco", "Código")
        dgv.Columns.Add("nombre", "Nombre")
        dgv.Columns.Add(dir)
        dgv.Columns.Add(tel)
        dgv.Columns.Add(suc)
        dgv.Columns.Add(mail)
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
        dgv.Columns(0).DataPropertyName = "id_banco"
        dgv.Columns(1).DataPropertyName = "Nombre"
        dgv.Columns(2).DataPropertyName = "direccion"
        dgv.Columns(3).DataPropertyName = "telefono"
        dgv.Columns(4).DataPropertyName = "sucursalb"
        dgv.Columns(5).DataPropertyName = "Email"
        dgv.Columns(6).DataPropertyName = "Editar"
        dgv.Columns(7).DataPropertyName = "Eliminar"
        dgv.Columns(8).DataPropertyName = "estadobaja"
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine
    End Sub

    Private Sub pbcerrar_Click(sender As Object, e As EventArgs) Handles pbcerrar.Click
        Me.Close()
    End Sub

    Sub Eliminar()
        Try
            If MsgBox("Seguro desea Eliminar este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                Dim ide = dgvbanco.CurrentRow().Cells(0).Value
                ADBanco.DarBaja(ide)
                ADBanco.MostrarBanco(dgvbanco)
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
        txtnombre.Clear()
        txtdireccion.Clear()
        txtemail.Clear()
        txttel.Clear()
        txtsucursal.Clear()
    End Sub
    Sub indice()
        txtcod.Text = ADBanco.index()

    End Sub
    Function DatosVacios() As Boolean

        Dim result As Boolean
        Try

            If txtnombre.Text.Trim = "" Or txtsucursal.Text.Trim = "" Or txtdireccion.Text.Trim = "" Or txtemail.Text.Trim = "" Or txttel.Text.Trim = "" Then
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
        If DatosVacios() = False Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Information, "Aviso")
            txtnombre.Focus()
        Else

            If (ADBanco.Existe(txtnombre.Text) = False) Then

                If MsgBox("Seguro agregar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    ADBanco.AgregarBanco(New Banco() With
                                    {
                                    .nombre = txtnombre.Text,
                                    .direccion = txtdireccion.Text,
                                    .telefono = txttel.Text,
                                    .sucursalb = txtsucursal.Text,
                                    .email = txtemail.Text,
                                    .estadobaja = 1
                                                          })

                    ADBanco.MostrarBanco(dgvbanco)
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
            If dgvbanco.RowCount > 0 Then
                txtcod.Text = CStr(dgvbanco.CurrentRow.Cells(0).Value)
                txtnombre.Text = CStr(dgvbanco.CurrentRow.Cells(1).Value)
                txtdireccion.Text = dgvbanco.CurrentRow.Cells(2).Value
                txttel.Text = dgvbanco.CurrentRow.Cells(3).Value
                txtsucursal.Text = dgvbanco.CurrentRow.Cells(4).Value
                txtemail.Text = dgvbanco.CurrentRow.Cells(5).Value
            Else
                MsgBox("No hay registros para editar", MsgBoxStyle.Exclamation, "Error")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Guardar()
        Try
            If dgvbanco.RowCount = 0 Then
                MsgBox("No hay registros para editar", MsgBoxStyle.Critical, "Error")
            Else
                If txtnombre.Text.Trim = "" Or txtcod.Text.Trim = "" Then
                    MsgBox("Faltan datos en el registro", MsgBoxStyle.Critical, "Error")
                Else

                    Dim id As Integer = dgvbanco.CurrentRow.Cells(0).Value
                    ADBanco.ModificarBanco(id, txtnombre.Text, txtdireccion.Text, txttel.Text, CInt(txtsucursal.Text), txtemail.Text)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Alta()
        Try
            If dgvbanco.RowCount = 0 Then
                MsgBox("No hay registros para dar de alta", MsgBoxStyle.Critical, "Error")
            Else

                If MsgBox("Seguro desea dar de alta este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then

                    Dim ide = dgvbanco.CurrentRow().Cells(0).Value
                    If ide <> 0 Then


                        ADBanco.DarAlta(ide)
                        ADBanco.MostrarBanco(dgvbanco)
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

    Private Sub txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
        ADBanco.Filtra(txtfiltro, dgvbanco)
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Guardar()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Alta()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
        indice()
    End Sub

    Private Sub dgvbanco_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbanco.CellContentClick
        Try
            If validar.DatagridVacio(dgvbanco) = False Then


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
End Class