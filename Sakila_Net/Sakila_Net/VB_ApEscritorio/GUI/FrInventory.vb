Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmInventory
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Inventory")
        Dim inventory as ClInventory = New ClInventory(Integer.Parse(TxtInventoryId.Text))
        If (ClNegInventory.eliminar(inventory)) Then
            MessageBox.Show("Error al Eliminar Registro", "Inventory")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "Inventory")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Inventory")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim inventory as ClInventory = New ClInventory(Integer.Parse(TxtInventoryId.Text), New ClFilm(Integer.Parse(TxtfilmId.Text)), New ClStore(Integer.Parse(TxtstoreId.Text)),TxtLastUpdate.Text)
        If (ClNegInventory.actualizar(inventory)) Then
            MessageBox.Show("Error al Actualizar Registro", "Inventory")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "Inventory")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Inventory")
        Dim inventory as ClInventory = New ClInventory(Integer.Parse(TxtInventoryId.Text))
        If (Not ClNegInventory.consultar(inventory)) Then
            MessageBox.Show("Error al Leer Registro", "Inventory")
            Return
        End If
        TxtLastUpdate.Text = inventory.DataLastUpdate
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
