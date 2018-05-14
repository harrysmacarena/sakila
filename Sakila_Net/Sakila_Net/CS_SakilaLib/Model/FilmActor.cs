using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClFilmActor
    {
	    //***********   Atributos o Propiedades
        private ClActor actorId;
        private ClFilm filmId;
        private DateTime lastUpdate;
	    //***********   Accesadores y  Mutadores
        public ClActor ActorId
        {
              get{ return actorId;}
              set{ actorId = value;}
        }
        public ClFilm FilmId
        {
              get{ return filmId;}
              set{ filmId = value;}
        }
        public DateTime LastUpdate
        {
              get{ return lastUpdate;}
              set{ lastUpdate = value;}
        }
	    //***********   Constructor para Primary Key( Select y Delete)
        public  ClFilmActor(ClActor actorId,ClFilm filmId)
        {
		   ActorId=actorId;
		   FilmId=filmId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClFilmActor(ClActor actorId,ClFilm filmId,DateTime lastUpdate)
        {
		   ActorId=actorId;
		   FilmId=filmId;
		   LastUpdate=lastUpdate;
        }		
  }
}
