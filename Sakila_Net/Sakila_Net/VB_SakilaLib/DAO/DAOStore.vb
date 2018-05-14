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

                Public Class DAOStore
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOStore
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOStore.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( store as ClStore) as Boolean
                        Return DAOBD.DAOStore.SelectOne(store)     
                    End Function
                    Public Shared  Function SqlInsert( store as ClStore) as Integer
                        Return DAOBD.DAOStore.SqlInsert(store)     
                    End Function
                    Public Shared  Function SqlDelete( store as ClStore) as Integer
                        Return DAOBD.DAOStore.SqlDelete(store)     
                    End Function
                    Public Shared  Function SqlUpdate( store as ClStore) as Integer
                        Return DAOBD.DAOStore.SqlUpdate(store)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
