namespace SistemaEE.Presentacion.Mostrar
{
    partial class MuestraFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuestraFactura));
            lbl_nombreEmpresa = new MaterialSkin.Controls.MaterialLabel();
            lbl_tipoFactura = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            lbl_direccionEmpresa = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            lbl_cuitEmpresa = new MaterialSkin.Controls.MaterialLabel();
            lbl_numeroFactura = new MaterialSkin.Controls.MaterialLabel();
            panel2 = new Panel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            lbl_fechaEmision = new MaterialSkin.Controls.MaterialLabel();
            panel3 = new Panel();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            dgvProductos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            btn_imprimir = new MaterialSkin.Controls.MaterialButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lbl_nombreEmpresa
            // 
            lbl_nombreEmpresa.AutoSize = true;
            lbl_nombreEmpresa.Depth = 0;
            lbl_nombreEmpresa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_nombreEmpresa.Location = new Point(6, 69);
            lbl_nombreEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_nombreEmpresa.Name = "lbl_nombreEmpresa";
            lbl_nombreEmpresa.Size = new Size(156, 19);
            lbl_nombreEmpresa.TabIndex = 0;
            lbl_nombreEmpresa.Text = "@NOMBRE EMPRESA";
            // 
            // lbl_tipoFactura
            // 
            lbl_tipoFactura.AutoSize = true;
            lbl_tipoFactura.BorderStyle = BorderStyle.FixedSingle;
            lbl_tipoFactura.Depth = 0;
            lbl_tipoFactura.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_tipoFactura.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            lbl_tipoFactura.Location = new Point(195, 116);
            lbl_tipoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_tipoFactura.Name = "lbl_tipoFactura";
            lbl_tipoFactura.Size = new Size(37, 72);
            lbl_tipoFactura.TabIndex = 1;
            lbl_tipoFactura.Text = "T";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(lbl_direccionEmpresa);
            panel1.Controls.Add(materialLabel3);
            panel1.Controls.Add(lbl_cuitEmpresa);
            panel1.Location = new Point(6, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 132);
            panel1.TabIndex = 2;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(12, 84);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(85, 19);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "DIRECCIÓN:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(12, 37);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(39, 19);
            materialLabel1.TabIndex = 9;
            materialLabel1.Text = "CUIT:";
            // 
            // lbl_direccionEmpresa
            // 
            lbl_direccionEmpresa.AutoSize = true;
            lbl_direccionEmpresa.Depth = 0;
            lbl_direccionEmpresa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_direccionEmpresa.Location = new Point(3, 108);
            lbl_direccionEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_direccionEmpresa.Name = "lbl_direccionEmpresa";
            lbl_direccionEmpresa.Size = new Size(95, 19);
            lbl_direccionEmpresa.TabIndex = 8;
            lbl_direccionEmpresa.Text = "@DIRECCION";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(112, 14);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(70, 19);
            materialLabel3.TabIndex = 3;
            materialLabel3.Text = "FACTURA";
            // 
            // lbl_cuitEmpresa
            // 
            lbl_cuitEmpresa.AutoSize = true;
            lbl_cuitEmpresa.Depth = 0;
            lbl_cuitEmpresa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_cuitEmpresa.Location = new Point(3, 60);
            lbl_cuitEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_cuitEmpresa.Name = "lbl_cuitEmpresa";
            lbl_cuitEmpresa.Size = new Size(49, 19);
            lbl_cuitEmpresa.TabIndex = 7;
            lbl_cuitEmpresa.Text = "@CUIT";
            // 
            // lbl_numeroFactura
            // 
            lbl_numeroFactura.AutoSize = true;
            lbl_numeroFactura.Depth = 0;
            lbl_numeroFactura.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_numeroFactura.Location = new Point(51, 14);
            lbl_numeroFactura.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_numeroFactura.Name = "lbl_numeroFactura";
            lbl_numeroFactura.Size = new Size(153, 19);
            lbl_numeroFactura.TabIndex = 4;
            lbl_numeroFactura.Text = "@NUMERO FACTURA";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(materialLabel4);
            panel2.Controls.Add(materialLabel9);
            panel2.Controls.Add(lbl_fechaEmision);
            panel2.Controls.Add(lbl_numeroFactura);
            panel2.Location = new Point(213, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 132);
            panel2.TabIndex = 5;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(3, 84);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(121, 19);
            materialLabel4.TabIndex = 11;
            materialLabel4.Text = "FECHA EMISIÓN:";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(23, 14);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(22, 19);
            materialLabel9.TabIndex = 7;
            materialLabel9.Text = "N°:";
            // 
            // lbl_fechaEmision
            // 
            lbl_fechaEmision.AutoSize = true;
            lbl_fechaEmision.Depth = 0;
            lbl_fechaEmision.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_fechaEmision.Location = new Point(3, 108);
            lbl_fechaEmision.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_fechaEmision.Name = "lbl_fechaEmision";
            lbl_fechaEmision.Size = new Size(131, 19);
            lbl_fechaEmision.TabIndex = 6;
            lbl_fechaEmision.Text = "@FECHA EMISION";
            // 
            // panel3
            // 
            panel3.Controls.Add(materialLabel13);
            panel3.Controls.Add(materialLabel12);
            panel3.Controls.Add(dgvProductos);
            panel3.Location = new Point(6, 254);
            panel3.Name = "panel3";
            panel3.Size = new Size(416, 237);
            panel3.TabIndex = 7;
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(145, 10);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(75, 19);
            materialLabel13.TabIndex = 174;
            materialLabel13.Text = "CONTADO";
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(8, 10);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(129, 19);
            materialLabel12.TabIndex = 173;
            materialLabel12.Text = "FORMA DE PAGO:";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column5, Column6 });
            dgvProductos.Location = new Point(4, 38);
            dgvProductos.Margin = new Padding(4);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(408, 186);
            dgvProductos.TabIndex = 171;
            // 
            // Column1
            // 
            Column1.HeaderText = "Producto";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Precio";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cantidad";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Sub-Total";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(10, 568);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(39, 19);
            materialLabel10.TabIndex = 9;
            materialLabel10.Text = "@IVA";
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(98, 568);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(65, 19);
            materialLabel11.TabIndex = 172;
            materialLabel11.Text = "@TOTAL";
            // 
            // btn_imprimir
            // 
            btn_imprimir.AutoSize = false;
            btn_imprimir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_imprimir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_imprimir.Depth = 0;
            btn_imprimir.HighEmphasis = true;
            btn_imprimir.Icon = (Image)resources.GetObject("btn_imprimir.Icon");
            btn_imprimir.Location = new Point(309, 556);
            btn_imprimir.Margin = new Padding(4, 6, 4, 6);
            btn_imprimir.MouseState = MaterialSkin.MouseState.HOVER;
            btn_imprimir.Name = "btn_imprimir";
            btn_imprimir.NoAccentTextColor = Color.Empty;
            btn_imprimir.Size = new Size(113, 36);
            btn_imprimir.TabIndex = 179;
            btn_imprimir.Text = "Imprimir";
            btn_imprimir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_imprimir.UseAccentColor = false;
            btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // MuestraFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 601);
            Controls.Add(btn_imprimir);
            Controls.Add(panel3);
            Controls.Add(materialLabel11);
            Controls.Add(lbl_tipoFactura);
            Controls.Add(materialLabel10);
            Controls.Add(panel2);
            Controls.Add(lbl_nombreEmpresa);
            Controls.Add(panel1);
            Name = "MuestraFactura";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_nombreEmpresa;
        private MaterialSkin.Controls.MaterialLabel lbl_tipoFactura;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lbl_direccionEmpresa;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lbl_cuitEmpresa;
        private MaterialSkin.Controls.MaterialLabel lbl_numeroFactura;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel lbl_fechaEmision;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btn_imprimir;
    }
}