namespace SistemaEE.Formularios
{
    partial class Usuarios
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            dgvUsuarios = new DataGridView();
            Column0 = new DataGridViewTextBoxColumn();
            btn_seleccionar = new DataGridViewButtonColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            pnl_detalle = new Panel();
            iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            txt_nombre = new MaterialSkin.Controls.MaterialTextBox();
            iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            btn_editar = new MaterialSkin.Controls.MaterialButton();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            btn_eliminar = new MaterialSkin.Controls.MaterialButton();
            btn_agregar = new MaterialSkin.Controls.MaterialButton();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            txt_tipoUsuario = new MaterialSkin.Controls.MaterialTextBox();
            txt_contraseña = new MaterialSkin.Controls.MaterialTextBox();
            panel1 = new Panel();
            txt_filtrar = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            pnl_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.WhiteSmoke;
            iconPictureBox6.ForeColor = SystemColors.ControlText;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox6.IconColor = SystemColors.ControlText;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 48;
            iconPictureBox6.Location = new Point(5, 27);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(48, 50);
            iconPictureBox6.TabIndex = 170;
            iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.WhiteSmoke;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 50;
            iconPictureBox3.Location = new Point(5, 107);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(53, 50);
            iconPictureBox3.TabIndex = 168;
            iconPictureBox3.TabStop = false;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToResizeColumns = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsuarios.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Column0, btn_seleccionar, Column1, Column2, Column3 });
            dgvUsuarios.Location = new Point(387, 128);
            dgvUsuarios.Margin = new Padding(4);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = Color.Transparent;
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(614, 401);
            dgvUsuarios.TabIndex = 159;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // Column0
            // 
            Column0.HeaderText = "Id";
            Column0.Name = "Column0";
            Column0.ReadOnly = true;
            Column0.Visible = false;
            Column0.Width = 34;
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.HeaderText = "";
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.ReadOnly = true;
            btn_seleccionar.Resizable = DataGridViewTriState.False;
            btn_seleccionar.Width = 25;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 95;
            // 
            // Column2
            // 
            Column2.HeaderText = "Contraseña";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 117;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tipo";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 70;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.WhiteSmoke;
            iconPictureBox5.ForeColor = SystemColors.ControlText;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            iconPictureBox5.IconColor = SystemColors.ControlText;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 50;
            iconPictureBox5.Location = new Point(5, 188);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(53, 50);
            iconPictureBox5.TabIndex = 169;
            iconPictureBox5.TabStop = false;
            // 
            // pnl_detalle
            // 
            pnl_detalle.Controls.Add(iconPictureBox9);
            pnl_detalle.Controls.Add(txt_nombre);
            pnl_detalle.Controls.Add(iconPictureBox8);
            pnl_detalle.Controls.Add(btn_editar);
            pnl_detalle.Controls.Add(iconPictureBox5);
            pnl_detalle.Controls.Add(iconPictureBox6);
            pnl_detalle.Controls.Add(iconPictureBox3);
            pnl_detalle.Controls.Add(iconPictureBox7);
            pnl_detalle.Controls.Add(btn_eliminar);
            pnl_detalle.Controls.Add(btn_agregar);
            pnl_detalle.Controls.Add(materialLabel5);
            pnl_detalle.Controls.Add(materialLabel4);
            pnl_detalle.Controls.Add(materialLabel3);
            pnl_detalle.Controls.Add(txt_tipoUsuario);
            pnl_detalle.Controls.Add(txt_contraseña);
            pnl_detalle.Location = new Point(12, 128);
            pnl_detalle.Name = "pnl_detalle";
            pnl_detalle.Size = new Size(368, 401);
            pnl_detalle.TabIndex = 177;
            // 
            // iconPictureBox9
            // 
            iconPictureBox9.BackColor = SystemColors.Control;
            iconPictureBox9.ForeColor = SystemColors.ControlText;
            iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            iconPictureBox9.IconColor = SystemColors.ControlText;
            iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox9.IconSize = 39;
            iconPictureBox9.Location = new Point(242, 362);
            iconPictureBox9.Name = "iconPictureBox9";
            iconPictureBox9.Size = new Size(39, 43);
            iconPictureBox9.TabIndex = 157;
            iconPictureBox9.TabStop = false;
            // 
            // txt_nombre
            // 
            txt_nombre.AnimateReadOnly = false;
            txt_nombre.BorderStyle = BorderStyle.None;
            txt_nombre.Depth = 0;
            txt_nombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_nombre.LeadingIcon = null;
            txt_nombre.Location = new Point(59, 27);
            txt_nombre.MaxLength = 50;
            txt_nombre.MouseState = MaterialSkin.MouseState.OUT;
            txt_nombre.Multiline = false;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(295, 50);
            txt_nombre.TabIndex = 145;
            txt_nombre.Text = "";
            txt_nombre.TrailingIcon = null;
            // 
            // iconPictureBox8
            // 
            iconPictureBox8.BackColor = SystemColors.Control;
            iconPictureBox8.ForeColor = SystemColors.ControlText;
            iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            iconPictureBox8.IconColor = SystemColors.ControlText;
            iconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox8.IconSize = 36;
            iconPictureBox8.Location = new Point(117, 362);
            iconPictureBox8.Name = "iconPictureBox8";
            iconPictureBox8.Size = new Size(39, 36);
            iconPictureBox8.TabIndex = 156;
            iconPictureBox8.TabStop = false;
            // 
            // btn_editar
            // 
            btn_editar.AutoSize = false;
            btn_editar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_editar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_editar.Depth = 0;
            btn_editar.HighEmphasis = true;
            btn_editar.Icon = null;
            btn_editar.Location = new Point(150, 362);
            btn_editar.Margin = new Padding(4, 6, 4, 6);
            btn_editar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_editar.Name = "btn_editar";
            btn_editar.NoAccentTextColor = Color.Empty;
            btn_editar.Size = new Size(89, 36);
            btn_editar.TabIndex = 158;
            btn_editar.Text = "Editar";
            btn_editar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_editar.UseAccentColor = false;
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.BackColor = SystemColors.Control;
            iconPictureBox7.ForeColor = SystemColors.ControlText;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            iconPictureBox7.IconColor = SystemColors.ControlText;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 36;
            iconPictureBox7.Location = new Point(5, 362);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(39, 36);
            iconPictureBox7.TabIndex = 155;
            iconPictureBox7.TabStop = false;
            // 
            // btn_eliminar
            // 
            btn_eliminar.AutoSize = false;
            btn_eliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_eliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_eliminar.Depth = 0;
            btn_eliminar.HighEmphasis = true;
            btn_eliminar.Icon = null;
            btn_eliminar.Location = new Point(278, 362);
            btn_eliminar.Margin = new Padding(4, 6, 4, 6);
            btn_eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.NoAccentTextColor = Color.Empty;
            btn_eliminar.Size = new Size(78, 36);
            btn_eliminar.TabIndex = 154;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_eliminar.UseAccentColor = false;
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.AutoSize = false;
            btn_agregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_agregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_agregar.Depth = 0;
            btn_agregar.HighEmphasis = true;
            btn_agregar.Icon = null;
            btn_agregar.Location = new Point(37, 362);
            btn_agregar.Margin = new Padding(4, 6, 4, 6);
            btn_agregar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_agregar.Name = "btn_agregar";
            btn_agregar.NoAccentTextColor = Color.Empty;
            btn_agregar.Size = new Size(78, 36);
            btn_agregar.TabIndex = 152;
            btn_agregar.Text = "Agregar";
            btn_agregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_agregar.UseAccentColor = false;
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(59, 166);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(133, 19);
            materialLabel5.TabIndex = 161;
            materialLabel5.Text = "TIPO DE USUARIO:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(64, 85);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(107, 19);
            materialLabel4.TabIndex = 160;
            materialLabel4.Text = "CONTRASEÑA:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(59, 5);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(70, 19);
            materialLabel3.TabIndex = 159;
            materialLabel3.Text = "NOMBRE:";
            // 
            // txt_tipoUsuario
            // 
            txt_tipoUsuario.AnimateReadOnly = false;
            txt_tipoUsuario.BorderStyle = BorderStyle.None;
            txt_tipoUsuario.Depth = 0;
            txt_tipoUsuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_tipoUsuario.LeadingIcon = null;
            txt_tipoUsuario.Location = new Point(59, 188);
            txt_tipoUsuario.MaxLength = 50;
            txt_tipoUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txt_tipoUsuario.Multiline = false;
            txt_tipoUsuario.Name = "txt_tipoUsuario";
            txt_tipoUsuario.Size = new Size(295, 50);
            txt_tipoUsuario.TabIndex = 148;
            txt_tipoUsuario.Text = "";
            txt_tipoUsuario.TrailingIcon = null;
            // 
            // txt_contraseña
            // 
            txt_contraseña.AnimateReadOnly = false;
            txt_contraseña.BorderStyle = BorderStyle.None;
            txt_contraseña.Depth = 0;
            txt_contraseña.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_contraseña.LeadingIcon = null;
            txt_contraseña.Location = new Point(58, 107);
            txt_contraseña.MaxLength = 50;
            txt_contraseña.MouseState = MaterialSkin.MouseState.OUT;
            txt_contraseña.Multiline = false;
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.Size = new Size(295, 50);
            txt_contraseña.TabIndex = 149;
            txt_contraseña.Text = "";
            txt_contraseña.TrailingIcon = null;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_filtrar);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(10, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 54);
            panel1.TabIndex = 178;
            // 
            // txt_filtrar
            // 
            txt_filtrar.AnimateReadOnly = false;
            txt_filtrar.BorderStyle = BorderStyle.None;
            txt_filtrar.Depth = 0;
            txt_filtrar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_filtrar.LeadingIcon = null;
            txt_filtrar.Location = new Point(612, 4);
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
            materialLabel1.Size = new Size(170, 19);
            materialLabel1.TabIndex = 150;
            materialLabel1.Text = "DETALLE DEL USUARIO";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(375, 5);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(147, 19);
            materialLabel2.TabIndex = 151;
            materialLabel2.Text = "LISTA DE USUARIOS";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 48;
            iconPictureBox1.Location = new Point(934, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(53, 48);
            iconPictureBox1.TabIndex = 141;
            iconPictureBox1.TabStop = false;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 537);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(pnl_detalle);
            Controls.Add(dgvUsuarios);
            Name = "Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".: Usuarios :.";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            pnl_detalle.ResumeLayout(false);
            pnl_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private DataGridView dgvUsuarios;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewButtonColumn btn_seleccionar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel pnl_detalle;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private MaterialSkin.Controls.MaterialButton btn_editar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private MaterialSkin.Controls.MaterialButton btn_eliminar;
        private MaterialSkin.Controls.MaterialButton btn_agregar;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txt_tipoUsuario;
        private MaterialSkin.Controls.MaterialTextBox txt_contraseña;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txt_filtrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}