using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipBoard_Manager.Seguridad
{
    public class Conexion
    {
        string cadena = "Data Source=DESKTOP-JKTQPIP\\SQLEXPRESS;Initial Catalog=ClipBoardManager; Integrated Security=True";
        public SqlConnection Conectarbd = new SqlConnection();
    }
}
