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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvFichaStock = new DataGridView();
            Column0 = new DataGridViewTextBoxColumn();
            idProductoGrilla = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFichaStock).BeginInit();
            SuspendLayout();
            // 
            // dgvFichaStock
            // 
            dgvFichaStock.AllowUserToResizeColumns = false;
            dgvFichaStock.AllowUserToResizeRows = false;
            dgvFichaStock.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvFichaStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvFichaStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFichaStock.Columns.AddRange(new DataGridViewColumn[] { Column0, idProductoGrilla, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dgvFichaStock.Location = new Point(9, 12);
            dgvFichaStock.MultiSelect = false;
            dgvFichaStock.Name = "dgvFichaStock";
            dgvFichaStock.ReadOnly = true;
            dgvFichaStock.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = Color.Transparent;
            dgvFichaStock.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvFichaStock.RowTemplate.Height = 25;
            dgvFichaStock.Size = new Size(1104, 392);
            dgvFichaStock.TabIndex = 105;
            // 
            // Column0
            // 
            Column0.HeaderText = "Fecha";
            Column0.Name = "Column0";
            Column0.ReadOnly = true;
            // 
            // idProductoGrilla
            // 
            idProductoGrilla.HeaderText = "idProducto";
            idProductoGrilla.Name = "idProductoGrilla";
            idProductoGrilla.ReadOnly = true;
            idProductoGrilla.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Concepto";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Unidades";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Prec. Unit.";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Total";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Unidades";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Prec. Unit.";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Total";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Unidades";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Prec. Unit.";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "Total";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // FichaDeStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 423);
            Controls.Add(dgvFichaStock);
            Name = "FichaDeStock";
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)dgvFichaStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFichaStock;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewTextBoxColumn idProductoGrilla;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}