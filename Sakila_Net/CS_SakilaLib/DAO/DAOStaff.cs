//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAOStaff 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAOStaff.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClStaff staff)
	   {
            return DAOBD.DAOStaff.SelectOne(staff); 
	   }
	   public static int sqlInsert(ClStaff staff)
	   {
            return DAOBD.DAOStaff.sqlInsert(staff);
       }
	   public static int sqlDelete(ClStaff staff)
	   {
            return DAOBD.DAOStaff.sqlDelete(staff);
       }
	   public static int sqlUpdate(ClStaff staff)
	   {
            return DAOBD.DAOStaff.sqlUpdate(staff);
       }
   }
}
