Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebFilmText
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "FilmText")
        Dim filmText as ClFilmText = New ClFilmText(Integer.Parse(TxtFilmId.Text))
        If (ClNegFilmText.eliminar(filmText)) Then
            'MessageBox.Show("Error al Eliminar Registro", "FilmText")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "FilmText")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "FilmText")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim filmText as ClFilmText = New ClFilmText(Integer.Parse(TxtFilmId.Text),TxtTitle.Text,TxtDescription.Text)
        If (ClNegFilmText.actualizar(filmText)) Then
            'MessageBox.Show("Error al Actualizar Registro", "FilmText")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "FilmText")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "FilmText")
        Dim filmText as ClFilmText = New ClFilmText(Integer.Parse(TxtFilmId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegFilmText.consultar(filmText)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            TxtTitle.Text = filmText.DataTitle
            TxtDescription.Text = filmText.DataDescription
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
        if limpiar then
            TxtFilmId.Focus()
            TxtTitle.Text = ""
            TxtDescription.Text = ""
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebFilmTextDgv")
    End Sub


End Class
