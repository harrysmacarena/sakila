using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegRental
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAORental.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClRental rental) 
        {
            return DAO.DAORental.sqlSelect(rental);
        }
        public  static int crear(ClRental rental)
        {
            return DAO.DAORental.sqlInsert(rental);
        }
        public  static int eliminar(ClRental rental)
        {
            return DAO.DAORental.sqlDelete(rental);
        }
        public  static int actualizar(ClRental rental)
        {
            return DAO.DAORental.sqlUpdate(rental);
        }
    }
}
