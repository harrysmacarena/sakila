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

                Public Class DAOActor
                    'Inherits SakilaLib.Cl.Harrys.Sakila.DAOBD.DAOActor
                    Public Shared  Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                        Return DAOBD.DAOActor.SelectAll(nPagina, cantidad)	   
                    End Function
                    Public Shared  Function SelectOne( actor as ClActor) as Boolean
                        Return DAOBD.DAOActor.SelectOne(actor)     
                    End Function
                    Public Shared  Function SqlInsert( actor as ClActor) as Integer
                        Return DAOBD.DAOActor.SqlInsert(actor)     
                    End Function
                    Public Shared  Function SqlDelete( actor as ClActor) as Integer
                        Return DAOBD.DAOActor.SqlDelete(actor)     
                    End Function
                    Public Shared  Function SqlUpdate( actor as ClActor) as Integer
                        Return DAOBD.DAOActor.SqlUpdate(actor)     
                    End Function
                End Class

            End Namespace  
        End Namespace  
    End Namespace  
End Namespace  
