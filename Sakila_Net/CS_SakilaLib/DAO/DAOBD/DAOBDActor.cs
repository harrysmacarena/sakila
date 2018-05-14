using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAOActor 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  actor_id ,first_name ,last_name ,last_update  from actor";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClActor actor)  
        {
            String stSql = "Select  actor_id ,first_name ,last_name ,last_update  from actor";
            stSql += " Where  actor_id='" + actor.ActorId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        actor.FirstName = dt.Rows[0]["first_name"].ToString();
        actor.LastName = dt.Rows[0]["last_name"].ToString();
        actor.LastUpdate = DateTime.ParseExact(dt.Rows[0]["last_update"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }

        public  static int sqlInsert( ClActor actor)  
        {
            String stSql = "insert into Actor (" 
                       + " actor_id ,first_name ,last_name ,last_update" 
                           + " )values (" 
            + "'" + actor.ActorId + "'" 
                     + ",'" + actor.FirstName + "'" 
                     + ",'" + actor.LastName + "'" 
                     + ",'" + actor.LastUpdate + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClActor actor) {
            
            String stSql  =  "delete from Actor " 
             + " Where  actor_id='" + actor.ActorId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClActor actor ) {
            String stSql  =  "update Actor SET " 
             + " first_name = '" + actor.FirstName + "'" 
                             + ",last_name = '" + actor.LastName + "'" 
                             + ",last_update = '" + actor.LastUpdate + "'" 
             + " Where  actor_id='" + actor.ActorId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
