using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Salidas : MaterialForm
    {
        private List<Producto> carrito = new List<Producto>();
        public int contadorCompras = 0;
        private ProductosEnStock formularioProductos;
        string nombre;


        int cantidadComprada;

        public Salidas()
        {
            InitializeComponent();
            this.Size = new Size(1132, 601);
            this.Resize += (sender, e) => this.Size = new Size(1132, 601);
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = true;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
            //
            if (Elegir.modoOscuro)
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


        private void RestarCantidadVenta(string nombre, int cantidad)
        {
            int cantidad1 = Elegir.cantidad;
            int cantidadneta = cantidad1 - Convert.ToInt32(txt_cantidad.Text);
            int producto = Elegir.idProducto;
            string consultaActualizarCantidad = "UPDATE productos SET cantidad = " + cantidadneta + " where id_producto =" + producto;

            ConectaDB.CargarDB(consultaActualizarCantidad);
            MessageBox.Show("Compra realizada correctamente");
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void Limpiar()
        {
            // Limpiar la grilla
            dgvProductos.Rows.Clear();
            // Limpiar los campos de texto
            txt_precio.Text = "";
            txt_cantidad.Text = "";
            txt_idproducto.Text = "";
            txt_nombreProducto.Text = "";
        }

        private void btn_agregarCarrito_Click(object sender, EventArgs e)
        {
            ConectaDB.AbrirDB();
            int id_producto = Elegir.idProducto;
            int limitecantidad = Elegir.cantidad;
            int CantidadNetaSalida = limitecantidad - Convert.ToInt32(txt_cantidad.Text);
            CantidadNetaSalida.ToString();
            string nombreProducto = Elegir.nomProducto;
            string marcaProducto = Elegir.marca;
            string categoriaProducto = Elegir.categoria;
            decimal precioConGanancia = Elegir.precioProducto;
            cantidadComprada = Convert.ToInt32(txt_cantidad.Text);

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

        private void btn_ConfirmarCompra_Click(object sender, EventArgs e)
        {
            RestarCantidadVenta(nombre, cantidadComprada);
            Limpiar();
        }

        private void btn_traerCliente_Click_1(object sender, EventArgs e)
        {
            MuestraCliente muestraCliente = new MuestraCliente();
            muestraCliente.ShowDialog();
            txt_cuit.Text = Elegir.CUITCliente.ToString();
            txt_nombreCliente.Text = Elegir.NombreCliente;
        }

        private void btn_traerProduc_Click(object sender, EventArgs e)
        {
            ProductosEnStock productosEnStock = new ProductosEnStock();
            productosEnStock.ShowDialog();
            txt_idproducto.Text = Elegir.idProducto.ToString();
            txt_nombreProducto.Text = Elegir.nomProducto;
            txt_precio.Text = Elegir.precioProducto.ToString();
        }
    }
}