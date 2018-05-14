using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAOFilmActor 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  actor_id ,film_id ,last_update  from filmActor";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClFilmActor filmActor)  
        {
            String stSql = "Select  actor_id ,film_id ,last_update  from filmActor";
            stSql += " Where  actor_id='" + filmActor.ActorId.ActorId + "'" 
                           + "   and film_id='" + filmActor.FilmId.FilmId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        filmActor.LastUpdate = DateTime.ParseExact(dt.Rows[0]["last_update"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }

        public  static int sqlInsert( ClFilmActor filmActor)  
        {
            String stSql = "insert into FilmActor (" 
                       + " actor_id ,film_id ,last_update" 
                           + " )values (" 
            + "'" + filmActor.ActorId.ActorId + "'" 
                     + ",'" + filmActor.FilmId.FilmId + "'" 
                     + ",'" + filmActor.LastUpdate + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClFilmActor filmActor) {
            
            String stSql  =  "delete from FilmActor " 
             + " Where  actor_id='" + filmActor.ActorId.ActorId + "'" 
                           + "   and film_id='" + filmActor.FilmId.FilmId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClFilmActor filmActor ) {
            String stSql  =  "update FilmActor SET " 
             + " last_update = '" + filmActor.LastUpdate + "'" 
             + " Where  actor_id='" + filmActor.ActorId.ActorId + "'" 
                           + "   and film_id='" + filmActor.FilmId.FilmId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
