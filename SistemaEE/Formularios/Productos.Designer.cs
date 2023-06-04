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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            dgvProductos = new DataGridView();
            Column0 = new DataGridViewTextBoxColumn();
            btn_seleccionar = new DataGridViewButtonColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txt_nombre = new MaterialSkin.Controls.MaterialTextBox();
            txt_marca = new MaterialSkin.Controls.MaterialTextBox();
            txt_prov = new MaterialSkin.Controls.MaterialTextBox();
            iconPictureBox13 = new FontAwesome.Sharp.IconPictureBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            btn_agregar = new MaterialSkin.Controls.MaterialButton();
            btn_eliminar = new MaterialSkin.Controls.MaterialButton();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            btn_editar = new MaterialSkin.Controls.MaterialButton();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            txt_categoria = new MaterialSkin.Controls.MaterialTextBox();
            pnl_detalle = new Panel();
            btn_traerProv = new MaterialSkin.Controls.MaterialButton();
            panel1 = new Panel();
            txt_filtrar = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btn_limpiar = new MaterialSkin.Controls.MaterialButton();
            btn_cargaMasiva = new MaterialSkin.Controls.MaterialButton();
            btn_descargaPlantilla = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            pnl_detalle.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
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
            dgvProductos.Location = new Point(370, 127);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(663, 394);
            dgvProductos.TabIndex = 103;
            dgvProductos.CellClick += Cell_Click;
            // 
            // Column0
            // 
            Column0.HeaderText = "Codigo";
            Column0.Name = "Column0";
            Column0.ReadOnly = true;
            Column0.Visible = false;
            Column0.Width = 69;
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.HeaderText = "";
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.ReadOnly = true;
            btn_seleccionar.Resizable = DataGridViewTriState.False;
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
            // txt_nombre
            // 
            txt_nombre.AnimateReadOnly = false;
            txt_nombre.BorderStyle = BorderStyle.None;
            txt_nombre.Depth = 0;
            txt_nombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_nombre.LeadingIcon = null;
            txt_nombre.Location = new Point(58, 37);
            txt_nombre.MaxLength = 50;
            txt_nombre.MouseState = MaterialSkin.MouseState.OUT;
            txt_nombre.Multiline = false;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(295, 50);
            txt_nombre.TabIndex = 149;
            txt_nombre.Text = "";
            txt_nombre.TrailingIcon = null;
            // 
            // txt_marca
            // 
            txt_marca.AnimateReadOnly = false;
            txt_marca.BorderStyle = BorderStyle.None;
            txt_marca.Depth = 0;
            txt_marca.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_marca.LeadingIcon = null;
            txt_marca.Location = new Point(59, 192);
            txt_marca.MaxLength = 50;
            txt_marca.MouseState = MaterialSkin.MouseState.OUT;
            txt_marca.Multiline = false;
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(295, 50);
            txt_marca.TabIndex = 148;
            txt_marca.Text = "";
            txt_marca.TrailingIcon = null;
            // 
            // txt_prov
            // 
            txt_prov.AnimateReadOnly = false;
            txt_prov.BorderStyle = BorderStyle.None;
            txt_prov.Depth = 0;
            txt_prov.Enabled = false;
            txt_prov.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_prov.LeadingIcon = null;
            txt_prov.Location = new Point(59, 271);
            txt_prov.MaxLength = 50;
            txt_prov.MouseState = MaterialSkin.MouseState.OUT;
            txt_prov.Multiline = false;
            txt_prov.Name = "txt_prov";
            txt_prov.Size = new Size(182, 50);
            txt_prov.TabIndex = 147;
            txt_prov.Text = "";
            txt_prov.TrailingIcon = null;
            // 
            // iconPictureBox13
            // 
            iconPictureBox13.BackColor = Color.WhiteSmoke;
            iconPictureBox13.ForeColor = Color.SteelBlue;
            iconPictureBox13.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox13.IconColor = Color.SteelBlue;
            iconPictureBox13.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox13.IconSize = 48;
            iconPictureBox13.Location = new Point(7, 274);
            iconPictureBox13.Name = "iconPictureBox13";
            iconPictureBox13.Size = new Size(48, 50);
            iconPictureBox13.TabIndex = 140;
            iconPictureBox13.TabStop = false;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(59, 9);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(70, 19);
            materialLabel3.TabIndex = 159;
            materialLabel3.Text = "NOMBRE:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(64, 89);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(90, 19);
            materialLabel4.TabIndex = 160;
            materialLabel4.Text = "CATEGORÍA:";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(59, 170);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(59, 19);
            materialLabel5.TabIndex = 161;
            materialLabel5.Text = "MARCA:";
            // 
            // btn_agregar
            // 
            btn_agregar.AutoSize = false;
            btn_agregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_agregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_agregar.Depth = 0;
            btn_agregar.HighEmphasis = true;
            btn_agregar.Icon = (Image)resources.GetObject("btn_agregar.Icon");
            btn_agregar.Location = new Point(7, 575);
            btn_agregar.Margin = new Padding(4, 6, 4, 6);
            btn_agregar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_agregar.Name = "btn_agregar";
            btn_agregar.NoAccentTextColor = Color.Empty;
            btn_agregar.Size = new Size(113, 36);
            btn_agregar.TabIndex = 152;
            btn_agregar.Text = "Agregar";
            btn_agregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_agregar.UseAccentColor = false;
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.AutoSize = false;
            btn_eliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_eliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_eliminar.Depth = 0;
            btn_eliminar.HighEmphasis = true;
            btn_eliminar.Icon = (Image)resources.GetObject("btn_eliminar.Icon");
            btn_eliminar.Location = new Point(249, 575);
            btn_eliminar.Margin = new Padding(4, 6, 4, 6);
            btn_eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.NoAccentTextColor = Color.Empty;
            btn_eliminar.Size = new Size(113, 36);
            btn_eliminar.TabIndex = 154;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_eliminar.UseAccentColor = false;
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(58, 249);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(96, 19);
            materialLabel6.TabIndex = 162;
            materialLabel6.Text = "PROVEEDOR:";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.WhiteSmoke;
            iconPictureBox3.ForeColor = Color.SteelBlue;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Tag;
            iconPictureBox3.IconColor = Color.SteelBlue;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 48;
            iconPictureBox3.Location = new Point(7, 37);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(48, 50);
            iconPictureBox3.TabIndex = 115;
            iconPictureBox3.TabStop = false;
            // 
            // btn_editar
            // 
            btn_editar.AutoSize = false;
            btn_editar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_editar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_editar.Depth = 0;
            btn_editar.HighEmphasis = true;
            btn_editar.Icon = (Image)resources.GetObject("btn_editar.Icon");
            btn_editar.Location = new Point(128, 575);
            btn_editar.Margin = new Padding(4, 6, 4, 6);
            btn_editar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_editar.Name = "btn_editar";
            btn_editar.NoAccentTextColor = Color.Empty;
            btn_editar.Size = new Size(113, 36);
            btn_editar.TabIndex = 158;
            btn_editar.Text = "Editar";
            btn_editar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_editar.UseAccentColor = false;
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.WhiteSmoke;
            iconPictureBox4.ForeColor = Color.SteelBlue;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Tags;
            iconPictureBox4.IconColor = Color.SteelBlue;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 48;
            iconPictureBox4.Location = new Point(7, 116);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(48, 50);
            iconPictureBox4.TabIndex = 116;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.WhiteSmoke;
            iconPictureBox2.ForeColor = Color.SteelBlue;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Tags;
            iconPictureBox2.IconColor = Color.SteelBlue;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 46;
            iconPictureBox2.Location = new Point(7, 201);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(46, 50);
            iconPictureBox2.TabIndex = 113;
            iconPictureBox2.TabStop = false;
            // 
            // txt_categoria
            // 
            txt_categoria.AnimateReadOnly = false;
            txt_categoria.BorderStyle = BorderStyle.None;
            txt_categoria.Depth = 0;
            txt_categoria.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_categoria.LeadingIcon = null;
            txt_categoria.Location = new Point(58, 116);
            txt_categoria.MaxLength = 50;
            txt_categoria.MouseState = MaterialSkin.MouseState.OUT;
            txt_categoria.Multiline = false;
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(295, 50);
            txt_categoria.TabIndex = 145;
            txt_categoria.Text = "";
            txt_categoria.TrailingIcon = null;
            // 
            // pnl_detalle
            // 
            pnl_detalle.Controls.Add(btn_traerProv);
            pnl_detalle.Controls.Add(txt_categoria);
            pnl_detalle.Controls.Add(iconPictureBox2);
            pnl_detalle.Controls.Add(iconPictureBox4);
            pnl_detalle.Controls.Add(iconPictureBox3);
            pnl_detalle.Controls.Add(materialLabel6);
            pnl_detalle.Controls.Add(materialLabel5);
            pnl_detalle.Controls.Add(materialLabel4);
            pnl_detalle.Controls.Add(materialLabel3);
            pnl_detalle.Controls.Add(iconPictureBox13);
            pnl_detalle.Controls.Add(txt_prov);
            pnl_detalle.Controls.Add(txt_marca);
            pnl_detalle.Controls.Add(txt_nombre);
            pnl_detalle.Location = new Point(2, 127);
            pnl_detalle.Name = "pnl_detalle";
            pnl_detalle.Size = new Size(360, 394);
            pnl_detalle.TabIndex = 165;
            // 
            // btn_traerProv
            // 
            btn_traerProv.AutoSize = false;
            btn_traerProv.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_traerProv.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_traerProv.Depth = 0;
            btn_traerProv.HighEmphasis = true;
            btn_traerProv.Icon = (Image)resources.GetObject("btn_traerProv.Icon");
            btn_traerProv.Location = new Point(248, 271);
            btn_traerProv.Margin = new Padding(4, 6, 4, 6);
            btn_traerProv.MouseState = MaterialSkin.MouseState.HOVER;
            btn_traerProv.Name = "btn_traerProv";
            btn_traerProv.NoAccentTextColor = Color.Empty;
            btn_traerProv.Size = new Size(105, 50);
            btn_traerProv.TabIndex = 203;
            btn_traerProv.Text = "BUSCAR";
            btn_traerProv.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_traerProv.UseAccentColor = false;
            btn_traerProv.UseVisualStyleBackColor = true;
            btn_traerProv.Click += btn_traerProv_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_filtrar);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(10, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(1023, 54);
            panel1.TabIndex = 166;
            // 
            // txt_filtrar
            // 
            txt_filtrar.AnimateReadOnly = false;
            txt_filtrar.BorderStyle = BorderStyle.None;
            txt_filtrar.Depth = 0;
            txt_filtrar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_filtrar.LeadingIcon = null;
            txt_filtrar.Location = new Point(645, 3);
            txt_filtrar.MaxLength = 50;
            txt_filtrar.MouseState = MaterialSkin.MouseState.OUT;
            txt_filtrar.Multiline = false;
            txt_filtrar.Name = "txt_filtrar";
            txt_filtrar.Size = new Size(316, 50);
            txt_filtrar.TabIndex = 152;
            txt_filtrar.Text = "";
            txt_filtrar.TrailingIcon = null;
            txt_filtrar.TextChanged += txt_filtrar_TextChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 5);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(188, 19);
            materialLabel1.TabIndex = 150;
            materialLabel1.Text = "DETALLE DEL PRODUCTO";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(375, 5);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(165, 19);
            materialLabel2.TabIndex = 151;
            materialLabel2.Text = "LISTA DE PRODUCTOS";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox1.IconColor = Color.SteelBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 46;
            iconPictureBox1.Location = new Point(967, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(53, 46);
            iconPictureBox1.TabIndex = 141;
            iconPictureBox1.TabStop = false;
            // 
            // btn_limpiar
            // 
            btn_limpiar.AutoSize = false;
            btn_limpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_limpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_limpiar.Depth = 0;
            btn_limpiar.HighEmphasis = true;
            btn_limpiar.Icon = (Image)resources.GetObject("btn_limpiar.Icon");
            btn_limpiar.Location = new Point(370, 575);
            btn_limpiar.Margin = new Padding(4, 6, 4, 6);
            btn_limpiar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.NoAccentTextColor = Color.Empty;
            btn_limpiar.Size = new Size(113, 36);
            btn_limpiar.TabIndex = 181;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_limpiar.UseAccentColor = false;
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_cargaMasiva
            // 
            btn_cargaMasiva.AutoSize = false;
            btn_cargaMasiva.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_cargaMasiva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_cargaMasiva.Depth = 0;
            btn_cargaMasiva.Enabled = false;
            btn_cargaMasiva.HighEmphasis = true;
            btn_cargaMasiva.Icon = (Image)resources.GetObject("btn_cargaMasiva.Icon");
            btn_cargaMasiva.Location = new Point(890, 575);
            btn_cargaMasiva.Margin = new Padding(4, 6, 4, 6);
            btn_cargaMasiva.MouseState = MaterialSkin.MouseState.HOVER;
            btn_cargaMasiva.Name = "btn_cargaMasiva";
            btn_cargaMasiva.NoAccentTextColor = Color.Empty;
            btn_cargaMasiva.Size = new Size(147, 36);
            btn_cargaMasiva.TabIndex = 179;
            btn_cargaMasiva.Text = "Carga masiva";
            btn_cargaMasiva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_cargaMasiva.UseAccentColor = false;
            btn_cargaMasiva.UseVisualStyleBackColor = true;
            // 
            // btn_descargaPlantilla
            // 
            btn_descargaPlantilla.AutoSize = false;
            btn_descargaPlantilla.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_descargaPlantilla.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_descargaPlantilla.Depth = 0;
            btn_descargaPlantilla.Enabled = false;
            btn_descargaPlantilla.HighEmphasis = true;
            btn_descargaPlantilla.Icon = (Image)resources.GetObject("btn_descargaPlantilla.Icon");
            btn_descargaPlantilla.Location = new Point(666, 575);
            btn_descargaPlantilla.Margin = new Padding(4, 6, 4, 6);
            btn_descargaPlantilla.MouseState = MaterialSkin.MouseState.HOVER;
            btn_descargaPlantilla.Name = "btn_descargaPlantilla";
            btn_descargaPlantilla.NoAccentTextColor = Color.Empty;
            btn_descargaPlantilla.Size = new Size(211, 36);
            btn_descargaPlantilla.TabIndex = 180;
            btn_descargaPlantilla.Text = "Descargar plantilla";
            btn_descargaPlantilla.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_descargaPlantilla.UseAccentColor = false;
            btn_descargaPlantilla.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1046, 620);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_cargaMasiva);
            Controls.Add(btn_descargaPlantilla);
            Controls.Add(panel1);
            Controls.Add(pnl_detalle);
            Controls.Add(dgvProductos);
            Controls.Add(btn_agregar);
            Controls.Add(btn_editar);
            Controls.Add(btn_eliminar);
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Productos :.";
            FormClosed += Productos_FormClosed;
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            pnl_detalle.ResumeLayout(false);
            pnl_detalle.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewButtonColumn btn_seleccionar;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre;
        private MaterialSkin.Controls.MaterialTextBox txt_marca;
        private MaterialSkin.Controls.MaterialTextBox txt_prov;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox13;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btn_agregar;
        private MaterialSkin.Controls.MaterialButton btn_eliminar;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private MaterialSkin.Controls.MaterialButton btn_editar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private MaterialSkin.Controls.MaterialTextBox txt_categoria;
        private Panel pnl_detalle;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txt_filtrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MaterialSkin.Controls.MaterialButton btn_traerProv;
        private MaterialSkin.Controls.MaterialButton btn_limpiar;
        private MaterialSkin.Controls.MaterialButton btn_cargaMasiva;
        private MaterialSkin.Controls.MaterialButton btn_descargaPlantilla;
    }
}