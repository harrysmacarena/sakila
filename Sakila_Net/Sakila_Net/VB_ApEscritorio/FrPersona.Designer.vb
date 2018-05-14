<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbComuna = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chDepCarr = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.opCivViu = New System.Windows.Forms.RadioButton()
        Me.opEstCas = New System.Windows.Forms.RadioButton()
        Me.opCivSol = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.opGenFem = New System.Windows.Forms.RadioButton()
        Me.opGenMas = New System.Windows.Forms.RadioButton()
        Me.chDepPlay = New System.Windows.Forms.CheckBox()
        Me.chDepTennis = New System.Windows.Forms.CheckBox()
        Me.btLeer = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btListar = New System.Windows.Forms.Button()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txApPat = New System.Windows.Forms.TextBox()
        Me.txApMat = New System.Windows.Forms.TextBox()
        Me.txtFNac = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbRut = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cbComuna)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.chDepCarr)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.chDepPlay)
        Me.Panel1.Controls.Add(Me.chDepTennis)
        Me.Panel1.Controls.Add(Me.btLeer)
        Me.Panel1.Controls.Add(Me.btSalir)
        Me.Panel1.Controls.Add(Me.btEliminar)
        Me.Panel1.Controls.Add(Me.btActualizar)
        Me.Panel1.Controls.Add(Me.btListar)
        Me.Panel1.Controls.Add(Me.btAgregar)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.txtNombres)
        Me.Panel1.Controls.Add(Me.txApPat)
        Me.Panel1.Controls.Add(Me.txApMat)
        Me.Panel1.Controls.Add(Me.txtFNac)
        Me.Panel1.Controls.Add(Me.txtDir)
        Me.Panel1.Controls.Add(Me.txtRut)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbRut)
        Me.Panel1.Location = New System.Drawing.Point(22, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 450)
        Me.Panel1.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(45, 325)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Comuna"
        '
        'cbComuna
        '
        Me.cbComuna.FormattingEnabled = True
        Me.cbComuna.Location = New System.Drawing.Point(172, 325)
        Me.cbComuna.Name = "cbComuna"
        Me.cbComuna.Size = New System.Drawing.Size(121, 21)
        Me.cbComuna.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(45, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Deporte"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(45, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Estado Civil"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(45, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Genero"
        '
        'chDepCarr
        '
        Me.chDepCarr.AutoSize = True
        Me.chDepCarr.Location = New System.Drawing.Point(384, 292)
        Me.chDepCarr.Name = "chDepCarr"
        Me.chDepCarr.Size = New System.Drawing.Size(60, 17)
        Me.chDepCarr.TabIndex = 48
        Me.chDepCarr.Text = "Carrera"
        Me.chDepCarr.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.opCivViu)
        Me.Panel3.Controls.Add(Me.opEstCas)
        Me.Panel3.Controls.Add(Me.opCivSol)
        Me.Panel3.Location = New System.Drawing.Point(172, 235)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(313, 39)
        Me.Panel3.TabIndex = 47
        '
        'opCivViu
        '
        Me.opCivViu.AutoSize = True
        Me.opCivViu.Location = New System.Drawing.Point(189, 8)
        Me.opCivViu.Name = "opCivViu"
        Me.opCivViu.Size = New System.Drawing.Size(104, 17)
        Me.opCivViu.TabIndex = 48
        Me.opCivViu.TabStop = True
        Me.opCivViu.Text = "Viudo de Verano"
        Me.opCivViu.UseVisualStyleBackColor = True
        '
        'opEstCas
        '
        Me.opEstCas.AutoSize = True
        Me.opEstCas.Location = New System.Drawing.Point(100, 8)
        Me.opEstCas.Name = "opEstCas"
        Me.opEstCas.Size = New System.Drawing.Size(61, 17)
        Me.opEstCas.TabIndex = 47
        Me.opEstCas.TabStop = True
        Me.opEstCas.Text = "Casado"
        Me.opEstCas.UseVisualStyleBackColor = True
        '
        'opCivSol
        '
        Me.opCivSol.AutoSize = True
        Me.opCivSol.Location = New System.Drawing.Point(14, 8)
        Me.opCivSol.Name = "opCivSol"
        Me.opCivSol.Size = New System.Drawing.Size(58, 17)
        Me.opCivSol.TabIndex = 46
        Me.opCivSol.TabStop = True
        Me.opCivSol.Text = "Soltero"
        Me.opCivSol.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.opGenFem)
        Me.Panel2.Controls.Add(Me.opGenMas)
        Me.Panel2.Location = New System.Drawing.Point(172, 190)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(196, 39)
        Me.Panel2.TabIndex = 46
        '
        'opGenFem
        '
        Me.opGenFem.AutoSize = True
        Me.opGenFem.Location = New System.Drawing.Point(98, 10)
        Me.opGenFem.Name = "opGenFem"
        Me.opGenFem.Size = New System.Drawing.Size(71, 17)
        Me.opGenFem.TabIndex = 44
        Me.opGenFem.TabStop = True
        Me.opGenFem.Text = "Femenino"
        Me.opGenFem.UseVisualStyleBackColor = True
        '
        'opGenMas
        '
        Me.opGenMas.AutoSize = True
        Me.opGenMas.Location = New System.Drawing.Point(12, 10)
        Me.opGenMas.Name = "opGenMas"
        Me.opGenMas.Size = New System.Drawing.Size(73, 17)
        Me.opGenMas.TabIndex = 43
        Me.opGenMas.TabStop = True
        Me.opGenMas.Text = "Masculino"
        Me.opGenMas.UseVisualStyleBackColor = True
        '
        'chDepPlay
        '
        Me.chDepPlay.AutoSize = True
        Me.chDepPlay.Location = New System.Drawing.Point(272, 292)
        Me.chDepPlay.Name = "chDepPlay"
        Me.chDepPlay.Size = New System.Drawing.Size(82, 17)
        Me.chDepPlay.TabIndex = 40
        Me.chDepPlay.Text = "Play Station"
        Me.chDepPlay.UseVisualStyleBackColor = True
        '
        'chDepTennis
        '
        Me.chDepTennis.AutoSize = True
        Me.chDepTennis.Location = New System.Drawing.Point(172, 292)
        Me.chDepTennis.Name = "chDepTennis"
        Me.chDepTennis.Size = New System.Drawing.Size(58, 17)
        Me.chDepTennis.TabIndex = 39
        Me.chDepTennis.Text = "Tennis"
        Me.chDepTennis.UseVisualStyleBackColor = True
        '
        'btLeer
        '
        Me.btLeer.Location = New System.Drawing.Point(361, 352)
        Me.btLeer.Name = "btLeer"
        Me.btLeer.Size = New System.Drawing.Size(75, 23)
        Me.btLeer.TabIndex = 38
        Me.btLeer.Text = "&Leer"
        Me.btLeer.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(131, 393)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(75, 23)
        Me.btSalir.TabIndex = 37
        Me.btSalir.Text = "&Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(199, 352)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btEliminar.TabIndex = 36
        Me.btEliminar.Text = "&Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(118, 352)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 35
        Me.btActualizar.Text = "A&ctualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'btListar
        '
        Me.btListar.Location = New System.Drawing.Point(18, 393)
        Me.btListar.Name = "btListar"
        Me.btListar.Size = New System.Drawing.Size(75, 23)
        Me.btListar.TabIndex = 34
        Me.btListar.Text = "L&istar"
        Me.btListar.UseVisualStyleBackColor = True
        '
        'btAgregar
        '
        Me.btAgregar.Location = New System.Drawing.Point(18, 352)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btAgregar.TabIndex = 33
        Me.btAgregar.Text = "&Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(257, 28)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(15, 20)
        Me.TextBox7.TabIndex = 32
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(172, 61)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(206, 20)
        Me.txtNombres.TabIndex = 31
        '
        'txApPat
        '
        Me.txApPat.Location = New System.Drawing.Point(172, 86)
        Me.txApPat.Name = "txApPat"
        Me.txApPat.Size = New System.Drawing.Size(122, 20)
        Me.txApPat.TabIndex = 30
        '
        'txApMat
        '
        Me.txApMat.Location = New System.Drawing.Point(172, 112)
        Me.txApMat.Name = "txApMat"
        Me.txApMat.Size = New System.Drawing.Size(122, 20)
        Me.txApMat.TabIndex = 29
        '
        'txtFNac
        '
        Me.txtFNac.Location = New System.Drawing.Point(172, 164)
        Me.txtFNac.Name = "txtFNac"
        Me.txtFNac.Size = New System.Drawing.Size(100, 20)
        Me.txtFNac.TabIndex = 28
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(172, 138)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(247, 20)
        Me.txtDir.TabIndex = 27
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(172, 27)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(79, 20)
        Me.txtRut.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(45, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Nombres"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Maroon
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(45, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Ap.Pateno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(45, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Ap.Materno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(45, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(45, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Fecha de Nacimiento"
        '
        'lbRut
        '
        Me.lbRut.AutoSize = True
        Me.lbRut.BackColor = System.Drawing.Color.Maroon
        Me.lbRut.ForeColor = System.Drawing.Color.Yellow
        Me.lbRut.Location = New System.Drawing.Point(45, 35)
        Me.lbRut.Name = "lbRut"
        Me.lbRut.Size = New System.Drawing.Size(24, 13)
        Me.lbRut.TabIndex = 20
        Me.lbRut.Text = "Rut"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(547, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(121, 97)
        Me.ListView1.TabIndex = 21
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(548, 126)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(549, 249)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 23
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(801, 498)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCliente"
        Me.Text = "Formula rio de Ejemplo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btLeer As Button
    Friend WithEvents btSalir As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btListar As Button
    Friend WithEvents btAgregar As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txApPat As TextBox
    Friend WithEvents txApMat As TextBox
    Friend WithEvents txtFNac As TextBox
    Friend WithEvents txtDir As TextBox
    Friend WithEvents txtRut As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbRut As Label
    Friend WithEvents chDepPlay As CheckBox
    Friend WithEvents chDepTennis As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents opGenFem As RadioButton
    Friend WithEvents opGenMas As RadioButton
    Friend WithEvents chDepCarr As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents opCivViu As RadioButton
    Friend WithEvents opEstCas As RadioButton
    Friend WithEvents opCivSol As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbComuna As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
