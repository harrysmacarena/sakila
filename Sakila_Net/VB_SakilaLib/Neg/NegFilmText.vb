Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegFilmText
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOFilmText.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( filmText as ClFilmText) as Boolean
                        Return DAO.DAOFilmText.SelectOne(filmText)     
                    End Function
                    Public  Shared Function crear( filmText as ClFilmText) as Integer
                        Return DAO.DAOFilmText.SqlInsert(filmText)     
                    End Function
                    Public  Shared Function eliminar( filmText as ClFilmText) as Integer
                        Return DAO.DAOFilmText.SqlDelete(filmText)     
                    End Function
                    Public  Shared Function actualizar( filmText as ClFilmText) as Integer
                        Return DAO.DAOFilmText.SqlUpdate(filmText)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
