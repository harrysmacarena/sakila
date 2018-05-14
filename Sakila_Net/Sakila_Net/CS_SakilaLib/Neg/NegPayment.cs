using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegPayment
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAOPayment.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClPayment payment) 
        {
            return DAO.DAOPayment.sqlSelect(payment);
        }
        public  static int crear(ClPayment payment)
        {
            return DAO.DAOPayment.sqlInsert(payment);
        }
        public  static int eliminar(ClPayment payment)
        {
            return DAO.DAOPayment.sqlDelete(payment);
        }
        public  static int actualizar(ClPayment payment)
        {
            return DAO.DAOPayment.sqlUpdate(payment);
        }
    }
}
