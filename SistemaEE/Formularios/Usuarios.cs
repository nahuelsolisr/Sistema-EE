using MaterialSkin;
using MaterialSkin.Controls;
using SistemaEE.Clases;
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
    public partial class Usuarios : MaterialForm
    {

        public int idUsuario;

        public Usuarios()
        {
            InitializeComponent();
            //1046; 620
            this.Size = new Size(1046, 620);
            this.Resize += (sender, e) => this.Size = new Size(1046, 620);
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = true;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
            //
            dgv_Usuarios();
            if (Elegir.modoOscuro)
            {
                EstiloOscuro();
                dgvUsuarios.DefaultCellStyle.BackColor = Color.DimGray;
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
        public void dgv_Usuarios()
        {
            ConectaDB.AbrirDB();
            string consultaUsuario = "SELECT * FROM usuarios";
            ConectaDB.LecturaDB(consultaUsuario);
            dgvUsuarios.Rows.Clear(); // Limpia los datos anteriores en la grilla

            while (DB.lector.Read())
            {
                dgvUsuarios.Rows.Add(
                     DB.lector["Id_usuario"],
                    "",
                    DB.lector["Usuario"],
                    DB.lector["Contra"],
                    DB.lector["Tipo_usuario"]
                );
            }

            dgvUsuarios.ClearSelection();
            DB.lector.Close();

        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se hizo clic en la celda del botón "btn_seleccionar"
            if (e.RowIndex >= 0 && dgvUsuarios.Columns[e.ColumnIndex].Name == "btn_seleccionar")
            {
                idUsuario = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["Column0"].Value);
                //Limpia el color de  la fila cuando se selecciona otro boton
                foreach (DataGridViewRow fila in dgvUsuarios.Rows)
                {
                    fila.DefaultCellStyle.BackColor = dgvUsuarios.DefaultCellStyle.BackColor;

                }


                // Obtiene los datos de la fila seleccionada

                DataGridViewRow filaSeleccionada = dgvUsuarios.Rows[e.RowIndex];

                //le da color a la fila seleccionada
                filaSeleccionada.DefaultCellStyle.BackColor = Color.SteelBlue;


                string nombre = filaSeleccionada.Cells["Column1"].Value.ToString();
                string contraseña = filaSeleccionada.Cells["Column2"].Value.ToString();
                string tipoUsuario = filaSeleccionada.Cells["Column3"].Value.ToString();


                // Actualiza los TextBox con los datos de la fila seleccionada
                txt_nombre.Text = nombre;
                txt_contraseña.Text = contraseña;
                txt_tipoUsuario.Text = tipoUsuario;
            }
        }



        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txt_filtrar.Text;
            Filtrar filtrador = new Filtrar();
            filtrador.FiltrarUsuarios(dgvUsuarios, filtro);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                ConectaDB.AbrirDB();
                string insertUsuario = "INSERT INTO usuarios (Usuario, Contra, Tipo_usuario) VALUES ('" + txt_nombre.Text + "', " + txt_contraseña.Text + ", '" + txt_tipoUsuario.Text + "')";
                ConectaDB.CargarDB(insertUsuario);
                ConectaDB.CerrarDB();
                MessageBox.Show("El Usuario ha sido agregado correctamente.");
                dgv_Usuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar al Usuario: " + ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                ConectaDB.AbrirDB();
                string updateUsuario = "UPDATE usuarios SET Usuario = '" + txt_nombre.Text + "', Contra = '" + txt_contraseña.Text + "', Tipo_usuario = '" + txt_tipoUsuario.Text + "' WHERE Id_usuario = " + idUsuario;
                ConectaDB.CargarDB(updateUsuario);
                ConectaDB.CerrarDB();
                dgv_Usuarios();
                MessageBox.Show("Actualización exitosa.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar Usuario: " + ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ConectaDB.AbrirDB();
                string deleteUsuario = "DELETE FROM usuarios WHERE Id_usuario = " + idUsuario + ";";
                ConectaDB.CargarDB(deleteUsuario);
                ConectaDB.CerrarDB();
                MessageBox.Show("Usuario eliminado correctamente");
                dgv_Usuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }

        private void Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
