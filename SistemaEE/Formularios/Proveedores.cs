using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEE.Formularios
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
            dgv_Proveedores();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void dgv_Proveedores()
        {
            {
                ConectaDB.AbrirDB();
                string consultaProveedor = "SELECT * FROM proveedor";
                ConectaDB.LecturaDB(consultaProveedor);
                dgvProveedor.Rows.Clear(); // Limpia los datos anteriores en la grilla

                while (DB.lector.Read())
                {
                    //En lugar de asignar cada valor al valor de una celda específica de la grilla, 
                    //se puede agregar una fila completa a la grilla de una sola vez, utilizando el método 
                    //Add() de la propiedad Rows de la grilla.

                    dgvProveedor.Rows.Add(
                          "",
                        DB.lector["cuit_prov"],
                        DB.lector["nombre_prov"],
                        DB.lector["condicion"]


                    );
                }

                dgvProveedor.ClearSelection();
                DB.lector.Close();
            }
        }
    }
}
