using MaterialSkin;
using MaterialSkin.Controls;
using SistemaEE.Clases;
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
    public partial class FichaDeStock : MaterialForm
    {
        public FichaDeStock()
        {
            InitializeComponent();
            aparienciaGrilla();
            dgv_FichaStock();
            //1256; 607
            this.Size = new Size(1256, 607);
            this.Resize += (sender, e) => this.Size = new Size(1256, 607);
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = true;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
            //
            dgv_FichaStock();
            if (Elegir.modoOscuro)
            {
                EstiloOscuro();
                dgvFichaStock.DefaultCellStyle.BackColor = Color.DimGray;
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

        private void FichaDeStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
