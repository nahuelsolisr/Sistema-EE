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
    public partial class ProductosEnStock : Form
    {
        public ProductosEnStock()
        {
            InitializeComponent();
            TraerProductos();
        }
        public void TraerProductos()
        {
            ConectaDB.AbrirDB();
            string consultaProductos = "SELECT id_producto,nombre,categoria, marca, precio, cantidad, porcentajeg FROM productos WHERE cantidad >= 1";
            ConectaDB.LecturaDB(consultaProductos);

            while (DB.lector.Read())
            {
                string id = DB.lector["id_producto"].ToString();
                string nombre = DB.lector["nombre"].ToString();
                string categoria = DB.lector["categoria"].ToString();
                string marca = DB.lector["marca"].ToString();
                decimal precio = Convert.ToDecimal(DB.lector["precio"]);
                decimal porcentajeGanancia = Convert.ToDecimal(DB.lector["porcentajeg"]);
                int cantidad = Convert.ToInt32(DB.lector["cantidad"]);

                decimal precioConGanancia = precio * (1 + (porcentajeGanancia / 100));

                dgvProductos.Rows.Add(id
                    , "",
                    nombre, categoria, marca,
                    precioConGanancia,
                    cantidad
                        );

            }

            dgvProductos.ClearSelection();

            DB.lector.Close();
        }

        private void Seleccionar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProductos.Columns[e.ColumnIndex].Name == "btn_seleccionar")
            {
                string idProductoStr = dgvProductos.Rows[e.RowIndex].Cells["Column0"].Value.ToString();
                Elegir.precioProducto = Convert.ToDecimal(dgvProductos.Rows[e.RowIndex].Cells["Column1"].Value);
                Elegir.idProducto = Convert.ToInt32(idProductoStr);
                Elegir.nomProducto = Convert.ToString(dgvProductos.Rows[e.RowIndex].Cells["Column2"].Value);
                Elegir.categoria = Convert.ToString(dgvProductos.Rows[e.RowIndex].Cells["Column3"].Value);
                Elegir.marca = Convert.ToString(dgvProductos.Rows[e.RowIndex].Cells["Column4"].Value);
                Elegir.cantidad = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Column5"].Value);

                this.Close();
            }
        }

        private void txt_filtrarGrilla_TextChanged(object sender, EventArgs e)
        {
            string filtro = txt_filtrarGrilla.Text;
            Filtrar filtrador = new Filtrar();
            filtrador.FiltrarProductos(dgvProductos, filtro);
        }
    }
}
