Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebFilm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Film")
        Dim film as ClFilm = New ClFilm(Integer.Parse(TxtFilmId.Text))
        If (ClNegFilm.eliminar(film)) Then
            'MessageBox.Show("Error al Eliminar Registro", "Film")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "Film")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Film")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim film as ClFilm = New ClFilm(Integer.Parse(TxtFilmId.Text),TxtTitle.Text,TxtDescription.Text,Integer.Parse(TxtReleaseYear.Text), New ClLanguage(Integer.Parse(ddlanguageId.SelectedValue.ToString())),Integer.Parse(TxtOriginalLanguageId.Text),Integer.Parse(TxtRentalDuration.Text),Integer.Parse(TxtRentalRate.Text),Integer.Parse(TxtLength.Text),Integer.Parse(TxtReplacementCost.Text),TxtRating.Text,TxtSpecialFeatures.Text,cldLastUpdate.SelectedDate.ToShortDateString())
        If (ClNegFilm.actualizar(film)) Then
            'MessageBox.Show("Error al Actualizar Registro", "Film")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "Film")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Film")
        Dim film as ClFilm = New ClFilm(Integer.Parse(TxtFilmId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegFilm.consultar(film)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            TxtTitle.Text = film.DataTitle
            TxtDescription.Text = film.DataDescription
            TxtReleaseYear.Text = film.DataReleaseYear
            TxtOriginalLanguageId.Text = film.DataOriginalLanguageId
            TxtRentalDuration.Text = film.DataRentalDuration
            TxtRentalRate.Text = film.DataRentalRate
            TxtLength.Text = film.DataLength
            TxtReplacementCost.Text = film.DataReplacementCost
            TxtRating.Text = film.DataRating
            TxtSpecialFeatures.Text = film.DataSpecialFeatures
            cldLastUpdate.SelectedDate = film.DataLastUpdate
            cldLbLastUpdateLabel.Text = film.DataLastUpdate
        else
            btEliminar.Enabled = False
            btActualizar.Text = "Agregar"
        End If
        fuCancelar(false)
    End Sub

    Protected Sub btCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btCancelar.Click
        fuCancelar(true)
    End Sub
    Protected Function fuCancelar(byVal limpiar as Boolean)
        TxtFilmId.Enabled = not TxtFilmId.Enabled
        TxtTitle.Enabled = not TxtTitle.Enabled
       TxtDescription.Enabled = not TxtDescription.Enabled
        TxtReleaseYear.Enabled = not TxtReleaseYear.Enabled
        ddLanguageId.Enabled = not ddLanguageId.Enabled
        TxtOriginalLanguageId.Enabled = not TxtOriginalLanguageId.Enabled
        TxtRentalDuration.Enabled = not TxtRentalDuration.Enabled
        TxtRentalRate.Enabled = not TxtRentalRate.Enabled
        TxtLength.Enabled = not TxtLength.Enabled
        TxtReplacementCost.Enabled = not TxtReplacementCost.Enabled
        TxtRating.Enabled = not TxtRating.Enabled
        TxtSpecialFeatures.Enabled = not TxtSpecialFeatures.Enabled
        cldLastUpdate.Enabled = not cldLastUpdate.Enabled
        if limpiar then
            TxtFilmId.Focus()
            TxtTitle.Text = ""
            TxtDescription.Text = ""
            TxtReleaseYear.Text = ""
            ddLanguageId.Text = ""
            TxtOriginalLanguageId.Text = ""
            TxtRentalDuration.Text = ""
            TxtRentalRate.Text = ""
            TxtLength.Text = ""
            TxtReplacementCost.Text = ""
            TxtRating.Text = ""
            TxtSpecialFeatures.Text = ""
            'cldLastUpdate.Remove(cldLastUpdate.SelectedDates[0])
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebFilmDgv")
    End Sub

    Protected Sub cldLastUpdate_SelectionChanged(sender As Object, e As EventArgs) Handles cldLastUpdate.SelectionChanged
        cldLbLastUpdateLabel.Text = cldLastUpdate.SelectedDate
    End Sub

End Class
