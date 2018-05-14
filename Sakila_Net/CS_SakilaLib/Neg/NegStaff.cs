using System.Data;
using Cl.Harrys.Sakila.DAO;
using Cl.Harrys.Sakila.Model;
namespace Cl.Harrys.Sakila.Neg
{
    public class ClNegStaff
    {
        public static DataTable listar(int nPagina ,int cantidad)
        {
            return DAO.DAOStaff.sqlSelectAll(nPagina, cantidad);
        }
        public  static bool consultar( ClStaff staff) 
        {
            return DAO.DAOStaff.sqlSelect(staff);
        }
        public  static int crear(ClStaff staff)
        {
            return DAO.DAOStaff.sqlInsert(staff);
        }
        public  static int eliminar(ClStaff staff)
        {
            return DAO.DAOStaff.sqlDelete(staff);
        }
        public  static int actualizar(ClStaff staff)
        {
            return DAO.DAOStaff.sqlUpdate(staff);
        }
    }
}
