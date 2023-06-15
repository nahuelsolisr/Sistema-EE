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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salidas));
            dgvProductos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btn_traerProduc = new MaterialSkin.Controls.MaterialButton();
            btn_traerCliente = new MaterialSkin.Controls.MaterialButton();
            txt_cuit = new MaterialSkin.Controls.MaterialTextBox();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            txt_nombreProducto = new MaterialSkin.Controls.MaterialTextBox();
            txt_nombreCliente = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            txt_idproducto = new MaterialSkin.Controls.MaterialTextBox();
            pnl_detalle = new Panel();
            lbl_stockDisponible = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            txt_cantidad = new MaterialSkin.Controls.MaterialTextBox();
            txt_precio = new MaterialSkin.Controls.MaterialTextBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            btn_agregarCarrito = new MaterialSkin.Controls.MaterialButton();
            btn_ConfirmarCompra = new MaterialSkin.Controls.MaterialButton();
            btn_limpiar = new MaterialSkin.Controls.MaterialButton();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            txt_efectivo = new MaterialSkin.Controls.MaterialTextBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            lbl_total = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            pnl_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dgvProductos.Size = new Size(885, 281);
            dgvProductos.TabIndex = 170;
            // 
            // Column1
            // 
            Column1.HeaderText = "Producto";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
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
            iconPictureBox1.ForeColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox1.IconColor = Color.SteelBlue;
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
            panel2.Controls.Add(materialLabel1);
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
            panel2.Controls.Add(txt_idproducto);
            panel2.Location = new Point(6, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(1113, 96);
            panel2.TabIndex = 202;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(569, 9);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(63, 19);
            materialLabel1.TabIndex = 205;
            materialLabel1.Text = "CODIGO:";
            // 
            // btn_traerProduc
            // 
            btn_traerProduc.AutoSize = false;
            btn_traerProduc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_traerProduc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_traerProduc.Depth = 0;
            btn_traerProduc.HighEmphasis = true;
            btn_traerProduc.Icon = (Image)resources.GetObject("btn_traerProduc.Icon");
            btn_traerProduc.Location = new Point(942, 30);
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
            btn_traerCliente.Icon = (Image)resources.GetObject("btn_traerCliente.Icon");
            btn_traerCliente.Location = new Point(376, 31);
            btn_traerCliente.Margin = new Padding(4, 6, 4, 6);
            btn_traerCliente.MouseState = MaterialSkin.MouseState.HOVER;
            btn_traerCliente.Name = "btn_traerCliente";
            btn_traerCliente.NoAccentTextColor = Color.Empty;
            btn_traerCliente.Size = new Size(114, 49);
            btn_traerCliente.TabIndex = 202;
            btn_traerCliente.Text = "BUSCAR";
            btn_traerCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_traerCliente.UseAccentColor = false;
            btn_traerCliente.UseVisualStyleBackColor = true;
            btn_traerCliente.Click += btn_traerCliente_Click;
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
            iconPictureBox6.ForeColor = Color.SteelBlue;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            iconPictureBox6.IconColor = Color.SteelBlue;
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
            materialLabel3.Size = new Size(88, 19);
            materialLabel3.TabIndex = 192;
            materialLabel3.Text = "PRODUCTO:";
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
            pnl_detalle.Controls.Add(lbl_stockDisponible);
            pnl_detalle.Controls.Add(materialLabel10);
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
            pnl_detalle.Size = new Size(1119, 137);
            pnl_detalle.TabIndex = 206;
            // 
            // lbl_stockDisponible
            // 
            lbl_stockDisponible.AutoSize = true;
            lbl_stockDisponible.Depth = 0;
            lbl_stockDisponible.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_stockDisponible.Location = new Point(620, 103);
            lbl_stockDisponible.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_stockDisponible.Name = "lbl_stockDisponible";
            lbl_stockDisponible.Size = new Size(1, 0);
            lbl_stockDisponible.TabIndex = 211;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(435, 103);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(175, 19);
            materialLabel10.TabIndex = 210;
            materialLabel10.Text = "CANTIDAD DISPONIBLE:";
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
            // btn_agregarCarrito
            // 
            btn_agregarCarrito.AutoSize = false;
            btn_agregarCarrito.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_agregarCarrito.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_agregarCarrito.Depth = 0;
            btn_agregarCarrito.HighEmphasis = true;
            btn_agregarCarrito.Icon = (Image)resources.GetObject("btn_agregarCarrito.Icon");
            btn_agregarCarrito.Location = new Point(894, 77);
            btn_agregarCarrito.Margin = new Padding(4, 6, 4, 6);
            btn_agregarCarrito.MouseState = MaterialSkin.MouseState.HOVER;
            btn_agregarCarrito.Name = "btn_agregarCarrito";
            btn_agregarCarrito.NoAccentTextColor = Color.Empty;
            btn_agregarCarrito.Size = new Size(219, 50);
            btn_agregarCarrito.TabIndex = 209;
            btn_agregarCarrito.Text = "AGREGAR AL CARRITO";
            btn_agregarCarrito.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_agregarCarrito.UseAccentColor = false;
            btn_agregarCarrito.UseVisualStyleBackColor = true;
            btn_agregarCarrito.Click += btn_agregarCarrito_Click;
            // 
            // btn_ConfirmarCompra
            // 
            btn_ConfirmarCompra.AutoSize = false;
            btn_ConfirmarCompra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_ConfirmarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_ConfirmarCompra.Depth = 0;
            btn_ConfirmarCompra.HighEmphasis = true;
            btn_ConfirmarCompra.Icon = (Image)resources.GetObject("btn_ConfirmarCompra.Icon");
            btn_ConfirmarCompra.Location = new Point(897, 539);
            btn_ConfirmarCompra.Margin = new Padding(4, 6, 4, 6);
            btn_ConfirmarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            btn_ConfirmarCompra.Name = "btn_ConfirmarCompra";
            btn_ConfirmarCompra.NoAccentTextColor = Color.Empty;
            btn_ConfirmarCompra.Size = new Size(228, 53);
            btn_ConfirmarCompra.TabIndex = 212;
            btn_ConfirmarCompra.Text = "VENDER";
            btn_ConfirmarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_ConfirmarCompra.UseAccentColor = false;
            btn_ConfirmarCompra.UseVisualStyleBackColor = true;
            btn_ConfirmarCompra.Click += btn_ConfirmarCompra_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.AutoSize = false;
            btn_limpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_limpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_limpiar.Depth = 0;
            btn_limpiar.HighEmphasis = true;
            btn_limpiar.Icon = (Image)resources.GetObject("btn_limpiar.Icon");
            btn_limpiar.Location = new Point(900, 315);
            btn_limpiar.Margin = new Padding(4, 6, 4, 6);
            btn_limpiar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.NoAccentTextColor = Color.Empty;
            btn_limpiar.Size = new Size(219, 49);
            btn_limpiar.TabIndex = 213;
            btn_limpiar.Text = "Vaciar carrito";
            btn_limpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_limpiar.UseAccentColor = false;
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(948, 458);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(73, 19);
            materialLabel5.TabIndex = 212;
            materialLabel5.Text = "IMPORTE:";
            // 
            // txt_efectivo
            // 
            txt_efectivo.AnimateReadOnly = false;
            txt_efectivo.BorderStyle = BorderStyle.None;
            txt_efectivo.Depth = 0;
            txt_efectivo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_efectivo.LeadingIcon = null;
            txt_efectivo.Location = new Point(940, 480);
            txt_efectivo.MaxLength = 50;
            txt_efectivo.MouseState = MaterialSkin.MouseState.OUT;
            txt_efectivo.Multiline = false;
            txt_efectivo.Name = "txt_efectivo";
            txt_efectivo.Size = new Size(179, 50);
            txt_efectivo.TabIndex = 211;
            txt_efectivo.Text = "";
            txt_efectivo.TrailingIcon = null;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.WhiteSmoke;
            iconPictureBox2.ForeColor = Color.SteelBlue;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            iconPictureBox2.IconColor = Color.SteelBlue;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 43;
            iconPictureBox2.Location = new Point(897, 480);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(43, 50);
            iconPictureBox2.TabIndex = 210;
            iconPictureBox2.TabStop = false;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(900, 388);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(55, 19);
            materialLabel9.TabIndex = 214;
            materialLabel9.Text = "TOTAL:";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Depth = 0;
            lbl_total.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_total.Location = new Point(966, 387);
            lbl_total.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(1, 0);
            lbl_total.TabIndex = 215;
            // 
            // Salidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 601);
            Controls.Add(lbl_total);
            Controls.Add(materialLabel9);
            Controls.Add(materialLabel5);
            Controls.Add(btn_limpiar);
            Controls.Add(txt_efectivo);
            Controls.Add(iconPictureBox2);
            Controls.Add(btn_ConfirmarCompra);
            Controls.Add(pnl_detalle);
            Controls.Add(panel2);
            Controls.Add(dgvProductos);
            Name = "Salidas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Venta :.";
            FormClosed += Salidas_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            pnl_detalle.ResumeLayout(false);
            pnl_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton btn_traerProduc;
        private MaterialSkin.Controls.MaterialButton btn_traerCliente;
        private MaterialSkin.Controls.MaterialTextBox txt_cuit;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txt_nombreProducto;
        private MaterialSkin.Controls.MaterialTextBox txt_nombreCliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txt_idproducto;
        private Panel pnl_detalle;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txt_cantidad;
        private MaterialSkin.Controls.MaterialTextBox txt_precio;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private MaterialSkin.Controls.MaterialButton btn_agregarCarrito;
        private MaterialSkin.Controls.MaterialButton btn_ConfirmarCompra;
        private MaterialSkin.Controls.MaterialButton btn_limpiar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txt_efectivo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel lbl_total;
        private MaterialSkin.Controls.MaterialLabel lbl_stockDisponible;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
    }
}