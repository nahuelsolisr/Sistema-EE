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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            button4 = new Button();
            Cliente_Modi = new Button();
            Cliente_Baja = new Button();
            Cliente_Alta = new Button();
            txt_nombre = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            txt_cuit = new TextBox();
            label1 = new Label();
            btn_salir = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(241, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(13, 451);
            groupBox1.TabIndex = 121;
            groupBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(517, 68);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(178, 27);
            textBox5.TabIndex = 119;
            // 
            // button4
            // 
            button4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(703, 68);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(96, 29);
            button4.TabIndex = 118;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // Cliente_Modi
            // 
            Cliente_Modi.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cliente_Modi.Location = new Point(116, 423);
            Cliente_Modi.Margin = new Padding(4);
            Cliente_Modi.Name = "Cliente_Modi";
            Cliente_Modi.Size = new Size(43, 41);
            Cliente_Modi.TabIndex = 117;
            Cliente_Modi.Text = "M";
            Cliente_Modi.UseVisualStyleBackColor = true;
            Cliente_Modi.Click += Cliente_Modi_Click;
            // 
            // Cliente_Baja
            // 
            Cliente_Baja.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cliente_Baja.Location = new Point(65, 423);
            Cliente_Baja.Margin = new Padding(4);
            Cliente_Baja.Name = "Cliente_Baja";
            Cliente_Baja.Size = new Size(43, 41);
            Cliente_Baja.TabIndex = 116;
            Cliente_Baja.Text = "B";
            Cliente_Baja.UseVisualStyleBackColor = true;
            Cliente_Baja.Click += Cliente_Baja_Click;
            // 
            // Cliente_Alta
            // 
            Cliente_Alta.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cliente_Alta.Location = new Point(13, 423);
            Cliente_Alta.Margin = new Padding(4);
            Cliente_Alta.Name = "Cliente_Alta";
            Cliente_Alta.Size = new Size(44, 41);
            Cliente_Alta.TabIndex = 115;
            Cliente_Alta.Text = "A";
            Cliente_Alta.UseVisualStyleBackColor = true;
            Cliente_Alta.Click += Cliente_Alta_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(16, 139);
            txt_nombre.Margin = new Padding(4);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(216, 27);
            txt_nombre.TabIndex = 110;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 117);
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
            label6.Location = new Point(262, 11);
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
            label5.Location = new Point(15, 11);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(176, 19);
            label5.TabIndex = 107;
            label5.Text = "DETALLE DEL CLIENTE";
            // 
            // txt_cuit
            // 
            txt_cuit.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cuit.Location = new Point(15, 76);
            txt_cuit.Margin = new Padding(4);
            txt_cuit.Name = "txt_cuit";
            txt_cuit.Size = new Size(216, 27);
            txt_cuit.TabIndex = 106;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 105;
            label1.Text = "Cuit:";
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Firebrick;
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salir.ForeColor = Color.FromArgb(254, 252, 230);
            btn_salir.Location = new Point(167, 423);
            btn_salir.Margin = new Padding(4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(66, 41);
            btn_salir.TabIndex = 122;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToResizeColumns = false;
            dgvCliente.AllowUserToResizeRows = false;
            dgvCliente.BackgroundColor = Color.White;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { btn_seleccionar, Column0, Column1, Column2, Column3, Column4 });
            dgvCliente.Location = new Point(261, 105);
            dgvCliente.Margin = new Padding(4);
            dgvCliente.MultiSelect = false;
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = Color.Transparent;
            dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.Size = new Size(538, 357);
            dgvCliente.TabIndex = 124;
            dgvCliente.CellClick += Cell_Click;
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.HeaderText = "";
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.ReadOnly = true;
            btn_seleccionar.Resizable = DataGridViewTriState.False;
            btn_seleccionar.Width = 35;
            // 
            // Column0
            // 
            Column0.HeaderText = "Cuit";
            Column0.Name = "Column0";
            Column0.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Dirección";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Mail";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Condición";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // txt_mail
            // 
            txt_mail.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_mail.Location = new Point(17, 261);
            txt_mail.Margin = new Padding(4);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(216, 27);
            txt_mail.TabIndex = 128;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 239);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 127;
            label3.Text = "Mail:";
            // 
            // txt_direccion
            // 
            txt_direccion.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_direccion.Location = new Point(16, 198);
            txt_direccion.Margin = new Padding(4);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(216, 27);
            txt_direccion.TabIndex = 126;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 175);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 19);
            label4.TabIndex = 125;
            label4.Text = "Dirección:";
            // 
            // txt_condicion
            // 
            txt_condicion.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_condicion.Location = new Point(17, 324);
            txt_condicion.Margin = new Padding(4);
            txt_condicion.Name = "txt_condicion";
            txt_condicion.Size = new Size(216, 27);
            txt_condicion.TabIndex = 130;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(20, 302);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 19);
            label7.TabIndex = 129;
            label7.Text = "Condición:";
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 477);
            Controls.Add(txt_condicion);
            Controls.Add(label7);
            Controls.Add(txt_mail);
            Controls.Add(label3);
            Controls.Add(txt_direccion);
            Controls.Add(label4);
            Controls.Add(dgvCliente);
            Controls.Add(Cliente_Modi);
            Controls.Add(btn_salir);
            Controls.Add(groupBox1);
            Controls.Add(textBox5);
            Controls.Add(button4);
            Controls.Add(Cliente_Baja);
            Controls.Add(Cliente_Alta);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox5;
        private Button button4;
        private Button Cliente_Modi;
        private Button Cliente_Baja;
        private Button Cliente_Alta;
        private TextBox txt_nombre;
        private Label label2;
        private Label label6;
        private Label label5;
        private TextBox txt_cuit;
        private Label label1;
        private Button btn_salir;
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
    }
}