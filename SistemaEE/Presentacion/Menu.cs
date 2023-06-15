using SistemaEE.Clases;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Windows.Forms;

namespace SistemaEE.Formularios
{
    public partial class Menu : MaterialForm
    {
        public bool PERMISOS;
        public Menu(string nombre, bool permisos)
        {


            InitializeComponent();
            //
            this.Size = new Size(600, 600);
            this.Resize += (sender, e) => this.Size = new Size(600, 600);
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = true;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
            //
            if (Datos.modoOscuro)
            {
                EstiloOscuro();
            }
            else
            {
                EstiloClaro();
            }

            lbl_usuario.Text = nombre;
            this.PERMISOS = permisos;

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
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }




        private void mtcMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mtcMenu.SelectedTab == tabContabilidad)
            {

            }
            if (mtcMenu.SelectedTab == tabUsuarios)
            {
                Usuarios usuarios = new Usuarios();
                usuarios.ShowDialog();
            }
            else { }
        }

        private void btn_prov_Click(object sender, EventArgs e)
        {

            Proveedores proveedores = new Proveedores();
            proveedores.ShowDialog();
        }

        private void btn_producto_Click(object sender, EventArgs e)
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

        private void btn_stock_Click(object sender, EventArgs e)
        {
            FichaDeStock inventario = new FichaDeStock();
            inventario.ShowDialog();
        }

    
  

     

        //MODULO DE CONFIGURACION

        

        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void msModoOscuro_CheckedChanged(object sender, EventArgs e)
        {
            if (msModoOscuro.Checked)
            {
                Datos.modoOscuro = true;
                EstiloOscuro();
            }
            else
            {
                Datos.modoOscuro = false;
                EstiloClaro();
            }
        }

        //MODOS DE COLOR (BETA)
        private void mr_modoNaranja_CheckedChanged(object sender, EventArgs e)
        {
            if (mr_modoNaranja.Checked)
                TManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
        }

        private void mr_modoVerde_CheckedChanged(object sender, EventArgs e)
        {
            if (mr_modoVerde.Checked)
                TManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        private void mr_modoAzul_CheckedChanged(object sender, EventArgs e)
        {
            if (mr_modoAzul.Checked)
                TManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
        }



        private void btn_datosEmpresa_Click(object sender, EventArgs e)
        {
            Datos.nombreEMPRESA = txt_nombreEmpresa.Text;
            Datos.direccionEMPRESA = txt_direcciónEmpresa.Text;
        }

        private void btn_subirLogo_Click(object sender, EventArgs e)
        {
            // Crear una instancia del cuadro de diálogo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Filtrar solo los archivos de imagen
            openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

            // Mostrar el cuadro de diálogo y esperar a que el usuario seleccione una imagen
            DialogResult result = openFileDialog.ShowDialog();

            // Verificar si el usuario seleccionó una imagen
            if (result == DialogResult.OK)
            {
                // Obtener la ruta de la imagen seleccionada
                string rutaImagen = openFileDialog.FileName;

                // Cargar la imagen en el PictureBox
                pic_logoEmpresa.Image = Image.FromFile(rutaImagen);
            }
        }

        //CIERRA EL FORMULARIO
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
