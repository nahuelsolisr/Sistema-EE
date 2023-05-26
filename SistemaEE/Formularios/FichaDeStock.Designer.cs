namespace SistemaEE.Formularios
{
    partial class FichaDeStock
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
            dgvFichaStock = new DataGridView();
            Column0 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            idProductoGrilla = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            txt_filtrarGrilla = new TextBox();
            btn_salir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvFichaStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dgvFichaStock
            // 
            dgvFichaStock.AllowUserToResizeColumns = false;
            dgvFichaStock.AllowUserToResizeRows = false;
            dgvFichaStock.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFichaStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFichaStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFichaStock.Columns.AddRange(new DataGridViewColumn[] { Column0, Column1, idProductoGrilla, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            dgvFichaStock.Location = new Point(12, 134);
            dgvFichaStock.MultiSelect = false;
            dgvFichaStock.Name = "dgvFichaStock";
            dgvFichaStock.ReadOnly = true;
            dgvFichaStock.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dgvFichaStock.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvFichaStock.RowTemplate.Height = 25;
            dgvFichaStock.Size = new Size(1207, 403);
            dgvFichaStock.TabIndex = 105;
            // 
            // Column0
            // 
            Column0.HeaderText = "Fecha";
            Column0.Name = "Column0";
            Column0.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Producto";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // idProductoGrilla
            // 
            idProductoGrilla.HeaderText = "idProducto";
            idProductoGrilla.Name = "idProductoGrilla";
            idProductoGrilla.ReadOnly = true;
            idProductoGrilla.Visible = false;
            // 
            // Column2
            // 
            Column2.HeaderText = "Concepto";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Unidades";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Prec. Unit.";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Unidades";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Prec. Unit.";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Total";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Unidades";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "Prec. Unit.";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.HeaderText = "Total";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightGreen;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(418, 112);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 19);
            label9.TabIndex = 190;
            label9.Text = "ENTRADA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSalmon;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(717, 112);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 191;
            label1.Text = "SALIDA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightBlue;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1020, 112);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 192;
            label2.Text = "EXISTENCIA";
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.WhiteSmoke;
            iconPictureBox5.ForeColor = SystemColors.ControlText;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox5.IconColor = SystemColors.ControlText;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 36;
            iconPictureBox5.Location = new Point(1166, 12);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(42, 36);
            iconPictureBox5.TabIndex = 194;
            iconPictureBox5.TabStop = false;
            // 
            // txt_filtrarGrilla
            // 
            txt_filtrarGrilla.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_filtrarGrilla.Location = new Point(842, 12);
            txt_filtrarGrilla.Name = "txt_filtrarGrilla";
            txt_filtrarGrilla.Size = new Size(318, 36);
            txt_filtrarGrilla.TabIndex = 193;
            // 
            // btn_salir
            // 
            btn_salir.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salir.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            btn_salir.IconColor = Color.Black;
            btn_salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_salir.IconSize = 25;
            btn_salir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salir.Location = new Point(12, 543);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(115, 46);
            btn_salir.TabIndex = 195;
            btn_salir.Text = "Salir";
            btn_salir.TextAlign = ContentAlignment.MiddleRight;
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // FichaDeStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 601);
            ControlBox = false;
            Controls.Add(btn_salir);
            Controls.Add(iconPictureBox5);
            Controls.Add(txt_filtrarGrilla);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(dgvFichaStock);
            Name = "FichaDeStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)dgvFichaStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFichaStock;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn idProductoGrilla;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private Label label9;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private TextBox txt_filtrarGrilla;
        private FontAwesome.Sharp.IconButton btn_salir;
    }
}