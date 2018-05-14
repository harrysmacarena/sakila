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

          Public class DAORental
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from rental"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( rental as ClRental) as Boolean
             Dim StSql as String = "Select * from rental"
            StSql &= " Where  rental_id='" & rental.dataRentalId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        rental.DataRentalDate = dt.Rows(0)("rental_date").ToString()
        rental.DataInventoryId = new ClInventory(Integer.Parse(dt.Rows(0)("inventory_id")))
        rental.DataCustomerId = new ClCustomer(Integer.Parse(dt.Rows(0)("customer_id")))
        rental.DataReturnDate = dt.Rows(0)("return_date").ToString()
        rental.DataStaffId = new ClStaff(Integer.Parse(dt.Rows(0)("staff_id")))
        rental.DataLastUpdate = dt.Rows(0)("last_update").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( rental as ClRental)  as Integer
            Dim stSql as String = "insert into Rental (" _
                       & " rental_id ,rental_date ,inventory_id ,customer_id ,return_date ,staff_id ,last_update" _
                           & " )values (" _
            & "'" & rental.dataRentalId & "'" _
                     & ",'" & rental.dataRentalDate & "'" _
                     & ",'" & rental.dataInventoryId.datainventoryId & "'" _
                     & ",'" & rental.dataCustomerId.datacustomerId & "'" _
                     & ",'" & rental.dataReturnDate & "'" _
                     & ",'" & rental.dataStaffId.datastaffId & "'" _
                     & ",'" & rental.dataLastUpdate & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( rental as ClRental) as Integer
            
            Dim stSql as String =  "delete from Rental " _
             & " Where  rental_id='" & rental.dataRentalId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(rental as ClRental) as Integer
            Dim stSql as String =  "update Rental SET " _
             & " rental_date = '" & rental.DataRentalDate & "'" _
                             & ",inventory_id = '" & rental.DataInventoryId.DataInventoryId & "'" _
                             & ",customer_id = '" & rental.DataCustomerId.DataCustomerId & "'" _
                             & ",return_date = '" & rental.DataReturnDate & "'" _
                             & ",staff_id = '" & rental.DataStaffId.DataStaffId & "'" _
                             & ",last_update = '" & rental.DataLastUpdate & "'" _
             & " Where  rental_id='" & rental.dataRentalId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
