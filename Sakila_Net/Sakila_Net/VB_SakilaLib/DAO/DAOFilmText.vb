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

                Public Class DAOFilmText
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOFilmText
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOFilmText.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( filmText as ClFilmText) as Boolean
                        Return DAOBD.DAOFilmText.SelectOne(filmText)     
                    End Function
                    Public Shared  Function SqlInsert( filmText as ClFilmText) as Integer
                        Return DAOBD.DAOFilmText.SqlInsert(filmText)     
                    End Function
                    Public Shared  Function SqlDelete( filmText as ClFilmText) as Integer
                        Return DAOBD.DAOFilmText.SqlDelete(filmText)     
                    End Function
                    Public Shared  Function SqlUpdate( filmText as ClFilmText) as Integer
                        Return DAOBD.DAOFilmText.SqlUpdate(filmText)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
