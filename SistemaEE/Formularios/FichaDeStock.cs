using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEE.Formularios
{
    public partial class FichaDeStock : Form
    {
        public FichaDeStock()
        {
            InitializeComponent();
            aparienciaGrilla();
            dgv_FichaStock();
        }
        public void dgv_FichaStock()
        {
            ConectaDB.AbrirDB();
            string consulta = "SELECT * FROM fichastock";
            SqlDataReader lector = ConectaDB.LecturaDB(consulta);
            dgvFichaStock.Rows.Clear();

            while (DB.lector.Read())
            {


                dgvFichaStock.Rows.Add(
                    DB.lector["fecha"],
                     DB.lector["nombreProducto"],
                     "",
                    DB.lector["Concepto"],
                    DB.lector["UnidadesE"],
                    DB.lector["PrecioUE"],
                    DB.lector["TotalE"],
                    DB.lector["UnidadesS"],
                    DB.lector["PrecioUS"],
                    DB.lector["TotalS"],
                    DB.lector["UnidadesEx"],
                    DB.lector["PrecioUEx"],
                    DB.lector["TotalEx"]

                );
            }

            dgvFichaStock.ClearSelection();
            DB.lector.Close();
        }
        public void aparienciaGrilla()
        {
            dgvFichaStock.Columns[4].DefaultCellStyle.BackColor = Color.LightGreen;
            dgvFichaStock.Columns[5].DefaultCellStyle.BackColor = Color.LightGreen;
            dgvFichaStock.Columns[6].DefaultCellStyle.BackColor = Color.LightGreen;
            dgvFichaStock.Columns[7].DefaultCellStyle.BackColor = Color.LightSalmon;
            dgvFichaStock.Columns[8].DefaultCellStyle.BackColor = Color.LightSalmon;
            dgvFichaStock.Columns[9].DefaultCellStyle.BackColor = Color.LightSalmon;
            dgvFichaStock.Columns[10].DefaultCellStyle.BackColor = Color.LightBlue;
            dgvFichaStock.Columns[11].DefaultCellStyle.BackColor = Color.LightBlue;
            dgvFichaStock.Columns[12].DefaultCellStyle.BackColor = Color.LightBlue;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
