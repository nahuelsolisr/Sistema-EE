using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaEE.Clases;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
using MaterialSkin.Animations;

namespace SistemaEE.Formularios
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            //
            this.Size = new Size(309, 535);
            this.Resize += (sender, e) => this.Size = new Size(309, 535);
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = true;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
            //
            EstiloClaro();
            txt_clave.Password = true;
        }
        //SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-9UILVSA\SQLEXPRESS;Initial Catalog=EconomiaEmpresarial;Integrated Security=True");
        SqlConnection conexion = new SqlConnection(@"Data Source=RODRIGO\DEVELOPER;Initial Catalog=EconomiaEmpresarial;Integrated Security=True");
        public void logear(string usuario, string contrasena)
        {

            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT Tipo_usuario FROM usuarios WHERE Usuario = @usuario AND Contra = @pas", conexion);
            cmd.Parameters.AddWithValue("usuario", usuario);
            cmd.Parameters.AddWithValue("pas", contrasena);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                string tipoUsuario = dt.Rows[0]["Tipo_usuario"].ToString();

                if (tipoUsuario == "Administrador")
                {
                    // Si el tipo de usuario es "admin", abrimos el formulario  y le damos permisos a los botones
                    Menu FormMenu = new Menu("Administrador", true);

                    FormMenu.ShowDialog();
                }
                else
                {
                    // Si el tipo de usuario es cualquier otro, abrimos el formulario  y restringimos los botones 
                    Menu FormMenu = new Menu("Empleado", false);

                    FormMenu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            conexion.Close();


        }




        private void btn_eye_Click(object sender, EventArgs e)
        {
            if (txt_clave.Password)
            {
                // Cambiar a modo de texto normal
                txt_clave.Password = false;
            }
            else
            {
                //Cambiar a modo de contraseña oculta
                txt_clave.Password = true;
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

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            logear(this.txt_usuario.Text, this.txt_clave.Text);
        }

        private void msModoOscuro_CheckedChanged(object sender, EventArgs e)
        {

            if (msModoOscuro.Checked)
            {
                Elegir.modoOscuro = true;
                EstiloOscuro();
            }
            else
            {
                Elegir.modoOscuro = false;
                EstiloClaro();
            }
        }
    }
}
