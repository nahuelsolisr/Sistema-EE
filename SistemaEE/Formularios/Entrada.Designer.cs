namespace SistemaEE.Formularios
{
    partial class Entrada
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
            txt_provNombre = new TextBox();
            label2 = new Label();
            txt_cuit = new TextBox();
            label1 = new Label();
            txt_nombreProducto = new TextBox();
            label3 = new Label();
            txt_idproducto = new TextBox();
            label4 = new Label();
            txt_precio = new TextBox();
            label5 = new Label();
            label6 = new Label();
            nud_cantidad = new NumericUpDown();
            label7 = new Label();
            nud_ganancia = new NumericUpDown();
            dgvCarrito = new DataGridView();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            btn_TraerProveedor = new FontAwesome.Sharp.IconButton();
            btn_traerProduct = new FontAwesome.Sharp.IconButton();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            btn_añadir = new FontAwesome.Sharp.IconButton();
            btn_confirmar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            pnl_detalle = new Panel();
            btn_salir = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            label10 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_ganancia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            pnl_detalle.SuspendLayout();
            SuspendLayout();
            // 
            // txt_provNombre
            // 
            txt_provNombre.Enabled = false;
            txt_provNombre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_provNombre.Location = new Point(43, 71);
            txt_provNombre.Name = "txt_provNombre";
            txt_provNombre.Size = new Size(144, 27);
            txt_provNombre.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 49);
            label2.Name = "label2";
            label2.Size = new Size(149, 19);
            label2.TabIndex = 13;
            label2.Text = "Nombre Proveedor:";
            // 
            // txt_cuit
            // 
            txt_cuit.Enabled = false;
            txt_cuit.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cuit.Location = new Point(195, 71);
            txt_cuit.Name = "txt_cuit";
            txt_cuit.Size = new Size(145, 27);
            txt_cuit.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(197, 49);
            label1.Name = "label1";
            label1.Size = new Size(125, 19);
            label1.TabIndex = 11;
            label1.Text = "Cuit  Proveedor:";
            // 
            // txt_nombreProducto
            // 
            txt_nombreProducto.Enabled = false;
            txt_nombreProducto.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombreProducto.Location = new Point(429, 70);
            txt_nombreProducto.Name = "txt_nombreProducto";
            txt_nombreProducto.Size = new Size(144, 27);
            txt_nombreProducto.TabIndex = 120;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(430, 48);
            label3.Name = "label3";
            label3.Size = new Size(140, 19);
            label3.TabIndex = 119;
            label3.Text = "Nombre Producto:";
            // 
            // txt_idproducto
            // 
            txt_idproducto.Enabled = false;
            txt_idproducto.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_idproducto.Location = new Point(580, 70);
            txt_idproducto.Name = "txt_idproducto";
            txt_idproducto.Size = new Size(145, 27);
            txt_idproducto.TabIndex = 118;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(581, 48);
            label4.Name = "label4";
            label4.Size = new Size(133, 19);
            label4.TabIndex = 117;
            label4.Text = "Codigo Producto:";
            // 
            // txt_precio
            // 
            txt_precio.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_precio.Location = new Point(34, 66);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(74, 27);
            txt_precio.TabIndex = 123;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 44);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 122;
            label5.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(310, 44);
            label6.Name = "label6";
            label6.Size = new Size(79, 19);
            label6.TabIndex = 124;
            label6.Text = "Ganancia:";
            // 
            // nud_cantidad
            // 
            nud_cantidad.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nud_cantidad.Location = new Point(162, 66);
            nud_cantidad.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nud_cantidad.Name = "nud_cantidad";
            nud_cantidad.Size = new Size(99, 27);
            nud_cantidad.TabIndex = 126;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(159, 44);
            label7.Name = "label7";
            label7.Size = new Size(77, 19);
            label7.TabIndex = 127;
            label7.Text = "Cantidad:";
            // 
            // nud_ganancia
            // 
            nud_ganancia.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nud_ganancia.Location = new Point(312, 65);
            nud_ganancia.Name = "nud_ganancia";
            nud_ganancia.Size = new Size(121, 27);
            nud_ganancia.TabIndex = 130;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToResizeColumns = false;
            dgvCarrito.AllowUserToResizeRows = false;
            dgvCarrito.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column3 });
            dgvCarrito.Location = new Point(13, 232);
            dgvCarrito.Margin = new Padding(4);
            dgvCarrito.MultiSelect = false;
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dgvCarrito.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCarrito.RowTemplate.Height = 25;
            dgvCarrito.Size = new Size(763, 304);
            dgvCarrito.TabIndex = 133;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 27;
            iconPictureBox1.Location = new Point(12, 71);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(31, 27);
            iconPictureBox1.TabIndex = 134;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.WhiteSmoke;
            iconPictureBox4.ForeColor = SystemColors.ControlText;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            iconPictureBox4.IconColor = SystemColors.ControlText;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 27;
            iconPictureBox4.Location = new Point(397, 70);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(31, 27);
            iconPictureBox4.TabIndex = 137;
            iconPictureBox4.TabStop = false;
            // 
            // btn_TraerProveedor
            // 
            btn_TraerProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btn_TraerProveedor.IconColor = Color.Black;
            btn_TraerProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_TraerProveedor.IconSize = 20;
            btn_TraerProveedor.Location = new Point(341, 70);
            btn_TraerProveedor.Name = "btn_TraerProveedor";
            btn_TraerProveedor.Size = new Size(38, 29);
            btn_TraerProveedor.TabIndex = 138;
            btn_TraerProveedor.UseVisualStyleBackColor = true;
            btn_TraerProveedor.Click += btn_TraerProveedor_Click_1;
            // 
            // btn_traerProduct
            // 
            btn_traerProduct.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btn_traerProduct.IconColor = Color.Black;
            btn_traerProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_traerProduct.IconSize = 20;
            btn_traerProduct.Location = new Point(727, 70);
            btn_traerProduct.Name = "btn_traerProduct";
            btn_traerProduct.Size = new Size(38, 27);
            btn_traerProduct.TabIndex = 139;
            btn_traerProduct.UseVisualStyleBackColor = true;
            btn_traerProduct.Click += btn_traerProduct_Click;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.WhiteSmoke;
            iconPictureBox5.ForeColor = SystemColors.ControlText;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            iconPictureBox5.IconColor = SystemColors.ControlText;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 27;
            iconPictureBox5.Location = new Point(3, 66);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(31, 27);
            iconPictureBox5.TabIndex = 140;
            iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.WhiteSmoke;
            iconPictureBox6.ForeColor = SystemColors.ControlText;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Percentage;
            iconPictureBox6.IconColor = SystemColors.ControlText;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 27;
            iconPictureBox6.Location = new Point(280, 65);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(31, 27);
            iconPictureBox6.TabIndex = 141;
            iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = Color.WhiteSmoke;
            iconPictureBox7.ForeColor = SystemColors.ControlText;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            iconPictureBox7.IconColor = SystemColors.ControlText;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 27;
            iconPictureBox7.Location = new Point(130, 66);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(31, 27);
            iconPictureBox7.TabIndex = 142;
            iconPictureBox7.TabStop = false;
            // 
            // btn_añadir
            // 
            btn_añadir.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btn_añadir.IconColor = Color.Black;
            btn_añadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_añadir.IconSize = 35;
            btn_añadir.ImageAlign = ContentAlignment.MiddleRight;
            btn_añadir.Location = new Point(587, 44);
            btn_añadir.Name = "btn_añadir";
            btn_añadir.Size = new Size(166, 49);
            btn_añadir.TabIndex = 143;
            btn_añadir.Text = "Agregar al carrito";
            btn_añadir.TextAlign = ContentAlignment.MiddleLeft;
            btn_añadir.UseVisualStyleBackColor = true;
            btn_añadir.Click += btn_añadir_Click;
            // 
            // btn_confirmar
            // 
            btn_confirmar.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_confirmar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btn_confirmar.IconColor = Color.Black;
            btn_confirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_confirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_confirmar.Location = new Point(663, 543);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(113, 45);
            btn_confirmar.TabIndex = 144;
            btn_confirmar.Text = "Guardar ";
            btn_confirmar.TextAlign = ContentAlignment.MiddleRight;
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Visible = false;
            btn_confirmar.Click += btn_confirmar_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(11, 9);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(165, 19);
            label8.TabIndex = 145;
            label8.Text = "DETALLES DE VALOR";
            // 
            // pnl_detalle
            // 
            pnl_detalle.Controls.Add(label8);
            pnl_detalle.Controls.Add(label5);
            pnl_detalle.Controls.Add(btn_añadir);
            pnl_detalle.Controls.Add(txt_precio);
            pnl_detalle.Controls.Add(label6);
            pnl_detalle.Controls.Add(iconPictureBox7);
            pnl_detalle.Controls.Add(nud_cantidad);
            pnl_detalle.Controls.Add(iconPictureBox6);
            pnl_detalle.Controls.Add(label7);
            pnl_detalle.Controls.Add(iconPictureBox5);
            pnl_detalle.Controls.Add(nud_ganancia);
            pnl_detalle.Location = new Point(12, 115);
            pnl_detalle.Name = "pnl_detalle";
            pnl_detalle.Size = new Size(763, 110);
            pnl_detalle.TabIndex = 146;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salir.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            btn_salir.IconColor = Color.Black;
            btn_salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_salir.IconSize = 25;
            btn_salir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salir.Location = new Point(12, 543);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(115, 46);
            btn_salir.TabIndex = 150;
            btn_salir.Text = "Salir";
            btn_salir.TextAlign = ContentAlignment.MiddleRight;
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 9);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(227, 19);
            label9.TabIndex = 189;
            label9.Text = "SELECCIONE EL PROVEEDOR:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(397, 9);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(220, 19);
            label10.TabIndex = 190;
            label10.Text = "SELECCIONE EL PRODUCTO:";
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
            Column2.HeaderText = "Precio";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Cantidad";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ganancia";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Entrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 601);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btn_salir);
            Controls.Add(btn_confirmar);
            Controls.Add(pnl_detalle);
            Controls.Add(btn_traerProduct);
            Controls.Add(btn_TraerProveedor);
            Controls.Add(iconPictureBox4);
            Controls.Add(iconPictureBox1);
            Controls.Add(dgvCarrito);
            Controls.Add(txt_nombreProducto);
            Controls.Add(label3);
            Controls.Add(txt_idproducto);
            Controls.Add(label4);
            Controls.Add(txt_provNombre);
            Controls.Add(label2);
            Controls.Add(txt_cuit);
            Controls.Add(label1);
            Name = "Entrada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada";
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_ganancia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            pnl_detalle.ResumeLayout(false);
            pnl_detalle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_provNombre;
        private Label label2;
        private TextBox txt_cuit;
        private Label label1;
        private Button btn_TraerProducto;
        private TextBox txt_nombreProducto;
        private Label label3;
        private TextBox txt_idproducto;
        private Label label4;
        private TextBox txt_precio;
        private Label label5;
        private Label label6;
        private NumericUpDown nud_cantidad;
        private Label label7;
        private NumericUpDown nud_ganancia;
        private DataGridView dgvCarrito;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconButton btn_TraerProveedor;
        private FontAwesome.Sharp.IconButton btn_traerProduct;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private FontAwesome.Sharp.IconButton btn_añadir;
        private FontAwesome.Sharp.IconButton btn_confirmar;
        private Label label8;
        private Panel pnl_detalle;
        private FontAwesome.Sharp.IconButton btn_salir;
        private Label label9;
        private Label label10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
    }
}