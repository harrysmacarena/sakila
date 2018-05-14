Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmTrensito
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Trensito")
        Dim trensito as ClTrensito = New ClTrensito(Integer.Parse(TxtId.Text))
        If (ClNegTrensito.eliminar(trensito)) Then
            MessageBox.Show("Error al Eliminar Registro", "Trensito")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "Trensito")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Trensito")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim trensito as ClTrensito = New ClTrensito(Integer.Parse(TxtId.Text),TxtNombre.Text,Integer.Parse(TxtLargo.Text),Integer.Parse(TxtIdMarca.Text))
        If (ClNegTrensito.actualizar(trensito)) Then
            MessageBox.Show("Error al Actualizar Registro", "Trensito")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "Trensito")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Trensito")
        Dim trensito as ClTrensito = New ClTrensito(Integer.Parse(TxtId.Text))
        If (Not ClNegTrensito.consultar(trensito)) Then
            MessageBox.Show("Error al Leer Registro", "Trensito")
            Return
        End If
        TxtNombre.Text = trensito.DataNombre
        TxtLargo.Text = trensito.DataLargo
        TxtIdMarca.Text = trensito.DataIdMarca
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
