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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            btn_salir = new Button();
            dgvProveedor = new DataGridView();
            btn_seleccionar = new DataGridViewButtonColumn();
            Column0 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(262, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(10, 471);
            groupBox1.TabIndex = 121;
            groupBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(600, 76);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 23);
            textBox5.TabIndex = 119;
            // 
            // button4
            // 
            button4.Location = new Point(745, 76);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 118;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(23, 438);
            button3.Name = "button3";
            button3.Size = new Size(215, 52);
            button3.TabIndex = 117;
            button3.Text = "M";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(22, 380);
            button2.Name = "button2";
            button2.Size = new Size(215, 52);
            button2.TabIndex = 116;
            button2.Text = "B";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(22, 322);
            button1.Name = "button1";
            button1.Size = new Size(215, 52);
            button1.TabIndex = 115;
            button1.Text = "A";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(22, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 20);
            textBox2.TabIndex = 110;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 137);
            label2.Name = "label2";
            label2.Size = new Size(35, 13);
            label2.TabIndex = 109;
            label2.Text = "label2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(322, 31);
            label6.Name = "label6";
            label6.Size = new Size(174, 15);
            label6.TabIndex = 108;
            label6.Text = "LISTA DE PROVEEDORES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(22, 31);
            label5.Name = "label5";
            label5.Size = new Size(187, 15);
            label5.TabIndex = 107;
            label5.Text = "DETALLE DEL PROVEEDOR";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(21, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 20);
            textBox1.TabIndex = 106;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 87);
            label1.Name = "label1";
            label1.Size = new Size(35, 13);
            label1.TabIndex = 105;
            label1.Text = "label1";
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Firebrick;
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salir.ForeColor = Color.FromArgb(254, 252, 230);
            btn_salir.Location = new Point(713, 481);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(107, 32);
            btn_salir.TabIndex = 122;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToResizeColumns = false;
            dgvProveedor.AllowUserToResizeRows = false;
            dgvProveedor.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { btn_seleccionar, Column0, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dgvProveedor.Location = new Point(291, 105);
            dgvProveedor.MultiSelect = false;
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.ReadOnly = true;
            dgvProveedor.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dgvProveedor.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvProveedor.RowTemplate.Height = 25;
            dgvProveedor.Size = new Size(538, 344);
            dgvProveedor.TabIndex = 123;
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Condición";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 525);
            Controls.Add(dgvProveedor);
            Controls.Add(btn_salir);
            Controls.Add(groupBox1);
            Controls.Add(textBox5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Proveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label label6;
        private Label label5;
        private TextBox textBox1;
        private Label label1;
        private Button btn_salir;
        private DataGridView dgvProveedor;
        private DataGridViewButtonColumn btn_seleccionar;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}