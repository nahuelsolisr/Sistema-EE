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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btn_contabilidad = new FontAwesome.Sharp.IconButton();
            mtcMenu = new MaterialSkin.Controls.MaterialTabControl();
            tabHome = new TabPage();
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
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            tabContabilidad = new TabPage();
            tabUsuarios = new TabPage();
            tabConfiguracion = new TabPage();
            msModoOscuro = new MaterialSkin.Controls.MaterialSwitch();
            mtcMenu.SuspendLayout();
            tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabFacturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            tabContabilidad.SuspendLayout();
            tabConfiguracion.SuspendLayout();
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
            btn_contabilidad.Location = new Point(3, 46);
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
            tabHome.Controls.Add(materialLabel2);
            tabHome.Controls.Add(pictureBox1);
            tabHome.Controls.Add(lbl_usuario);
            tabHome.Controls.Add(materialLabel1);
            tabHome.Location = new Point(4, 24);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(577, 500);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
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
            pictureBox1.Location = new Point(6, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(565, 440);
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
            lbl_usuario.Location = new Point(6, 13);
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
            materialLabel1.Location = new Point(119, 13);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(185, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "¡Bienvenido al programa!\r\n\r\n";
            // 
            // tabFacturacion
            // 
            tabFacturacion.Controls.Add(btn_stock);
            tabFacturacion.Controls.Add(btn_salidas);
            tabFacturacion.Controls.Add(btn_entradas);
            tabFacturacion.Controls.Add(btn_clientes);
            tabFacturacion.Controls.Add(btn_producto);
            tabFacturacion.Controls.Add(btn_prov);
            tabFacturacion.Controls.Add(iconPictureBox6);
            tabFacturacion.Controls.Add(iconPictureBox5);
            tabFacturacion.Controls.Add(iconPictureBox4);
            tabFacturacion.Controls.Add(iconPictureBox3);
            tabFacturacion.Controls.Add(iconPictureBox2);
            tabFacturacion.Controls.Add(iconPictureBox1);
            tabFacturacion.Location = new Point(4, 24);
            tabFacturacion.Name = "tabFacturacion";
            tabFacturacion.Padding = new Padding(3);
            tabFacturacion.Size = new Size(577, 500);
            tabFacturacion.TabIndex = 1;
            tabFacturacion.Text = "Facturación";
            tabFacturacion.UseVisualStyleBackColor = true;
            // 
            // btn_stock
            // 
            btn_stock.AutoSize = false;
            btn_stock.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_stock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_stock.Depth = 0;
            btn_stock.HighEmphasis = true;
            btn_stock.Icon = null;
            btn_stock.Location = new Point(66, 304);
            btn_stock.Margin = new Padding(4, 6, 4, 6);
            btn_stock.MouseState = MaterialSkin.MouseState.HOVER;
            btn_stock.Name = "btn_stock";
            btn_stock.NoAccentTextColor = Color.Empty;
            btn_stock.Size = new Size(277, 53);
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
            btn_salidas.Icon = null;
            btn_salidas.Location = new Point(66, 245);
            btn_salidas.Margin = new Padding(4, 6, 4, 6);
            btn_salidas.MouseState = MaterialSkin.MouseState.HOVER;
            btn_salidas.Name = "btn_salidas";
            btn_salidas.NoAccentTextColor = Color.Empty;
            btn_salidas.Size = new Size(277, 53);
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
            btn_entradas.Icon = null;
            btn_entradas.Location = new Point(66, 183);
            btn_entradas.Margin = new Padding(4, 6, 4, 6);
            btn_entradas.MouseState = MaterialSkin.MouseState.HOVER;
            btn_entradas.Name = "btn_entradas";
            btn_entradas.NoAccentTextColor = Color.Empty;
            btn_entradas.Size = new Size(277, 53);
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
            btn_clientes.Icon = null;
            btn_clientes.Location = new Point(66, 124);
            btn_clientes.Margin = new Padding(4, 6, 4, 6);
            btn_clientes.MouseState = MaterialSkin.MouseState.HOVER;
            btn_clientes.Name = "btn_clientes";
            btn_clientes.NoAccentTextColor = Color.Empty;
            btn_clientes.Size = new Size(277, 53);
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
            btn_producto.Icon = null;
            btn_producto.Location = new Point(66, 65);
            btn_producto.Margin = new Padding(4, 6, 4, 6);
            btn_producto.MouseState = MaterialSkin.MouseState.HOVER;
            btn_producto.Name = "btn_producto";
            btn_producto.NoAccentTextColor = Color.Empty;
            btn_producto.Size = new Size(277, 53);
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
            btn_prov.Icon = null;
            btn_prov.Location = new Point(66, 6);
            btn_prov.Margin = new Padding(4, 6, 4, 6);
            btn_prov.MouseState = MaterialSkin.MouseState.HOVER;
            btn_prov.Name = "btn_prov";
            btn_prov.NoAccentTextColor = Color.Empty;
            btn_prov.Size = new Size(277, 53);
            btn_prov.TabIndex = 31;
            btn_prov.Text = "Proveedores";
            btn_prov.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_prov.UseAccentColor = false;
            btn_prov.UseVisualStyleBackColor = true;
            btn_prov.Click += btn_prov_Click;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.Transparent;
            iconPictureBox6.ForeColor = SystemColors.ControlText;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Cube;
            iconPictureBox6.IconColor = SystemColors.ControlText;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 53;
            iconPictureBox6.Location = new Point(6, 304);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(62, 53);
            iconPictureBox6.TabIndex = 30;
            iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.Transparent;
            iconPictureBox5.ForeColor = SystemColors.ControlText;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            iconPictureBox5.IconColor = SystemColors.ControlText;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 53;
            iconPictureBox5.Location = new Point(6, 245);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(62, 53);
            iconPictureBox5.TabIndex = 29;
            iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Transparent;
            iconPictureBox4.ForeColor = SystemColors.ControlText;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            iconPictureBox4.IconColor = SystemColors.ControlText;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 53;
            iconPictureBox4.Location = new Point(6, 183);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(62, 53);
            iconPictureBox4.TabIndex = 28;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Transparent;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 53;
            iconPictureBox3.Location = new Point(6, 123);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(62, 53);
            iconPictureBox3.TabIndex = 27;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 53;
            iconPictureBox2.Location = new Point(6, 65);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(62, 53);
            iconPictureBox2.TabIndex = 26;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 53;
            iconPictureBox1.Location = new Point(6, 6);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(62, 53);
            iconPictureBox1.TabIndex = 25;
            iconPictureBox1.TabStop = false;
            // 
            // tabContabilidad
            // 
            tabContabilidad.Controls.Add(btn_contabilidad);
            tabContabilidad.Location = new Point(4, 24);
            tabContabilidad.Name = "tabContabilidad";
            tabContabilidad.Size = new Size(577, 500);
            tabContabilidad.TabIndex = 2;
            tabContabilidad.Text = "Contabilidad";
            tabContabilidad.UseVisualStyleBackColor = true;
            // 
            // tabUsuarios
            // 
            tabUsuarios.Location = new Point(4, 24);
            tabUsuarios.Name = "tabUsuarios";
            tabUsuarios.Size = new Size(577, 500);
            tabUsuarios.TabIndex = 3;
            tabUsuarios.Text = "Usuarios";
            tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // tabConfiguracion
            // 
            tabConfiguracion.Controls.Add(msModoOscuro);
            tabConfiguracion.Location = new Point(4, 24);
            tabConfiguracion.Name = "tabConfiguracion";
            tabConfiguracion.Size = new Size(577, 500);
            tabConfiguracion.TabIndex = 4;
            tabConfiguracion.Text = "Configuración";
            tabConfiguracion.UseVisualStyleBackColor = true;
            // 
            // msModoOscuro
            // 
            msModoOscuro.AutoSize = true;
            msModoOscuro.Depth = 0;
            msModoOscuro.Location = new Point(13, 10);
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
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 89);
            ClientSize = new Size(597, 601);
            Controls.Add(mtcMenu);
            DrawerTabControl = mtcMenu;
            Name = "Menu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Menu :.";
            mtcMenu.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabFacturacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            tabContabilidad.ResumeLayout(false);
            tabConfiguracion.ResumeLayout(false);
            tabConfiguracion.PerformLayout();
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
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MaterialSkin.Controls.MaterialButton btn_stock;
        private MaterialSkin.Controls.MaterialButton btn_salidas;
        private MaterialSkin.Controls.MaterialButton btn_entradas;
        private MaterialSkin.Controls.MaterialButton btn_clientes;
        private MaterialSkin.Controls.MaterialButton btn_producto;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private PictureBox pictureBox1;
    }
}