using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClCountry
    {
	    //***********   Atributos o Propiedades
        private int countryId;
        private string country;
        private DateTime lastUpdate;
	    //***********   Accesadores y  Mutadores
        public int CountryId
        {
              get{ return countryId;}
              set{ countryId = value;}
        }
        public string Country
        {
              get{ return country;}
              set{ country = value;}
        }
        public DateTime LastUpdate
        {
              get{ return lastUpdate;}
              set{ lastUpdate = value;}
        }
	    //***********   Constructor para Primary Key( Select y Delete)
        public  ClCountry(int countryId)
        {
		   CountryId=countryId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClCountry(int countryId,string country,DateTime lastUpdate)
        {
		   CountryId=countryId;
		   Country=country;
		   LastUpdate=lastUpdate;
        }		
  }
}
