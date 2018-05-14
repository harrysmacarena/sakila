using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClCategory
    {
	    //***********   Atributos o Propiedades
        private int categoryId;
        private string name;
        private DateTime lastUpdate;
	    //***********   Accesadores y  Mutadores
        public int CategoryId
        {
              get{ return categoryId;}
              set{ categoryId = value;}
        }
        public string Name
        {
              get{ return name;}
              set{ name = value;}
        }
        public DateTime LastUpdate
        {
              get{ return lastUpdate;}
              set{ lastUpdate = value;}
        }
	    //***********   Constructor para Primary Key( Select y Delete)
        public  ClCategory(int categoryId)
        {
		   CategoryId=categoryId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClCategory(int categoryId,string name,DateTime lastUpdate)
        {
		   CategoryId=categoryId;
		   Name=name;
		   LastUpdate=lastUpdate;
        }		
  }
}
