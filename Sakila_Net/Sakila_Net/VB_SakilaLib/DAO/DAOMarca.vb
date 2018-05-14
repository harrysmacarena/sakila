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

                Public Class DAOMarca
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOMarca
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOMarca.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( marca as ClMarca) as Boolean
                        Return DAOBD.DAOMarca.SelectOne(marca)     
                    End Function
                    Public Shared  Function SqlInsert( marca as ClMarca) as Integer
                        Return DAOBD.DAOMarca.SqlInsert(marca)     
                    End Function
                    Public Shared  Function SqlDelete( marca as ClMarca) as Integer
                        Return DAOBD.DAOMarca.SqlDelete(marca)     
                    End Function
                    Public Shared  Function SqlUpdate( marca as ClMarca) as Integer
                        Return DAOBD.DAOMarca.SqlUpdate(marca)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
