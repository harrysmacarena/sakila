<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFilmDgv
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

Me.ColDgvFilmId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvReleaseYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvLanguageId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvOriginalLanguageId = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvRentalDuration = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvRentalRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvReplacementCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvRating = New System.Windows.Forms.DataGridViewTextBoxColumn()
Me.ColDgvSpecialFeatures = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
              Me.ColDgvFilmId _
,              Me.ColDgvTitle _
,              Me.ColDgvDescription _
,              Me.ColDgvReleaseYear _
,              Me.ColDgvLanguageId _
,              Me.ColDgvOriginalLanguageId _
,              Me.ColDgvRentalDuration _
,              Me.ColDgvRentalRate _
,              Me.ColDgvLength _
,              Me.ColDgvReplacementCost _
,              Me.ColDgvRating _
,              Me.ColDgvSpecialFeatures _
,              Me.ColDgvLastUpdate _
        })        
        Me.dgvData.Location = New System.Drawing.Point(32, 33)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(800, 450)
        Me.dgvData.TabIndex = 0

        '
        '   Column FilmId
        '
        Me.ColDgvFilmId.HeaderText = "Título FilmId"
        Me.ColDgvFilmId.Name = "ColFilmId"
        Me.ColDgvFilmId.DataPropertyName = "film_id"

        '
        '   Column Title
        '
        Me.ColDgvTitle.HeaderText = "Título Title"
        Me.ColDgvTitle.Name = "ColTitle"
        Me.ColDgvTitle.DataPropertyName = "title"

        '
        '   Column Description
        '
        Me.ColDgvDescription.HeaderText = "Título Description"
        Me.ColDgvDescription.Name = "ColDescription"
        Me.ColDgvDescription.DataPropertyName = "description"

        '
        '   Column ReleaseYear
        '
        Me.ColDgvReleaseYear.HeaderText = "Título ReleaseYear"
        Me.ColDgvReleaseYear.Name = "ColReleaseYear"
        Me.ColDgvReleaseYear.DataPropertyName = "release_year"

        '
        '   Column LanguageId
        '
        Me.ColDgvLanguageId.HeaderText = "Título LanguageId"
        Me.ColDgvLanguageId.Name = "ColLanguageId"
        Me.ColDgvLanguageId.DataPropertyName = "language_id"

        '
        '   Column OriginalLanguageId
        '
        Me.ColDgvOriginalLanguageId.HeaderText = "Título OriginalLanguageId"
        Me.ColDgvOriginalLanguageId.Name = "ColOriginalLanguageId"
        Me.ColDgvOriginalLanguageId.DataPropertyName = "original_language_id"

        '
        '   Column RentalDuration
        '
        Me.ColDgvRentalDuration.HeaderText = "Título RentalDuration"
        Me.ColDgvRentalDuration.Name = "ColRentalDuration"
        Me.ColDgvRentalDuration.DataPropertyName = "rental_duration"

        '
        '   Column RentalRate
        '
        Me.ColDgvRentalRate.HeaderText = "Título RentalRate"
        Me.ColDgvRentalRate.Name = "ColRentalRate"
        Me.ColDgvRentalRate.DataPropertyName = "rental_rate"

        '
        '   Column Length
        '
        Me.ColDgvLength.HeaderText = "Título Length"
        Me.ColDgvLength.Name = "ColLength"
        Me.ColDgvLength.DataPropertyName = "length"

        '
        '   Column ReplacementCost
        '
        Me.ColDgvReplacementCost.HeaderText = "Título ReplacementCost"
        Me.ColDgvReplacementCost.Name = "ColReplacementCost"
        Me.ColDgvReplacementCost.DataPropertyName = "replacement_cost"

        '
        '   Column Rating
        '
        Me.ColDgvRating.HeaderText = "Título Rating"
        Me.ColDgvRating.Name = "ColRating"
        Me.ColDgvRating.DataPropertyName = "rating"

        '
        '   Column SpecialFeatures
        '
        Me.ColDgvSpecialFeatures.HeaderText = "Título SpecialFeatures"
        Me.ColDgvSpecialFeatures.Name = "ColSpecialFeatures"
        Me.ColDgvSpecialFeatures.DataPropertyName = "special_features"

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
        'FrmFilmDgv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.pnPrincipal)
        Me.Name = "FrmFilmDgv"
        Me.Text = "Lista de Film"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
        Friend WithEvents btSalir As Button
        Friend WithEvents dgvData As DataGridView
        Friend WithEvents btListar As Button
        Friend WithEvents pnPrincipal As Panel

Friend WithEvents ColDgvFilmId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvTitle As DataGridViewTextBoxColumn
Friend WithEvents ColDgvDescription As DataGridViewTextBoxColumn
Friend WithEvents ColDgvReleaseYear As DataGridViewTextBoxColumn
Friend WithEvents ColDgvLanguageId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvOriginalLanguageId As DataGridViewTextBoxColumn
Friend WithEvents ColDgvRentalDuration As DataGridViewTextBoxColumn
Friend WithEvents ColDgvRentalRate As DataGridViewTextBoxColumn
Friend WithEvents ColDgvLength As DataGridViewTextBoxColumn
Friend WithEvents ColDgvReplacementCost As DataGridViewTextBoxColumn
Friend WithEvents ColDgvRating As DataGridViewTextBoxColumn
Friend WithEvents ColDgvSpecialFeatures As DataGridViewTextBoxColumn
Friend WithEvents ColDgvLastUpdate As DataGridViewTextBoxColumn

End Class
