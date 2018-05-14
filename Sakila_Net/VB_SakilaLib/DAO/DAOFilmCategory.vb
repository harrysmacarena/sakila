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

                Public Class DAOFilmCategory
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOFilmCategory
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOFilmCategory.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( filmCategory as ClFilmCategory) as Boolean
                        Return DAOBD.DAOFilmCategory.SelectOne(filmCategory)     
                    End Function
                    Public Shared  Function SqlInsert( filmCategory as ClFilmCategory) as Integer
                        Return DAOBD.DAOFilmCategory.SqlInsert(filmCategory)     
                    End Function
                    Public Shared  Function SqlDelete( filmCategory as ClFilmCategory) as Integer
                        Return DAOBD.DAOFilmCategory.SqlDelete(filmCategory)     
                    End Function
                    Public Shared  Function SqlUpdate( filmCategory as ClFilmCategory) as Integer
                        Return DAOBD.DAOFilmCategory.SqlUpdate(filmCategory)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
