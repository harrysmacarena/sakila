//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAOCity 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAOCity.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClCity city)
	   {
            return DAOBD.DAOCity.SelectOne(city); 
	   }
	   public static int sqlInsert(ClCity city)
	   {
            return DAOBD.DAOCity.sqlInsert(city);
       }
	   public static int sqlDelete(ClCity city)
	   {
            return DAOBD.DAOCity.sqlDelete(city);
       }
	   public static int sqlUpdate(ClCity city)
	   {
            return DAOBD.DAOCity.sqlUpdate(city);
       }
   }
}
