'using System;
Imports  System.Data
'using System.Collections.Generic;
'using System.Configuration;
'using System.Collections;
Imports SakilaLib.Cl.Harrys.Sakila.Model
Imports SakilaLib.Cl.Harrys.BD


Namespace Cl
  Namespace Harrys
    Namespace Sakila
       Namespace DAOBD

          Public class DAOActor
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from actor"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( actor as ClActor) as Boolean
             Dim StSql as String = "Select * from actor"
            StSql &= " Where  actor_id='" & actor.dataActorId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        actor.DataFirstName = dt.Rows(0)("first_name").ToString()
        actor.DataLastName = dt.Rows(0)("last_name").ToString()
        actor.DataLastUpdate = dt.Rows(0)("last_update").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( actor as ClActor)  as Integer
            Dim stSql as String = "insert into Actor (" _
                       & " actor_id ,first_name ,last_name ,last_update" _
                           & " )values (" _
            & "'" & actor.dataActorId & "'" _
                     & ",'" & actor.dataFirstName & "'" _
                     & ",'" & actor.dataLastName & "'" _
                     & ",'" & actor.dataLastUpdate & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( actor as ClActor) as Integer
            
            Dim stSql as String =  "delete from Actor " _
             & " Where  actor_id='" & actor.dataActorId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(actor as ClActor) as Integer
            Dim stSql as String =  "update Actor SET " _
             & " first_name = '" & actor.DataFirstName & "'" _
                             & ",last_name = '" & actor.DataLastName & "'" _
                             & ",last_update = '" & actor.DataLastUpdate & "'" _
             & " Where  actor_id='" & actor.dataActorId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
