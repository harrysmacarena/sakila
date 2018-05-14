using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAOPayment 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  payment_id ,customer_id ,staff_id ,rental_id ,amount ,payment_date ,last_update  from payment";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClPayment payment)  
        {
            String stSql = "Select  payment_id ,customer_id ,staff_id ,rental_id ,amount ,payment_date ,last_update  from payment";
            stSql += " Where  payment_id='" + payment.PaymentId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        payment.CustomerId = new ClCustomer(int.Parse(dt.Rows[0]["customer_id"].ToString()));
        payment.StaffId = new ClStaff(int.Parse(dt.Rows[0]["staff_id"].ToString()));
        payment.RentalId = new ClRental(int.Parse(dt.Rows[0]["rental_id"].ToString()));
        payment.Amount = int.Parse(dt.Rows[0]["amount"].ToString());
        payment.PaymentDate = DateTime.ParseExact(dt.Rows[0]["payment_date"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
        payment.LastUpdate = DateTime.ParseExact(dt.Rows[0]["last_update"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }

        public  static int sqlInsert( ClPayment payment)  
        {
            String stSql = "insert into Payment (" 
                       + " payment_id ,customer_id ,staff_id ,rental_id ,amount ,payment_date ,last_update" 
                           + " )values (" 
            + "'" + payment.PaymentId + "'" 
                     + ",'" + payment.CustomerId.CustomerId + "'" 
                     + ",'" + payment.StaffId.StaffId + "'" 
                     + ",'" + payment.RentalId.RentalId + "'" 
                     + ",'" + payment.Amount + "'" 
                     + ",'" + payment.PaymentDate + "'" 
                     + ",'" + payment.LastUpdate + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClPayment payment) {
            
            String stSql  =  "delete from Payment " 
             + " Where  payment_id='" + payment.PaymentId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClPayment payment ) {
            String stSql  =  "update Payment SET " 
             + " customer_id = '" + payment.CustomerId.CustomerId + "'" 
                             + ",staff_id = '" + payment.StaffId.StaffId + "'" 
                             + ",rental_id = '" + payment.RentalId.RentalId + "'" 
                             + ",amount = '" + payment.Amount + "'" 
                             + ",payment_date = '" + payment.PaymentDate + "'" 
                             + ",last_update = '" + payment.LastUpdate + "'" 
             + " Where  payment_id='" + payment.PaymentId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
