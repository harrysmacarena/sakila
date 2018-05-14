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

                Public Class DAOInventory
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOInventory
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOInventory.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( inventory as ClInventory) as Boolean
                        Return DAOBD.DAOInventory.SelectOne(inventory)     
                    End Function
                    Public Shared  Function SqlInsert( inventory as ClInventory) as Integer
                        Return DAOBD.DAOInventory.SqlInsert(inventory)     
                    End Function
                    Public Shared  Function SqlDelete( inventory as ClInventory) as Integer
                        Return DAOBD.DAOInventory.SqlDelete(inventory)     
                    End Function
                    Public Shared  Function SqlUpdate( inventory as ClInventory) as Integer
                        Return DAOBD.DAOInventory.SqlUpdate(inventory)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
