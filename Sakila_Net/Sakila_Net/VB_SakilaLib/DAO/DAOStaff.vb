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

                Public Class DAOStaff
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOStaff
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOStaff.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( staff as ClStaff) as Boolean
                        Return DAOBD.DAOStaff.SelectOne(staff)     
                    End Function
                    Public Shared  Function SqlInsert( staff as ClStaff) as Integer
                        Return DAOBD.DAOStaff.SqlInsert(staff)     
                    End Function
                    Public Shared  Function SqlDelete( staff as ClStaff) as Integer
                        Return DAOBD.DAOStaff.SqlDelete(staff)     
                    End Function
                    Public Shared  Function SqlUpdate( staff as ClStaff) as Integer
                        Return DAOBD.DAOStaff.SqlUpdate(staff)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
