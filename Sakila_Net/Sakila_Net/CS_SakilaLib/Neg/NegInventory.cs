using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegInventory
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAOInventory.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClInventory inventory) 
        {
            return DAO.DAOInventory.sqlSelect(inventory);
        }
        public  static int crear(ClInventory inventory)
        {
            return DAO.DAOInventory.sqlInsert(inventory);
        }
        public  static int eliminar(ClInventory inventory)
        {
            return DAO.DAOInventory.sqlDelete(inventory);
        }
        public  static int actualizar(ClInventory inventory)
        {
            return DAO.DAOInventory.sqlUpdate(inventory);
        }
    }
}
