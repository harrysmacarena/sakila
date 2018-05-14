Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebInventory
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Inventory")
        Dim inventory as ClInventory = New ClInventory(Integer.Parse(TxtInventoryId.Text))
        If (ClNegInventory.eliminar(inventory)) Then
            'MessageBox.Show("Error al Eliminar Registro", "Inventory")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "Inventory")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Inventory")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim inventory as ClInventory = New ClInventory(Integer.Parse(TxtInventoryId.Text), New ClFilm(Integer.Parse(ddfilmId.SelectedValue.ToString())), New ClStore(Integer.Parse(ddstoreId.SelectedValue.ToString())),cldLastUpdate.SelectedDate.ToShortDateString())
        If (ClNegInventory.actualizar(inventory)) Then
            'MessageBox.Show("Error al Actualizar Registro", "Inventory")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "Inventory")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Inventory")
        Dim inventory as ClInventory = New ClInventory(Integer.Parse(TxtInventoryId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegInventory.consultar(inventory)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            cldLastUpdate.SelectedDate = inventory.DataLastUpdate
            cldLbLastUpdateLabel.Text = inventory.DataLastUpdate
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
        TxtInventoryId.Enabled = not TxtInventoryId.Enabled
        ddFilmId.Enabled = not ddFilmId.Enabled
        ddStoreId.Enabled = not ddStoreId.Enabled
        cldLastUpdate.Enabled = not cldLastUpdate.Enabled
        if limpiar then
            TxtInventoryId.Focus()
            ddFilmId.Text = ""
            ddStoreId.Text = ""
            'cldLastUpdate.Remove(cldLastUpdate.SelectedDates[0])
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebInventoryDgv")
    End Sub

    Protected Sub cldLastUpdate_SelectionChanged(sender As Object, e As EventArgs) Handles cldLastUpdate.SelectionChanged
        cldLbLastUpdateLabel.Text = cldLastUpdate.SelectedDate
    End Sub

End Class
