Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmAddress
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Address")
        Dim address as ClAddress = New ClAddress(Integer.Parse(TxtAddressId.Text))
        If (ClNegAddress.eliminar(address)) Then
            MessageBox.Show("Error al Eliminar Registro", "Address")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "Address")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Address")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim address as ClAddress = New ClAddress(Integer.Parse(TxtAddressId.Text),TxtAddress.Text,TxtAddress2.Text,TxtDistrict.Text, New ClCity(Integer.Parse(TxtcityId.Text)),TxtPostalCode.Text,TxtPhone.Text,TxtLastUpdate.Text)
        If (ClNegAddress.actualizar(address)) Then
            MessageBox.Show("Error al Actualizar Registro", "Address")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "Address")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Address")
        Dim address as ClAddress = New ClAddress(Integer.Parse(TxtAddressId.Text))
        If (Not ClNegAddress.consultar(address)) Then
            MessageBox.Show("Error al Leer Registro", "Address")
            Return
        End If
        TxtAddress.Text = address.DataAddress
        TxtAddress2.Text = address.DataAddress2
        TxtDistrict.Text = address.DataDistrict
        TxtPostalCode.Text = address.DataPostalCode
        TxtPhone.Text = address.DataPhone
        TxtLastUpdate.Text = address.DataLastUpdate
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
