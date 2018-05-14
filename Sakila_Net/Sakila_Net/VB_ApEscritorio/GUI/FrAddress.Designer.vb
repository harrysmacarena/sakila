<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddress
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

        Me.LbAddressId = New System.Windows.Forms.Label()
        Me.TxtAddressId = New System.Windows.Forms.TextBox()
        Me.LbAddress = New System.Windows.Forms.Label()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.LbAddress2 = New System.Windows.Forms.Label()
        Me.TxtAddress2 = New System.Windows.Forms.TextBox()
        Me.LbDistrict = New System.Windows.Forms.Label()
        Me.TxtDistrict = New System.Windows.Forms.TextBox()
        Me.LbCityId = New System.Windows.Forms.Label()
        Me.txtCityId = New System.Windows.Forms.TextBox()
        Me.LbPostalCode = New System.Windows.Forms.Label()
        Me.TxtPostalCode = New System.Windows.Forms.TextBox()
        Me.LbPhone = New System.Windows.Forms.Label()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
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

        Me.pnPrincipal.Controls.Add(Me.LbAddressId)
        Me.pnPrincipal.Controls.Add(Me.TxtAddressId)
        Me.pnPrincipal.Controls.Add(Me.LbAddress)
        Me.pnPrincipal.Controls.Add(Me.TxtAddress)
        Me.pnPrincipal.Controls.Add(Me.LbAddress2)
        Me.pnPrincipal.Controls.Add(Me.TxtAddress2)
        Me.pnPrincipal.Controls.Add(Me.LbDistrict)
        Me.pnPrincipal.Controls.Add(Me.TxtDistrict)
        Me.pnPrincipal.Controls.Add(Me.LbCityId)
        Me.pnPrincipal.Controls.Add(Me.TxtCityId)
        Me.pnPrincipal.Controls.Add(Me.LbPostalCode)
        Me.pnPrincipal.Controls.Add(Me.TxtPostalCode)
        Me.pnPrincipal.Controls.Add(Me.LbPhone)
        Me.pnPrincipal.Controls.Add(Me.TxtPhone)
        Me.pnPrincipal.Controls.Add(Me.LbLastUpdate)
        Me.pnPrincipal.Controls.Add(Me.TxtLastUpdate)






        Me.pnPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnPrincipal.Location = New System.Drawing.Point(22, 12)
        Me.pnPrincipal.Name = "pnPrincipal"
        Me.pnPrincipal.Size = New System.Drawing.Size(519, 450)
        Me.pnPrincipal.TabIndex = 20

        '
        '   Objeto AddressId
        '
        Me.LbAddressId.AutoSize = True
        Me.LbAddressId.BackColor = System.Drawing.Color.Blue
        Me.LbAddressId.ForeColor = System.Drawing.Color.Yellow
        Me.LbAddressId.Location = New System.Drawing.Point(30, 25)
        Me.LbAddressId.Name = "TxtAddressId"
        Me.LbAddressId.Size = New System.Drawing.Size(175, 23)
        Me.LbAddressId.TabIndex = 1
        Me.LbAddressId.Text = "AddressId"


        Me.TxtAddressId.Location = New System.Drawing.Point(150, 25)
        Me.TxtAddressId.Name = "TxtAddressId"
        Me.TxtAddressId.Size = New System.Drawing.Size(175, 23)
        Me.TxtAddressId.TabIndex = 1
        Me.TxtAddressId.Text = ""






        '
        '   Objeto Address
        '
        Me.LbAddress.AutoSize = True
        Me.LbAddress.BackColor = System.Drawing.Color.Blue
        Me.LbAddress.ForeColor = System.Drawing.Color.Yellow
        Me.LbAddress.Location = New System.Drawing.Point(30, 50)
        Me.LbAddress.Name = "TxtAddress"
        Me.LbAddress.Size = New System.Drawing.Size(175, 23)
        Me.LbAddress.TabIndex = 2
        Me.LbAddress.Text = "Address"



        Me.TxtAddress.Location = New System.Drawing.Point(150, 50)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(175, 23)
        Me.TxtAddress.TabIndex = 2
        Me.TxtAddress.Text = ""





        '
        '   Objeto Address2
        '
        Me.LbAddress2.AutoSize = True
        Me.LbAddress2.BackColor = System.Drawing.Color.Blue
        Me.LbAddress2.ForeColor = System.Drawing.Color.Yellow
        Me.LbAddress2.Location = New System.Drawing.Point(30, 75)
        Me.LbAddress2.Name = "TxtAddress2"
        Me.LbAddress2.Size = New System.Drawing.Size(175, 23)
        Me.LbAddress2.TabIndex = 3
        Me.LbAddress2.Text = "Address2"



        Me.TxtAddress2.Location = New System.Drawing.Point(150, 75)
        Me.TxtAddress2.Name = "TxtAddress2"
        Me.TxtAddress2.Size = New System.Drawing.Size(175, 23)
        Me.TxtAddress2.TabIndex = 3
        Me.TxtAddress2.Text = ""





        '
        '   Objeto District
        '
        Me.LbDistrict.AutoSize = True
        Me.LbDistrict.BackColor = System.Drawing.Color.Blue
        Me.LbDistrict.ForeColor = System.Drawing.Color.Yellow
        Me.LbDistrict.Location = New System.Drawing.Point(30, 100)
        Me.LbDistrict.Name = "TxtDistrict"
        Me.LbDistrict.Size = New System.Drawing.Size(175, 23)
        Me.LbDistrict.TabIndex = 4
        Me.LbDistrict.Text = "District"



        Me.TxtDistrict.Location = New System.Drawing.Point(150, 100)
        Me.TxtDistrict.Name = "TxtDistrict"
        Me.TxtDistrict.Size = New System.Drawing.Size(175, 23)
        Me.TxtDistrict.TabIndex = 4
        Me.TxtDistrict.Text = ""





        '
        '   Objeto CityId
        '
        Me.LbCityId.AutoSize = True
        Me.LbCityId.BackColor = System.Drawing.Color.Blue
        Me.LbCityId.ForeColor = System.Drawing.Color.Yellow
        Me.LbCityId.Location = New System.Drawing.Point(30, 125)
        Me.LbCityId.Name = "TxtCityId"
        Me.LbCityId.Size = New System.Drawing.Size(175, 23)
        Me.LbCityId.TabIndex = 5
        Me.LbCityId.Text = "CityId"








        Me.TxtCityId.Location = New System.Drawing.Point(150, 125)
        Me.TxtCityId.Name = "TxtCityId"
        Me.TxtCityId.Size = New System.Drawing.Size(175, 23)
        Me.TxtCityId.TabIndex = 5
        Me.TxtCityId.Text = ""
        '
        '   Objeto PostalCode
        '
        Me.LbPostalCode.AutoSize = True
        Me.LbPostalCode.BackColor = System.Drawing.Color.Blue
        Me.LbPostalCode.ForeColor = System.Drawing.Color.Yellow
        Me.LbPostalCode.Location = New System.Drawing.Point(30, 150)
        Me.LbPostalCode.Name = "TxtPostalCode"
        Me.LbPostalCode.Size = New System.Drawing.Size(175, 23)
        Me.LbPostalCode.TabIndex = 6
        Me.LbPostalCode.Text = "PostalCode"



        Me.TxtPostalCode.Location = New System.Drawing.Point(150, 150)
        Me.TxtPostalCode.Name = "TxtPostalCode"
        Me.TxtPostalCode.Size = New System.Drawing.Size(175, 23)
        Me.TxtPostalCode.TabIndex = 6
        Me.TxtPostalCode.Text = ""





        '
        '   Objeto Phone
        '
        Me.LbPhone.AutoSize = True
        Me.LbPhone.BackColor = System.Drawing.Color.Blue
        Me.LbPhone.ForeColor = System.Drawing.Color.Yellow
        Me.LbPhone.Location = New System.Drawing.Point(30, 175)
        Me.LbPhone.Name = "TxtPhone"
        Me.LbPhone.Size = New System.Drawing.Size(175, 23)
        Me.LbPhone.TabIndex = 7
        Me.LbPhone.Text = "Phone"



        Me.TxtPhone.Location = New System.Drawing.Point(150, 175)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(175, 23)
        Me.TxtPhone.TabIndex = 7
        Me.TxtPhone.Text = ""





        '
        '   Objeto LastUpdate
        '
        Me.LbLastUpdate.AutoSize = True
        Me.LbLastUpdate.BackColor = System.Drawing.Color.Blue
        Me.LbLastUpdate.ForeColor = System.Drawing.Color.Yellow
        Me.LbLastUpdate.Location = New System.Drawing.Point(30, 200)
        Me.LbLastUpdate.Name = "TxtLastUpdate"
        Me.LbLastUpdate.Size = New System.Drawing.Size(175, 23)
        Me.LbLastUpdate.TabIndex = 8
        Me.LbLastUpdate.Text = "LastUpdate"




        Me.TxtLastUpdate.Location = New System.Drawing.Point(150, 200)
        Me.TxtLastUpdate.Name = "TxtLastUpdate"
        Me.TxtLastUpdate.Size = New System.Drawing.Size(175, 23)
        Me.TxtLastUpdate.TabIndex = 8
        Me.TxtLastUpdate.Text = ""





        '
        'btAgregar
        '
        Me.btAgregar.Location = New System.Drawing.Point(18, 225)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btAgregar.TabIndex = 33
        Me.btAgregar.Text = "&Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '

        '
        'btLeer
        '
        Me.btLeer.Location = New System.Drawing.Point(361, 225)
        Me.btLeer.Name = "btLeer"
        Me.btLeer.Size = New System.Drawing.Size(75, 23)
        Me.btLeer.TabIndex = 38
        Me.btLeer.Text = "&Leer"
        Me.btLeer.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(199, 225)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btEliminar.TabIndex = 36
        Me.btEliminar.Text = "&Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(118, 225)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 35
        Me.btActualizar.Text = "A&ctualizar"
        Me.btActualizar.UseVisualStyleBackColor = True




        '
        'btListar
        '
        Me.btListar.Location = New System.Drawing.Point(18, 250)
        Me.btListar.Name = "btListar"
        Me.btListar.Size = New System.Drawing.Size(75, 23)
        Me.btListar.TabIndex = 34
        Me.btListar.Text = "L&istar"
        Me.btListar.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(118, 250)
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



    Friend WithEvents LbAddressId As Label
    Friend WithEvents TxtAddressId As TextBox
    Friend WithEvents LbAddress As Label
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents LbAddress2 As Label
    Friend WithEvents TxtAddress2 As TextBox
    Friend WithEvents LbDistrict As Label
    Friend WithEvents TxtDistrict As TextBox
    Friend WithEvents LbCityId As Label
    Friend WithEvents txtCityId As TextBox
    Friend WithEvents LbPostalCode As Label
    Friend WithEvents TxtPostalCode As TextBox
    Friend WithEvents LbPhone As Label
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents LbLastUpdate As Label
    Friend WithEvents TxtLastUpdate As TextBox
End Class
