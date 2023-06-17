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
    }
}
