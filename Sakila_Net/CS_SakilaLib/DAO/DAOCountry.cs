//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAOCountry 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAOCountry.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClCountry country)
	   {
            return DAOBD.DAOCountry.SelectOne(country); 
	   }
	   public static int sqlInsert(ClCountry country)
	   {
            return DAOBD.DAOCountry.sqlInsert(country);
       }
	   public static int sqlDelete(ClCountry country)
	   {
            return DAOBD.DAOCountry.sqlDelete(country);
       }
	   public static int sqlUpdate(ClCountry country)
	   {
            return DAOBD.DAOCountry.sqlUpdate(country);
       }
   }
}
