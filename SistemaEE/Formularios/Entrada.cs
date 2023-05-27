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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                nombre = nombreProducto,
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

                ConectaDB.AbrirDB();
                foreach (Producto producto in carrito)
                {
                    // Actualiza los datos del producto en la base de datos
                    string updateEntrada = $"UPDATE productos SET cantidad = {producto.Cantidad}, precio = {producto.Precio}, porcentajeg = {producto.Ganancia} WHERE id_producto = {producto.Id}";
                    ConectaDB.CargarDB(updateEntrada);

                    //Realiza el insert en la tabla "fichastock"
                    string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    int unidadesE = producto.Cantidad;
                    decimal precioUE = producto.Precio;
                    decimal totalE = producto.Cantidad * producto.Precio;
                    int unidadesEx = ObtenerUnidadesExistentes();
                    decimal precioUEx = ObtenerPrecioUExistentes();
                    decimal totalEx = ObtenerTotalExistentes();
                    string concepto = "COMPRA";

                    //verifica si las unidades existentes son igual a 0 ahora pasan a ser las entradas sino se le suma las entradas mas las que ya tienen   

                    if (unidadesEx == 0 || precioUEx == 0 || totalEx == 0)
                    {
                        unidadesEx = unidadesE;
                        precioUEx = precioUE;
                        totalEx = totalE;
                    }
                    else
                    {
                        unidadesEx = unidadesEx + unidadesE;
                        totalEx = totalEx + totalE;
                    }
                    //hace el insert en stock
                    string insertStock = $"INSERT INTO fichastock (fecha, nombreProducto ,IdProducto, Concepto, UnidadesE, PrecioUE, TotalE, UnidadesEx, PrecioUEx, TotalEx) " +
                       $"VALUES ({fecha} ,'{producto.nombre}', {producto.Id}, '{concepto}', {unidadesE}, {precioUE}, {totalE}, {unidadesEx}, {precioUEx}, {totalEx})";
                    ConectaDB.CargarDB(insertStock);
                 
                }

                MessageBox.Show("Su compra ha sido realizada");
                ConectaDB.CerrarDB();
                Limpiar();
                carrito.Clear();
            }
            else { }
        }
        //CLASE DEL PRODUCTO
        public class Producto
        {
            public string Id { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
            public decimal Ganancia { get; set; }
            public string nombre { get; set; }
        }

        //METODO PARA LIMPIAR
        public void Limpiar()
        {
            dgvCarrito.Rows.Clear();
            txt_precio.Text = "";
            txt_idproducto.Text = "";
            txt_nombreProducto.Text = "";
            nud_cantidad.Value = 0;
            nud_ganancia.Value = 0;
        }

        //METODOS PARA OBTENER EL VALOR DE EXISTENCIA 
        //SI NO EXISTE LO TRANSFORMO EN 0  
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
    }
}
