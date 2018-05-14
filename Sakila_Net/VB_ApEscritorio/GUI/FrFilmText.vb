Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmFilmText
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "FilmText")
        Dim filmText as ClFilmText = New ClFilmText(Integer.Parse(TxtFilmId.Text))
        If (ClNegFilmText.eliminar(filmText)) Then
            MessageBox.Show("Error al Eliminar Registro", "FilmText")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "FilmText")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "FilmText")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim filmText as ClFilmText = New ClFilmText(Integer.Parse(TxtFilmId.Text),TxtTitle.Text,TxtDescription.Text)
        If (ClNegFilmText.actualizar(filmText)) Then
            MessageBox.Show("Error al Actualizar Registro", "FilmText")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "FilmText")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "FilmText")
        Dim filmText as ClFilmText = New ClFilmText(Integer.Parse(TxtFilmId.Text))
        If (Not ClNegFilmText.consultar(filmText)) Then
            MessageBox.Show("Error al Leer Registro", "FilmText")
            Return
        End If
        TxtTitle.Text = filmText.DataTitle
        TxtDescription.Text = filmText.DataDescription
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
