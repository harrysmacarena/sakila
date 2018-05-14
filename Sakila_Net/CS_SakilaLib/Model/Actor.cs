using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClActor
    {
	    //***********   Atributos o Propiedades
        private int actorId;
        private string firstName;
        private string lastName;
        private DateTime lastUpdate;
	    //***********   Accesadores y  Mutadores
        public int ActorId
        {
              get{ return actorId;}
              set{ actorId = value;}
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
        public DateTime LastUpdate
        {
              get{ return lastUpdate;}
              set{ lastUpdate = value;}
        }
	    //***********   Constructor para Primary Key( Select y Delete)
        public  ClActor(int actorId)
        {
		   ActorId=actorId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClActor(int actorId,string firstName,string lastName,DateTime lastUpdate)
        {
		   ActorId=actorId;
		   FirstName=firstName;
		   LastName=lastName;
		   LastUpdate=lastUpdate;
        }		
  }
}
