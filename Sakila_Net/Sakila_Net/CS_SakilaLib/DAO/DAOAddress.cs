//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAOAddress 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAOAddress.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClAddress address)
	   {
            return DAOBD.DAOAddress.SelectOne(address); 
	   }
	   public static int sqlInsert(ClAddress address)
	   {
            return DAOBD.DAOAddress.sqlInsert(address);
       }
	   public static int sqlDelete(ClAddress address)
	   {
            return DAOBD.DAOAddress.sqlDelete(address);
       }
	   public static int sqlUpdate(ClAddress address)
	   {
            return DAOBD.DAOAddress.sqlUpdate(address);
       }
   }
}
