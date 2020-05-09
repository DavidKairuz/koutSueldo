<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VSucursal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.dgvsucursal = New System.Windows.Forms.DataGridView()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.pbcerrar = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cborazonsoc = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.chktodo = New System.Windows.Forms.CheckBox()
        CType(Me.dgvsucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.pbcerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpiar.Image = Global.KountSueldos.My.Resources.Resources.clean
        Me.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlimpiar.Location = New System.Drawing.Point(137, 439)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(101, 37)
        Me.btnlimpiar.TabIndex = 48
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
        Me.btnnuevo.Location = New System.Drawing.Point(29, 382)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(101, 37)
        Me.btnnuevo.TabIndex = 47
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.KountSueldos.My.Resources.Resources.pdf1
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(837, 175)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 37)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "PDF"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.KountSueldos.My.Resources.Resources.tecnologia
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(837, 113)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 37)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "Imprimir"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.KountSueldos.My.Resources.Resources.logo
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(837, 234)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 37)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = "Excel"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAlta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlta.Image = Global.KountSueldos.My.Resources.Resources.edit
        Me.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlta.Location = New System.Drawing.Point(244, 382)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(101, 37)
        Me.btnAlta.TabIndex = 43
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
        Me.btnguardar.Location = New System.Drawing.Point(137, 382)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(101, 37)
        Me.btnguardar.TabIndex = 42
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(544, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Buscar"
        '
        'txtfiltro
        '
        Me.txtfiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfiltro.Location = New System.Drawing.Point(603, 75)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(220, 20)
        Me.txtfiltro.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Código"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(117, 161)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(193, 20)
        Me.txtnombre.TabIndex = 37
        '
        'txtcod
        '
        Me.txtcod.Enabled = False
        Me.txtcod.Location = New System.Drawing.Point(117, 79)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(159, 20)
        Me.txtcod.TabIndex = 36
        '
        'dgvsucursal
        '
        Me.dgvsucursal.AllowUserToAddRows = False
        Me.dgvsucursal.AllowUserToDeleteRows = False
        Me.dgvsucursal.AllowUserToResizeColumns = False
        Me.dgvsucursal.AllowUserToResizeRows = False
        Me.dgvsucursal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvsucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsucursal.Location = New System.Drawing.Point(370, 113)
        Me.dgvsucursal.Name = "dgvsucursal"
        Me.dgvsucursal.Size = New System.Drawing.Size(453, 427)
        Me.dgvsucursal.TabIndex = 35
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PanelSuperior.Controls.Add(Me.lbltitulo)
        Me.PanelSuperior.Controls.Add(Me.pbcerrar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1019, 45)
        Me.PanelSuperior.TabIndex = 34
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.White
        Me.lbltitulo.Location = New System.Drawing.Point(42, 17)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(131, 19)
        Me.lbltitulo.TabIndex = 33
        Me.lbltitulo.Text = "Empresa Sucursal"
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Empresa"
        '
        'cborazonsoc
        '
        Me.cborazonsoc.FormattingEnabled = True
        Me.cborazonsoc.Location = New System.Drawing.Point(117, 122)
        Me.cborazonsoc.Name = "cborazonsoc"
        Me.cborazonsoc.Size = New System.Drawing.Size(156, 21)
        Me.cborazonsoc.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Telefono"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(117, 249)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(159, 20)
        Me.txttelefono.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Dirección"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(117, 207)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(243, 20)
        Me.txtdireccion.TabIndex = 63
        '
        'chktodo
        '
        Me.chktodo.AutoSize = True
        Me.chktodo.Location = New System.Drawing.Point(389, 82)
        Me.chktodo.Name = "chktodo"
        Me.chktodo.Size = New System.Drawing.Size(91, 17)
        Me.chktodo.TabIndex = 69
        Me.chktodo.Text = "Mostrar todo :"
        Me.chktodo.UseVisualStyleBackColor = True
        '
        'VSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 558)
        Me.Controls.Add(Me.chktodo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cborazonsoc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtfiltro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.dgvsucursal)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VSucursal"
        Me.Text = "VSucursal"
        CType(Me.dgvsucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        CType(Me.pbcerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfiltro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents dgvsucursal As DataGridView
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents lbltitulo As Label
    Friend WithEvents pbcerrar As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cborazonsoc As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents chktodo As CheckBox
End Class
