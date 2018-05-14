//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAOInventory 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAOInventory.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClInventory inventory)
	   {
            return DAOBD.DAOInventory.SelectOne(inventory); 
	   }
	   public static int sqlInsert(ClInventory inventory)
	   {
            return DAOBD.DAOInventory.sqlInsert(inventory);
       }
	   public static int sqlDelete(ClInventory inventory)
	   {
            return DAOBD.DAOInventory.sqlDelete(inventory);
       }
	   public static int sqlUpdate(ClInventory inventory)
	   {
            return DAOBD.DAOInventory.sqlUpdate(inventory);
       }
   }
}
