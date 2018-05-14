using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegCategory
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAOCategory.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClCategory category) 
        {
            return DAO.DAOCategory.sqlSelect(category);
        }
        public  static int crear(ClCategory category)
        {
            return DAO.DAOCategory.sqlInsert(category);
        }
        public  static int eliminar(ClCategory category)
        {
            return DAO.DAOCategory.sqlDelete(category);
        }
        public  static int actualizar(ClCategory category)
        {
            return DAO.DAOCategory.sqlUpdate(category);
        }
    }
}
