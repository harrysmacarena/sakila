using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClRental
    {
	    //***********   Atributos o Propiedades
        private int rentalId;
        private DateTime rentalDate;
        private ClInventory inventoryId;
        private ClCustomer customerId;
        private DateTime returnDate;
        private ClStaff staffId;
        private DateTime lastUpdate;
	    //***********   Accesadores y  Mutadores
        public int RentalId
        {
              get{ return rentalId;}
              set{ rentalId = value;}
        }
        public DateTime RentalDate
        {
              get{ return rentalDate;}
              set{ rentalDate = value;}
        }
        public ClInventory InventoryId
        {
              get{ return inventoryId;}
              set{ inventoryId = value;}
        }
        public ClCustomer CustomerId
        {
              get{ return customerId;}
              set{ customerId = value;}
        }
        public DateTime ReturnDate
        {
              get{ return returnDate;}
              set{ returnDate = value;}
        }
        public ClStaff StaffId
        {
              get{ return staffId;}
              set{ staffId = value;}
        }
        public DateTime LastUpdate
        {
              get{ return lastUpdate;}
              set{ lastUpdate = value;}
        }
	    //***********   Constructor para Primary Key( Select y Delete)
        public  ClRental(int rentalId)
        {
		   RentalId=rentalId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClRental(int rentalId,DateTime rentalDate,ClInventory inventoryId,ClCustomer customerId,DateTime returnDate,ClStaff staffId,DateTime lastUpdate)
        {
		   RentalId=rentalId;
		   RentalDate=rentalDate;
		   InventoryId=inventoryId;
		   CustomerId=customerId;
		   ReturnDate=returnDate;
		   StaffId=staffId;
		   LastUpdate=lastUpdate;
        }		
  }
}
