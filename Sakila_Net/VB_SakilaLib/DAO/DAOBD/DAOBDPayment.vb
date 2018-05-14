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

          Public class DAOPayment
             Public  Shared Function SelectAll(nPagina as Integer ,cantidad as Integer) as DataTable
                Dim StSql as String = "Select * from payment"
                Return MyBD.getInstance.SqlSelect(StSql, nPagina, cantidad)
        	   End Function

                    Public  Shared Function SelectOne( payment as ClPayment) as Boolean
             Dim StSql as String = "Select * from payment"
            StSql &= " Where  payment_id='" & payment.dataPaymentId & "'" _
                        & ""
                        Dim dt as DataTable = MyBD.getInstance.sqlSelect(stSql)
                        If dt.Rows.Count = 0 Then
                            Return False
                        End If
        payment.DataCustomerId = new ClCustomer(Integer.Parse(dt.Rows(0)("customer_id")))
        payment.DataStaffId = new ClStaff(Integer.Parse(dt.Rows(0)("staff_id")))
        payment.DataRentalId = new ClRental(Integer.Parse(dt.Rows(0)("rental_id")))
        payment.DataAmount = dt.Rows(0)("amount")
        payment.DataPaymentDate = dt.Rows(0)("payment_date").ToString()
        payment.DataLastUpdate = dt.Rows(0)("last_update").ToString()
                        Return True
                     end Function

        Public  Shared Function SqlInsert( payment as ClPayment)  as Integer
            Dim stSql as String = "insert into Payment (" _
                       & " payment_id ,customer_id ,staff_id ,rental_id ,amount ,payment_date ,last_update" _
                           & " )values (" _
            & "'" & payment.dataPaymentId & "'" _
                     & ",'" & payment.dataCustomerId.datacustomerId & "'" _
                     & ",'" & payment.dataStaffId.datastaffId & "'" _
                     & ",'" & payment.dataRentalId.datarentalId & "'" _
                     & ",'" & payment.dataAmount & "'" _
                     & ",'" & payment.dataPaymentDate & "'" _
                     & ",'" & payment.dataLastUpdate & "'" _
             & ")"
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

        Public  Shared Function SqlDelete( payment as ClPayment) as Integer
            
            Dim stSql as String =  "delete from Payment " _
             & " Where  payment_id='" & payment.dataPaymentId & "'" _
                       
       
            Return MyBD.getInstance.sqlEjecutar(stSql)
        End Function

       Public   Shared Function SqlUpdate(payment as ClPayment) as Integer
            Dim stSql as String =  "update Payment SET " _
             & " customer_id = '" & payment.DataCustomerId.DataCustomerId & "'" _
                             & ",staff_id = '" & payment.DataStaffId.DataStaffId & "'" _
                             & ",rental_id = '" & payment.DataRentalId.DataRentalId & "'" _
                             & ",amount = '" & payment.DataAmount & "'" _
                             & ",payment_date = '" & payment.DataPaymentDate & "'" _
                             & ",last_update = '" & payment.DataLastUpdate & "'" _
             & " Where  payment_id='" & payment.dataPaymentId & "'" _
& ""
            Return MyBD.getInstance.sqlEjecutar(stSql)
            
        end Function
          End Class

         End Namespace  
      End Namespace  
   End Namespace  
End Namespace  
