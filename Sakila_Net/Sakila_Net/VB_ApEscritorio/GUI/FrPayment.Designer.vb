<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayment
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

        Me.LbPaymentId = New System.Windows.Forms.Label()
        Me.TxtPaymentId = New System.Windows.Forms.TextBox()
        Me.LbCustomerId = New System.Windows.Forms.Label()
        Me.txtCustomerId = New System.Windows.Forms.TextBox()
        Me.LbStaffId = New System.Windows.Forms.Label()
        Me.txtStaffId = New System.Windows.Forms.TextBox()
        Me.LbRentalId = New System.Windows.Forms.Label()
        Me.txtRentalId = New System.Windows.Forms.TextBox()
        Me.LbAmount = New System.Windows.Forms.Label()
        Me.TxtAmount = New System.Windows.Forms.TextBox()
        Me.LbPaymentDate = New System.Windows.Forms.Label()
        Me.TxtPaymentDate = New System.Windows.Forms.TextBox()
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

        Me.pnPrincipal.Controls.Add(Me.LbPaymentId)
        Me.pnPrincipal.Controls.Add(Me.TxtPaymentId)
        Me.pnPrincipal.Controls.Add(Me.LbCustomerId)
        Me.pnPrincipal.Controls.Add(Me.TxtCustomerId)
        Me.pnPrincipal.Controls.Add(Me.LbStaffId)
        Me.pnPrincipal.Controls.Add(Me.TxtStaffId)
        Me.pnPrincipal.Controls.Add(Me.LbRentalId)
        Me.pnPrincipal.Controls.Add(Me.TxtRentalId)
        Me.pnPrincipal.Controls.Add(Me.LbAmount)
        Me.pnPrincipal.Controls.Add(Me.TxtAmount)
        Me.pnPrincipal.Controls.Add(Me.LbPaymentDate)
        Me.pnPrincipal.Controls.Add(Me.TxtPaymentDate)
        Me.pnPrincipal.Controls.Add(Me.LbLastUpdate)
        Me.pnPrincipal.Controls.Add(Me.TxtLastUpdate)






        Me.pnPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnPrincipal.Location = New System.Drawing.Point(22, 12)
        Me.pnPrincipal.Name = "pnPrincipal"
        Me.pnPrincipal.Size = New System.Drawing.Size(519, 450)
        Me.pnPrincipal.TabIndex = 20

        '
        '   Objeto PaymentId
        '
        Me.LbPaymentId.AutoSize = True
        Me.LbPaymentId.BackColor = System.Drawing.Color.Blue
        Me.LbPaymentId.ForeColor = System.Drawing.Color.Yellow
        Me.LbPaymentId.Location = New System.Drawing.Point(30, 25)
        Me.LbPaymentId.Name = "TxtPaymentId"
        Me.LbPaymentId.Size = New System.Drawing.Size(175, 23)
        Me.LbPaymentId.TabIndex = 1
        Me.LbPaymentId.Text = "PaymentId"


        Me.TxtPaymentId.Location = New System.Drawing.Point(150, 25)
        Me.TxtPaymentId.Name = "TxtPaymentId"
        Me.TxtPaymentId.Size = New System.Drawing.Size(175, 23)
        Me.TxtPaymentId.TabIndex = 1
        Me.TxtPaymentId.Text = ""






        '
        '   Objeto CustomerId
        '
        Me.LbCustomerId.AutoSize = True
        Me.LbCustomerId.BackColor = System.Drawing.Color.Blue
        Me.LbCustomerId.ForeColor = System.Drawing.Color.Yellow
        Me.LbCustomerId.Location = New System.Drawing.Point(30, 50)
        Me.LbCustomerId.Name = "TxtCustomerId"
        Me.LbCustomerId.Size = New System.Drawing.Size(175, 23)
        Me.LbCustomerId.TabIndex = 2
        Me.LbCustomerId.Text = "CustomerId"








        Me.TxtCustomerId.Location = New System.Drawing.Point(150, 50)
        Me.TxtCustomerId.Name = "TxtCustomerId"
        Me.TxtCustomerId.Size = New System.Drawing.Size(175, 23)
        Me.TxtCustomerId.TabIndex = 2
        Me.TxtCustomerId.Text = ""
        '
        '   Objeto StaffId
        '
        Me.LbStaffId.AutoSize = True
        Me.LbStaffId.BackColor = System.Drawing.Color.Blue
        Me.LbStaffId.ForeColor = System.Drawing.Color.Yellow
        Me.LbStaffId.Location = New System.Drawing.Point(30, 75)
        Me.LbStaffId.Name = "TxtStaffId"
        Me.LbStaffId.Size = New System.Drawing.Size(175, 23)
        Me.LbStaffId.TabIndex = 3
        Me.LbStaffId.Text = "StaffId"








        Me.TxtStaffId.Location = New System.Drawing.Point(150, 75)
        Me.TxtStaffId.Name = "TxtStaffId"
        Me.TxtStaffId.Size = New System.Drawing.Size(175, 23)
        Me.TxtStaffId.TabIndex = 3
        Me.TxtStaffId.Text = ""
        '
        '   Objeto RentalId
        '
        Me.LbRentalId.AutoSize = True
        Me.LbRentalId.BackColor = System.Drawing.Color.Blue
        Me.LbRentalId.ForeColor = System.Drawing.Color.Yellow
        Me.LbRentalId.Location = New System.Drawing.Point(30, 100)
        Me.LbRentalId.Name = "TxtRentalId"
        Me.LbRentalId.Size = New System.Drawing.Size(175, 23)
        Me.LbRentalId.TabIndex = 4
        Me.LbRentalId.Text = "RentalId"








        Me.TxtRentalId.Location = New System.Drawing.Point(150, 100)
        Me.TxtRentalId.Name = "TxtRentalId"
        Me.TxtRentalId.Size = New System.Drawing.Size(175, 23)
        Me.TxtRentalId.TabIndex = 4
        Me.TxtRentalId.Text = ""
        '
        '   Objeto Amount
        '
        Me.LbAmount.AutoSize = True
        Me.LbAmount.BackColor = System.Drawing.Color.Blue
        Me.LbAmount.ForeColor = System.Drawing.Color.Yellow
        Me.LbAmount.Location = New System.Drawing.Point(30, 125)
        Me.LbAmount.Name = "TxtAmount"
        Me.LbAmount.Size = New System.Drawing.Size(175, 23)
        Me.LbAmount.TabIndex = 5
        Me.LbAmount.Text = "Amount"

        Me.TxtAmount.Location = New System.Drawing.Point(150, 125)
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(175, 23)
        Me.TxtAmount.TabIndex = 5
        Me.TxtAmount.Text = ""







        '
        '   Objeto PaymentDate
        '
        Me.LbPaymentDate.AutoSize = True
        Me.LbPaymentDate.BackColor = System.Drawing.Color.Blue
        Me.LbPaymentDate.ForeColor = System.Drawing.Color.Yellow
        Me.LbPaymentDate.Location = New System.Drawing.Point(30, 150)
        Me.LbPaymentDate.Name = "TxtPaymentDate"
        Me.LbPaymentDate.Size = New System.Drawing.Size(175, 23)
        Me.LbPaymentDate.TabIndex = 6
        Me.LbPaymentDate.Text = "PaymentDate"




        Me.TxtPaymentDate.Location = New System.Drawing.Point(150, 150)
        Me.TxtPaymentDate.Name = "TxtPaymentDate"
        Me.TxtPaymentDate.Size = New System.Drawing.Size(175, 23)
        Me.TxtPaymentDate.TabIndex = 6
        Me.TxtPaymentDate.Text = ""




        '
        '   Objeto LastUpdate
        '
        Me.LbLastUpdate.AutoSize = True
        Me.LbLastUpdate.BackColor = System.Drawing.Color.Blue
        Me.LbLastUpdate.ForeColor = System.Drawing.Color.Yellow
        Me.LbLastUpdate.Location = New System.Drawing.Point(30, 175)
        Me.LbLastUpdate.Name = "TxtLastUpdate"
        Me.LbLastUpdate.Size = New System.Drawing.Size(175, 23)
        Me.LbLastUpdate.TabIndex = 7
        Me.LbLastUpdate.Text = "LastUpdate"




        Me.TxtLastUpdate.Location = New System.Drawing.Point(150, 175)
        Me.TxtLastUpdate.Name = "TxtLastUpdate"
        Me.TxtLastUpdate.Size = New System.Drawing.Size(175, 23)
        Me.TxtLastUpdate.TabIndex = 7
        Me.TxtLastUpdate.Text = ""





        '
        'btAgregar
        '
        Me.btAgregar.Location = New System.Drawing.Point(18, 200)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btAgregar.TabIndex = 33
        Me.btAgregar.Text = "&Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '

        '
        'btLeer
        '
        Me.btLeer.Location = New System.Drawing.Point(361, 200)
        Me.btLeer.Name = "btLeer"
        Me.btLeer.Size = New System.Drawing.Size(75, 23)
        Me.btLeer.TabIndex = 38
        Me.btLeer.Text = "&Leer"
        Me.btLeer.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(199, 200)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btEliminar.TabIndex = 36
        Me.btEliminar.Text = "&Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(118, 200)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 35
        Me.btActualizar.Text = "A&ctualizar"
        Me.btActualizar.UseVisualStyleBackColor = True




        '
        'btListar
        '
        Me.btListar.Location = New System.Drawing.Point(18, 225)
        Me.btListar.Name = "btListar"
        Me.btListar.Size = New System.Drawing.Size(75, 23)
        Me.btListar.TabIndex = 34
        Me.btListar.Text = "L&istar"
        Me.btListar.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(118, 225)
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



    Friend WithEvents LbPaymentId As Label
    Friend WithEvents TxtPaymentId As TextBox
    Friend WithEvents LbCustomerId As Label
    Friend WithEvents txtCustomerId As TextBox
    Friend WithEvents LbStaffId As Label
    Friend WithEvents txtStaffId As TextBox
    Friend WithEvents LbRentalId As Label
    Friend WithEvents txtRentalId As TextBox
    Friend WithEvents LbAmount As Label
    Friend WithEvents TxtAmount As TextBox
    Friend WithEvents LbPaymentDate As Label
    Friend WithEvents TxtPaymentDate As TextBox
    Friend WithEvents LbLastUpdate As Label
    Friend WithEvents TxtLastUpdate As TextBox
End Class
