Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegCategory
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOCategory.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( category as ClCategory) as Boolean
                        Return DAO.DAOCategory.SelectOne(category)     
                    End Function
                    Public  Shared Function crear( category as ClCategory) as Integer
                        Return DAO.DAOCategory.SqlInsert(category)     
                    End Function
                    Public  Shared Function eliminar( category as ClCategory) as Integer
                        Return DAO.DAOCategory.SqlDelete(category)     
                    End Function
                    Public  Shared Function actualizar( category as ClCategory) as Integer
                        Return DAO.DAOCategory.SqlUpdate(category)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
