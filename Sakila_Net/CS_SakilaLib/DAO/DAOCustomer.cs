//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAOCustomer 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAOCustomer.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClCustomer customer)
	   {
            return DAOBD.DAOCustomer.SelectOne(customer); 
	   }
	   public static int sqlInsert(ClCustomer customer)
	   {
            return DAOBD.DAOCustomer.sqlInsert(customer);
       }
	   public static int sqlDelete(ClCustomer customer)
	   {
            return DAOBD.DAOCustomer.sqlDelete(customer);
       }
	   public static int sqlUpdate(ClCustomer customer)
	   {
            return DAOBD.DAOCustomer.sqlUpdate(customer);
       }
   }
}
