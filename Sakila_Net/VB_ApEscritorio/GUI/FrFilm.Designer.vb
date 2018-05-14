<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFilm
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

        Me.LbFilmId = New System.Windows.Forms.Label()
        Me.TxtFilmId = New System.Windows.Forms.TextBox()
        Me.LbTitle = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.LbDescription = New System.Windows.Forms.Label()
       Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.LbReleaseYear = New System.Windows.Forms.Label()
        Me.TxtReleaseYear = New System.Windows.Forms.TextBox()
        Me.LbLanguageId = New System.Windows.Forms.Label()
        Me.txtLanguageId = New System.Windows.Forms.TextBox()
        Me.LbOriginalLanguageId = New System.Windows.Forms.Label()
        Me.TxtOriginalLanguageId = New System.Windows.Forms.TextBox()
        Me.LbRentalDuration = New System.Windows.Forms.Label()
        Me.TxtRentalDuration = New System.Windows.Forms.TextBox()
        Me.LbRentalRate = New System.Windows.Forms.Label()
        Me.TxtRentalRate = New System.Windows.Forms.TextBox()
        Me.LbLength = New System.Windows.Forms.Label()
        Me.TxtLength = New System.Windows.Forms.TextBox()
        Me.LbReplacementCost = New System.Windows.Forms.Label()
        Me.TxtReplacementCost = New System.Windows.Forms.TextBox()
        Me.LbRating = New System.Windows.Forms.Label()
        Me.TxtRating = New System.Windows.Forms.TextBox()
        Me.LbSpecialFeatures = New System.Windows.Forms.Label()
        Me.TxtSpecialFeatures = New System.Windows.Forms.TextBox()
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

        Me.pnPrincipal.Controls.Add(Me.LbFilmId)
        Me.pnPrincipal.Controls.Add(Me.TxtFilmId)
        Me.pnPrincipal.Controls.Add(Me.LbTitle)
        Me.pnPrincipal.Controls.Add(Me.TxtTitle)
        Me.pnPrincipal.Controls.Add(Me.LbDescription)
       Me.pnPrincipal.Controls.Add(Me.TxtDescription)
        Me.pnPrincipal.Controls.Add(Me.LbReleaseYear)
        Me.pnPrincipal.Controls.Add(Me.TxtReleaseYear)
        Me.pnPrincipal.Controls.Add(Me.LbLanguageId)
        Me.pnPrincipal.Controls.Add(Me.TxtLanguageId)
        Me.pnPrincipal.Controls.Add(Me.LbOriginalLanguageId)
        Me.pnPrincipal.Controls.Add(Me.TxtOriginalLanguageId)
        Me.pnPrincipal.Controls.Add(Me.LbRentalDuration)
        Me.pnPrincipal.Controls.Add(Me.TxtRentalDuration)
        Me.pnPrincipal.Controls.Add(Me.LbRentalRate)
        Me.pnPrincipal.Controls.Add(Me.TxtRentalRate)
        Me.pnPrincipal.Controls.Add(Me.LbLength)
        Me.pnPrincipal.Controls.Add(Me.TxtLength)
        Me.pnPrincipal.Controls.Add(Me.LbReplacementCost)
        Me.pnPrincipal.Controls.Add(Me.TxtReplacementCost)
        Me.pnPrincipal.Controls.Add(Me.LbRating)
        Me.pnPrincipal.Controls.Add(Me.TxtRating)
        Me.pnPrincipal.Controls.Add(Me.LbSpecialFeatures)
        Me.pnPrincipal.Controls.Add(Me.TxtSpecialFeatures)
        Me.pnPrincipal.Controls.Add(Me.LbLastUpdate)
        Me.pnPrincipal.Controls.Add(Me.TxtLastUpdate)






        Me.pnPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnPrincipal.Location = New System.Drawing.Point(22, 12)
        Me.pnPrincipal.Name = "pnPrincipal"
        Me.pnPrincipal.Size = New System.Drawing.Size(519, 450)
        Me.pnPrincipal.TabIndex = 20

        '
        '   Objeto FilmId
        '
        Me.LbFilmId.AutoSize = True
        Me.LbFilmId.BackColor = System.Drawing.Color.Blue
        Me.LbFilmId.ForeColor = System.Drawing.Color.Yellow
        Me.LbFilmId.Location = New System.Drawing.Point(30, 25)
        Me.LbFilmId.Name = "TxtFilmId"
        Me.LbFilmId.Size = New System.Drawing.Size(175, 23)
        Me.LbFilmId.TabIndex = 1
        Me.LbFilmId.Text = "FilmId"


        Me.TxtFilmId.Location = New System.Drawing.Point(150, 25)
        Me.TxtFilmId.Name = "TxtFilmId"
        Me.TxtFilmId.Size = New System.Drawing.Size(175, 23)
        Me.TxtFilmId.TabIndex = 1
        Me.TxtFilmId.Text = ""






        '
        '   Objeto Title
        '
        Me.LbTitle.AutoSize = True
        Me.LbTitle.BackColor = System.Drawing.Color.Blue
        Me.LbTitle.ForeColor = System.Drawing.Color.Yellow
        Me.LbTitle.Location = New System.Drawing.Point(30, 50)
        Me.LbTitle.Name = "TxtTitle"
        Me.LbTitle.Size = New System.Drawing.Size(175, 23)
        Me.LbTitle.TabIndex = 2
        Me.LbTitle.Text = "Title"



        Me.TxtTitle.Location = New System.Drawing.Point(150, 50)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(175, 23)
        Me.TxtTitle.TabIndex = 2
        Me.TxtTitle.Text = ""





        '
        '   Objeto Description
        '
        Me.LbDescription.AutoSize = True
        Me.LbDescription.BackColor = System.Drawing.Color.Blue
        Me.LbDescription.ForeColor = System.Drawing.Color.Yellow
        Me.LbDescription.Location = New System.Drawing.Point(30, 75)
        Me.LbDescription.Name = "TxtDescription"
        Me.LbDescription.Size = New System.Drawing.Size(175, 23)
        Me.LbDescription.TabIndex = 3
        Me.LbDescription.Text = "Description"







        Me.TxtDescription.Location = New System.Drawing.Point(150, 75)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(175, 23)
        Me.TxtDescription.TabIndex = 3
        Me.TxtDescription.Text = ""

        '
        '   Objeto ReleaseYear
        '
        Me.LbReleaseYear.AutoSize = True
        Me.LbReleaseYear.BackColor = System.Drawing.Color.Blue
        Me.LbReleaseYear.ForeColor = System.Drawing.Color.Yellow
        Me.LbReleaseYear.Location = New System.Drawing.Point(30, 100)
        Me.LbReleaseYear.Name = "TxtReleaseYear"
        Me.LbReleaseYear.Size = New System.Drawing.Size(175, 23)
        Me.LbReleaseYear.TabIndex = 4
        Me.LbReleaseYear.Text = "ReleaseYear"


        Me.TxtReleaseYear.Location = New System.Drawing.Point(150, 100)
        Me.TxtReleaseYear.Name = "TxtReleaseYear"
        Me.TxtReleaseYear.Size = New System.Drawing.Size(175, 23)
        Me.TxtReleaseYear.TabIndex = 4
        Me.TxtReleaseYear.Text = ""






        '
        '   Objeto LanguageId
        '
        Me.LbLanguageId.AutoSize = True
        Me.LbLanguageId.BackColor = System.Drawing.Color.Blue
        Me.LbLanguageId.ForeColor = System.Drawing.Color.Yellow
        Me.LbLanguageId.Location = New System.Drawing.Point(30, 125)
        Me.LbLanguageId.Name = "TxtLanguageId"
        Me.LbLanguageId.Size = New System.Drawing.Size(175, 23)
        Me.LbLanguageId.TabIndex = 5
        Me.LbLanguageId.Text = "LanguageId"








        Me.TxtLanguageId.Location = New System.Drawing.Point(150, 125)
        Me.TxtLanguageId.Name = "TxtLanguageId"
        Me.TxtLanguageId.Size = New System.Drawing.Size(175, 23)
        Me.TxtLanguageId.TabIndex = 5
        Me.TxtLanguageId.Text = ""
        '
        '   Objeto OriginalLanguageId
        '
        Me.LbOriginalLanguageId.AutoSize = True
        Me.LbOriginalLanguageId.BackColor = System.Drawing.Color.Blue
        Me.LbOriginalLanguageId.ForeColor = System.Drawing.Color.Yellow
        Me.LbOriginalLanguageId.Location = New System.Drawing.Point(30, 150)
        Me.LbOriginalLanguageId.Name = "TxtOriginalLanguageId"
        Me.LbOriginalLanguageId.Size = New System.Drawing.Size(175, 23)
        Me.LbOriginalLanguageId.TabIndex = 6
        Me.LbOriginalLanguageId.Text = "OriginalLanguageId"


        Me.TxtOriginalLanguageId.Location = New System.Drawing.Point(150, 150)
        Me.TxtOriginalLanguageId.Name = "TxtOriginalLanguageId"
        Me.TxtOriginalLanguageId.Size = New System.Drawing.Size(175, 23)
        Me.TxtOriginalLanguageId.TabIndex = 6
        Me.TxtOriginalLanguageId.Text = ""






        '
        '   Objeto RentalDuration
        '
        Me.LbRentalDuration.AutoSize = True
        Me.LbRentalDuration.BackColor = System.Drawing.Color.Blue
        Me.LbRentalDuration.ForeColor = System.Drawing.Color.Yellow
        Me.LbRentalDuration.Location = New System.Drawing.Point(30, 175)
        Me.LbRentalDuration.Name = "TxtRentalDuration"
        Me.LbRentalDuration.Size = New System.Drawing.Size(175, 23)
        Me.LbRentalDuration.TabIndex = 7
        Me.LbRentalDuration.Text = "RentalDuration"


        Me.TxtRentalDuration.Location = New System.Drawing.Point(150, 175)
        Me.TxtRentalDuration.Name = "TxtRentalDuration"
        Me.TxtRentalDuration.Size = New System.Drawing.Size(175, 23)
        Me.TxtRentalDuration.TabIndex = 7
        Me.TxtRentalDuration.Text = ""






        '
        '   Objeto RentalRate
        '
        Me.LbRentalRate.AutoSize = True
        Me.LbRentalRate.BackColor = System.Drawing.Color.Blue
        Me.LbRentalRate.ForeColor = System.Drawing.Color.Yellow
        Me.LbRentalRate.Location = New System.Drawing.Point(30, 200)
        Me.LbRentalRate.Name = "TxtRentalRate"
        Me.LbRentalRate.Size = New System.Drawing.Size(175, 23)
        Me.LbRentalRate.TabIndex = 8
        Me.LbRentalRate.Text = "RentalRate"

        Me.TxtRentalRate.Location = New System.Drawing.Point(150, 200)
        Me.TxtRentalRate.Name = "TxtRentalRate"
        Me.TxtRentalRate.Size = New System.Drawing.Size(175, 23)
        Me.TxtRentalRate.TabIndex = 8
        Me.TxtRentalRate.Text = ""







        '
        '   Objeto Length
        '
        Me.LbLength.AutoSize = True
        Me.LbLength.BackColor = System.Drawing.Color.Blue
        Me.LbLength.ForeColor = System.Drawing.Color.Yellow
        Me.LbLength.Location = New System.Drawing.Point(30, 225)
        Me.LbLength.Name = "TxtLength"
        Me.LbLength.Size = New System.Drawing.Size(175, 23)
        Me.LbLength.TabIndex = 9
        Me.LbLength.Text = "Length"


        Me.TxtLength.Location = New System.Drawing.Point(150, 225)
        Me.TxtLength.Name = "TxtLength"
        Me.TxtLength.Size = New System.Drawing.Size(175, 23)
        Me.TxtLength.TabIndex = 9
        Me.TxtLength.Text = ""






        '
        '   Objeto ReplacementCost
        '
        Me.LbReplacementCost.AutoSize = True
        Me.LbReplacementCost.BackColor = System.Drawing.Color.Blue
        Me.LbReplacementCost.ForeColor = System.Drawing.Color.Yellow
        Me.LbReplacementCost.Location = New System.Drawing.Point(30, 250)
        Me.LbReplacementCost.Name = "TxtReplacementCost"
        Me.LbReplacementCost.Size = New System.Drawing.Size(175, 23)
        Me.LbReplacementCost.TabIndex = 10
        Me.LbReplacementCost.Text = "ReplacementCost"

        Me.TxtReplacementCost.Location = New System.Drawing.Point(150, 250)
        Me.TxtReplacementCost.Name = "TxtReplacementCost"
        Me.TxtReplacementCost.Size = New System.Drawing.Size(175, 23)
        Me.TxtReplacementCost.TabIndex = 10
        Me.TxtReplacementCost.Text = ""







        '
        '   Objeto Rating
        '
        Me.LbRating.AutoSize = True
        Me.LbRating.BackColor = System.Drawing.Color.Blue
        Me.LbRating.ForeColor = System.Drawing.Color.Yellow
        Me.LbRating.Location = New System.Drawing.Point(30, 275)
        Me.LbRating.Name = "TxtRating"
        Me.LbRating.Size = New System.Drawing.Size(175, 23)
        Me.LbRating.TabIndex = 11
        Me.LbRating.Text = "Rating"



        Me.TxtRating.Location = New System.Drawing.Point(150, 275)
        Me.TxtRating.Name = "TxtRating"
        Me.TxtRating.Size = New System.Drawing.Size(175, 23)
        Me.TxtRating.TabIndex = 11
        Me.TxtRating.Text = ""





        '
        '   Objeto SpecialFeatures
        '
        Me.LbSpecialFeatures.AutoSize = True
        Me.LbSpecialFeatures.BackColor = System.Drawing.Color.Blue
        Me.LbSpecialFeatures.ForeColor = System.Drawing.Color.Yellow
        Me.LbSpecialFeatures.Location = New System.Drawing.Point(30, 300)
        Me.LbSpecialFeatures.Name = "TxtSpecialFeatures"
        Me.LbSpecialFeatures.Size = New System.Drawing.Size(175, 23)
        Me.LbSpecialFeatures.TabIndex = 12
        Me.LbSpecialFeatures.Text = "SpecialFeatures"



        Me.TxtSpecialFeatures.Location = New System.Drawing.Point(150, 300)
        Me.TxtSpecialFeatures.Name = "TxtSpecialFeatures"
        Me.TxtSpecialFeatures.Size = New System.Drawing.Size(175, 23)
        Me.TxtSpecialFeatures.TabIndex = 12
        Me.TxtSpecialFeatures.Text = ""





        '
        '   Objeto LastUpdate
        '
        Me.LbLastUpdate.AutoSize = True
        Me.LbLastUpdate.BackColor = System.Drawing.Color.Blue
        Me.LbLastUpdate.ForeColor = System.Drawing.Color.Yellow
        Me.LbLastUpdate.Location = New System.Drawing.Point(30, 325)
        Me.LbLastUpdate.Name = "TxtLastUpdate"
        Me.LbLastUpdate.Size = New System.Drawing.Size(175, 23)
        Me.LbLastUpdate.TabIndex = 13
        Me.LbLastUpdate.Text = "LastUpdate"




        Me.TxtLastUpdate.Location = New System.Drawing.Point(150, 325)
        Me.TxtLastUpdate.Name = "TxtLastUpdate"
        Me.TxtLastUpdate.Size = New System.Drawing.Size(175, 23)
        Me.TxtLastUpdate.TabIndex = 13
        Me.TxtLastUpdate.Text = ""





        '
        'btAgregar
        '
        Me.btAgregar.Location = New System.Drawing.Point(18, 350)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btAgregar.TabIndex = 33
        Me.btAgregar.Text = "&Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '

        '
        'btLeer
        '
        Me.btLeer.Location = New System.Drawing.Point(361, 350)
        Me.btLeer.Name = "btLeer"
        Me.btLeer.Size = New System.Drawing.Size(75, 23)
        Me.btLeer.TabIndex = 38
        Me.btLeer.Text = "&Leer"
        Me.btLeer.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(199, 350)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btEliminar.TabIndex = 36
        Me.btEliminar.Text = "&Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(118, 350)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btActualizar.TabIndex = 35
        Me.btActualizar.Text = "A&ctualizar"
        Me.btActualizar.UseVisualStyleBackColor = True




        '
        'btListar
        '
        Me.btListar.Location = New System.Drawing.Point(18, 375)
        Me.btListar.Name = "btListar"
        Me.btListar.Size = New System.Drawing.Size(75, 23)
        Me.btListar.TabIndex = 34
        Me.btListar.Text = "L&istar"
        Me.btListar.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(118, 375)
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



    Friend WithEvents LbFilmId As Label
    Friend WithEvents TxtFilmId As TextBox
    Friend WithEvents LbTitle As Label
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents LbDescription As Label
    Friend WithEvents TxtDescription As TextBox
    Friend WithEvents LbReleaseYear As Label
    Friend WithEvents TxtReleaseYear As TextBox
    Friend WithEvents LbLanguageId As Label
    Friend WithEvents txtLanguageId As TextBox
    Friend WithEvents LbOriginalLanguageId As Label
    Friend WithEvents TxtOriginalLanguageId As TextBox
    Friend WithEvents LbRentalDuration As Label
    Friend WithEvents TxtRentalDuration As TextBox
    Friend WithEvents LbRentalRate As Label
    Friend WithEvents TxtRentalRate As TextBox
    Friend WithEvents LbLength As Label
    Friend WithEvents TxtLength As TextBox
    Friend WithEvents LbReplacementCost As Label
    Friend WithEvents TxtReplacementCost As TextBox
    Friend WithEvents LbRating As Label
    Friend WithEvents TxtRating As TextBox
    Friend WithEvents LbSpecialFeatures As Label
    Friend WithEvents TxtSpecialFeatures As TextBox
    Friend WithEvents LbLastUpdate As Label
    Friend WithEvents TxtLastUpdate As TextBox
End Class
