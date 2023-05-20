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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            txt_filtrarGrilla = new TextBox();
            txt_prov = new TextBox();
            label4 = new Label();
            btn_buscarProv = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            btn_salir = new FontAwesome.Sharp.IconButton();
            btn_baja = new FontAwesome.Sharp.IconButton();
            btn_alta = new FontAwesome.Sharp.IconButton();
            btn_modi = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 71);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(49, 92);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(216, 27);
            txt_nombre.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 9);
            label5.Name = "label5";
            label5.Size = new Size(165, 19);
            label5.TabIndex = 5;
            label5.Text = "DETALLE PRODUCTO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(307, 9);
            label6.Name = "label6";
            label6.Size = new Size(177, 19);
            label6.TabIndex = 6;
            label6.Text = "LISTA DE PRODUCTOS";
            // 
            // txt_categoria
            // 
            txt_categoria.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_categoria.Location = new Point(49, 147);
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(216, 27);
            txt_categoria.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 124);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 7;
            label2.Text = "Categoria:";
            // 
            // txt_marca
            // 
            txt_marca.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_marca.Location = new Point(49, 201);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(216, 27);
            txt_marca.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 179);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 9;
            label3.Text = "Marca:";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Column0, btn_seleccionar, Column2, Column3, Column4 });
            dgvProductos.Location = new Point(308, 92);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(727, 489);
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
            btn_seleccionar.Text = "";
            btn_seleccionar.Width = 25;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 95;
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoría";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 105;
            // 
            // Column4
            // 
            Column4.HeaderText = "Marca";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 79;
            // 
            // txt_filtrarGrilla
            // 
            txt_filtrarGrilla.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_filtrarGrilla.Location = new Point(668, 50);
            txt_filtrarGrilla.Name = "txt_filtrarGrilla";
            txt_filtrarGrilla.Size = new Size(318, 36);
            txt_filtrarGrilla.TabIndex = 107;
            txt_filtrarGrilla.TextChanged += txt_filtrarGrilla_TextChanged;
            // 
            // txt_prov
            // 
            txt_prov.Enabled = false;
            txt_prov.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_prov.Location = new Point(49, 256);
            txt_prov.Name = "txt_prov";
            txt_prov.Size = new Size(172, 27);
            txt_prov.TabIndex = 109;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 234);
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
            btn_buscarProv.Location = new Point(225, 256);
            btn_buscarProv.Name = "btn_buscarProv";
            btn_buscarProv.Size = new Size(38, 28);
            btn_buscarProv.TabIndex = 110;
            btn_buscarProv.UseVisualStyleBackColor = true;
            btn_buscarProv.Click += btn_buscarProv_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 27;
            iconPictureBox1.Location = new Point(17, 255);
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
            iconPictureBox2.Location = new Point(17, 201);
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
            iconPictureBox3.Location = new Point(17, 92);
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
            iconPictureBox4.Location = new Point(17, 147);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(31, 27);
            iconPictureBox4.TabIndex = 116;
            iconPictureBox4.TabStop = false;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salir.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            btn_salir.IconColor = Color.Black;
            btn_salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_salir.IconSize = 25;
            btn_salir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salir.Location = new Point(19, 547);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(118, 42);
            btn_salir.TabIndex = 149;
            btn_salir.Text = "Salir";
            btn_salir.TextAlign = ContentAlignment.MiddleRight;
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click_1;
            // 
            // btn_baja
            // 
            btn_baja.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_baja.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            btn_baja.IconColor = Color.Black;
            btn_baja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_baja.ImageAlign = ContentAlignment.MiddleLeft;
            btn_baja.Location = new Point(18, 421);
            btn_baja.Name = "btn_baja";
            btn_baja.Size = new Size(248, 55);
            btn_baja.TabIndex = 148;
            btn_baja.Text = "Eliminar";
            btn_baja.TextAlign = ContentAlignment.MiddleRight;
            btn_baja.UseVisualStyleBackColor = true;
            btn_baja.Click += btn_baja_Click_1;
            // 
            // btn_alta
            // 
            btn_alta.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_alta.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btn_alta.IconColor = Color.Black;
            btn_alta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_alta.ImageAlign = ContentAlignment.MiddleLeft;
            btn_alta.Location = new Point(18, 360);
            btn_alta.Name = "btn_alta";
            btn_alta.Size = new Size(248, 55);
            btn_alta.TabIndex = 147;
            btn_alta.Text = "Agregar";
            btn_alta.TextAlign = ContentAlignment.MiddleRight;
            btn_alta.UseVisualStyleBackColor = true;
            btn_alta.Click += btn_alta_Click_1;
            // 
            // btn_modi
            // 
            btn_modi.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_modi.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btn_modi.IconColor = Color.Black;
            btn_modi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_modi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_modi.Location = new Point(18, 482);
            btn_modi.Name = "btn_modi";
            btn_modi.Size = new Size(248, 55);
            btn_modi.TabIndex = 146;
            btn_modi.Text = "Modificar";
            btn_modi.TextAlign = ContentAlignment.MiddleRight;
            btn_modi.UseVisualStyleBackColor = true;
            btn_modi.Click += btn_modi_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(273, 9);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(27, 579);
            groupBox1.TabIndex = 150;
            groupBox1.TabStop = false;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.WhiteSmoke;
            iconPictureBox5.ForeColor = SystemColors.ControlText;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox5.IconColor = SystemColors.ControlText;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 36;
            iconPictureBox5.Location = new Point(992, 50);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(42, 36);
            iconPictureBox5.TabIndex = 151;
            iconPictureBox5.TabStop = false;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1046, 601);
            ControlBox = false;
            Controls.Add(iconPictureBox5);
            Controls.Add(groupBox1);
            Controls.Add(btn_salir);
            Controls.Add(btn_baja);
            Controls.Add(btn_alta);
            Controls.Add(btn_modi);
            Controls.Add(iconPictureBox4);
            Controls.Add(iconPictureBox3);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox1);
            Controls.Add(btn_buscarProv);
            Controls.Add(txt_prov);
            Controls.Add(label4);
            Controls.Add(dgvProductos);
            Controls.Add(txt_filtrarGrilla);
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
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
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
        private TextBox txt_filtrarGrilla;
        private TextBox txt_prov;
        private Label label4;
        private FontAwesome.Sharp.IconButton btn_buscarProv;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewButtonColumn btn_seleccionar;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private FontAwesome.Sharp.IconButton btn_salir;
        private FontAwesome.Sharp.IconButton btn_baja;
        private FontAwesome.Sharp.IconButton btn_alta;
        private FontAwesome.Sharp.IconButton btn_modi;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
    }
}