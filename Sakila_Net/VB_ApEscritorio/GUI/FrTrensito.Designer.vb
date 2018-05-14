<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrensito
    Inherits System.Windows.Forms.Form
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
		Me.pnPrincipal = New System.Windows.Forms.Panel()
        Me.btLeer = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btListar = New System.Windows.Forms.Button()
        Me.btAgregar = New System.Windows.Forms.Button()

        Me.LbId = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LbLargo = New System.Windows.Forms.Label()
        Me.TxtLargo = New System.Windows.Forms.TextBox()
        Me.LbIdMarca = New System.Windows.Forms.Label()
        Me.TxtIdMarca = New System.Windows.Forms.TextBox()

		Me.SuspendLayout()

		Me.pnPrincipal.SuspendLayout()

        Me.pnPrincipal.Controls.Add(Me.btLeer)
        Me.pnPrincipal.Controls.Add(Me.btSalir)
        Me.pnPrincipal.Controls.Add(Me.btEliminar)
        Me.pnPrincipal.Controls.Add(Me.btActualizar)
        Me.pnPrincipal.Controls.Add(Me.btListar)
        Me.pnPrincipal.Controls.Add(Me.btAgregar)

        Me.pnPrincipal.Controls.Add(Me.LbId)
        Me.pnPrincipal.Controls.Add(Me.TxtId)
        Me.pnPrincipal.Controls.Add(Me.LbNombre)
        Me.pnPrincipal.Controls.Add(Me.TxtNombre)
        Me.pnPrincipal.Controls.Add(Me.LbLargo)
        Me.pnPrincipal.Controls.Add(Me.TxtLargo)
        Me.pnPrincipal.Controls.Add(Me.LbIdMarca)
        Me.pnPrincipal.Controls.Add(Me.TxtIdMarca)






        Me.pnPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnPrincipal.Location = New System.Drawing.Point(22, 12)
        Me.pnPrincipal.Name = "pnPrincipal"
        Me.pnPrincipal.Size = New System.Drawing.Size(519, 450)
        Me.pnPrincipal.TabIndex = 20

        '
        '   Objeto Id
        '
        Me.LbId.AutoSize = True
        Me.LbId.BackColor = System.Drawing.Color.Blue
        Me.LbId.ForeColor = System.Drawing.Color.Yellow
        Me.LbId.Location = New System.Drawing.Point(30, 25)
        Me.LbId.Name = "TxtId"
        Me.LbId.Size = New System.Drawing.Size(175, 23)
        Me.LbId.TabIndex = 1
        Me.LbId.Text = "Id"


        Me.TxtId.Location = New System.Drawing.Point(150, 25)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(175, 23)
        Me.TxtId.TabIndex = 1
        Me.TxtId.Text = ""






        '
        '   Objeto Nombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.BackColor = System.Drawing.Color.Blue
        Me.LbNombre.ForeColor = System.Drawing.Color.Yellow
        Me.LbNombre.Location = New System.Drawing.Point(30, 50)
        Me.LbNombre.Name = "TxtNombre"
        Me.LbNombre.Size = New System.Drawing.Size(175, 23)
        Me.LbNombre.TabIndex = 2
        Me.LbNombre.Text = "Nombre"



        Me.TxtNombre.Location = New System.Drawing.Point(150, 50)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(175, 23)
        Me.TxtNombre.TabIndex = 2
        Me.TxtNombre.Text = ""





        '
        '   Objeto Largo
        '
        Me.LbLargo.AutoSize = True
        Me.LbLargo.BackColor = System.Drawing.Color.Blue
        Me.LbLargo.ForeColor = System.Drawing.Color.Yellow
        Me.LbLargo.Location = New System.Drawing.Point(30, 75)
        Me.LbLargo.Name = "TxtLargo"
        Me.LbLargo.Size = New System.Drawing.Size(175, 23)
        Me.LbLargo.TabIndex = 3
        Me.LbLargo.Text = "Largo"


        Me.TxtLargo.Location = New System.Drawing.Point(150, 75)
        Me.TxtLargo.Name = "TxtLargo"
        Me.TxtLargo.Size = New System.Drawing.Size(175, 23)
        Me.TxtLargo.TabIndex = 3
        Me.TxtLargo.Text = ""






        '
        '   Objeto IdMarca
        '
        Me.LbIdMarca.AutoSize = True
        Me.LbIdMarca.BackColor = System.Drawing.Color.Blue
        Me.LbIdMarca.ForeColor = System.Drawing.Color.Yellow
        Me.LbIdMarca.Location = New System.Drawing.Point(30, 100)
        Me.LbIdMarca.Name = "TxtIdMarca"
        Me.LbIdMarca.Size = New System.Drawing.Size(175, 23)
        Me.LbIdMarca.TabIndex = 4
        Me.LbIdMarca.Text = "IdMarca"


        Me.TxtIdMarca.Location = New System.Drawing.Point(150, 100)
        Me.TxtIdMarca.Name = "TxtIdMarca"
        Me.TxtIdMarca.Size = New System.Drawing.Size(175, 23)
        Me.TxtIdMarca.TabIndex = 4
        Me.TxtIdMarca.Text = ""







        '
        'btAgregar
        '
        Me.btAgregar.Location = New System.Drawing.Point(18, 125)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btAgregar.TabIndex = 33
        Me.btAgregar.Text = "&Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '

        '
        'btLeer
        '
        Me.btLeer.Location = New System.Drawing.Point(361, 125)
        Me.btLeer.Name = "btLeer"
        Me.btLeer.Size = New System.Drawing.Size(75, 23)
        Me.btLeer.TabIndex = 38
        Me.btLeer.Text = "&Leer"
        Me.btLeer.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(199, 125)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btEliminar.TabIndex = 36
        Me.btEliminar.Text = "&Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(118, 125)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 35
        Me.btActualizar.Text = "A&ctualizar"
        Me.btActualizar.UseVisualStyleBackColor = True




        '
        'btListar
        '
        Me.btListar.Location = New System.Drawing.Point(18, 150)
        Me.btListar.Name = "btListar"
        Me.btListar.Size = New System.Drawing.Size(75, 23)
        Me.btListar.TabIndex = 34
        Me.btListar.Text = "L&istar"
        Me.btListar.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(118, 150)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(75, 23)
        Me.btSalir.TabIndex = 37
        Me.btSalir.Text = "&Cerrar"
        Me.btSalir.UseVisualStyleBackColor = True



        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(801, 498)


        Me.Controls.Add(Me.pnPrincipal)
        Me.pnPrincipal.PerformLayout()

        Me.Name = "FrmCliente"
        Me.Text = "Formula rio de Ejemplo"
        Me.pnPrincipal.ResumeLayout(False)


        Me.ResumeLayout(False)

    End Sub
        Dim LinDel as Integer = 75
        Dim Lin as Integer = 20
    Friend WithEvents pnPrincipal As Panel    
    Friend WithEvents btLeer As Button
    Friend WithEvents btSalir As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btListar As Button
    Friend WithEvents btAgregar As Button



    Friend WithEvents LbId As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents LbNombre As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LbLargo As Label
    Friend WithEvents TxtLargo As TextBox
    Friend WithEvents LbIdMarca As Label
    Friend WithEvents TxtIdMarca As TextBox
End Class
