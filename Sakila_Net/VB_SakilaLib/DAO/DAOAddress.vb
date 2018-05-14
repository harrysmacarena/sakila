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

                Public Class DAOAddress
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOAddress
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOAddress.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( address as ClAddress) as Boolean
                        Return DAOBD.DAOAddress.SelectOne(address)     
                    End Function
                    Public Shared  Function SqlInsert( address as ClAddress) as Integer
                        Return DAOBD.DAOAddress.SqlInsert(address)     
                    End Function
                    Public Shared  Function SqlDelete( address as ClAddress) as Integer
                        Return DAOBD.DAOAddress.SqlDelete(address)     
                    End Function
                    Public Shared  Function SqlUpdate( address as ClAddress) as Integer
                        Return DAOBD.DAOAddress.SqlUpdate(address)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
