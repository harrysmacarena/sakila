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

                Public Class DAOCountry
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOCountry
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOCountry.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( country as ClCountry) as Boolean
                        Return DAOBD.DAOCountry.SelectOne(country)     
                    End Function
                    Public Shared  Function SqlInsert( country as ClCountry) as Integer
                        Return DAOBD.DAOCountry.SqlInsert(country)     
                    End Function
                    Public Shared  Function SqlDelete( country as ClCountry) as Integer
                        Return DAOBD.DAOCountry.SqlDelete(country)     
                    End Function
                    Public Shared  Function SqlUpdate( country as ClCountry) as Integer
                        Return DAOBD.DAOCountry.SqlUpdate(country)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
