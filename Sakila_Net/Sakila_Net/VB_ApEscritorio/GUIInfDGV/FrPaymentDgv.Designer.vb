<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaymentDgv
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

Me.ColDgvPaymentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvCustomerId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvStaffId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvRentalId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvPaymentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
              Me.ColDgvPaymentId _
,              Me.ColDgvCustomerId _
,              Me.ColDgvStaffId _
,              Me.ColDgvRentalId _
,              Me.ColDgvAmount _
,              Me.ColDgvPaymentDate _
,              Me.ColDgvLastUpdate _
        })        
        Me.dgvData.Location = New System.Drawing.Point(32, 33)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(800, 450)
        Me.dgvData.TabIndex = 0

        '
        '   Column PaymentId
        '
        Me.ColDgvPaymentId.HeaderText = "Título PaymentId"
        Me.ColDgvPaymentId.Name = "ColPaymentId"
        Me.ColDgvPaymentId.DataPropertyName = "payment_id"

        '
        '   Column CustomerId
        '
        Me.ColDgvCustomerId.HeaderText = "Título CustomerId"
        Me.ColDgvCustomerId.Name = "ColCustomerId"
        Me.ColDgvCustomerId.DataPropertyName = "customer_id"

        '
        '   Column StaffId
        '
        Me.ColDgvStaffId.HeaderText = "Título StaffId"
        Me.ColDgvStaffId.Name = "ColStaffId"
        Me.ColDgvStaffId.DataPropertyName = "staff_id"

        '
        '   Column RentalId
        '
        Me.ColDgvRentalId.HeaderText = "Título RentalId"
        Me.ColDgvRentalId.Name = "ColRentalId"
        Me.ColDgvRentalId.DataPropertyName = "rental_id"

        '
        '   Column Amount
        '
        Me.ColDgvAmount.HeaderText = "Título Amount"
        Me.ColDgvAmount.Name = "ColAmount"
        Me.ColDgvAmount.DataPropertyName = "amount"

        '
        '   Column PaymentDate
        '
        Me.ColDgvPaymentDate.HeaderText = "Título PaymentDate"
        Me.ColDgvPaymentDate.Name = "ColPaymentDate"
        Me.ColDgvPaymentDate.DataPropertyName = "payment_date"

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
        'FrmPaymentDgv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.pnPrincipal)
        Me.Name = "FrmPaymentDgv"
        Me.Text = "Lista de Payment"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
        Friend WithEvents btSalir As Button
        Friend WithEvents dgvData As DataGridView
        Friend WithEvents btListar As Button
        Friend WithEvents pnPrincipal As Panel

Friend WithEvents ColDgvPaymentId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvCustomerId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvStaffId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvRentalId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvAmount As DataGridViewTextBoxColumn
Friend WithEvents ColDgvPaymentDate As DataGridViewTextBoxColumn
Friend WithEvents ColDgvLastUpdate As DataGridViewTextBoxColumn

End Class
