using SistemaEE.Clases;
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
    public partial class MuestraProductos : Form
    {
        public MuestraProductos()
        {
            InitializeComponent();
            dgv_Productos();
        }

        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProductos.Columns[e.ColumnIndex].Name == "btn_seleccionar")
            {
                Elegir.idProducto = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Column0"].Value);
                Elegir.nomProducto= Convert.ToString(dgvProductos.Rows[e.RowIndex].Cells["Column2"].Value);
                this.Close();

            }
        }
        public void dgv_Productos()
        {
            ConectaDB.AbrirDB();
            string consultaProductos = "SELECT * FROM productos WHERE cuit_prov = '" + Elegir.cuit_prov + "'";
            ConectaDB.LecturaDB(consultaProductos);
            dgvProductos.Rows.Clear(); // Limpia los datos anteriores en la grilla

            while (DB.lector.Read())
            {
                //En lugar de asignar cada valor al valor de una celda específica de la grilla, 
                //se puede agregar una fila completa a la grilla de una sola vez, utilizando el método 
                //Add() de la propiedad Rows de la grilla.

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
        }
    }
}
