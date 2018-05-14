Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebCity
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "City")
        Dim city as ClCity = New ClCity(Integer.Parse(TxtCityId.Text))
        If (ClNegCity.eliminar(city)) Then
            'MessageBox.Show("Error al Eliminar Registro", "City")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "City")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "City")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim city as ClCity = New ClCity(Integer.Parse(TxtCityId.Text),TxtCity.Text, New ClCountry(Integer.Parse(ddcountryId.SelectedValue.ToString())),cldLastUpdate.SelectedDate.ToShortDateString())
        If (ClNegCity.actualizar(city)) Then
            'MessageBox.Show("Error al Actualizar Registro", "City")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "City")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "City")
        Dim city as ClCity = New ClCity(Integer.Parse(TxtCityId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegCity.consultar(city)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            TxtCity.Text = city.DataCity
            cldLastUpdate.SelectedDate = city.DataLastUpdate
            cldLbLastUpdateLabel.Text = city.DataLastUpdate
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
        TxtCityId.Enabled = not TxtCityId.Enabled
        TxtCity.Enabled = not TxtCity.Enabled
        ddCountryId.Enabled = not ddCountryId.Enabled
        cldLastUpdate.Enabled = not cldLastUpdate.Enabled
        if limpiar then
            TxtCityId.Focus()
            TxtCity.Text = ""
            ddCountryId.Text = ""
            'cldLastUpdate.Remove(cldLastUpdate.SelectedDates[0])
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebCityDgv")
    End Sub

    Protected Sub cldLastUpdate_SelectionChanged(sender As Object, e As EventArgs) Handles cldLastUpdate.SelectionChanged
        cldLbLastUpdateLabel.Text = cldLastUpdate.SelectedDate
    End Sub

End Class
