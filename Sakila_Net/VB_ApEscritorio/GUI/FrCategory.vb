Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmCategory
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Category")
        Dim category as ClCategory = New ClCategory(Integer.Parse(TxtCategoryId.Text))
        If (ClNegCategory.eliminar(category)) Then
            MessageBox.Show("Error al Eliminar Registro", "Category")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "Category")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Category")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim category as ClCategory = New ClCategory(Integer.Parse(TxtCategoryId.Text),TxtName.Text,TxtLastUpdate.Text)
        If (ClNegCategory.actualizar(category)) Then
            MessageBox.Show("Error al Actualizar Registro", "Category")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "Category")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Category")
        Dim category as ClCategory = New ClCategory(Integer.Parse(TxtCategoryId.Text))
        If (Not ClNegCategory.consultar(category)) Then
            MessageBox.Show("Error al Leer Registro", "Category")
            Return
        End If
        TxtName.Text = category.DataName
        TxtLastUpdate.Text = category.DataLastUpdate
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
