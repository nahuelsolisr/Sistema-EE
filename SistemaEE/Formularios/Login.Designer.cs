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
            label1 = new Label();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            btn_eye = new FontAwesome.Sharp.IconPictureBox();
            txt_usuario = new MaterialSkin.Controls.MaterialTextBox();
            txt_clave = new MaterialSkin.Controls.MaterialTextBox();
            btn_ingresar = new MaterialSkin.Controls.MaterialButton();
            msModoOscuro = new MaterialSkin.Controls.MaterialSwitch();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_eye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-8, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(254, 252, 230);
            label1.Location = new Point(58, 302);
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
            label2.Location = new Point(58, 377);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(82, 82, 89);
            iconPictureBox1.ForeColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox1.IconColor = Color.SteelBlue;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 46;
            iconPictureBox1.Location = new Point(9, 331);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(46, 50);
            iconPictureBox1.TabIndex = 135;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(82, 82, 89);
            iconPictureBox2.ForeColor = Color.SteelBlue;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = Color.SteelBlue;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 46;
            iconPictureBox2.Location = new Point(9, 405);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(46, 50);
            iconPictureBox2.TabIndex = 136;
            iconPictureBox2.TabStop = false;
            // 
            // btn_eye
            // 
            btn_eye.BackColor = Color.FromArgb(82, 82, 89);
            btn_eye.ForeColor = Color.SteelBlue;
            btn_eye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btn_eye.IconColor = Color.SteelBlue;
            btn_eye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_eye.IconSize = 36;
            btn_eye.Location = new Point(267, 408);
            btn_eye.Name = "btn_eye";
            btn_eye.Size = new Size(36, 41);
            btn_eye.TabIndex = 137;
            btn_eye.TabStop = false;
            btn_eye.Click += btn_eye_Click;
            // 
            // txt_usuario
            // 
            txt_usuario.AnimateReadOnly = false;
            txt_usuario.BorderStyle = BorderStyle.None;
            txt_usuario.Depth = 0;
            txt_usuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_usuario.LeadingIcon = null;
            txt_usuario.Location = new Point(58, 324);
            txt_usuario.MaxLength = 50;
            txt_usuario.MouseState = MaterialSkin.MouseState.OUT;
            txt_usuario.Multiline = false;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(203, 50);
            txt_usuario.TabIndex = 138;
            txt_usuario.Text = "";
            txt_usuario.TrailingIcon = null;
            // 
            // txt_clave
            // 
            txt_clave.AnimateReadOnly = false;
            txt_clave.BorderStyle = BorderStyle.None;
            txt_clave.Depth = 0;
            txt_clave.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_clave.LeadingIcon = null;
            txt_clave.Location = new Point(57, 399);
            txt_clave.MaxLength = 50;
            txt_clave.MouseState = MaterialSkin.MouseState.OUT;
            txt_clave.Multiline = false;
            txt_clave.Name = "txt_clave";
            txt_clave.Size = new Size(204, 50);
            txt_clave.TabIndex = 139;
            txt_clave.Text = "";
            txt_clave.TrailingIcon = null;
            // 
            // btn_ingresar
            // 
            btn_ingresar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_ingresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_ingresar.Depth = 0;
            btn_ingresar.HighEmphasis = true;
            btn_ingresar.Icon = null;
            btn_ingresar.Location = new Point(170, 490);
            btn_ingresar.Margin = new Padding(4, 6, 4, 6);
            btn_ingresar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.NoAccentTextColor = Color.Empty;
            btn_ingresar.Size = new Size(91, 36);
            btn_ingresar.TabIndex = 140;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_ingresar.UseAccentColor = false;
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // msModoOscuro
            // 
            msModoOscuro.Depth = 0;
            msModoOscuro.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            msModoOscuro.Location = new Point(248, 31);
            msModoOscuro.Margin = new Padding(0);
            msModoOscuro.MouseLocation = new Point(-1, -1);
            msModoOscuro.MouseState = MaterialSkin.MouseState.HOVER;
            msModoOscuro.Name = "msModoOscuro";
            msModoOscuro.Ripple = true;
            msModoOscuro.Size = new Size(55, 25);
            msModoOscuro.TabIndex = 141;
            msModoOscuro.UseVisualStyleBackColor = true;
            msModoOscuro.CheckedChanged += msModoOscuro_CheckedChanged;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.White;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Moon;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 25;
            iconPictureBox3.Location = new Point(213, 31);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(32, 25);
            iconPictureBox3.TabIndex = 142;
            iconPictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(309, 535);
            Controls.Add(iconPictureBox3);
            Controls.Add(msModoOscuro);
            Controls.Add(btn_ingresar);
            Controls.Add(txt_clave);
            Controls.Add(txt_usuario);
            Controls.Add(btn_eye);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Opacity = 0.96D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Inicio de sesión :.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_eye).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_salir;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox btn_eye;
        private MaterialSkin.Controls.MaterialTextBox txt_usuario;
        private MaterialSkin.Controls.MaterialTextBox txt_clave;
        private MaterialSkin.Controls.MaterialButton btn_ingresar;
        private MaterialSkin.Controls.MaterialSwitch msModoOscuro;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
    }
}