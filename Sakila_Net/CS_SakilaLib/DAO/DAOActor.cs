//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAOActor 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAOActor.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClActor actor)
	   {
            return DAOBD.DAOActor.SelectOne(actor); 
	   }
	   public static int sqlInsert(ClActor actor)
	   {
            return DAOBD.DAOActor.sqlInsert(actor);
       }
	   public static int sqlDelete(ClActor actor)
	   {
            return DAOBD.DAOActor.sqlDelete(actor);
       }
	   public static int sqlUpdate(ClActor actor)
	   {
            return DAOBD.DAOActor.sqlUpdate(actor);
       }
   }
}
