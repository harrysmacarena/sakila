using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAORental 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  rental_id ,rental_date ,inventory_id ,customer_id ,return_date ,staff_id ,last_update  from rental";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClRental rental)  
        {
            String stSql = "Select  rental_id ,rental_date ,inventory_id ,customer_id ,return_date ,staff_id ,last_update  from rental";
            stSql += " Where  rental_id='" + rental.RentalId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        rental.RentalDate = DateTime.ParseExact(dt.Rows[0]["rental_date"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
        rental.InventoryId = new ClInventory(int.Parse(dt.Rows[0]["inventory_id"].ToString()));
        rental.CustomerId = new ClCustomer(int.Parse(dt.Rows[0]["customer_id"].ToString()));
        rental.ReturnDate = DateTime.ParseExact(dt.Rows[0]["return_date"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
        rental.StaffId = new ClStaff(int.Parse(dt.Rows[0]["staff_id"].ToString()));
        rental.LastUpdate = DateTime.ParseExact(dt.Rows[0]["last_update"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }

        public  static int sqlInsert( ClRental rental)  
        {
            String stSql = "insert into Rental (" 
                       + " rental_id ,rental_date ,inventory_id ,customer_id ,return_date ,staff_id ,last_update" 
                           + " )values (" 
            + "'" + rental.RentalId + "'" 
                     + ",'" + rental.RentalDate + "'" 
                     + ",'" + rental.InventoryId.InventoryId + "'" 
                     + ",'" + rental.CustomerId.CustomerId + "'" 
                     + ",'" + rental.ReturnDate + "'" 
                     + ",'" + rental.StaffId.StaffId + "'" 
                     + ",'" + rental.LastUpdate + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClRental rental) {
            
            String stSql  =  "delete from Rental " 
             + " Where  rental_id='" + rental.RentalId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClRental rental ) {
            String stSql  =  "update Rental SET " 
             + " rental_date = '" + rental.RentalDate + "'" 
                             + ",inventory_id = '" + rental.InventoryId.InventoryId + "'" 
                             + ",customer_id = '" + rental.CustomerId.CustomerId + "'" 
                             + ",return_date = '" + rental.ReturnDate + "'" 
                             + ",staff_id = '" + rental.StaffId.StaffId + "'" 
                             + ",last_update = '" + rental.LastUpdate + "'" 
             + " Where  rental_id='" + rental.RentalId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
