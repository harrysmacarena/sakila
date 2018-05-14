//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAOFilm 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAOFilm.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClFilm film)
	   {
            return DAOBD.DAOFilm.SelectOne(film); 
	   }
	   public static int sqlInsert(ClFilm film)
	   {
            return DAOBD.DAOFilm.sqlInsert(film);
       }
	   public static int sqlDelete(ClFilm film)
	   {
            return DAOBD.DAOFilm.sqlDelete(film);
       }
	   public static int sqlUpdate(ClFilm film)
	   {
            return DAOBD.DAOFilm.sqlUpdate(film);
       }
   }
}
