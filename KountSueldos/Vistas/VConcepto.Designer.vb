<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VConcepto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.dgvconcepto = New System.Windows.Forms.DataGridView()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.lblvalor = New System.Windows.Forms.Label()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.cbotipoconcep = New System.Windows.Forms.ComboBox()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.cboestado = New System.Windows.Forms.ComboBox()
        Me.chktodo = New System.Windows.Forms.CheckBox()
        Me.lblley = New System.Windows.Forms.Label()
        Me.txtley = New System.Windows.Forms.TextBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.pbcerrar = New System.Windows.Forms.PictureBox()
        CType(Me.dgvconcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.pbcerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(544, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Buscar"
        '
        'txtfiltro
        '
        Me.txtfiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfiltro.Location = New System.Drawing.Point(603, 77)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(220, 20)
        Me.txtfiltro.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Código"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(101, 127)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(159, 32)
        Me.txtdescripcion.TabIndex = 22
        '
        'txtcod
        '
        Me.txtcod.Enabled = False
        Me.txtcod.Location = New System.Drawing.Point(101, 89)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(159, 20)
        Me.txtcod.TabIndex = 21
        '
        'dgvconcepto
        '
        Me.dgvconcepto.AllowUserToAddRows = False
        Me.dgvconcepto.AllowUserToDeleteRows = False
        Me.dgvconcepto.AllowUserToResizeColumns = False
        Me.dgvconcepto.AllowUserToResizeRows = False
        Me.dgvconcepto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvconcepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvconcepto.Location = New System.Drawing.Point(287, 117)
        Me.dgvconcepto.Name = "dgvconcepto"
        Me.dgvconcepto.Size = New System.Drawing.Size(651, 427)
        Me.dgvconcepto.TabIndex = 20
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PanelSuperior.Controls.Add(Me.lbltitulo)
        Me.PanelSuperior.Controls.Add(Me.pbcerrar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(950, 45)
        Me.PanelSuperior.TabIndex = 19
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.White
        Me.lbltitulo.Location = New System.Drawing.Point(42, 17)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(79, 19)
        Me.lbltitulo.TabIndex = 33
        Me.lbltitulo.Text = " Concepto"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(28, 212)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(53, 26)
        Me.lbltipo.TabIndex = 34
        Me.lbltipo.Text = "Tipo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Concepto"
        '
        'lblvalor
        '
        Me.lblvalor.AutoSize = True
        Me.lblvalor.Location = New System.Drawing.Point(28, 256)
        Me.lblvalor.Name = "lblvalor"
        Me.lblvalor.Size = New System.Drawing.Size(31, 13)
        Me.lblvalor.TabIndex = 35
        Me.lblvalor.Text = "Valor"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(28, 287)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(43, 26)
        Me.lblestado.TabIndex = 36
        Me.lblestado.Text = "Estado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R o NR"
        '
        'cbotipoconcep
        '
        Me.cbotipoconcep.FormattingEnabled = True
        Me.cbotipoconcep.Location = New System.Drawing.Point(101, 215)
        Me.cbotipoconcep.Name = "cbotipoconcep"
        Me.cbotipoconcep.Size = New System.Drawing.Size(159, 21)
        Me.cbotipoconcep.TabIndex = 37
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(102, 254)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(158, 20)
        Me.txtvalor.TabIndex = 38
        '
        'cboestado
        '
        Me.cboestado.FormattingEnabled = True
        Me.cboestado.Location = New System.Drawing.Point(101, 292)
        Me.cboestado.Name = "cboestado"
        Me.cboestado.Size = New System.Drawing.Size(159, 21)
        Me.cboestado.TabIndex = 39
        '
        'chktodo
        '
        Me.chktodo.AutoSize = True
        Me.chktodo.Location = New System.Drawing.Point(381, 80)
        Me.chktodo.Name = "chktodo"
        Me.chktodo.Size = New System.Drawing.Size(91, 17)
        Me.chktodo.TabIndex = 40
        Me.chktodo.Text = "Mostrar todo :"
        Me.chktodo.UseVisualStyleBackColor = True
        '
        'lblley
        '
        Me.lblley.AutoSize = True
        Me.lblley.Location = New System.Drawing.Point(28, 178)
        Me.lblley.Name = "lblley"
        Me.lblley.Size = New System.Drawing.Size(24, 13)
        Me.lblley.TabIndex = 42
        Me.lblley.Text = "Ley"
        '
        'txtley
        '
        Me.txtley.Location = New System.Drawing.Point(101, 177)
        Me.txtley.Name = "txtley"
        Me.txtley.Size = New System.Drawing.Size(159, 20)
        Me.txtley.TabIndex = 41
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpiar.Image = Global.KountSueldos.My.Resources.Resources.clean
        Me.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlimpiar.Location = New System.Drawing.Point(46, 419)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(95, 37)
        Me.btnlimpiar.TabIndex = 33
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Image = Global.KountSueldos.My.Resources.Resources.web
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnuevo.Location = New System.Drawing.Point(46, 353)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(95, 37)
        Me.btnnuevo.TabIndex = 32
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAlta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlta.Image = Global.KountSueldos.My.Resources.Resources.edit
        Me.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlta.Location = New System.Drawing.Point(165, 419)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(95, 37)
        Me.btnAlta.TabIndex = 28
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Image = Global.KountSueldos.My.Resources.Resources.web
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardar.Location = New System.Drawing.Point(165, 353)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(95, 37)
        Me.btnguardar.TabIndex = 27
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'pbcerrar
        '
        Me.pbcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbcerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbcerrar.Image = Global.KountSueldos.My.Resources.Resources.interfaz
        Me.pbcerrar.Location = New System.Drawing.Point(895, 9)
        Me.pbcerrar.Name = "pbcerrar"
        Me.pbcerrar.Size = New System.Drawing.Size(29, 27)
        Me.pbcerrar.TabIndex = 0
        Me.pbcerrar.TabStop = False
        '
        'VConcepto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 611)
        Me.Controls.Add(Me.lblley)
        Me.Controls.Add(Me.txtley)
        Me.Controls.Add(Me.chktodo)
        Me.Controls.Add(Me.cboestado)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.cbotipoconcep)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.lblvalor)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtfiltro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.dgvconcepto)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VConcepto"
        Me.Text = "VConcepto"
        CType(Me.dgvconcepto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        CType(Me.pbcerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfiltro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents dgvconcepto As DataGridView
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents lbltitulo As Label
    Friend WithEvents pbcerrar As PictureBox
    Friend WithEvents lbltipo As Label
    Friend WithEvents lblvalor As Label
    Friend WithEvents lblestado As Label
    Friend WithEvents cbotipoconcep As ComboBox
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents cboestado As ComboBox
    Friend WithEvents chktodo As CheckBox
    Friend WithEvents lblley As Label
    Friend WithEvents txtley As TextBox
End Class
