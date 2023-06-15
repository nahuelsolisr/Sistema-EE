using MaterialSkin;
using MaterialSkin.Controls;
using SistemaEE.AccesoDatos;
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
    public partial class ProductosEnStock : MaterialForm
    {
        public ProductosEnStock()
        {
            InitializeComponent();
            this.Size = new Size(694, 469);
            this.Resize += (sender, e) => this.Size = new Size(694, 469);
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = true;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
            //
            dgv_Productos();
            if (Datos.modoOscuro)
            {
                EstiloOscuro();
            }
            else
            {
                EstiloClaro();
            }
        }
        public void EstiloClaro()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
        public void EstiloOscuro()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; // Cambiar a tema oscuro
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE); // Ajustar colores para modo oscuro
        }
        public void dgv_Productos()
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
                Datos.precioProducto = Convert.ToDecimal(dgvProductos.Rows[e.RowIndex].Cells["Column1"].Value);
                Datos.idProducto = Convert.ToInt32(idProductoStr);
                Datos.nomProducto = Convert.ToString(dgvProductos.Rows[e.RowIndex].Cells["Column2"].Value);
                Datos.categoria = Convert.ToString(dgvProductos.Rows[e.RowIndex].Cells["Column3"].Value);
                Datos.marca = Convert.ToString(dgvProductos.Rows[e.RowIndex].Cells["Column4"].Value);
                Datos.cantidad = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Column5"].Value);

                this.Close();
            }
        }



        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txt_filtrar.Text;
            Filtrar filtrador = new Filtrar();
            filtrador.FiltrarProductos(dgvProductos, filtro);
        }

        private void ProductosEnStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
