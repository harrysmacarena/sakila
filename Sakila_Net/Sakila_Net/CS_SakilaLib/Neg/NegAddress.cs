using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegAddress
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAOAddress.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClAddress address) 
        {
            return DAO.DAOAddress.sqlSelect(address);
        }
        public  static int crear(ClAddress address)
        {
            return DAO.DAOAddress.sqlInsert(address);
        }
        public  static int eliminar(ClAddress address)
        {
            return DAO.DAOAddress.sqlDelete(address);
        }
        public  static int actualizar(ClAddress address)
        {
            return DAO.DAOAddress.sqlUpdate(address);
        }
    }
}
