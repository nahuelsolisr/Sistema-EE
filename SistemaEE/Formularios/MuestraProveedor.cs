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
    public partial class MuestraProveedor : MaterialForm
    {
        public MuestraProveedor()
        {
            InitializeComponent();
            this.Size = new Size(694, 469);
            this.Resize += (sender, e) => this.Size = new Size(694, 469);
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = true;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
            //
            dgv_Proveedores();
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

        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0 && dgvProveedor.Columns[e.ColumnIndex].Name == "btn_seleccionar")
            {

                Clases.Elegir.cuit_prov = Convert.ToDecimal(dgvProveedor.Rows[e.RowIndex].Cells["Column0"].Value);
                Clases.Elegir.nom_prov = Convert.ToString(dgvProveedor.Rows[e.RowIndex].Cells["Column1"].Value);

                this.Close();

            }


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



        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txt_filtrar.Text;
            Filtrar filtrador = new Filtrar();
            filtrador.FiltrarProveedores(dgvProveedor, filtro);
        }
    }
}
