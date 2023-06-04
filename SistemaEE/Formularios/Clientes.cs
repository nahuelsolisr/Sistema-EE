using MaterialSkin;
using MaterialSkin.Controls;
using SistemaEE.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEE.Formularios
{
    public partial class Clientes : MaterialForm
    {
        decimal idCliente;
        public Clientes()
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
            dgv_Clientes();
            if (Elegir.modoOscuro)
            {
                EstiloOscuro();
                dgvCliente.DefaultCellStyle.BackColor = Color.DimGray;
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

        public void dgv_Clientes()
        {

            ConectaDB.AbrirDB();
            string consultaCliente = "SELECT * FROM clientes";
            ConectaDB.LecturaDB(consultaCliente);
            dgvCliente.Rows.Clear(); // Limpia los datos anteriores en la grilla

            while (DB.lector.Read())
            {
                //En lugar de asignar cada valor al valor de una celda específica de la grilla, 
                //se puede agregar una fila completa a la grilla de una sola vez, utilizando el método 
                //Add() de la propiedad Rows de la grilla.

                dgvCliente.Rows.Add(
                      "",
                    DB.lector["cuit_cliente"],
                    DB.lector["cliente_nombre"],
                    DB.lector["direccion"],
                    DB.lector["mail_cliente"],
                    DB.lector["condicion_cliente"]
                );
            }

            dgvCliente.ClearSelection();
            DB.lector.Close();

        }

        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCliente.Columns[e.ColumnIndex].Name == "btn_seleccionar")
            {
                idCliente = Convert.ToDecimal(dgvCliente.Rows[e.RowIndex].Cells["Column0"].Value);
                //Limpia el color de  la fila cuando se selecciona otro boton
                foreach (DataGridViewRow fila in dgvCliente.Rows)
                {
                    fila.DefaultCellStyle.BackColor = dgvCliente.DefaultCellStyle.BackColor;

                }


                // Obtiene los datos de la fila seleccionada

                DataGridViewRow filaSeleccionada = dgvCliente.Rows[e.RowIndex];

                //le da color a la fila seleccionada
                filaSeleccionada.DefaultCellStyle.BackColor = Color.SteelBlue;


                string cuit = filaSeleccionada.Cells["Column0"].Value.ToString();
                string nombre = filaSeleccionada.Cells["Column1"].Value.ToString();
                string direccion = filaSeleccionada.Cells["Column2"].Value.ToString();
                string mail = filaSeleccionada.Cells["Column3"].Value.ToString();
                string condicion = filaSeleccionada.Cells["Column4"].Value.ToString();


                // Actualiza los TextBox con los datos de la fila seleccionada
                txt_cuit.Text = cuit;
                txt_nombre.Text = nombre;
                txt_direccion.Text = direccion;
                txt_mail.Text = mail;
                cmb_condicion.Text = condicion;

            }
        }


        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txt_filtrar.Text;
            Filtrar filtrador = new Filtrar();
            filtrador.FiltrarClientes(dgvCliente, filtro);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                ConectaDB.AbrirDB();
                string insertCliente = "INSERT INTO clientes (cuit_cliente, cliente_nombre, direccion, mail_cliente, condicion_cliente) VALUES (" + txt_cuit.Text + ", '" + txt_nombre.Text + "', '" + txt_direccion.Text + "', '" + txt_mail.Text + "', '" + cmb_condicion.Text + "')";
                ConectaDB.CargarDB(insertCliente);
                ConectaDB.CerrarDB();
                MessageBox.Show("El Cliente ha sido agregado correctamente.");
                dgv_Clientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el Cliente: " + ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                ConectaDB.AbrirDB();
                string updateProveedor = "UPDATE clientes SET cuit_cliente = " + txt_cuit.Text + ", cliente_nombre = '" + txt_nombre.Text + "', direccion = '" + txt_direccion.Text + "', mail_cliente = '" + txt_mail.Text + "',condicion_cliente = '" + cmb_condicion.Text + "' WHERE cuit_cliente = " + idCliente;
                ConectaDB.CargarDB(updateProveedor);
                ConectaDB.CerrarDB();
                dgv_Clientes();
                MessageBox.Show("Actualización exitosa.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar cliente: " + ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ConectaDB.AbrirDB();
                string deleteCliente = "DELETE FROM clientes WHERE cuit_cliente = " + idCliente + ";";
                ConectaDB.CargarDB(deleteCliente);
                ConectaDB.CerrarDB();
                MessageBox.Show("Cliente eliminado correctamente");
                dgv_Clientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el Cliente: " + ex.Message);
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }
        public void Limpiar()
        {
            txt_cuit.Text = "";
            txt_direccion.Text = "";
            txt_mail.Text = "";
            txt_nombre.Text = "";
        }

        private void btn_descargaPlantilla_Click(object sender, EventArgs e)
        {
           
        }
    }
}
