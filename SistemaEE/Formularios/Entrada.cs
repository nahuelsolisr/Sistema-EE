using SistemaEE.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEE.Formularios
{
    public partial class Entrada : Form
    {

        private List<Producto> carrito = new List<Producto>();


        public Entrada()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btn_TraerProveedor_Click_1(object sender, EventArgs e)
        {
            MuestraProveedor muestraProveedor = new MuestraProveedor();
            muestraProveedor.ShowDialog();
            txt_cuit.Text = Elegir.cuit_prov.ToString();
            txt_provNombre.Text = Elegir.nom_prov;
        }

        private void btn_traerProduct_Click(object sender, EventArgs e)
        {
            MuestraProductos muestraProductos = new MuestraProductos();
            muestraProductos.ShowDialog();
            txt_idproducto.Text = Elegir.idProducto.ToString();
            txt_nombreProducto.Text = Elegir.nomProducto;
        }


        private void btn_añadir_Click(object sender, EventArgs e)
        {
            // Obtén los datos del producto del formulario
            string idProducto = txt_idproducto.Text;
            string nombreProducto = txt_nombreProducto.Text;
            decimal precio = Convert.ToDecimal(txt_precio.Text);
            int cantidad = (int)nud_cantidad.Value;
            decimal ganancia = nud_ganancia.Value;


            // Crea un objeto Producto con los datos obtenidos
            Producto producto = new Producto
            {
                Id = idProducto,
                Precio = precio,
                Cantidad = cantidad,
                nombre=nombreProducto,
                Ganancia = (decimal)nud_ganancia.Value
            };

            // Agrega el producto al carrito
            carrito.Add(producto);

            // Agrega el producto a la DataGridView
            dgvCarrito.Rows.Add(nombreProducto, precio, cantidad, ganancia);
            btn_confirmar.Visible = true;
        }

        private void btn_confirmar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de realizar esta compra?", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Limpiar();
                ConectaDB.AbrirDB();

                foreach (Producto producto in carrito)
                {
                    // Actualiza los datos del producto en la base de datos
                    string cant = $"Select cantidad from productos where id_producto = {producto.Id}";
                    int cantidadActual = 0;

                    // Realiza la lectura de la base de datos para obtener la cantidad actual del producto
                    using (var reader = ConectaDB.LecturaDB(cant))
                    {
                        if (reader.Read())
                        {
                            cantidadActual = Convert.ToInt32(reader["cantidad"]);
                        }
                    }

                    int cantidadNetaEntrada = cantidadActual + producto.Cantidad;
                    decimal total_stock = cantidadNetaEntrada * producto.Precio;
                    total_stock.ToString();
                    string updateEntrada = $"UPDATE productos SET cantidad = {cantidadNetaEntrada}, precio = {producto.Precio}, porcentajeg = {producto.Ganancia} WHERE id_producto = {producto.Id}";
                    ConectaDB.CargarDB(updateEntrada);
                    decimal totalEntrada = producto.Precio * producto.Cantidad;
                    totalEntrada.ToString();

                    //Realiza el insert en la tabla "fichastock"
                    string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    string insertEntrada = $"INSERT INTO fichastock (cantidad_entrada, precio_unit_entrada, cod_producto, nombre_producto, total_entrada, fecha, cantidad_stock, precio_unit_stock, total_stock) " + $"VALUES ('{producto.Cantidad}', '{producto.Precio}', {producto.Id}, '{producto.nombre}', '{totalEntrada}', '{fecha}', '{cantidadNetaEntrada}', '{producto.Precio}', '{total_stock}')";
                    ConectaDB.CargarDB(insertEntrada);
                }

                MessageBox.Show("Su compra ha sido realizada");

                // Cierra la conexión a la base de datos
                ConectaDB.CerrarDB();

            }
            else if (result == DialogResult.Cancel)
            {

            }
            else
            {

            }


        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class Producto
        {
            public string Id { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
            public decimal Ganancia { get; set; }
            public string nombre { get; set; }
        }
        public void Limpiar()
        {
            dgvCarrito.Rows.Clear();

            txt_precio.Text = "";
            txt_idproducto.Text = "";
            txt_nombreProducto.Text = "";
            nud_cantidad.Value = 0;
            nud_ganancia.Value = 0;

        }
    }
}
