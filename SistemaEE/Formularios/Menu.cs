namespace SistemaEE.Formularios
{
    public partial class Menu : Form
    {
        private bool permisos;
        public Menu(string nombre, bool permisos)
        {
            InitializeComponent();
            lbl_usuario.Text = nombre;

            this.permisos = permisos;

            if (permisos)
            {
                // Habilitar todos los botones si el usuario es administrador


            }
            else
            {
                // Deshabilitar los botones productos,provedores, si el usuario no es administrador

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

        private void btn_contabilidad_Click(object sender, EventArgs e)
        {

        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            panel_facturacion.Visible = false;
            btn_contabilidad.Enabled = true;
            btn_usuarios.Enabled = true;
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.ShowDialog();
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.ShowDialog();
        }
    }
}
