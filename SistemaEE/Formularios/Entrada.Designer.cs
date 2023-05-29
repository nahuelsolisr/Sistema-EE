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
            dgvCarrito = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            pnl_detalle = new Panel();
            iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            txt_cantidad = new MaterialSkin.Controls.MaterialTextBox();
            txt_precio = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            nud_ganancia = new MaterialSkin.Controls.MaterialSlider();
            btn_agregarCarrito = new MaterialSkin.Controls.MaterialButton();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            txt_nombreProducto = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txt_idproducto = new MaterialSkin.Controls.MaterialTextBox();
            txt_cuit = new MaterialSkin.Controls.MaterialTextBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            txt_provNombre = new MaterialSkin.Controls.MaterialTextBox();
            panel1 = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btn_traerProduc = new MaterialSkin.Controls.MaterialButton();
            btn_traerProv = new MaterialSkin.Controls.MaterialButton();
            iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            btn_ConfirmarCompra = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            pnl_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).BeginInit();
            SuspendLayout();
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
            dgvCarrito.Location = new Point(7, 313);
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
            dgvCarrito.Size = new Size(772, 281);
            dgvCarrito.TabIndex = 133;
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
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.WhiteSmoke;
            iconPictureBox4.ForeColor = Color.SteelBlue;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            iconPictureBox4.IconColor = Color.SteelBlue;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 50;
            iconPictureBox4.Location = new Point(569, 30);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(50, 50);
            iconPictureBox4.TabIndex = 137;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.WhiteSmoke;
            iconPictureBox5.ForeColor = Color.SteelBlue;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            iconPictureBox5.IconColor = Color.SteelBlue;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 48;
            iconPictureBox5.Location = new Point(3, 76);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(48, 50);
            iconPictureBox5.TabIndex = 140;
            iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.WhiteSmoke;
            iconPictureBox6.ForeColor = Color.SteelBlue;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Percentage;
            iconPictureBox6.IconColor = Color.SteelBlue;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 49;
            iconPictureBox6.Location = new Point(489, 78);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(50, 49);
            iconPictureBox6.TabIndex = 141;
            iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = Color.WhiteSmoke;
            iconPictureBox7.ForeColor = Color.SteelBlue;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            iconPictureBox7.IconColor = Color.SteelBlue;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 50;
            iconPictureBox7.Location = new Point(216, 77);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(53, 50);
            iconPictureBox7.TabIndex = 142;
            iconPictureBox7.TabStop = false;
            // 
            // pnl_detalle
            // 
            pnl_detalle.Controls.Add(iconPictureBox8);
            pnl_detalle.Controls.Add(materialLabel8);
            pnl_detalle.Controls.Add(materialLabel7);
            pnl_detalle.Controls.Add(materialLabel6);
            pnl_detalle.Controls.Add(txt_cantidad);
            pnl_detalle.Controls.Add(txt_precio);
            pnl_detalle.Controls.Add(materialLabel5);
            pnl_detalle.Controls.Add(nud_ganancia);
            pnl_detalle.Controls.Add(iconPictureBox7);
            pnl_detalle.Controls.Add(iconPictureBox6);
            pnl_detalle.Controls.Add(iconPictureBox5);
            pnl_detalle.Controls.Add(btn_agregarCarrito);
            pnl_detalle.Location = new Point(6, 169);
            pnl_detalle.Name = "pnl_detalle";
            pnl_detalle.Size = new Size(1113, 137);
            pnl_detalle.TabIndex = 146;
            // 
            // iconPictureBox8
            // 
            iconPictureBox8.BackColor = Color.WhiteSmoke;
            iconPictureBox8.ForeColor = Color.SteelBlue;
            iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            iconPictureBox8.IconColor = Color.SteelBlue;
            iconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox8.IconSize = 53;
            iconPictureBox8.Location = new Point(782, 74);
            iconPictureBox8.Name = "iconPictureBox8";
            iconPictureBox8.Size = new Size(59, 53);
            iconPictureBox8.TabIndex = 208;
            iconPictureBox8.TabStop = false;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(272, 54);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(82, 19);
            materialLabel8.TabIndex = 207;
            materialLabel8.Text = "CANTIDAD:";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(54, 55);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(59, 19);
            materialLabel7.TabIndex = 206;
            materialLabel7.Text = "PRECIO:";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(17, 11);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(146, 19);
            materialLabel6.TabIndex = 206;
            materialLabel6.Text = "DETALLE DE VALOR";
            // 
            // txt_cantidad
            // 
            txt_cantidad.AnimateReadOnly = false;
            txt_cantidad.BorderStyle = BorderStyle.None;
            txt_cantidad.Depth = 0;
            txt_cantidad.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_cantidad.LeadingIcon = null;
            txt_cantidad.Location = new Point(270, 77);
            txt_cantidad.MaxLength = 50;
            txt_cantidad.MouseState = MaterialSkin.MouseState.OUT;
            txt_cantidad.Multiline = false;
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(159, 50);
            txt_cantidad.TabIndex = 203;
            txt_cantidad.Text = "";
            txt_cantidad.TrailingIcon = null;
            // 
            // txt_precio
            // 
            txt_precio.AnimateReadOnly = false;
            txt_precio.BorderStyle = BorderStyle.None;
            txt_precio.Depth = 0;
            txt_precio.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_precio.LeadingIcon = null;
            txt_precio.Location = new Point(53, 77);
            txt_precio.MaxLength = 50;
            txt_precio.MouseState = MaterialSkin.MouseState.OUT;
            txt_precio.Multiline = false;
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(157, 50);
            txt_precio.TabIndex = 202;
            txt_precio.Text = "";
            txt_precio.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(545, 55);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(82, 19);
            materialLabel5.TabIndex = 201;
            materialLabel5.Text = "GANANCIA:";
            // 
            // nud_ganancia
            // 
            nud_ganancia.Depth = 0;
            nud_ganancia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            nud_ganancia.Location = new Point(545, 84);
            nud_ganancia.MouseState = MaterialSkin.MouseState.HOVER;
            nud_ganancia.Name = "nud_ganancia";
            nud_ganancia.Size = new Size(210, 40);
            nud_ganancia.TabIndex = 146;
            nud_ganancia.Text = "";
            nud_ganancia.Value = 25;
            nud_ganancia.ValueMax = 100;
            // 
            // btn_agregarCarrito
            // 
            btn_agregarCarrito.AutoSize = false;
            btn_agregarCarrito.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_agregarCarrito.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_agregarCarrito.Depth = 0;
            btn_agregarCarrito.HighEmphasis = true;
            btn_agregarCarrito.Icon = null;
            btn_agregarCarrito.Location = new Point(821, 74);
            btn_agregarCarrito.Margin = new Padding(4, 6, 4, 6);
            btn_agregarCarrito.MouseState = MaterialSkin.MouseState.HOVER;
            btn_agregarCarrito.Name = "btn_agregarCarrito";
            btn_agregarCarrito.NoAccentTextColor = Color.Empty;
            btn_agregarCarrito.Size = new Size(280, 50);
            btn_agregarCarrito.TabIndex = 209;
            btn_agregarCarrito.Text = "AGREGAR AL CARRITO";
            btn_agregarCarrito.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_agregarCarrito.UseAccentColor = false;
            btn_agregarCarrito.UseVisualStyleBackColor = true;
            btn_agregarCarrito.Click += btn_agregarCarrito_Click;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(782, 8);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(69, 19);
            materialLabel3.TabIndex = 192;
            materialLabel3.Text = "Producto:";
            // 
            // txt_nombreProducto
            // 
            txt_nombreProducto.AnimateReadOnly = false;
            txt_nombreProducto.BorderStyle = BorderStyle.None;
            txt_nombreProducto.Depth = 0;
            txt_nombreProducto.Enabled = false;
            txt_nombreProducto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_nombreProducto.LeadingIcon = null;
            txt_nombreProducto.Location = new Point(782, 30);
            txt_nombreProducto.MaxLength = 50;
            txt_nombreProducto.MouseState = MaterialSkin.MouseState.OUT;
            txt_nombreProducto.Multiline = false;
            txt_nombreProducto.Name = "txt_nombreProducto";
            txt_nombreProducto.Size = new Size(153, 50);
            txt_nombreProducto.TabIndex = 191;
            txt_nombreProducto.Text = "";
            txt_nombreProducto.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(620, 8);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(14, 19);
            materialLabel1.TabIndex = 194;
            materialLabel1.Text = "Id";
            // 
            // txt_idproducto
            // 
            txt_idproducto.AnimateReadOnly = false;
            txt_idproducto.BorderStyle = BorderStyle.None;
            txt_idproducto.Depth = 0;
            txt_idproducto.Enabled = false;
            txt_idproducto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_idproducto.LeadingIcon = null;
            txt_idproducto.Location = new Point(620, 30);
            txt_idproducto.MaxLength = 50;
            txt_idproducto.MouseState = MaterialSkin.MouseState.OUT;
            txt_idproducto.Multiline = false;
            txt_idproducto.Name = "txt_idproducto";
            txt_idproducto.Size = new Size(153, 50);
            txt_idproducto.TabIndex = 193;
            txt_idproducto.Text = "";
            txt_idproducto.TrailingIcon = null;
            // 
            // txt_cuit
            // 
            txt_cuit.AnimateReadOnly = false;
            txt_cuit.BorderStyle = BorderStyle.None;
            txt_cuit.Depth = 0;
            txt_cuit.Enabled = false;
            txt_cuit.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_cuit.LeadingIcon = null;
            txt_cuit.Location = new Point(57, 30);
            txt_cuit.MaxLength = 50;
            txt_cuit.MouseState = MaterialSkin.MouseState.OUT;
            txt_cuit.Multiline = false;
            txt_cuit.Name = "txt_cuit";
            txt_cuit.Size = new Size(153, 50);
            txt_cuit.TabIndex = 197;
            txt_cuit.Text = "";
            txt_cuit.TrailingIcon = null;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.WhiteSmoke;
            iconPictureBox3.ForeColor = Color.SteelBlue;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconPictureBox3.IconColor = Color.SteelBlue;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 48;
            iconPictureBox3.Location = new Point(8, 31);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(48, 52);
            iconPictureBox3.TabIndex = 195;
            iconPictureBox3.TabStop = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(216, 9);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(70, 19);
            materialLabel4.TabIndex = 200;
            materialLabel4.Text = "NOMBRE:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(57, 9);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(39, 19);
            materialLabel2.TabIndex = 199;
            materialLabel2.Text = "CUIT:";
            // 
            // txt_provNombre
            // 
            txt_provNombre.AnimateReadOnly = false;
            txt_provNombre.BorderStyle = BorderStyle.None;
            txt_provNombre.Depth = 0;
            txt_provNombre.Enabled = false;
            txt_provNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_provNombre.LeadingIcon = null;
            txt_provNombre.Location = new Point(216, 31);
            txt_provNombre.MaxLength = 50;
            txt_provNombre.MouseState = MaterialSkin.MouseState.OUT;
            txt_provNombre.Multiline = false;
            txt_provNombre.Name = "txt_provNombre";
            txt_provNombre.Size = new Size(153, 50);
            txt_provNombre.TabIndex = 198;
            txt_provNombre.Text = "";
            txt_provNombre.TrailingIcon = null;
            // 
            // panel1
            // 
            panel1.Controls.Add(iconPictureBox2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(btn_traerProduc);
            panel1.Controls.Add(btn_traerProv);
            panel1.Controls.Add(iconPictureBox3);
            panel1.Controls.Add(txt_cuit);
            panel1.Controls.Add(iconPictureBox4);
            panel1.Controls.Add(materialLabel4);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(txt_nombreProducto);
            panel1.Controls.Add(txt_provNombre);
            panel1.Controls.Add(materialLabel3);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(txt_idproducto);
            panel1.Location = new Point(6, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 96);
            panel1.TabIndex = 201;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.WhiteSmoke;
            iconPictureBox2.ForeColor = Color.SteelBlue;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox2.IconColor = Color.SteelBlue;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 50;
            iconPictureBox2.Location = new Point(937, 30);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(54, 50);
            iconPictureBox2.TabIndex = 205;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox1.IconColor = Color.SteelBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 53;
            iconPictureBox1.Location = new Point(375, 30);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(54, 53);
            iconPictureBox1.TabIndex = 203;
            iconPictureBox1.TabStop = false;
            // 
            // btn_traerProduc
            // 
            btn_traerProduc.AutoSize = false;
            btn_traerProduc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_traerProduc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_traerProduc.Depth = 0;
            btn_traerProduc.HighEmphasis = true;
            btn_traerProduc.Icon = null;
            btn_traerProduc.Location = new Point(986, 30);
            btn_traerProduc.Margin = new Padding(4, 6, 4, 6);
            btn_traerProduc.MouseState = MaterialSkin.MouseState.HOVER;
            btn_traerProduc.Name = "btn_traerProduc";
            btn_traerProduc.NoAccentTextColor = Color.Empty;
            btn_traerProduc.Size = new Size(114, 50);
            btn_traerProduc.TabIndex = 204;
            btn_traerProduc.Text = "BUSCAR";
            btn_traerProduc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_traerProduc.UseAccentColor = false;
            btn_traerProduc.UseVisualStyleBackColor = true;
            btn_traerProduc.Click += btn_traerProduc_Click;
            // 
            // btn_traerProv
            // 
            btn_traerProv.AutoSize = false;
            btn_traerProv.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_traerProv.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_traerProv.Depth = 0;
            btn_traerProv.HighEmphasis = true;
            btn_traerProv.Icon = null;
            btn_traerProv.Location = new Point(424, 30);
            btn_traerProv.Margin = new Padding(4, 6, 4, 6);
            btn_traerProv.MouseState = MaterialSkin.MouseState.HOVER;
            btn_traerProv.Name = "btn_traerProv";
            btn_traerProv.NoAccentTextColor = Color.Empty;
            btn_traerProv.Size = new Size(114, 50);
            btn_traerProv.TabIndex = 202;
            btn_traerProv.Text = "BUSCAR";
            btn_traerProv.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_traerProv.UseAccentColor = false;
            btn_traerProv.UseVisualStyleBackColor = true;
            btn_traerProv.Click += btn_traerProv_Click;
            // 
            // iconPictureBox9
            // 
            iconPictureBox9.BackColor = Color.WhiteSmoke;
            iconPictureBox9.ForeColor = Color.SteelBlue;
            iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            iconPictureBox9.IconColor = Color.SteelBlue;
            iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox9.IconSize = 53;
            iconPictureBox9.Location = new Point(784, 539);
            iconPictureBox9.Name = "iconPictureBox9";
            iconPictureBox9.Size = new Size(59, 53);
            iconPictureBox9.TabIndex = 209;
            iconPictureBox9.TabStop = false;
            // 
            // btn_ConfirmarCompra
            // 
            btn_ConfirmarCompra.AutoSize = false;
            btn_ConfirmarCompra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_ConfirmarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_ConfirmarCompra.Depth = 0;
            btn_ConfirmarCompra.HighEmphasis = true;
            btn_ConfirmarCompra.Icon = null;
            btn_ConfirmarCompra.Location = new Point(839, 539);
            btn_ConfirmarCompra.Margin = new Padding(4, 6, 4, 6);
            btn_ConfirmarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            btn_ConfirmarCompra.Name = "btn_ConfirmarCompra";
            btn_ConfirmarCompra.NoAccentTextColor = Color.Empty;
            btn_ConfirmarCompra.Size = new Size(280, 53);
            btn_ConfirmarCompra.TabIndex = 210;
            btn_ConfirmarCompra.Text = "CONFIRMAR COMPRA";
            btn_ConfirmarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_ConfirmarCompra.UseAccentColor = false;
            btn_ConfirmarCompra.UseVisualStyleBackColor = true;
            btn_ConfirmarCompra.Click += btn_ConfirmarCompra_Click;
            // 
            // Entrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 601);
            Controls.Add(iconPictureBox9);
            Controls.Add(panel1);
            Controls.Add(pnl_detalle);
            Controls.Add(dgvCarrito);
            Controls.Add(btn_ConfirmarCompra);
            Name = "Entrada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Compra :.";
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            pnl_detalle.ResumeLayout(false);
            pnl_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_TraerProducto;
        private DataGridView dgvCarrito;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private FontAwesome.Sharp.IconButton btn_añadir;
        private Panel pnl_detalle;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txt_nombreProducto;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_idproducto;
        private MaterialSkin.Controls.MaterialTextBox txt_cuit;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txt_provNombre;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton btn_traerProv;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private MaterialSkin.Controls.MaterialButton btn_traerProduc;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txt_cantidad;
        private MaterialSkin.Controls.MaterialTextBox txt_precio;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSlider nud_ganancia;
        private MaterialSkin.Controls.MaterialButton btn_agregarCarrito;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private MaterialSkin.Controls.MaterialButton btn_ConfirmarCompra;
    }
}