Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebFilmActor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "FilmActor")
        Dim filmActor as ClFilmActor = New ClFilmActor(New ClActor(Integer.Parse(ddactorId.SelectedValue.ToString())),New ClFilm(Integer.Parse(ddfilmId.SelectedValue.ToString())))
        If (ClNegFilmActor.eliminar(filmActor)) Then
            'MessageBox.Show("Error al Eliminar Registro", "FilmActor")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "FilmActor")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "FilmActor")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim filmActor as ClFilmActor = New ClFilmActor( New ClActor(Integer.Parse(ddactorId.SelectedValue.ToString())), New ClFilm(Integer.Parse(ddfilmId.SelectedValue.ToString())),cldLastUpdate.SelectedDate.ToShortDateString())
        If (ClNegFilmActor.actualizar(filmActor)) Then
            'MessageBox.Show("Error al Actualizar Registro", "FilmActor")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "FilmActor")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "FilmActor")
        Dim filmActor as ClFilmActor = New ClFilmActor(New ClActor(Integer.Parse(ddactorId.SelectedValue.ToString())),New ClFilm(Integer.Parse(ddfilmId.SelectedValue.ToString())))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegFilmActor.consultar(filmActor)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            cldLastUpdate.SelectedDate = filmActor.DataLastUpdate
            cldLbLastUpdateLabel.Text = filmActor.DataLastUpdate
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
        ddActorId.Enabled = not ddActorId.Enabled
        ddFilmId.Enabled = not ddFilmId.Enabled
        cldLastUpdate.Enabled = not cldLastUpdate.Enabled
        if limpiar then
            ddActorId.Text = ""
            ddActorId.Focus()
            ddFilmId.Text = ""
            ddFilmId.Focus()
            'cldLastUpdate.Remove(cldLastUpdate.SelectedDates[0])
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebFilmActorDgv")
    End Sub

    Protected Sub cldLastUpdate_SelectionChanged(sender As Object, e As EventArgs) Handles cldLastUpdate.SelectionChanged
        cldLbLastUpdateLabel.Text = cldLastUpdate.SelectedDate
    End Sub

End Class
