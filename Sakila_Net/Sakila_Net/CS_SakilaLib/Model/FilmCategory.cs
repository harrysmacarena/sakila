using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClFilmCategory
    {
	    //***********   Atributos o Propiedades
        private ClFilm filmId;
        private ClCategory categoryId;
        private DateTime lastUpdate;
	    //***********   Accesadores y  Mutadores
        public ClFilm FilmId
        {
              get{ return filmId;}
              set{ filmId = value;}
        }
        public ClCategory CategoryId
        {
              get{ return categoryId;}
              set{ categoryId = value;}
        }
        public DateTime LastUpdate
        {
              get{ return lastUpdate;}
              set{ lastUpdate = value;}
        }
	    //***********   Constructor para Primary Key( Select y Delete)
        public  ClFilmCategory(ClFilm filmId,ClCategory categoryId)
        {
		   FilmId=filmId;
		   CategoryId=categoryId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClFilmCategory(ClFilm filmId,ClCategory categoryId,DateTime lastUpdate)
        {
		   FilmId=filmId;
		   CategoryId=categoryId;
		   LastUpdate=lastUpdate;
        }		
  }
}
