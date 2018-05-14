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

          Public class DAOAddress
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from address"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( address as ClAddress) as Boolean
             Dim StSql as String = "Select * from address"
            StSql &= " Where  address_id='" & address.dataAddressId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        address.DataAddress = dt.Rows(0)("address").ToString()
        address.DataAddress2 = dt.Rows(0)("address2").ToString()
        address.DataDistrict = dt.Rows(0)("district").ToString()
        address.DataCityId = new ClCity(Integer.Parse(dt.Rows(0)("city_id")))
        address.DataPostalCode = dt.Rows(0)("postal_code").ToString()
        address.DataPhone = dt.Rows(0)("phone").ToString()
        address.DataLastUpdate = dt.Rows(0)("last_update").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( address as ClAddress)  as Integer
            Dim stSql as String = "insert into Address (" _
                       & " address_id ,address ,address2 ,district ,city_id ,postal_code ,phone ,last_update" _
                           & " )values (" _
            & "'" & address.dataAddressId & "'" _
                     & ",'" & address.dataAddress & "'" _
                     & ",'" & address.dataAddress2 & "'" _
                     & ",'" & address.dataDistrict & "'" _
                     & ",'" & address.dataCityId.datacityId & "'" _
                     & ",'" & address.dataPostalCode & "'" _
                     & ",'" & address.dataPhone & "'" _
                     & ",'" & address.dataLastUpdate & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( address as ClAddress) as Integer
            
            Dim stSql as String =  "delete from Address " _
             & " Where  address_id='" & address.dataAddressId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(address as ClAddress) as Integer
            Dim stSql as String =  "update Address SET " _
             & " address = '" & address.DataAddress & "'" _
                             & ",address2 = '" & address.DataAddress2 & "'" _
                             & ",district = '" & address.DataDistrict & "'" _
                             & ",city_id = '" & address.DataCityId.DataCityId & "'" _
                             & ",postal_code = '" & address.DataPostalCode & "'" _
                             & ",phone = '" & address.DataPhone & "'" _
                             & ",last_update = '" & address.DataLastUpdate & "'" _
             & " Where  address_id='" & address.dataAddressId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
