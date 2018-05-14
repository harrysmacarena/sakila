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

          Public class DAOFilm
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from film"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( film as ClFilm) as Boolean
             Dim StSql as String = "Select * from film"
            StSql &= " Where  film_id='" & film.dataFilmId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        film.DataTitle = dt.Rows(0)("title").ToString()
        film.DataDescription = dt.Rows(0)("description").ToString()
        film.DataReleaseYear = dt.Rows(0)("release_year")
        film.DataLanguageId = new ClLanguage(Integer.Parse(dt.Rows(0)("language_id")))
        film.DataOriginalLanguageId = dt.Rows(0)("original_language_id")
        film.DataRentalDuration = dt.Rows(0)("rental_duration")
        film.DataRentalRate = dt.Rows(0)("rental_rate")
        film.DataLength = dt.Rows(0)("length")
        film.DataReplacementCost = dt.Rows(0)("replacement_cost")
        film.DataRating = dt.Rows(0)("rating").ToString()
        film.DataSpecialFeatures = dt.Rows(0)("special_features").ToString()
        film.DataLastUpdate = dt.Rows(0)("last_update").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( film as ClFilm)  as Integer
            Dim stSql as String = "insert into Film (" _
                       & " film_id ,title ,description ,release_year ,language_id ,original_language_id ,rental_duration ,rental_rate ,length ,replacement_cost ,rating ,special_features ,last_update" _
                           & " )values (" _
            & "'" & film.dataFilmId & "'" _
                     & ",'" & film.dataTitle & "'" _
                     & ",'" & film.dataDescription & "'" _
                     & ",'" & film.dataReleaseYear & "'" _
                     & ",'" & film.dataLanguageId.datalanguageId & "'" _
                     & ",'" & film.dataOriginalLanguageId & "'" _
                     & ",'" & film.dataRentalDuration & "'" _
                     & ",'" & film.dataRentalRate & "'" _
                     & ",'" & film.dataLength & "'" _
                     & ",'" & film.dataReplacementCost & "'" _
                     & ",'" & film.dataRating & "'" _
                     & ",'" & film.dataSpecialFeatures & "'" _
                     & ",'" & film.dataLastUpdate & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( film as ClFilm) as Integer
            
            Dim stSql as String =  "delete from Film " _
             & " Where  film_id='" & film.dataFilmId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(film as ClFilm) as Integer
            Dim stSql as String =  "update Film SET " _
             & " title = '" & film.DataTitle & "'" _
                             & ",description = '" & film.DataDescription & "'" _
                             & ",release_year = '" & film.DataReleaseYear & "'" _
                             & ",language_id = '" & film.DataLanguageId.DataLanguageId & "'" _
                             & ",original_language_id = '" & film.DataOriginalLanguageId & "'" _
                             & ",rental_duration = '" & film.DataRentalDuration & "'" _
                             & ",rental_rate = '" & film.DataRentalRate & "'" _
                             & ",length = '" & film.DataLength & "'" _
                             & ",replacement_cost = '" & film.DataReplacementCost & "'" _
                             & ",rating = '" & film.DataRating & "'" _
                             & ",special_features = '" & film.DataSpecialFeatures & "'" _
                             & ",last_update = '" & film.DataLastUpdate & "'" _
             & " Where  film_id='" & film.dataFilmId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
