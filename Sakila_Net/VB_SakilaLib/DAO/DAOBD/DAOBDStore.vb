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

          Public class DAOStore
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from store"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( store as ClStore) as Boolean
             Dim StSql as String = "Select * from store"
            StSql &= " Where  store_id='" & store.dataStoreId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        store.DataManagerStaffId = dt.Rows(0)("manager_staff_id")
        store.DataAddressId = new ClAddress(Integer.Parse(dt.Rows(0)("address_id")))
        store.DataLastUpdate = dt.Rows(0)("last_update").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( store as ClStore)  as Integer
            Dim stSql as String = "insert into Store (" _
                       & " store_id ,manager_staff_id ,address_id ,last_update" _
                           & " )values (" _
            & "'" & store.dataStoreId & "'" _
                     & ",'" & store.dataManagerStaffId & "'" _
                     & ",'" & store.dataAddressId.dataaddressId & "'" _
                     & ",'" & store.dataLastUpdate & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( store as ClStore) as Integer
            
            Dim stSql as String =  "delete from Store " _
             & " Where  store_id='" & store.dataStoreId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(store as ClStore) as Integer
            Dim stSql as String =  "update Store SET " _
             & " manager_staff_id = '" & store.DataManagerStaffId & "'" _
                             & ",address_id = '" & store.DataAddressId.DataAddressId & "'" _
                             & ",last_update = '" & store.DataLastUpdate & "'" _
             & " Where  store_id='" & store.dataStoreId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
