Module MConfiguracionF

    Sub TamañoForm(Form As Form)

        Form.Size = New System.Drawing.Size(950, 611)
    End Sub





    Sub configDGV(dgv As DataGridView)
        dgv.AutoResizeColumns()
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AutoResizeRows()
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub
End Module
