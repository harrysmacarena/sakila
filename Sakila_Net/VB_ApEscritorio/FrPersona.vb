Public Class FrmCliente
    'Dim p1 As Persona = New Persona(1, "0", "Juan", "Harrys", "Escalante")
    'Dim p2 As Persona = New Persona(2, "1", "Maria", "Harrys", "Escalante")
    'Dim p3 As Persona = New Persona(3, "1", "Hector", "marilax", "escalante")

    Private Sub FrmCliente_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick

        MessageBox.Show("hola Como Estas", "Titulo")

    End Sub

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Agregando", "Persona")



    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
        'FrMenu.Show()
        FrMenu.Visible = True
    End Sub

    Private Sub btAgregar_Click_1(sender As Object, e As EventArgs) Handles btAgregar.Click
    End Sub

    Private Sub btLeer_Click(sender As Object, e As EventArgs) Handles btLeer.Click
        'txtRut.Text = p1.dataRut
        'txtNombres.Text = p1.dataNombres


    End Sub
End Class
