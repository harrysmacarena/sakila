using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClLanguage
    {
	    //***********   Atributos o Propiedades
        private int languageId;
        private string name;
        private DateTime lastUpdate;
	    //***********   Accesadores y  Mutadores
        public int LanguageId
        {
              get{ return languageId;}
              set{ languageId = value;}
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
        public  ClLanguage(int languageId)
        {
		   LanguageId=languageId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClLanguage(int languageId,string name,DateTime lastUpdate)
        {
		   LanguageId=languageId;
		   Name=name;
		   LastUpdate=lastUpdate;
        }		
  }
}
