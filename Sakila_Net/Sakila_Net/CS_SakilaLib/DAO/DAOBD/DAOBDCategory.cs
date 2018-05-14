using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAOCategory 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  category_id ,name ,last_update  from category";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClCategory category)  
        {
            String stSql = "Select  category_id ,name ,last_update  from category";
            stSql += " Where  category_id='" + category.CategoryId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        category.Name = dt.Rows[0]["name"].ToString();
        category.LastUpdate = DateTime.ParseExact(dt.Rows[0]["last_update"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }

        public  static int sqlInsert( ClCategory category)  
        {
            String stSql = "insert into Category (" 
                       + " category_id ,name ,last_update" 
                           + " )values (" 
            + "'" + category.CategoryId + "'" 
                     + ",'" + category.Name + "'" 
                     + ",'" + category.LastUpdate + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClCategory category) {
            
            String stSql  =  "delete from Category " 
             + " Where  category_id='" + category.CategoryId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClCategory category ) {
            String stSql  =  "update Category SET " 
             + " name = '" + category.Name + "'" 
                             + ",last_update = '" + category.LastUpdate + "'" 
             + " Where  category_id='" + category.CategoryId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
