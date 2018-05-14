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

                Public Class DAOFilm
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOFilm
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOFilm.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( film as ClFilm) as Boolean
                        Return DAOBD.DAOFilm.SelectOne(film)     
                    End Function
                    Public Shared  Function SqlInsert( film as ClFilm) as Integer
                        Return DAOBD.DAOFilm.SqlInsert(film)     
                    End Function
                    Public Shared  Function SqlDelete( film as ClFilm) as Integer
                        Return DAOBD.DAOFilm.SqlDelete(film)     
                    End Function
                    Public Shared  Function SqlUpdate( film as ClFilm) as Integer
                        Return DAOBD.DAOFilm.SqlUpdate(film)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
