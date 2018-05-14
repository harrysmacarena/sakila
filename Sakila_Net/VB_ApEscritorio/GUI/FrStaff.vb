Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmStaff
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Staff")
        Dim staff as ClStaff = New ClStaff(Integer.Parse(TxtStaffId.Text))
        If (ClNegStaff.eliminar(staff)) Then
            MessageBox.Show("Error al Eliminar Registro", "Staff")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "Staff")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Staff")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim staff as ClStaff = New ClStaff(Integer.Parse(TxtStaffId.Text),TxtFirstName.Text,TxtLastName.Text, New ClAddress(Integer.Parse(TxtaddressId.Text)),TxtPicture.Text,TxtEmail.Text, New ClStore(Integer.Parse(TxtstoreId.Text)),Integer.Parse(TxtActive.Text),TxtUsername.Text,TxtPassword.Text,TxtLastUpdate.Text)
        If (ClNegStaff.actualizar(staff)) Then
            MessageBox.Show("Error al Actualizar Registro", "Staff")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "Staff")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Staff")
        Dim staff as ClStaff = New ClStaff(Integer.Parse(TxtStaffId.Text))
        If (Not ClNegStaff.consultar(staff)) Then
            MessageBox.Show("Error al Leer Registro", "Staff")
            Return
        End If
        TxtFirstName.Text = staff.DataFirstName
        TxtLastName.Text = staff.DataLastName
        TxtPicture.Text = staff.DataPicture
        TxtEmail.Text = staff.DataEmail
        TxtActive.Text = staff.DataActive
        TxtUsername.Text = staff.DataUsername
        TxtPassword.Text = staff.DataPassword
        TxtLastUpdate.Text = staff.DataLastUpdate
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
