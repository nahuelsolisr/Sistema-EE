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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            groupBox1 = new GroupBox();
            btn_salir = new FontAwesome.Sharp.IconButton();
            btn_baja = new FontAwesome.Sharp.IconButton();
            btn_alta = new FontAwesome.Sharp.IconButton();
            btn_modi = new FontAwesome.Sharp.IconButton();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            txt_filtrarGrilla = new TextBox();
            txt_tipoUsuario = new TextBox();
            label4 = new Label();
            dgvUsuarios = new DataGridView();
            Column0 = new DataGridViewTextBoxColumn();
            btn_seleccionar = new DataGridViewButtonColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            txt_contraseña = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            txt_nombre = new TextBox();
            label1 = new Label();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            SuspendLayout();
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.WhiteSmoke;
            iconPictureBox4.ForeColor = SystemColors.ControlText;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox4.IconColor = SystemColors.ControlText;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 36;
            iconPictureBox4.Location = new Point(985, 48);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(42, 36);
            iconPictureBox4.TabIndex = 176;
            iconPictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(271, 9);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(27, 579);
            groupBox1.TabIndex = 175;
            groupBox1.TabStop = false;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salir.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            btn_salir.IconColor = Color.Black;
            btn_salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_salir.IconSize = 25;
            btn_salir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salir.Location = new Point(17, 550);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(118, 42);
            btn_salir.TabIndex = 174;
            btn_salir.Text = "Salir";
            btn_salir.TextAlign = ContentAlignment.MiddleRight;
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_baja
            // 
            btn_baja.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_baja.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            btn_baja.IconColor = Color.Black;
            btn_baja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_baja.ImageAlign = ContentAlignment.MiddleLeft;
            btn_baja.Location = new Point(16, 424);
            btn_baja.Name = "btn_baja";
            btn_baja.Size = new Size(248, 55);
            btn_baja.TabIndex = 173;
            btn_baja.Text = "Eliminar";
            btn_baja.TextAlign = ContentAlignment.MiddleRight;
            btn_baja.UseVisualStyleBackColor = true;
            btn_baja.Click += btn_baja_Click;
            // 
            // btn_alta
            // 
            btn_alta.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_alta.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btn_alta.IconColor = Color.Black;
            btn_alta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_alta.ImageAlign = ContentAlignment.MiddleLeft;
            btn_alta.Location = new Point(16, 363);
            btn_alta.Name = "btn_alta";
            btn_alta.Size = new Size(248, 55);
            btn_alta.TabIndex = 172;
            btn_alta.Text = "Agregar";
            btn_alta.TextAlign = ContentAlignment.MiddleRight;
            btn_alta.UseVisualStyleBackColor = true;
            btn_alta.Click += btn_alta_Click;
            // 
            // btn_modi
            // 
            btn_modi.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_modi.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btn_modi.IconColor = Color.Black;
            btn_modi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_modi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_modi.Location = new Point(16, 485);
            btn_modi.Name = "btn_modi";
            btn_modi.Size = new Size(248, 55);
            btn_modi.TabIndex = 171;
            btn_modi.Text = "Modificar";
            btn_modi.TextAlign = ContentAlignment.MiddleRight;
            btn_modi.UseVisualStyleBackColor = true;
            btn_modi.Click += btn_modi_Click;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.WhiteSmoke;
            iconPictureBox6.ForeColor = SystemColors.ControlText;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox6.IconColor = SystemColors.ControlText;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 27;
            iconPictureBox6.Location = new Point(16, 92);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(31, 27);
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
            iconPictureBox3.IconSize = 27;
            iconPictureBox3.Location = new Point(16, 148);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(31, 27);
            iconPictureBox3.TabIndex = 168;
            iconPictureBox3.TabStop = false;
            // 
            // txt_filtrarGrilla
            // 
            txt_filtrarGrilla.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_filtrarGrilla.Location = new Point(660, 48);
            txt_filtrarGrilla.Margin = new Padding(4);
            txt_filtrarGrilla.Name = "txt_filtrarGrilla";
            txt_filtrarGrilla.Size = new Size(318, 36);
            txt_filtrarGrilla.TabIndex = 165;
            txt_filtrarGrilla.TextChanged += txt_filtrarGrilla_TextChanged;
            // 
            // txt_tipoUsuario
            // 
            txt_tipoUsuario.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tipoUsuario.Location = new Point(47, 204);
            txt_tipoUsuario.Margin = new Padding(4);
            txt_tipoUsuario.Name = "txt_tipoUsuario";
            txt_tipoUsuario.Size = new Size(216, 27);
            txt_tipoUsuario.TabIndex = 161;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 181);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 19);
            label4.TabIndex = 160;
            label4.Text = "Tipo de usuario:";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToResizeColumns = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsuarios.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Column0, btn_seleccionar, Column1, Column2, Column3 });
            dgvUsuarios.Location = new Point(306, 92);
            dgvUsuarios.Margin = new Padding(4);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(725, 482);
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
            // txt_contraseña
            // 
            txt_contraseña.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_contraseña.Location = new Point(47, 148);
            txt_contraseña.Margin = new Padding(4);
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.Size = new Size(216, 27);
            txt_contraseña.TabIndex = 158;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 126);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 19);
            label2.TabIndex = 157;
            label2.Text = "Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(306, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(162, 19);
            label6.TabIndex = 156;
            label6.Text = "LISTA DE USUARIOS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 9);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(183, 19);
            label5.TabIndex = 155;
            label5.Text = "DETALLE DEL USUARIO";
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(47, 92);
            txt_nombre.Margin = new Padding(4);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(216, 27);
            txt_nombre.TabIndex = 154;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 153;
            label1.Text = "Nombre";
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.WhiteSmoke;
            iconPictureBox5.ForeColor = SystemColors.ControlText;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            iconPictureBox5.IconColor = SystemColors.ControlText;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 27;
            iconPictureBox5.Location = new Point(16, 204);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(31, 27);
            iconPictureBox5.TabIndex = 169;
            iconPictureBox5.TabStop = false;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 601);
            ControlBox = false;
            Controls.Add(iconPictureBox4);
            Controls.Add(groupBox1);
            Controls.Add(btn_salir);
            Controls.Add(btn_baja);
            Controls.Add(btn_alta);
            Controls.Add(btn_modi);
            Controls.Add(iconPictureBox6);
            Controls.Add(iconPictureBox5);
            Controls.Add(iconPictureBox3);
            Controls.Add(txt_filtrarGrilla);
            Controls.Add(txt_tipoUsuario);
            Controls.Add(label4);
            Controls.Add(dgvUsuarios);
            Controls.Add(txt_contraseña);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Name = "Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btn_salir;
        private FontAwesome.Sharp.IconButton btn_baja;
        private FontAwesome.Sharp.IconButton btn_alta;
        private FontAwesome.Sharp.IconButton btn_modi;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private TextBox txt_filtrarGrilla;
        private TextBox txt_tipoUsuario;
        private Label label4;
        private DataGridView dgvUsuarios;
        private TextBox txt_contraseña;
        private Label label2;
        private Label label6;
        private Label label5;
        private TextBox txt_nombre;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewButtonColumn btn_seleccionar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}