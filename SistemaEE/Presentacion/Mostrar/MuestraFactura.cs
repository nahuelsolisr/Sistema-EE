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
using DocumentFormat.OpenXml.Bibliography;
using FontAwesome.Sharp;
using MaterialSkin;
using MaterialSkin.Controls;
using SistemaEE.AccesoDatos;
using SistemaEE.Clases;

namespace SistemaEE.Presentacion.Mostrar
{
    public partial class MuestraFactura : MaterialForm
    {
        public MuestraFactura()
        {

            InitializeComponent();
            CargarDatosEmpresa();
            OtrosDatos();
        }
        public void AgregarDatosAlDataGridView(List<string[]> datos)
        {
            foreach (string[] fila in datos)
            {
                dgvProductosF.Rows.Add(fila);
            }

            // Declarar una variable para almacenar la suma total
            decimal total = 0;
            decimal iva = 0;

            // Iterar a través de las filas del DataGridView
            if (lbl_tipoFactura.Text == "A")
            {
                foreach (DataGridViewRow row in dgvProductosF.Rows)
                {
                    // Verificar si la celda en la columna deseada no está vacía y contiene un valor numérico
                    if (row.Cells["subtotal"].Value != null &&
                        decimal.TryParse(row.Cells["subtotal"].Value.ToString(), out decimal subtotal))
                    {
                        // Sumar el valor de la celda a la variable total
                        total += subtotal;
                        lbl_iva.Text = "IVA: INCLUIDO";
                        lbl_totalSiniva.Text = "TOTAL: $" + total.ToString();
                    }
                }
            }
            if (lbl_tipoFactura.Text == "B")
            {
                foreach (DataGridViewRow row in dgvProductosF.Rows)
                {
                    // Verificar si la celda en la columna deseada no está vacía y contiene un valor numérico
                    if (row.Cells["subtotal"].Value != null &&
                        decimal.TryParse(row.Cells["subtotal"].Value.ToString(), out decimal subtotal))
                    {
                        // Sumar el valor de la celda a la variable total
                        total += subtotal;
                        lbl_iva.Text = "IVA: INCLUIDO";
                        lbl_totalSiniva.Text = "TOTAL: $" + total.ToString();
                    }
                }
            }
            if (lbl_tipoFactura.Text == "C")
            {
                // Asegúrate de que la columna "iva" existe en el DataGridView
                if (dgvProductosF.Columns.Contains("iva"))
                {
                    dgvProductosF.Columns["iva"].Visible = true; // Hacer visible la columna "iva"
                }

                foreach (DataGridViewRow row in dgvProductosF.Rows)
                {
                    // Verificar si la celda en la columna deseada no está vacía y contiene un valor numérico
                    if (row.Cells["subtotal"].Value != null &&
                        decimal.TryParse(row.Cells["subtotal"].Value.ToString(), out decimal subtotal))
                    {
                        // Calcular el subtotal con descuento del 21%
                        decimal subtotalConDescuento = subtotal - (subtotal * 0.21M);

                        // Asignar el valor del subtotal con descuento a la celda "subtotal" en la fila actual
                        row.Cells["subtotal"].Value = subtotalConDescuento;

                        // Calcular el IVA (21%) y asignarlo a la columna "iva" en la fila actual
                        iva = subtotal * 0.21M;
                        row.Cells["iva"].Value = iva;

                        // Sumar el valor de la celda a la variable total
                        total += subtotalConDescuento;
                        lbl_iva.Text = "IVA: $" + iva;
                        lbl_totalSiniva.Text = "TOTAL SIN IVA: $" + total.ToString();
                        lbl_total.Text = "TOTAL NETO" + (total + iva).ToString();
                    }
                }
            }

            // Calcular el total final y mostrarlo en lbl_totaFinal
            decimal totalFinal = total + iva;
            lbl_totalFinal.Text = "TOTAL: $" + totalFinal.ToString();



        }

        public void CargarDatosEmpresa()
        {
            ConectaDB.AbrirDB();
            string consulta = "SELECT nombreEmpresa, cuitEmpresa, direccionEmpresa FROM datosEmpresa";
            SqlDataReader reader = ConectaDB.LecturaDB(consulta);

            if (reader.Read())
            {
                lbl_nombreEmpresa.Text = reader["nombreEmpresa"].ToString();
                lbl_cuitEmpresa.Text = reader["cuitEmpresa"].ToString();
                lbl_direccionEmpresa.Text = reader["direccionEmpresa"].ToString();
            }
            else
            {
                // No se encontraron datos en la tabla datosEmpresa
                // Puedes manejarlo de acuerdo a tus necesidades (mostrar un mensaje de error, por ejemplo)
            }
            reader.Close();
            ConectaDB.CerrarDB();

        }
        public void OtrosDatos()
        {
            if (Datos.condicionante == "Responsable Inscripto")
            {
                lbl_tipoFactura.Text = "A";
            }
            if (Datos.condicionante == "Monotributista ")
            {
                lbl_tipoFactura.Text = "B";
            }
            if (Datos.condicionante == "Consumidor Final")
            {
                lbl_tipoFactura.Text = "C";
            }


            DateTime fechaActual = DateTime.Now;
            lbl_fechaEmision.Text = fechaActual.ToString("dd/MM/yyyy HH:mm:ss");

            ConectaDB.AbrirDB();

            // Obtener el valor actual de numeroFactura de la base de datos
            string consultaNumeroFactura = "SELECT numeroFactura FROM Factura";
            SqlDataReader readerNumeroFactura = ConectaDB.LecturaDB(consultaNumeroFactura);

            int numeroFacturaActual = 0;

            if (readerNumeroFactura.Read())
            {
                numeroFacturaActual = Convert.ToInt32(readerNumeroFactura["numeroFactura"]);
            }

            readerNumeroFactura.Close();

            // Incrementar el número de factura y formatearlo con ceros adelante
            int nuevoNumeroFactura = numeroFacturaActual + 1;
            string nuevoNumeroFacturaFormateado = nuevoNumeroFactura.ToString().PadLeft(4, '0');

            // Realizar el update para actualizar el número de factura en la tabla Factura
            string updateNumeroFactura = "UPDATE Factura SET numeroFactura = '" + nuevoNumeroFacturaFormateado + "'";
            ConectaDB.CargarDB(updateNumeroFactura);

            // Asignar el nuevo número de factura al lbl_numeroFactura
            lbl_numeroFactura.Text = nuevoNumeroFacturaFormateado;

            ConectaDB.CerrarDB();
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
