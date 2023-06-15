using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace SistemaEE.AccesoDatos
{
    internal class ConectaDB
    {
        public static void AbrirDB()
        {
            DB.ConexionConBD = new SqlConnection(DB.strConexión);
            DB.ConexionConBD.Open();
        }

        public static SqlDataReader LecturaDB(string mi_consulta)
        {
            DB.Orden = new SqlCommand(mi_consulta, DB.ConexionConBD);
            DB.lector = DB.Orden.ExecuteReader();
            return DB.lector;
        }

        public static void CerrarDB()
        {
            DB.ConexionConBD.Close();
        }

        public static void CargarDB(string consulta)
        {
            DB.Orden = new SqlCommand(consulta, DB.ConexionConBD);
            DB.Orden.ExecuteNonQuery();
        }
    }
}
