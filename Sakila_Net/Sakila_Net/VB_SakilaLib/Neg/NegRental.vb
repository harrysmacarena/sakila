Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegRental
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAORental.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( rental as ClRental) as Boolean
                        Return DAO.DAORental.SelectOne(rental)     
                    End Function
                    Public  Shared Function crear( rental as ClRental) as Integer
                        Return DAO.DAORental.SqlInsert(rental)     
                    End Function
                    Public  Shared Function eliminar( rental as ClRental) as Integer
                        Return DAO.DAORental.SqlDelete(rental)     
                    End Function
                    Public  Shared Function actualizar( rental as ClRental) as Integer
                        Return DAO.DAORental.SqlUpdate(rental)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
