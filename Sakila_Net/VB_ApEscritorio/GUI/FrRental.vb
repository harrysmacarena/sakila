Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmRental
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Rental")
        Dim rental as ClRental = New ClRental(Integer.Parse(TxtRentalId.Text))
        If (ClNegRental.eliminar(rental)) Then
            MessageBox.Show("Error al Eliminar Registro", "Rental")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "Rental")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Rental")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim rental as ClRental = New ClRental(Integer.Parse(TxtRentalId.Text),TxtRentalDate.Text, New ClInventory(Integer.Parse(TxtinventoryId.Text)), New ClCustomer(Integer.Parse(TxtcustomerId.Text)),TxtReturnDate.Text, New ClStaff(Integer.Parse(TxtstaffId.Text)),TxtLastUpdate.Text)
        If (ClNegRental.actualizar(rental)) Then
            MessageBox.Show("Error al Actualizar Registro", "Rental")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "Rental")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Rental")
        Dim rental as ClRental = New ClRental(Integer.Parse(TxtRentalId.Text))
        If (Not ClNegRental.consultar(rental)) Then
            MessageBox.Show("Error al Leer Registro", "Rental")
            Return
        End If
        TxtRentalDate.Text = rental.DataRentalDate
        TxtReturnDate.Text = rental.DataReturnDate
        TxtLastUpdate.Text = rental.DataLastUpdate
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