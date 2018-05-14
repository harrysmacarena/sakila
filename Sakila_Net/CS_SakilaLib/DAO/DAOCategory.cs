//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAOCategory 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAOCategory.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClCategory category)
	   {
            return DAOBD.DAOCategory.SelectOne(category); 
	   }
	   public static int sqlInsert(ClCategory category)
	   {
            return DAOBD.DAOCategory.sqlInsert(category);
       }
	   public static int sqlDelete(ClCategory category)
	   {
            return DAOBD.DAOCategory.sqlDelete(category);
       }
	   public static int sqlUpdate(ClCategory category)
	   {
            return DAOBD.DAOCategory.sqlUpdate(category);
       }
   }
}
