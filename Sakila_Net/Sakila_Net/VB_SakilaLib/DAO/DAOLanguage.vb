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

                Public Class DAOLanguage
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOLanguage
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOLanguage.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( language as ClLanguage) as Boolean
                        Return DAOBD.DAOLanguage.SelectOne(language)     
                    End Function
                    Public Shared  Function SqlInsert( language as ClLanguage) as Integer
                        Return DAOBD.DAOLanguage.SqlInsert(language)     
                    End Function
                    Public Shared  Function SqlDelete( language as ClLanguage) as Integer
                        Return DAOBD.DAOLanguage.SqlDelete(language)     
                    End Function
                    Public Shared  Function SqlUpdate( language as ClLanguage) as Integer
                        Return DAOBD.DAOLanguage.SqlUpdate(language)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
