Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmFilmCategory
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "FilmCategory")
        Dim filmCategory as ClFilmCategory = New ClFilmCategory(New ClFilm(Integer.Parse(TxtfilmId.Text)),New ClCategory(Integer.Parse(TxtcategoryId.Text)))
        If (ClNegFilmCategory.eliminar(filmCategory)) Then
            MessageBox.Show("Error al Eliminar Registro", "FilmCategory")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "FilmCategory")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "FilmCategory")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim filmCategory as ClFilmCategory = New ClFilmCategory( New ClFilm(Integer.Parse(TxtfilmId.Text)), New ClCategory(Integer.Parse(TxtcategoryId.Text)),TxtLastUpdate.Text)
        If (ClNegFilmCategory.actualizar(filmCategory)) Then
            MessageBox.Show("Error al Actualizar Registro", "FilmCategory")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "FilmCategory")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "FilmCategory")
        Dim filmCategory as ClFilmCategory = New ClFilmCategory(New ClFilm(Integer.Parse(TxtfilmId.Text)),New ClCategory(Integer.Parse(TxtcategoryId.Text)))
        If (Not ClNegFilmCategory.consultar(filmCategory)) Then
            MessageBox.Show("Error al Leer Registro", "FilmCategory")
            Return
        End If
        TxtLastUpdate.Text = filmCategory.DataLastUpdate
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
