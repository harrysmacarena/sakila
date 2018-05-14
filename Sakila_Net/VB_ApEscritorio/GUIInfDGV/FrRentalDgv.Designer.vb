<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRentalDgv
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

Me.ColDgvRentalId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvRentalDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvInventoryId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvCustomerId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvReturnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvStaffId = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
              Me.ColDgvRentalId _
,              Me.ColDgvRentalDate _
,              Me.ColDgvInventoryId _
,              Me.ColDgvCustomerId _
,              Me.ColDgvReturnDate _
,              Me.ColDgvStaffId _
,              Me.ColDgvLastUpdate _
        })        
        Me.dgvData.Location = New System.Drawing.Point(32, 33)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(800, 450)
        Me.dgvData.TabIndex = 0

        '
        '   Column RentalId
        '
        Me.ColDgvRentalId.HeaderText = "Título RentalId"
        Me.ColDgvRentalId.Name = "ColRentalId"
        Me.ColDgvRentalId.DataPropertyName = "rental_id"

        '
        '   Column RentalDate
        '
        Me.ColDgvRentalDate.HeaderText = "Título RentalDate"
        Me.ColDgvRentalDate.Name = "ColRentalDate"
        Me.ColDgvRentalDate.DataPropertyName = "rental_date"

        '
        '   Column InventoryId
        '
        Me.ColDgvInventoryId.HeaderText = "Título InventoryId"
        Me.ColDgvInventoryId.Name = "ColInventoryId"
        Me.ColDgvInventoryId.DataPropertyName = "inventory_id"

        '
        '   Column CustomerId
        '
        Me.ColDgvCustomerId.HeaderText = "Título CustomerId"
        Me.ColDgvCustomerId.Name = "ColCustomerId"
        Me.ColDgvCustomerId.DataPropertyName = "customer_id"

        '
        '   Column ReturnDate
        '
        Me.ColDgvReturnDate.HeaderText = "Título ReturnDate"
        Me.ColDgvReturnDate.Name = "ColReturnDate"
        Me.ColDgvReturnDate.DataPropertyName = "return_date"

        '
        '   Column StaffId
        '
        Me.ColDgvStaffId.HeaderText = "Título StaffId"
        Me.ColDgvStaffId.Name = "ColStaffId"
        Me.ColDgvStaffId.DataPropertyName = "staff_id"

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
        'FrmRentalDgv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.pnPrincipal)
        Me.Name = "FrmRentalDgv"
        Me.Text = "Lista de Rental"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
        Friend WithEvents btSalir As Button
        Friend WithEvents dgvData As DataGridView
        Friend WithEvents btListar As Button
        Friend WithEvents pnPrincipal As Panel

Friend WithEvents ColDgvRentalId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvRentalDate As DataGridViewTextBoxColumn
Friend WithEvents ColDgvInventoryId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvCustomerId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvReturnDate As DataGridViewTextBoxColumn
Friend WithEvents ColDgvStaffId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvLastUpdate As DataGridViewTextBoxColumn

End Class
