using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEE.Formularios
{
    public partial class Proveedores : Form
    {
        decimal idProveedor;
        public Proveedores()
        {
            InitializeComponent();
            dgv_Proveedores();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void dgv_Proveedores()
        {
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
                filaSeleccionada.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);


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
                txt_condicion.Text = condicion;

            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                ConectaDB.AbrirDB();
                string insertProveedor = "INSERT INTO proveedor (cuit_prov, nombre_prov, domicilio_prov, mail_prov, condicion) VALUES (" + txt_cuit.Text + ", '" + txt_nombre.Text + "', '" + txt_domicilio.Text + "', '" + txt_mail.Text + "', '" + txt_condicion.Text + "')";
                ConectaDB.CargarDB(insertProveedor);
                ConectaDB.CerrarDB();
                MessageBox.Show("El proveedor ha sido agregado correctamente.");
                dgv_Proveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el Proveedor: " + ex.Message);
            }
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            try
            {
                ConectaDB.AbrirDB();
                string deleteProveedor = "DELETE FROM proveedor WHERE cuit_prov = " + idProveedor + ";";
                ConectaDB.CargarDB(deleteProveedor);
                ConectaDB.CerrarDB();
                MessageBox.Show("Producto eliminado correctamente");
                dgv_Proveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el proveedor: " + ex.Message);
            }
        }

        private void btn_Modi_Click(object sender, EventArgs e)
        {
            try
            {
                ConectaDB.AbrirDB();
                string updateProveedor = "UPDATE proveedor SET cuit_prov = " + txt_cuit.Text + ", nombre_prov = '" + txt_nombre.Text + "', domicilio_prov = '" + txt_domicilio.Text + "', mail_prov = '" + txt_mail.Text + "',condicion = '" + txt_condicion.Text + "' WHERE cuit_prov = " + idProveedor;
                ConectaDB.CargarDB(updateProveedor);
                ConectaDB.CerrarDB();
                dgv_Proveedores();
                MessageBox.Show("Actualización exitosa.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar proveedor: " + ex.Message);
            }
        }
    }
}
