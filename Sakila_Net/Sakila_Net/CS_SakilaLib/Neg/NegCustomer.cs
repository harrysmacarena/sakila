using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegCustomer
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAOCustomer.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClCustomer customer) 
        {
            return DAO.DAOCustomer.sqlSelect(customer);
        }
        public  static int crear(ClCustomer customer)
        {
            return DAO.DAOCustomer.sqlInsert(customer);
        }
        public  static int eliminar(ClCustomer customer)
        {
            return DAO.DAOCustomer.sqlDelete(customer);
        }
        public  static int actualizar(ClCustomer customer)
        {
            return DAO.DAOCustomer.sqlUpdate(customer);
        }
    }
}
