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
    public partial class Entrada : Form
    {
        static decimal CUIT;
        static string NOMBRE;
        static int IDPRODUCTO;
        static string NOMBREPRODUCTO;


        public Entrada(decimal cuit, string provNombre, int IdProducto, string nombreProducto)
        {
            InitializeComponent();
            CUIT = cuit;
            NOMBRE = provNombre;
            IDPRODUCTO = IdProducto;
            NOMBREPRODUCTO = nombreProducto;

            txt_cuit.Text = Convert.ToString(CUIT);
            txt_provNombre.Text = NOMBRE;
            txt_idproducto.Text = Convert.ToString(IDPRODUCTO);
            txt_nombreProducto.Text = NOMBREPRODUCTO;


        }

        private void btn_TraerProveedor_Click(object sender, EventArgs e)
        {
            MuestraProveedor muestraProveedor = new MuestraProveedor();
            this.Close();
            muestraProveedor.Show();

        }

        private void btn_TraerProducto_Click(object sender, EventArgs e)
        {
            MuestraProductos muestraProductos = new MuestraProductos();
            this.Close();
            muestraProductos.Show();
        }
    }
}
