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
            lbl_usuario = new Label();
            panel1 = new Panel();
            btn_salir = new Button();
            panel_facturacion = new Panel();
            btn_fichaStock = new FontAwesome.Sharp.IconButton();
            btn_volver = new FontAwesome.Sharp.IconButton();
            btn_entradas = new FontAwesome.Sharp.IconButton();
            btn_clientes = new FontAwesome.Sharp.IconButton();
            btn_salidas = new FontAwesome.Sharp.IconButton();
            btn_productos = new FontAwesome.Sharp.IconButton();
            btn_proveedores = new FontAwesome.Sharp.IconButton();
            btn_facturacion = new FontAwesome.Sharp.IconButton();
            btn_contabilidad = new FontAwesome.Sharp.IconButton();
            btn_usuarios = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel_facturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_usuario.ForeColor = SystemColors.ButtonFace;
            lbl_usuario.Location = new Point(4, 96);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(0, 15);
            lbl_usuario.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(82, 82, 89);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 93);
            panel1.TabIndex = 2;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Firebrick;
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salir.ForeColor = Color.FromArgb(254, 252, 230);
            btn_salir.Location = new Point(478, 557);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(107, 32);
            btn_salir.TabIndex = 11;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // panel_facturacion
            // 
            panel_facturacion.Controls.Add(btn_fichaStock);
            panel_facturacion.Controls.Add(btn_volver);
            panel_facturacion.Controls.Add(btn_entradas);
            panel_facturacion.Controls.Add(btn_clientes);
            panel_facturacion.Controls.Add(btn_salidas);
            panel_facturacion.Controls.Add(btn_productos);
            panel_facturacion.Controls.Add(btn_proveedores);
            panel_facturacion.Location = new Point(12, 187);
            panel_facturacion.Name = "panel_facturacion";
            panel_facturacion.Size = new Size(185, 402);
            panel_facturacion.TabIndex = 15;
            panel_facturacion.Visible = false;
            // 
            // btn_fichaStock
            // 
            btn_fichaStock.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_fichaStock.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            btn_fichaStock.IconColor = Color.DimGray;
            btn_fichaStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_fichaStock.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fichaStock.Location = new Point(3, 289);
            btn_fichaStock.Name = "btn_fichaStock";
            btn_fichaStock.Size = new Size(179, 57);
            btn_fichaStock.TabIndex = 24;
            btn_fichaStock.Text = "Ficha de Stock";
            btn_fichaStock.TextAlign = ContentAlignment.MiddleRight;
            btn_fichaStock.UseVisualStyleBackColor = true;
            btn_fichaStock.Click += btn_fichaStock_Click;
            // 
            // btn_volver
            // 
            btn_volver.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_volver.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            btn_volver.IconColor = Color.DimGray;
            btn_volver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_volver.IconSize = 25;
            btn_volver.ImageAlign = ContentAlignment.MiddleLeft;
            btn_volver.Location = new Point(0, 357);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(97, 42);
            btn_volver.TabIndex = 19;
            btn_volver.Text = "Volver";
            btn_volver.TextAlign = ContentAlignment.MiddleRight;
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // btn_entradas
            // 
            btn_entradas.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_entradas.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            btn_entradas.IconColor = Color.DimGray;
            btn_entradas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_entradas.ImageAlign = ContentAlignment.MiddleLeft;
            btn_entradas.Location = new Point(3, 175);
            btn_entradas.Name = "btn_entradas";
            btn_entradas.Size = new Size(179, 57);
            btn_entradas.TabIndex = 21;
            btn_entradas.Text = "Entradas";
            btn_entradas.TextAlign = ContentAlignment.MiddleRight;
            btn_entradas.UseVisualStyleBackColor = true;
            btn_entradas.Click += btn_entradas_Click;
            // 
            // btn_clientes
            // 
            btn_clientes.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_clientes.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            btn_clientes.IconColor = Color.DimGray;
            btn_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_clientes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clientes.Location = new Point(3, 118);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(179, 57);
            btn_clientes.TabIndex = 22;
            btn_clientes.Text = "Clientes";
            btn_clientes.TextAlign = ContentAlignment.MiddleRight;
            btn_clientes.UseVisualStyleBackColor = true;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // btn_salidas
            // 
            btn_salidas.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salidas.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            btn_salidas.IconColor = Color.DimGray;
            btn_salidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_salidas.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salidas.Location = new Point(3, 232);
            btn_salidas.Name = "btn_salidas";
            btn_salidas.Size = new Size(179, 57);
            btn_salidas.TabIndex = 23;
            btn_salidas.Text = "Salidas";
            btn_salidas.TextAlign = ContentAlignment.MiddleRight;
            btn_salidas.UseVisualStyleBackColor = true;
            btn_salidas.Click += btn_salidas_Click;
            // 
            // btn_productos
            // 
            btn_productos.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_productos.IconChar = FontAwesome.Sharp.IconChar.Cube;
            btn_productos.IconColor = Color.DimGray;
            btn_productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_productos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_productos.Location = new Point(3, 61);
            btn_productos.Name = "btn_productos";
            btn_productos.Size = new Size(179, 57);
            btn_productos.TabIndex = 20;
            btn_productos.Text = "Productos";
            btn_productos.TextAlign = ContentAlignment.MiddleRight;
            btn_productos.UseVisualStyleBackColor = true;
            btn_productos.Click += btn_productos_Click;
            // 
            // btn_proveedores
            // 
            btn_proveedores.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_proveedores.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            btn_proveedores.IconColor = Color.DimGray;
            btn_proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_proveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btn_proveedores.Location = new Point(3, 3);
            btn_proveedores.Name = "btn_proveedores";
            btn_proveedores.Size = new Size(179, 57);
            btn_proveedores.TabIndex = 19;
            btn_proveedores.Text = "Proveedores";
            btn_proveedores.TextAlign = ContentAlignment.MiddleRight;
            btn_proveedores.UseVisualStyleBackColor = true;
            btn_proveedores.Click += btn_proveedores_Click;
            // 
            // btn_facturacion
            // 
            btn_facturacion.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_facturacion.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btn_facturacion.IconColor = Color.DimGray;
            btn_facturacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_facturacion.ImageAlign = ContentAlignment.MiddleLeft;
            btn_facturacion.Location = new Point(12, 121);
            btn_facturacion.Name = "btn_facturacion";
            btn_facturacion.Size = new Size(185, 60);
            btn_facturacion.TabIndex = 16;
            btn_facturacion.Text = "Facturación";
            btn_facturacion.TextAlign = ContentAlignment.MiddleRight;
            btn_facturacion.UseVisualStyleBackColor = true;
            btn_facturacion.Click += btn_facturacion_Click;
            // 
            // btn_contabilidad
            // 
            btn_contabilidad.Enabled = false;
            btn_contabilidad.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_contabilidad.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            btn_contabilidad.IconColor = Color.DimGray;
            btn_contabilidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_contabilidad.ImageAlign = ContentAlignment.MiddleLeft;
            btn_contabilidad.Location = new Point(203, 121);
            btn_contabilidad.Name = "btn_contabilidad";
            btn_contabilidad.Size = new Size(211, 60);
            btn_contabilidad.TabIndex = 17;
            btn_contabilidad.Text = "Contabilidad";
            btn_contabilidad.TextAlign = ContentAlignment.MiddleRight;
            btn_contabilidad.UseVisualStyleBackColor = true;
            // 
            // btn_usuarios
            // 
            btn_usuarios.Enabled = false;
            btn_usuarios.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_usuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            btn_usuarios.IconColor = Color.DimGray;
            btn_usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_usuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btn_usuarios.Location = new Point(420, 121);
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Size = new Size(165, 60);
            btn_usuarios.TabIndex = 18;
            btn_usuarios.Text = "Usuarios";
            btn_usuarios.TextAlign = ContentAlignment.MiddleRight;
            btn_usuarios.UseVisualStyleBackColor = true;
            btn_usuarios.Click += btn_usuarios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(597, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 89);
            ClientSize = new Size(597, 601);
            ControlBox = false;
            Controls.Add(btn_usuarios);
            Controls.Add(btn_contabilidad);
            Controls.Add(btn_facturacion);
            Controls.Add(panel_facturacion);
            Controls.Add(btn_salir);
            Controls.Add(panel1);
            Controls.Add(lbl_usuario);
            Name = "Menu";
            Opacity = 0.98D;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Menu :.";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_facturacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_usuario;
        private Panel panel1;
        private Button btn_salir;
        private Panel panel_facturacion;
        private FontAwesome.Sharp.IconButton btn_facturacion;
        private FontAwesome.Sharp.IconButton btn_contabilidad;
        private FontAwesome.Sharp.IconButton btn_usuarios;
        private FontAwesome.Sharp.IconButton btn_salidas;
        private FontAwesome.Sharp.IconButton btn_proveedores;
        private FontAwesome.Sharp.IconButton btn_productos;
        private FontAwesome.Sharp.IconButton btn_clientes;
        private FontAwesome.Sharp.IconButton btn_entradas;
        private FontAwesome.Sharp.IconButton btn_volver;
        private FontAwesome.Sharp.IconButton btn_fichaStock;
        private PictureBox pictureBox1;
    }
}