Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebLanguage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Language")
        Dim language as ClLanguage = New ClLanguage(Integer.Parse(TxtLanguageId.Text))
        If (ClNegLanguage.eliminar(language)) Then
            'MessageBox.Show("Error al Eliminar Registro", "Language")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "Language")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Language")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim language as ClLanguage = New ClLanguage(Integer.Parse(TxtLanguageId.Text),TxtName.Text,cldLastUpdate.SelectedDate.ToShortDateString())
        If (ClNegLanguage.actualizar(language)) Then
            'MessageBox.Show("Error al Actualizar Registro", "Language")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "Language")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Language")
        Dim language as ClLanguage = New ClLanguage(Integer.Parse(TxtLanguageId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegLanguage.consultar(language)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            TxtName.Text = language.DataName
            cldLastUpdate.SelectedDate = language.DataLastUpdate
            cldLbLastUpdateLabel.Text = language.DataLastUpdate
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
        TxtLanguageId.Enabled = not TxtLanguageId.Enabled
        TxtName.Enabled = not TxtName.Enabled
        cldLastUpdate.Enabled = not cldLastUpdate.Enabled
        if limpiar then
            TxtLanguageId.Focus()
            TxtName.Text = ""
            'cldLastUpdate.Remove(cldLastUpdate.SelectedDates[0])
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebLanguageDgv")
    End Sub

    Protected Sub cldLastUpdate_SelectionChanged(sender As Object, e As EventArgs) Handles cldLastUpdate.SelectionChanged
        cldLbLastUpdateLabel.Text = cldLastUpdate.SelectedDate
    End Sub

End Class
