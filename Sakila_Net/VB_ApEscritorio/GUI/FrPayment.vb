Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmPayment
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Payment")
        Dim payment as ClPayment = New ClPayment(Integer.Parse(TxtPaymentId.Text))
        If (ClNegPayment.eliminar(payment)) Then
            MessageBox.Show("Error al Eliminar Registro", "Payment")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "Payment")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Payment")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim payment as ClPayment = New ClPayment(Integer.Parse(TxtPaymentId.Text), New ClCustomer(Integer.Parse(TxtcustomerId.Text)), New ClStaff(Integer.Parse(TxtstaffId.Text)), New ClRental(Integer.Parse(TxtrentalId.Text)),Integer.Parse(TxtAmount.Text),TxtPaymentDate.Text,TxtLastUpdate.Text)
        If (ClNegPayment.actualizar(payment)) Then
            MessageBox.Show("Error al Actualizar Registro", "Payment")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "Payment")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Payment")
        Dim payment as ClPayment = New ClPayment(Integer.Parse(TxtPaymentId.Text))
        If (Not ClNegPayment.consultar(payment)) Then
            MessageBox.Show("Error al Leer Registro", "Payment")
            Return
        End If
        TxtAmount.Text = payment.DataAmount
        TxtPaymentDate.Text = payment.DataPaymentDate
        TxtLastUpdate.Text = payment.DataLastUpdate
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
