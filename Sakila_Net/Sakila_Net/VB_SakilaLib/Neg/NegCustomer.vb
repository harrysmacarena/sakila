Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegCustomer
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOCustomer.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( customer as ClCustomer) as Boolean
                        Return DAO.DAOCustomer.SelectOne(customer)     
                    End Function
                    Public  Shared Function crear( customer as ClCustomer) as Integer
                        Return DAO.DAOCustomer.SqlInsert(customer)     
                    End Function
                    Public  Shared Function eliminar( customer as ClCustomer) as Integer
                        Return DAO.DAOCustomer.SqlDelete(customer)     
                    End Function
                    Public  Shared Function actualizar( customer as ClCustomer) as Integer
                        Return DAO.DAOCustomer.SqlUpdate(customer)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
