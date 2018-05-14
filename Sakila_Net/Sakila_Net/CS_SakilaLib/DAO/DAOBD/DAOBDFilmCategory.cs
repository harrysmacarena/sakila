using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAOFilmCategory 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  film_id ,category_id ,last_update  from filmCategory";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClFilmCategory filmCategory)  
        {
            String stSql = "Select  film_id ,category_id ,last_update  from filmCategory";
            stSql += " Where  film_id='" + filmCategory.FilmId.FilmId + "'" 
                           + "   and category_id='" + filmCategory.CategoryId.CategoryId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        filmCategory.LastUpdate = DateTime.ParseExact(dt.Rows[0]["last_update"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }

        public  static int sqlInsert( ClFilmCategory filmCategory)  
        {
            String stSql = "insert into FilmCategory (" 
                       + " film_id ,category_id ,last_update" 
                           + " )values (" 
            + "'" + filmCategory.FilmId.FilmId + "'" 
                     + ",'" + filmCategory.CategoryId.CategoryId + "'" 
                     + ",'" + filmCategory.LastUpdate + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClFilmCategory filmCategory) {
            
            String stSql  =  "delete from FilmCategory " 
             + " Where  film_id='" + filmCategory.FilmId.FilmId + "'" 
                           + "   and category_id='" + filmCategory.CategoryId.CategoryId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClFilmCategory filmCategory ) {
            String stSql  =  "update FilmCategory SET " 
             + " last_update = '" + filmCategory.LastUpdate + "'" 
             + " Where  film_id='" + filmCategory.FilmId.FilmId + "'" 
                           + "   and category_id='" + filmCategory.CategoryId.CategoryId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
