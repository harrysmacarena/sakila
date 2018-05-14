'using System;
Imports  System.Data
'using System.Collections.Generic;
'using System.Configuration;
'using System.Collections;
Imports  SakilaLib.Cl.Harrys.Sakila.Model
'using Cl.Harrys.BD;

Namespace Cl
    Namespace Harrys
        Namespace Sakila
            Namespace DAO

                Public Class DAOFilmActor
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOFilmActor
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOFilmActor.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( filmActor as ClFilmActor) as Boolean
                        Return DAOBD.DAOFilmActor.SelectOne(filmActor)     
                    End Function
                    Public Shared  Function SqlInsert( filmActor as ClFilmActor) as Integer
                        Return DAOBD.DAOFilmActor.SqlInsert(filmActor)     
                    End Function
                    Public Shared  Function SqlDelete( filmActor as ClFilmActor) as Integer
                        Return DAOBD.DAOFilmActor.SqlDelete(filmActor)     
                    End Function
                    Public Shared  Function SqlUpdate( filmActor as ClFilmActor) as Integer
                        Return DAOBD.DAOFilmActor.SqlUpdate(filmActor)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
