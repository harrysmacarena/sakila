using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClStaff
    {
	    //***********   Atributos o Propiedades
        private int staffId;
        private string firstName;
        private string lastName;
        private ClAddress addressId;
        private string picture;
        private string email;
        private ClStore storeId;
        private int active;
        private string username;
        private string password;
        private DateTime lastUpdate;
	    //***********   Accesadores y  Mutadores
        public int StaffId
        {
              get{ return staffId;}
              set{ staffId = value;}
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
        public ClAddress AddressId
        {
              get{ return addressId;}
              set{ addressId = value;}
        }
        public string Picture
        {
              get{ return picture;}
              set{ picture = value;}
        }
        public string Email
        {
              get{ return email;}
              set{ email = value;}
        }
        public ClStore StoreId
        {
              get{ return storeId;}
              set{ storeId = value;}
        }
        public int Active
        {
              get{ return active;}
              set{ active = value;}
        }
        public string Username
        {
              get{ return username;}
              set{ username = value;}
        }
        public string Password
        {
              get{ return password;}
              set{ password = value;}
        }
        public DateTime LastUpdate
        {
              get{ return lastUpdate;}
              set{ lastUpdate = value;}
        }
	    //***********   Constructor para Primary Key( Select y Delete)
        public  ClStaff(int staffId)
        {
		   StaffId=staffId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClStaff(int staffId,string firstName,string lastName,ClAddress addressId,string picture,string email,ClStore storeId,int active,string username,string password,DateTime lastUpdate)
        {
		   StaffId=staffId;
		   FirstName=firstName;
		   LastName=lastName;
		   AddressId=addressId;
		   Picture=picture;
		   Email=email;
		   StoreId=storeId;
		   Active=active;
		   Username=username;
		   Password=password;
		   LastUpdate=lastUpdate;
        }		
  }
}
