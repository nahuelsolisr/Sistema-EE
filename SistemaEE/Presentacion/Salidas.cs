using MaterialSkin;
using MaterialSkin.Controls;
using SistemaEE.AccesoDatos;
using SistemaEE.Clases;
using SistemaEE.Presentacion.Mostrar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private List<Producto2> carrito2 = new List<Producto2>();
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
            txt_cantidad.Enabled = false;

            //
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





        private int ObtenerCantidadDisponible(string nombre)
        {
            int producto = Datos.idProducto;
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
            int cantidad1 = Datos.cantidad;
            int cantidadneta = cantidad1 - Convert.ToInt32(txt_cantidad.Text);
            int producto = Datos.idProducto;
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
            lbl_total.Text = "";
        }

        public class Producto2
        {
            public string Id { get; set; }
            public string PrecioUS { get; set; }
            public string Cantidad { get; set; }
            public string UnidadesS { get; set; }
            public string Ganancia { get; set; }
            public string nombre { get; set; }
            public string TotalS { get; set; }
        }

        private void btn_agregarCarrito_Click(object sender, EventArgs e)
        {
            string precio = txt_precio.Text;
            string cantidadsalida = txt_cantidad.Text;
            string id_producto = txt_idproducto.Text;
            string nombre_producto = txt_nombreProducto.Text;
            string marcaProducto = Datos.marca;
            string categoriaProducto = Datos.categoria;

            int cantidadDisponible = ObtenerCantidadDisponible(nombre);
            if (cantidadDisponible == -1)
            {
                MessageBox.Show("El producto no se encuentra disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt64(cantidadsalida) > cantidadDisponible)
            {
                MessageBox.Show("No hay suficiente cantidad disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string precioo = $"Select precio from productos where id_producto = {id_producto}";
            decimal preciocosto = 0;

            // Realiza la lectura de la base de datos para obtener la cantidad actual del producto
            ConectaDB.AbrirDB();
            using (var reader = ConectaDB.LecturaDB(precioo))
            {
                if (reader.Read())
                {
                    preciocosto = Convert.ToDecimal(reader["precio"]);
                }
            }
            ConectaDB.CerrarDB();

            decimal preciod = Convert.ToDecimal(precio);
            decimal cantidadsalidad = Convert.ToDecimal(cantidadsalida);
            decimal subtotal = preciod * cantidadsalidad;
            decimal total = 0;
            decimal stock_disp = Convert.ToDecimal(lbl_stockDisponible.Text);
            decimal apoyo = stock_disp + 1;
            lbl_apoyo.Text = apoyo.ToString();



            if (apoyo <= Convert.ToDecimal(cantidadsalida))
            {
                //stock_disp = stock_disp + Convert.ToDecimal(cantidadsalida);
                MessageBox.Show("No hay suficiente cantidad disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (apoyo > Convert.ToDecimal(cantidadsalida))
            {
                stock_disp = stock_disp - Convert.ToDecimal(cantidadsalida);
                lbl_stockDisponible.Text = stock_disp.ToString();
            }
            if (stock_disp == Convert.ToDecimal(cantidadsalida))
            {
                //lbl_stockDisponible.Text = "0";
            }

            Producto2 producto2 = new Producto2
            {
                UnidadesS = cantidadsalida,
                PrecioUS = precio,
                TotalS = subtotal.ToString(),
                Id = id_producto,
                nombre = nombre_producto,

            };
            dgvProductos.Rows.Add(nombre_producto, marcaProducto, categoriaProducto, precio, cantidadsalida, subtotal);
            carrito2.Add(producto2);

            total = total + subtotal;

            // Convertir el valor en total a una cadena con el formato personalizado
            string totalFormateado = total.ToString("#,##0.00");

            // Mostrar el resultado formateado en lbl_total
            lbl_total.Text = totalFormateado;
        }

        public static int ObtenerUnidadesExistentes()
        {

            string consulta = "SELECT SUM(UnidadesEx) FROM fichastock";
            SqlCommand comando = new SqlCommand(consulta, DB.ConexionConBD);
            object resultado = comando.ExecuteScalar();
            int unidadesExistentes = 0;

            if (resultado != null && !Convert.IsDBNull(resultado))
            {
                unidadesExistentes = Convert.ToInt32(resultado);
            }

            return unidadesExistentes;
        }
        public static decimal ObtenerPrecioUExistentes()
        {
            string consulta = "SELECT AVG(PrecioUEx) FROM fichastock";
            SqlCommand comando = new SqlCommand(consulta, DB.ConexionConBD);
            object resultado = comando.ExecuteScalar();
            decimal precioUExistente = 0;

            if (resultado != null && !Convert.IsDBNull(resultado))
            {
                precioUExistente = Convert.ToDecimal(resultado);
            }

            return precioUExistente;
        }

        public static decimal ObtenerTotalExistentes()
        {
            string consulta = "SELECT SUM(TotalEx) FROM fichastock";
            SqlCommand comando = new SqlCommand(consulta, DB.ConexionConBD);
            object resultado = comando.ExecuteScalar();
            decimal totalExistente = 0;

            if (resultado != null && !Convert.IsDBNull(resultado))
            {
                totalExistente = Convert.ToDecimal(resultado);
            }

            return totalExistente;
        }


        private void btn_ConfirmarCompra_Click(object sender, EventArgs e)
        {
            txt_cantidad.Enabled = false;
            lbl_stockDisponible.Visible = false;
            DialogResult result = MessageBox.Show("¿Estás seguro de realizar esta venta?", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                ConectaDB.AbrirDB();
                foreach (Producto2 producto2 in carrito2)
                {
                    int contador = 0;
                    string cant = $"Select cantidad from productos where id_producto = {producto2.Id}";
                    int cantidadActual = 0;

                    // Realiza la lectura de la base de datos para obtener la cantidad actual del producto
                    using (var reader = ConectaDB.LecturaDB(cant))
                    {
                        if (reader.Read())
                        {
                            object cantidadObj = reader["cantidad"];
                            if (cantidadObj != DBNull.Value)
                            {
                                cantidadActual = Convert.ToInt32(cantidadObj);
                            }
                            else
                            {
                                // Valor nulo, maneja el caso según tus necesidades (por ejemplo, asignar un valor predeterminado)
                                cantidadActual = 0;
                            }
                        }
                    }
                    int cantidadNetaSalida = cantidadActual - Convert.ToInt32(producto2.UnidadesS);
                    decimal total_stock = cantidadNetaSalida * Convert.ToDecimal(producto2.PrecioUS);
                    total_stock.ToString();
                    string precioo = $"Select precio from productos where id_producto = {producto2.Id}";
                    decimal preciocosto = 0;

                    // Realiza la lectura de la base de datos para obtener la cantidad actual del producto
                    ConectaDB.AbrirDB();
                    using (var reader = ConectaDB.LecturaDB(precioo))
                    {
                        if (reader.Read())
                        {
                            preciocosto = Convert.ToDecimal(reader["precio"]);
                        }
                    }
                    // Actualiza los datos del producto en la base de datos
                    string updateSalida = $"UPDATE productos SET cantidad = {cantidadNetaSalida} WHERE id_producto = {producto2.Id}";
                    ConectaDB.CargarDB(updateSalida);

                    DateTime fechaActual = DateTime.Now;
                    string fechaActualString = fechaActual.ToString("dd/MM/yyyy");
                    unidadesE = Convert.ToInt32(producto2.UnidadesS);
                    precioUE = Convert.ToDecimal(producto2.PrecioUS);
                    decimal totalE = unidadesE * precioUE;
                    decimal totalEx = preciocosto * cantidadNetaSalida;
                    string concepto = "VENTA";
                    string totalsalida = totalE.ToString();

                    //hace el insert en stock
                    string insertStock = $"INSERT INTO fichastock (fecha, nombreProducto ,IdProducto, Concepto, UnidadesS, PrecioUS, TotalS, UnidadesEx, PrecioUEx, TotalEx) " +
                        $"VALUES ('{fechaActualString}' ,'{producto2.nombre}', '{producto2.Id}', '{concepto}', '{producto2.UnidadesS}', '{producto2.PrecioUS}', '{totalsalida}', '{cantidadNetaSalida}', '{preciocosto}', '{totalEx}')";
                    ConectaDB.CargarDB(insertStock);
                }
                // Agrega 
                // Obtener los datos del DataGridView dgvProductos del Formulario 1
                List<string[]> datos = new List<string[]>();

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string[] fila = new string[row.Cells.Count];
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            fila[i] = row.Cells[i].Value.ToString();
                        }
                        datos.Add(fila);
                    }
                }
                MessageBox.Show("Su compra ha sido realizada");
                ConectaDB.CerrarDB();
                Limpiar();
                carrito2.Clear();




                // Obtener una referencia al Formulario 2 (MuestraFactura)
                MuestraFactura formulario2 = new MuestraFactura();

                // Pasar los datos al DataGridView dgvProductosF en el Formulario 2
                formulario2.AgregarDatosAlDataGridView(datos);

                // Mostrar el Formulario 2
                formulario2.ShowDialog(); // Puedes usar ShowDialog para bloquear el Formulario 1 hasta que se cierre el Formulario 2
            }
        }

        private void btn_traerCliente_Click(object sender, EventArgs e)
        {
            MuestraCliente muestraCliente = new MuestraCliente();
            muestraCliente.ShowDialog();
            txt_cuit.Text = Datos.CUITCliente.ToString();
            txt_nombreCliente.Text = Datos.NombreCliente;
        }

        private void btn_traerProduc_Click(object sender, EventArgs e)
        {
            txt_cantidad.Enabled = true;
            ProductosEnStock productosEnStock = new ProductosEnStock();
            productosEnStock.ShowDialog();
            txt_idproducto.Text = Datos.idProducto.ToString();
            txt_nombreProducto.Text = Datos.nomProducto;
            txt_precio.Text = Datos.precioProducto.ToString();
            lbl_stockDisponible.Text = Datos.cantidad.ToString();
        }

        private void Salidas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_cantidad.Enabled = false;
            lbl_stockDisponible.Visible = false;
            dgvProductos.ClearSelection();
            carrito2.Clear();
            Limpiar();
        }

        private void KeyPressPrecio(object sender, KeyPressEventArgs e)
        {
            MaterialSkin.Controls.MaterialTextBox textBox = (MaterialSkin.Controls.MaterialTextBox)sender;
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_precio, "Solo se admiten numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();

            if (e.KeyChar >= 45 && e.KeyChar <= 47)
            {
                errorProvider1.SetError(txt_precio, "Solo se admiten comas");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();

            //Permitir números, comas y teclas de control(como retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Ignorar el carácter ingresado
            }

            // Permitir solo una coma en el campo
            if (e.KeyChar == ',' && textBox.Text.Contains(","))
            {
                e.Handled = true; // Ignorar la coma adicional
            }
        }

        private void KeyPressCantidad(object sender, KeyPressEventArgs e)
        {
            MaterialSkin.Controls.MaterialTextBox textBox = (MaterialSkin.Controls.MaterialTextBox)sender;
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProvider1.SetError(txt_cantidad, "Solo se admiten numeros");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();

            if (e.KeyChar >= 45 && e.KeyChar <= 47)
            {
                errorProvider1.SetError(txt_cantidad, "Solo se admiten comas");
                e.Handled = true;
                return;
            }
            else errorProvider1.Clear();

            //Permitir números, comas y teclas de control(como retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Ignorar el carácter ingresado
            }

            // Permitir solo una coma en el campo
            if (e.KeyChar == ',' && textBox.Text.Contains(","))
            {
                e.Handled = true; // Ignorar la coma adicional
            }
        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_Click(object sender, EventArgs e)
        {
            lbl_stockDisponible.Visible = true;
        }
    }
}