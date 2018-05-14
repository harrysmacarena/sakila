using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClPayment
    {
	    //***********   Atributos o Propiedades
        private int paymentId;
        private ClCustomer customerId;
        private ClStaff staffId;
        private ClRental rentalId;
        private double amount;
        private DateTime paymentDate;
        private DateTime lastUpdate;
	    //***********   Accesadores y  Mutadores
        public int PaymentId
        {
              get{ return paymentId;}
              set{ paymentId = value;}
        }
        public ClCustomer CustomerId
        {
              get{ return customerId;}
              set{ customerId = value;}
        }
        public ClStaff StaffId
        {
              get{ return staffId;}
              set{ staffId = value;}
        }
        public ClRental RentalId
        {
              get{ return rentalId;}
              set{ rentalId = value;}
        }
        public double Amount
        {
              get{ return amount;}
              set{ amount = value;}
        }
        public DateTime PaymentDate
        {
              get{ return paymentDate;}
              set{ paymentDate = value;}
        }
        public DateTime LastUpdate
        {
              get{ return lastUpdate;}
              set{ lastUpdate = value;}
        }
	    //***********   Constructor para Primary Key( Select y Delete)
        public  ClPayment(int paymentId)
        {
		   PaymentId=paymentId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClPayment(int paymentId,ClCustomer customerId,ClStaff staffId,ClRental rentalId,double amount,DateTime paymentDate,DateTime lastUpdate)
        {
		   PaymentId=paymentId;
		   CustomerId=customerId;
		   StaffId=staffId;
		   RentalId=rentalId;
		   Amount=amount;
		   PaymentDate=paymentDate;
		   LastUpdate=lastUpdate;
        }		
  }
}
