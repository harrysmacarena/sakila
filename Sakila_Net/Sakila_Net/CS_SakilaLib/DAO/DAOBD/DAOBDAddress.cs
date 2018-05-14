using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAOAddress 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  address_id ,address ,address2 ,district ,city_id ,postal_code ,phone ,last_update  from address";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClAddress address)  
        {
            String stSql = "Select  address_id ,address ,address2 ,district ,city_id ,postal_code ,phone ,last_update  from address";
            stSql += " Where  address_id='" + address.AddressId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        address.Address = dt.Rows[0]["address"].ToString();
        address.Address2 = dt.Rows[0]["address2"].ToString();
        address.District = dt.Rows[0]["district"].ToString();
        address.CityId = new ClCity(int.Parse(dt.Rows[0]["city_id"].ToString()));
        address.PostalCode = dt.Rows[0]["postal_code"].ToString();
        address.Phone = dt.Rows[0]["phone"].ToString();
        address.LastUpdate = DateTime.ParseExact(dt.Rows[0]["last_update"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }

        public  static int sqlInsert( ClAddress address)  
        {
            String stSql = "insert into Address (" 
                       + " address_id ,address ,address2 ,district ,city_id ,postal_code ,phone ,last_update" 
                           + " )values (" 
            + "'" + address.AddressId + "'" 
                     + ",'" + address.Address + "'" 
                     + ",'" + address.Address2 + "'" 
                     + ",'" + address.District + "'" 
                     + ",'" + address.CityId.CityId + "'" 
                     + ",'" + address.PostalCode + "'" 
                     + ",'" + address.Phone + "'" 
                     + ",'" + address.LastUpdate + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClAddress address) {
            
            String stSql  =  "delete from Address " 
             + " Where  address_id='" + address.AddressId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClAddress address ) {
            String stSql  =  "update Address SET " 
             + " address = '" + address.Address + "'" 
                             + ",address2 = '" + address.Address2 + "'" 
                             + ",district = '" + address.District + "'" 
                             + ",city_id = '" + address.CityId.CityId + "'" 
                             + ",postal_code = '" + address.PostalCode + "'" 
                             + ",phone = '" + address.Phone + "'" 
                             + ",last_update = '" + address.LastUpdate + "'" 
             + " Where  address_id='" + address.AddressId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
