Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmCountry
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Country")
        Dim country as ClCountry = New ClCountry(Integer.Parse(TxtCountryId.Text))
        If (ClNegCountry.eliminar(country)) Then
            MessageBox.Show("Error al Eliminar Registro", "Country")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "Country")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Country")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim country as ClCountry = New ClCountry(Integer.Parse(TxtCountryId.Text),TxtCountry.Text,TxtLastUpdate.Text)
        If (ClNegCountry.actualizar(country)) Then
            MessageBox.Show("Error al Actualizar Registro", "Country")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "Country")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Country")
        Dim country as ClCountry = New ClCountry(Integer.Parse(TxtCountryId.Text))
        If (Not ClNegCountry.consultar(country)) Then
            MessageBox.Show("Error al Leer Registro", "Country")
            Return
        End If
        TxtCountry.Text = country.DataCountry
        TxtLastUpdate.Text = country.DataLastUpdate
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
