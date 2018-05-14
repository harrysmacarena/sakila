Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegFilm
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOFilm.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( film as ClFilm) as Boolean
                        Return DAO.DAOFilm.SelectOne(film)     
                    End Function
                    Public  Shared Function crear( film as ClFilm) as Integer
                        Return DAO.DAOFilm.SqlInsert(film)     
                    End Function
                    Public  Shared Function eliminar( film as ClFilm) as Integer
                        Return DAO.DAOFilm.SqlDelete(film)     
                    End Function
                    Public  Shared Function actualizar( film as ClFilm) as Integer
                        Return DAO.DAOFilm.SqlUpdate(film)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
