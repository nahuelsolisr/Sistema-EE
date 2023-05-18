namespace SistemaEE.Formularios
{
    partial class Productos
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            txt_nombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txt_categoria = new TextBox();
            label2 = new Label();
            txt_marca = new TextBox();
            label3 = new Label();
            dgvProductos = new DataGridView();
            Column0 = new DataGridViewTextBoxColumn();
            btn_seleccionar = new DataGridViewButtonColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btn_Alta = new Button();
            btn_Modificacion = new Button();
            btn_baja = new Button();
            groupBox1 = new GroupBox();
            btn_salir = new Button();
            textBox9 = new TextBox();
            txt_prov = new TextBox();
            label4 = new Label();
            btn_buscarProv = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 46);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(39, 68);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(190, 27);
            txt_nombre.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 9);
            label5.Name = "label5";
            label5.Size = new Size(165, 19);
            label5.TabIndex = 5;
            label5.Text = "DETALLE PRODUCTO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(251, 9);
            label6.Name = "label6";
            label6.Size = new Size(177, 19);
            label6.TabIndex = 6;
            label6.Text = "LISTA DE PRODUCTOS";
            // 
            // txt_categoria
            // 
            txt_categoria.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_categoria.Location = new Point(39, 122);
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(190, 27);
            txt_categoria.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 100);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 7;
            label2.Text = "Categoria:";
            // 
            // txt_marca
            // 
            txt_marca.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_marca.Location = new Point(39, 176);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(190, 27);
            txt_marca.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 154);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 9;
            label3.Text = "Marca:";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Column0, btn_seleccionar, Column2, Column3, Column4 });
            dgvProductos.Location = new Point(251, 94);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = Color.Transparent;
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(539, 338);
            dgvProductos.TabIndex = 103;
            dgvProductos.CellClick += Cell_Click;
            // 
            // Column0
            // 
            Column0.HeaderText = "Codigo";
            Column0.Name = "Column0";
            Column0.ReadOnly = true;
            Column0.Visible = false;
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.HeaderText = "";
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.ReadOnly = true;
            btn_seleccionar.Resizable = DataGridViewTriState.False;
            btn_seleccionar.Width = 35;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoría";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Marca";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // btn_Alta
            // 
            btn_Alta.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Alta.Location = new Point(17, 300);
            btn_Alta.Name = "btn_Alta";
            btn_Alta.Size = new Size(66, 26);
            btn_Alta.TabIndex = 14;
            btn_Alta.Text = "A";
            btn_Alta.UseVisualStyleBackColor = true;
            btn_Alta.Click += btn_Alta_Click;
            // 
            // btn_Modificacion
            // 
            btn_Modificacion.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Modificacion.Location = new Point(160, 300);
            btn_Modificacion.Name = "btn_Modificacion";
            btn_Modificacion.Size = new Size(65, 26);
            btn_Modificacion.TabIndex = 15;
            btn_Modificacion.Text = "M";
            btn_Modificacion.UseVisualStyleBackColor = true;
            btn_Modificacion.Click += btn_Modi_Click;
            // 
            // btn_baja
            // 
            btn_baja.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_baja.Location = new Point(89, 300);
            btn_baja.Name = "btn_baja";
            btn_baja.Size = new Size(65, 26);
            btn_baja.TabIndex = 16;
            btn_baja.Text = "B";
            btn_baja.UseVisualStyleBackColor = true;
            btn_baja.Click += btn_Baja_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(235, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(10, 423);
            groupBox1.TabIndex = 104;
            groupBox1.TabStop = false;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Firebrick;
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salir.ForeColor = Color.FromArgb(254, 252, 230);
            btn_salir.Location = new Point(152, 405);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 27);
            btn_salir.TabIndex = 105;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(640, 51);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(96, 27);
            textBox9.TabIndex = 107;
            // 
            // txt_prov
            // 
            txt_prov.Enabled = false;
            txt_prov.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_prov.Location = new Point(39, 233);
            txt_prov.Name = "txt_prov";
            txt_prov.Size = new Size(144, 27);
            txt_prov.TabIndex = 109;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 211);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 108;
            label4.Text = "Proveedor:";
            // 
            // btn_buscarProv
            // 
            btn_buscarProv.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btn_buscarProv.IconColor = Color.Black;
            btn_buscarProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_buscarProv.IconSize = 20;
            btn_buscarProv.Location = new Point(189, 233);
            btn_buscarProv.Name = "btn_buscarProv";
            btn_buscarProv.Size = new Size(38, 27);
            btn_buscarProv.TabIndex = 110;
            btn_buscarProv.UseVisualStyleBackColor = true;
            btn_buscarProv.Click += btn_buscarProv_Click;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(742, 51);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(38, 27);
            iconButton1.TabIndex = 111;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 27;
            iconPictureBox1.Location = new Point(8, 233);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(31, 27);
            iconPictureBox1.TabIndex = 112;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.WhiteSmoke;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Tags;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 27;
            iconPictureBox2.Location = new Point(8, 176);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(31, 27);
            iconPictureBox2.TabIndex = 113;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.WhiteSmoke;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Tag;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 27;
            iconPictureBox3.Location = new Point(8, 68);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(31, 27);
            iconPictureBox3.TabIndex = 115;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.WhiteSmoke;
            iconPictureBox4.ForeColor = SystemColors.ControlText;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Tags;
            iconPictureBox4.IconColor = SystemColors.ControlText;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 27;
            iconPictureBox4.Location = new Point(8, 122);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(31, 27);
            iconPictureBox4.TabIndex = 116;
            iconPictureBox4.TabStop = false;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(802, 444);
            Controls.Add(iconPictureBox4);
            Controls.Add(iconPictureBox3);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox1);
            Controls.Add(iconButton1);
            Controls.Add(btn_buscarProv);
            Controls.Add(txt_prov);
            Controls.Add(label4);
            Controls.Add(dgvProductos);
            Controls.Add(textBox9);
            Controls.Add(btn_salir);
            Controls.Add(groupBox1);
            Controls.Add(btn_baja);
            Controls.Add(btn_Modificacion);
            Controls.Add(btn_Alta);
            Controls.Add(txt_marca);
            Controls.Add(label3);
            Controls.Add(txt_categoria);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Name = "Productos";
            Opacity = 0.96D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_nombre;
        private Label label5;
        private Label label6;
        private TextBox txt_categoria;
        private Label label2;
        private TextBox txt_marca;
        private Label label3;
        private DataGridView dgvProductos;
        private Button btn_Alta;
        private Button btn_Modificacion;
        private Button btn_baja;
        private GroupBox groupBox1;
        private Button btn_salir;
        private TextBox textBox9;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewButtonColumn btn_seleccionar;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox txt_prov;
        private Label label4;
        private FontAwesome.Sharp.IconButton btn_buscarProv;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
    }
}