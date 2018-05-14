//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAOLanguage 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAOLanguage.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClLanguage language)
	   {
            return DAOBD.DAOLanguage.SelectOne(language); 
	   }
	   public static int sqlInsert(ClLanguage language)
	   {
            return DAOBD.DAOLanguage.sqlInsert(language);
       }
	   public static int sqlDelete(ClLanguage language)
	   {
            return DAOBD.DAOLanguage.sqlDelete(language);
       }
	   public static int sqlUpdate(ClLanguage language)
	   {
            return DAOBD.DAOLanguage.sqlUpdate(language);
       }
   }
}
