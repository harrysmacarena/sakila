<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCity
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

        Me.LbCityId = New System.Windows.Forms.Label()
        Me.TxtCityId = New System.Windows.Forms.TextBox()
        Me.LbCity = New System.Windows.Forms.Label()
        Me.TxtCity = New System.Windows.Forms.TextBox()
        Me.LbCountryId = New System.Windows.Forms.Label()
        Me.txtCountryId = New System.Windows.Forms.TextBox()
        Me.LbLastUpdate = New System.Windows.Forms.Label()
        Me.TxtLastUpdate = New System.Windows.Forms.TextBox()

		Me.SuspendLayout()

		Me.pnPrincipal.SuspendLayout()

        Me.pnPrincipal.Controls.Add(Me.btLeer)
        Me.pnPrincipal.Controls.Add(Me.btSalir)
        Me.pnPrincipal.Controls.Add(Me.btEliminar)
        Me.pnPrincipal.Controls.Add(Me.btActualizar)
        Me.pnPrincipal.Controls.Add(Me.btListar)
        Me.pnPrincipal.Controls.Add(Me.btAgregar)

        Me.pnPrincipal.Controls.Add(Me.LbCityId)
        Me.pnPrincipal.Controls.Add(Me.TxtCityId)
        Me.pnPrincipal.Controls.Add(Me.LbCity)
        Me.pnPrincipal.Controls.Add(Me.TxtCity)
        Me.pnPrincipal.Controls.Add(Me.LbCountryId)
        Me.pnPrincipal.Controls.Add(Me.TxtCountryId)
        Me.pnPrincipal.Controls.Add(Me.LbLastUpdate)
        Me.pnPrincipal.Controls.Add(Me.TxtLastUpdate)






        Me.pnPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnPrincipal.Location = New System.Drawing.Point(22, 12)
        Me.pnPrincipal.Name = "pnPrincipal"
        Me.pnPrincipal.Size = New System.Drawing.Size(519, 450)
        Me.pnPrincipal.TabIndex = 20

        '
        '   Objeto CityId
        '
        Me.LbCityId.AutoSize = True
        Me.LbCityId.BackColor = System.Drawing.Color.Blue
        Me.LbCityId.ForeColor = System.Drawing.Color.Yellow
        Me.LbCityId.Location = New System.Drawing.Point(30, 25)
        Me.LbCityId.Name = "TxtCityId"
        Me.LbCityId.Size = New System.Drawing.Size(175, 23)
        Me.LbCityId.TabIndex = 1
        Me.LbCityId.Text = "CityId"


        Me.TxtCityId.Location = New System.Drawing.Point(150, 25)
        Me.TxtCityId.Name = "TxtCityId"
        Me.TxtCityId.Size = New System.Drawing.Size(175, 23)
        Me.TxtCityId.TabIndex = 1
        Me.TxtCityId.Text = ""






        '
        '   Objeto City
        '
        Me.LbCity.AutoSize = True
        Me.LbCity.BackColor = System.Drawing.Color.Blue
        Me.LbCity.ForeColor = System.Drawing.Color.Yellow
        Me.LbCity.Location = New System.Drawing.Point(30, 50)
        Me.LbCity.Name = "TxtCity"
        Me.LbCity.Size = New System.Drawing.Size(175, 23)
        Me.LbCity.TabIndex = 2
        Me.LbCity.Text = "City"



        Me.TxtCity.Location = New System.Drawing.Point(150, 50)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(175, 23)
        Me.TxtCity.TabIndex = 2
        Me.TxtCity.Text = ""





        '
        '   Objeto CountryId
        '
        Me.LbCountryId.AutoSize = True
        Me.LbCountryId.BackColor = System.Drawing.Color.Blue
        Me.LbCountryId.ForeColor = System.Drawing.Color.Yellow
        Me.LbCountryId.Location = New System.Drawing.Point(30, 75)
        Me.LbCountryId.Name = "TxtCountryId"
        Me.LbCountryId.Size = New System.Drawing.Size(175, 23)
        Me.LbCountryId.TabIndex = 3
        Me.LbCountryId.Text = "CountryId"








        Me.TxtCountryId.Location = New System.Drawing.Point(150, 75)
        Me.TxtCountryId.Name = "TxtCountryId"
        Me.TxtCountryId.Size = New System.Drawing.Size(175, 23)
        Me.TxtCountryId.TabIndex = 3
        Me.TxtCountryId.Text = ""
        '
        '   Objeto LastUpdate
        '
        Me.LbLastUpdate.AutoSize = True
        Me.LbLastUpdate.BackColor = System.Drawing.Color.Blue
        Me.LbLastUpdate.ForeColor = System.Drawing.Color.Yellow
        Me.LbLastUpdate.Location = New System.Drawing.Point(30, 100)
        Me.LbLastUpdate.Name = "TxtLastUpdate"
        Me.LbLastUpdate.Size = New System.Drawing.Size(175, 23)
        Me.LbLastUpdate.TabIndex = 4
        Me.LbLastUpdate.Text = "LastUpdate"




        Me.TxtLastUpdate.Location = New System.Drawing.Point(150, 100)
        Me.TxtLastUpdate.Name = "TxtLastUpdate"
        Me.TxtLastUpdate.Size = New System.Drawing.Size(175, 23)
        Me.TxtLastUpdate.TabIndex = 4
        Me.TxtLastUpdate.Text = ""





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



    Friend WithEvents LbCityId As Label
    Friend WithEvents TxtCityId As TextBox
    Friend WithEvents LbCity As Label
    Friend WithEvents TxtCity As TextBox
    Friend WithEvents LbCountryId As Label
    Friend WithEvents txtCountryId As TextBox
    Friend WithEvents LbLastUpdate As Label
    Friend WithEvents TxtLastUpdate As TextBox
End Class
