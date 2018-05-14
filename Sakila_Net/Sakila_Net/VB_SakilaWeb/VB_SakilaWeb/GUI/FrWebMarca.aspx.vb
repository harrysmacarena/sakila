Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebMarca
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub
    Protected Sub btEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Marca")
        Dim marca as ClMarca = New ClMarca(Integer.Parse(TxtId.Text))
        If (ClNegMarca.eliminar(marca)) Then
            'MessageBox.Show("Error al Eliminar Registro", "Marca")
            Return
        End If
        'MessageBox.Show("Registro Eliminado", "Marca")
        fuCancelar(True)
    End Sub
    Protected Sub btActualizar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Marca")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim marca as ClMarca = New ClMarca(Integer.Parse(TxtId.Text),TxtNombre.Text)
        If (ClNegMarca.actualizar(marca)) Then
            'MessageBox.Show("Error al Actualizar Registro", "Marca")
            Return
        End If
        'MessageBox.Show("Registro Actualizar", "Marca")
        fuCancelar(True)
    End Sub
    Protected Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Marca")
        Dim marca as ClMarca = New ClMarca(Integer.Parse(TxtId.Text))
        btLeer.Enabled = False
        btActualizar.Enabled = True
        If (ClNegMarca.consultar(marca)) Then
             btActualizar.Text = "Actualizar"
             btEliminar.Enabled = True
            TxtNombre.Text = marca.DataNombre
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
        if limpiar then
            TxtId.Focus()
            TxtNombre.Text = ""
            btLeer.Enabled = True
            btActualizar.Enabled = False
            btEliminar.Enabled = False
        End If
        Return True
    End Function
    Protected Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        Response.Redirect("~/GUIDgv/FRWebMarcaDgv")
    End Sub


End Class
