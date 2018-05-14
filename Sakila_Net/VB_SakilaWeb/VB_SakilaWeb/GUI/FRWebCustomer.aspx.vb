Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebCustomer
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Customer")
        Dim customer as ClCustomer = New ClCustomer(Integer.Parse(TxtCustomerId.Text))
        If (ClNegCustomer.eliminar(customer)) Then
            'MessageBox.Show("Error al Eliminar Registro", "Customer")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "Customer")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Customer")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim customer as ClCustomer = New ClCustomer(Integer.Parse(TxtCustomerId.Text), New ClStore(Integer.Parse(ddstoreId.SelectedValue.ToString())),TxtFirstName.Text,TxtLastName.Text,TxtEmail.Text, New ClAddress(Integer.Parse(ddaddressId.SelectedValue.ToString())),Integer.Parse(TxtActive.Text),cldCreateDate.SelectedDate.ToShortDateString(),cldLastUpdate.SelectedDate.ToShortDateString())
        If (ClNegCustomer.actualizar(customer)) Then
            'MessageBox.Show("Error al Actualizar Registro", "Customer")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "Customer")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Customer")
        Dim customer as ClCustomer = New ClCustomer(Integer.Parse(TxtCustomerId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegCustomer.consultar(customer)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            TxtFirstName.Text = customer.DataFirstName
            TxtLastName.Text = customer.DataLastName
            TxtEmail.Text = customer.DataEmail
            TxtActive.Text = customer.DataActive
            cldCreateDate.SelectedDate = customer.DataCreateDate
            cldLbCreateDateLabel.Text = customer.DataCreateDate
            cldLastUpdate.SelectedDate = customer.DataLastUpdate
            cldLbLastUpdateLabel.Text = customer.DataLastUpdate
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
        TxtCustomerId.Enabled = not TxtCustomerId.Enabled
        ddStoreId.Enabled = not ddStoreId.Enabled
        TxtFirstName.Enabled = not TxtFirstName.Enabled
        TxtLastName.Enabled = not TxtLastName.Enabled
        TxtEmail.Enabled = not TxtEmail.Enabled
        ddAddressId.Enabled = not ddAddressId.Enabled
        TxtActive.Enabled = not TxtActive.Enabled
        cldCreateDate.Enabled = not cldCreateDate.Enabled
        cldLastUpdate.Enabled = not cldLastUpdate.Enabled
        if limpiar then
            TxtCustomerId.Focus()
            ddStoreId.Text = ""
            TxtFirstName.Text = ""
            TxtLastName.Text = ""
            TxtEmail.Text = ""
            ddAddressId.Text = ""
            TxtActive.Text = ""
            'cldCreateDate.Remove(cldCreateDate.SelectedDates[0])
            'cldLastUpdate.Remove(cldLastUpdate.SelectedDates[0])
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebCustomerDgv")
    End Sub

    Protected Sub cldCreateDate_SelectionChanged(sender As Object, e As EventArgs) Handles cldCreateDate.SelectionChanged
        cldLbCreateDateLabel.Text = cldCreateDate.SelectedDate
    End Sub
    Protected Sub cldLastUpdate_SelectionChanged(sender As Object, e As EventArgs) Handles cldLastUpdate.SelectionChanged
        cldLbLastUpdateLabel.Text = cldLastUpdate.SelectedDate
    End Sub

End Class
