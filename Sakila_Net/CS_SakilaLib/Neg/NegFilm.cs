using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegFilm
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAOFilm.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClFilm film) 
        {
            return DAO.DAOFilm.sqlSelect(film);
        }
        public  static int crear(ClFilm film)
        {
            return DAO.DAOFilm.sqlInsert(film);
        }
        public  static int eliminar(ClFilm film)
        {
            return DAO.DAOFilm.sqlDelete(film);
        }
        public  static int actualizar(ClFilm film)
        {
            return DAO.DAOFilm.sqlUpdate(film);
        }
    }
}
