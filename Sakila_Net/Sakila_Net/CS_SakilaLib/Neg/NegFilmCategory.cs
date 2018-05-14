using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegFilmCategory
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAOFilmCategory.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClFilmCategory filmCategory) 
        {
            return DAO.DAOFilmCategory.sqlSelect(filmCategory);
        }
        public  static int crear(ClFilmCategory filmCategory)
        {
            return DAO.DAOFilmCategory.sqlInsert(filmCategory);
        }
        public  static int eliminar(ClFilmCategory filmCategory)
        {
            return DAO.DAOFilmCategory.sqlDelete(filmCategory);
        }
        public  static int actualizar(ClFilmCategory filmCategory)
        {
            return DAO.DAOFilmCategory.sqlUpdate(filmCategory);
        }
    }
}
