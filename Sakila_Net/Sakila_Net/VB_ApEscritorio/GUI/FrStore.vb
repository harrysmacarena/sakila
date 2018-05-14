Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmStore
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Store")
        Dim store as ClStore = New ClStore(Integer.Parse(TxtStoreId.Text))
        If (ClNegStore.eliminar(store)) Then
            MessageBox.Show("Error al Eliminar Registro", "Store")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "Store")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Store")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim store as ClStore = New ClStore(Integer.Parse(TxtStoreId.Text),Integer.Parse(TxtManagerStaffId.Text), New ClAddress(Integer.Parse(TxtaddressId.Text)),TxtLastUpdate.Text)
        If (ClNegStore.actualizar(store)) Then
            MessageBox.Show("Error al Actualizar Registro", "Store")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "Store")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Store")
        Dim store as ClStore = New ClStore(Integer.Parse(TxtStoreId.Text))
        If (Not ClNegStore.consultar(store)) Then
            MessageBox.Show("Error al Leer Registro", "Store")
            Return
        End If
        TxtManagerStaffId.Text = store.DataManagerStaffId
        TxtLastUpdate.Text = store.DataLastUpdate
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
