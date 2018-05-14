Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebActor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Actor")
        Dim actor as ClActor = New ClActor(Integer.Parse(TxtActorId.Text))
        If (ClNegActor.eliminar(actor)) Then
            'MessageBox.Show("Error al Eliminar Registro", "Actor")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "Actor")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Actor")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim actor as ClActor = New ClActor(Integer.Parse(TxtActorId.Text),TxtFirstName.Text,TxtLastName.Text,cldLastUpdate.SelectedDate.ToShortDateString())
        If (ClNegActor.actualizar(actor)) Then
            'MessageBox.Show("Error al Actualizar Registro", "Actor")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "Actor")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Actor")
        Dim actor as ClActor = New ClActor(Integer.Parse(TxtActorId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegActor.consultar(actor)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            TxtFirstName.Text = actor.DataFirstName
            TxtLastName.Text = actor.DataLastName
            cldLastUpdate.SelectedDate = actor.DataLastUpdate
            cldLbLastUpdateLabel.Text = actor.DataLastUpdate
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
        TxtActorId.Enabled = not TxtActorId.Enabled
        TxtFirstName.Enabled = not TxtFirstName.Enabled
        TxtLastName.Enabled = not TxtLastName.Enabled
        cldLastUpdate.Enabled = not cldLastUpdate.Enabled
        if limpiar then
            TxtActorId.Focus()
            TxtFirstName.Text = ""
            TxtLastName.Text = ""
            'cldLastUpdate.Remove(cldLastUpdate.SelectedDates[0])
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebActorDgv")
    End Sub

    Protected Sub cldLastUpdate_SelectionChanged(sender As Object, e As EventArgs) Handles cldLastUpdate.SelectionChanged
        cldLbLastUpdateLabel.Text = cldLastUpdate.SelectedDate
    End Sub

End Class
