Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmCategoryLsv
    Private Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
        ListarData()
    End Sub


    Private Sub  ListarData()
        Dim dt As DataTable = ClNegCategory.listar(1,100)
        'dgvData.DataSource = dt
        dgvData.Columns.Add("Title", 300, HorizontalAlignment.Left)
        dgvData.Columns.Add("ID", 70, HorizontalAlignment.Left)
        dgvData.Columns.Add("Price", 70, HorizontalAlignment.Left)
        dgvData.Columns.Add("Publi-Date", 100, HorizontalAlignment.Left)
        For Each xrow As DataRow In dt.Rows
            dgvData.Items.Add(xrow("first_name"))
        Next        
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
