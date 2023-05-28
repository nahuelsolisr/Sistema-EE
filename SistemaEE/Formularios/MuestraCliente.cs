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
    public partial class MuestraCliente : MaterialForm
    {
        public MuestraCliente()
        {
            InitializeComponent();
            //694; 469
            this.Size = new Size(694, 469);
            this.Resize += (sender, e) => this.Size = new Size(694, 469);
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = true;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
            //
            dgv_Clientes();
            if (Elegir.modoOscuro)
            {
                EstiloOscuro();
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

        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txt_filtrar.Text;
            Filtrar filtrador = new Filtrar();
            filtrador.FiltrarClientes(dgvCliente, filtro);
        }
    }
}
