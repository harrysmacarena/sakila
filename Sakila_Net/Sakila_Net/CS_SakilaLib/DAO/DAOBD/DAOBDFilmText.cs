using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAOFilmText 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  film_id ,title ,description  from filmText";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClFilmText filmText)  
        {
            String stSql = "Select  film_id ,title ,description  from filmText";
            stSql += " Where  film_id='" + filmText.FilmId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        filmText.Title = dt.Rows[0]["title"].ToString();
        filmText.Description = dt.Rows[0]["description"].ToString();
            return true;
        }

        public  static int sqlInsert( ClFilmText filmText)  
        {
            String stSql = "insert into FilmText (" 
                       + " film_id ,title ,description" 
                           + " )values (" 
            + "'" + filmText.FilmId + "'" 
                     + ",'" + filmText.Title + "'" 
                     + ",'" + filmText.Description + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClFilmText filmText) {
            
            String stSql  =  "delete from FilmText " 
             + " Where  film_id='" + filmText.FilmId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClFilmText filmText ) {
            String stSql  =  "update FilmText SET " 
             + " title = '" + filmText.Title + "'" 
                             + ",description = '" + filmText.Description + "'" 
             + " Where  film_id='" + filmText.FilmId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
