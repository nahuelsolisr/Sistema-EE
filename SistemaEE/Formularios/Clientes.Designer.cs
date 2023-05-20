namespace SistemaEE.Formularios
{
    partial class Clientes
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
            txt_nombre = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            txt_cuit = new TextBox();
            label1 = new Label();
            dgvCliente = new DataGridView();
            btn_seleccionar = new DataGridViewButtonColumn();
            Column0 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txt_mail = new TextBox();
            label3 = new Label();
            txt_direccion = new TextBox();
            label4 = new Label();
            txt_condicion = new TextBox();
            label7 = new Label();
            txt_filtrarGrilla = new TextBox();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btn_salir = new FontAwesome.Sharp.IconButton();
            btn_baja = new FontAwesome.Sharp.IconButton();
            btn_alta = new FontAwesome.Sharp.IconButton();
            btn_modi = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            SuspendLayout();
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(49, 148);
            txt_nombre.Margin = new Padding(4);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(216, 27);
            txt_nombre.TabIndex = 110;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 126);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 109;
            label2.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(308, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(155, 19);
            label6.TabIndex = 108;
            label6.Text = "LISTA DE CLIENTES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 9);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(176, 19);
            label5.TabIndex = 107;
            label5.Text = "DETALLE DEL CLIENTE";
            // 
            // txt_cuit
            // 
            txt_cuit.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cuit.Location = new Point(49, 92);
            txt_cuit.Margin = new Padding(4);
            txt_cuit.Name = "txt_cuit";
            txt_cuit.Size = new Size(216, 27);
            txt_cuit.TabIndex = 106;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 105;
            label1.Text = "Cuit:";
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToResizeColumns = false;
            dgvCliente.AllowUserToResizeRows = false;
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCliente.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { btn_seleccionar, Column0, Column1, Column2, Column3, Column4 });
            dgvCliente.Location = new Point(308, 92);
            dgvCliente.Margin = new Padding(4);
            dgvCliente.MultiSelect = false;
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.Size = new Size(725, 482);
            dgvCliente.TabIndex = 124;
            dgvCliente.CellClick += Cell_Click;
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.HeaderText = "";
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.ReadOnly = true;
            btn_seleccionar.Resizable = DataGridViewTriState.False;
            btn_seleccionar.Width = 25;
            // 
            // Column0
            // 
            Column0.HeaderText = "Cuit";
            Column0.Name = "Column0";
            Column0.ReadOnly = true;
            Column0.Width = 66;
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
            Column2.HeaderText = "Dirección";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 103;
            // 
            // Column3
            // 
            Column3.HeaderText = "Mail";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 66;
            // 
            // Column4
            // 
            Column4.HeaderText = "Condición";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 108;
            // 
            // txt_mail
            // 
            txt_mail.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_mail.Location = new Point(49, 259);
            txt_mail.Margin = new Padding(4);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(216, 27);
            txt_mail.TabIndex = 128;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 236);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 127;
            label3.Text = "Mail:";
            // 
            // txt_direccion
            // 
            txt_direccion.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_direccion.Location = new Point(49, 204);
            txt_direccion.Margin = new Padding(4);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(216, 27);
            txt_direccion.TabIndex = 126;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 181);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 19);
            label4.TabIndex = 125;
            label4.Text = "Dirección:";
            // 
            // txt_condicion
            // 
            txt_condicion.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_condicion.Location = new Point(49, 315);
            txt_condicion.Margin = new Padding(4);
            txt_condicion.Name = "txt_condicion";
            txt_condicion.Size = new Size(216, 27);
            txt_condicion.TabIndex = 130;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(43, 292);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 19);
            label7.TabIndex = 129;
            label7.Text = "Condición:";
            // 
            // txt_filtrarGrilla
            // 
            txt_filtrarGrilla.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_filtrarGrilla.Location = new Point(662, 48);
            txt_filtrarGrilla.Margin = new Padding(4);
            txt_filtrarGrilla.Name = "txt_filtrarGrilla";
            txt_filtrarGrilla.Size = new Size(318, 36);
            txt_filtrarGrilla.TabIndex = 136;
            txt_filtrarGrilla.TextChanged += txt_filtrarGrilla_TextChanged;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.WhiteSmoke;
            iconPictureBox6.ForeColor = SystemColors.ControlText;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox6.IconColor = SystemColors.ControlText;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 27;
            iconPictureBox6.Location = new Point(17, 148);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(31, 27);
            iconPictureBox6.TabIndex = 145;
            iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.WhiteSmoke;
            iconPictureBox5.ForeColor = SystemColors.ControlText;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            iconPictureBox5.IconColor = SystemColors.ControlText;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 27;
            iconPictureBox5.Location = new Point(17, 315);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(31, 27);
            iconPictureBox5.TabIndex = 144;
            iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.WhiteSmoke;
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 27;
            iconPictureBox3.Location = new Point(17, 92);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(31, 27);
            iconPictureBox3.TabIndex = 143;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.WhiteSmoke;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 27;
            iconPictureBox2.Location = new Point(17, 204);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(31, 27);
            iconPictureBox2.TabIndex = 142;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.EnvelopeSquare;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 27;
            iconPictureBox1.Location = new Point(17, 259);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(31, 27);
            iconPictureBox1.TabIndex = 141;
            iconPictureBox1.TabStop = false;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salir.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            btn_salir.IconColor = Color.Black;
            btn_salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_salir.IconSize = 25;
            btn_salir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salir.Location = new Point(19, 550);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(118, 42);
            btn_salir.TabIndex = 149;
            btn_salir.Text = "Salir";
            btn_salir.TextAlign = ContentAlignment.MiddleRight;
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click_1;
            // 
            // btn_baja
            // 
            btn_baja.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_baja.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            btn_baja.IconColor = Color.Black;
            btn_baja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_baja.ImageAlign = ContentAlignment.MiddleLeft;
            btn_baja.Location = new Point(18, 424);
            btn_baja.Name = "btn_baja";
            btn_baja.Size = new Size(248, 55);
            btn_baja.TabIndex = 148;
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
            btn_alta.Location = new Point(18, 363);
            btn_alta.Name = "btn_alta";
            btn_alta.Size = new Size(248, 55);
            btn_alta.TabIndex = 147;
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
            btn_modi.Location = new Point(18, 485);
            btn_modi.Name = "btn_modi";
            btn_modi.Size = new Size(248, 55);
            btn_modi.TabIndex = 146;
            btn_modi.Text = "Modificar";
            btn_modi.TextAlign = ContentAlignment.MiddleRight;
            btn_modi.UseVisualStyleBackColor = true;
            btn_modi.Click += btn_modi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(273, 9);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(27, 579);
            groupBox1.TabIndex = 150;
            groupBox1.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.WhiteSmoke;
            iconPictureBox4.ForeColor = SystemColors.ControlText;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox4.IconColor = SystemColors.ControlText;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 36;
            iconPictureBox4.Location = new Point(987, 48);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(42, 36);
            iconPictureBox4.TabIndex = 151;
            iconPictureBox4.TabStop = false;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
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
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox1);
            Controls.Add(txt_filtrarGrilla);
            Controls.Add(txt_condicion);
            Controls.Add(label7);
            Controls.Add(txt_mail);
            Controls.Add(label3);
            Controls.Add(txt_direccion);
            Controls.Add(label4);
            Controls.Add(dgvCliente);
            Controls.Add(txt_nombre);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_cuit);
            Controls.Add(label1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_nombre;
        private Label label2;
        private Label label6;
        private Label label5;
        private TextBox txt_cuit;
        private Label label1;
        private DataGridView dgvCliente;
        private DataGridViewButtonColumn btn_seleccionar;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox txt_mail;
        private Label label3;
        private TextBox txt_direccion;
        private Label label4;
        private TextBox txt_condicion;
        private Label label7;
        private TextBox txt_filtrarGrilla;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btn_salir;
        private FontAwesome.Sharp.IconButton btn_baja;
        private FontAwesome.Sharp.IconButton btn_alta;
        private FontAwesome.Sharp.IconButton btn_modi;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
    }
}