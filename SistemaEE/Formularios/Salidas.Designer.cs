namespace SistemaEE.Formularios
{
    partial class Salidas
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
            btn_añadir = new FontAwesome.Sharp.IconButton();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            btn_traerProduct = new FontAwesome.Sharp.IconButton();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            dgvProductos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            nud_cantidad = new NumericUpDown();
            txt_precio = new TextBox();
            label5 = new Label();
            txt_nombreProducto = new TextBox();
            label3 = new Label();
            txt_idproducto = new TextBox();
            label4 = new Label();
            btn_TraerCliente = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txt_nombreCliente = new TextBox();
            label2 = new Label();
            txt_cuit = new TextBox();
            label1 = new Label();
            btn_confirmar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            btn_salir = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label6 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_añadir
            // 
            btn_añadir.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btn_añadir.IconColor = Color.Black;
            btn_añadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_añadir.IconSize = 35;
            btn_añadir.ImageAlign = ContentAlignment.MiddleRight;
            btn_añadir.Location = new Point(574, 49);
            btn_añadir.Name = "btn_añadir";
            btn_añadir.Size = new Size(166, 49);
            btn_añadir.TabIndex = 176;
            btn_añadir.Text = "Agregar al  carrito";
            btn_añadir.TextAlign = ContentAlignment.MiddleLeft;
            btn_añadir.UseVisualStyleBackColor = true;
            btn_añadir.Click += btn_añadir_Click;
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = Color.WhiteSmoke;
            iconPictureBox7.ForeColor = SystemColors.ControlText;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            iconPictureBox7.IconColor = SystemColors.ControlText;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 27;
            iconPictureBox7.Location = new Point(115, 71);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(31, 27);
            iconPictureBox7.TabIndex = 175;
            iconPictureBox7.TabStop = false;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.WhiteSmoke;
            iconPictureBox5.ForeColor = SystemColors.ControlText;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            iconPictureBox5.IconColor = SystemColors.ControlText;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 27;
            iconPictureBox5.Location = new Point(4, 71);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(31, 27);
            iconPictureBox5.TabIndex = 174;
            iconPictureBox5.TabStop = false;
            // 
            // btn_traerProduct
            // 
            btn_traerProduct.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btn_traerProduct.IconColor = Color.Black;
            btn_traerProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_traerProduct.IconSize = 20;
            btn_traerProduct.Location = new Point(729, 69);
            btn_traerProduct.Name = "btn_traerProduct";
            btn_traerProduct.Size = new Size(38, 28);
            btn_traerProduct.TabIndex = 173;
            btn_traerProduct.UseVisualStyleBackColor = true;
            btn_traerProduct.Click += btn_traerProduct_Click;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.WhiteSmoke;
            iconPictureBox4.ForeColor = SystemColors.ControlText;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            iconPictureBox4.IconColor = SystemColors.ControlText;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 27;
            iconPictureBox4.Location = new Point(403, 70);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(31, 27);
            iconPictureBox4.TabIndex = 172;
            iconPictureBox4.TabStop = false;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvProductos.Location = new Point(13, 232);
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
            dgvProductos.Size = new Size(757, 301);
            dgvProductos.TabIndex = 170;
            // 
            // Column1
            // 
            Column1.HeaderText = "Producto";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 103;
            // 
            // Column2
            // 
            Column2.HeaderText = "Marca";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoria";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(144, 49);
            label7.Name = "label7";
            label7.Size = new Size(77, 19);
            label7.TabIndex = 169;
            label7.Text = "Cantidad:";
            // 
            // nud_cantidad
            // 
            nud_cantidad.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nud_cantidad.Location = new Point(147, 71);
            nud_cantidad.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nud_cantidad.Name = "nud_cantidad";
            nud_cantidad.Size = new Size(99, 27);
            nud_cantidad.TabIndex = 168;
            // 
            // txt_precio
            // 
            txt_precio.Enabled = false;
            txt_precio.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_precio.Location = new Point(35, 71);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(74, 27);
            txt_precio.TabIndex = 167;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 49);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 166;
            label5.Text = "Precio:";
            // 
            // txt_nombreProducto
            // 
            txt_nombreProducto.Enabled = false;
            txt_nombreProducto.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombreProducto.Location = new Point(583, 70);
            txt_nombreProducto.Name = "txt_nombreProducto";
            txt_nombreProducto.Size = new Size(145, 27);
            txt_nombreProducto.TabIndex = 165;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(586, 48);
            label3.Name = "label3";
            label3.Size = new Size(140, 19);
            label3.TabIndex = 164;
            label3.Text = "Nombre Producto:";
            // 
            // txt_idproducto
            // 
            txt_idproducto.Enabled = false;
            txt_idproducto.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_idproducto.Location = new Point(435, 70);
            txt_idproducto.Name = "txt_idproducto";
            txt_idproducto.Size = new Size(145, 27);
            txt_idproducto.TabIndex = 163;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(434, 48);
            label4.Name = "label4";
            label4.Size = new Size(133, 19);
            label4.TabIndex = 162;
            label4.Text = "Codigo Producto:";
            // 
            // btn_TraerCliente
            // 
            btn_TraerCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btn_TraerCliente.IconColor = Color.Black;
            btn_TraerCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_TraerCliente.IconSize = 20;
            btn_TraerCliente.Location = new Point(338, 69);
            btn_TraerCliente.Name = "btn_TraerCliente";
            btn_TraerCliente.Size = new Size(38, 28);
            btn_TraerCliente.TabIndex = 183;
            btn_TraerCliente.UseVisualStyleBackColor = true;
            btn_TraerCliente.Click += btn_TraerCliente_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 27;
            iconPictureBox1.Location = new Point(13, 69);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(31, 27);
            iconPictureBox1.TabIndex = 181;
            iconPictureBox1.TabStop = false;
            // 
            // txt_nombreCliente
            // 
            txt_nombreCliente.Enabled = false;
            txt_nombreCliente.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombreCliente.Location = new Point(44, 69);
            txt_nombreCliente.Name = "txt_nombreCliente";
            txt_nombreCliente.Size = new Size(144, 27);
            txt_nombreCliente.TabIndex = 180;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 47);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 179;
            label2.Text = "Nombre Cliente:";
            // 
            // txt_cuit
            // 
            txt_cuit.Enabled = false;
            txt_cuit.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cuit.Location = new Point(191, 69);
            txt_cuit.Name = "txt_cuit";
            txt_cuit.Size = new Size(145, 27);
            txt_cuit.TabIndex = 178;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(194, 47);
            label1.Name = "label1";
            label1.Size = new Size(105, 19);
            label1.TabIndex = 177;
            label1.Text = "CUIT Cliente:";
            // 
            // btn_confirmar
            // 
            btn_confirmar.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_confirmar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btn_confirmar.IconColor = Color.Black;
            btn_confirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_confirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_confirmar.Location = new Point(646, 544);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(126, 45);
            btn_confirmar.TabIndex = 184;
            btn_confirmar.Text = "Guardar ";
            btn_confirmar.TextAlign = ContentAlignment.MiddleRight;
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 10);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(171, 19);
            label8.TabIndex = 185;
            label8.Text = "DETALLES DE VENTA:";
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salir.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            btn_salir.IconColor = Color.Black;
            btn_salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_salir.IconSize = 25;
            btn_salir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salir.Location = new Point(12, 544);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(115, 46);
            btn_salir.TabIndex = 186;
            btn_salir.Text = "Salir";
            btn_salir.TextAlign = ContentAlignment.MiddleRight;
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_precio);
            panel1.Controls.Add(nud_cantidad);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(iconPictureBox5);
            panel1.Controls.Add(iconPictureBox7);
            panel1.Controls.Add(btn_añadir);
            panel1.Location = new Point(12, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 110);
            panel1.TabIndex = 187;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(198, 19);
            label6.TabIndex = 188;
            label6.Text = "SELECCIONE EL CLIENTE:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(403, 9);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(220, 19);
            label9.TabIndex = 189;
            label9.Text = "SELECCIONE EL PRODUCTO:";
            // 
            // Salidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 601);
            ControlBox = false;
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(btn_salir);
            Controls.Add(btn_confirmar);
            Controls.Add(btn_TraerCliente);
            Controls.Add(iconPictureBox1);
            Controls.Add(txt_nombreCliente);
            Controls.Add(label2);
            Controls.Add(txt_cuit);
            Controls.Add(label1);
            Controls.Add(btn_traerProduct);
            Controls.Add(iconPictureBox4);
            Controls.Add(dgvProductos);
            Controls.Add(txt_nombreProducto);
            Controls.Add(label3);
            Controls.Add(txt_idproducto);
            Controls.Add(label4);
            Name = "Salidas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salidas";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_añadir;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconButton btn_traerProduct;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label7;
        private NumericUpDown nud_cantidad;
        private TextBox txt_precio;
        private Label label5;
        private TextBox txt_nombreProducto;
        private Label label3;
        private TextBox txt_idproducto;
        private Label label4;
        private FontAwesome.Sharp.IconButton btn_TraerCliente;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txt_nombreCliente;
        private Label label2;
        private TextBox txt_cuit;
        private Label label1;
        private FontAwesome.Sharp.IconButton btn_confirmar;
        private Label label8;
        private FontAwesome.Sharp.IconButton btn_salir;
        private Panel panel1;
        private Label label6;
        private Label label9;
    }
}