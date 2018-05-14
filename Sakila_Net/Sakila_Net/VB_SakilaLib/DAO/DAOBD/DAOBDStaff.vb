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

          Public class DAOStaff
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from staff"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( staff as ClStaff) as Boolean
             Dim StSql as String = "Select * from staff"
            StSql &= " Where  staff_id='" & staff.dataStaffId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        staff.DataFirstName = dt.Rows(0)("first_name").ToString()
        staff.DataLastName = dt.Rows(0)("last_name").ToString()
        staff.DataAddressId = new ClAddress(Integer.Parse(dt.Rows(0)("address_id")))
        staff.DataPicture = dt.Rows(0)("picture").ToString()
        staff.DataEmail = dt.Rows(0)("email").ToString()
        staff.DataStoreId = new ClStore(Integer.Parse(dt.Rows(0)("store_id")))
        staff.DataActive = dt.Rows(0)("active")
        staff.DataUsername = dt.Rows(0)("username").ToString()
        staff.DataPassword = dt.Rows(0)("password").ToString()
        staff.DataLastUpdate = dt.Rows(0)("last_update").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( staff as ClStaff)  as Integer
            Dim stSql as String = "insert into Staff (" _
                       & " staff_id ,first_name ,last_name ,address_id ,picture ,email ,store_id ,active ,username ,password ,last_update" _
                           & " )values (" _
            & "'" & staff.dataStaffId & "'" _
                     & ",'" & staff.dataFirstName & "'" _
                     & ",'" & staff.dataLastName & "'" _
                     & ",'" & staff.dataAddressId.dataaddressId & "'" _
                     & ",'" & staff.dataPicture & "'" _
                     & ",'" & staff.dataEmail & "'" _
                     & ",'" & staff.dataStoreId.datastoreId & "'" _
                     & ",'" & staff.dataActive & "'" _
                     & ",'" & staff.dataUsername & "'" _
                     & ",'" & staff.dataPassword & "'" _
                     & ",'" & staff.dataLastUpdate & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( staff as ClStaff) as Integer
            
            Dim stSql as String =  "delete from Staff " _
             & " Where  staff_id='" & staff.dataStaffId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(staff as ClStaff) as Integer
            Dim stSql as String =  "update Staff SET " _
             & " first_name = '" & staff.DataFirstName & "'" _
                             & ",last_name = '" & staff.DataLastName & "'" _
                             & ",address_id = '" & staff.DataAddressId.DataAddressId & "'" _
                             & ",picture = '" & staff.DataPicture & "'" _
                             & ",email = '" & staff.DataEmail & "'" _
                             & ",store_id = '" & staff.DataStoreId.DataStoreId & "'" _
                             & ",active = '" & staff.DataActive & "'" _
                             & ",username = '" & staff.DataUsername & "'" _
                             & ",password = '" & staff.DataPassword & "'" _
                             & ",last_update = '" & staff.DataLastUpdate & "'" _
             & " Where  staff_id='" & staff.dataStaffId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
