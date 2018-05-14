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

          Public class DAOMarca
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from marca"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( marca as ClMarca) as Boolean
             Dim StSql as String = "Select * from marca"
            StSql &= " Where  Id='" & marca.dataId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        marca.DataNombre = dt.Rows(0)("nombre").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( marca as ClMarca)  as Integer
            Dim stSql as String = "insert into Marca (" _
                       & " Id ,nombre" _
                           & " )values (" _
            & "'" & marca.dataId & "'" _
                     & ",'" & marca.dataNombre & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( marca as ClMarca) as Integer
            
            Dim stSql as String =  "delete from Marca " _
             & " Where  Id='" & marca.dataId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(marca as ClMarca) as Integer
            Dim stSql as String =  "update Marca SET " _
             & " nombre = '" & marca.DataNombre & "'" _
             & " Where  Id='" & marca.dataId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
