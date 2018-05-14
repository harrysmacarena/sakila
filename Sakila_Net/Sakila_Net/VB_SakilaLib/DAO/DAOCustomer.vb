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

                Public Class DAOCustomer
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOCustomer
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOCustomer.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( customer as ClCustomer) as Boolean
                        Return DAOBD.DAOCustomer.SelectOne(customer)     
                    End Function
                    Public Shared  Function SqlInsert( customer as ClCustomer) as Integer
                        Return DAOBD.DAOCustomer.SqlInsert(customer)     
                    End Function
                    Public Shared  Function SqlDelete( customer as ClCustomer) as Integer
                        Return DAOBD.DAOCustomer.SqlDelete(customer)     
                    End Function
                    Public Shared  Function SqlUpdate( customer as ClCustomer) as Integer
                        Return DAOBD.DAOCustomer.SqlUpdate(customer)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
