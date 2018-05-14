using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClInventory
    {
	    //***********   Atributos o Propiedades
        private int inventoryId;
        private ClFilm filmId;
        private ClStore storeId;
        private DateTime lastUpdate;
	    //***********   Accesadores y  Mutadores
        public int InventoryId
        {
              get{ return inventoryId;}
              set{ inventoryId = value;}
        }
        public ClFilm FilmId
        {
              get{ return filmId;}
              set{ filmId = value;}
        }
        public ClStore StoreId
        {
              get{ return storeId;}
              set{ storeId = value;}
        }
        public DateTime LastUpdate
        {
              get{ return lastUpdate;}
              set{ lastUpdate = value;}
        }
	    //***********   Constructor para Primary Key( Select y Delete)
        public  ClInventory(int inventoryId)
        {
		   InventoryId=inventoryId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClInventory(int inventoryId,ClFilm filmId,ClStore storeId,DateTime lastUpdate)
        {
		   InventoryId=inventoryId;
		   FilmId=filmId;
		   StoreId=storeId;
		   LastUpdate=lastUpdate;
        }		
  }
}
