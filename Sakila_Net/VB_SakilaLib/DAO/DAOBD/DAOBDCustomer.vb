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

          Public class DAOCustomer
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from customer"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( customer as ClCustomer) as Boolean
             Dim StSql as String = "Select * from customer"
            StSql &= " Where  customer_id='" & customer.dataCustomerId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        customer.DataStoreId = new ClStore(Integer.Parse(dt.Rows(0)("store_id")))
        customer.DataFirstName = dt.Rows(0)("first_name").ToString()
        customer.DataLastName = dt.Rows(0)("last_name").ToString()
        customer.DataEmail = dt.Rows(0)("email").ToString()
        customer.DataAddressId = new ClAddress(Integer.Parse(dt.Rows(0)("address_id")))
        customer.DataActive = dt.Rows(0)("active")
        customer.DataCreateDate = dt.Rows(0)("create_date").ToString()
        customer.DataLastUpdate = dt.Rows(0)("last_update").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( customer as ClCustomer)  as Integer
            Dim stSql as String = "insert into Customer (" _
                       & " customer_id ,store_id ,first_name ,last_name ,email ,address_id ,active ,create_date ,last_update" _
                           & " )values (" _
            & "'" & customer.dataCustomerId & "'" _
                     & ",'" & customer.dataStoreId.datastoreId & "'" _
                     & ",'" & customer.dataFirstName & "'" _
                     & ",'" & customer.dataLastName & "'" _
                     & ",'" & customer.dataEmail & "'" _
                     & ",'" & customer.dataAddressId.dataaddressId & "'" _
                     & ",'" & customer.dataActive & "'" _
                     & ",'" & customer.dataCreateDate & "'" _
                     & ",'" & customer.dataLastUpdate & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( customer as ClCustomer) as Integer
            
            Dim stSql as String =  "delete from Customer " _
             & " Where  customer_id='" & customer.dataCustomerId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(customer as ClCustomer) as Integer
            Dim stSql as String =  "update Customer SET " _
             & " store_id = '" & customer.DataStoreId.DataStoreId & "'" _
                             & ",first_name = '" & customer.DataFirstName & "'" _
                             & ",last_name = '" & customer.DataLastName & "'" _
                             & ",email = '" & customer.DataEmail & "'" _
                             & ",address_id = '" & customer.DataAddressId.DataAddressId & "'" _
                             & ",active = '" & customer.DataActive & "'" _
                             & ",create_date = '" & customer.DataCreateDate & "'" _
                             & ",last_update = '" & customer.DataLastUpdate & "'" _
             & " Where  customer_id='" & customer.dataCustomerId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
