Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebStaff
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Staff")
        Dim staff as ClStaff = New ClStaff(Integer.Parse(TxtStaffId.Text))
        If (ClNegStaff.eliminar(staff)) Then
            'MessageBox.Show("Error al Eliminar Registro", "Staff")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "Staff")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Staff")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim staff as ClStaff = New ClStaff(Integer.Parse(TxtStaffId.Text),TxtFirstName.Text,TxtLastName.Text, New ClAddress(Integer.Parse(ddaddressId.SelectedValue.ToString())),TxtPicture.Text,TxtEmail.Text, New ClStore(Integer.Parse(ddstoreId.SelectedValue.ToString())),Integer.Parse(TxtActive.Text),TxtUsername.Text,TxtPassword.Text,cldLastUpdate.SelectedDate.ToShortDateString())
        If (ClNegStaff.actualizar(staff)) Then
            'MessageBox.Show("Error al Actualizar Registro", "Staff")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "Staff")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Staff")
        Dim staff as ClStaff = New ClStaff(Integer.Parse(TxtStaffId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegStaff.consultar(staff)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            TxtFirstName.Text = staff.DataFirstName
            TxtLastName.Text = staff.DataLastName
            TxtPicture.Text = staff.DataPicture
            TxtEmail.Text = staff.DataEmail
            TxtActive.Text = staff.DataActive
            TxtUsername.Text = staff.DataUsername
            TxtPassword.Text = staff.DataPassword
            cldLastUpdate.SelectedDate = staff.DataLastUpdate
            cldLbLastUpdateLabel.Text = staff.DataLastUpdate
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
        TxtStaffId.Enabled = not TxtStaffId.Enabled
        TxtFirstName.Enabled = not TxtFirstName.Enabled
        TxtLastName.Enabled = not TxtLastName.Enabled
        ddAddressId.Enabled = not ddAddressId.Enabled
       TxtPicture.Enabled = not TxtPicture.Enabled
        TxtEmail.Enabled = not TxtEmail.Enabled
        ddStoreId.Enabled = not ddStoreId.Enabled
        TxtActive.Enabled = not TxtActive.Enabled
        TxtUsername.Enabled = not TxtUsername.Enabled
        TxtPassword.Enabled = not TxtPassword.Enabled
        cldLastUpdate.Enabled = not cldLastUpdate.Enabled
        if limpiar then
            TxtStaffId.Focus()
            TxtFirstName.Text = ""
            TxtLastName.Text = ""
            ddAddressId.Text = ""
            TxtPicture.Text = ""
            TxtEmail.Text = ""
            ddStoreId.Text = ""
            TxtActive.Text = ""
            TxtUsername.Text = ""
            TxtPassword.Text = ""
            'cldLastUpdate.Remove(cldLastUpdate.SelectedDates[0])
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebStaffDgv")
    End Sub

    Protected Sub cldLastUpdate_SelectionChanged(sender As Object, e As EventArgs) Handles cldLastUpdate.SelectionChanged
        cldLbLastUpdateLabel.Text = cldLastUpdate.SelectedDate
    End Sub

End Class
