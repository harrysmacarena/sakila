Imports  SakilaLib.Cl.Harrys.Sakila.DAO
Imports  SakilaLib.Cl.Harrys.Sakila.Model
Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace Neg

                Public Class ClNegFilmActor
                    Public Shared Function listar(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAO.DAOFilmActor.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public  Shared Function consultar( filmActor as ClFilmActor) as Boolean
                        Return DAO.DAOFilmActor.SelectOne(filmActor)     
                    End Function
                    Public  Shared Function crear( filmActor as ClFilmActor) as Integer
                        Return DAO.DAOFilmActor.SqlInsert(filmActor)     
                    End Function
                    Public  Shared Function eliminar( filmActor as ClFilmActor) as Integer
                        Return DAO.DAOFilmActor.SqlDelete(filmActor)     
                    End Function
                    Public  Shared Function actualizar( filmActor as ClFilmActor) as Integer
                        Return DAO.DAOFilmActor.SqlUpdate(filmActor)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
