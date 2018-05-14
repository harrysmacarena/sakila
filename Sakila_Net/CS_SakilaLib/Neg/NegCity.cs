using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegCity
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAOCity.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClCity city) 
        {
            return DAO.DAOCity.sqlSelect(city);
        }
        public  static int crear(ClCity city)
        {
            return DAO.DAOCity.sqlInsert(city);
        }
        public  static int eliminar(ClCity city)
        {
            return DAO.DAOCity.sqlDelete(city);
        }
        public  static int actualizar(ClCity city)
        {
            return DAO.DAOCity.sqlUpdate(city);
        }
    }
}
