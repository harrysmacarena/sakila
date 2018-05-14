Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebCountry
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Country")
        Dim country as ClCountry = New ClCountry(Integer.Parse(TxtCountryId.Text))
        If (ClNegCountry.eliminar(country)) Then
            'MessageBox.Show("Error al Eliminar Registro", "Country")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "Country")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Country")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim country as ClCountry = New ClCountry(Integer.Parse(TxtCountryId.Text),TxtCountry.Text,cldLastUpdate.SelectedDate.ToShortDateString())
        If (ClNegCountry.actualizar(country)) Then
            'MessageBox.Show("Error al Actualizar Registro", "Country")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "Country")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Country")
        Dim country as ClCountry = New ClCountry(Integer.Parse(TxtCountryId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegCountry.consultar(country)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            TxtCountry.Text = country.DataCountry
            cldLastUpdate.SelectedDate = country.DataLastUpdate
            cldLbLastUpdateLabel.Text = country.DataLastUpdate
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
        TxtCountryId.Enabled = not TxtCountryId.Enabled
        TxtCountry.Enabled = not TxtCountry.Enabled
        cldLastUpdate.Enabled = not cldLastUpdate.Enabled
        if limpiar then
            TxtCountryId.Focus()
            TxtCountry.Text = ""
            'cldLastUpdate.Remove(cldLastUpdate.SelectedDates[0])
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebCountryDgv")
    End Sub

    Protected Sub cldLastUpdate_SelectionChanged(sender As Object, e As EventArgs) Handles cldLastUpdate.SelectionChanged
        cldLbLastUpdateLabel.Text = cldLastUpdate.SelectedDate
    End Sub

End Class
