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
        static decimal CUIT;
        static string NOMBRE;
        static int IDPRODUCTO;
        static string NOMBREPRODUCTO;
        static decimal CANTIDAD;
        List<decimal> listaProductos = new List<decimal>();

        public Entrada()
        {
            InitializeComponent();


            txt_cuit.Text = Convert.ToString(CUIT);
            txt_provNombre.Text = NOMBRE;
            txt_idproducto.Text = Convert.ToString(IDPRODUCTO);
            txt_nombreProducto.Text = NOMBREPRODUCTO;

        }



        public class Producto
        {
            public decimal Precio { get; set; }
            public decimal Ganancia { get; set; }
            public int Cantidad { get; set; }
            public string CodigoProducto { get; set; }
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
            ConectaDB.AbrirDB();

            string cuitProveedor = txt_cuit.Text;
            string nombreProveedor = txt_provNombre.Text;
            decimal codigoProducto = decimal.Parse(txt_idproducto.Text);
            string nombreProducto = txt_nombreProducto.Text;
            decimal precio = Convert.ToDecimal(txt_precio.Text);
            decimal ganancia = nud_ganancia.Value;
            decimal cantidad = nud_cantidad.Value;

            // Agrega los datos a la DataGridView
            dgvCarrito.Rows.Add(nombreProducto, precio, ganancia, cantidad);
            //lista de productos 
            listaProductos.Add(Convert.ToDecimal(precio));
            listaProductos.Add(Convert.ToDecimal(ganancia));
            listaProductos.Add(Convert.ToDecimal(cantidad));
            listaProductos.Add(Convert.ToDecimal(codigoProducto));


            string consultacantidad = "SELECT cantidad FROM productos where id_producto= " + txt_idproducto.Text;
            SqlDataReader reader = ConectaDB.LecturaDB(consultacantidad);

            // Verifica si hay filas en el resultado
            if (reader.Read())
            {
                // Verifica si el valor de cantidad no es nulo
                if (!reader.IsDBNull(0))
                {
                    // Obtiene el valor de cantidad y lo asigna a la variable correspondiente
                    CANTIDAD = reader.GetDecimal(0);
                }
            }

            reader.Close();
            ConectaDB.CerrarDB();

        }

        private void btn_confirmar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de realizar esta compra?", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ConectaDB.AbrirDB();

                // Itera sobre los elementos de la lista en incrementos de 4 (asumiendo que hay 4 valores por registro)
                for (int i = 0; i < listaProductos.Count; i += 4)
                {
                    // Obtiene los valores correspondientes para el registro actual
                    decimal precio = listaProductos[i];
                    decimal ganancia = listaProductos[i + 1];
                    decimal cantidad = listaProductos[i + 2];
                    decimal codigoProducto = listaProductos[i + 3];
                    cantidad += CANTIDAD;
                    // Construye la consulta SQL utilizando los valores del registro actual
                    string updateEntrada = $"UPDATE productos SET cantidad = {cantidad}, precio = {precio}, porcentajeg = {ganancia} WHERE id_producto = {codigoProducto}";

                    // Ejecuta la consulta
                    ConectaDB.CargarDB(updateEntrada);
                    MessageBox.Show("Su compra ha sido realizada");

                }

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
    }
}
