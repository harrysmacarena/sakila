using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClCity
    {
	    //***********   Atributos o Propiedades
        private int cityId;
        private string city;
        private ClCountry countryId;
        private DateTime lastUpdate;
	    //***********   Accesadores y  Mutadores
        public int CityId
        {
              get{ return cityId;}
              set{ cityId = value;}
        }
        public string City
        {
              get{ return city;}
              set{ city = value;}
        }
        public ClCountry CountryId
        {
              get{ return countryId;}
              set{ countryId = value;}
        }
        public DateTime LastUpdate
        {
              get{ return lastUpdate;}
              set{ lastUpdate = value;}
        }
	    //***********   Constructor para Primary Key( Select y Delete)
        public  ClCity(int cityId)
        {
		   CityId=cityId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClCity(int cityId,string city,ClCountry countryId,DateTime lastUpdate)
        {
		   CityId=cityId;
		   City=city;
		   CountryId=countryId;
		   LastUpdate=lastUpdate;
        }		
  }
}
