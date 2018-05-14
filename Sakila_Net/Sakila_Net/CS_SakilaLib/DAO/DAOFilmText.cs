//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAOFilmText 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAOFilmText.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClFilmText filmText)
	   {
            return DAOBD.DAOFilmText.SelectOne(filmText); 
	   }
	   public static int sqlInsert(ClFilmText filmText)
	   {
            return DAOBD.DAOFilmText.sqlInsert(filmText);
       }
	   public static int sqlDelete(ClFilmText filmText)
	   {
            return DAOBD.DAOFilmText.sqlDelete(filmText);
       }
	   public static int sqlUpdate(ClFilmText filmText)
	   {
            return DAOBD.DAOFilmText.sqlUpdate(filmText);
       }
   }
}
