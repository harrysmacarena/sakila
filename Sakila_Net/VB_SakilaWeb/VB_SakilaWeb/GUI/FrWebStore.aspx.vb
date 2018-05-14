Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebStore
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Store")
        Dim store as ClStore = New ClStore(Integer.Parse(TxtStoreId.Text))
        If (ClNegStore.eliminar(store)) Then
            'MessageBox.Show("Error al Eliminar Registro", "Store")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "Store")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Store")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim store as ClStore = New ClStore(Integer.Parse(TxtStoreId.Text),Integer.Parse(TxtManagerStaffId.Text), New ClAddress(Integer.Parse(ddaddressId.SelectedValue.ToString())),cldLastUpdate.SelectedDate.ToShortDateString())
        If (ClNegStore.actualizar(store)) Then
            'MessageBox.Show("Error al Actualizar Registro", "Store")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "Store")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Store")
        Dim store as ClStore = New ClStore(Integer.Parse(TxtStoreId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegStore.consultar(store)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            TxtManagerStaffId.Text = store.DataManagerStaffId
            cldLastUpdate.SelectedDate = store.DataLastUpdate
            cldLbLastUpdateLabel.Text = store.DataLastUpdate
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
        TxtStoreId.Enabled = not TxtStoreId.Enabled
        TxtManagerStaffId.Enabled = not TxtManagerStaffId.Enabled
        ddAddressId.Enabled = not ddAddressId.Enabled
        cldLastUpdate.Enabled = not cldLastUpdate.Enabled
        if limpiar then
            TxtStoreId.Focus()
            TxtManagerStaffId.Text = ""
            ddAddressId.Text = ""
            'cldLastUpdate.Remove(cldLastUpdate.SelectedDates[0])
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebStoreDgv")
    End Sub

    Protected Sub cldLastUpdate_SelectionChanged(sender As Object, e As EventArgs) Handles cldLastUpdate.SelectionChanged
        cldLbLastUpdateLabel.Text = cldLastUpdate.SelectedDate
    End Sub

End Class
