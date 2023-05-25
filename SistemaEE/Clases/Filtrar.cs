using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEE.Clases
{
    internal class Filtrar
    {
        public void FiltrarProductos(DataGridView dgvProductos, string filtro)
        {
            ConectaDB.AbrirDB();
            string consultaProductos = "SELECT * FROM productos WHERE nombre LIKE '%' + @filtro + '%' OR categoria LIKE '%' + @filtro + '%' OR marca LIKE '%' + @filtro + '%'";
            SqlCommand comando = new SqlCommand(consultaProductos, DB.ConexionConBD);
            comando.Parameters.AddWithValue("@filtro", filtro);
            DB.lector = comando.ExecuteReader();
            dgvProductos.Rows.Clear(); // Limpia los datos anteriores en la grilla

            while (DB.lector.Read())
            {
                dgvProductos.Rows.Add(
                    DB.lector["id_producto"],
                    "",
                    DB.lector["nombre"],
                    DB.lector["categoria"],
                    DB.lector["marca"]
                );
            }

            dgvProductos.ClearSelection();
            DB.lector.Close();
            ConectaDB.CerrarDB();
        }
        public void FiltrarProveedores(DataGridView dgvProveedor, string filtro)
        {
            ConectaDB.AbrirDB();
            string consultaProveedor = "SELECT * FROM proveedor WHERE cuit_prov LIKE '%' + @filtro + '%' OR nombre_prov LIKE '%' + @filtro + '%' OR domicilio_prov LIKE '%' + @filtro + '%' OR mail_prov LIKE '%' + @filtro + '%' OR condicion LIKE '%' + @filtro + '%'";
            SqlCommand comando = new SqlCommand(consultaProveedor, DB.ConexionConBD);
            comando.Parameters.AddWithValue("@filtro", filtro);
            DB.lector = comando.ExecuteReader();
            dgvProveedor.Rows.Clear(); // Limpia los datos anteriores en la grilla

            while (DB.lector.Read())
            {
                dgvProveedor.Rows.Add(
                    "",
                    DB.lector["cuit_prov"],
                    DB.lector["nombre_prov"],
                    DB.lector["domicilio_prov"],
                    DB.lector["mail_prov"],
                    DB.lector["condicion"]
                );
            }

            dgvProveedor.ClearSelection();
            DB.lector.Close();
        }
        public void FiltrarClientes(DataGridView dgvCliente, string filtro)
        {
            ConectaDB.AbrirDB();
            string consultaCliente = "SELECT * FROM clientes WHERE cuit_cliente LIKE '%' + @filtro + '%' OR cliente_nombre LIKE '%' + @filtro + '%' OR direccion LIKE '%' + @filtro + '%' OR mail_cliente LIKE '%' + @filtro + '%' OR condicion_cliente LIKE '%' + @filtro + '%'";
            SqlCommand comando = new SqlCommand(consultaCliente, DB.ConexionConBD);
            comando.Parameters.AddWithValue("@filtro", filtro);
            DB.lector = comando.ExecuteReader();
            dgvCliente.Rows.Clear(); // Limpia los datos anteriores en la grilla

            while (DB.lector.Read())
            {
                dgvCliente.Rows.Add(
                    "",
                    DB.lector["cuit_cliente"],
                    DB.lector["cliente_nombre"],
                    DB.lector["direccion"],
                    DB.lector["mail_cliente"],
                    DB.lector["condicion_cliente"]
                );
            }

            dgvCliente.ClearSelection();
            DB.lector.Close();
        }
        public void FiltrarUsuarios(DataGridView dgvUsuarios, string filtro)
        {
            ConectaDB.AbrirDB();
            string consultaUsuario = "SELECT * FROM usuarios WHERE Id_usuario LIKE '%' + @filtro + '%' OR Usuario LIKE '%' + @filtro + '%' OR Contra LIKE '%' + @filtro + '%' OR Tipo_usuario LIKE '%' + @filtro + '%'";
            SqlCommand comando = new SqlCommand(consultaUsuario, DB.ConexionConBD);
            comando.Parameters.AddWithValue("@filtro", filtro);
            DB.lector = comando.ExecuteReader();
            dgvUsuarios.Rows.Clear(); // Limpia los datos anteriores en la grilla

            while (DB.lector.Read())
            {
                dgvUsuarios.Rows.Add(
                    DB.lector["Id_usuario"],
                    "",
                    DB.lector["Usuario"],
                    DB.lector["Contra"],
                    DB.lector["Tipo_usuario"]
                );
            }

            dgvUsuarios.ClearSelection();
            DB.lector.Close();
            ConectaDB.CerrarDB();
        }

    }
}
