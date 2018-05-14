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

          Public class DAOTrensito
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from trensito"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( trensito as ClTrensito) as Boolean
             Dim StSql as String = "Select * from trensito"
            StSql &= " Where  Id='" & trensito.dataId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        trensito.DataNombre = dt.Rows(0)("nombre").ToString()
        trensito.DataLargo = dt.Rows(0)("largo")
        trensito.DataIdMarca = dt.Rows(0)("idMarca")
                        Return True
                     end Function

        Public  Shared Function SqlInsert( trensito as ClTrensito)  as Integer
            Dim stSql as String = "insert into Trensito (" _
                       & " Id ,nombre ,largo ,idMarca" _
                           & " )values (" _
            & "'" & trensito.dataId & "'" _
                     & ",'" & trensito.dataNombre & "'" _
                     & ",'" & trensito.dataLargo & "'" _
                     & ",'" & trensito.dataIdMarca & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( trensito as ClTrensito) as Integer
            
            Dim stSql as String =  "delete from Trensito " _
             & " Where  Id='" & trensito.dataId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(trensito as ClTrensito) as Integer
            Dim stSql as String =  "update Trensito SET " _
             & " nombre = '" & trensito.DataNombre & "'" _
                             & ",largo = '" & trensito.DataLargo & "'" _
                             & ",idMarca = '" & trensito.DataIdMarca & "'" _
             & " Where  Id='" & trensito.dataId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
