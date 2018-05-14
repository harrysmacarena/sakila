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

          Public class DAOCountry
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from country"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( country as ClCountry) as Boolean
             Dim StSql as String = "Select * from country"
            StSql &= " Where  country_id='" & country.dataCountryId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        country.DataCountry = dt.Rows(0)("country").ToString()
        country.DataLastUpdate = dt.Rows(0)("last_update").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( country as ClCountry)  as Integer
            Dim stSql as String = "insert into Country (" _
                       & " country_id ,country ,last_update" _
                           & " )values (" _
            & "'" & country.dataCountryId & "'" _
                     & ",'" & country.dataCountry & "'" _
                     & ",'" & country.dataLastUpdate & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( country as ClCountry) as Integer
            
            Dim stSql as String =  "delete from Country " _
             & " Where  country_id='" & country.dataCountryId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(country as ClCountry) as Integer
            Dim stSql as String =  "update Country SET " _
             & " country = '" & country.DataCountry & "'" _
                             & ",last_update = '" & country.DataLastUpdate & "'" _
             & " Where  country_id='" & country.dataCountryId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
