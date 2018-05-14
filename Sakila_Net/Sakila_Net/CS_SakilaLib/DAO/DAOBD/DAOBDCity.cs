using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAOCity 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  city_id ,city ,country_id ,last_update  from city";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClCity city)  
        {
            String stSql = "Select  city_id ,city ,country_id ,last_update  from city";
            stSql += " Where  city_id='" + city.CityId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        city.City = dt.Rows[0]["city"].ToString();
        city.CountryId = new ClCountry(int.Parse(dt.Rows[0]["country_id"].ToString()));
        city.LastUpdate = DateTime.ParseExact(dt.Rows[0]["last_update"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }

        public  static int sqlInsert( ClCity city)  
        {
            String stSql = "insert into City (" 
                       + " city_id ,city ,country_id ,last_update" 
                           + " )values (" 
            + "'" + city.CityId + "'" 
                     + ",'" + city.City + "'" 
                     + ",'" + city.CountryId.CountryId + "'" 
                     + ",'" + city.LastUpdate + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClCity city) {
            
            String stSql  =  "delete from City " 
             + " Where  city_id='" + city.CityId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClCity city ) {
            String stSql  =  "update City SET " 
             + " city = '" + city.City + "'" 
                             + ",country_id = '" + city.CountryId.CountryId + "'" 
                             + ",last_update = '" + city.LastUpdate + "'" 
             + " Where  city_id='" + city.CityId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
