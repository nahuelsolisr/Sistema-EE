using MaterialSkin;
using MaterialSkin.Controls;
using SistemaEE.AccesoDatos;
using SistemaEE.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEE.Formularios
{
    public partial class Proveedores : MaterialForm
    {
        decimal idProveedor;
        public Proveedores()
        {
            InitializeComponent();
            //
            this.Size = new Size(1046, 620);
            this.Resize += (sender, e) => this.Size = new Size(1046, 620);
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = true;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
            //
            dgv_Proveedores();
            if (Datos.modoOscuro)
            {
                EstiloOscuro();
                dgvProveedor.DefaultCellStyle.BackColor = Color.DimGray;
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
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            dgvProveedor.BackgroundColor = Color.DimGray;
        }

        public void dgv_Proveedores()
        {

            ConectaDB.AbrirDB();
            string consultaProveedor = "SELECT * FROM proveedor";
            ConectaDB.LecturaDB(consultaProveedor);
            dgvProveedor.Rows.Clear(); // Limpia los datos anteriores en la grilla
            while (DB.lector.Read())
            {
                //En lugar de asignar cada valor al valor de una celda específica de la grilla, 
                //se puede agregar una fila completa a la grilla de una sola vez, utilizando el método 
                //Add() de la propiedad Rows de la grilla.

                dgvProveedor.Rows.Add(
                      "",
                    DB.lector["cuit_prov"],
                    DB.lector["nombre_prov"],
                    DB.lector["domicilio_prov"],
                    DB.lector["mail_prov"],
                    DB.lector["condicion"]

                );
            }

            dgvProveedor.ClearSelection();
            DB.lector.Close();

        }

        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProveedor.Columns[e.ColumnIndex].Name == "btn_seleccionar")
            {
                idProveedor = Convert.ToDecimal(dgvProveedor.Rows[e.RowIndex].Cells["Column0"].Value);
                //Limpia el color de  la fila cuando se selecciona otro boton
                foreach (DataGridViewRow fila in dgvProveedor.Rows)
                {
                    fila.DefaultCellStyle.BackColor = dgvProveedor.DefaultCellStyle.BackColor;

                }

                // Obtiene los datos de la fila seleccionada

                DataGridViewRow filaSeleccionada = dgvProveedor.Rows[e.RowIndex];

                //le da color a la fila seleccionada
                filaSeleccionada.DefaultCellStyle.BackColor = Color.SteelBlue;

                string cuit = filaSeleccionada.Cells["Column0"].Value.ToString();
                string nombre = filaSeleccionada.Cells["Column1"].Value.ToString();
                string domicilio = filaSeleccionada.Cells["Column2"].Value.ToString();
                string mail = filaSeleccionada.Cells["Column3"].Value.ToString();
                string condicion = filaSeleccionada.Cells["Column4"].Value.ToString();

                // Actualiza los TextBox con los datos de la fila seleccionada
                txt_cuit.Text = cuit;
                txt_nombre.Text = nombre;
                txt_domicilio.Text = domicilio;
                txt_mail.Text = mail;
                cmb_condicion.Text = condicion;

            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            bool validacion = EnviarValidaciones();

            if (validacion)
            {
                try
                {
                    ConectaDB.AbrirDB();
                    string insertProveedor = "INSERT INTO proveedor (cuit_prov, nombre_prov, domicilio_prov, mail_prov, condicion) VALUES (" + txt_cuit.Text + ", '" + txt_nombre.Text + "', '" + txt_domicilio.Text + "', '" + txt_mail.Text + "', '" + cmb_condicion.Text + "')";
                    ConectaDB.CargarDB(insertProveedor);
                    ConectaDB.CerrarDB();
                    MessageBox.Show("El proveedor ha sido agregado correctamente.");
                    Limpiar();
                    dgv_Proveedores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el Proveedor: " + ex.Message);
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            bool validacion = EnviarValidaciones();

            if (validacion)
            {
                try
                {
                    ConectaDB.AbrirDB();
                    string updateProveedor = "UPDATE proveedor SET cuit_prov = " + txt_cuit.Text + ", nombre_prov = '" + txt_nombre.Text + "', domicilio_prov = '" + txt_domicilio.Text + "', mail_prov = '" + txt_mail.Text + "',condicion = '" + cmb_condicion.Text + "' WHERE cuit_prov = " + idProveedor;
                    ConectaDB.CargarDB(updateProveedor);
                    ConectaDB.CerrarDB();
                    Limpiar();
                    dgv_Proveedores();
                    MessageBox.Show("Actualización exitosa.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar proveedor: " + ex.Message);
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ConectaDB.AbrirDB();
                string deleteProveedor = "DELETE FROM proveedor WHERE cuit_prov = " + idProveedor + ";";
                ConectaDB.CargarDB(deleteProveedor);
                ConectaDB.CerrarDB();
                Limpiar();
                MessageBox.Show("Proveedor eliminado correctamente");
                dgv_Proveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el proveedor: " + ex.Message);
            }

        }


        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txt_filtrar.Text;
            Filtrar filtrador = new Filtrar();
            filtrador.FiltrarProveedores(dgvProveedor, filtro);
        }

        public bool EnviarValidaciones()
        {

            string cuit = txt_cuit.Text;

            string nombre = txt_nombre.Text;

            string email = txt_mail.Text;


            if (!Validaciones.ValidarCuit(cuit))
            {
                MessageBox.Show("El CUIT no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Validaciones.ValidarNombre(nombre))
            {
                MessageBox.Show("El nombre no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Validaciones.ValidarEmail(email))
            {
                MessageBox.Show("El correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //si todas las validaciones son correctas
            return true;

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        WebClient cliente = new WebClient();
        string ruta = null;

        private void btn_descargaPlantilla_Click(object sender, EventArgs e)
        {
            // Crear un cuadro de diálogo de guardado de archivo
            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Filter = "Archivos RAR|*.rar";
            dialogo.FileName = "PlantillaClientes.rar";

            // Mostrar el cuadro de diálogo y esperar a que el usuario seleccione una ubicación de archivo
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                ruta = dialogo.FileName;

                // Descargar el archivo utilizando la ruta completa del archivo
                cliente.DownloadFileAsync(new Uri(@"C:\MisProyectos\Sistema Economia Empresarial\SistemaEE\Resources\PlantillaProveedor.rar"), dialogo.FileName);
            }
        }

        public void Limpiar()
        {
            txt_cuit.Text = "";
            txt_nombre.Text = "";
            txt_domicilio.Text = "";
            txt_mail.Text = "";
            cmb_condicion.Text = "";
        }

        private void Proveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
