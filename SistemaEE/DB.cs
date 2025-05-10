using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Microsoft.VisualBasic.ApplicationServices;

namespace SistemaEE
{
    internal class DB
    {
       //
        public static SqlConnection ConexionConBD;
        //public static string strConexión = "Data Source=DESKTOP-9UILVSA\\SQLEXPRESS;Initial Catalog=EconomiaEmpresarial;Integrated Security=True";
        public static string strConexión = "Data Source=RODRIGO\\DEVELOPER;Initial Catalog=EconomiaEmpresarial; Integrated Security=True";
        public static SqlCommand Orden;
        public static SqlDataReader lector;
     
    }
}
