using MaterialSkin;
using MaterialSkin.Controls;
using OfficeOpenXml;
using SistemaEE.Clases;
using SistemaEE.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SistemaEE.Formularios
{
    public partial class Productos : MaterialForm
    {
        int idProductoSeleccionado; // Variable id de producto para modificar - dar de baja


        public Productos()
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
            dgv_Productos();
            if (Elegir.modoOscuro)
            {
                EstiloOscuro();
                dgvProductos.DefaultCellStyle.BackColor = Color.DimGray;
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

        private void Productos_Load(object sender, EventArgs e)
        {

        }



        //Botón salir



        //Evento click en botón de la grilla
        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se hizo clic en la celda del botón "btn_seleccionar"
            if (e.RowIndex >= 0 && dgvProductos.Columns[e.ColumnIndex].Name == "btn_seleccionar")
            {
                idProductoSeleccionado = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Column0"].Value);
                //Limpia el color de  la fila cuando se selecciona otro boton
                foreach (DataGridViewRow fila in dgvProductos.Rows)
                {
                    fila.DefaultCellStyle.BackColor = dgvProductos.DefaultCellStyle.BackColor;

                }


                // Obtiene los datos de la fila seleccionada

                DataGridViewRow filaSeleccionada = dgvProductos.Rows[e.RowIndex];

                //le da color a la fila seleccionada
                filaSeleccionada.DefaultCellStyle.BackColor = Color.SteelBlue;


                string nombre = filaSeleccionada.Cells["Column2"].Value.ToString();
                string categoria = filaSeleccionada.Cells["Column3"].Value.ToString();
                string marca = filaSeleccionada.Cells["Column4"].Value.ToString();


                // Actualiza los TextBox con los datos de la fila seleccionada
                txt_nombre.Text = nombre;
                txt_categoria.Text = categoria;
                txt_marca.Text = marca;

            }
        }







        //Cargo los productos en la grilla
        public void dgv_Productos()
        {
            ConectaDB.AbrirDB();
            string consultaproductos = "SELECT * FROM productos";
            ConectaDB.LecturaDB(consultaproductos);
            dgvProductos.Rows.Clear(); // Limpia los datos anteriores en la grilla

            while (DB.lector.Read())
            {
                //En lugar de asignar cada valor al valor de una celda específica de la grilla, 
                //se puede agregar una fila completa a la grilla de una sola vez, utilizando el método 
                //Add() de la propiedad Rows de la grilla.

                dgvProductos.Rows.Add(
                    DB.lector["id_producto"],
                     "",
                    DB.lector["nombre"],
                    DB.lector["categoria"],
                    DB.lector["marca"]

                );
            }

            dgvProductos.ClearSelection();
            DB.lector.Close();
        }

        private void btn_buscarProv_Click(object sender, EventArgs e)
        {
            MuestraProveedor muestraProveedor = new MuestraProveedor();
            muestraProveedor.ShowDialog();
            txt_prov.Text = Clases.Elegir.cuit_prov.ToString();
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                ConectaDB.AbrirDB();
                string insertProducto = "INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (" + Elegir.cuit_prov + " ,'" + txt_nombre.Text + "', '" + txt_categoria.Text + "', '" + txt_marca.Text + "')";
                ConectaDB.CargarDB(insertProducto);
                ConectaDB.CerrarDB();
                MessageBox.Show("El producto ha sido agregado correctamente.");
                dgv_Productos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            try
            {
                ConectaDB.AbrirDB();
                string updateProducto = "UPDATE productos SET cuit_prov = " + txt_prov.Text + " , nombre = '" + txt_nombre.Text + "', categoria = '" + txt_categoria.Text + "', marca = '" + txt_marca.Text + "' WHERE id_producto = " + idProductoSeleccionado;
                ConectaDB.CargarDB(updateProducto);
                ConectaDB.CerrarDB();
                dgv_Productos();
                MessageBox.Show("Actualización exitosa.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ConectaDB.AbrirDB();
                string deleteProducto = "DELETE FROM productos WHERE id_producto = " + idProductoSeleccionado + ";";
                ConectaDB.CargarDB(deleteProducto);
                ConectaDB.CerrarDB();
                MessageBox.Show("Producto eliminado correctamente");
                dgv_Productos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }

        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txt_filtrar.Text;
            Filtrar filtrador = new Filtrar();
            filtrador.FiltrarProductos(dgvProductos, filtro);
        }



        private void Productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btn_traerProv_Click(object sender, EventArgs e)
        {
            MuestraProveedor muestraProveedor = new MuestraProveedor();
            muestraProveedor.ShowDialog();
            txt_prov.Text = Clases.Elegir.nom_prov.ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            txt_nombre.Text = "";
            txt_categoria.Text = "";
            txt_marca.Text = "";
            txt_prov.Text = "";
        }

        WebClient cliente = new WebClient();
        string ruta = null;

        //DESCARGAR PLANTILLA 

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
                cliente.DownloadFileAsync(new Uri(@"C:\MisProyectos\Sistema Economia Empresarial\SistemaEE\Resources\PlantillaProductos.rar"), dialogo.FileName);
            }
        }

        //CARGA MASIVA DE PRODUCTOS

        private void btn_cargaMasiva_Click(object sender, EventArgs e)
        {
            try
            {
                // Permite al usuario seleccionar el archivo Excel
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtiene la ruta del archivo seleccionado
                    string rutaArchivo = openFileDialog.FileName;

                    // Crea una instancia de FileInfo para el archivo Excel
                    FileInfo archivoExcel = new FileInfo(rutaArchivo);

                    // Crea una instancia de ExcelPackage para leer el archivo Excel
                    using (ExcelPackage excelPackage = new ExcelPackage(archivoExcel))
                    {
                        // Obtén la primera hoja del archivo Excel
                        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1]; // Índice 1 representa la primera hoja

                        // Inicializa el número de fila
                        int fila = 2; // Ignoramos la primera fila, ya que generalmente contiene encabezados

                        // Recorre las filas hasta encontrar una fila vacía en la columna A
                        while (string.IsNullOrEmpty(excelWorksheet.Cells[fila, 1].Value?.ToString()))
                        {
                            decimal cuitProv = Convert.ToDecimal(excelWorksheet.Cells[fila, 2].Value);
                            string nombre = excelWorksheet.Cells[fila, 3].Value?.ToString();
                            string categoria = excelWorksheet.Cells[fila, 4].Value?.ToString();
                            string marca = excelWorksheet.Cells[fila, 5].Value?.ToString();

                            // Construye la consulta de inserción
                            string insertProducto = "INSERT INTO productos (cuit_prov, nombre, categoria, marca) VALUES (" + cuitProv + ", '" + nombre + "', '" + categoria + "', '" + marca + "')";

                            try
                            {
                                // Realiza la inserción en la base de datos
                                ConectaDB.AbrirDB();
                                ConectaDB.CargarDB(insertProducto);
                                ConectaDB.CerrarDB();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al agregar el producto en la fila " + fila + ": " + ex.Message);
                                // Puedes manejar el error de inserción aquí, si es necesario
                            }

                            fila++; // Incrementa el número de fila
                        }
                    }

                    MessageBox.Show("La carga masiva ha sido completada.", "Carga masiva exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el archivo Excel: " + ex.Message, "Error de carga masiva", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
