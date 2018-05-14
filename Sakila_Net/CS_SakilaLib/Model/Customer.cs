using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClCustomer
    {
	    //***********   Atributos o Propiedades
        private int customerId;
        private ClStore storeId;
        private string firstName;
        private string lastName;
        private string email;
        private ClAddress addressId;
        private int active;
        private DateTime createDate;
        private DateTime lastUpdate;
	    //***********   Accesadores y  Mutadores
        public int CustomerId
        {
              get{ return customerId;}
              set{ customerId = value;}
        }
        public ClStore StoreId
        {
              get{ return storeId;}
              set{ storeId = value;}
        }
        public string FirstName
        {
              get{ return firstName;}
              set{ firstName = value;}
        }
        public string LastName
        {
              get{ return lastName;}
              set{ lastName = value;}
        }
        public string Email
        {
              get{ return email;}
              set{ email = value;}
        }
        public ClAddress AddressId
        {
              get{ return addressId;}
              set{ addressId = value;}
        }
        public int Active
        {
              get{ return active;}
              set{ active = value;}
        }
        public DateTime CreateDate
        {
              get{ return createDate;}
              set{ createDate = value;}
        }
        public DateTime LastUpdate
        {
              get{ return lastUpdate;}
              set{ lastUpdate = value;}
        }
	    //***********   Constructor para Primary Key( Select y Delete)
        public  ClCustomer(int customerId)
        {
		   CustomerId=customerId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClCustomer(int customerId,ClStore storeId,string firstName,string lastName,string email,ClAddress addressId,int active,DateTime createDate,DateTime lastUpdate)
        {
		   CustomerId=customerId;
		   StoreId=storeId;
		   FirstName=firstName;
		   LastName=lastName;
		   Email=email;
		   AddressId=addressId;
		   Active=active;
		   CreateDate=createDate;
		   LastUpdate=lastUpdate;
        }		
  }
}
