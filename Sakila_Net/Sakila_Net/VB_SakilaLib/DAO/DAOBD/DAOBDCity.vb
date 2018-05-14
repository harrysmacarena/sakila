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

          Public class DAOCity
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from city"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( city as ClCity) as Boolean
             Dim StSql as String = "Select * from city"
            StSql &= " Where  city_id='" & city.dataCityId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        city.DataCity = dt.Rows(0)("city").ToString()
        city.DataCountryId = new ClCountry(Integer.Parse(dt.Rows(0)("country_id")))
        city.DataLastUpdate = dt.Rows(0)("last_update").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( city as ClCity)  as Integer
            Dim stSql as String = "insert into City (" _
                       & " city_id ,city ,country_id ,last_update" _
                           & " )values (" _
            & "'" & city.dataCityId & "'" _
                     & ",'" & city.dataCity & "'" _
                     & ",'" & city.dataCountryId.datacountryId & "'" _
                     & ",'" & city.dataLastUpdate & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( city as ClCity) as Integer
            
            Dim stSql as String =  "delete from City " _
             & " Where  city_id='" & city.dataCityId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(city as ClCity) as Integer
            Dim stSql as String =  "update City SET " _
             & " city = '" & city.DataCity & "'" _
                             & ",country_id = '" & city.DataCountryId.DataCountryId & "'" _
                             & ",last_update = '" & city.DataLastUpdate & "'" _
             & " Where  city_id='" & city.dataCityId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
