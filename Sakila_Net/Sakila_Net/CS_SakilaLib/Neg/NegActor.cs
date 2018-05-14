using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegActor
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAOActor.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClActor actor) 
        {
            return DAO.DAOActor.sqlSelect(actor);
        }
        public  static int crear(ClActor actor)
        {
            return DAO.DAOActor.sqlInsert(actor);
        }
        public  static int eliminar(ClActor actor)
        {
            return DAO.DAOActor.sqlDelete(actor);
        }
        public  static int actualizar(ClActor actor)
        {
            return DAO.DAOActor.sqlUpdate(actor);
        }
    }
}
