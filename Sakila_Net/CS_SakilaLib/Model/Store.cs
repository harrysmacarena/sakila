using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClStore
    {
	    //***********   Atributos o Propiedades
        private int storeId;
        private int managerStaffId;
        private ClAddress addressId;
        private DateTime lastUpdate;
	    //***********   Accesadores y  Mutadores
        public int StoreId
        {
              get{ return storeId;}
              set{ storeId = value;}
        }
        public int ManagerStaffId
        {
              get{ return managerStaffId;}
              set{ managerStaffId = value;}
        }
        public ClAddress AddressId
        {
              get{ return addressId;}
              set{ addressId = value;}
        }
        public DateTime LastUpdate
        {
              get{ return lastUpdate;}
              set{ lastUpdate = value;}
        }
	    //***********   Constructor para Primary Key( Select y Delete)
        public  ClStore(int storeId)
        {
		   StoreId=storeId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClStore(int storeId,int managerStaffId,ClAddress addressId,DateTime lastUpdate)
        {
		   StoreId=storeId;
		   ManagerStaffId=managerStaffId;
		   AddressId=addressId;
		   LastUpdate=lastUpdate;
        }		
  }
}
