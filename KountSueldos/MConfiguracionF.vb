Module MConfiguracionF

    Sub TamañoForm(Form As Form)

        Form.Size = New System.Drawing.Size(950, 611)
    End Sub


    Sub configCombobox(cbo As ComboBox)
        cbo.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub


    Sub configDGV(dgv As DataGridView)
        dgv.AutoResizeColumns()
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AutoResizeRows()
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Coral
    End Sub


    Sub ConfigBotones(guarda As Button, alta As Button)
        guarda.Enabled = False 'hace refencia a guardar
        alta.Enabled = False ' hace referencia a alta
    End Sub
End Module
