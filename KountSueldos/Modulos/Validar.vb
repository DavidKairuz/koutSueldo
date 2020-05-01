Imports System.Text.RegularExpressions
Public Class Validar


    Public Sub validarnumeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
            'ElseIf e.KeyChar = "," And Not txtcosto.Text.IndexOf(",") Then
            '    e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo valores numericos", vbExclamation, "Aviso")
        End If
    End Sub



    '----------------------------------------------------------------
    Public Sub validartexto(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo caracteres alfabeticos", vbExclamation, "Aviso")
        End If
    End Sub
    '-------------------------------------------------------------------------
    Public Sub NumerosyDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            'ElseIf e.KeyChar = "," And Not sender.Text.IndexOf(",") Then
            '    e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function IsMail(ByVal p_email As String) As Boolean
        Dim l_reg As New System.Text.RegularExpressions.Regex("^(([^<;>;()[\]\\.,;:\s@\""]+" &
            "(\.[^<;>;()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@" &
            "((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}" &
            "\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+" &
            "[a-zA-Z]{2,}))$")
        Return (l_reg.IsMatch(p_email))

    End Function


    Function validarprecio(ByVal pesos As Decimal) As Boolean
        Dim resp As Boolean
        Try
            Dim patron As Regex = New Regex("^(\d|-)?(\d|,)*\.?\d*$")
            If patron.IsMatch(pesos) = True Then
                resp = True
            Else resp = False
            End If

        Catch ex As Exception
            MsgBox("no anda")
        End Try
        Return resp
    End Function

    Function controlaprecio(ByVal costo As Decimal, ByVal precio As Decimal) As Boolean
        Dim resp As Boolean
        Try
            If costo <> 0 And precio <> 0 Then
                If precio > costo Then
                    resp = True
                ElseIf costo >= precio Then
                    resp = False
                End If
            Else
                MsgBox("Debe ingresar valores validos", MsgBoxStyle.Information, "Mensaje")
                resp = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return resp
    End Function
    Public Sub condicion(sender As TextBox, e As KeyPressEventArgs)

        Dim cadena As String = sender.Text
        Dim filtro As String = "1234567890"

        'If Len(cadena) = 0 Then
        '    filtro += "-"
        'End If
        If Len(cadena) > 0 Then
            filtro += ","
        End If


        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "," And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        End If

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If e.KeyChar = "," And Not cadena.IndexOf(",") Then
            e.Handled = True
        End If

    End Sub



    Public Function DatagridVacio(dg As DataGridView) As Boolean
        Dim resp As Boolean
        If dg.Rows.Count = 0 Then
            resp = True
        Else
            resp = False
        End If
        Return resp
    End Function


    Function vacio(text As TextBox) As Boolean
        Dim result As Boolean = False
        If (text.Text.Trim = "") Then
            result = True

        Else
            result = False
        End If
        Return result
    End Function

    'agrega una columna del tipo checkbox en cualquier datagrid tener readonly en false
    Shared Sub AddEBdgv(dgv As DataGridView)
        Dim cc As DataGridViewCheckBoxColumn
        Dim k As Integer = dgv.ColumnCount
        For j = 0 To dgv.ColumnCount
            If j = dgv.ColumnCount Then
                cc = New DataGridViewCheckBoxColumn
                cc.Name = "Estadobaja"
                cc.HeaderText = "Estado baja"
                dgv.Columns.Insert(k, cc)

            End If
        Next
    End Sub

    'Shared Sub VerificarCheckDGV(dgv As DataGridView)
    '    Dim j As Integer
    '    j = dgv.ColumnCount
    '    For i = 0 To dgv.RowCount - 1
    '        If CBool(dgv.Rows(i).Cells(j).Value) = True Then

    '        End If
    '    Next
    'End Sub
    ' Shared Sub agregarchboxadgv()
    'Dim eb As New DataGridViewCheckBoxColumn
    'eb.HeaderText = "Activo"
    'eb.Name = "estado"
    'dgvunidades.Columns.Insert(dgvunidades.Columns.Count, eb)
    '   End Sub



    Shared Sub configuraDGV(dgv As DataGridView)
        dgv.AutoResizeColumns()
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AutoResizeRows()
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub


    'Shared Sub RemplazoColumnadgv(dgv As DataGridView)
    '    Dim cc As DataGridViewCheckBoxColumn
    '    ' Dim cv As DataGridViewTextBoxColumn

    '    For Each column As DataGridViewColumn In dgv.Columns
    '        If column.HeaderText = "estadobaja" Then
    '            '   IndiceFor = column.Index
    '            cc = New DataGridViewCheckBoxColumn
    '            cc.Name = "Estadobaja"
    '            cc.HeaderText = "Estado baja"
    '            dgv.Columns.Add(cc)
    '        Else
    '            MsgBox("No se encontro la columna")
    '        End If
    '        Exit For
    '    Next
    'End Sub
    Function indiceCE(dgv As DataGridView) As Integer
        Dim index As Integer
        If dgv.RowCount > 0 Then
            index = dgv.ColumnCount
        Else
            index = 0
        End If

        Return index
    End Function

    'Shared Sub cargarDGtodos(dgv As DataGridView)
    '    Try
    '        Dim y As Integer = dgv.ColumnCount

    '        Dim row As DataGridViewRow
    '        For Each row In dgv.Rows
    '            If row.Cells(y).Value = True Then
    '                row.DefaultCellStyle.BackColor = Color.Red
    '            Else
    '                row.DefaultCellStyle.BackColor = Color.Green
    '            End If
    '        Next
    '        dgv.Columns(y).Visible = False
    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub dgvunidades_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvunidades.CellValueChanged
    '    Dim IsDirty As Boolean
    '    If e.RowIndex = -1 Then Exit Sub
    '    'mark as dirty
    '    IsDirty = True
    '    MsgBox(IsDirty)
    '    '  End If
    'End Sub
End Class
