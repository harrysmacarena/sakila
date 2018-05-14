using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAOFilm 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  film_id ,title ,description ,release_year ,language_id ,original_language_id ,rental_duration ,rental_rate ,length ,replacement_cost ,rating ,special_features ,last_update  from film";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClFilm film)  
        {
            String stSql = "Select  film_id ,title ,description ,release_year ,language_id ,original_language_id ,rental_duration ,rental_rate ,length ,replacement_cost ,rating ,special_features ,last_update  from film";
            stSql += " Where  film_id='" + film.FilmId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        film.Title = dt.Rows[0]["title"].ToString();
        film.Description = dt.Rows[0]["description"].ToString();
        film.ReleaseYear = int.Parse(dt.Rows[0]["release_year"].ToString());
        film.LanguageId = new ClLanguage(int.Parse(dt.Rows[0]["language_id"].ToString()));
        film.OriginalLanguageId = int.Parse(dt.Rows[0]["original_language_id"].ToString());
        film.RentalDuration = int.Parse(dt.Rows[0]["rental_duration"].ToString());
        film.RentalRate = int.Parse(dt.Rows[0]["rental_rate"].ToString());
        film.Length = int.Parse(dt.Rows[0]["length"].ToString());
        film.ReplacementCost = int.Parse(dt.Rows[0]["replacement_cost"].ToString());
        film.Rating = dt.Rows[0]["rating"].ToString();
        film.SpecialFeatures = dt.Rows[0]["special_features"].ToString();
        film.LastUpdate = DateTime.ParseExact(dt.Rows[0]["last_update"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }

        public  static int sqlInsert( ClFilm film)  
        {
            String stSql = "insert into Film (" 
                       + " film_id ,title ,description ,release_year ,language_id ,original_language_id ,rental_duration ,rental_rate ,length ,replacement_cost ,rating ,special_features ,last_update" 
                           + " )values (" 
            + "'" + film.FilmId + "'" 
                     + ",'" + film.Title + "'" 
                     + ",'" + film.Description + "'" 
                     + ",'" + film.ReleaseYear + "'" 
                     + ",'" + film.LanguageId.LanguageId + "'" 
                     + ",'" + film.OriginalLanguageId + "'" 
                     + ",'" + film.RentalDuration + "'" 
                     + ",'" + film.RentalRate + "'" 
                     + ",'" + film.Length + "'" 
                     + ",'" + film.ReplacementCost + "'" 
                     + ",'" + film.Rating + "'" 
                     + ",'" + film.SpecialFeatures + "'" 
                     + ",'" + film.LastUpdate + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClFilm film) {
            
            String stSql  =  "delete from Film " 
             + " Where  film_id='" + film.FilmId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClFilm film ) {
            String stSql  =  "update Film SET " 
             + " title = '" + film.Title + "'" 
                             + ",description = '" + film.Description + "'" 
                             + ",release_year = '" + film.ReleaseYear + "'" 
                             + ",language_id = '" + film.LanguageId.LanguageId + "'" 
                             + ",original_language_id = '" + film.OriginalLanguageId + "'" 
                             + ",rental_duration = '" + film.RentalDuration + "'" 
                             + ",rental_rate = '" + film.RentalRate + "'" 
                             + ",length = '" + film.Length + "'" 
                             + ",replacement_cost = '" + film.ReplacementCost + "'" 
                             + ",rating = '" + film.Rating + "'" 
                             + ",special_features = '" + film.SpecialFeatures + "'" 
                             + ",last_update = '" + film.LastUpdate + "'" 
             + " Where  film_id='" + film.FilmId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
