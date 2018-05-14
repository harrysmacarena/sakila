Imports SakilaLib.Cl.Harrys.Sakila.Neg
Imports SakilaLib.Cl.Harrys.Sakila.Model

Public Class FrmAddressLsb
    Private Sub FrmActorLsb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarData()
    End Sub
    Private Sub btListar_Click(sender As Object, e As EventArgs) Handles btListar.Click
         ListarData()
        'ListarDataClass()
    End Sub


    Private Sub  ListarData()

        'dgvData.BeginUpdate()
        'Dim x As Integer
        'For x = 1 To 50
        ''    dgvData.Items.Add("Item " & x.ToString())
        'Next x
        ' Allow the ListBox to repaint and display the new items.
        'dgvData.EndUpdate()

        ' Select three items from the ListBox.
        'dgvData.SetSelected(1, True)
        'dgvData.SetSelected(3, True)
        'dgvData.SetSelected(5, True)
        
          Me.dgvData.DisplayMember = "address"
        Me.dgvData.ValueMember = "address_id"

        Dim dt As DataTable = ClNegAddress.listar(1,100)
        dgvData.DataSource = dt
    End Sub
    Private Sub ListarDataClass()
        Dim dataClass As New ArrayList()
        Dim dt As DataTable = ClNegAddress.listar(1, 100)
        For Each xrow As DataRow In dt.Rows
            dataClass.Add(New ClAddress(
xrow("address_id") _
,xrow("address") _
,xrow("address2") _
,xrow("district") _
,New ClCity(xrow("city_id")) _
,xrow("postal_code") _
,xrow("phone") _
,xrow("last_update") _
                                      ))
        Next
        dgvData.DataSource = dataClass
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
