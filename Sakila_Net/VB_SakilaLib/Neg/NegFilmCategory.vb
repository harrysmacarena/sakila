Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegFilmCategory
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOFilmCategory.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( filmCategory as ClFilmCategory) as Boolean
                        Return DAO.DAOFilmCategory.SelectOne(filmCategory)     
                    End Function
                    Public  Shared Function crear( filmCategory as ClFilmCategory) as Integer
                        Return DAO.DAOFilmCategory.SqlInsert(filmCategory)     
                    End Function
                    Public  Shared Function eliminar( filmCategory as ClFilmCategory) as Integer
                        Return DAO.DAOFilmCategory.SqlDelete(filmCategory)     
                    End Function
                    Public  Shared Function actualizar( filmCategory as ClFilmCategory) as Integer
                        Return DAO.DAOFilmCategory.SqlUpdate(filmCategory)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
