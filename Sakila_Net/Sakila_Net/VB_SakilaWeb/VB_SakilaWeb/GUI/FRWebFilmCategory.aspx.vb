Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebFilmCategory
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "FilmCategory")
        Dim filmCategory as ClFilmCategory = New ClFilmCategory(New ClFilm(Integer.Parse(ddfilmId.SelectedValue.ToString())),New ClCategory(Integer.Parse(ddcategoryId.SelectedValue.ToString())))
        If (ClNegFilmCategory.eliminar(filmCategory)) Then
            'MessageBox.Show("Error al Eliminar Registro", "FilmCategory")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "FilmCategory")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "FilmCategory")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim filmCategory as ClFilmCategory = New ClFilmCategory( New ClFilm(Integer.Parse(ddfilmId.SelectedValue.ToString())), New ClCategory(Integer.Parse(ddcategoryId.SelectedValue.ToString())),cldLastUpdate.SelectedDate.ToShortDateString())
        If (ClNegFilmCategory.actualizar(filmCategory)) Then
            'MessageBox.Show("Error al Actualizar Registro", "FilmCategory")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "FilmCategory")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "FilmCategory")
        Dim filmCategory as ClFilmCategory = New ClFilmCategory(New ClFilm(Integer.Parse(ddfilmId.SelectedValue.ToString())),New ClCategory(Integer.Parse(ddcategoryId.SelectedValue.ToString())))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegFilmCategory.consultar(filmCategory)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            cldLastUpdate.SelectedDate = filmCategory.DataLastUpdate
            cldLbLastUpdateLabel.Text = filmCategory.DataLastUpdate
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
        ddFilmId.Enabled = not ddFilmId.Enabled
        ddCategoryId.Enabled = not ddCategoryId.Enabled
        cldLastUpdate.Enabled = not cldLastUpdate.Enabled
        if limpiar then
            ddFilmId.Text = ""
            ddFilmId.Focus()
            ddCategoryId.Text = ""
            ddCategoryId.Focus()
            'cldLastUpdate.Remove(cldLastUpdate.SelectedDates[0])
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebFilmCategoryDgv")
    End Sub

    Protected Sub cldLastUpdate_SelectionChanged(sender As Object, e As EventArgs) Handles cldLastUpdate.SelectionChanged
        cldLbLastUpdateLabel.Text = cldLastUpdate.SelectedDate
    End Sub

End Class
