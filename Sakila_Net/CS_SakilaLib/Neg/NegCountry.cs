using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegCountry
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAOCountry.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClCountry country) 
        {
            return DAO.DAOCountry.sqlSelect(country);
        }
        public  static int crear(ClCountry country)
        {
            return DAO.DAOCountry.sqlInsert(country);
        }
        public  static int eliminar(ClCountry country)
        {
            return DAO.DAOCountry.sqlDelete(country);
        }
        public  static int actualizar(ClCountry country)
        {
            return DAO.DAOCountry.sqlUpdate(country);
        }
    }
}
