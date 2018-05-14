Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegPayment
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOPayment.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( payment as ClPayment) as Boolean
                        Return DAO.DAOPayment.SelectOne(payment)     
                    End Function
                    Public  Shared Function crear( payment as ClPayment) as Integer
                        Return DAO.DAOPayment.SqlInsert(payment)     
                    End Function
                    Public  Shared Function eliminar( payment as ClPayment) as Integer
                        Return DAO.DAOPayment.SqlDelete(payment)     
                    End Function
                    Public  Shared Function actualizar( payment as ClPayment) as Integer
                        Return DAO.DAOPayment.SqlUpdate(payment)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
