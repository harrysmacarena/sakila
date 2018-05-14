<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomerDgv
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

Me.ColDgvCustomerId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvStoreId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvAddressId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvCreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
              Me.ColDgvCustomerId _
,              Me.ColDgvStoreId _
,              Me.ColDgvFirstName _
,              Me.ColDgvLastName _
,              Me.ColDgvEmail _
,              Me.ColDgvAddressId _
,              Me.ColDgvActive _
,              Me.ColDgvCreateDate _
,              Me.ColDgvLastUpdate _
        })        
        Me.dgvData.Location = New System.Drawing.Point(32, 33)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(800, 450)
        Me.dgvData.TabIndex = 0

        '
        '   Column CustomerId
        '
        Me.ColDgvCustomerId.HeaderText = "Título CustomerId"
        Me.ColDgvCustomerId.Name = "ColCustomerId"
        Me.ColDgvCustomerId.DataPropertyName = "customer_id"

        '
        '   Column StoreId
        '
        Me.ColDgvStoreId.HeaderText = "Título StoreId"
        Me.ColDgvStoreId.Name = "ColStoreId"
        Me.ColDgvStoreId.DataPropertyName = "store_id"

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
        '   Column Email
        '
        Me.ColDgvEmail.HeaderText = "Título Email"
        Me.ColDgvEmail.Name = "ColEmail"
        Me.ColDgvEmail.DataPropertyName = "email"

        '
        '   Column AddressId
        '
        Me.ColDgvAddressId.HeaderText = "Título AddressId"
        Me.ColDgvAddressId.Name = "ColAddressId"
        Me.ColDgvAddressId.DataPropertyName = "address_id"

        '
        '   Column Active
        '
        Me.ColDgvActive.HeaderText = "Título Active"
        Me.ColDgvActive.Name = "ColActive"
        Me.ColDgvActive.DataPropertyName = "active"

        '
        '   Column CreateDate
        '
        Me.ColDgvCreateDate.HeaderText = "Título CreateDate"
        Me.ColDgvCreateDate.Name = "ColCreateDate"
        Me.ColDgvCreateDate.DataPropertyName = "create_date"

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
        'FrmCustomerDgv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.pnPrincipal)
        Me.Name = "FrmCustomerDgv"
        Me.Text = "Lista de Customer"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
        Friend WithEvents btSalir As Button
        Friend WithEvents dgvData As DataGridView
        Friend WithEvents btListar As Button
        Friend WithEvents pnPrincipal As Panel

Friend WithEvents ColDgvCustomerId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvStoreId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvFirstName As DataGridViewTextBoxColumn
Friend WithEvents ColDgvLastName As DataGridViewTextBoxColumn
Friend WithEvents ColDgvEmail As DataGridViewTextBoxColumn
Friend WithEvents ColDgvAddressId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvActive As DataGridViewTextBoxColumn
Friend WithEvents ColDgvCreateDate As DataGridViewTextBoxColumn
Friend WithEvents ColDgvLastUpdate As DataGridViewTextBoxColumn

End Class
