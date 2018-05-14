<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStaff
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

        Me.LbStaffId = New System.Windows.Forms.Label()
        Me.TxtStaffId = New System.Windows.Forms.TextBox()
        Me.LbFirstName = New System.Windows.Forms.Label()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.LbLastName = New System.Windows.Forms.Label()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.LbAddressId = New System.Windows.Forms.Label()
        Me.txtAddressId = New System.Windows.Forms.TextBox()
        Me.LbPicture = New System.Windows.Forms.Label()
       Me.TxtPicture = New System.Windows.Forms.TextBox()
        Me.LbEmail = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LbStoreId = New System.Windows.Forms.Label()
        Me.txtStoreId = New System.Windows.Forms.TextBox()
        Me.LbActive = New System.Windows.Forms.Label()
        Me.TxtActive = New System.Windows.Forms.TextBox()
        Me.LbUsername = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.LbPassword = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
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

        Me.pnPrincipal.Controls.Add(Me.LbStaffId)
        Me.pnPrincipal.Controls.Add(Me.TxtStaffId)
        Me.pnPrincipal.Controls.Add(Me.LbFirstName)
        Me.pnPrincipal.Controls.Add(Me.TxtFirstName)
        Me.pnPrincipal.Controls.Add(Me.LbLastName)
        Me.pnPrincipal.Controls.Add(Me.TxtLastName)
        Me.pnPrincipal.Controls.Add(Me.LbAddressId)
        Me.pnPrincipal.Controls.Add(Me.TxtAddressId)
        Me.pnPrincipal.Controls.Add(Me.LbPicture)
       Me.pnPrincipal.Controls.Add(Me.TxtPicture)
        Me.pnPrincipal.Controls.Add(Me.LbEmail)
        Me.pnPrincipal.Controls.Add(Me.TxtEmail)
        Me.pnPrincipal.Controls.Add(Me.LbStoreId)
        Me.pnPrincipal.Controls.Add(Me.TxtStoreId)
        Me.pnPrincipal.Controls.Add(Me.LbActive)
        Me.pnPrincipal.Controls.Add(Me.TxtActive)
        Me.pnPrincipal.Controls.Add(Me.LbUsername)
        Me.pnPrincipal.Controls.Add(Me.TxtUsername)
        Me.pnPrincipal.Controls.Add(Me.LbPassword)
        Me.pnPrincipal.Controls.Add(Me.TxtPassword)
        Me.pnPrincipal.Controls.Add(Me.LbLastUpdate)
        Me.pnPrincipal.Controls.Add(Me.TxtLastUpdate)






        Me.pnPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnPrincipal.Location = New System.Drawing.Point(22, 12)
        Me.pnPrincipal.Name = "pnPrincipal"
        Me.pnPrincipal.Size = New System.Drawing.Size(519, 450)
        Me.pnPrincipal.TabIndex = 20

        '
        '   Objeto StaffId
        '
        Me.LbStaffId.AutoSize = True
        Me.LbStaffId.BackColor = System.Drawing.Color.Blue
        Me.LbStaffId.ForeColor = System.Drawing.Color.Yellow
        Me.LbStaffId.Location = New System.Drawing.Point(30, 25)
        Me.LbStaffId.Name = "TxtStaffId"
        Me.LbStaffId.Size = New System.Drawing.Size(175, 23)
        Me.LbStaffId.TabIndex = 1
        Me.LbStaffId.Text = "StaffId"


        Me.TxtStaffId.Location = New System.Drawing.Point(150, 25)
        Me.TxtStaffId.Name = "TxtStaffId"
        Me.TxtStaffId.Size = New System.Drawing.Size(175, 23)
        Me.TxtStaffId.TabIndex = 1
        Me.TxtStaffId.Text = ""






        '
        '   Objeto FirstName
        '
        Me.LbFirstName.AutoSize = True
        Me.LbFirstName.BackColor = System.Drawing.Color.Blue
        Me.LbFirstName.ForeColor = System.Drawing.Color.Yellow
        Me.LbFirstName.Location = New System.Drawing.Point(30, 50)
        Me.LbFirstName.Name = "TxtFirstName"
        Me.LbFirstName.Size = New System.Drawing.Size(175, 23)
        Me.LbFirstName.TabIndex = 2
        Me.LbFirstName.Text = "FirstName"



        Me.TxtFirstName.Location = New System.Drawing.Point(150, 50)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(175, 23)
        Me.TxtFirstName.TabIndex = 2
        Me.TxtFirstName.Text = ""





        '
        '   Objeto LastName
        '
        Me.LbLastName.AutoSize = True
        Me.LbLastName.BackColor = System.Drawing.Color.Blue
        Me.LbLastName.ForeColor = System.Drawing.Color.Yellow
        Me.LbLastName.Location = New System.Drawing.Point(30, 75)
        Me.LbLastName.Name = "TxtLastName"
        Me.LbLastName.Size = New System.Drawing.Size(175, 23)
        Me.LbLastName.TabIndex = 3
        Me.LbLastName.Text = "LastName"



        Me.TxtLastName.Location = New System.Drawing.Point(150, 75)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(175, 23)
        Me.TxtLastName.TabIndex = 3
        Me.TxtLastName.Text = ""





        '
        '   Objeto AddressId
        '
        Me.LbAddressId.AutoSize = True
        Me.LbAddressId.BackColor = System.Drawing.Color.Blue
        Me.LbAddressId.ForeColor = System.Drawing.Color.Yellow
        Me.LbAddressId.Location = New System.Drawing.Point(30, 100)
        Me.LbAddressId.Name = "TxtAddressId"
        Me.LbAddressId.Size = New System.Drawing.Size(175, 23)
        Me.LbAddressId.TabIndex = 4
        Me.LbAddressId.Text = "AddressId"








        Me.TxtAddressId.Location = New System.Drawing.Point(150, 100)
        Me.TxtAddressId.Name = "TxtAddressId"
        Me.TxtAddressId.Size = New System.Drawing.Size(175, 23)
        Me.TxtAddressId.TabIndex = 4
        Me.TxtAddressId.Text = ""
        '
        '   Objeto Picture
        '
        Me.LbPicture.AutoSize = True
        Me.LbPicture.BackColor = System.Drawing.Color.Blue
        Me.LbPicture.ForeColor = System.Drawing.Color.Yellow
        Me.LbPicture.Location = New System.Drawing.Point(30, 125)
        Me.LbPicture.Name = "TxtPicture"
        Me.LbPicture.Size = New System.Drawing.Size(175, 23)
        Me.LbPicture.TabIndex = 5
        Me.LbPicture.Text = "Picture"







        Me.TxtPicture.Location = New System.Drawing.Point(150, 125)
        Me.TxtPicture.Name = "TxtPicture"
        Me.TxtPicture.Size = New System.Drawing.Size(175, 23)
        Me.TxtPicture.TabIndex = 5
        Me.TxtPicture.Text = ""

        '
        '   Objeto Email
        '
        Me.LbEmail.AutoSize = True
        Me.LbEmail.BackColor = System.Drawing.Color.Blue
        Me.LbEmail.ForeColor = System.Drawing.Color.Yellow
        Me.LbEmail.Location = New System.Drawing.Point(30, 150)
        Me.LbEmail.Name = "TxtEmail"
        Me.LbEmail.Size = New System.Drawing.Size(175, 23)
        Me.LbEmail.TabIndex = 6
        Me.LbEmail.Text = "Email"



        Me.TxtEmail.Location = New System.Drawing.Point(150, 150)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(175, 23)
        Me.TxtEmail.TabIndex = 6
        Me.TxtEmail.Text = ""





        '
        '   Objeto StoreId
        '
        Me.LbStoreId.AutoSize = True
        Me.LbStoreId.BackColor = System.Drawing.Color.Blue
        Me.LbStoreId.ForeColor = System.Drawing.Color.Yellow
        Me.LbStoreId.Location = New System.Drawing.Point(30, 175)
        Me.LbStoreId.Name = "TxtStoreId"
        Me.LbStoreId.Size = New System.Drawing.Size(175, 23)
        Me.LbStoreId.TabIndex = 7
        Me.LbStoreId.Text = "StoreId"








        Me.TxtStoreId.Location = New System.Drawing.Point(150, 175)
        Me.TxtStoreId.Name = "TxtStoreId"
        Me.TxtStoreId.Size = New System.Drawing.Size(175, 23)
        Me.TxtStoreId.TabIndex = 7
        Me.TxtStoreId.Text = ""
        '
        '   Objeto Active
        '
        Me.LbActive.AutoSize = True
        Me.LbActive.BackColor = System.Drawing.Color.Blue
        Me.LbActive.ForeColor = System.Drawing.Color.Yellow
        Me.LbActive.Location = New System.Drawing.Point(30, 200)
        Me.LbActive.Name = "TxtActive"
        Me.LbActive.Size = New System.Drawing.Size(175, 23)
        Me.LbActive.TabIndex = 8
        Me.LbActive.Text = "Active"


        Me.TxtActive.Location = New System.Drawing.Point(150, 200)
        Me.TxtActive.Name = "TxtActive"
        Me.TxtActive.Size = New System.Drawing.Size(175, 23)
        Me.TxtActive.TabIndex = 8
        Me.TxtActive.Text = ""






        '
        '   Objeto Username
        '
        Me.LbUsername.AutoSize = True
        Me.LbUsername.BackColor = System.Drawing.Color.Blue
        Me.LbUsername.ForeColor = System.Drawing.Color.Yellow
        Me.LbUsername.Location = New System.Drawing.Point(30, 225)
        Me.LbUsername.Name = "TxtUsername"
        Me.LbUsername.Size = New System.Drawing.Size(175, 23)
        Me.LbUsername.TabIndex = 9
        Me.LbUsername.Text = "Username"



        Me.TxtUsername.Location = New System.Drawing.Point(150, 225)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(175, 23)
        Me.TxtUsername.TabIndex = 9
        Me.TxtUsername.Text = ""





        '
        '   Objeto Password
        '
        Me.LbPassword.AutoSize = True
        Me.LbPassword.BackColor = System.Drawing.Color.Blue
        Me.LbPassword.ForeColor = System.Drawing.Color.Yellow
        Me.LbPassword.Location = New System.Drawing.Point(30, 250)
        Me.LbPassword.Name = "TxtPassword"
        Me.LbPassword.Size = New System.Drawing.Size(175, 23)
        Me.LbPassword.TabIndex = 10
        Me.LbPassword.Text = "Password"



        Me.TxtPassword.Location = New System.Drawing.Point(150, 250)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(175, 23)
        Me.TxtPassword.TabIndex = 10
        Me.TxtPassword.Text = ""





        '
        '   Objeto LastUpdate
        '
        Me.LbLastUpdate.AutoSize = True
        Me.LbLastUpdate.BackColor = System.Drawing.Color.Blue
        Me.LbLastUpdate.ForeColor = System.Drawing.Color.Yellow
        Me.LbLastUpdate.Location = New System.Drawing.Point(30, 275)
        Me.LbLastUpdate.Name = "TxtLastUpdate"
        Me.LbLastUpdate.Size = New System.Drawing.Size(175, 23)
        Me.LbLastUpdate.TabIndex = 11
        Me.LbLastUpdate.Text = "LastUpdate"




        Me.TxtLastUpdate.Location = New System.Drawing.Point(150, 275)
        Me.TxtLastUpdate.Name = "TxtLastUpdate"
        Me.TxtLastUpdate.Size = New System.Drawing.Size(175, 23)
        Me.TxtLastUpdate.TabIndex = 11
        Me.TxtLastUpdate.Text = ""





        '
        'btAgregar
        '
        Me.btAgregar.Location = New System.Drawing.Point(18, 300)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btAgregar.TabIndex = 33
        Me.btAgregar.Text = "&Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '

        '
        'btLeer
        '
        Me.btLeer.Location = New System.Drawing.Point(361, 300)
        Me.btLeer.Name = "btLeer"
        Me.btLeer.Size = New System.Drawing.Size(75, 23)
        Me.btLeer.TabIndex = 38
        Me.btLeer.Text = "&Leer"
        Me.btLeer.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(199, 300)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btEliminar.TabIndex = 36
        Me.btEliminar.Text = "&Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(118, 300)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 35
        Me.btActualizar.Text = "A&ctualizar"
        Me.btActualizar.UseVisualStyleBackColor = True




        '
        'btListar
        '
        Me.btListar.Location = New System.Drawing.Point(18, 325)
        Me.btListar.Name = "btListar"
        Me.btListar.Size = New System.Drawing.Size(75, 23)
        Me.btListar.TabIndex = 34
        Me.btListar.Text = "L&istar"
        Me.btListar.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(118, 325)
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



    Friend WithEvents LbStaffId As Label
    Friend WithEvents TxtStaffId As TextBox
    Friend WithEvents LbFirstName As Label
    Friend WithEvents TxtFirstName As TextBox
    Friend WithEvents LbLastName As Label
    Friend WithEvents TxtLastName As TextBox
    Friend WithEvents LbAddressId As Label
    Friend WithEvents txtAddressId As TextBox
    Friend WithEvents LbPicture As Label
    Friend WithEvents TxtPicture As TextBox
    Friend WithEvents LbEmail As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents LbStoreId As Label
    Friend WithEvents txtStoreId As TextBox
    Friend WithEvents LbActive As Label
    Friend WithEvents TxtActive As TextBox
    Friend WithEvents LbUsername As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents LbPassword As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LbLastUpdate As Label
    Friend WithEvents TxtLastUpdate As TextBox
End Class
