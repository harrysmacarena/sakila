using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegFilmText
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAOFilmText.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClFilmText filmText) 
        {
            return DAO.DAOFilmText.sqlSelect(filmText);
        }
        public  static int crear(ClFilmText filmText)
        {
            return DAO.DAOFilmText.sqlInsert(filmText);
        }
        public  static int eliminar(ClFilmText filmText)
        {
            return DAO.DAOFilmText.sqlDelete(filmText);
        }
        public  static int actualizar(ClFilmText filmText)
        {
            return DAO.DAOFilmText.sqlUpdate(filmText);
        }
    }
}
