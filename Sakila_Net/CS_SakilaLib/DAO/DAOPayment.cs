//using System;
using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Collections;
using Cl.Harrys.Sakila.Model;
namespace  Cl.Harrys.Sakila.DAO
{   
  public class DAOPayment 
  {
       public static DataTable sqlSelectAll(int nPagina,int cantidad)
	   {
           return DAOBD.DAOPayment.selectAll(nPagina,cantidad);
	   }
       public static bool sqlSelect(ClPayment payment)
	   {
            return DAOBD.DAOPayment.SelectOne(payment); 
	   }
	   public static int sqlInsert(ClPayment payment)
	   {
            return DAOBD.DAOPayment.sqlInsert(payment);
       }
	   public static int sqlDelete(ClPayment payment)
	   {
            return DAOBD.DAOPayment.sqlDelete(payment);
       }
	   public static int sqlUpdate(ClPayment payment)
	   {
            return DAOBD.DAOPayment.sqlUpdate(payment);
       }
   }
}
