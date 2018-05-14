Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmFilm
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Film")
        Dim film as ClFilm = New ClFilm(Integer.Parse(TxtFilmId.Text))
        If (ClNegFilm.eliminar(film)) Then
            MessageBox.Show("Error al Eliminar Registro", "Film")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "Film")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Film")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim film as ClFilm = New ClFilm(Integer.Parse(TxtFilmId.Text),TxtTitle.Text,TxtDescription.Text,Integer.Parse(TxtReleaseYear.Text), New ClLanguage(Integer.Parse(TxtlanguageId.Text)),Integer.Parse(TxtOriginalLanguageId.Text),Integer.Parse(TxtRentalDuration.Text),Integer.Parse(TxtRentalRate.Text),Integer.Parse(TxtLength.Text),Integer.Parse(TxtReplacementCost.Text),TxtRating.Text,TxtSpecialFeatures.Text,TxtLastUpdate.Text)
        If (ClNegFilm.actualizar(film)) Then
            MessageBox.Show("Error al Actualizar Registro", "Film")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "Film")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Film")
        Dim film as ClFilm = New ClFilm(Integer.Parse(TxtFilmId.Text))
        If (Not ClNegFilm.consultar(film)) Then
            MessageBox.Show("Error al Leer Registro", "Film")
            Return
        End If
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
        TxtLastUpdate.Text = film.DataLastUpdate
        'setDisabled(jpaCl, 1, false)
        'setEnabled(jpaDt, 2, true)
        'btSalir.setText(vpadre.lbCancelar)
        'btSalir.setEnabled(true)
        'btLeer.setEnabled(false)
        'if (vpadre.genSqlGen.getNReg() > 0 ) Then
    ''
    ''        btGrabar.setText(vpadre.lbModificar)
    ''    Else
    ''        setEnabled(jpaDt,2,true)
    ''        btGrabar.setText(vpadre.lbInsertar)
    ''        btEliminar.setEnabled(false)
    ''    End If
    ''    return true
    End Sub

    Private Sub btSalir_Click(sender as Object, e as EventArgs) Handles btSalir.Click
        fuCancelar()
    End Sub
    Private Function fuCancelar()
        If (btSalir.Text = General.btCerrar) Then '// || txTOrdenSt !=  null)
            Me.Close()
            FrMenu.Visible = True
            FrMenu.Show()
            Return True
        End If
        btSalir.Text = General.btCerrar
        Return True
    End Function
End Class
