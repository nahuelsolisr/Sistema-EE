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
using static SistemaEE.Formularios.Entrada;

namespace SistemaEE.Formularios
{
    public partial class Salidas : Form
    {
        private List<Producto> carrito = new List<Producto>();
        public int contadorCompras = 0;
        private ProductosEnStock formularioProductos;
        string nombre;


        int cantidadComprada;

        public Salidas()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //compras = new object[100, 6];
        }

        private void btn_TraerCliente_Click(object sender, EventArgs e)
        {
            MuestraCliente muestraCliente = new MuestraCliente();
            muestraCliente.ShowDialog();
            txt_cuit.Text = Elegir.CUITCliente.ToString();
            txt_nombreCliente.Text = Elegir.NombreCliente;
        }

        private void btn_traerProduct_Click(object sender, EventArgs e)
        {
            ProductosEnStock productosEnStock = new ProductosEnStock();
            productosEnStock.ShowDialog();
            txt_idproducto.Text = Elegir.idProducto.ToString();
            txt_nombreProducto.Text = Elegir.nomProducto;
            txt_precio.Text = Elegir.precioProducto.ToString();
        }

        private int ObtenerCantidadDisponible(string nombre)
        {
            int producto = Elegir.idProducto;
            string consultaCantidad = "SELECT cantidad FROM productos WHERE id_producto = " + producto;

            ConectaDB.AbrirDB();
            ConectaDB.LecturaDB(consultaCantidad);

            int cantidadDisponible = 0;

            if (DB.lector.Read() && !DBNull.Value.Equals(DB.lector["cantidad"]))
            {
                cantidadDisponible = Convert.ToInt32(DB.lector["cantidad"]);
            }

            DB.lector.Close();
            ConectaDB.CerrarDB();

            return cantidadDisponible;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {

            RestarCantidadVenta(nombre, cantidadComprada);
            Limpiar();
        }

        private void RestarCantidadVenta(string nombre, int cantidad)
        {
            int cantidad1 = Elegir.cantidad;
            int cantidadneta = cantidad1 - (int)nud_cantidad.Value;
            int producto = Elegir.idProducto;
            string consultaActualizarCantidad = "UPDATE productos SET cantidad = " + cantidadneta + " where id_producto =" + producto;
           
            ConectaDB.CargarDB(consultaActualizarCantidad);
            MessageBox.Show("Compra realizada correctamente");
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            ConectaDB.AbrirDB();
            int id_producto = Elegir.idProducto;
            int limitecantidad = Elegir.cantidad;
            int CantidadNetaSalida = limitecantidad - (int)nud_cantidad.Value;
            CantidadNetaSalida.ToString();
            string nombreProducto = Elegir.nomProducto;
            string marcaProducto = Elegir.marca;
            string categoriaProducto = Elegir.categoria;
            decimal precioConGanancia = Elegir.precioProducto;
            cantidadComprada = Convert.ToInt32(nud_cantidad.Value);

            // Verificar la cantidad disponible del producto
            int cantidadDisponible = ObtenerCantidadDisponible(nombre);
            if (cantidadDisponible == -1)
            {
                MessageBox.Show("El producto no se encuentra disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cantidadComprada > cantidadDisponible)
            {
                MessageBox.Show("No hay suficiente cantidad disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string precio = $"Select precio from productos where id_producto = {id_producto}";
            int preciocosto = 0;

            // Realiza la lectura de la base de datos para obtener la cantidad actual del producto
            ConectaDB.AbrirDB();
            using (var reader = ConectaDB.LecturaDB(precio))
            {
                if (reader.Read())
                {
                    preciocosto = Convert.ToInt32(reader["precio"]);
                }
            }
            ConectaDB.CerrarDB();
            // Realizar la venta
            decimal subtotal = precioConGanancia * cantidadComprada;

            // Agregar fila a la grilla
            dgvProductos.Rows.Add(nombreProducto, marcaProducto, categoriaProducto, precioConGanancia, cantidadComprada, subtotal);

            int totalsalida = CantidadNetaSalida * preciocosto;
            totalsalida.ToString();
            int totalsalida2 = cantidadComprada * Convert.ToInt32(precioConGanancia);
            totalsalida2.ToString();
            Producto producto = new Producto
            {
                Id = id_producto.ToString(),
                Precio = precioConGanancia,
                Cantidad = cantidadComprada,
                nombre = nombreProducto,
            };
            carrito.Add(producto);


            foreach (Producto productoo in carrito)
            {
                ConectaDB.AbrirDB();
                RestarCantidadVenta(nombre, cantidadComprada);
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                string insertEntrada = $"INSERT INTO fichastock (cantidad_salida, precio_unit_salida, cod_producto, nombre_producto, total_salida, fecha, cantidad_stock, precio_unit_stock, total_stock) " + $"VALUES ('{producto.Cantidad}', '{producto.Precio}', {producto.Id}, '{producto.nombre}', '{totalsalida2}', '{fecha}', '{CantidadNetaSalida}', '{preciocosto}', '{totalsalida}')";
                ConectaDB.CargarDB(insertEntrada);
                
            }
            ConectaDB.CerrarDB();
          
        }

        public void Limpiar()
        {
            // Limpiar la grilla
            dgvProductos.Rows.Clear();

            // Limpiar los campos de texto
            txt_precio.Text = "";
            nud_cantidad.Text = "";
            txt_idproducto.Text = "";
            txt_nombreProducto.Text = "";
        }
    }
}