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
    public partial class MuestraCliente : Form
    {
        public MuestraCliente()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            dgv_Clientes();
        }
        public void dgv_Clientes()
        {

            ConectaDB.AbrirDB();
            string consultaCliente = "SELECT * FROM clientes";
            ConectaDB.LecturaDB(consultaCliente);
            dgvCliente.Rows.Clear(); // Limpia los datos anteriores en la grilla

            while (DB.lector.Read())
            {
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

        private void Seleccionar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == btn_seleccionar.Index)
            {

                Clases.Elegir.CUITCliente = Convert.ToDecimal(dgvCliente.Rows[e.RowIndex].Cells["Column0"].Value);
                Clases.Elegir.NombreCliente = Convert.ToString(dgvCliente.Rows[e.RowIndex].Cells["Column1"].Value);
                Clases.Elegir.direccion_cliente = Convert.ToString(dgvCliente.Rows[e.RowIndex].Cells["Column2"].Value);
                Clases.Elegir.mail_cliente = Convert.ToString(dgvCliente.Rows[e.RowIndex].Cells["Column3"].Value);
                Clases.Elegir.condicionante = Convert.ToString(dgvCliente.Rows[e.RowIndex].Cells["Column4"].Value);

                this.Close();

            }

        }



        private void txt_filtrarGrilla_TextChanged(object sender, EventArgs e)
        {
            string filtro = txt_filtrarGrilla.Text;
            Filtrar filtrador = new Filtrar();
            filtrador.FiltrarClientes(dgvCliente, filtro);
        }
    }
}
