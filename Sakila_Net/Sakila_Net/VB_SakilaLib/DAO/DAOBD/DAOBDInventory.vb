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

          Public class DAOInventory
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from inventory"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( inventory as ClInventory) as Boolean
             Dim StSql as String = "Select * from inventory"
            StSql &= " Where  inventory_id='" & inventory.dataInventoryId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        inventory.DataFilmId = new ClFilm(Integer.Parse(dt.Rows(0)("film_id")))
        inventory.DataStoreId = new ClStore(Integer.Parse(dt.Rows(0)("store_id")))
        inventory.DataLastUpdate = dt.Rows(0)("last_update").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( inventory as ClInventory)  as Integer
            Dim stSql as String = "insert into Inventory (" _
                       & " inventory_id ,film_id ,store_id ,last_update" _
                           & " )values (" _
            & "'" & inventory.dataInventoryId & "'" _
                     & ",'" & inventory.dataFilmId.datafilmId & "'" _
                     & ",'" & inventory.dataStoreId.datastoreId & "'" _
                     & ",'" & inventory.dataLastUpdate & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( inventory as ClInventory) as Integer
            
            Dim stSql as String =  "delete from Inventory " _
             & " Where  inventory_id='" & inventory.dataInventoryId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(inventory as ClInventory) as Integer
            Dim stSql as String =  "update Inventory SET " _
             & " film_id = '" & inventory.DataFilmId.DataFilmId & "'" _
                             & ",store_id = '" & inventory.DataStoreId.DataStoreId & "'" _
                             & ",last_update = '" & inventory.DataLastUpdate & "'" _
             & " Where  inventory_id='" & inventory.dataInventoryId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
