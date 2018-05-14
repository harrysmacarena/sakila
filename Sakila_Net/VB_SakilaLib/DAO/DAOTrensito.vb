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

                Public Class DAOTrensito
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOTrensito
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOTrensito.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( trensito as ClTrensito) as Boolean
                        Return DAOBD.DAOTrensito.SelectOne(trensito)     
                    End Function
                    Public Shared  Function SqlInsert( trensito as ClTrensito) as Integer
                        Return DAOBD.DAOTrensito.SqlInsert(trensito)     
                    End Function
                    Public Shared  Function SqlDelete( trensito as ClTrensito) as Integer
                        Return DAOBD.DAOTrensito.SqlDelete(trensito)     
                    End Function
                    Public Shared  Function SqlUpdate( trensito as ClTrensito) as Integer
                        Return DAOBD.DAOTrensito.SqlUpdate(trensito)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
