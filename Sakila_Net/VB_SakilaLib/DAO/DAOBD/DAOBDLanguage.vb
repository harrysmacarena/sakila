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

          Public class DAOLanguage
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from language"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( language as ClLanguage) as Boolean
             Dim StSql as String = "Select * from language"
            StSql &= " Where  language_id='" & language.dataLanguageId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        language.DataName = dt.Rows(0)("name").ToString()
        language.DataLastUpdate = dt.Rows(0)("last_update").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( language as ClLanguage)  as Integer
            Dim stSql as String = "insert into Language (" _
                       & " language_id ,name ,last_update" _
                           & " )values (" _
            & "'" & language.dataLanguageId & "'" _
                     & ",'" & language.dataName & "'" _
                     & ",'" & language.dataLastUpdate & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( language as ClLanguage) as Integer
            
            Dim stSql as String =  "delete from Language " _
             & " Where  language_id='" & language.dataLanguageId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(language as ClLanguage) as Integer
            Dim stSql as String =  "update Language SET " _
             & " name = '" & language.DataName & "'" _
                             & ",last_update = '" & language.DataLastUpdate & "'" _
             & " Where  language_id='" & language.dataLanguageId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
