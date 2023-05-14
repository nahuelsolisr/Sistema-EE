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
    public partial class MuestraProveedor : Form
    {
        public MuestraProveedor()
        {
            InitializeComponent();
            dgv_Proveedores();
        }

        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0 && dgvProveedor.Columns[e.ColumnIndex].Name == "btn_seleccionar")
            {
                Clases.Entrada.cuit = Convert.ToDecimal(dgvProveedor.Rows[e.RowIndex].Cells["Column0"].Value);
                Clases.Entrada.nombreProv = Convert.ToString(dgvProveedor.Rows[e.RowIndex].Cells["Column1"].Value);
                Entrada enviarDatos = new Entrada(Clases.Entrada.cuit, Clases.Entrada.nombreProv, Clases.Entrada.idProducto, Clases.Entrada.nombreProducto);
                this.Close();
                enviarDatos.Show();
            }
        }
        public void dgv_Proveedores()
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
                    DB.lector["domicilio_prov"],
                    DB.lector["mail_prov"],
                    DB.lector["condicion"]


                );
            }

            dgvProveedor.ClearSelection();
            DB.lector.Close();
        }
    }
}
