using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAOLanguage 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  language_id ,name ,last_update  from language";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClLanguage language)  
        {
            String stSql = "Select  language_id ,name ,last_update  from language";
            stSql += " Where  language_id='" + language.LanguageId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        language.Name = dt.Rows[0]["name"].ToString();
        language.LastUpdate = DateTime.ParseExact(dt.Rows[0]["last_update"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }

        public  static int sqlInsert( ClLanguage language)  
        {
            String stSql = "insert into Language (" 
                       + " language_id ,name ,last_update" 
                           + " )values (" 
            + "'" + language.LanguageId + "'" 
                     + ",'" + language.Name + "'" 
                     + ",'" + language.LastUpdate + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClLanguage language) {
            
            String stSql  =  "delete from Language " 
             + " Where  language_id='" + language.LanguageId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClLanguage language ) {
            String stSql  =  "update Language SET " 
             + " name = '" + language.Name + "'" 
                             + ",last_update = '" + language.LastUpdate + "'" 
             + " Where  language_id='" + language.LanguageId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
