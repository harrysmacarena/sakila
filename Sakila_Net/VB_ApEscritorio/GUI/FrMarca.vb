Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmMarca
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Marca")
        Dim marca as ClMarca = New ClMarca(Integer.Parse(TxtId.Text))
        If (ClNegMarca.eliminar(marca)) Then
            MessageBox.Show("Error al Eliminar Registro", "Marca")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "Marca")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Marca")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim marca as ClMarca = New ClMarca(Integer.Parse(TxtId.Text),TxtNombre.Text)
        If (ClNegMarca.actualizar(marca)) Then
            MessageBox.Show("Error al Actualizar Registro", "Marca")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "Marca")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Marca")
        Dim marca as ClMarca = New ClMarca(Integer.Parse(TxtId.Text))
        If (Not ClNegMarca.consultar(marca)) Then
            MessageBox.Show("Error al Leer Registro", "Marca")
            Return
        End If
        TxtNombre.Text = marca.DataNombre
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
