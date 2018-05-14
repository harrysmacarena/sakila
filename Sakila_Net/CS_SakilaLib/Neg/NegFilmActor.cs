using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegFilmActor
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAOFilmActor.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClFilmActor filmActor) 
        {
            return DAO.DAOFilmActor.sqlSelect(filmActor);
        }
        public  static int crear(ClFilmActor filmActor)
        {
            return DAO.DAOFilmActor.sqlInsert(filmActor);
        }
        public  static int eliminar(ClFilmActor filmActor)
        {
            return DAO.DAOFilmActor.sqlDelete(filmActor);
        }
        public  static int actualizar(ClFilmActor filmActor)
        {
            return DAO.DAOFilmActor.sqlUpdate(filmActor);
        }
    }
}
