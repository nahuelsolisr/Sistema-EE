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
    public partial class Salidas : Form
    {
        public object[,] compras; // Matriz para almacenar los datos de las compras
        public int contadorCompras = 0;
        private ProductosEnStock formularioProductos;
        string nombre;

        public Salidas()
        {
            InitializeComponent();
            compras = new object[100, 6];
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
            ConectaDB.AbrirDB();
            string consultaCantidad = "SELECT cantidad FROM productos WHERE id_producto = " + producto;
            ConectaDB.LecturaDB(consultaCantidad);

            int cantidadDisponible = 0;

            if (DB.lector.Read())
            {
                if (!DBNull.Value.Equals(DB.lector["cantidad"]))
                {
                    cantidadDisponible = Convert.ToInt32(DB.lector["cantidad"]);
                }
            }

            DB.lector.Close();
            ConectaDB.CerrarDB();

            return cantidadDisponible;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            int limitecantidad = Elegir.cantidad;
            string nombreProducto = Elegir.nomProducto;
            string marcaProducto = Elegir.marca;
            string categoriaProducto = Elegir.categoria;
            decimal precioConGanancia = Elegir.precioProducto;
            int cantidadComprada = Convert.ToInt32(nud_cantidad.Value);

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


            // Realizar la venta
            //// Restar la cantidad vendida del stock
            RestarCantidadVenta(nombre, cantidadComprada);

            decimal subtotal = precioConGanancia * cantidadComprada;

            // Agregar fila a la grilla
            dgvProductos.Rows.Add(nombreProducto, marcaProducto, categoriaProducto, precioConGanancia, cantidadComprada, subtotal);

            // Almacenar los datos en la matriz
            compras[contadorCompras, 0] = nombreProducto;
            compras[contadorCompras, 1] = marcaProducto;
            compras[contadorCompras, 2] = categoriaProducto;
            compras[contadorCompras, 3] = precioConGanancia;
            compras[contadorCompras, 4] = cantidadComprada;
            compras[contadorCompras, 5] = subtotal;

            contadorCompras++;

            RestarCantidadVenta(nombre, cantidadComprada);

        }


        private void RestarCantidadVenta(string nombre, int cantidad)
        {
            int cantidad1 = Elegir.cantidad;
            int cantidadneta = cantidad1 - (int)nud_cantidad.Value;
            int producto = Elegir.idProducto;
            ConectaDB.AbrirDB();
            string consultaActualizarCantidad = "UPDATE productos SET cantidad = " + cantidadneta + " where id_producto =" + producto;
            ConectaDB.CargarDB(consultaActualizarCantidad);
            ConectaDB.CerrarDB();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
