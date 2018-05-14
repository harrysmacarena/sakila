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

          Public class DAOFilmCategory
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from filmCategory"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( filmCategory as ClFilmCategory) as Boolean
             Dim StSql as String = "Select * from filmCategory"
            StSql &= " Where  film_id='" & filmCategory.dataFilmId.dataFilmId & "'" _
                           & "   and category_id='" & filmCategory.dataCategoryId.dataCategoryId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        filmCategory.DataLastUpdate = dt.Rows(0)("last_update").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( filmCategory as ClFilmCategory)  as Integer
            Dim stSql as String = "insert into FilmCategory (" _
                       & " film_id ,category_id ,last_update" _
                           & " )values (" _
            & "'" & filmCategory.dataFilmId.datafilmId & "'" _
                     & ",'" & filmCategory.dataCategoryId.datacategoryId & "'" _
                     & ",'" & filmCategory.dataLastUpdate & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( filmCategory as ClFilmCategory) as Integer
            
            Dim stSql as String =  "delete from FilmCategory " _
             & " Where  film_id='" & filmCategory.dataFilmId.dataFilmId & "'" _
                           & "   and category_id='" & filmCategory.dataCategoryId.dataCategoryId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(filmCategory as ClFilmCategory) as Integer
            Dim stSql as String =  "update FilmCategory SET " _
             & " last_update = '" & filmCategory.DataLastUpdate & "'" _
             & " Where  film_id='" & filmCategory.dataFilmId.dataFilmId & "'" _
                           & "   and category_id='" & filmCategory.dataCategoryId.dataCategoryId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
