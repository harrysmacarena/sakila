Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebCategory
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Category")
        Dim category as ClCategory = New ClCategory(Integer.Parse(TxtCategoryId.Text))
        If (ClNegCategory.eliminar(category)) Then
            'MessageBox.Show("Error al Eliminar Registro", "Category")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "Category")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Category")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim category as ClCategory = New ClCategory(Integer.Parse(TxtCategoryId.Text),TxtName.Text,cldLastUpdate.SelectedDate.ToShortDateString())
        If (ClNegCategory.actualizar(category)) Then
            'MessageBox.Show("Error al Actualizar Registro", "Category")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "Category")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Category")
        Dim category as ClCategory = New ClCategory(Integer.Parse(TxtCategoryId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegCategory.consultar(category)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            TxtName.Text = category.DataName
            cldLastUpdate.SelectedDate = category.DataLastUpdate
            cldLbLastUpdateLabel.Text = category.DataLastUpdate
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
        TxtCategoryId.Enabled = not TxtCategoryId.Enabled
        TxtName.Enabled = not TxtName.Enabled
        cldLastUpdate.Enabled = not cldLastUpdate.Enabled
        if limpiar then
            TxtCategoryId.Focus()
            TxtName.Text = ""
            'cldLastUpdate.Remove(cldLastUpdate.SelectedDates[0])
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebCategoryDgv")
    End Sub

    Protected Sub cldLastUpdate_SelectionChanged(sender As Object, e As EventArgs) Handles cldLastUpdate.SelectionChanged
        cldLbLastUpdateLabel.Text = cldLastUpdate.SelectedDate
    End Sub

End Class
