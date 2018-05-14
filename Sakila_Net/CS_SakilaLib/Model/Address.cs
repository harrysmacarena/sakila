using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClAddress
    {
	    //***********   Atributos o Propiedades
        private int addressId;
        private string address;
        private string address2;
        private string district;
        private ClCity cityId;
        private string postalCode;
        private string phone;
        private DateTime lastUpdate;
	    //***********   Accesadores y  Mutadores
        public int AddressId
        {
              get{ return addressId;}
              set{ addressId = value;}
        }
        public string Address
        {
              get{ return address;}
              set{ address = value;}
        }
        public string Address2
        {
              get{ return address2;}
              set{ address2 = value;}
        }
        public string District
        {
              get{ return district;}
              set{ district = value;}
        }
        public ClCity CityId
        {
              get{ return cityId;}
              set{ cityId = value;}
        }
        public string PostalCode
        {
              get{ return postalCode;}
              set{ postalCode = value;}
        }
        public string Phone
        {
              get{ return phone;}
              set{ phone = value;}
        }
        public DateTime LastUpdate
        {
              get{ return lastUpdate;}
              set{ lastUpdate = value;}
        }
	    //***********   Constructor para Primary Key( Select y Delete)
        public  ClAddress(int addressId)
        {
		   AddressId=addressId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClAddress(int addressId,string address,string address2,string district,ClCity cityId,string postalCode,string phone,DateTime lastUpdate)
        {
		   AddressId=addressId;
		   Address=address;
		   Address2=address2;
		   District=district;
		   CityId=cityId;
		   PostalCode=postalCode;
		   Phone=phone;
		   LastUpdate=lastUpdate;
        }		
  }
}
