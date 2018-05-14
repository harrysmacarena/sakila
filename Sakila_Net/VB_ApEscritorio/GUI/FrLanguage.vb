Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmLanguage
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Language")
        Dim language as ClLanguage = New ClLanguage(Integer.Parse(TxtLanguageId.Text))
        If (ClNegLanguage.eliminar(language)) Then
            MessageBox.Show("Error al Eliminar Registro", "Language")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "Language")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Language")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim language as ClLanguage = New ClLanguage(Integer.Parse(TxtLanguageId.Text),TxtName.Text,TxtLastUpdate.Text)
        If (ClNegLanguage.actualizar(language)) Then
            MessageBox.Show("Error al Actualizar Registro", "Language")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "Language")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Language")
        Dim language as ClLanguage = New ClLanguage(Integer.Parse(TxtLanguageId.Text))
        If (Not ClNegLanguage.consultar(language)) Then
            MessageBox.Show("Error al Leer Registro", "Language")
            Return
        End If
        TxtName.Text = language.DataName
        TxtLastUpdate.Text = language.DataLastUpdate
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
