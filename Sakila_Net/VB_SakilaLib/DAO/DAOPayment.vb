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

                Public Class DAOPayment
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOPayment
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOPayment.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( payment as ClPayment) as Boolean
                        Return DAOBD.DAOPayment.SelectOne(payment)     
                    End Function
                    Public Shared  Function SqlInsert( payment as ClPayment) as Integer
                        Return DAOBD.DAOPayment.SqlInsert(payment)     
                    End Function
                    Public Shared  Function SqlDelete( payment as ClPayment) as Integer
                        Return DAOBD.DAOPayment.SqlDelete(payment)     
                    End Function
                    Public Shared  Function SqlUpdate( payment as ClPayment) as Integer
                        Return DAOBD.DAOPayment.SqlUpdate(payment)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
