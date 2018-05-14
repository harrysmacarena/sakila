<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarcaDgv
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

Me.ColDgvId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()


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
              Me.ColDgvId _
,              Me.ColDgvNombre _
        })        
        Me.dgvData.Location = New System.Drawing.Point(32, 33)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(800, 450)
        Me.dgvData.TabIndex = 0

        '
        '   Column Id
        '
        Me.ColDgvId.HeaderText = "Título Id"
        Me.ColDgvId.Name = "ColId"
        Me.ColDgvId.DataPropertyName = "Id"

        '
        '   Column Nombre
        '
        Me.ColDgvNombre.HeaderText = "Título Nombre"
        Me.ColDgvNombre.Name = "ColNombre"
        Me.ColDgvNombre.DataPropertyName = "nombre"



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
        'FrmMarcaDgv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.pnPrincipal)
        Me.Name = "FrmMarcaDgv"
        Me.Text = "Lista de Marca"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
        Friend WithEvents btSalir As Button
        Friend WithEvents dgvData As DataGridView
        Friend WithEvents btListar As Button
        Friend WithEvents pnPrincipal As Panel

Friend WithEvents ColDgvId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvNombre As DataGridViewTextBoxColumn

End Class
