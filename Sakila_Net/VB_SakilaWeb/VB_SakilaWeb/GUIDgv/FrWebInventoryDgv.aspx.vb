Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.Sakila.Neg

Public Class FrWebInventoryDgv
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarData()
    End Sub
    Private Sub btLeer_Click(sender As Object, e As EventArgs) Handles btLeer.Click
        ListarData()
    End Sub


    Private Sub  ListarData()
        Dim dt As DataTable = ClNegInventory.listar(1,100)
        GdData.DataSource = dt
        GdData.DataBind()
    End Sub
End Class
