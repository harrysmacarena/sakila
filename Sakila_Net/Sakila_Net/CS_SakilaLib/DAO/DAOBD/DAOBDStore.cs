using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAOStore 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  store_id ,manager_staff_id ,address_id ,last_update  from store";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClStore store)  
        {
            String stSql = "Select  store_id ,manager_staff_id ,address_id ,last_update  from store";
            stSql += " Where  store_id='" + store.StoreId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        store.ManagerStaffId = int.Parse(dt.Rows[0]["manager_staff_id"].ToString());
        store.AddressId = new ClAddress(int.Parse(dt.Rows[0]["address_id"].ToString()));
        store.LastUpdate = DateTime.ParseExact(dt.Rows[0]["last_update"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }

        public  static int sqlInsert( ClStore store)  
        {
            String stSql = "insert into Store (" 
                       + " store_id ,manager_staff_id ,address_id ,last_update" 
                           + " )values (" 
            + "'" + store.StoreId + "'" 
                     + ",'" + store.ManagerStaffId + "'" 
                     + ",'" + store.AddressId.AddressId + "'" 
                     + ",'" + store.LastUpdate + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClStore store) {
            
            String stSql  =  "delete from Store " 
             + " Where  store_id='" + store.StoreId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClStore store ) {
            String stSql  =  "update Store SET " 
             + " manager_staff_id = '" + store.ManagerStaffId + "'" 
                             + ",address_id = '" + store.AddressId.AddressId + "'" 
                             + ",last_update = '" + store.LastUpdate + "'" 
             + " Where  store_id='" + store.StoreId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
