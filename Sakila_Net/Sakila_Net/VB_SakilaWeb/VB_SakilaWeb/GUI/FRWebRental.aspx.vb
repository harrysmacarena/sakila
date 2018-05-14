Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebRental
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Rental")
        Dim rental as ClRental = New ClRental(Integer.Parse(TxtRentalId.Text))
        If (ClNegRental.eliminar(rental)) Then
            'MessageBox.Show("Error al Eliminar Registro", "Rental")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "Rental")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Rental")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim rental as ClRental = New ClRental(Integer.Parse(TxtRentalId.Text),cldRentalDate.SelectedDate.ToShortDateString(), New ClInventory(Integer.Parse(ddinventoryId.SelectedValue.ToString())), New ClCustomer(Integer.Parse(ddcustomerId.SelectedValue.ToString())),cldReturnDate.SelectedDate.ToShortDateString(), New ClStaff(Integer.Parse(ddstaffId.SelectedValue.ToString())),cldLastUpdate.SelectedDate.ToShortDateString())
        If (ClNegRental.actualizar(rental)) Then
            'MessageBox.Show("Error al Actualizar Registro", "Rental")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "Rental")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Rental")
        Dim rental as ClRental = New ClRental(Integer.Parse(TxtRentalId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegRental.consultar(rental)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            cldRentalDate.SelectedDate = rental.DataRentalDate
            cldLbRentalDateLabel.Text = rental.DataRentalDate
            cldReturnDate.SelectedDate = rental.DataReturnDate
            cldLbReturnDateLabel.Text = rental.DataReturnDate
            cldLastUpdate.SelectedDate = rental.DataLastUpdate
            cldLbLastUpdateLabel.Text = rental.DataLastUpdate
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
        TxtRentalId.Enabled = not TxtRentalId.Enabled
        cldRentalDate.Enabled = not cldRentalDate.Enabled
        ddInventoryId.Enabled = not ddInventoryId.Enabled
        ddCustomerId.Enabled = not ddCustomerId.Enabled
        cldReturnDate.Enabled = not cldReturnDate.Enabled
        ddStaffId.Enabled = not ddStaffId.Enabled
        cldLastUpdate.Enabled = not cldLastUpdate.Enabled
        if limpiar then
            TxtRentalId.Focus()
            'cldRentalDate.Remove(cldRentalDate.SelectedDates[0])
            ddInventoryId.Text = ""
            ddCustomerId.Text = ""
            'cldReturnDate.Remove(cldReturnDate.SelectedDates[0])
            ddStaffId.Text = ""
            'cldLastUpdate.Remove(cldLastUpdate.SelectedDates[0])
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebRentalDgv")
    End Sub

    Protected Sub cldRentalDate_SelectionChanged(sender As Object, e As EventArgs) Handles cldRentalDate.SelectionChanged
        cldLbRentalDateLabel.Text = cldRentalDate.SelectedDate
    End Sub
    Protected Sub cldReturnDate_SelectionChanged(sender As Object, e As EventArgs) Handles cldReturnDate.SelectionChanged
        cldLbReturnDateLabel.Text = cldReturnDate.SelectedDate
    End Sub
    Protected Sub cldLastUpdate_SelectionChanged(sender As Object, e As EventArgs) Handles cldLastUpdate.SelectionChanged
        cldLbLastUpdateLabel.Text = cldLastUpdate.SelectedDate
    End Sub

End Class
