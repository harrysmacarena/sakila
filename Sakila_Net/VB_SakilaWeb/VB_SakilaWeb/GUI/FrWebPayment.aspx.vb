Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebPayment
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Payment")
        Dim payment as ClPayment = New ClPayment(Integer.Parse(TxtPaymentId.Text))
        If (ClNegPayment.eliminar(payment)) Then
            'MessageBox.Show("Error al Eliminar Registro", "Payment")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "Payment")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Payment")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim payment as ClPayment = New ClPayment(Integer.Parse(TxtPaymentId.Text), New ClCustomer(Integer.Parse(ddcustomerId.SelectedValue.ToString())), New ClStaff(Integer.Parse(ddstaffId.SelectedValue.ToString())), New ClRental(Integer.Parse(ddrentalId.SelectedValue.ToString())),Integer.Parse(TxtAmount.Text),cldPaymentDate.SelectedDate.ToShortDateString(),cldLastUpdate.SelectedDate.ToShortDateString())
        If (ClNegPayment.actualizar(payment)) Then
            'MessageBox.Show("Error al Actualizar Registro", "Payment")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "Payment")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Payment")
        Dim payment as ClPayment = New ClPayment(Integer.Parse(TxtPaymentId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegPayment.consultar(payment)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            TxtAmount.Text = payment.DataAmount
            cldPaymentDate.SelectedDate = payment.DataPaymentDate
            cldLbPaymentDateLabel.Text = payment.DataPaymentDate
            cldLastUpdate.SelectedDate = payment.DataLastUpdate
            cldLbLastUpdateLabel.Text = payment.DataLastUpdate
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
        TxtPaymentId.Enabled = not TxtPaymentId.Enabled
        ddCustomerId.Enabled = not ddCustomerId.Enabled
        ddStaffId.Enabled = not ddStaffId.Enabled
        ddRentalId.Enabled = not ddRentalId.Enabled
        TxtAmount.Enabled = not TxtAmount.Enabled
        cldPaymentDate.Enabled = not cldPaymentDate.Enabled
        cldLastUpdate.Enabled = not cldLastUpdate.Enabled
        if limpiar then
            TxtPaymentId.Focus()
            ddCustomerId.Text = ""
            ddStaffId.Text = ""
            ddRentalId.Text = ""
            TxtAmount.Text = ""
            'cldPaymentDate.Remove(cldPaymentDate.SelectedDates[0])
            'cldLastUpdate.Remove(cldLastUpdate.SelectedDates[0])
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebPaymentDgv")
    End Sub

    Protected Sub cldPaymentDate_SelectionChanged(sender As Object, e As EventArgs) Handles cldPaymentDate.SelectionChanged
        cldLbPaymentDateLabel.Text = cldPaymentDate.SelectedDate
    End Sub
    Protected Sub cldLastUpdate_SelectionChanged(sender As Object, e As EventArgs) Handles cldLastUpdate.SelectionChanged
        cldLbLastUpdateLabel.Text = cldLastUpdate.SelectedDate
    End Sub

End Class
