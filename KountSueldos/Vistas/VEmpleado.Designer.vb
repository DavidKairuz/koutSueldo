<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VEmpleado
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.pbcerrar = New System.Windows.Forms.PictureBox()
        Me.Pestaña1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtpnacimiento = New System.Windows.Forms.DateTimePicker()
        Me.btndesplazar = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcuil = New System.Windows.Forms.TextBox()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.Pestaña2 = New System.Windows.Forms.TabPage()
        Me.btnatras2 = New System.Windows.Forms.Button()
        Me.btndesplazar2 = New System.Windows.Forms.Button()
        Me.Pestaña3 = New System.Windows.Forms.TabPage()
        Me.btnatras3 = New System.Windows.Forms.Button()
        Me.dtpfegreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpfingreso = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtactividad = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcategoria = New System.Windows.Forms.TextBox()
        Me.txtempresa = New System.Windows.Forms.TextBox()
        Me.cboobra = New System.Windows.Forms.ComboBox()
        Me.cboestadocivil = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mkhijos = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtfiltrocuil = New System.Windows.Forms.TextBox()
        Me.rbapellido = New System.Windows.Forms.RadioButton()
        Me.rbcuil = New System.Windows.Forms.RadioButton()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.chktodo = New System.Windows.Forms.CheckBox()
        Me.dgvempleado = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.pbcerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pestaña1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Pestaña2.SuspendLayout()
        Me.Pestaña3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvempleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Dirección"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Código"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(94, 308)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(216, 20)
        Me.txtdireccion.TabIndex = 37
        '
        'txtcod
        '
        Me.txtcod.Enabled = False
        Me.txtcod.Location = New System.Drawing.Point(94, 21)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(159, 20)
        Me.txtcod.TabIndex = 36
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PanelSuperior.Controls.Add(Me.lbltitulo)
        Me.PanelSuperior.Controls.Add(Me.pbcerrar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1029, 45)
        Me.PanelSuperior.TabIndex = 34
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.White
        Me.lbltitulo.Location = New System.Drawing.Point(42, 17)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(78, 19)
        Me.lbltitulo.TabIndex = 33
        Me.lbltitulo.Text = "Empleado"
        '
        'pbcerrar
        '
        Me.pbcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbcerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbcerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.pbcerrar.Image = Global.KountSueldos.My.Resources.Resources.interfaz
        Me.pbcerrar.Location = New System.Drawing.Point(1000, 0)
        Me.pbcerrar.Name = "pbcerrar"
        Me.pbcerrar.Size = New System.Drawing.Size(29, 45)
        Me.pbcerrar.TabIndex = 0
        Me.pbcerrar.TabStop = False
        '
        'Pestaña1
        '
        Me.Pestaña1.Controls.Add(Me.TabPage1)
        Me.Pestaña1.Controls.Add(Me.Pestaña2)
        Me.Pestaña1.Controls.Add(Me.Pestaña3)
        Me.Pestaña1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pestaña1.Location = New System.Drawing.Point(0, 45)
        Me.Pestaña1.Name = "Pestaña1"
        Me.Pestaña1.SelectedIndex = 0
        Me.Pestaña1.Size = New System.Drawing.Size(1029, 516)
        Me.Pestaña1.TabIndex = 50
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cboobra)
        Me.TabPage1.Controls.Add(Me.cboestadocivil)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.mkhijos)
        Me.TabPage1.Controls.Add(Me.dtpfegreso)
        Me.TabPage1.Controls.Add(Me.dtpfingreso)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txtactividad)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtcategoria)
        Me.TabPage1.Controls.Add(Me.txtempresa)
        Me.TabPage1.Controls.Add(Me.dtpnacimiento)
        Me.TabPage1.Controls.Add(Me.btndesplazar)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.txtmail)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txttelefono)
        Me.TabPage1.Controls.Add(Me.txtapellido)
        Me.TabPage1.Controls.Add(Me.txtnombre)
        Me.TabPage1.Controls.Add(Me.txtcuil)
        Me.TabPage1.Controls.Add(Me.btnnuevo)
        Me.TabPage1.Controls.Add(Me.btnguardar)
        Me.TabPage1.Controls.Add(Me.btnlimpiar)
        Me.TabPage1.Controls.Add(Me.btnAlta)
        Me.TabPage1.Controls.Add(Me.txtcod)
        Me.TabPage1.Controls.Add(Me.txtdireccion)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1021, 490)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pestaña 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dtpnacimiento
        '
        Me.dtpnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpnacimiento.Location = New System.Drawing.Point(94, 266)
        Me.dtpnacimiento.Name = "dtpnacimiento"
        Me.dtpnacimiento.Size = New System.Drawing.Size(148, 20)
        Me.dtpnacimiento.TabIndex = 70
        '
        'btndesplazar
        '
        Me.btndesplazar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndesplazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndesplazar.Image = Global.KountSueldos.My.Resources.Resources.derecha
        Me.btndesplazar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndesplazar.Location = New System.Drawing.Point(912, 435)
        Me.btndesplazar.Name = "btndesplazar"
        Me.btndesplazar.Size = New System.Drawing.Size(95, 37)
        Me.btndesplazar.TabIndex = 66
        Me.btndesplazar.Text = "Siguiente"
        Me.btndesplazar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndesplazar.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(28, 260)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 26)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(28, 221)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "E-mail"
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(94, 226)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(148, 20)
        Me.txtmail.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Telefono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Apellido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "CUIL"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(94, 185)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(165, 20)
        Me.txttelefono.TabIndex = 53
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(94, 144)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(165, 20)
        Me.txtapellido.TabIndex = 52
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(94, 103)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(165, 20)
        Me.txtnombre.TabIndex = 51
        '
        'txtcuil
        '
        Me.txtcuil.Location = New System.Drawing.Point(94, 62)
        Me.txtcuil.Name = "txtcuil"
        Me.txtcuil.Size = New System.Drawing.Size(165, 20)
        Me.txtcuil.TabIndex = 50
        '
        'btnnuevo
        '
        Me.btnnuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Image = Global.KountSueldos.My.Resources.Resources.neww1
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnuevo.Location = New System.Drawing.Point(301, 391)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(95, 37)
        Me.btnnuevo.TabIndex = 47
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Image = Global.KountSueldos.My.Resources.Resources.web
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardar.Location = New System.Drawing.Point(409, 391)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(95, 37)
        Me.btnguardar.TabIndex = 42
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpiar.Image = Global.KountSueldos.My.Resources.Resources.clean
        Me.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlimpiar.Location = New System.Drawing.Point(517, 391)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(95, 37)
        Me.btnlimpiar.TabIndex = 48
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAlta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlta.Image = Global.KountSueldos.My.Resources.Resources.edit
        Me.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlta.Location = New System.Drawing.Point(625, 391)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(95, 37)
        Me.btnAlta.TabIndex = 43
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'Pestaña2
        '
        Me.Pestaña2.Controls.Add(Me.Button4)
        Me.Pestaña2.Controls.Add(Me.Button5)
        Me.Pestaña2.Controls.Add(Me.Button3)
        Me.Pestaña2.Controls.Add(Me.GroupBox1)
        Me.Pestaña2.Controls.Add(Me.dgvempleado)
        Me.Pestaña2.Controls.Add(Me.btnatras2)
        Me.Pestaña2.Controls.Add(Me.btndesplazar2)
        Me.Pestaña2.Location = New System.Drawing.Point(4, 22)
        Me.Pestaña2.Name = "Pestaña2"
        Me.Pestaña2.Padding = New System.Windows.Forms.Padding(3)
        Me.Pestaña2.Size = New System.Drawing.Size(1021, 490)
        Me.Pestaña2.TabIndex = 1
        Me.Pestaña2.Text = "Pestaña 2"
        Me.Pestaña2.UseVisualStyleBackColor = True
        '
        'btnatras2
        '
        Me.btnatras2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnatras2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnatras2.Image = Global.KountSueldos.My.Resources.Resources.Izquierda
        Me.btnatras2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnatras2.Location = New System.Drawing.Point(15, 433)
        Me.btnatras2.Name = "btnatras2"
        Me.btnatras2.Size = New System.Drawing.Size(95, 37)
        Me.btnatras2.TabIndex = 68
        Me.btnatras2.Text = "Atras"
        Me.btnatras2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnatras2.UseVisualStyleBackColor = True
        '
        'btndesplazar2
        '
        Me.btndesplazar2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndesplazar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndesplazar2.Image = Global.KountSueldos.My.Resources.Resources.derecha
        Me.btndesplazar2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndesplazar2.Location = New System.Drawing.Point(891, 433)
        Me.btndesplazar2.Name = "btndesplazar2"
        Me.btndesplazar2.Size = New System.Drawing.Size(95, 37)
        Me.btndesplazar2.TabIndex = 67
        Me.btndesplazar2.Text = "Siguiente"
        Me.btndesplazar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndesplazar2.UseVisualStyleBackColor = True
        '
        'Pestaña3
        '
        Me.Pestaña3.Controls.Add(Me.btnatras3)
        Me.Pestaña3.Location = New System.Drawing.Point(4, 22)
        Me.Pestaña3.Name = "Pestaña3"
        Me.Pestaña3.Padding = New System.Windows.Forms.Padding(3)
        Me.Pestaña3.Size = New System.Drawing.Size(1021, 490)
        Me.Pestaña3.TabIndex = 2
        Me.Pestaña3.Text = "Pestaña3"
        Me.Pestaña3.UseVisualStyleBackColor = True
        '
        'btnatras3
        '
        Me.btnatras3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnatras3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnatras3.Image = Global.KountSueldos.My.Resources.Resources.Izquierda
        Me.btnatras3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnatras3.Location = New System.Drawing.Point(21, 431)
        Me.btnatras3.Name = "btnatras3"
        Me.btnatras3.Size = New System.Drawing.Size(95, 37)
        Me.btnatras3.TabIndex = 69
        Me.btnatras3.Text = "Atras"
        Me.btnatras3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnatras3.UseVisualStyleBackColor = True
        '
        'dtpfegreso
        '
        Me.dtpfegreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfegreso.Location = New System.Drawing.Point(510, 83)
        Me.dtpfegreso.Name = "dtpfegreso"
        Me.dtpfegreso.Size = New System.Drawing.Size(128, 20)
        Me.dtpfegreso.TabIndex = 80
        '
        'dtpfingreso
        '
        Me.dtpfingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfingreso.Location = New System.Drawing.Point(510, 41)
        Me.dtpfingreso.Name = "dtpfingreso"
        Me.dtpfingreso.Size = New System.Drawing.Size(128, 20)
        Me.dtpfingreso.TabIndex = 79
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(431, 235)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Actividad"
        '
        'txtactividad
        '
        Me.txtactividad.Location = New System.Drawing.Point(510, 232)
        Me.txtactividad.Name = "txtactividad"
        Me.txtactividad.Size = New System.Drawing.Size(128, 20)
        Me.txtactividad.TabIndex = 77
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(431, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "Categoria"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(431, 134)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Empresa"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(431, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Fecha Ingreso"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(431, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Fecha Egreso"
        '
        'txtcategoria
        '
        Me.txtcategoria.Location = New System.Drawing.Point(510, 179)
        Me.txtcategoria.Name = "txtcategoria"
        Me.txtcategoria.Size = New System.Drawing.Size(128, 20)
        Me.txtcategoria.TabIndex = 72
        '
        'txtempresa
        '
        Me.txtempresa.Location = New System.Drawing.Point(510, 131)
        Me.txtempresa.Name = "txtempresa"
        Me.txtempresa.Size = New System.Drawing.Size(128, 20)
        Me.txtempresa.TabIndex = 71
        '
        'cboobra
        '
        Me.cboobra.FormattingEnabled = True
        Me.cboobra.Location = New System.Drawing.Point(883, 55)
        Me.cboobra.Name = "cboobra"
        Me.cboobra.Size = New System.Drawing.Size(100, 21)
        Me.cboobra.TabIndex = 86
        '
        'cboestadocivil
        '
        Me.cboestadocivil.FormattingEnabled = True
        Me.cboestadocivil.Location = New System.Drawing.Point(883, 100)
        Me.cboestadocivil.Name = "cboestadocivil"
        Me.cboestadocivil.Size = New System.Drawing.Size(100, 21)
        Me.cboestadocivil.TabIndex = 85
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(798, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Obra Social"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(803, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Estado civil"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(813, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Hijos"
        '
        'mkhijos
        '
        Me.mkhijos.Location = New System.Drawing.Point(883, 138)
        Me.mkhijos.Name = "mkhijos"
        Me.mkhijos.Size = New System.Drawing.Size(100, 20)
        Me.mkhijos.TabIndex = 81
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtfiltrocuil)
        Me.GroupBox1.Controls.Add(Me.rbapellido)
        Me.GroupBox1.Controls.Add(Me.rbcuil)
        Me.GroupBox1.Controls.Add(Me.txtfiltro)
        Me.GroupBox1.Controls.Add(Me.chktodo)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1007, 65)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Por : "
        '
        'txtfiltrocuil
        '
        Me.txtfiltrocuil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfiltrocuil.Enabled = False
        Me.txtfiltrocuil.Location = New System.Drawing.Point(158, 36)
        Me.txtfiltrocuil.Name = "txtfiltrocuil"
        Me.txtfiltrocuil.Size = New System.Drawing.Size(148, 20)
        Me.txtfiltrocuil.TabIndex = 64
        '
        'rbapellido
        '
        Me.rbapellido.AutoSize = True
        Me.rbapellido.Checked = True
        Me.rbapellido.Location = New System.Drawing.Point(403, 13)
        Me.rbapellido.Name = "rbapellido"
        Me.rbapellido.Size = New System.Drawing.Size(62, 17)
        Me.rbapellido.TabIndex = 63
        Me.rbapellido.TabStop = True
        Me.rbapellido.Text = "Apellido"
        Me.rbapellido.UseVisualStyleBackColor = True
        '
        'rbcuil
        '
        Me.rbcuil.AutoSize = True
        Me.rbcuil.Location = New System.Drawing.Point(158, 13)
        Me.rbcuil.Name = "rbcuil"
        Me.rbcuil.Size = New System.Drawing.Size(49, 17)
        Me.rbcuil.TabIndex = 62
        Me.rbcuil.Text = "CUIL"
        Me.rbcuil.UseVisualStyleBackColor = True
        '
        'txtfiltro
        '
        Me.txtfiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfiltro.Enabled = False
        Me.txtfiltro.Location = New System.Drawing.Point(403, 36)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(148, 20)
        Me.txtfiltro.TabIndex = 40
        '
        'chktodo
        '
        Me.chktodo.AutoSize = True
        Me.chktodo.Location = New System.Drawing.Point(24, 29)
        Me.chktodo.Name = "chktodo"
        Me.chktodo.Size = New System.Drawing.Size(91, 17)
        Me.chktodo.TabIndex = 49
        Me.chktodo.Text = "Mostrar todo :"
        Me.chktodo.UseVisualStyleBackColor = True
        '
        'dgvempleado
        '
        Me.dgvempleado.AllowUserToAddRows = False
        Me.dgvempleado.AllowUserToDeleteRows = False
        Me.dgvempleado.AllowUserToResizeColumns = False
        Me.dgvempleado.AllowUserToResizeRows = False
        Me.dgvempleado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvempleado.Location = New System.Drawing.Point(6, 108)
        Me.dgvempleado.Name = "dgvempleado"
        Me.dgvempleado.Size = New System.Drawing.Size(1009, 309)
        Me.dgvempleado.TabIndex = 72
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.KountSueldos.My.Resources.Resources.tecnologia
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(321, 433)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 37)
        Me.Button4.TabIndex = 75
        Me.Button4.Text = "Imprimir"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.KountSueldos.My.Resources.Resources.pdf1
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(435, 433)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 37)
        Me.Button5.TabIndex = 76
        Me.Button5.Text = "PDF"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.KountSueldos.My.Resources.Resources.logo
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(548, 433)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 37)
        Me.Button3.TabIndex = 74
        Me.Button3.Text = "Excel"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'VEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 561)
        Me.Controls.Add(Me.Pestaña1)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VEmpleado"
        Me.Text = "VEmpleado"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        CType(Me.pbcerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pestaña1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Pestaña2.ResumeLayout(False)
        Me.Pestaña3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvempleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents lbltitulo As Label
    Friend WithEvents pbcerrar As PictureBox
    Friend WithEvents Pestaña1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Pestaña2 As TabPage
    Friend WithEvents txtcuil As TextBox
    Friend WithEvents Pestaña3 As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtmail As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btndesplazar As Button
    Friend WithEvents btndesplazar2 As Button
    Friend WithEvents btnatras2 As Button
    Friend WithEvents btnatras3 As Button
    Friend WithEvents dtpnacimiento As DateTimePicker
    Friend WithEvents cboobra As ComboBox
    Friend WithEvents cboestadocivil As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents mkhijos As MaskedTextBox
    Friend WithEvents dtpfegreso As DateTimePicker
    Friend WithEvents dtpfingreso As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents txtactividad As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcategoria As TextBox
    Friend WithEvents txtempresa As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtfiltrocuil As TextBox
    Friend WithEvents rbapellido As RadioButton
    Friend WithEvents rbcuil As RadioButton
    Friend WithEvents txtfiltro As TextBox
    Friend WithEvents chktodo As CheckBox
    Friend WithEvents dgvempleado As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
End Class
