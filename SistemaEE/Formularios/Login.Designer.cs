namespace SistemaEE.Formularios
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            btn_ingresar = new Button();
            btn_salir = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_usuario = new TextBox();
            txt_clave = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-21, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 284);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.SteelBlue;
            btn_ingresar.Cursor = Cursors.Hand;
            btn_ingresar.FlatAppearance.BorderSize = 0;
            btn_ingresar.FlatStyle = FlatStyle.Flat;
            btn_ingresar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ingresar.ForeColor = Color.FromArgb(254, 252, 230);
            btn_ingresar.Location = new Point(39, 454);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(107, 32);
            btn_ingresar.TabIndex = 1;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Firebrick;
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salir.ForeColor = Color.FromArgb(254, 252, 230);
            btn_salir.Location = new Point(152, 454);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(107, 32);
            btn_salir.TabIndex = 2;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(254, 252, 230);
            label1.Location = new Point(39, 320);
            label1.Name = "label1";
            label1.Size = new Size(69, 19);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(254, 252, 230);
            label2.Location = new Point(39, 377);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.Location = new Point(39, 342);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(220, 27);
            txt_usuario.TabIndex = 5;
            // 
            // txt_clave
            // 
            txt_clave.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_clave.Location = new Point(39, 399);
            txt_clave.Name = "txt_clave";
            txt_clave.PasswordChar = '*';
            txt_clave.Size = new Size(220, 27);
            txt_clave.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 82, 89);
            ClientSize = new Size(284, 516);
            ControlBox = false;
            Controls.Add(txt_clave);
            Controls.Add(txt_usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_salir);
            Controls.Add(btn_ingresar);
            Controls.Add(pictureBox1);
            Name = "Login";
            Opacity = 0.96D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Login :.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_ingresar;
        private Button btn_salir;
        private Label label1;
        private Label label2;
        public TextBox txt_usuario;
        public TextBox txt_clave;
    }
}