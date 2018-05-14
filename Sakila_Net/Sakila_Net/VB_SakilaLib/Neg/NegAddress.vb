Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegAddress
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOAddress.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( address as ClAddress) as Boolean
                        Return DAO.DAOAddress.SelectOne(address)     
                    End Function
                    Public  Shared Function crear( address as ClAddress) as Integer
                        Return DAO.DAOAddress.SqlInsert(address)     
                    End Function
                    Public  Shared Function eliminar( address as ClAddress) as Integer
                        Return DAO.DAOAddress.SqlDelete(address)     
                    End Function
                    Public  Shared Function actualizar( address as ClAddress) as Integer
                        Return DAO.DAOAddress.SqlUpdate(address)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
