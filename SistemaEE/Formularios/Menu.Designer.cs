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
            pictureBox1 = new PictureBox();
            btn_salir = new Button();
            btn_usuarios = new Button();
            btn_contabilidad = new Button();
            btn_facturacion = new Button();
            panel_facturacion = new Panel();
            btn_salida = new Button();
            btn_entradas = new Button();
            btn_atras = new Button();
            btn_proveedores = new Button();
            btn_productos = new Button();
            btn_cliente = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_facturacion.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_usuario.ForeColor = SystemColors.ButtonFace;
            lbl_usuario.Location = new Point(12, 203);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(0, 15);
            lbl_usuario.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 200);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Firebrick;
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salir.ForeColor = Color.FromArgb(254, 252, 230);
            btn_salir.Location = new Point(478, 508);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(107, 32);
            btn_salir.TabIndex = 11;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_usuarios
            // 
            btn_usuarios.BackColor = Color.SteelBlue;
            btn_usuarios.Cursor = Cursors.Hand;
            btn_usuarios.FlatAppearance.BorderSize = 0;
            btn_usuarios.FlatStyle = FlatStyle.Flat;
            btn_usuarios.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_usuarios.ForeColor = Color.FromArgb(254, 252, 230);
            btn_usuarios.Location = new Point(238, 252);
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Size = new Size(107, 79);
            btn_usuarios.TabIndex = 12;
            btn_usuarios.Text = "Usuarios";
            btn_usuarios.UseVisualStyleBackColor = false;
            btn_usuarios.Click += btn_usuarios_Click;
            // 
            // btn_contabilidad
            // 
            btn_contabilidad.BackColor = Color.SteelBlue;
            btn_contabilidad.Cursor = Cursors.Hand;
            btn_contabilidad.FlatAppearance.BorderSize = 0;
            btn_contabilidad.FlatStyle = FlatStyle.Flat;
            btn_contabilidad.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_contabilidad.ForeColor = Color.FromArgb(254, 252, 230);
            btn_contabilidad.Location = new Point(125, 252);
            btn_contabilidad.Name = "btn_contabilidad";
            btn_contabilidad.Size = new Size(107, 79);
            btn_contabilidad.TabIndex = 13;
            btn_contabilidad.Text = "Contabilidad";
            btn_contabilidad.UseVisualStyleBackColor = false;
            btn_contabilidad.Click += btn_contabilidad_Click;
            // 
            // btn_facturacion
            // 
            btn_facturacion.BackColor = Color.SteelBlue;
            btn_facturacion.Cursor = Cursors.Hand;
            btn_facturacion.FlatAppearance.BorderSize = 0;
            btn_facturacion.FlatStyle = FlatStyle.Flat;
            btn_facturacion.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_facturacion.ForeColor = Color.FromArgb(254, 252, 230);
            btn_facturacion.Location = new Point(12, 252);
            btn_facturacion.Name = "btn_facturacion";
            btn_facturacion.Size = new Size(107, 79);
            btn_facturacion.TabIndex = 14;
            btn_facturacion.Text = "Facturación";
            btn_facturacion.UseVisualStyleBackColor = false;
            btn_facturacion.Click += btn_facturacion_Click;
            // 
            // panel_facturacion
            // 
            panel_facturacion.Controls.Add(btn_salida);
            panel_facturacion.Controls.Add(btn_entradas);
            panel_facturacion.Controls.Add(btn_atras);
            panel_facturacion.Controls.Add(btn_proveedores);
            panel_facturacion.Controls.Add(btn_productos);
            panel_facturacion.Controls.Add(btn_cliente);
            panel_facturacion.Location = new Point(12, 346);
            panel_facturacion.Name = "panel_facturacion";
            panel_facturacion.Size = new Size(460, 190);
            panel_facturacion.TabIndex = 15;
            panel_facturacion.Visible = false;
            // 
            // btn_salida
            // 
            btn_salida.BackColor = Color.SteelBlue;
            btn_salida.Cursor = Cursors.Hand;
            btn_salida.FlatAppearance.BorderSize = 0;
            btn_salida.FlatStyle = FlatStyle.Flat;
            btn_salida.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salida.ForeColor = Color.FromArgb(254, 252, 230);
            btn_salida.Location = new Point(283, 43);
            btn_salida.Name = "btn_salida";
            btn_salida.Size = new Size(80, 57);
            btn_salida.TabIndex = 14;
            btn_salida.Text = "Salidas";
            btn_salida.UseVisualStyleBackColor = false;
            // 
            // btn_entradas
            // 
            btn_entradas.BackColor = Color.SteelBlue;
            btn_entradas.Cursor = Cursors.Hand;
            btn_entradas.FlatAppearance.BorderSize = 0;
            btn_entradas.FlatStyle = FlatStyle.Flat;
            btn_entradas.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_entradas.ForeColor = Color.FromArgb(254, 252, 230);
            btn_entradas.Location = new Point(191, 42);
            btn_entradas.Name = "btn_entradas";
            btn_entradas.Size = new Size(80, 57);
            btn_entradas.TabIndex = 13;
            btn_entradas.Text = "Entradas";
            btn_entradas.UseVisualStyleBackColor = false;
            btn_entradas.Click += btn_entradas_Click;
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Olive;
            btn_atras.Cursor = Cursors.Hand;
            btn_atras.FlatAppearance.BorderSize = 0;
            btn_atras.FlatStyle = FlatStyle.Flat;
            btn_atras.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_atras.ForeColor = Color.Black;
            btn_atras.Location = new Point(3, 155);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(107, 32);
            btn_atras.TabIndex = 12;
            btn_atras.Text = "Salir";
            btn_atras.UseVisualStyleBackColor = false;
            btn_atras.Click += btn_atras_Click;
            // 
            // btn_proveedores
            // 
            btn_proveedores.BackColor = Color.SteelBlue;
            btn_proveedores.Cursor = Cursors.Hand;
            btn_proveedores.FlatAppearance.BorderSize = 0;
            btn_proveedores.FlatStyle = FlatStyle.Flat;
            btn_proveedores.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_proveedores.ForeColor = Color.FromArgb(254, 252, 230);
            btn_proveedores.Location = new Point(323, 130);
            btn_proveedores.Name = "btn_proveedores";
            btn_proveedores.Size = new Size(114, 57);
            btn_proveedores.TabIndex = 10;
            btn_proveedores.Text = "Proveedores";
            btn_proveedores.UseVisualStyleBackColor = false;
            btn_proveedores.Click += btn_proveedores_Click;
            // 
            // btn_productos
            // 
            btn_productos.BackColor = Color.SteelBlue;
            btn_productos.Cursor = Cursors.Hand;
            btn_productos.FlatAppearance.BorderSize = 0;
            btn_productos.FlatStyle = FlatStyle.Flat;
            btn_productos.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_productos.ForeColor = Color.FromArgb(254, 252, 230);
            btn_productos.Location = new Point(226, 130);
            btn_productos.Name = "btn_productos";
            btn_productos.Size = new Size(91, 57);
            btn_productos.TabIndex = 9;
            btn_productos.Text = "Productos";
            btn_productos.UseVisualStyleBackColor = false;
            btn_productos.Click += btn_productos_Click;
            // 
            // btn_cliente
            // 
            btn_cliente.BackColor = Color.SteelBlue;
            btn_cliente.Cursor = Cursors.Hand;
            btn_cliente.FlatAppearance.BorderSize = 0;
            btn_cliente.FlatStyle = FlatStyle.Flat;
            btn_cliente.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cliente.ForeColor = Color.FromArgb(254, 252, 230);
            btn_cliente.Location = new Point(130, 130);
            btn_cliente.Name = "btn_cliente";
            btn_cliente.Size = new Size(90, 57);
            btn_cliente.TabIndex = 8;
            btn_cliente.Text = "Cliente";
            btn_cliente.UseVisualStyleBackColor = false;
            btn_cliente.Click += btn_cliente_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 89);
            ClientSize = new Size(597, 548);
            ControlBox = false;
            Controls.Add(panel_facturacion);
            Controls.Add(btn_facturacion);
            Controls.Add(btn_contabilidad);
            Controls.Add(btn_usuarios);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_facturacion.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_usuario;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_salir;
        private Button btn_usuarios;
        private Button btn_contabilidad;
        private Button btn_facturacion;
        private Panel panel_facturacion;
        private Button btn_atras;
        private Button btn_proveedores;
        private Button btn_productos;
        private Button btn_cliente;
        private Button btn_salida;
        private Button btn_entradas;
    }
}