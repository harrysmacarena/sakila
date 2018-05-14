Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmCity
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "City")
        Dim city as ClCity = New ClCity(Integer.Parse(TxtCityId.Text))
        If (ClNegCity.eliminar(city)) Then
            MessageBox.Show("Error al Eliminar Registro", "City")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "City")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "City")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim city as ClCity = New ClCity(Integer.Parse(TxtCityId.Text),TxtCity.Text, New ClCountry(Integer.Parse(TxtcountryId.Text)),TxtLastUpdate.Text)
        If (ClNegCity.actualizar(city)) Then
            MessageBox.Show("Error al Actualizar Registro", "City")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "City")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "City")
        Dim city as ClCity = New ClCity(Integer.Parse(TxtCityId.Text))
        If (Not ClNegCity.consultar(city)) Then
            MessageBox.Show("Error al Leer Registro", "City")
            Return
        End If
        TxtCity.Text = city.DataCity
        TxtLastUpdate.Text = city.DataLastUpdate
        'setDisabled(jpaCl, 1, false)
        'setEnabled(jpaDt, 2, true)
        'btSalir.setText(vpadre.lbCancelar)
        'btSalir.setEnabled(true)
        'btLeer.setEnabled(false)
        'if (vpadre.genSqlGen.getNReg() > 0 ) Then
    ''
    ''        btGrabar.setText(vpadre.lbModificar)
    ''    Else
    ''        setEnabled(jpaDt,2,true)
    ''        btGrabar.setText(vpadre.lbInsertar)
    ''        btEliminar.setEnabled(false)
    ''    End If
    ''    return true
    End Sub

    Private Sub btSalir_Click(sender as Object, e as EventArgs) Handles btSalir.Click
        fuCancelar()
    End Sub
    Private Function fuCancelar()
        If (btSalir.Text = General.btCerrar) Then '// || txTOrdenSt !=  null)
            Me.Close()
            FrMenu.Visible = True
            FrMenu.Show()
            Return True
        End If
        btSalir.Text = General.btCerrar
        Return True
    End Function
End Class
