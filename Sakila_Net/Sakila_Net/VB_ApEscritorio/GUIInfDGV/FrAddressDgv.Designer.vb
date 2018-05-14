<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddressDgv
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

Me.ColDgvAddressId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvAddress2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvDistrict = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvCityId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvPostalCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
              Me.ColDgvAddressId _
,              Me.ColDgvAddress _
,              Me.ColDgvAddress2 _
,              Me.ColDgvDistrict _
,              Me.ColDgvCityId _
,              Me.ColDgvPostalCode _
,              Me.ColDgvPhone _
,              Me.ColDgvLastUpdate _
        })        
        Me.dgvData.Location = New System.Drawing.Point(32, 33)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(800, 450)
        Me.dgvData.TabIndex = 0

        '
        '   Column AddressId
        '
        Me.ColDgvAddressId.HeaderText = "Título AddressId"
        Me.ColDgvAddressId.Name = "ColAddressId"
        Me.ColDgvAddressId.DataPropertyName = "address_id"

        '
        '   Column Address
        '
        Me.ColDgvAddress.HeaderText = "Título Address"
        Me.ColDgvAddress.Name = "ColAddress"
        Me.ColDgvAddress.DataPropertyName = "address"

        '
        '   Column Address2
        '
        Me.ColDgvAddress2.HeaderText = "Título Address2"
        Me.ColDgvAddress2.Name = "ColAddress2"
        Me.ColDgvAddress2.DataPropertyName = "address2"

        '
        '   Column District
        '
        Me.ColDgvDistrict.HeaderText = "Título District"
        Me.ColDgvDistrict.Name = "ColDistrict"
        Me.ColDgvDistrict.DataPropertyName = "district"

        '
        '   Column CityId
        '
        Me.ColDgvCityId.HeaderText = "Título CityId"
        Me.ColDgvCityId.Name = "ColCityId"
        Me.ColDgvCityId.DataPropertyName = "city_id"

        '
        '   Column PostalCode
        '
        Me.ColDgvPostalCode.HeaderText = "Título PostalCode"
        Me.ColDgvPostalCode.Name = "ColPostalCode"
        Me.ColDgvPostalCode.DataPropertyName = "postal_code"

        '
        '   Column Phone
        '
        Me.ColDgvPhone.HeaderText = "Título Phone"
        Me.ColDgvPhone.Name = "ColPhone"
        Me.ColDgvPhone.DataPropertyName = "phone"

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
        'FrmAddressDgv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.pnPrincipal)
        Me.Name = "FrmAddressDgv"
        Me.Text = "Lista de Address"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
        Friend WithEvents btSalir As Button
        Friend WithEvents dgvData As DataGridView
        Friend WithEvents btListar As Button
        Friend WithEvents pnPrincipal As Panel

Friend WithEvents ColDgvAddressId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvAddress As DataGridViewTextBoxColumn
Friend WithEvents ColDgvAddress2 As DataGridViewTextBoxColumn
Friend WithEvents ColDgvDistrict As DataGridViewTextBoxColumn
Friend WithEvents ColDgvCityId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvPostalCode As DataGridViewTextBoxColumn
Friend WithEvents ColDgvPhone As DataGridViewTextBoxColumn
Friend WithEvents ColDgvLastUpdate As DataGridViewTextBoxColumn

End Class
