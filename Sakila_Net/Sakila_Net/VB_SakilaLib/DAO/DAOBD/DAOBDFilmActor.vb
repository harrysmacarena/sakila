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

          Public class DAOFilmActor
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from filmActor"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( filmActor as ClFilmActor) as Boolean
             Dim StSql as String = "Select * from filmActor"
            StSql &= " Where  actor_id='" & filmActor.dataActorId.dataActorId & "'" _
                           & "   and film_id='" & filmActor.dataFilmId.dataFilmId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        filmActor.DataLastUpdate = dt.Rows(0)("last_update").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( filmActor as ClFilmActor)  as Integer
            Dim stSql as String = "insert into FilmActor (" _
                       & " actor_id ,film_id ,last_update" _
                           & " )values (" _
            & "'" & filmActor.dataActorId.dataactorId & "'" _
                     & ",'" & filmActor.dataFilmId.datafilmId & "'" _
                     & ",'" & filmActor.dataLastUpdate & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( filmActor as ClFilmActor) as Integer
            
            Dim stSql as String =  "delete from FilmActor " _
             & " Where  actor_id='" & filmActor.dataActorId.dataActorId & "'" _
                           & "   and film_id='" & filmActor.dataFilmId.dataFilmId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(filmActor as ClFilmActor) as Integer
            Dim stSql as String =  "update FilmActor SET " _
             & " last_update = '" & filmActor.DataLastUpdate & "'" _
             & " Where  actor_id='" & filmActor.dataActorId.dataActorId & "'" _
                           & "   and film_id='" & filmActor.dataFilmId.dataFilmId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
