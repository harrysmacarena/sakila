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

                Public Class DAOCategory
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOCategory
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOCategory.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( category as ClCategory) as Boolean
                        Return DAOBD.DAOCategory.SelectOne(category)     
                    End Function
                    Public Shared  Function SqlInsert( category as ClCategory) as Integer
                        Return DAOBD.DAOCategory.SqlInsert(category)     
                    End Function
                    Public Shared  Function SqlDelete( category as ClCategory) as Integer
                        Return DAOBD.DAOCategory.SqlDelete(category)     
                    End Function
                    Public Shared  Function SqlUpdate( category as ClCategory) as Integer
                        Return DAOBD.DAOCategory.SqlUpdate(category)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
