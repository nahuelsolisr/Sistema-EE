namespace SistemaEE.Formularios
{
    partial class Proveedores
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
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            button4 = new Button();
            btn_modi = new Button();
            btn_baja = new Button();
            btn_alta = new Button();
            txt_nombre = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            txt_cuit = new TextBox();
            label1 = new Label();
            btn_salir = new Button();
            txt_mail = new TextBox();
            label3 = new Label();
            txt_domicilio = new TextBox();
            label4 = new Label();
            txt_condicion = new TextBox();
            label7 = new Label();
            dgvProveedor = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column0 = new DataGridViewTextBoxColumn();
            btn_seleccionar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(238, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(13, 415);
            groupBox1.TabIndex = 121;
            groupBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(522, 85);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(178, 27);
            textBox5.TabIndex = 119;
            // 
            // button4
            // 
            button4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(708, 82);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(96, 29);
            button4.TabIndex = 118;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // btn_modi
            // 
            btn_modi.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_modi.Location = new Point(87, 358);
            btn_modi.Margin = new Padding(4);
            btn_modi.Name = "btn_modi";
            btn_modi.Size = new Size(28, 66);
            btn_modi.TabIndex = 117;
            btn_modi.Text = "M";
            btn_modi.UseVisualStyleBackColor = true;
            btn_modi.Click += btn_Modi_Click;
            // 
            // btn_baja
            // 
            btn_baja.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_baja.Location = new Point(49, 358);
            btn_baja.Margin = new Padding(4);
            btn_baja.Name = "btn_baja";
            btn_baja.Size = new Size(30, 66);
            btn_baja.TabIndex = 116;
            btn_baja.Text = "B";
            btn_baja.UseVisualStyleBackColor = true;
            btn_baja.Click += btn_Baja_Click;
            // 
            // btn_alta
            // 
            btn_alta.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_alta.Location = new Point(12, 358);
            btn_alta.Margin = new Padding(4);
            btn_alta.Name = "btn_alta";
            btn_alta.Size = new Size(29, 66);
            btn_alta.TabIndex = 115;
            btn_alta.Text = "A";
            btn_alta.UseVisualStyleBackColor = true;
            btn_alta.Click += btn_Alta_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(13, 145);
            txt_nombre.Margin = new Padding(4);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(216, 27);
            txt_nombre.TabIndex = 110;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 123);
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
            label6.Location = new Point(259, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(193, 19);
            label6.TabIndex = 108;
            label6.Text = "LISTA DE PROVEEDORES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 9);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(205, 19);
            label5.TabIndex = 107;
            label5.Text = "DETALLE DEL PROVEEDOR";
            // 
            // txt_cuit
            // 
            txt_cuit.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cuit.Location = new Point(12, 82);
            txt_cuit.Margin = new Padding(4);
            txt_cuit.Name = "txt_cuit";
            txt_cuit.Size = new Size(216, 27);
            txt_cuit.TabIndex = 106;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 59);
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
            btn_salir.Location = new Point(130, 383);
            btn_salir.Margin = new Padding(4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(100, 41);
            btn_salir.TabIndex = 122;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // txt_mail
            // 
            txt_mail.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_mail.Location = new Point(14, 268);
            txt_mail.Margin = new Padding(4);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(216, 27);
            txt_mail.TabIndex = 127;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 246);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 126;
            label3.Text = "Mail:";
            // 
            // txt_domicilio
            // 
            txt_domicilio.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_domicilio.Location = new Point(13, 205);
            txt_domicilio.Margin = new Padding(4);
            txt_domicilio.Name = "txt_domicilio";
            txt_domicilio.Size = new Size(216, 27);
            txt_domicilio.TabIndex = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 182);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 19);
            label4.TabIndex = 124;
            label4.Text = "Domicilio";
            // 
            // txt_condicion
            // 
            txt_condicion.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_condicion.Location = new Point(14, 321);
            txt_condicion.Margin = new Padding(4);
            txt_condicion.Name = "txt_condicion";
            txt_condicion.Size = new Size(216, 27);
            txt_condicion.TabIndex = 131;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(14, 299);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 19);
            label7.TabIndex = 130;
            label7.Text = "Condición:";
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToResizeColumns = false;
            dgvProveedor.AllowUserToResizeRows = false;
            dgvProveedor.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { btn_seleccionar, Column0, Column1, Column2, Column3, Column4 });
            dgvProveedor.Location = new Point(259, 120);
            dgvProveedor.Margin = new Padding(4);
            dgvProveedor.MultiSelect = false;
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.ReadOnly = true;
            dgvProveedor.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dgvProveedor.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvProveedor.RowTemplate.Height = 25;
            dgvProveedor.Size = new Size(545, 311);
            dgvProveedor.TabIndex = 123;
            dgvProveedor.CellClick += Cell_Click;
            // 
            // Column4
            // 
            Column4.HeaderText = "Condición";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Mail";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Domicilio";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column0
            // 
            Column0.HeaderText = "Cuit";
            Column0.Name = "Column0";
            Column0.ReadOnly = true;
            // 
            // btn_seleccionar
            // 
            btn_seleccionar.HeaderText = "";
            btn_seleccionar.Name = "btn_seleccionar";
            btn_seleccionar.ReadOnly = true;
            btn_seleccionar.Resizable = DataGridViewTriState.False;
            btn_seleccionar.Width = 35;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 444);
            Controls.Add(dgvProveedor);
            Controls.Add(txt_condicion);
            Controls.Add(label7);
            Controls.Add(txt_mail);
            Controls.Add(label3);
            Controls.Add(txt_domicilio);
            Controls.Add(label4);
            Controls.Add(btn_salir);
            Controls.Add(groupBox1);
            Controls.Add(textBox5);
            Controls.Add(button4);
            Controls.Add(btn_modi);
            Controls.Add(btn_baja);
            Controls.Add(btn_alta);
            Controls.Add(txt_nombre);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_cuit);
            Controls.Add(label1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Proveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proveedores";
            Load += Proveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox5;
        private Button button4;
        private Button btn_modi;
        private Button btn_baja;
        private Button btn_alta;
        private TextBox txt_nombre;
        private Label label2;
        private Label label6;
        private Label label5;
        private TextBox txt_cuit;
        private Label label1;
        private Button btn_salir;
        private TextBox txt_mail;
        private Label label3;
        private TextBox txt_domicilio;
        private Label label4;
        private TextBox txt_condicion;
        private Label label7;
        private DataGridView dgvProveedor;
        private DataGridViewButtonColumn btn_seleccionar;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}