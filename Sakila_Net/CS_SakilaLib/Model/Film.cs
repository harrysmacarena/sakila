using System;
using System.Data;
using System.Configuration;
using System.Drawing;
//using System.Drawing.Imaging;

namespace  Cl.Harrys.Sakila.Model
{   
    public class ClFilm
    {
	    //***********   Atributos o Propiedades
        private int filmId;
        private string title;
        private string description;
        private int releaseYear;
        private ClLanguage languageId;
        private int originalLanguageId;
        private int rentalDuration;
        private double rentalRate;
        private int length;
        private double replacementCost;
        private string rating;
        private string specialFeatures;
        private DateTime lastUpdate;
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
        public int ReleaseYear
        {
              get{ return releaseYear;}
              set{ releaseYear = value;}
        }
        public ClLanguage LanguageId
        {
              get{ return languageId;}
              set{ languageId = value;}
        }
        public int OriginalLanguageId
        {
              get{ return originalLanguageId;}
              set{ originalLanguageId = value;}
        }
        public int RentalDuration
        {
              get{ return rentalDuration;}
              set{ rentalDuration = value;}
        }
        public double RentalRate
        {
              get{ return rentalRate;}
              set{ rentalRate = value;}
        }
        public int Length
        {
              get{ return length;}
              set{ length = value;}
        }
        public double ReplacementCost
        {
              get{ return replacementCost;}
              set{ replacementCost = value;}
        }
        public string Rating
        {
              get{ return rating;}
              set{ rating = value;}
        }
        public string SpecialFeatures
        {
              get{ return specialFeatures;}
              set{ specialFeatures = value;}
        }
        public DateTime LastUpdate
        {
              get{ return lastUpdate;}
              set{ lastUpdate = value;}
        }
	    //***********   Constructor para Primary Key( Select y Delete)
        public  ClFilm(int filmId)
        {
		   FilmId=filmId;
        }		
	    //***********   Constructor con todos los parámetros (Insert y Update)
        public  ClFilm(int filmId,string title,string description,int releaseYear,ClLanguage languageId,int originalLanguageId,int rentalDuration,double rentalRate,int length,double replacementCost,string rating,string specialFeatures,DateTime lastUpdate)
        {
		   FilmId=filmId;
		   Title=title;
		   Description=description;
		   ReleaseYear=releaseYear;
		   LanguageId=languageId;
		   OriginalLanguageId=originalLanguageId;
		   RentalDuration=rentalDuration;
		   RentalRate=rentalRate;
		   Length=length;
		   ReplacementCost=replacementCost;
		   Rating=rating;
		   SpecialFeatures=specialFeatures;
		   LastUpdate=lastUpdate;
        }		
  }
}
