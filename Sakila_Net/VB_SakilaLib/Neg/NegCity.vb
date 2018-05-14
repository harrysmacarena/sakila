Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegCity
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOCity.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( city as ClCity) as Boolean
                        Return DAO.DAOCity.SelectOne(city)     
                    End Function
                    Public  Shared Function crear( city as ClCity) as Integer
                        Return DAO.DAOCity.SqlInsert(city)     
                    End Function
                    Public  Shared Function eliminar( city as ClCity) as Integer
                        Return DAO.DAOCity.SqlDelete(city)     
                    End Function
                    Public  Shared Function actualizar( city as ClCity) as Integer
                        Return DAO.DAOCity.SqlUpdate(city)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
