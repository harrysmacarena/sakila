using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl.Harrys.MyBD
{
    public class MyBD
    {
        private static MyBD bd;
        private SqlCommand cmd;
        private SqlConnection cnn;
        private  MyBD()
        {
            cnn = new SqlConnection("");
            cnn.Open();
        }
        public static MyBD getInstance()
        {
            if (bd == null)
            {
                bd = new MyBD();
            }
            return bd;
        }
        public DataTable sqlSelect(String sql,int nPagina,int nCantidad)
        {
            DataTable dt = new DataTable(); 
            cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(nPagina * nCantidad, nCantidad, dt);
            return dt;
        }
        public int sqlEjecutar(String sql)
        {
            cmd = new SqlCommand(sql,cnn);
            return cmd.ExecuteNonQuery();
        }
    }
}
