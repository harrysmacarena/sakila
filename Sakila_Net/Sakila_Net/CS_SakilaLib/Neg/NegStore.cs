using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegStore
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAOStore.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClStore store) 
        {
            return DAO.DAOStore.sqlSelect(store);
        }
        public  static int crear(ClStore store)
        {
            return DAO.DAOStore.sqlInsert(store);
        }
        public  static int eliminar(ClStore store)
        {
            return DAO.DAOStore.sqlDelete(store);
        }
        public  static int actualizar(ClStore store)
        {
            return DAO.DAOStore.sqlUpdate(store);
        }
    }
}
