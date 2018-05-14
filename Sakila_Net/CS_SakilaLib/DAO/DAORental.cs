//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAORental 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAORental.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClRental rental)
	   {
            return DAOBD.DAORental.SelectOne(rental); 
	   }
	   public static int sqlInsert(ClRental rental)
	   {
            return DAOBD.DAORental.sqlInsert(rental);
       }
	   public static int sqlDelete(ClRental rental)
	   {
            return DAOBD.DAORental.sqlDelete(rental);
       }
	   public static int sqlUpdate(ClRental rental)
	   {
            return DAOBD.DAORental.sqlUpdate(rental);
       }
   }
}
