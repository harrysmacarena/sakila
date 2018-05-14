using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAOStaff 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  staff_id ,first_name ,last_name ,address_id ,picture ,email ,store_id ,active ,username ,password ,last_update  from staff";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClStaff staff)  
        {
            String stSql = "Select  staff_id ,first_name ,last_name ,address_id ,picture ,email ,store_id ,active ,username ,password ,last_update  from staff";
            stSql += " Where  staff_id='" + staff.StaffId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        staff.FirstName = dt.Rows[0]["first_name"].ToString();
        staff.LastName = dt.Rows[0]["last_name"].ToString();
        staff.AddressId = new ClAddress(int.Parse(dt.Rows[0]["address_id"].ToString()));
        staff.Picture = dt.Rows[0]["picture"].ToString();
        staff.Email = dt.Rows[0]["email"].ToString();
        staff.StoreId = new ClStore(int.Parse(dt.Rows[0]["store_id"].ToString()));
        staff.Active = int.Parse(dt.Rows[0]["active"].ToString());
        staff.Username = dt.Rows[0]["username"].ToString();
        staff.Password = dt.Rows[0]["password"].ToString();
        staff.LastUpdate = DateTime.ParseExact(dt.Rows[0]["last_update"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }

        public  static int sqlInsert( ClStaff staff)  
        {
            String stSql = "insert into Staff (" 
                       + " staff_id ,first_name ,last_name ,address_id ,picture ,email ,store_id ,active ,username ,password ,last_update" 
                           + " )values (" 
            + "'" + staff.StaffId + "'" 
                     + ",'" + staff.FirstName + "'" 
                     + ",'" + staff.LastName + "'" 
                     + ",'" + staff.AddressId.AddressId + "'" 
                     + ",'" + staff.Picture + "'" 
                     + ",'" + staff.Email + "'" 
                     + ",'" + staff.StoreId.StoreId + "'" 
                     + ",'" + staff.Active + "'" 
                     + ",'" + staff.Username + "'" 
                     + ",'" + staff.Password + "'" 
                     + ",'" + staff.LastUpdate + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClStaff staff) {
            
            String stSql  =  "delete from Staff " 
             + " Where  staff_id='" + staff.StaffId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClStaff staff ) {
            String stSql  =  "update Staff SET " 
             + " first_name = '" + staff.FirstName + "'" 
                             + ",last_name = '" + staff.LastName + "'" 
                             + ",address_id = '" + staff.AddressId.AddressId + "'" 
                             + ",picture = '" + staff.Picture + "'" 
                             + ",email = '" + staff.Email + "'" 
                             + ",store_id = '" + staff.StoreId.StoreId + "'" 
                             + ",active = '" + staff.Active + "'" 
                             + ",username = '" + staff.Username + "'" 
                             + ",password = '" + staff.Password + "'" 
                             + ",last_update = '" + staff.LastUpdate + "'" 
             + " Where  staff_id='" + staff.StaffId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
