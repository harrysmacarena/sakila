Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegLanguage
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOLanguage.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( language as ClLanguage) as Boolean
                        Return DAO.DAOLanguage.SelectOne(language)     
                    End Function
                    Public  Shared Function crear( language as ClLanguage) as Integer
                        Return DAO.DAOLanguage.SqlInsert(language)     
                    End Function
                    Public  Shared Function eliminar( language as ClLanguage) as Integer
                        Return DAO.DAOLanguage.SqlDelete(language)     
                    End Function
                    Public  Shared Function actualizar( language as ClLanguage) as Integer
                        Return DAO.DAOLanguage.SqlUpdate(language)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
