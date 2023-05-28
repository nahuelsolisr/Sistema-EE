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
            dgvProductos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            btn_traerProduc = new MaterialSkin.Controls.MaterialButton();
            btn_traerCliente = new MaterialSkin.Controls.MaterialButton();
            txt_cuit = new MaterialSkin.Controls.MaterialTextBox();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            txt_nombreProducto = new MaterialSkin.Controls.MaterialTextBox();
            txt_nombreCliente = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txt_idproducto = new MaterialSkin.Controls.MaterialTextBox();
            pnl_detalle = new Panel();
            iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            txt_cantidad = new MaterialSkin.Controls.MaterialTextBox();
            txt_precio = new MaterialSkin.Controls.MaterialTextBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            btn_agregarCarrito = new MaterialSkin.Controls.MaterialButton();
            iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            btn_ConfirmarCompra = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            pnl_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).BeginInit();
            SuspendLayout();
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
            dgvProductos.Location = new Point(7, 313);
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
            dgvProductos.Size = new Size(773, 281);
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
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 50;
            iconPictureBox1.Location = new Point(3, 30);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(51, 50);
            iconPictureBox1.TabIndex = 181;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox2);
            panel2.Controls.Add(iconPictureBox3);
            panel2.Controls.Add(btn_traerProduc);
            panel2.Controls.Add(btn_traerCliente);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(txt_cuit);
            panel2.Controls.Add(iconPictureBox6);
            panel2.Controls.Add(materialLabel4);
            panel2.Controls.Add(materialLabel2);
            panel2.Controls.Add(txt_nombreProducto);
            panel2.Controls.Add(txt_nombreCliente);
            panel2.Controls.Add(materialLabel3);
            panel2.Controls.Add(materialLabel1);
            panel2.Controls.Add(txt_idproducto);
            panel2.Location = new Point(6, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(1113, 96);
            panel2.TabIndex = 202;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.WhiteSmoke;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 50;
            iconPictureBox2.Location = new Point(937, 30);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(54, 50);
            iconPictureBox2.TabIndex = 205;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.WhiteSmoke;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 53;
            iconPictureBox3.Location = new Point(375, 30);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(54, 53);
            iconPictureBox3.TabIndex = 203;
            iconPictureBox3.TabStop = false;
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
            // btn_traerCliente
            // 
            btn_traerCliente.AutoSize = false;
            btn_traerCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_traerCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_traerCliente.Depth = 0;
            btn_traerCliente.HighEmphasis = true;
            btn_traerCliente.Icon = null;
            btn_traerCliente.Location = new Point(424, 30);
            btn_traerCliente.Margin = new Padding(4, 6, 4, 6);
            btn_traerCliente.MouseState = MaterialSkin.MouseState.HOVER;
            btn_traerCliente.Name = "btn_traerCliente";
            btn_traerCliente.NoAccentTextColor = Color.Empty;
            btn_traerCliente.Size = new Size(114, 50);
            btn_traerCliente.TabIndex = 202;
            btn_traerCliente.Text = "BUSCAR";
            btn_traerCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_traerCliente.UseAccentColor = false;
            btn_traerCliente.UseVisualStyleBackColor = true;
            btn_traerCliente.Click += btn_traerCliente_Click_1;
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
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.WhiteSmoke;
            iconPictureBox6.ForeColor = SystemColors.ControlText;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            iconPictureBox6.IconColor = SystemColors.ControlText;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 50;
            iconPictureBox6.Location = new Point(569, 30);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(50, 50);
            iconPictureBox6.TabIndex = 137;
            iconPictureBox6.TabStop = false;
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
            // txt_nombreCliente
            // 
            txt_nombreCliente.AnimateReadOnly = false;
            txt_nombreCliente.BorderStyle = BorderStyle.None;
            txt_nombreCliente.Depth = 0;
            txt_nombreCliente.Enabled = false;
            txt_nombreCliente.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_nombreCliente.LeadingIcon = null;
            txt_nombreCliente.Location = new Point(216, 31);
            txt_nombreCliente.MaxLength = 50;
            txt_nombreCliente.MouseState = MaterialSkin.MouseState.OUT;
            txt_nombreCliente.Multiline = false;
            txt_nombreCliente.Name = "txt_nombreCliente";
            txt_nombreCliente.Size = new Size(153, 50);
            txt_nombreCliente.TabIndex = 198;
            txt_nombreCliente.Text = "";
            txt_nombreCliente.TrailingIcon = null;
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
            // pnl_detalle
            // 
            pnl_detalle.Controls.Add(iconPictureBox8);
            pnl_detalle.Controls.Add(materialLabel8);
            pnl_detalle.Controls.Add(materialLabel7);
            pnl_detalle.Controls.Add(materialLabel6);
            pnl_detalle.Controls.Add(txt_cantidad);
            pnl_detalle.Controls.Add(txt_precio);
            pnl_detalle.Controls.Add(iconPictureBox7);
            pnl_detalle.Controls.Add(iconPictureBox5);
            pnl_detalle.Controls.Add(btn_agregarCarrito);
            pnl_detalle.Location = new Point(6, 169);
            pnl_detalle.Name = "pnl_detalle";
            pnl_detalle.Size = new Size(1113, 137);
            pnl_detalle.TabIndex = 206;
            // 
            // iconPictureBox8
            // 
            iconPictureBox8.BackColor = Color.WhiteSmoke;
            iconPictureBox8.ForeColor = SystemColors.ControlText;
            iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            iconPictureBox8.IconColor = SystemColors.ControlText;
            iconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox8.IconSize = 53;
            iconPictureBox8.Location = new Point(781, 76);
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
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = Color.WhiteSmoke;
            iconPictureBox7.ForeColor = SystemColors.ControlText;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            iconPictureBox7.IconColor = SystemColors.ControlText;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 50;
            iconPictureBox7.Location = new Point(216, 77);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(53, 50);
            iconPictureBox7.TabIndex = 142;
            iconPictureBox7.TabStop = false;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.WhiteSmoke;
            iconPictureBox5.ForeColor = SystemColors.ControlText;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            iconPictureBox5.IconColor = SystemColors.ControlText;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 48;
            iconPictureBox5.Location = new Point(3, 76);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(48, 50);
            iconPictureBox5.TabIndex = 140;
            iconPictureBox5.TabStop = false;
            // 
            // btn_agregarCarrito
            // 
            btn_agregarCarrito.AutoSize = false;
            btn_agregarCarrito.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_agregarCarrito.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_agregarCarrito.Depth = 0;
            btn_agregarCarrito.HighEmphasis = true;
            btn_agregarCarrito.Icon = null;
            btn_agregarCarrito.Location = new Point(820, 76);
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
            // iconPictureBox9
            // 
            iconPictureBox9.BackColor = Color.WhiteSmoke;
            iconPictureBox9.ForeColor = SystemColors.ControlText;
            iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            iconPictureBox9.IconColor = SystemColors.ControlText;
            iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox9.IconSize = 53;
            iconPictureBox9.Location = new Point(785, 539);
            iconPictureBox9.Name = "iconPictureBox9";
            iconPictureBox9.Size = new Size(59, 53);
            iconPictureBox9.TabIndex = 211;
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
            btn_ConfirmarCompra.Size = new Size(267, 53);
            btn_ConfirmarCompra.TabIndex = 212;
            btn_ConfirmarCompra.Text = "CONFIRMAR COMPRA";
            btn_ConfirmarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_ConfirmarCompra.UseAccentColor = false;
            btn_ConfirmarCompra.UseVisualStyleBackColor = true;
            btn_ConfirmarCompra.Click += btn_ConfirmarCompra_Click;
            // 
            // Salidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 601);
            ControlBox = false;
            Controls.Add(iconPictureBox9);
            Controls.Add(btn_ConfirmarCompra);
            Controls.Add(pnl_detalle);
            Controls.Add(panel2);
            Controls.Add(dgvProductos);
            Name = "Salidas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Venta :.";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            pnl_detalle.ResumeLayout(false);
            pnl_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private MaterialSkin.Controls.MaterialButton btn_traerProduc;
        private MaterialSkin.Controls.MaterialButton btn_traerCliente;
        private MaterialSkin.Controls.MaterialTextBox txt_cuit;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txt_nombreProducto;
        private MaterialSkin.Controls.MaterialTextBox txt_nombreCliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_idproducto;
        private Panel pnl_detalle;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txt_cantidad;
        private MaterialSkin.Controls.MaterialTextBox txt_precio;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private MaterialSkin.Controls.MaterialButton btn_agregarCarrito;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private MaterialSkin.Controls.MaterialButton btn_ConfirmarCompra;
    }
}