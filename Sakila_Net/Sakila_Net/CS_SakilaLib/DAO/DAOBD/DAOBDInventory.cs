using System;
using  System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using Cl.Harrys.Sakila.Model;
using Cl.Harrys.MyBD;


namespace Cl.Harrys.Sakila.DAOBD 
{ 
    public class DAOInventory 
    {
        public  static DataTable selectAll(int nPagina  ,int cantidad ) 
        {
            String StSql = "Select  inventory_id ,film_id ,store_id ,last_update  from inventory";
            return MyBD.MyBD.getInstance().sqlSelect(StSql, nPagina, cantidad);
        }

        public  static Boolean SelectOne( ClInventory inventory)  
        {
            String stSql = "Select  inventory_id ,film_id ,store_id ,last_update  from inventory";
            stSql += " Where  inventory_id='" + inventory.InventoryId + "'" 
                        + "";
            DataTable dt = MyBD.MyBD.getInstance().sqlSelect(stSql,1,1);
            if (dt.Rows.Count == 0) 
                return false;
                        
        inventory.FilmId = new ClFilm(int.Parse(dt.Rows[0]["film_id"].ToString()));
        inventory.StoreId = new ClStore(int.Parse(dt.Rows[0]["store_id"].ToString()));
        inventory.LastUpdate = DateTime.ParseExact(dt.Rows[0]["last_update"].ToString(), "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
            return true;
        }

        public  static int sqlInsert( ClInventory inventory)  
        {
            String stSql = "insert into Inventory (" 
                       + " inventory_id ,film_id ,store_id ,last_update" 
                           + " )values (" 
            + "'" + inventory.InventoryId + "'" 
                     + ",'" + inventory.FilmId.FilmId + "'" 
                     + ",'" + inventory.StoreId.StoreId + "'" 
                     + ",'" + inventory.LastUpdate + "'" 
             + ")";
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

        public  static int sqlDelete( ClInventory inventory) {
            
            String stSql  =  "delete from Inventory " 
             + " Where  inventory_id='" + inventory.InventoryId + "'" 
                       ;
       
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
        }

       public   static int sqlUpdate(ClInventory inventory ) {
            String stSql  =  "update Inventory SET " 
             + " film_id = '" + inventory.FilmId.FilmId + "'" 
                             + ",store_id = '" + inventory.StoreId.StoreId + "'" 
                             + ",last_update = '" + inventory.LastUpdate + "'" 
             + " Where  inventory_id='" + inventory.InventoryId + "'" 
                 + "";
            return MyBD.MyBD.getInstance().sqlEjecutar(stSql);
            
        }
   }

}
