Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmFilmActor
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "FilmActor")
        Dim filmActor as ClFilmActor = New ClFilmActor(New ClActor(Integer.Parse(TxtactorId.Text)),New ClFilm(Integer.Parse(TxtfilmId.Text)))
        If (ClNegFilmActor.eliminar(filmActor)) Then
            MessageBox.Show("Error al Eliminar Registro", "FilmActor")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "FilmActor")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "FilmActor")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim filmActor as ClFilmActor = New ClFilmActor( New ClActor(Integer.Parse(TxtactorId.Text)), New ClFilm(Integer.Parse(TxtfilmId.Text)),TxtLastUpdate.Text)
        If (ClNegFilmActor.actualizar(filmActor)) Then
            MessageBox.Show("Error al Actualizar Registro", "FilmActor")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "FilmActor")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "FilmActor")
        Dim filmActor as ClFilmActor = New ClFilmActor(New ClActor(Integer.Parse(TxtactorId.Text)),New ClFilm(Integer.Parse(TxtfilmId.Text)))
        If (Not ClNegFilmActor.consultar(filmActor)) Then
            MessageBox.Show("Error al Leer Registro", "FilmActor")
            Return
        End If
        TxtLastUpdate.Text = filmActor.DataLastUpdate
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
