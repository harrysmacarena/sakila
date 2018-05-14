<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStaffDgv
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
        Me.btSalir = New System.Windows.Forms.Button()
        Me.pnPrincipal = New System.Windows.Forms.Panel()
        Me.btListar = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()

Me.ColDgvStaffId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvAddressId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvPicture = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvStoreId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvLastUpdate = New System.Windows.Forms.DataGridViewTextBoxColumn()


        Me.pnPrincipal.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(180, 10)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(75, 23)
        Me.btSalir.TabIndex = 37
        Me.btSalir.Text = "&Cerrar"
        Me.btSalir.UseVisualStyleBackColor = True


        '
        'btListar
        '
        Me.btListar.Location = New System.Drawing.Point(18, 10)
        Me.btListar.Name = "btListar"
        Me.btListar.Size = New System.Drawing.Size(75, 23)
        Me.btListar.TabIndex = 34
        Me.btListar.Text = "L&istar"
        Me.btListar.UseVisualStyleBackColor = True

        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
              Me.ColDgvStaffId _
,              Me.ColDgvFirstName _
,              Me.ColDgvLastName _
,              Me.ColDgvAddressId _
,              Me.ColDgvPicture _
,              Me.ColDgvEmail _
,              Me.ColDgvStoreId _
,              Me.ColDgvActive _
,              Me.ColDgvUsername _
,              Me.ColDgvPassword _
,              Me.ColDgvLastUpdate _
        })        
        Me.dgvData.Location = New System.Drawing.Point(32, 33)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(800, 450)
        Me.dgvData.TabIndex = 0

        '
        '   Column StaffId
        '
        Me.ColDgvStaffId.HeaderText = "Título StaffId"
        Me.ColDgvStaffId.Name = "ColStaffId"
        Me.ColDgvStaffId.DataPropertyName = "staff_id"

        '
        '   Column FirstName
        '
        Me.ColDgvFirstName.HeaderText = "Título FirstName"
        Me.ColDgvFirstName.Name = "ColFirstName"
        Me.ColDgvFirstName.DataPropertyName = "first_name"

        '
        '   Column LastName
        '
        Me.ColDgvLastName.HeaderText = "Título LastName"
        Me.ColDgvLastName.Name = "ColLastName"
        Me.ColDgvLastName.DataPropertyName = "last_name"

        '
        '   Column AddressId
        '
        Me.ColDgvAddressId.HeaderText = "Título AddressId"
        Me.ColDgvAddressId.Name = "ColAddressId"
        Me.ColDgvAddressId.DataPropertyName = "address_id"

        '
        '   Column Picture
        '
        Me.ColDgvPicture.HeaderText = "Título Picture"
        Me.ColDgvPicture.Name = "ColPicture"
        Me.ColDgvPicture.DataPropertyName = "picture"

        '
        '   Column Email
        '
        Me.ColDgvEmail.HeaderText = "Título Email"
        Me.ColDgvEmail.Name = "ColEmail"
        Me.ColDgvEmail.DataPropertyName = "email"

        '
        '   Column StoreId
        '
        Me.ColDgvStoreId.HeaderText = "Título StoreId"
        Me.ColDgvStoreId.Name = "ColStoreId"
        Me.ColDgvStoreId.DataPropertyName = "store_id"

        '
        '   Column Active
        '
        Me.ColDgvActive.HeaderText = "Título Active"
        Me.ColDgvActive.Name = "ColActive"
        Me.ColDgvActive.DataPropertyName = "active"

        '
        '   Column Username
        '
        Me.ColDgvUsername.HeaderText = "Título Username"
        Me.ColDgvUsername.Name = "ColUsername"
        Me.ColDgvUsername.DataPropertyName = "username"

        '
        '   Column Password
        '
        Me.ColDgvPassword.HeaderText = "Título Password"
        Me.ColDgvPassword.Name = "ColPassword"
        Me.ColDgvPassword.DataPropertyName = "password"

        '
        '   Column LastUpdate
        '
        Me.ColDgvLastUpdate.HeaderText = "Título LastUpdate"
        Me.ColDgvLastUpdate.Name = "ColLastUpdate"
        Me.ColDgvLastUpdate.DataPropertyName = "last_update"



        '
        'pnPrincipal
        '
        Me.pnPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnPrincipal.Controls.Add(Me.btListar)
        Me.pnPrincipal.Controls.Add(Me.dgvData)
        Me.pnPrincipal.Controls.Add(Me.btSalir)
        Me.pnPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.pnPrincipal.Name = "pnPrincipal"
        Me.pnPrincipal.Size = New System.Drawing.Size(900, 413)
        Me.pnPrincipal.TabIndex = 21


        '
        'FrmStaffDgv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.pnPrincipal)
        Me.Name = "FrmStaffDgv"
        Me.Text = "Lista de Staff"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
        Friend WithEvents btSalir As Button
        Friend WithEvents dgvData As DataGridView
        Friend WithEvents btListar As Button
        Friend WithEvents pnPrincipal As Panel

Friend WithEvents ColDgvStaffId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvFirstName As DataGridViewTextBoxColumn
Friend WithEvents ColDgvLastName As DataGridViewTextBoxColumn
Friend WithEvents ColDgvAddressId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvPicture As DataGridViewTextBoxColumn
Friend WithEvents ColDgvEmail As DataGridViewTextBoxColumn
Friend WithEvents ColDgvStoreId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvActive As DataGridViewTextBoxColumn
Friend WithEvents ColDgvUsername As DataGridViewTextBoxColumn
Friend WithEvents ColDgvPassword As DataGridViewTextBoxColumn
Friend WithEvents ColDgvLastUpdate As DataGridViewTextBoxColumn

End Class
