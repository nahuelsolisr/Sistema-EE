namespace SistemaEE.Formularios
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btn_contabilidad = new FontAwesome.Sharp.IconButton();
            mtcMenu = new MaterialSkin.Controls.MaterialTabControl();
            tabHome = new TabPage();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            lbl_horaActual = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox1 = new PictureBox();
            lbl_usuario = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tabFacturacion = new TabPage();
            btn_stock = new MaterialSkin.Controls.MaterialButton();
            btn_salidas = new MaterialSkin.Controls.MaterialButton();
            btn_entradas = new MaterialSkin.Controls.MaterialButton();
            btn_clientes = new MaterialSkin.Controls.MaterialButton();
            btn_producto = new MaterialSkin.Controls.MaterialButton();
            btn_prov = new MaterialSkin.Controls.MaterialButton();
            tabContabilidad = new TabPage();
            tabUsuarios = new TabPage();
            tabConfiguracion = new TabPage();
            btn_datosEmpresa = new MaterialSkin.Controls.MaterialButton();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            pic_logoEmpresa = new PictureBox();
            txt_direcciónEmpresa = new MaterialSkin.Controls.MaterialTextBox();
            iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            txt_nombreEmpresa = new MaterialSkin.Controls.MaterialTextBox();
            iconPictureBox11 = new FontAwesome.Sharp.IconPictureBox();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            msModoOscuro = new MaterialSkin.Controls.MaterialSwitch();
            btn_subirLogo = new MaterialSkin.Controls.MaterialButton();
            ImagenesTab = new ImageList(components);
            timer1 = new System.Windows.Forms.Timer(components);
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            mtcMenu.SuspendLayout();
            tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabFacturacion.SuspendLayout();
            tabContabilidad.SuspendLayout();
            tabConfiguracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logoEmpresa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            SuspendLayout();
            // 
            // btn_contabilidad
            // 
            btn_contabilidad.Enabled = false;
            btn_contabilidad.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_contabilidad.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            btn_contabilidad.IconColor = Color.DimGray;
            btn_contabilidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_contabilidad.ImageAlign = ContentAlignment.MiddleLeft;
            btn_contabilidad.Location = new Point(3, 3);
            btn_contabilidad.Name = "btn_contabilidad";
            btn_contabilidad.Size = new Size(211, 60);
            btn_contabilidad.TabIndex = 17;
            btn_contabilidad.Text = "Contabilidad";
            btn_contabilidad.TextAlign = ContentAlignment.MiddleRight;
            btn_contabilidad.UseVisualStyleBackColor = true;
            // 
            // mtcMenu
            // 
            mtcMenu.Controls.Add(tabHome);
            mtcMenu.Controls.Add(tabFacturacion);
            mtcMenu.Controls.Add(tabContabilidad);
            mtcMenu.Controls.Add(tabUsuarios);
            mtcMenu.Controls.Add(tabConfiguracion);
            mtcMenu.Depth = 0;
            mtcMenu.ImageList = ImagenesTab;
            mtcMenu.Location = new Point(6, 67);
            mtcMenu.MouseState = MaterialSkin.MouseState.HOVER;
            mtcMenu.Multiline = true;
            mtcMenu.Name = "mtcMenu";
            mtcMenu.SelectedIndex = 0;
            mtcMenu.Size = new Size(585, 528);
            mtcMenu.TabIndex = 21;
            mtcMenu.SelectedIndexChanged += mtcMenu_SelectedIndexChanged;
            // 
            // tabHome
            // 
            tabHome.BackColor = Color.White;
            tabHome.Controls.Add(materialLabel10);
            tabHome.Controls.Add(materialLabel3);
            tabHome.Controls.Add(lbl_horaActual);
            tabHome.Controls.Add(materialLabel2);
            tabHome.Controls.Add(pictureBox1);
            tabHome.Controls.Add(lbl_usuario);
            tabHome.Controls.Add(materialLabel1);
            tabHome.ImageKey = "house-solid.png";
            tabHome.Location = new Point(4, 39);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(577, 485);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.BackColor = Color.Transparent;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(70, 13);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(115, 19);
            materialLabel3.TabIndex = 26;
            materialLabel3.Text = "Tipo de usuario:";
            // 
            // lbl_horaActual
            // 
            lbl_horaActual.AutoSize = true;
            lbl_horaActual.BackColor = Color.Transparent;
            lbl_horaActual.Depth = 0;
            lbl_horaActual.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_horaActual.Location = new Point(464, 14);
            lbl_horaActual.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_horaActual.Name = "lbl_horaActual";
            lbl_horaActual.Size = new Size(1, 0);
            lbl_horaActual.TabIndex = 25;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(213, 478);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(358, 19);
            materialLabel2.TabIndex = 24;
            materialLabel2.Text = "¿Qué vamos a hacer hoy? sólo tu puedes saberlo...";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(501, 404);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.BackColor = Color.Transparent;
            lbl_usuario.Depth = 0;
            lbl_usuario.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_usuario.Location = new Point(191, 13);
            lbl_usuario.MouseState = MaterialSkin.MouseState.HOVER;
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(107, 19);
            lbl_usuario.TabIndex = 22;
            lbl_usuario.Text = "materialLabel1";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(70, 49);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(185, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "¡Bienvenido al programa!\r\n\r\n";
            // 
            // tabFacturacion
            // 
            tabFacturacion.BackColor = Color.White;
            tabFacturacion.Controls.Add(btn_stock);
            tabFacturacion.Controls.Add(btn_salidas);
            tabFacturacion.Controls.Add(btn_entradas);
            tabFacturacion.Controls.Add(btn_clientes);
            tabFacturacion.Controls.Add(btn_producto);
            tabFacturacion.Controls.Add(btn_prov);
            tabFacturacion.ImageKey = "file-invoice-solid.png";
            tabFacturacion.Location = new Point(4, 39);
            tabFacturacion.Name = "tabFacturacion";
            tabFacturacion.Padding = new Padding(3);
            tabFacturacion.Size = new Size(577, 485);
            tabFacturacion.TabIndex = 1;
            tabFacturacion.Text = "Facturación";
            // 
            // btn_stock
            // 
            btn_stock.AutoSize = false;
            btn_stock.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_stock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_stock.Depth = 0;
            btn_stock.HighEmphasis = true;
            btn_stock.Icon = (Image)resources.GetObject("btn_stock.Icon");
            btn_stock.Location = new Point(66, 307);
            btn_stock.Margin = new Padding(4, 6, 4, 6);
            btn_stock.MouseState = MaterialSkin.MouseState.HOVER;
            btn_stock.Name = "btn_stock";
            btn_stock.NoAccentTextColor = Color.Empty;
            btn_stock.Size = new Size(182, 53);
            btn_stock.TabIndex = 36;
            btn_stock.Text = "Inventario";
            btn_stock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_stock.UseAccentColor = false;
            btn_stock.UseVisualStyleBackColor = true;
            btn_stock.Click += btn_stock_Click;
            // 
            // btn_salidas
            // 
            btn_salidas.AutoSize = false;
            btn_salidas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_salidas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_salidas.Depth = 0;
            btn_salidas.HighEmphasis = true;
            btn_salidas.Icon = (Image)resources.GetObject("btn_salidas.Icon");
            btn_salidas.Location = new Point(66, 248);
            btn_salidas.Margin = new Padding(4, 6, 4, 6);
            btn_salidas.MouseState = MaterialSkin.MouseState.HOVER;
            btn_salidas.Name = "btn_salidas";
            btn_salidas.NoAccentTextColor = Color.Empty;
            btn_salidas.Size = new Size(182, 53);
            btn_salidas.TabIndex = 35;
            btn_salidas.Text = "Salidas";
            btn_salidas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_salidas.UseAccentColor = false;
            btn_salidas.UseVisualStyleBackColor = true;
            btn_salidas.Click += btn_salidas_Click;
            // 
            // btn_entradas
            // 
            btn_entradas.AutoSize = false;
            btn_entradas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_entradas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_entradas.Depth = 0;
            btn_entradas.HighEmphasis = true;
            btn_entradas.Icon = (Image)resources.GetObject("btn_entradas.Icon");
            btn_entradas.Location = new Point(66, 186);
            btn_entradas.Margin = new Padding(4, 6, 4, 6);
            btn_entradas.MouseState = MaterialSkin.MouseState.HOVER;
            btn_entradas.Name = "btn_entradas";
            btn_entradas.NoAccentTextColor = Color.Empty;
            btn_entradas.Size = new Size(182, 53);
            btn_entradas.TabIndex = 34;
            btn_entradas.Text = "Entradas";
            btn_entradas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_entradas.UseAccentColor = false;
            btn_entradas.UseVisualStyleBackColor = true;
            btn_entradas.Click += btn_entradas_Click;
            // 
            // btn_clientes
            // 
            btn_clientes.AutoSize = false;
            btn_clientes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_clientes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_clientes.Depth = 0;
            btn_clientes.HighEmphasis = true;
            btn_clientes.Icon = (Image)resources.GetObject("btn_clientes.Icon");
            btn_clientes.Location = new Point(66, 127);
            btn_clientes.Margin = new Padding(4, 6, 4, 6);
            btn_clientes.MouseState = MaterialSkin.MouseState.HOVER;
            btn_clientes.Name = "btn_clientes";
            btn_clientes.NoAccentTextColor = Color.Empty;
            btn_clientes.Size = new Size(182, 53);
            btn_clientes.TabIndex = 33;
            btn_clientes.Text = "Clientes";
            btn_clientes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_clientes.UseAccentColor = false;
            btn_clientes.UseVisualStyleBackColor = true;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // btn_producto
            // 
            btn_producto.AutoSize = false;
            btn_producto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_producto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_producto.Depth = 0;
            btn_producto.HighEmphasis = true;
            btn_producto.Icon = (Image)resources.GetObject("btn_producto.Icon");
            btn_producto.Location = new Point(66, 68);
            btn_producto.Margin = new Padding(4, 6, 4, 6);
            btn_producto.MouseState = MaterialSkin.MouseState.HOVER;
            btn_producto.Name = "btn_producto";
            btn_producto.NoAccentTextColor = Color.Empty;
            btn_producto.Size = new Size(182, 53);
            btn_producto.TabIndex = 32;
            btn_producto.Text = "Productos";
            btn_producto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_producto.UseAccentColor = false;
            btn_producto.UseVisualStyleBackColor = true;
            btn_producto.Click += btn_producto_Click;
            // 
            // btn_prov
            // 
            btn_prov.AutoSize = false;
            btn_prov.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_prov.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_prov.Depth = 0;
            btn_prov.HighEmphasis = true;
            btn_prov.Icon = (Image)resources.GetObject("btn_prov.Icon");
            btn_prov.Location = new Point(66, 9);
            btn_prov.Margin = new Padding(4, 6, 4, 6);
            btn_prov.MouseState = MaterialSkin.MouseState.HOVER;
            btn_prov.Name = "btn_prov";
            btn_prov.NoAccentTextColor = Color.Empty;
            btn_prov.Size = new Size(182, 53);
            btn_prov.TabIndex = 31;
            btn_prov.Text = "Proveedores";
            btn_prov.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_prov.UseAccentColor = false;
            btn_prov.UseVisualStyleBackColor = true;
            btn_prov.Click += btn_prov_Click;
            // 
            // tabContabilidad
            // 
            tabContabilidad.BackColor = Color.White;
            tabContabilidad.Controls.Add(btn_contabilidad);
            tabContabilidad.ImageKey = "receipt-solid.png";
            tabContabilidad.Location = new Point(4, 39);
            tabContabilidad.Name = "tabContabilidad";
            tabContabilidad.Size = new Size(577, 485);
            tabContabilidad.TabIndex = 2;
            tabContabilidad.Text = "Contabilidad";
            // 
            // tabUsuarios
            // 
            tabUsuarios.BackColor = Color.White;
            tabUsuarios.ImageKey = "user-solid.png";
            tabUsuarios.Location = new Point(4, 39);
            tabUsuarios.Name = "tabUsuarios";
            tabUsuarios.Size = new Size(577, 485);
            tabUsuarios.TabIndex = 3;
            tabUsuarios.Text = "Usuarios";
            // 
            // tabConfiguracion
            // 
            tabConfiguracion.BackColor = Color.White;
            tabConfiguracion.Controls.Add(btn_datosEmpresa);
            tabConfiguracion.Controls.Add(materialLabel9);
            tabConfiguracion.Controls.Add(pic_logoEmpresa);
            tabConfiguracion.Controls.Add(txt_direcciónEmpresa);
            tabConfiguracion.Controls.Add(iconPictureBox8);
            tabConfiguracion.Controls.Add(materialLabel8);
            tabConfiguracion.Controls.Add(materialDivider2);
            tabConfiguracion.Controls.Add(materialDivider1);
            tabConfiguracion.Controls.Add(txt_nombreEmpresa);
            tabConfiguracion.Controls.Add(iconPictureBox11);
            tabConfiguracion.Controls.Add(materialLabel7);
            tabConfiguracion.Controls.Add(iconPictureBox7);
            tabConfiguracion.Controls.Add(materialLabel6);
            tabConfiguracion.Controls.Add(materialLabel5);
            tabConfiguracion.Controls.Add(materialLabel4);
            tabConfiguracion.Controls.Add(msModoOscuro);
            tabConfiguracion.Controls.Add(btn_subirLogo);
            tabConfiguracion.ImageKey = "gear-solid.png";
            tabConfiguracion.Location = new Point(4, 39);
            tabConfiguracion.Name = "tabConfiguracion";
            tabConfiguracion.Size = new Size(577, 485);
            tabConfiguracion.TabIndex = 4;
            tabConfiguracion.Text = "Opciones";
            // 
            // btn_datosEmpresa
            // 
            btn_datosEmpresa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_datosEmpresa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_datosEmpresa.Depth = 0;
            btn_datosEmpresa.HighEmphasis = true;
            btn_datosEmpresa.Icon = (Image)resources.GetObject("btn_datosEmpresa.Icon");
            btn_datosEmpresa.Location = new Point(64, 443);
            btn_datosEmpresa.Margin = new Padding(4, 6, 4, 6);
            btn_datosEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            btn_datosEmpresa.Name = "btn_datosEmpresa";
            btn_datosEmpresa.NoAccentTextColor = Color.Empty;
            btn_datosEmpresa.Size = new Size(196, 36);
            btn_datosEmpresa.TabIndex = 173;
            btn_datosEmpresa.Text = "Modificar cambios";
            btn_datosEmpresa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_datosEmpresa.UseAccentColor = false;
            btn_datosEmpresa.UseVisualStyleBackColor = true;
            btn_datosEmpresa.Click += btn_datosEmpresa_Click;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(339, 212);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(41, 19);
            materialLabel9.TabIndex = 169;
            materialLabel9.Text = "Logo:";
            // 
            // pic_logoEmpresa
            // 
            pic_logoEmpresa.Image = (Image)resources.GetObject("pic_logoEmpresa.Image");
            pic_logoEmpresa.Location = new Point(339, 234);
            pic_logoEmpresa.Name = "pic_logoEmpresa";
            pic_logoEmpresa.Size = new Size(148, 128);
            pic_logoEmpresa.TabIndex = 168;
            pic_logoEmpresa.TabStop = false;
            // 
            // txt_direcciónEmpresa
            // 
            txt_direcciónEmpresa.AnimateReadOnly = false;
            txt_direcciónEmpresa.BorderStyle = BorderStyle.None;
            txt_direcciónEmpresa.Depth = 0;
            txt_direcciónEmpresa.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_direcciónEmpresa.LeadingIcon = null;
            txt_direcciónEmpresa.Location = new Point(111, 312);
            txt_direcciónEmpresa.MaxLength = 50;
            txt_direcciónEmpresa.MouseState = MaterialSkin.MouseState.OUT;
            txt_direcciónEmpresa.Multiline = false;
            txt_direcciónEmpresa.Name = "txt_direcciónEmpresa";
            txt_direcciónEmpresa.Size = new Size(184, 50);
            txt_direcciónEmpresa.TabIndex = 166;
            txt_direcciónEmpresa.Text = "";
            txt_direcciónEmpresa.TrailingIcon = null;
            // 
            // iconPictureBox8
            // 
            iconPictureBox8.BackColor = Color.WhiteSmoke;
            iconPictureBox8.ForeColor = Color.SteelBlue;
            iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            iconPictureBox8.IconColor = Color.SteelBlue;
            iconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox8.IconSize = 48;
            iconPictureBox8.Location = new Point(61, 313);
            iconPictureBox8.Name = "iconPictureBox8";
            iconPictureBox8.Size = new Size(48, 52);
            iconPictureBox8.TabIndex = 165;
            iconPictureBox8.TabStop = false;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(111, 290);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(71, 19);
            materialLabel8.TabIndex = 167;
            materialLabel8.Text = "Dirección:";
            // 
            // materialDivider2
            // 
            materialDivider2.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider2.Depth = 0;
            materialDivider2.Location = new Point(61, 153);
            materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            materialDivider2.Size = new Size(513, 10);
            materialDivider2.TabIndex = 164;
            materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(61, 23);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(513, 10);
            materialDivider1.TabIndex = 163;
            materialDivider1.Text = "materialDivider1";
            // 
            // txt_nombreEmpresa
            // 
            txt_nombreEmpresa.AnimateReadOnly = false;
            txt_nombreEmpresa.BorderStyle = BorderStyle.None;
            txt_nombreEmpresa.Depth = 0;
            txt_nombreEmpresa.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_nombreEmpresa.LeadingIcon = null;
            txt_nombreEmpresa.Location = new Point(111, 234);
            txt_nombreEmpresa.MaxLength = 50;
            txt_nombreEmpresa.MouseState = MaterialSkin.MouseState.OUT;
            txt_nombreEmpresa.Multiline = false;
            txt_nombreEmpresa.Name = "txt_nombreEmpresa";
            txt_nombreEmpresa.Size = new Size(184, 50);
            txt_nombreEmpresa.TabIndex = 161;
            txt_nombreEmpresa.Text = "";
            txt_nombreEmpresa.TrailingIcon = null;
            // 
            // iconPictureBox11
            // 
            iconPictureBox11.BackColor = Color.WhiteSmoke;
            iconPictureBox11.ForeColor = Color.SteelBlue;
            iconPictureBox11.IconChar = FontAwesome.Sharp.IconChar.Building;
            iconPictureBox11.IconColor = Color.SteelBlue;
            iconPictureBox11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox11.IconSize = 48;
            iconPictureBox11.Location = new Point(61, 235);
            iconPictureBox11.Name = "iconPictureBox11";
            iconPictureBox11.Size = new Size(48, 52);
            iconPictureBox11.TabIndex = 160;
            iconPictureBox11.TabStop = false;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(111, 212);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(146, 19);
            materialLabel7.TabIndex = 162;
            materialLabel7.Text = "Nombre del negocio:";
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = Color.Transparent;
            iconPictureBox7.ForeColor = Color.SteelBlue;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Moon;
            iconPictureBox7.IconColor = Color.SteelBlue;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 42;
            iconPictureBox7.Location = new Point(67, 81);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(42, 42);
            iconPictureBox7.TabIndex = 143;
            iconPictureBox7.TabStop = false;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(64, 166);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(59, 19);
            materialLabel6.TabIndex = 3;
            materialLabel6.Text = "Negocio";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(67, 36);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(76, 19);
            materialLabel5.TabIndex = 2;
            materialLabel5.Text = "Apariencia";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(64, 117);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(1, 0);
            materialLabel4.TabIndex = 1;
            // 
            // msModoOscuro
            // 
            msModoOscuro.AutoSize = true;
            msModoOscuro.Depth = 0;
            msModoOscuro.Location = new Point(111, 84);
            msModoOscuro.Margin = new Padding(0);
            msModoOscuro.MouseLocation = new Point(-1, -1);
            msModoOscuro.MouseState = MaterialSkin.MouseState.HOVER;
            msModoOscuro.Name = "msModoOscuro";
            msModoOscuro.Ripple = true;
            msModoOscuro.Size = new Size(153, 37);
            msModoOscuro.TabIndex = 0;
            msModoOscuro.Text = "Modo Oscuro";
            msModoOscuro.UseVisualStyleBackColor = true;
            msModoOscuro.CheckedChanged += msModoOscuro_CheckedChanged;
            // 
            // btn_subirLogo
            // 
            btn_subirLogo.AutoSize = false;
            btn_subirLogo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_subirLogo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_subirLogo.Depth = 0;
            btn_subirLogo.HighEmphasis = true;
            btn_subirLogo.Icon = (Image)resources.GetObject("btn_subirLogo.Icon");
            btn_subirLogo.Location = new Point(339, 371);
            btn_subirLogo.Margin = new Padding(4, 6, 4, 6);
            btn_subirLogo.MouseState = MaterialSkin.MouseState.HOVER;
            btn_subirLogo.Name = "btn_subirLogo";
            btn_subirLogo.NoAccentTextColor = Color.Empty;
            btn_subirLogo.Size = new Size(147, 29);
            btn_subirLogo.TabIndex = 172;
            btn_subirLogo.Text = "Subir logo";
            btn_subirLogo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_subirLogo.UseAccentColor = false;
            btn_subirLogo.UseVisualStyleBackColor = true;
            btn_subirLogo.Click += btn_subirLogo_Click;
            // 
            // ImagenesTab
            // 
            ImagenesTab.ColorDepth = ColorDepth.Depth32Bit;
            ImagenesTab.ImageStream = (ImageListStreamer)resources.GetObject("ImagenesTab.ImageStream");
            ImagenesTab.TransparentColor = Color.Transparent;
            ImagenesTab.Images.SetKeyName(0, "house-solid.png");
            ImagenesTab.Images.SetKeyName(1, "file-invoice-solid.png");
            ImagenesTab.Images.SetKeyName(2, "receipt-solid.png");
            ImagenesTab.Images.SetKeyName(3, "user-solid.png");
            ImagenesTab.Images.SetKeyName(4, "gear-solid.png");
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(371, 13);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(87, 19);
            materialLabel10.TabIndex = 27;
            materialLabel10.Text = "Hora actual:";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 89);
            ClientSize = new Size(597, 601);
            Controls.Add(mtcMenu);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = mtcMenu;
            Name = "Menu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Menu :.";
            FormClosed += Menu_FormClosed;
            mtcMenu.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabFacturacion.ResumeLayout(false);
            tabContabilidad.ResumeLayout(false);
            tabConfiguracion.ResumeLayout(false);
            tabConfiguracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logoEmpresa).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_contabilidad;
        private MaterialSkin.Controls.MaterialTabControl mtcMenu;
        private TabPage tabHome;
        private TabPage tabFacturacion;
        private TabPage tabContabilidad;
        private TabPage tabUsuarios;
        private TabPage tabConfiguracion;
        private MaterialSkin.Controls.MaterialLabel lbl_usuario;
        private MaterialSkin.Controls.MaterialSwitch msModoOscuro;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btn_prov;
        private MaterialSkin.Controls.MaterialButton btn_stock;
        private MaterialSkin.Controls.MaterialButton btn_salidas;
        private MaterialSkin.Controls.MaterialButton btn_entradas;
        private MaterialSkin.Controls.MaterialButton btn_clientes;
        private MaterialSkin.Controls.MaterialButton btn_producto;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private PictureBox pictureBox1;
        private ImageList ImagenesTab;
        private MaterialSkin.Controls.MaterialLabel lbl_horaActual;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        public System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private PictureBox pic_logoEmpresa;
        private MaterialSkin.Controls.MaterialTextBox txt_direcciónEmpresa;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTextBox txt_nombreEmpresa;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox11;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialButton btn_subirLogo;
        private MaterialSkin.Controls.MaterialButton btn_datosEmpresa;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
    }
}