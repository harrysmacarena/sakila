//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAOStore 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAOStore.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClStore store)
	   {
            return DAOBD.DAOStore.SelectOne(store); 
	   }
	   public static int sqlInsert(ClStore store)
	   {
            return DAOBD.DAOStore.sqlInsert(store);
       }
	   public static int sqlDelete(ClStore store)
	   {
            return DAOBD.DAOStore.sqlDelete(store);
       }
	   public static int sqlUpdate(ClStore store)
	   {
            return DAOBD.DAOStore.sqlUpdate(store);
       }
   }
}
