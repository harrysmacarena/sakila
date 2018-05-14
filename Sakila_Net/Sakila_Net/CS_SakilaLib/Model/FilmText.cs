using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClFilmText
    {
	    //***********   Atributos o Propiedades
        private int filmId;
        private string title;
        private string description;
	    //***********   Accesadores y  Mutadores
        public int FilmId
        {
              get{ return filmId;}
              set{ filmId = value;}
        }
        public string Title
        {
              get{ return title;}
              set{ title = value;}
        }
        public string Description
        {
              get{ return description;}
              set{ description = value;}
        }
	    //***********   Constructor para Primary Key( Select y Delete)
        public  ClFilmText(int filmId)
        {
		   FilmId=filmId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClFilmText(int filmId,string title,string description)
        {
		   FilmId=filmId;
		   Title=title;
		   Description=description;
        }		
  }
}
