using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAOCountry 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  country_id ,country ,last_update  from country";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClCountry country)  
        {
            String stSql = "Select  country_id ,country ,last_update  from country";
            stSql += " Where  country_id='" + country.CountryId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        country.Country = dt.Rows[0]["country"].ToString();
        country.LastUpdate = DateTime.ParseExact(dt.Rows[0]["last_update"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }

        public  static int sqlInsert( ClCountry country)  
        {
            String stSql = "insert into Country (" 
                       + " country_id ,country ,last_update" 
                           + " )values (" 
            + "'" + country.CountryId + "'" 
                     + ",'" + country.Country + "'" 
                     + ",'" + country.LastUpdate + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClCountry country) {
            
            String stSql  =  "delete from Country " 
             + " Where  country_id='" + country.CountryId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClCountry country ) {
            String stSql  =  "update Country SET " 
             + " country = '" + country.Country + "'" 
                             + ",last_update = '" + country.LastUpdate + "'" 
             + " Where  country_id='" + country.CountryId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
