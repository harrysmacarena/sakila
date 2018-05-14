Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmActor
    Private Sub btEliminar_Click(sender as Object, e as EventArgs) Handles btEliminar.Click
        'MessageBox.Show("Eliminando", "Actor")
        Dim actor as ClActor = New ClActor(Integer.Parse(TxtActorId.Text))
        If (ClNegActor.eliminar(actor)) Then
            MessageBox.Show("Error al Eliminar Registro", "Actor")
            Return
        End If
        MessageBox.Show("Registro Eliminado", "Actor")
        fuCancelar()
    End Sub
    Private Sub btActualizar_Click(sender as Object, e as EventArgs) Handles btActualizar.Click
        'MessageBox.Show("Actualizando", "Actor")
        'if (ExistCamObl(jpaDt,2)) return false
        Dim actor as ClActor = New ClActor(Integer.Parse(TxtActorId.Text),TxtFirstName.Text,TxtLastName.Text,TxtLastUpdate.Text)
        If (ClNegActor.actualizar(actor)) Then
            MessageBox.Show("Error al Actualizar Registro", "Actor")
            Return
        End If
        MessageBox.Show("Registro Actualizar", "Actor")
        fuCancelar()
    End Sub
    Private Sub btLeer_Click(sender as Object, e as EventArgs) Handles btLeer.Click
        'MessageBox.Show("Leer", "Actor")
        Dim actor as ClActor = New ClActor(Integer.Parse(TxtActorId.Text))
        If (Not ClNegActor.consultar(actor)) Then
            MessageBox.Show("Error al Leer Registro", "Actor")
            Return
        End If
        TxtFirstName.Text = actor.DataFirstName
        TxtLastName.Text = actor.DataLastName
        TxtLastUpdate.Text = actor.DataLastUpdate
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
