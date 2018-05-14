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

                Public Class DAORental
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAORental
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAORental.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( rental as ClRental) as Boolean
                        Return DAOBD.DAORental.SelectOne(rental)     
                    End Function
                    Public Shared  Function SqlInsert( rental as ClRental) as Integer
                        Return DAOBD.DAORental.SqlInsert(rental)     
                    End Function
                    Public Shared  Function SqlDelete( rental as ClRental) as Integer
                        Return DAOBD.DAORental.SqlDelete(rental)     
                    End Function
                    Public Shared  Function SqlUpdate( rental as ClRental) as Integer
                        Return DAOBD.DAORental.SqlUpdate(rental)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
