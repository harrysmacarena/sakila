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

          Public class DAOFilmText
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from filmText"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( filmText as ClFilmText) as Boolean
             Dim StSql as String = "Select * from filmText"
            StSql &= " Where  film_id='" & filmText.dataFilmId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        filmText.DataTitle = dt.Rows(0)("title").ToString()
        filmText.DataDescription = dt.Rows(0)("description").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( filmText as ClFilmText)  as Integer
            Dim stSql as String = "insert into FilmText (" _
                       & " film_id ,title ,description" _
                           & " )values (" _
            & "'" & filmText.dataFilmId & "'" _
                     & ",'" & filmText.dataTitle & "'" _
                     & ",'" & filmText.dataDescription & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( filmText as ClFilmText) as Integer
            
            Dim stSql as String =  "delete from FilmText " _
             & " Where  film_id='" & filmText.dataFilmId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(filmText as ClFilmText) as Integer
            Dim stSql as String =  "update FilmText SET " _
             & " title = '" & filmText.DataTitle & "'" _
                             & ",description = '" & filmText.DataDescription & "'" _
             & " Where  film_id='" & filmText.dataFilmId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
