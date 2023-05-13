namespace SistemaEE.Formularios
{
    partial class Entrada
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
            txt_categoria = new TextBox();
            label2 = new Label();
            txt_nombre = new TextBox();
            label1 = new Label();
            btn_TraerProveedor = new Button();
            btn_TraerProducto = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txt_categoria
            // 
            txt_categoria.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_categoria.Location = new Point(163, 47);
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(144, 20);
            txt_categoria.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(163, 29);
            label2.Name = "label2";
            label2.Size = new Size(96, 13);
            label2.TabIndex = 13;
            label2.Text = "Nombre Proveedor";
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(12, 47);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(145, 20);
            txt_nombre.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(82, 13);
            label1.TabIndex = 11;
            label1.Text = "Doc. Proveedor";
            // 
            // btn_TraerProveedor
            // 
            btn_TraerProveedor.Location = new Point(324, 40);
            btn_TraerProveedor.Name = "btn_TraerProveedor";
            btn_TraerProveedor.Size = new Size(50, 27);
            btn_TraerProveedor.TabIndex = 116;
            btn_TraerProveedor.Text = "Buscar";
            btn_TraerProveedor.UseVisualStyleBackColor = true;
            btn_TraerProveedor.Click += btn_TraerProveedor_Click;
            // 
            // btn_TraerProducto
            // 
            btn_TraerProducto.Location = new Point(324, 107);
            btn_TraerProducto.Name = "btn_TraerProducto";
            btn_TraerProducto.Size = new Size(50, 27);
            btn_TraerProducto.TabIndex = 121;
            btn_TraerProducto.Text = "Buscar";
            btn_TraerProducto.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(163, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 20);
            textBox1.TabIndex = 120;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(163, 96);
            label3.Name = "label3";
            label3.Size = new Size(90, 13);
            label3.TabIndex = 119;
            label3.Text = "Nombre Producto";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 20);
            textBox2.TabIndex = 118;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(86, 13);
            label4.TabIndex = 117;
            label4.Text = "Codigo Producto";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(389, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(52, 20);
            textBox3.TabIndex = 123;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(389, 96);
            label5.Name = "label5";
            label5.Size = new Size(37, 13);
            label5.TabIndex = 122;
            label5.Text = "Precio";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(462, 114);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(62, 20);
            textBox4.TabIndex = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(462, 98);
            label6.Name = "label6";
            label6.Size = new Size(62, 13);
            label6.TabIndex = 124;
            label6.Text = "% ganancia";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(549, 111);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(57, 23);
            numericUpDown1.TabIndex = 126;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(549, 95);
            label7.Name = "label7";
            label7.Size = new Size(48, 13);
            label7.TabIndex = 127;
            label7.Text = "cantidad";
            // 
            // button3
            // 
            button3.Location = new Point(627, 107);
            button3.Name = "button3";
            button3.Size = new Size(110, 27);
            button3.TabIndex = 128;
            button3.Text = "Añadir al carrito";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(795, 294);
            dataGridView1.TabIndex = 129;
            // 
            // Entrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 472);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(btn_TraerProducto);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(btn_TraerProveedor);
            Controls.Add(txt_categoria);
            Controls.Add(label2);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Name = "Entrada";
            Text = "Entrada";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_categoria;
        private Label label2;
        private TextBox txt_nombre;
        private Label label1;
        private Button btn_TraerProveedor;
        private Button btn_TraerProducto;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private Button button3;
        private DataGridView dataGridView1;
    }
}