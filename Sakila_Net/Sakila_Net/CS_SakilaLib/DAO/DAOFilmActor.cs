//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAOFilmActor 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAOFilmActor.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClFilmActor filmActor)
	   {
            return DAOBD.DAOFilmActor.SelectOne(filmActor); 
	   }
	   public static int sqlInsert(ClFilmActor filmActor)
	   {
            return DAOBD.DAOFilmActor.sqlInsert(filmActor);
       }
	   public static int sqlDelete(ClFilmActor filmActor)
	   {
            return DAOBD.DAOFilmActor.sqlDelete(filmActor);
       }
	   public static int sqlUpdate(ClFilmActor filmActor)
	   {
            return DAOBD.DAOFilmActor.sqlUpdate(filmActor);
       }
   }
}
