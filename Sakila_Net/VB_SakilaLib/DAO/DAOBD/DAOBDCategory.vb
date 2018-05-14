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

          Public class DAOCategory
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from category"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( category as ClCategory) as Boolean
             Dim StSql as String = "Select * from category"
            StSql &= " Where  category_id='" & category.dataCategoryId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        category.DataName = dt.Rows(0)("name").ToString()
        category.DataLastUpdate = dt.Rows(0)("last_update").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( category as ClCategory)  as Integer
            Dim stSql as String = "insert into Category (" _
                       & " category_id ,name ,last_update" _
                           & " )values (" _
            & "'" & category.dataCategoryId & "'" _
                     & ",'" & category.dataName & "'" _
                     & ",'" & category.dataLastUpdate & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( category as ClCategory) as Integer
            
            Dim stSql as String =  "delete from Category " _
             & " Where  category_id='" & category.dataCategoryId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(category as ClCategory) as Integer
            Dim stSql as String =  "update Category SET " _
             & " name = '" & category.DataName & "'" _
                             & ",last_update = '" & category.DataLastUpdate & "'" _
             & " Where  category_id='" & category.dataCategoryId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
