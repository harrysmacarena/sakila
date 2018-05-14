Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmCustomer
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Customer")
        Dim customer as ClCustomer = New ClCustomer(Integer.Parse(TxtCustomerId.Text))
        If (ClNegCustomer.eliminar(customer)) Then
            MessageBox.Show("Error al Eliminar Registro", "Customer")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "Customer")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Customer")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim customer as ClCustomer = New ClCustomer(Integer.Parse(TxtCustomerId.Text), New ClStore(Integer.Parse(TxtstoreId.Text)),TxtFirstName.Text,TxtLastName.Text,TxtEmail.Text, New ClAddress(Integer.Parse(TxtaddressId.Text)),Integer.Parse(TxtActive.Text),TxtCreateDate.Text,TxtLastUpdate.Text)
        If (ClNegCustomer.actualizar(customer)) Then
            MessageBox.Show("Error al Actualizar Registro", "Customer")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "Customer")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Customer")
        Dim customer as ClCustomer = New ClCustomer(Integer.Parse(TxtCustomerId.Text))
        If (Not ClNegCustomer.consultar(customer)) Then
            MessageBox.Show("Error al Leer Registro", "Customer")
            Return
        End If
        TxtFirstName.Text = customer.DataFirstName
        TxtLastName.Text = customer.DataLastName
        TxtEmail.Text = customer.DataEmail
        TxtActive.Text = customer.DataActive
        TxtCreateDate.Text = customer.DataCreateDate
        TxtLastUpdate.Text = customer.DataLastUpdate
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
