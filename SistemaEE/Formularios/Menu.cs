using SistemaEE.Clases;

namespace SistemaEE.Formularios
{
    public partial class Menu : Form
    {
        public bool PERMISOS;
        public Menu(string nombre, bool permisos)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            lbl_usuario.Text = nombre;
            this.PERMISOS = permisos;

            if (PERMISOS)
            {
                btn_contabilidad.Enabled = true;
                btn_usuarios.Enabled = true;
            }
            else
            {
                btn_contabilidad.Enabled = false;
                btn_usuarios.Enabled = false;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }









        private void btn_facturacion_Click(object sender, EventArgs e)
        {
            panel_facturacion.Visible = true;
            btn_contabilidad.Enabled = false;
            btn_usuarios.Enabled = false;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            panel_facturacion.Visible = false;

            if (PERMISOS)
            {
                btn_contabilidad.Enabled = true;
                btn_usuarios.Enabled = true;
            }
            else
            {

            }

        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.ShowDialog();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.ShowDialog();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }

        private void btn_entradas_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();
            entrada.ShowDialog();
        }

        private void btn_salidas_Click(object sender, EventArgs e)
        {
            Salidas salidas = new Salidas();
            salidas.ShowDialog();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
        }
        private void btn_fichaStock_Click(object sender, EventArgs e)
        {

        }
    }
}
