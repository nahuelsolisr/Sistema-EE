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

namespace SistemaEE.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        // SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-9UILVSA\SQLEXPRESS;Initial Catalog=EconomiaEmpresarial;Integrated Security=True");
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
                    Menu FormMenu = new Menu("Usuario: Administrador", true);
                    FormMenu.ShowDialog();
                }
                else
                {
                    // Si el tipo de usuario es cualquier otro, abrimos el formulario  y restringimos los botones 
                    Menu FormMenu = new Menu("Usuario: Común", false);
                    FormMenu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            conexion.Close();


        }
        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            logear(this.txt_usuario.Text, this.txt_clave.Text);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
