//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAOFilmCategory 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAOFilmCategory.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClFilmCategory filmCategory)
	   {
            return DAOBD.DAOFilmCategory.SelectOne(filmCategory); 
	   }
	   public static int sqlInsert(ClFilmCategory filmCategory)
	   {
            return DAOBD.DAOFilmCategory.sqlInsert(filmCategory);
       }
	   public static int sqlDelete(ClFilmCategory filmCategory)
	   {
            return DAOBD.DAOFilmCategory.sqlDelete(filmCategory);
       }
	   public static int sqlUpdate(ClFilmCategory filmCategory)
	   {
            return DAOBD.DAOFilmCategory.sqlUpdate(filmCategory);
       }
   }
}
