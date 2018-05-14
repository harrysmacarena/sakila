Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebAddress
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Address")
        Dim address as ClAddress = New ClAddress(Integer.Parse(TxtAddressId.Text))
        If (ClNegAddress.eliminar(address)) Then
            'MessageBox.Show("Error al Eliminar Registro", "Address")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "Address")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Address")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim address as ClAddress = New ClAddress(Integer.Parse(TxtAddressId.Text),TxtAddress.Text,TxtAddress2.Text,TxtDistrict.Text, New ClCity(Integer.Parse(ddcityId.SelectedValue.ToString())),TxtPostalCode.Text,TxtPhone.Text,cldLastUpdate.SelectedDate.ToShortDateString())
        If (ClNegAddress.actualizar(address)) Then
            'MessageBox.Show("Error al Actualizar Registro", "Address")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "Address")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Address")
        Dim address as ClAddress = New ClAddress(Integer.Parse(TxtAddressId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegAddress.consultar(address)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            TxtAddress.Text = address.DataAddress
            TxtAddress2.Text = address.DataAddress2
            TxtDistrict.Text = address.DataDistrict
            TxtPostalCode.Text = address.DataPostalCode
            TxtPhone.Text = address.DataPhone
            cldLastUpdate.SelectedDate = address.DataLastUpdate
            cldLbLastUpdateLabel.Text = address.DataLastUpdate
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
        TxtAddressId.Enabled = not TxtAddressId.Enabled
        TxtAddress.Enabled = not TxtAddress.Enabled
        TxtAddress2.Enabled = not TxtAddress2.Enabled
        TxtDistrict.Enabled = not TxtDistrict.Enabled
        ddCityId.Enabled = not ddCityId.Enabled
        TxtPostalCode.Enabled = not TxtPostalCode.Enabled
        TxtPhone.Enabled = not TxtPhone.Enabled
        cldLastUpdate.Enabled = not cldLastUpdate.Enabled
        if limpiar then
            TxtAddressId.Focus()
            TxtAddress.Text = ""
            TxtAddress2.Text = ""
            TxtDistrict.Text = ""
            ddCityId.Text = ""
            TxtPostalCode.Text = ""
            TxtPhone.Text = ""
            'cldLastUpdate.Remove(cldLastUpdate.SelectedDates[0])
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebAddressDgv")
    End Sub

    Protected Sub cldLastUpdate_SelectionChanged(sender As Object, e As EventArgs) Handles cldLastUpdate.SelectionChanged
        cldLbLastUpdateLabel.Text = cldLastUpdate.SelectedDate
    End Sub

End Class
