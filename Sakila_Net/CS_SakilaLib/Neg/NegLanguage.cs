using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegLanguage
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAOLanguage.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClLanguage language) 
        {
            return DAO.DAOLanguage.sqlSelect(language);
        }
        public  static int crear(ClLanguage language)
        {
            return DAO.DAOLanguage.sqlInsert(language);
        }
        public  static int eliminar(ClLanguage language)
        {
            return DAO.DAOLanguage.sqlDelete(language);
        }
        public  static int actualizar(ClLanguage language)
        {
            return DAO.DAOLanguage.sqlUpdate(language);
        }
    }
}
