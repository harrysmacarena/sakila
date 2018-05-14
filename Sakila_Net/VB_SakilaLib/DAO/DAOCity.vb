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

                Public Class DAOCity
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOCity
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOCity.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( city as ClCity) as Boolean
                        Return DAOBD.DAOCity.SelectOne(city)     
                    End Function
                    Public Shared  Function SqlInsert( city as ClCity) as Integer
                        Return DAOBD.DAOCity.SqlInsert(city)     
                    End Function
                    Public Shared  Function SqlDelete( city as ClCity) as Integer
                        Return DAOBD.DAOCity.SqlDelete(city)     
                    End Function
                    Public Shared  Function SqlUpdate( city as ClCity) as Integer
                        Return DAOBD.DAOCity.SqlUpdate(city)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
