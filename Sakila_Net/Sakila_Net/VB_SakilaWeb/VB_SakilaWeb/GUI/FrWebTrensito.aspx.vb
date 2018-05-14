Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebTrensito
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Trensito")
        Dim trensito as ClTrensito = New ClTrensito(Integer.Parse(TxtId.Text))
        If (ClNegTrensito.eliminar(trensito)) Then
            'MessageBox.Show("Error al Eliminar Registro", "Trensito")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "Trensito")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Trensito")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim trensito as ClTrensito = New ClTrensito(Integer.Parse(TxtId.Text),TxtNombre.Text,Integer.Parse(TxtLargo.Text),Integer.Parse(TxtIdMarca.Text))
        If (ClNegTrensito.actualizar(trensito)) Then
            'MessageBox.Show("Error al Actualizar Registro", "Trensito")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "Trensito")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Trensito")
        Dim trensito as ClTrensito = New ClTrensito(Integer.Parse(TxtId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegTrensito.consultar(trensito)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            TxtNombre.Text = trensito.DataNombre
            TxtLargo.Text = trensito.DataLargo
            TxtIdMarca.Text = trensito.DataIdMarca
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
        TxtId.Enabled = not TxtId.Enabled
        TxtNombre.Enabled = not TxtNombre.Enabled
        TxtLargo.Enabled = not TxtLargo.Enabled
        TxtIdMarca.Enabled = not TxtIdMarca.Enabled
        if limpiar then
            TxtId.Focus()
            TxtNombre.Text = ""
            TxtLargo.Text = ""
            TxtIdMarca.Text = ""
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebTrensitoDgv")
    End Sub


End Class
