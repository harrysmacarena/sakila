using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAOCustomer 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  customer_id ,store_id ,first_name ,last_name ,email ,address_id ,active ,create_date ,last_update  from customer";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClCustomer customer)  
        {
            String stSql = "Select  customer_id ,store_id ,first_name ,last_name ,email ,address_id ,active ,create_date ,last_update  from customer";
            stSql += " Where  customer_id='" + customer.CustomerId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        customer.StoreId = new ClStore(int.Parse(dt.Rows[0]["store_id"].ToString()));
        customer.FirstName = dt.Rows[0]["first_name"].ToString();
        customer.LastName = dt.Rows[0]["last_name"].ToString();
        customer.Email = dt.Rows[0]["email"].ToString();
        customer.AddressId = new ClAddress(int.Parse(dt.Rows[0]["address_id"].ToString()));
        customer.Active = int.Parse(dt.Rows[0]["active"].ToString());
        customer.CreateDate = DateTime.ParseExact(dt.Rows[0]["create_date"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
        customer.LastUpdate = DateTime.ParseExact(dt.Rows[0]["last_update"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }

        public  static int sqlInsert( ClCustomer customer)  
        {
            String stSql = "insert into Customer (" 
                       + " customer_id ,store_id ,first_name ,last_name ,email ,address_id ,active ,create_date ,last_update" 
                           + " )values (" 
            + "'" + customer.CustomerId + "'" 
                     + ",'" + customer.StoreId.StoreId + "'" 
                     + ",'" + customer.FirstName + "'" 
                     + ",'" + customer.LastName + "'" 
                     + ",'" + customer.Email + "'" 
                     + ",'" + customer.AddressId.AddressId + "'" 
                     + ",'" + customer.Active + "'" 
                     + ",'" + customer.CreateDate + "'" 
                     + ",'" + customer.LastUpdate + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClCustomer customer) {
            
            String stSql  =  "delete from Customer " 
             + " Where  customer_id='" + customer.CustomerId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClCustomer customer ) {
            String stSql  =  "update Customer SET " 
             + " store_id = '" + customer.StoreId.StoreId + "'" 
                             + ",first_name = '" + customer.FirstName + "'" 
                             + ",last_name = '" + customer.LastName + "'" 
                             + ",email = '" + customer.Email + "'" 
                             + ",address_id = '" + customer.AddressId.AddressId + "'" 
                             + ",active = '" + customer.Active + "'" 
                             + ",create_date = '" + customer.CreateDate + "'" 
                             + ",last_update = '" + customer.LastUpdate + "'" 
             + " Where  customer_id='" + customer.CustomerId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
