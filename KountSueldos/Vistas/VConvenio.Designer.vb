﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VConvenio
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
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.pbcerrar = New System.Windows.Forms.PictureBox()
        Me.dgvconvenio = New System.Windows.Forms.DataGridView()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.chktodo = New System.Windows.Forms.CheckBox()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.pbcerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvconvenio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelSuperior.TabIndex = 0
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
        Me.lbltitulo.Text = " Convenio"
        '
        'pbcerrar
        '
        Me.pbcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbcerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbcerrar.Image = Global.KountSueldos.My.Resources.Resources.icon
        Me.pbcerrar.Location = New System.Drawing.Point(895, 9)
        Me.pbcerrar.Name = "pbcerrar"
        Me.pbcerrar.Size = New System.Drawing.Size(29, 27)
        Me.pbcerrar.TabIndex = 0
        Me.pbcerrar.TabStop = False
        '
        'dgvconvenio
        '
        Me.dgvconvenio.AllowUserToAddRows = False
        Me.dgvconvenio.AllowUserToDeleteRows = False
        Me.dgvconvenio.AllowUserToResizeColumns = False
        Me.dgvconvenio.AllowUserToResizeRows = False
        Me.dgvconvenio.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvconvenio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvconvenio.Location = New System.Drawing.Point(370, 126)
        Me.dgvconvenio.Name = "dgvconvenio"
        Me.dgvconvenio.Size = New System.Drawing.Size(453, 427)
        Me.dgvconvenio.TabIndex = 1
        '
        'txtcod
        '
        Me.txtcod.Enabled = False
        Me.txtcod.Location = New System.Drawing.Point(121, 143)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(159, 20)
        Me.txtcod.TabIndex = 2
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(121, 186)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(159, 32)
        Me.txtdescripcion.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Descripción"
        '
        'txtfiltro
        '
        Me.txtfiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfiltro.Location = New System.Drawing.Point(603, 84)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(220, 20)
        Me.txtfiltro.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(544, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Buscar"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpiar.Image = Global.KountSueldos.My.Resources.Resources.clean
        Me.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlimpiar.Location = New System.Drawing.Point(33, 388)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(95, 37)
        Me.btnlimpiar.TabIndex = 18
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
        Me.btnnuevo.Location = New System.Drawing.Point(33, 327)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(95, 37)
        Me.btnnuevo.TabIndex = 17
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
        Me.btnAlta.Location = New System.Drawing.Point(158, 388)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(95, 37)
        Me.btnAlta.TabIndex = 13
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
        Me.btnguardar.Location = New System.Drawing.Point(158, 327)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(95, 37)
        Me.btnguardar.TabIndex = 12
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'chktodo
        '
        Me.chktodo.AutoSize = True
        Me.chktodo.Location = New System.Drawing.Point(384, 87)
        Me.chktodo.Name = "chktodo"
        Me.chktodo.Size = New System.Drawing.Size(91, 17)
        Me.chktodo.TabIndex = 35
        Me.chktodo.Text = "Mostrar todo :"
        Me.chktodo.UseVisualStyleBackColor = True
        '
        'VConvenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 611)
        Me.Controls.Add(Me.chktodo)
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
        Me.Controls.Add(Me.dgvconvenio)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VConvenio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convenio"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        CType(Me.pbcerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvconvenio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents dgvconvenio As DataGridView
    Friend WithEvents txtcod As TextBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtfiltro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents pbcerrar As PictureBox
    Friend WithEvents lbltitulo As Label
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents chktodo As CheckBox
End Class
