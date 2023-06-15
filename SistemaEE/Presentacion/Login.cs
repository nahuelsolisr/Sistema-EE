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
using SistemaEE.AccesoDatos;

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

        //AHORA HAY UNA SOLA CONEXION Y ESTA UBICADA EN DB

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            logear(this.txt_usuario.Text, this.txt_clave.Text);
        }

        public void logear(string usuario, string contrasena)
        {
            ConectaDB.AbrirDB();
            SqlCommand cmd = new SqlCommand("SELECT Tipo_usuario FROM usuarios WHERE Usuario = @usuario AND Contra = @pas", DB.ConexionConBD);
            cmd.Parameters.AddWithValue("usuario", usuario);
            cmd.Parameters.AddWithValue("pas", contrasena);
            cmd.Connection = DB.ConexionConBD;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                string tipoUsuario = dt.Rows[0]["Tipo_usuario"].ToString();

                if (tipoUsuario == "Administrador")
                {
                    Menu FormMenu = new Menu("Administrador", true);
                    FormMenu.ShowDialog();
                }
                else
                {
                    Menu FormMenu = new Menu("Empleado", false);
                    FormMenu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

            ConectaDB.CerrarDB();

            txt_clave.Text = "";
            txt_usuario.Text = "";
        }

        private void btn_eye_Click(object sender, EventArgs e)
        {
            if (txt_clave.Password)
            {
                txt_clave.Password = false;
            }
            else
            {
                txt_clave.Password = true;
            }
        }

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

        private void CierroPrograma(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Confirmar con el usuario antes de cerrar la aplicación si es necesario
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    // Cancelar el cierre de la aplicación si el usuario selecciona "No"
                    e.Cancel = true;
                }
                else
                {
                    // Cerrar la aplicación por completo si el usuario selecciona "Sí"
                    Application.Exit();
                }
            }
        }
    }
}
