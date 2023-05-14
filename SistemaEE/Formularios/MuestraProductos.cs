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
                Clases.Entrada.idProducto = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Column0"].Value);
                Clases.Entrada.nombreProducto= Convert.ToString(dgvProductos.Rows[e.RowIndex].Cells["Column2"].Value);
                Entrada enviarDatos = new Entrada(Clases.Entrada.cuit, Clases.Entrada.nombreProv, Clases.Entrada.idProducto, Clases.Entrada.nombreProducto);
                this.Close();
                enviarDatos.Show();

            }
        }
        public void dgv_Productos()
        {
            ConectaDB.AbrirDB();
            string consultaproductos = "SELECT * FROM productos";
            ConectaDB.LecturaDB(consultaproductos);
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
